This project generates TimeZoneRepositoryInternal.cs

To update the IDs from the CLDR project, download the latest data core.zip file from:
http://cldr.unicode.org/index/downloads
Extract the zip file, and grab /core/common/bcp47/timezone.xml
and paste the content into:
/Cldr/common/bcp47/timezone.xml

To update the time zone/country mappings, download the data from your Google Calendar:
https://www.google.com/calendar/fetchTZ
(Note: you need to be logged in to your Google Calendar)
then copy and paste the content into:
/GoogleCalendar/fetchTZ

To update the country list, download the latest csv from GeoNames:
http://download.geonames.org/export/dump/countryInfo.txt
then place copy and paste the content into:
/GeoNames/countryInfo.txt

** the list of countries displayed in google calendar is in the precompiled js file:
https://www.google.com/calendar/static/37f646aca09da1a6beea27cb4b653cf0calendarjs_eventformcompiled__en.js
but that's harder to parse than CSV so for now we use GeoNames

Then run this project, which will generate the code into a temp file, 
  then it will open the temp file in notepad.  Copy and paste the conten 
  from that code file into the TimeZones project:
  TimeZoneRepositoryInternal.cs