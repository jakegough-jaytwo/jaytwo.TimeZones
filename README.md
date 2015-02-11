# jaytwo.TimeZones

A library built on top of NodaTime to make working with time zones a little easier.

## Installation

Get the nuget package: jaytwo.TimeZones

The package contains binaries for .NET frameworks: `3.5`/`4.0`/`4.5.`.

### Pro Tips:

For your own sanity....

- Store evrything in UTC.  Work with UTC everywhere you can in your code.
- Include Utc in your variable names and database columns to remove any question.
- If you're working with a local time, include context with your names. In a CRM system, `userLocalStartTime` is not the same as `clientLocalStartTime`.
- Use only Unix/Tzdb/Olson time zones.  Don't even bother with Windows Time zones.  The battle ended, and windows lost.
- Don't try to imply meaning with `DateTimeKind.Utc` vs `DateTimeKind.Local`.  If you have trouble with (de)serialization, look at DateTimeKind first.

## Highlights

### TimeZoneUtility

```cs
using jaytwo.TimeZones
...

// supply UTC time and it returns a translated date/time for the target time zone
TimeZoneUtility.UtcToLocalTime(DateTime.UtcNow, "America/New_York"); // returns current time in New York

// supply UTC time and translates it to the supplied target time zone
TimeZoneUtility.LocalTimeToUtc(new DateTime("2015-01-15T17:00"), "America/New_York"); // returns 2015-01-15T22:00 (winter time / no daylight saving)

TimeZoneUtility.LocalTimeToUtc(new DateTime("2015-06-15T17:00"), "America/New_York"); // returns 2015-06-15T21:00 (summer time / daylight saving)

// supply local time with zone and translates it to the target time zone
TimeZoneUtility.ConvertTimeZone(new DateTime("2015-01-15T17:00"), "America/Denver", "America/New_York"); // returns 2015-01-15T19:00

// check whether a given time zone observes daylight saving time
TimeZoneUtility.TimeZoneObservesDaylightSavingTime("usnyc"); // returns true
TimeZoneUtility.TimeZoneObservesDaylightSavingTime("utc"); // returns false

// if you need to work with NodaTime's ZonedDateTime
TimeZoneUtility.LocalTimeToZonedDateTime(new DateTime("2015-01-15T17:00"), "America/New_York");
TimeZoneUtility.UtcToZonedDateTime(new DateTime("2015-01-15T17:00"));

```

### Extension Methods

I keep extension methods in the `jaytwo.Common.Extensions` namespace.  These are intented to complement existing extensions found in my `jaytwo.Common` library.

#### To/From UTC

```cs
using jaytwo.Common.Extensions
...

// (winter time / no daylight saving)
new DateTime("2015-01-15T22:00").UtcToLocalTime("America/New_York"); //returns 2015-01-15T17:00
new DateTime("2015-01-15T17:00").LocalTimeToUtc("America/New_York"); //returns 2015-01-15T22:00

// (summer time / daylight saving)
new DateTime("2015-06-15T21:00").UtcToLocalTime("America/New_York"); //returns 2015-06-15T17:00
new DateTime("2015-06-15T17:00").LocalTimeToUtc("America/New_York"); //returns 2015-06-15T21:00
```

#### Truncation

Sometimes it can cause problems if one system is more precise with time than another.   `System.DateTime` truncation is actually in my `jaytwo.Common` library, but `NodaTime.ZonedDateTime` extensions are here in the `jaytwo.TimeZones` library.  Regardless of the library, they're all in the `jaytwo.Common.Extensions` namespace.

```cs
using jaytwo.Common.Extensions
...

new DateTime("2015-01-15T12:34:56.789").TruncateToSecondPrecision(); //returns 2015-01-15T12:34:56.000

new DateTime("2015-01-15T12:34:56.789").TruncateToMinutePrecision(); //returns 2015-01-15T12:34:00.000
```

## TimeZoneRepository

When you build an application where users will be selecting their own time zones, then 
you're probably going to be providing the options with one or two dropdown boxes.  

This  usually means one of two things: 1) You put the entire 300+ item canon of Olson time zones in a single drop down list and let the user figure it out, or 2) You maintain time zone and country tables in a database.  I wasn't satisfied with either option.

Users are overwhelmed (or at least confused) when you drop the whole time zone database in their face.  Nearly all of my users just want to pick Pacific, Mountain,  Central, or Eastern.

Database tables over different projects is a maintenance nightmare, plus every time you visit the time zone problem you think of a new way to store the selected time zone while preserving the country selection.

People smarter than me have already thought through all this:

- Tzdb defines names and timekeeping rules for every time zone.
- NodaTime does all the heavy lifting translating between time zones and accounting for daylight saving, etc.
- Google provides a nice interface in Google Calendar for selecting a time zone by country.  
- Unicode's CLDR project maintains a list of immutable keys for each time zone in the tzdb.

Enter `TimeZoneRepository`.

The `TimeZoneRepository.Default` instance contains a list of time zones and countries that is coded into the assembly.  In the Visual Studio solution, the `CodeGen` project creates

```cs
using jaytwo.TimeZones
...

// returns a list of countries that Google Calendar maps to a time zone
TimeZoneRepository.Default.GetCountries();

// returns a list of time zones that Google Calendar maps to a given country
TimeZoneRepository.Default.GetTimeZonesByCountryId(selectedCountry);
```

Here is sample definitions for `CountryListItem` and `TimeZoneListItem`:
```cs
...
yield return new CountryListItem()
{
    Id = "US",
    Name = "United States",
};
....
yield return new TimeZoneListItem()
{
    Id = "usden",
    CldrTimeZoneKey = "usden",
    CountryId = "US",
    CountryName = "United States",
    IsAssignedToCountry = true,
    OlsonTimeZone = "America/Denver",
    DisplayName = "(GMT-07:00) Mountain Time",
    DisplayNameWithCountry = "United States - (GMT-07:00) Mountain Time",
    StandardOffset = "-07:00",
    DisplayNameWithoutOffset = "Mountain Time",
};
....
```

You only need to store the time zone's `Id`, `usden`.  From this you can look up the country (`US`), and the Olson time zone (`America/Denver`).  

Most of the time the `Id` will be the `CldrTimeZoneKey`.  But not always:

```cs
yield return new TimeZoneListItem()
{
    Id = "ushnl_um",
    CldrTimeZoneKey = "ushnl",
    CountryId = "UM",
    CountryName = "United States Minor Outlying Islands",
    IsAssignedToCountry = true,
    OlsonTimeZone = "Pacific/Honolulu",
    DisplayName = "(GMT-10:00) Hawaii Time",
    DisplayNameWithCountry = "United States Minor Outlying Islands - (GMT-10:00) Hawaii Time",
    StandardOffset = "-10:00",
    DisplayNameWithoutOffset = "Hawaii Time",
};
```

In cases like this, the `Id` is the `CldrTimeZoneKey` suffixed with the lower-cased `CountryId`.

If you're creating a database table to store the time zone id, you're probably safe with a `VARCHAR(15)`.  ~76% of the ids are 5 characters or less.  ~99.7% of the keys are 8 characters or less.   At the time of this writing, the longest `CldrTimeZoneKey` in the list is 8 characters long.   If we had to suffix that with an underscore and a 2-digit country ISO codo, that brings us to a potential 11 characters.
