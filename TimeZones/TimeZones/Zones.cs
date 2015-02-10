// auto generated Thursday, February 05, 2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaytwo.TimeZones
{
	public static class Zones
	{
		public static IList<TimeZoneLocation> AllZones { get; private set; }
		public static IDictionary<string, TimeZoneLocation> IdMap { get; private set; }

		static Zones()
		{
			var allZones = new List<TimeZoneLocation>();
			var idMap = new Dictionary<string, TimeZoneLocation>();

			allZones.Add(AD_Europe_Andorra);
			idMap.Add(AD_Europe_Andorra.Id, AD_Europe_Andorra);

			allZones.Add(AE_Asia_Dubai);
			idMap.Add(AE_Asia_Dubai.Id, AE_Asia_Dubai);

			allZones.Add(AF_Asia_Kabul);
			idMap.Add(AF_Asia_Kabul.Id, AF_Asia_Kabul);

			allZones.Add(AG_America_Antigua);
			idMap.Add(AG_America_Antigua.Id, AG_America_Antigua);

			allZones.Add(AI_America_Port_of_Spain);
			idMap.Add(AI_America_Port_of_Spain.Id, AI_America_Port_of_Spain);

			allZones.Add(AL_Europe_Tirane);
			idMap.Add(AL_Europe_Tirane.Id, AL_Europe_Tirane);

			allZones.Add(AM_Asia_Yerevan);
			idMap.Add(AM_Asia_Yerevan.Id, AM_Asia_Yerevan);

			allZones.Add(AN_America_Curacao);
			idMap.Add(AN_America_Curacao.Id, AN_America_Curacao);

			allZones.Add(AO_Africa_Lagos);
			idMap.Add(AO_Africa_Lagos.Id, AO_Africa_Lagos);

			allZones.Add(AQ_Antarctica_Palmer);
			idMap.Add(AQ_Antarctica_Palmer.Id, AQ_Antarctica_Palmer);

			allZones.Add(AQ_Antarctica_Rothera);
			idMap.Add(AQ_Antarctica_Rothera.Id, AQ_Antarctica_Rothera);

			allZones.Add(AQ_Antarctica_Syowa);
			idMap.Add(AQ_Antarctica_Syowa.Id, AQ_Antarctica_Syowa);

			allZones.Add(AQ_Antarctica_Mawson);
			idMap.Add(AQ_Antarctica_Mawson.Id, AQ_Antarctica_Mawson);

			allZones.Add(AQ_Antarctica_Vostok);
			idMap.Add(AQ_Antarctica_Vostok.Id, AQ_Antarctica_Vostok);

			allZones.Add(AQ_Antarctica_Davis);
			idMap.Add(AQ_Antarctica_Davis.Id, AQ_Antarctica_Davis);

			allZones.Add(AQ_Antarctica_Casey);
			idMap.Add(AQ_Antarctica_Casey.Id, AQ_Antarctica_Casey);

			allZones.Add(AQ_Antarctica_DumontDUrville);
			idMap.Add(AQ_Antarctica_DumontDUrville.Id, AQ_Antarctica_DumontDUrville);

			allZones.Add(AQ_Pacific_Auckland);
			idMap.Add(AQ_Pacific_Auckland.Id, AQ_Pacific_Auckland);

			allZones.Add(AR_America_Argentina_Buenos_Aires);
			idMap.Add(AR_America_Argentina_Buenos_Aires.Id, AR_America_Argentina_Buenos_Aires);

			allZones.Add(AS_Pacific_Pago_Pago);
			idMap.Add(AS_Pacific_Pago_Pago.Id, AS_Pacific_Pago_Pago);

			allZones.Add(AT_Europe_Vienna);
			idMap.Add(AT_Europe_Vienna.Id, AT_Europe_Vienna);

			allZones.Add(AU_Australia_Perth);
			idMap.Add(AU_Australia_Perth.Id, AU_Australia_Perth);

			allZones.Add(AU_Australia_Adelaide);
			idMap.Add(AU_Australia_Adelaide.Id, AU_Australia_Adelaide);

			allZones.Add(AU_Australia_Darwin);
			idMap.Add(AU_Australia_Darwin.Id, AU_Australia_Darwin);

			allZones.Add(AU_Australia_Brisbane);
			idMap.Add(AU_Australia_Brisbane.Id, AU_Australia_Brisbane);

			allZones.Add(AU_Australia_Hobart);
			idMap.Add(AU_Australia_Hobart.Id, AU_Australia_Hobart);

			allZones.Add(AU_Australia_Sydney);
			idMap.Add(AU_Australia_Sydney.Id, AU_Australia_Sydney);

			allZones.Add(AW_America_Curacao);
			idMap.Add(AW_America_Curacao.Id, AW_America_Curacao);

			allZones.Add(AX_Europe_Helsinki);
			idMap.Add(AX_Europe_Helsinki.Id, AX_Europe_Helsinki);

			allZones.Add(AZ_Asia_Baku);
			idMap.Add(AZ_Asia_Baku.Id, AZ_Asia_Baku);

			allZones.Add(BA_Europe_Belgrade);
			idMap.Add(BA_Europe_Belgrade.Id, BA_Europe_Belgrade);

			allZones.Add(BB_America_Barbados);
			idMap.Add(BB_America_Barbados.Id, BB_America_Barbados);

			allZones.Add(BD_Asia_Dhaka);
			idMap.Add(BD_Asia_Dhaka.Id, BD_Asia_Dhaka);

			allZones.Add(BE_Europe_Brussels);
			idMap.Add(BE_Europe_Brussels.Id, BE_Europe_Brussels);

			allZones.Add(BF_Africa_Abidjan);
			idMap.Add(BF_Africa_Abidjan.Id, BF_Africa_Abidjan);

			allZones.Add(BG_Europe_Sofia);
			idMap.Add(BG_Europe_Sofia.Id, BG_Europe_Sofia);

			allZones.Add(BH_Asia_Bahrain);
			idMap.Add(BH_Asia_Bahrain.Id, BH_Asia_Bahrain);

			allZones.Add(BI_Africa_Maputo);
			idMap.Add(BI_Africa_Maputo.Id, BI_Africa_Maputo);

			allZones.Add(BJ_Africa_Lagos);
			idMap.Add(BJ_Africa_Lagos.Id, BJ_Africa_Lagos);

			allZones.Add(BM_Atlantic_Bermuda);
			idMap.Add(BM_Atlantic_Bermuda.Id, BM_Atlantic_Bermuda);

			allZones.Add(BN_Asia_Brunei);
			idMap.Add(BN_Asia_Brunei.Id, BN_Asia_Brunei);

			allZones.Add(BO_America_La_Paz);
			idMap.Add(BO_America_La_Paz.Id, BO_America_La_Paz);

			allZones.Add(BQ_America_Curacao);
			idMap.Add(BQ_America_Curacao.Id, BQ_America_Curacao);

			allZones.Add(BR_America_Rio_Branco);
			idMap.Add(BR_America_Rio_Branco.Id, BR_America_Rio_Branco);

			allZones.Add(BR_America_Boa_Vista);
			idMap.Add(BR_America_Boa_Vista.Id, BR_America_Boa_Vista);

			allZones.Add(BR_America_Campo_Grande);
			idMap.Add(BR_America_Campo_Grande.Id, BR_America_Campo_Grande);

			allZones.Add(BR_America_Cuiaba);
			idMap.Add(BR_America_Cuiaba.Id, BR_America_Cuiaba);

			allZones.Add(BR_America_Manaus);
			idMap.Add(BR_America_Manaus.Id, BR_America_Manaus);

			allZones.Add(BR_America_Porto_Velho);
			idMap.Add(BR_America_Porto_Velho.Id, BR_America_Porto_Velho);

			allZones.Add(BR_America_Araguaina);
			idMap.Add(BR_America_Araguaina.Id, BR_America_Araguaina);

			allZones.Add(BR_America_Bahia);
			idMap.Add(BR_America_Bahia.Id, BR_America_Bahia);

			allZones.Add(BR_America_Belem);
			idMap.Add(BR_America_Belem.Id, BR_America_Belem);

			allZones.Add(BR_America_Fortaleza);
			idMap.Add(BR_America_Fortaleza.Id, BR_America_Fortaleza);

			allZones.Add(BR_America_Maceio);
			idMap.Add(BR_America_Maceio.Id, BR_America_Maceio);

			allZones.Add(BR_America_Recife);
			idMap.Add(BR_America_Recife.Id, BR_America_Recife);

			allZones.Add(BR_America_Sao_Paulo);
			idMap.Add(BR_America_Sao_Paulo.Id, BR_America_Sao_Paulo);

			allZones.Add(BR_America_Noronha);
			idMap.Add(BR_America_Noronha.Id, BR_America_Noronha);

			allZones.Add(BS_America_Nassau);
			idMap.Add(BS_America_Nassau.Id, BS_America_Nassau);

			allZones.Add(BT_Asia_Thimphu);
			idMap.Add(BT_Asia_Thimphu.Id, BT_Asia_Thimphu);

			allZones.Add(BV_Africa_Abidjan);
			idMap.Add(BV_Africa_Abidjan.Id, BV_Africa_Abidjan);

			allZones.Add(BW_Africa_Maputo);
			idMap.Add(BW_Africa_Maputo.Id, BW_Africa_Maputo);

			allZones.Add(BY_Europe_Minsk);
			idMap.Add(BY_Europe_Minsk.Id, BY_Europe_Minsk);

			allZones.Add(BZ_America_Belize);
			idMap.Add(BZ_America_Belize.Id, BZ_America_Belize);

			allZones.Add(CA_America_Vancouver);
			idMap.Add(CA_America_Vancouver.Id, CA_America_Vancouver);

			allZones.Add(CA_America_Whitehorse);
			idMap.Add(CA_America_Whitehorse.Id, CA_America_Whitehorse);

			allZones.Add(CA_America_Dawson_Creek);
			idMap.Add(CA_America_Dawson_Creek.Id, CA_America_Dawson_Creek);

			allZones.Add(CA_America_Edmonton);
			idMap.Add(CA_America_Edmonton.Id, CA_America_Edmonton);

			allZones.Add(CA_America_Yellowknife);
			idMap.Add(CA_America_Yellowknife.Id, CA_America_Yellowknife);

			allZones.Add(CA_America_Regina);
			idMap.Add(CA_America_Regina.Id, CA_America_Regina);

			allZones.Add(CA_America_Winnipeg);
			idMap.Add(CA_America_Winnipeg.Id, CA_America_Winnipeg);

			allZones.Add(CA_America_Iqaluit);
			idMap.Add(CA_America_Iqaluit.Id, CA_America_Iqaluit);

			allZones.Add(CA_America_Montreal);
			idMap.Add(CA_America_Montreal.Id, CA_America_Montreal);

			allZones.Add(CA_America_Toronto);
			idMap.Add(CA_America_Toronto.Id, CA_America_Toronto);

			allZones.Add(CA_America_Halifax);
			idMap.Add(CA_America_Halifax.Id, CA_America_Halifax);

			allZones.Add(CA_America_St_Johns);
			idMap.Add(CA_America_St_Johns.Id, CA_America_St_Johns);

			allZones.Add(CC_Indian_Cocos);
			idMap.Add(CC_Indian_Cocos.Id, CC_Indian_Cocos);

			allZones.Add(CD_Africa_Lagos);
			idMap.Add(CD_Africa_Lagos.Id, CD_Africa_Lagos);

			allZones.Add(CD_Africa_Maputo);
			idMap.Add(CD_Africa_Maputo.Id, CD_Africa_Maputo);

			allZones.Add(CF_Africa_Lagos);
			idMap.Add(CF_Africa_Lagos.Id, CF_Africa_Lagos);

			allZones.Add(CG_Africa_Lagos);
			idMap.Add(CG_Africa_Lagos.Id, CG_Africa_Lagos);

			allZones.Add(CH_Europe_Zurich);
			idMap.Add(CH_Europe_Zurich.Id, CH_Europe_Zurich);

			allZones.Add(CI_Africa_Abidjan);
			idMap.Add(CI_Africa_Abidjan.Id, CI_Africa_Abidjan);

			allZones.Add(CK_Pacific_Rarotonga);
			idMap.Add(CK_Pacific_Rarotonga.Id, CK_Pacific_Rarotonga);

			allZones.Add(CL_Pacific_Easter);
			idMap.Add(CL_Pacific_Easter.Id, CL_Pacific_Easter);

			allZones.Add(CL_America_Santiago);
			idMap.Add(CL_America_Santiago.Id, CL_America_Santiago);

			allZones.Add(CM_Africa_Lagos);
			idMap.Add(CM_Africa_Lagos.Id, CM_Africa_Lagos);

			allZones.Add(CN_Asia_Shanghai);
			idMap.Add(CN_Asia_Shanghai.Id, CN_Asia_Shanghai);

			allZones.Add(CO_America_Bogota);
			idMap.Add(CO_America_Bogota.Id, CO_America_Bogota);

			allZones.Add(CR_America_Costa_Rica);
			idMap.Add(CR_America_Costa_Rica.Id, CR_America_Costa_Rica);

			allZones.Add(CS_Europe_Belgrade);
			idMap.Add(CS_Europe_Belgrade.Id, CS_Europe_Belgrade);

			allZones.Add(CU_America_Havana);
			idMap.Add(CU_America_Havana.Id, CU_America_Havana);

			allZones.Add(CV_Atlantic_Cape_Verde);
			idMap.Add(CV_Atlantic_Cape_Verde.Id, CV_Atlantic_Cape_Verde);

			allZones.Add(CW_America_Curacao);
			idMap.Add(CW_America_Curacao.Id, CW_America_Curacao);

			allZones.Add(CX_Indian_Christmas);
			idMap.Add(CX_Indian_Christmas.Id, CX_Indian_Christmas);

			allZones.Add(CY_Asia_Nicosia);
			idMap.Add(CY_Asia_Nicosia.Id, CY_Asia_Nicosia);

			allZones.Add(CZ_Europe_Prague);
			idMap.Add(CZ_Europe_Prague.Id, CZ_Europe_Prague);

			allZones.Add(DE_Europe_Berlin);
			idMap.Add(DE_Europe_Berlin.Id, DE_Europe_Berlin);

			allZones.Add(DJ_Africa_Nairobi);
			idMap.Add(DJ_Africa_Nairobi.Id, DJ_Africa_Nairobi);

			allZones.Add(DK_Europe_Copenhagen);
			idMap.Add(DK_Europe_Copenhagen.Id, DK_Europe_Copenhagen);

			allZones.Add(DM_America_Port_of_Spain);
			idMap.Add(DM_America_Port_of_Spain.Id, DM_America_Port_of_Spain);

			allZones.Add(DO_America_Santo_Domingo);
			idMap.Add(DO_America_Santo_Domingo.Id, DO_America_Santo_Domingo);

			allZones.Add(DZ_Africa_Algiers);
			idMap.Add(DZ_Africa_Algiers.Id, DZ_Africa_Algiers);

			allZones.Add(EC_Pacific_Galapagos);
			idMap.Add(EC_Pacific_Galapagos.Id, EC_Pacific_Galapagos);

			allZones.Add(EC_America_Guayaquil);
			idMap.Add(EC_America_Guayaquil.Id, EC_America_Guayaquil);

			allZones.Add(EE_Europe_Tallinn);
			idMap.Add(EE_Europe_Tallinn.Id, EE_Europe_Tallinn);

			allZones.Add(EG_Africa_Cairo);
			idMap.Add(EG_Africa_Cairo.Id, EG_Africa_Cairo);

			allZones.Add(EH_Africa_El_Aaiun);
			idMap.Add(EH_Africa_El_Aaiun.Id, EH_Africa_El_Aaiun);

			allZones.Add(ER_Africa_Nairobi);
			idMap.Add(ER_Africa_Nairobi.Id, ER_Africa_Nairobi);

			allZones.Add(ES_Atlantic_Canary);
			idMap.Add(ES_Atlantic_Canary.Id, ES_Atlantic_Canary);

			allZones.Add(ES_Africa_Ceuta);
			idMap.Add(ES_Africa_Ceuta.Id, ES_Africa_Ceuta);

			allZones.Add(ES_Europe_Madrid);
			idMap.Add(ES_Europe_Madrid.Id, ES_Europe_Madrid);

			allZones.Add(ET_Africa_Nairobi);
			idMap.Add(ET_Africa_Nairobi.Id, ET_Africa_Nairobi);

			allZones.Add(FI_Europe_Helsinki);
			idMap.Add(FI_Europe_Helsinki.Id, FI_Europe_Helsinki);

			allZones.Add(FJ_Pacific_Fiji);
			idMap.Add(FJ_Pacific_Fiji.Id, FJ_Pacific_Fiji);

			allZones.Add(FK_Atlantic_Stanley);
			idMap.Add(FK_Atlantic_Stanley.Id, FK_Atlantic_Stanley);

			allZones.Add(FM_Pacific_Chuuk);
			idMap.Add(FM_Pacific_Chuuk.Id, FM_Pacific_Chuuk);

			allZones.Add(FM_Pacific_Kosrae);
			idMap.Add(FM_Pacific_Kosrae.Id, FM_Pacific_Kosrae);

			allZones.Add(FM_Pacific_Pohnpei);
			idMap.Add(FM_Pacific_Pohnpei.Id, FM_Pacific_Pohnpei);

			allZones.Add(FO_Atlantic_Faroe);
			idMap.Add(FO_Atlantic_Faroe.Id, FO_Atlantic_Faroe);

			allZones.Add(FR_Europe_Paris);
			idMap.Add(FR_Europe_Paris.Id, FR_Europe_Paris);

			allZones.Add(GA_Africa_Lagos);
			idMap.Add(GA_Africa_Lagos.Id, GA_Africa_Lagos);

			allZones.Add(GB_Europe_London);
			idMap.Add(GB_Europe_London.Id, GB_Europe_London);

			allZones.Add(GD_America_Port_of_Spain);
			idMap.Add(GD_America_Port_of_Spain.Id, GD_America_Port_of_Spain);

			allZones.Add(GE_Asia_Tbilisi);
			idMap.Add(GE_Asia_Tbilisi.Id, GE_Asia_Tbilisi);

			allZones.Add(GF_America_Cayenne);
			idMap.Add(GF_America_Cayenne.Id, GF_America_Cayenne);

			allZones.Add(GG_Europe_London);
			idMap.Add(GG_Europe_London.Id, GG_Europe_London);

			allZones.Add(GH_Africa_Accra);
			idMap.Add(GH_Africa_Accra.Id, GH_Africa_Accra);

			allZones.Add(GI_Europe_Gibraltar);
			idMap.Add(GI_Europe_Gibraltar.Id, GI_Europe_Gibraltar);

			allZones.Add(GL_America_Thule);
			idMap.Add(GL_America_Thule.Id, GL_America_Thule);

			allZones.Add(GL_America_Godthab);
			idMap.Add(GL_America_Godthab.Id, GL_America_Godthab);

			allZones.Add(GL_America_Scoresbysund);
			idMap.Add(GL_America_Scoresbysund.Id, GL_America_Scoresbysund);

			allZones.Add(GL_America_Danmarkshavn);
			idMap.Add(GL_America_Danmarkshavn.Id, GL_America_Danmarkshavn);

			allZones.Add(GM_Africa_Abidjan);
			idMap.Add(GM_Africa_Abidjan.Id, GM_Africa_Abidjan);

			allZones.Add(GN_Africa_Abidjan);
			idMap.Add(GN_Africa_Abidjan.Id, GN_Africa_Abidjan);

			allZones.Add(GP_America_Port_of_Spain);
			idMap.Add(GP_America_Port_of_Spain.Id, GP_America_Port_of_Spain);

			allZones.Add(GQ_Africa_Lagos);
			idMap.Add(GQ_Africa_Lagos.Id, GQ_Africa_Lagos);

			allZones.Add(GR_Europe_Athens);
			idMap.Add(GR_Europe_Athens.Id, GR_Europe_Athens);

			allZones.Add(GS_Atlantic_South_Georgia);
			idMap.Add(GS_Atlantic_South_Georgia.Id, GS_Atlantic_South_Georgia);

			allZones.Add(GT_America_Guatemala);
			idMap.Add(GT_America_Guatemala.Id, GT_America_Guatemala);

			allZones.Add(GU_Pacific_Guam);
			idMap.Add(GU_Pacific_Guam.Id, GU_Pacific_Guam);

			allZones.Add(GW_Africa_Bissau);
			idMap.Add(GW_Africa_Bissau.Id, GW_Africa_Bissau);

			allZones.Add(GY_America_Guyana);
			idMap.Add(GY_America_Guyana.Id, GY_America_Guyana);

			allZones.Add(HK_Asia_Hong_Kong);
			idMap.Add(HK_Asia_Hong_Kong.Id, HK_Asia_Hong_Kong);

			allZones.Add(HM_Indian_Kerguelen);
			idMap.Add(HM_Indian_Kerguelen.Id, HM_Indian_Kerguelen);

			allZones.Add(HN_America_Tegucigalpa);
			idMap.Add(HN_America_Tegucigalpa.Id, HN_America_Tegucigalpa);

			allZones.Add(HR_Europe_Belgrade);
			idMap.Add(HR_Europe_Belgrade.Id, HR_Europe_Belgrade);

			allZones.Add(HT_America_Port_au_Prince);
			idMap.Add(HT_America_Port_au_Prince.Id, HT_America_Port_au_Prince);

			allZones.Add(HU_Europe_Budapest);
			idMap.Add(HU_Europe_Budapest.Id, HU_Europe_Budapest);

			allZones.Add(ID_Asia_Jakarta);
			idMap.Add(ID_Asia_Jakarta.Id, ID_Asia_Jakarta);

			allZones.Add(ID_Asia_Makassar);
			idMap.Add(ID_Asia_Makassar.Id, ID_Asia_Makassar);

			allZones.Add(ID_Asia_Jayapura);
			idMap.Add(ID_Asia_Jayapura.Id, ID_Asia_Jayapura);

			allZones.Add(IE_Europe_Dublin);
			idMap.Add(IE_Europe_Dublin.Id, IE_Europe_Dublin);

			allZones.Add(IL_Asia_Jerusalem);
			idMap.Add(IL_Asia_Jerusalem.Id, IL_Asia_Jerusalem);

			allZones.Add(IM_Europe_London);
			idMap.Add(IM_Europe_London.Id, IM_Europe_London);

			allZones.Add(IN_Asia_Calcutta);
			idMap.Add(IN_Asia_Calcutta.Id, IN_Asia_Calcutta);

			allZones.Add(IO_Indian_Chagos);
			idMap.Add(IO_Indian_Chagos.Id, IO_Indian_Chagos);

			allZones.Add(IQ_Asia_Baghdad);
			idMap.Add(IQ_Asia_Baghdad.Id, IQ_Asia_Baghdad);

			allZones.Add(IR_Asia_Tehran);
			idMap.Add(IR_Asia_Tehran.Id, IR_Asia_Tehran);

			allZones.Add(IS_Atlantic_Reykjavik);
			idMap.Add(IS_Atlantic_Reykjavik.Id, IS_Atlantic_Reykjavik);

			allZones.Add(IT_Europe_Rome);
			idMap.Add(IT_Europe_Rome.Id, IT_Europe_Rome);

			allZones.Add(JE_Europe_London);
			idMap.Add(JE_Europe_London.Id, JE_Europe_London);

			allZones.Add(JM_America_Jamaica);
			idMap.Add(JM_America_Jamaica.Id, JM_America_Jamaica);

			allZones.Add(JO_Asia_Amman);
			idMap.Add(JO_Asia_Amman.Id, JO_Asia_Amman);

			allZones.Add(JP_Asia_Tokyo);
			idMap.Add(JP_Asia_Tokyo.Id, JP_Asia_Tokyo);

			allZones.Add(KE_Africa_Nairobi);
			idMap.Add(KE_Africa_Nairobi.Id, KE_Africa_Nairobi);

			allZones.Add(KG_Asia_Bishkek);
			idMap.Add(KG_Asia_Bishkek.Id, KG_Asia_Bishkek);

			allZones.Add(KH_Asia_Bangkok);
			idMap.Add(KH_Asia_Bangkok.Id, KH_Asia_Bangkok);

			allZones.Add(KI_Pacific_Tarawa);
			idMap.Add(KI_Pacific_Tarawa.Id, KI_Pacific_Tarawa);

			allZones.Add(KI_Pacific_Kiritimati);
			idMap.Add(KI_Pacific_Kiritimati.Id, KI_Pacific_Kiritimati);

			allZones.Add(KM_Africa_Nairobi);
			idMap.Add(KM_Africa_Nairobi.Id, KM_Africa_Nairobi);

			allZones.Add(KN_America_Port_of_Spain);
			idMap.Add(KN_America_Port_of_Spain.Id, KN_America_Port_of_Spain);

			allZones.Add(KP_Asia_Pyongyang);
			idMap.Add(KP_Asia_Pyongyang.Id, KP_Asia_Pyongyang);

			allZones.Add(KR_Asia_Seoul);
			idMap.Add(KR_Asia_Seoul.Id, KR_Asia_Seoul);

			allZones.Add(KW_Asia_Kuwait);
			idMap.Add(KW_Asia_Kuwait.Id, KW_Asia_Kuwait);

			allZones.Add(KY_America_Cayman);
			idMap.Add(KY_America_Cayman.Id, KY_America_Cayman);

			allZones.Add(KZ_Asia_Aqtau);
			idMap.Add(KZ_Asia_Aqtau.Id, KZ_Asia_Aqtau);

			allZones.Add(KZ_Asia_Aqtobe);
			idMap.Add(KZ_Asia_Aqtobe.Id, KZ_Asia_Aqtobe);

			allZones.Add(KZ_Asia_Almaty);
			idMap.Add(KZ_Asia_Almaty.Id, KZ_Asia_Almaty);

			allZones.Add(LA_Asia_Bangkok);
			idMap.Add(LA_Asia_Bangkok.Id, LA_Asia_Bangkok);

			allZones.Add(LB_Asia_Beirut);
			idMap.Add(LB_Asia_Beirut.Id, LB_Asia_Beirut);

			allZones.Add(LC_America_Port_of_Spain);
			idMap.Add(LC_America_Port_of_Spain.Id, LC_America_Port_of_Spain);

			allZones.Add(LI_Europe_Zurich);
			idMap.Add(LI_Europe_Zurich.Id, LI_Europe_Zurich);

			allZones.Add(LK_Asia_Colombo);
			idMap.Add(LK_Asia_Colombo.Id, LK_Asia_Colombo);

			allZones.Add(LR_Africa_Monrovia);
			idMap.Add(LR_Africa_Monrovia.Id, LR_Africa_Monrovia);

			allZones.Add(LS_Africa_Johannesburg);
			idMap.Add(LS_Africa_Johannesburg.Id, LS_Africa_Johannesburg);

			allZones.Add(LT_Europe_Vilnius);
			idMap.Add(LT_Europe_Vilnius.Id, LT_Europe_Vilnius);

			allZones.Add(LU_Europe_Luxembourg);
			idMap.Add(LU_Europe_Luxembourg.Id, LU_Europe_Luxembourg);

			allZones.Add(LV_Europe_Riga);
			idMap.Add(LV_Europe_Riga.Id, LV_Europe_Riga);

			allZones.Add(LY_Africa_Tripoli);
			idMap.Add(LY_Africa_Tripoli.Id, LY_Africa_Tripoli);

			allZones.Add(MA_Africa_Casablanca);
			idMap.Add(MA_Africa_Casablanca.Id, MA_Africa_Casablanca);

			allZones.Add(MC_Europe_Monaco);
			idMap.Add(MC_Europe_Monaco.Id, MC_Europe_Monaco);

			allZones.Add(MD_Europe_Chisinau);
			idMap.Add(MD_Europe_Chisinau.Id, MD_Europe_Chisinau);

			allZones.Add(ME_Europe_Belgrade);
			idMap.Add(ME_Europe_Belgrade.Id, ME_Europe_Belgrade);

			allZones.Add(MF_America_Port_of_Spain);
			idMap.Add(MF_America_Port_of_Spain.Id, MF_America_Port_of_Spain);

			allZones.Add(MG_Africa_Nairobi);
			idMap.Add(MG_Africa_Nairobi.Id, MG_Africa_Nairobi);

			allZones.Add(MH_Pacific_Kwajalein);
			idMap.Add(MH_Pacific_Kwajalein.Id, MH_Pacific_Kwajalein);

			allZones.Add(MH_Pacific_Majuro);
			idMap.Add(MH_Pacific_Majuro.Id, MH_Pacific_Majuro);

			allZones.Add(MK_Europe_Belgrade);
			idMap.Add(MK_Europe_Belgrade.Id, MK_Europe_Belgrade);

			allZones.Add(ML_Africa_Abidjan);
			idMap.Add(ML_Africa_Abidjan.Id, ML_Africa_Abidjan);

			allZones.Add(MM_Asia_Rangoon);
			idMap.Add(MM_Asia_Rangoon.Id, MM_Asia_Rangoon);

			allZones.Add(MN_Asia_Hovd);
			idMap.Add(MN_Asia_Hovd.Id, MN_Asia_Hovd);

			allZones.Add(MN_Asia_Choibalsan);
			idMap.Add(MN_Asia_Choibalsan.Id, MN_Asia_Choibalsan);

			allZones.Add(MN_Asia_Ulaanbaatar);
			idMap.Add(MN_Asia_Ulaanbaatar.Id, MN_Asia_Ulaanbaatar);

			allZones.Add(MO_Asia_Macau);
			idMap.Add(MO_Asia_Macau.Id, MO_Asia_Macau);

			allZones.Add(MP_Pacific_Saipan);
			idMap.Add(MP_Pacific_Saipan.Id, MP_Pacific_Saipan);

			allZones.Add(MQ_America_Martinique);
			idMap.Add(MQ_America_Martinique.Id, MQ_America_Martinique);

			allZones.Add(MR_Africa_Abidjan);
			idMap.Add(MR_Africa_Abidjan.Id, MR_Africa_Abidjan);

			allZones.Add(MS_America_Port_of_Spain);
			idMap.Add(MS_America_Port_of_Spain.Id, MS_America_Port_of_Spain);

			allZones.Add(MT_Europe_Malta);
			idMap.Add(MT_Europe_Malta.Id, MT_Europe_Malta);

			allZones.Add(MU_Indian_Mauritius);
			idMap.Add(MU_Indian_Mauritius.Id, MU_Indian_Mauritius);

			allZones.Add(MV_Indian_Maldives);
			idMap.Add(MV_Indian_Maldives.Id, MV_Indian_Maldives);

			allZones.Add(MW_Africa_Maputo);
			idMap.Add(MW_Africa_Maputo.Id, MW_Africa_Maputo);

			allZones.Add(MX_America_Tijuana);
			idMap.Add(MX_America_Tijuana.Id, MX_America_Tijuana);

			allZones.Add(MX_America_Hermosillo);
			idMap.Add(MX_America_Hermosillo.Id, MX_America_Hermosillo);

			allZones.Add(MX_America_Mazatlan);
			idMap.Add(MX_America_Mazatlan.Id, MX_America_Mazatlan);

			allZones.Add(MX_America_Mexico_City);
			idMap.Add(MX_America_Mexico_City.Id, MX_America_Mexico_City);

			allZones.Add(MY_Asia_Kuala_Lumpur);
			idMap.Add(MY_Asia_Kuala_Lumpur.Id, MY_Asia_Kuala_Lumpur);

			allZones.Add(MZ_Africa_Maputo);
			idMap.Add(MZ_Africa_Maputo.Id, MZ_Africa_Maputo);

			allZones.Add(NA_Africa_Windhoek);
			idMap.Add(NA_Africa_Windhoek.Id, NA_Africa_Windhoek);

			allZones.Add(NC_Pacific_Noumea);
			idMap.Add(NC_Pacific_Noumea.Id, NC_Pacific_Noumea);

			allZones.Add(NE_Africa_Lagos);
			idMap.Add(NE_Africa_Lagos.Id, NE_Africa_Lagos);

			allZones.Add(NF_Pacific_Norfolk);
			idMap.Add(NF_Pacific_Norfolk.Id, NF_Pacific_Norfolk);

			allZones.Add(NG_Africa_Lagos);
			idMap.Add(NG_Africa_Lagos.Id, NG_Africa_Lagos);

			allZones.Add(NI_America_Managua);
			idMap.Add(NI_America_Managua.Id, NI_America_Managua);

			allZones.Add(NL_Europe_Amsterdam);
			idMap.Add(NL_Europe_Amsterdam.Id, NL_Europe_Amsterdam);

			allZones.Add(NO_Europe_Oslo);
			idMap.Add(NO_Europe_Oslo.Id, NO_Europe_Oslo);

			allZones.Add(NP_Asia_Katmandu);
			idMap.Add(NP_Asia_Katmandu.Id, NP_Asia_Katmandu);

			allZones.Add(NR_Pacific_Nauru);
			idMap.Add(NR_Pacific_Nauru.Id, NR_Pacific_Nauru);

			allZones.Add(NU_Pacific_Niue);
			idMap.Add(NU_Pacific_Niue.Id, NU_Pacific_Niue);

			allZones.Add(NZ_Pacific_Auckland);
			idMap.Add(NZ_Pacific_Auckland.Id, NZ_Pacific_Auckland);

			allZones.Add(OM_Asia_Muscat);
			idMap.Add(OM_Asia_Muscat.Id, OM_Asia_Muscat);

			allZones.Add(PA_America_Panama);
			idMap.Add(PA_America_Panama.Id, PA_America_Panama);

			allZones.Add(PE_America_Lima);
			idMap.Add(PE_America_Lima.Id, PE_America_Lima);

			allZones.Add(PF_Pacific_Tahiti);
			idMap.Add(PF_Pacific_Tahiti.Id, PF_Pacific_Tahiti);

			allZones.Add(PF_Pacific_Marquesas);
			idMap.Add(PF_Pacific_Marquesas.Id, PF_Pacific_Marquesas);

			allZones.Add(PF_Pacific_Gambier);
			idMap.Add(PF_Pacific_Gambier.Id, PF_Pacific_Gambier);

			allZones.Add(PG_Pacific_Port_Moresby);
			idMap.Add(PG_Pacific_Port_Moresby.Id, PG_Pacific_Port_Moresby);

			allZones.Add(PH_Asia_Manila);
			idMap.Add(PH_Asia_Manila.Id, PH_Asia_Manila);

			allZones.Add(PK_Asia_Karachi);
			idMap.Add(PK_Asia_Karachi.Id, PK_Asia_Karachi);

			allZones.Add(PL_Europe_Warsaw);
			idMap.Add(PL_Europe_Warsaw.Id, PL_Europe_Warsaw);

			allZones.Add(PM_America_Miquelon);
			idMap.Add(PM_America_Miquelon.Id, PM_America_Miquelon);

			allZones.Add(PN_Pacific_Pitcairn);
			idMap.Add(PN_Pacific_Pitcairn.Id, PN_Pacific_Pitcairn);

			allZones.Add(PR_America_Puerto_Rico);
			idMap.Add(PR_America_Puerto_Rico.Id, PR_America_Puerto_Rico);

			allZones.Add(PS_Asia_Gaza);
			idMap.Add(PS_Asia_Gaza.Id, PS_Asia_Gaza);

			allZones.Add(PT_Atlantic_Azores);
			idMap.Add(PT_Atlantic_Azores.Id, PT_Atlantic_Azores);

			allZones.Add(PT_Europe_Lisbon);
			idMap.Add(PT_Europe_Lisbon.Id, PT_Europe_Lisbon);

			allZones.Add(PW_Pacific_Palau);
			idMap.Add(PW_Pacific_Palau.Id, PW_Pacific_Palau);

			allZones.Add(PY_America_Asuncion);
			idMap.Add(PY_America_Asuncion.Id, PY_America_Asuncion);

			allZones.Add(QA_Asia_Qatar);
			idMap.Add(QA_Asia_Qatar.Id, QA_Asia_Qatar);

			allZones.Add(RE_Indian_Reunion);
			idMap.Add(RE_Indian_Reunion.Id, RE_Indian_Reunion);

			allZones.Add(RO_Europe_Bucharest);
			idMap.Add(RO_Europe_Bucharest.Id, RO_Europe_Bucharest);

			allZones.Add(RS_Europe_Belgrade);
			idMap.Add(RS_Europe_Belgrade.Id, RS_Europe_Belgrade);

			allZones.Add(RU_Europe_Kaliningrad);
			idMap.Add(RU_Europe_Kaliningrad.Id, RU_Europe_Kaliningrad);

			allZones.Add(RU_Europe_Moscow);
			idMap.Add(RU_Europe_Moscow.Id, RU_Europe_Moscow);

			allZones.Add(RU_Europe_Samara);
			idMap.Add(RU_Europe_Samara.Id, RU_Europe_Samara);

			allZones.Add(RU_Asia_Yekaterinburg);
			idMap.Add(RU_Asia_Yekaterinburg.Id, RU_Asia_Yekaterinburg);

			allZones.Add(RU_Asia_Omsk);
			idMap.Add(RU_Asia_Omsk.Id, RU_Asia_Omsk);

			allZones.Add(RU_Asia_Krasnoyarsk);
			idMap.Add(RU_Asia_Krasnoyarsk.Id, RU_Asia_Krasnoyarsk);

			allZones.Add(RU_Asia_Irkutsk);
			idMap.Add(RU_Asia_Irkutsk.Id, RU_Asia_Irkutsk);

			allZones.Add(RU_Asia_Yakutsk);
			idMap.Add(RU_Asia_Yakutsk.Id, RU_Asia_Yakutsk);

			allZones.Add(RU_Asia_Magadan);
			idMap.Add(RU_Asia_Magadan.Id, RU_Asia_Magadan);

			allZones.Add(RU_Asia_Vladivostok);
			idMap.Add(RU_Asia_Vladivostok.Id, RU_Asia_Vladivostok);

			allZones.Add(RU_Asia_Kamchatka);
			idMap.Add(RU_Asia_Kamchatka.Id, RU_Asia_Kamchatka);

			allZones.Add(RW_Africa_Maputo);
			idMap.Add(RW_Africa_Maputo.Id, RW_Africa_Maputo);

			allZones.Add(SA_Asia_Riyadh);
			idMap.Add(SA_Asia_Riyadh.Id, SA_Asia_Riyadh);

			allZones.Add(SB_Pacific_Guadalcanal);
			idMap.Add(SB_Pacific_Guadalcanal.Id, SB_Pacific_Guadalcanal);

			allZones.Add(SC_Indian_Mahe);
			idMap.Add(SC_Indian_Mahe.Id, SC_Indian_Mahe);

			allZones.Add(SD_Africa_Khartoum);
			idMap.Add(SD_Africa_Khartoum.Id, SD_Africa_Khartoum);

			allZones.Add(SE_Europe_Stockholm);
			idMap.Add(SE_Europe_Stockholm.Id, SE_Europe_Stockholm);

			allZones.Add(SG_Asia_Singapore);
			idMap.Add(SG_Asia_Singapore.Id, SG_Asia_Singapore);

			allZones.Add(SH_Africa_Abidjan);
			idMap.Add(SH_Africa_Abidjan.Id, SH_Africa_Abidjan);

			allZones.Add(SI_Europe_Belgrade);
			idMap.Add(SI_Europe_Belgrade.Id, SI_Europe_Belgrade);

			allZones.Add(SJ_Europe_Oslo);
			idMap.Add(SJ_Europe_Oslo.Id, SJ_Europe_Oslo);

			allZones.Add(SK_Europe_Prague);
			idMap.Add(SK_Europe_Prague.Id, SK_Europe_Prague);

			allZones.Add(SL_Africa_Abidjan);
			idMap.Add(SL_Africa_Abidjan.Id, SL_Africa_Abidjan);

			allZones.Add(SM_Europe_Rome);
			idMap.Add(SM_Europe_Rome.Id, SM_Europe_Rome);

			allZones.Add(SN_Africa_Abidjan);
			idMap.Add(SN_Africa_Abidjan.Id, SN_Africa_Abidjan);

			allZones.Add(SO_Africa_Nairobi);
			idMap.Add(SO_Africa_Nairobi.Id, SO_Africa_Nairobi);

			allZones.Add(SR_America_Paramaribo);
			idMap.Add(SR_America_Paramaribo.Id, SR_America_Paramaribo);

			allZones.Add(SS_Africa_Khartoum);
			idMap.Add(SS_Africa_Khartoum.Id, SS_Africa_Khartoum);

			allZones.Add(ST_Africa_Abidjan);
			idMap.Add(ST_Africa_Abidjan.Id, ST_Africa_Abidjan);

			allZones.Add(SV_America_El_Salvador);
			idMap.Add(SV_America_El_Salvador.Id, SV_America_El_Salvador);

			allZones.Add(SX_America_Curacao);
			idMap.Add(SX_America_Curacao.Id, SX_America_Curacao);

			allZones.Add(SY_Asia_Damascus);
			idMap.Add(SY_Asia_Damascus.Id, SY_Asia_Damascus);

			allZones.Add(SZ_Africa_Johannesburg);
			idMap.Add(SZ_Africa_Johannesburg.Id, SZ_Africa_Johannesburg);

			allZones.Add(TC_America_Grand_Turk);
			idMap.Add(TC_America_Grand_Turk.Id, TC_America_Grand_Turk);

			allZones.Add(TD_Africa_Ndjamena);
			idMap.Add(TD_Africa_Ndjamena.Id, TD_Africa_Ndjamena);

			allZones.Add(TF_Indian_Kerguelen);
			idMap.Add(TF_Indian_Kerguelen.Id, TF_Indian_Kerguelen);

			allZones.Add(TG_Africa_Abidjan);
			idMap.Add(TG_Africa_Abidjan.Id, TG_Africa_Abidjan);

			allZones.Add(TH_Asia_Bangkok);
			idMap.Add(TH_Asia_Bangkok.Id, TH_Asia_Bangkok);

			allZones.Add(TJ_Asia_Dushanbe);
			idMap.Add(TJ_Asia_Dushanbe.Id, TJ_Asia_Dushanbe);

			allZones.Add(TK_Pacific_Fakaofo);
			idMap.Add(TK_Pacific_Fakaofo.Id, TK_Pacific_Fakaofo);

			allZones.Add(TL_Asia_Dili);
			idMap.Add(TL_Asia_Dili.Id, TL_Asia_Dili);

			allZones.Add(TM_Asia_Ashgabat);
			idMap.Add(TM_Asia_Ashgabat.Id, TM_Asia_Ashgabat);

			allZones.Add(TN_Africa_Tunis);
			idMap.Add(TN_Africa_Tunis.Id, TN_Africa_Tunis);

			allZones.Add(TO_Pacific_Tongatapu);
			idMap.Add(TO_Pacific_Tongatapu.Id, TO_Pacific_Tongatapu);

			allZones.Add(TR_Europe_Istanbul);
			idMap.Add(TR_Europe_Istanbul.Id, TR_Europe_Istanbul);

			allZones.Add(TT_America_Port_of_Spain);
			idMap.Add(TT_America_Port_of_Spain.Id, TT_America_Port_of_Spain);

			allZones.Add(TV_Pacific_Funafuti);
			idMap.Add(TV_Pacific_Funafuti.Id, TV_Pacific_Funafuti);

			allZones.Add(TW_Asia_Taipei);
			idMap.Add(TW_Asia_Taipei.Id, TW_Asia_Taipei);

			allZones.Add(TZ_Africa_Nairobi);
			idMap.Add(TZ_Africa_Nairobi.Id, TZ_Africa_Nairobi);

			allZones.Add(UA_Europe_Kiev);
			idMap.Add(UA_Europe_Kiev.Id, UA_Europe_Kiev);

			allZones.Add(UG_Africa_Nairobi);
			idMap.Add(UG_Africa_Nairobi.Id, UG_Africa_Nairobi);

			allZones.Add(UM_Pacific_Midway);
			idMap.Add(UM_Pacific_Midway.Id, UM_Pacific_Midway);

			allZones.Add(UM_Pacific_Honolulu);
			idMap.Add(UM_Pacific_Honolulu.Id, UM_Pacific_Honolulu);

			allZones.Add(UM_Pacific_Wake);
			idMap.Add(UM_Pacific_Wake.Id, UM_Pacific_Wake);

			allZones.Add(UM_Pacific_Enderbury);
			idMap.Add(UM_Pacific_Enderbury.Id, UM_Pacific_Enderbury);

			allZones.Add(US_Pacific_Honolulu);
			idMap.Add(US_Pacific_Honolulu.Id, US_Pacific_Honolulu);

			allZones.Add(US_America_Anchorage);
			idMap.Add(US_America_Anchorage.Id, US_America_Anchorage);

			allZones.Add(US_America_Los_Angeles);
			idMap.Add(US_America_Los_Angeles.Id, US_America_Los_Angeles);

			allZones.Add(US_America_Denver);
			idMap.Add(US_America_Denver.Id, US_America_Denver);

			allZones.Add(US_America_Phoenix);
			idMap.Add(US_America_Phoenix.Id, US_America_Phoenix);

			allZones.Add(US_America_Chicago);
			idMap.Add(US_America_Chicago.Id, US_America_Chicago);

			allZones.Add(US_America_New_York);
			idMap.Add(US_America_New_York.Id, US_America_New_York);

			allZones.Add(UY_America_Montevideo);
			idMap.Add(UY_America_Montevideo.Id, UY_America_Montevideo);

			allZones.Add(UZ_Asia_Tashkent);
			idMap.Add(UZ_Asia_Tashkent.Id, UZ_Asia_Tashkent);

			allZones.Add(VA_Europe_Rome);
			idMap.Add(VA_Europe_Rome.Id, VA_Europe_Rome);

			allZones.Add(VC_America_Port_of_Spain);
			idMap.Add(VC_America_Port_of_Spain.Id, VC_America_Port_of_Spain);

			allZones.Add(VE_America_Caracas);
			idMap.Add(VE_America_Caracas.Id, VE_America_Caracas);

			allZones.Add(VG_America_Port_of_Spain);
			idMap.Add(VG_America_Port_of_Spain.Id, VG_America_Port_of_Spain);

			allZones.Add(VI_America_Port_of_Spain);
			idMap.Add(VI_America_Port_of_Spain.Id, VI_America_Port_of_Spain);

			allZones.Add(VN_Asia_Saigon);
			idMap.Add(VN_Asia_Saigon.Id, VN_Asia_Saigon);

			allZones.Add(VU_Pacific_Efate);
			idMap.Add(VU_Pacific_Efate.Id, VU_Pacific_Efate);

			allZones.Add(WF_Pacific_Wallis);
			idMap.Add(WF_Pacific_Wallis.Id, WF_Pacific_Wallis);

			allZones.Add(WS_Pacific_Apia);
			idMap.Add(WS_Pacific_Apia.Id, WS_Pacific_Apia);

			allZones.Add(YE_Asia_Aden);
			idMap.Add(YE_Asia_Aden.Id, YE_Asia_Aden);

			allZones.Add(YT_Africa_Nairobi);
			idMap.Add(YT_Africa_Nairobi.Id, YT_Africa_Nairobi);

			allZones.Add(ZA_Africa_Johannesburg);
			idMap.Add(ZA_Africa_Johannesburg.Id, ZA_Africa_Johannesburg);

			allZones.Add(ZM_Africa_Maputo);
			idMap.Add(ZM_Africa_Maputo.Id, ZM_Africa_Maputo);

			allZones.Add(ZW_Africa_Maputo);
			idMap.Add(ZW_Africa_Maputo.Id, ZW_Africa_Maputo);

			allZones.Add(ZZ_Etc_GMT);
			idMap.Add(ZZ_Etc_GMT.Id, ZZ_Etc_GMT);


			AllZones = allZones.AsReadOnly();
			IdMap = idMap;
		}


		private static readonly TimeZoneLocation AD_Europe_Andorra = new TimeZoneLocation()
		{
			Id = "AD_Europe_Andorra",
			CountryCode = "AD",
			CountryName = "Andorra",
			OlsonTimeZone = "Europe/Andorra",
			FriendlyName = "Andorra",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Andorra",
		};

		private static readonly TimeZoneLocation AE_Asia_Dubai = new TimeZoneLocation()
		{
			Id = "AE_Asia_Dubai",
			CountryCode = "AE",
			CountryName = "United Arab Emirates",
			OlsonTimeZone = "Asia/Dubai",
			FriendlyName = "Dubai",
			StandardGmtOffset = "+04:00",
			FullDisplayName = "(GMT+04:00) Dubai",
		};

		private static readonly TimeZoneLocation AF_Asia_Kabul = new TimeZoneLocation()
		{
			Id = "AF_Asia_Kabul",
			CountryCode = "AF",
			CountryName = "Afghanistan",
			OlsonTimeZone = "Asia/Kabul",
			FriendlyName = "Kabul",
			StandardGmtOffset = "+04:30",
			FullDisplayName = "(GMT+04:30) Kabul",
		};

		private static readonly TimeZoneLocation AG_America_Antigua = new TimeZoneLocation()
		{
			Id = "AG_America_Antigua",
			CountryCode = "AG",
			CountryName = "Antigua and Barbuda",
			OlsonTimeZone = "America/Antigua",
			FriendlyName = "Antigua",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Antigua",
		};

		private static readonly TimeZoneLocation AI_America_Port_of_Spain = new TimeZoneLocation()
		{
			Id = "AI_America_Port_of_Spain",
			CountryCode = "AI",
			CountryName = "Anguilla",
			OlsonTimeZone = "America/Port_of_Spain",
			FriendlyName = "Port of Spain",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Port of Spain",
		};

		private static readonly TimeZoneLocation AL_Europe_Tirane = new TimeZoneLocation()
		{
			Id = "AL_Europe_Tirane",
			CountryCode = "AL",
			CountryName = "Albania",
			OlsonTimeZone = "Europe/Tirane",
			FriendlyName = "Tirane",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Tirane",
		};

		private static readonly TimeZoneLocation AM_Asia_Yerevan = new TimeZoneLocation()
		{
			Id = "AM_Asia_Yerevan",
			CountryCode = "AM",
			CountryName = "Armenia",
			OlsonTimeZone = "Asia/Yerevan",
			FriendlyName = "Yerevan",
			StandardGmtOffset = "+04:00",
			FullDisplayName = "(GMT+04:00) Yerevan",
		};

		private static readonly TimeZoneLocation AN_America_Curacao = new TimeZoneLocation()
		{
			Id = "AN_America_Curacao",
			CountryCode = "AN",
			CountryName = "Netherlands Antilles",
			OlsonTimeZone = "America/Curacao",
			FriendlyName = "Curacao",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Curacao",
		};

		private static readonly TimeZoneLocation AO_Africa_Lagos = new TimeZoneLocation()
		{
			Id = "AO_Africa_Lagos",
			CountryCode = "AO",
			CountryName = "Angola",
			OlsonTimeZone = "Africa/Lagos",
			FriendlyName = "Lagos",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Lagos",
		};

		private static readonly TimeZoneLocation AQ_Antarctica_Palmer = new TimeZoneLocation()
		{
			Id = "AQ_Antarctica_Palmer",
			CountryCode = "AQ",
			CountryName = "Antarctica",
			OlsonTimeZone = "Antarctica/Palmer",
			FriendlyName = "Palmer",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Palmer",
		};

		private static readonly TimeZoneLocation AQ_Antarctica_Rothera = new TimeZoneLocation()
		{
			Id = "AQ_Antarctica_Rothera",
			CountryCode = "AQ",
			CountryName = "Antarctica",
			OlsonTimeZone = "Antarctica/Rothera",
			FriendlyName = "Rothera",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Rothera",
		};

		private static readonly TimeZoneLocation AQ_Antarctica_Syowa = new TimeZoneLocation()
		{
			Id = "AQ_Antarctica_Syowa",
			CountryCode = "AQ",
			CountryName = "Antarctica",
			OlsonTimeZone = "Antarctica/Syowa",
			FriendlyName = "Syowa",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Syowa",
		};

		private static readonly TimeZoneLocation AQ_Antarctica_Mawson = new TimeZoneLocation()
		{
			Id = "AQ_Antarctica_Mawson",
			CountryCode = "AQ",
			CountryName = "Antarctica",
			OlsonTimeZone = "Antarctica/Mawson",
			FriendlyName = "Mawson",
			StandardGmtOffset = "+05:00",
			FullDisplayName = "(GMT+05:00) Mawson",
		};

		private static readonly TimeZoneLocation AQ_Antarctica_Vostok = new TimeZoneLocation()
		{
			Id = "AQ_Antarctica_Vostok",
			CountryCode = "AQ",
			CountryName = "Antarctica",
			OlsonTimeZone = "Antarctica/Vostok",
			FriendlyName = "Vostok",
			StandardGmtOffset = "+06:00",
			FullDisplayName = "(GMT+06:00) Vostok",
		};

		private static readonly TimeZoneLocation AQ_Antarctica_Davis = new TimeZoneLocation()
		{
			Id = "AQ_Antarctica_Davis",
			CountryCode = "AQ",
			CountryName = "Antarctica",
			OlsonTimeZone = "Antarctica/Davis",
			FriendlyName = "Davis",
			StandardGmtOffset = "+07:00",
			FullDisplayName = "(GMT+07:00) Davis",
		};

		private static readonly TimeZoneLocation AQ_Antarctica_Casey = new TimeZoneLocation()
		{
			Id = "AQ_Antarctica_Casey",
			CountryCode = "AQ",
			CountryName = "Antarctica",
			OlsonTimeZone = "Antarctica/Casey",
			FriendlyName = "Casey",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) Casey",
		};

		private static readonly TimeZoneLocation AQ_Antarctica_DumontDUrville = new TimeZoneLocation()
		{
			Id = "AQ_Antarctica_DumontDUrville",
			CountryCode = "AQ",
			CountryName = "Antarctica",
			OlsonTimeZone = "Antarctica/DumontDUrville",
			FriendlyName = "Dumont D'Urville",
			StandardGmtOffset = "+10:00",
			FullDisplayName = "(GMT+10:00) Dumont D'Urville",
		};

		private static readonly TimeZoneLocation AQ_Pacific_Auckland = new TimeZoneLocation()
		{
			Id = "AQ_Pacific_Auckland",
			CountryCode = "AQ",
			CountryName = "Antarctica",
			OlsonTimeZone = "Pacific/Auckland",
			FriendlyName = "Auckland",
			StandardGmtOffset = "+12:00",
			FullDisplayName = "(GMT+12:00) Auckland",
		};

		private static readonly TimeZoneLocation AR_America_Argentina_Buenos_Aires = new TimeZoneLocation()
		{
			Id = "AR_America_Argentina_Buenos_Aires",
			CountryCode = "AR",
			CountryName = "Argentina",
			OlsonTimeZone = "America/Argentina/Buenos_Aires",
			FriendlyName = "Buenos Aires",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Buenos Aires",
		};

		private static readonly TimeZoneLocation AS_Pacific_Pago_Pago = new TimeZoneLocation()
		{
			Id = "AS_Pacific_Pago_Pago",
			CountryCode = "AS",
			CountryName = "American Samoa",
			OlsonTimeZone = "Pacific/Pago_Pago",
			FriendlyName = "Pago Pago",
			StandardGmtOffset = "-11:00",
			FullDisplayName = "(GMT-11:00) Pago Pago",
		};

		private static readonly TimeZoneLocation AT_Europe_Vienna = new TimeZoneLocation()
		{
			Id = "AT_Europe_Vienna",
			CountryCode = "AT",
			CountryName = "Austria",
			OlsonTimeZone = "Europe/Vienna",
			FriendlyName = "Vienna",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Vienna",
		};

		private static readonly TimeZoneLocation AU_Australia_Perth = new TimeZoneLocation()
		{
			Id = "AU_Australia_Perth",
			CountryCode = "AU",
			CountryName = "Australia",
			OlsonTimeZone = "Australia/Perth",
			FriendlyName = "Western Time - Perth",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) Western Time - Perth",
		};

		private static readonly TimeZoneLocation AU_Australia_Adelaide = new TimeZoneLocation()
		{
			Id = "AU_Australia_Adelaide",
			CountryCode = "AU",
			CountryName = "Australia",
			OlsonTimeZone = "Australia/Adelaide",
			FriendlyName = "Central Time - Adelaide",
			StandardGmtOffset = "+09:30",
			FullDisplayName = "(GMT+09:30) Central Time - Adelaide",
		};

		private static readonly TimeZoneLocation AU_Australia_Darwin = new TimeZoneLocation()
		{
			Id = "AU_Australia_Darwin",
			CountryCode = "AU",
			CountryName = "Australia",
			OlsonTimeZone = "Australia/Darwin",
			FriendlyName = "Central Time - Darwin",
			StandardGmtOffset = "+09:30",
			FullDisplayName = "(GMT+09:30) Central Time - Darwin",
		};

		private static readonly TimeZoneLocation AU_Australia_Brisbane = new TimeZoneLocation()
		{
			Id = "AU_Australia_Brisbane",
			CountryCode = "AU",
			CountryName = "Australia",
			OlsonTimeZone = "Australia/Brisbane",
			FriendlyName = "Eastern Time - Brisbane",
			StandardGmtOffset = "+10:00",
			FullDisplayName = "(GMT+10:00) Eastern Time - Brisbane",
		};

		private static readonly TimeZoneLocation AU_Australia_Hobart = new TimeZoneLocation()
		{
			Id = "AU_Australia_Hobart",
			CountryCode = "AU",
			CountryName = "Australia",
			OlsonTimeZone = "Australia/Hobart",
			FriendlyName = "Eastern Time - Hobart",
			StandardGmtOffset = "+10:00",
			FullDisplayName = "(GMT+10:00) Eastern Time - Hobart",
		};

		private static readonly TimeZoneLocation AU_Australia_Sydney = new TimeZoneLocation()
		{
			Id = "AU_Australia_Sydney",
			CountryCode = "AU",
			CountryName = "Australia",
			OlsonTimeZone = "Australia/Sydney",
			FriendlyName = "Eastern Time - Melbourne, Sydney",
			StandardGmtOffset = "+10:00",
			FullDisplayName = "(GMT+10:00) Eastern Time - Melbourne, Sydney",
		};

		private static readonly TimeZoneLocation AW_America_Curacao = new TimeZoneLocation()
		{
			Id = "AW_America_Curacao",
			CountryCode = "AW",
			CountryName = "Aruba",
			OlsonTimeZone = "America/Curacao",
			FriendlyName = "Curacao",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Curacao",
		};

		private static readonly TimeZoneLocation AX_Europe_Helsinki = new TimeZoneLocation()
		{
			Id = "AX_Europe_Helsinki",
			CountryCode = "AX",
			CountryName = "Aland Islands",
			OlsonTimeZone = "Europe/Helsinki",
			FriendlyName = "Helsinki",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Helsinki",
		};

		private static readonly TimeZoneLocation AZ_Asia_Baku = new TimeZoneLocation()
		{
			Id = "AZ_Asia_Baku",
			CountryCode = "AZ",
			CountryName = "Azerbaijan",
			OlsonTimeZone = "Asia/Baku",
			FriendlyName = "Baku",
			StandardGmtOffset = "+04:00",
			FullDisplayName = "(GMT+04:00) Baku",
		};

		private static readonly TimeZoneLocation BA_Europe_Belgrade = new TimeZoneLocation()
		{
			Id = "BA_Europe_Belgrade",
			CountryCode = "BA",
			CountryName = "Bosnia and Herzegovina",
			OlsonTimeZone = "Europe/Belgrade",
			FriendlyName = "Central European Time - Belgrade",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Central European Time - Belgrade",
		};

		private static readonly TimeZoneLocation BB_America_Barbados = new TimeZoneLocation()
		{
			Id = "BB_America_Barbados",
			CountryCode = "BB",
			CountryName = "Barbados",
			OlsonTimeZone = "America/Barbados",
			FriendlyName = "Barbados",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Barbados",
		};

		private static readonly TimeZoneLocation BD_Asia_Dhaka = new TimeZoneLocation()
		{
			Id = "BD_Asia_Dhaka",
			CountryCode = "BD",
			CountryName = "Bangladesh",
			OlsonTimeZone = "Asia/Dhaka",
			FriendlyName = "Dhaka",
			StandardGmtOffset = "+06:00",
			FullDisplayName = "(GMT+06:00) Dhaka",
		};

		private static readonly TimeZoneLocation BE_Europe_Brussels = new TimeZoneLocation()
		{
			Id = "BE_Europe_Brussels",
			CountryCode = "BE",
			CountryName = "Belgium",
			OlsonTimeZone = "Europe/Brussels",
			FriendlyName = "Brussels",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Brussels",
		};

		private static readonly TimeZoneLocation BF_Africa_Abidjan = new TimeZoneLocation()
		{
			Id = "BF_Africa_Abidjan",
			CountryCode = "BF",
			CountryName = "Burkina Faso",
			OlsonTimeZone = "Africa/Abidjan",
			FriendlyName = "Abidjan",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Abidjan",
		};

		private static readonly TimeZoneLocation BG_Europe_Sofia = new TimeZoneLocation()
		{
			Id = "BG_Europe_Sofia",
			CountryCode = "BG",
			CountryName = "Bulgaria",
			OlsonTimeZone = "Europe/Sofia",
			FriendlyName = "Sofia",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Sofia",
		};

		private static readonly TimeZoneLocation BH_Asia_Bahrain = new TimeZoneLocation()
		{
			Id = "BH_Asia_Bahrain",
			CountryCode = "BH",
			CountryName = "Bahrain",
			OlsonTimeZone = "Asia/Bahrain",
			FriendlyName = "Bahrain",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Bahrain",
		};

		private static readonly TimeZoneLocation BI_Africa_Maputo = new TimeZoneLocation()
		{
			Id = "BI_Africa_Maputo",
			CountryCode = "BI",
			CountryName = "Burundi",
			OlsonTimeZone = "Africa/Maputo",
			FriendlyName = "Maputo",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Maputo",
		};

		private static readonly TimeZoneLocation BJ_Africa_Lagos = new TimeZoneLocation()
		{
			Id = "BJ_Africa_Lagos",
			CountryCode = "BJ",
			CountryName = "Benin",
			OlsonTimeZone = "Africa/Lagos",
			FriendlyName = "Lagos",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Lagos",
		};

		private static readonly TimeZoneLocation BM_Atlantic_Bermuda = new TimeZoneLocation()
		{
			Id = "BM_Atlantic_Bermuda",
			CountryCode = "BM",
			CountryName = "Bermuda",
			OlsonTimeZone = "Atlantic/Bermuda",
			FriendlyName = "Bermuda",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Bermuda",
		};

		private static readonly TimeZoneLocation BN_Asia_Brunei = new TimeZoneLocation()
		{
			Id = "BN_Asia_Brunei",
			CountryCode = "BN",
			CountryName = "Brunei",
			OlsonTimeZone = "Asia/Brunei",
			FriendlyName = "Brunei",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) Brunei",
		};

		private static readonly TimeZoneLocation BO_America_La_Paz = new TimeZoneLocation()
		{
			Id = "BO_America_La_Paz",
			CountryCode = "BO",
			CountryName = "Bolivia",
			OlsonTimeZone = "America/La_Paz",
			FriendlyName = "La Paz",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) La Paz",
		};

		private static readonly TimeZoneLocation BQ_America_Curacao = new TimeZoneLocation()
		{
			Id = "BQ_America_Curacao",
			CountryCode = "BQ",
			CountryName = "Bonaire, Saint Eustatius and Saba ",
			OlsonTimeZone = "America/Curacao",
			FriendlyName = "Curacao",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Curacao",
		};

		private static readonly TimeZoneLocation BR_America_Rio_Branco = new TimeZoneLocation()
		{
			Id = "BR_America_Rio_Branco",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Rio_Branco",
			FriendlyName = "Rio Branco",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Rio Branco",
		};

		private static readonly TimeZoneLocation BR_America_Boa_Vista = new TimeZoneLocation()
		{
			Id = "BR_America_Boa_Vista",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Boa_Vista",
			FriendlyName = "Boa Vista",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Boa Vista",
		};

		private static readonly TimeZoneLocation BR_America_Campo_Grande = new TimeZoneLocation()
		{
			Id = "BR_America_Campo_Grande",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Campo_Grande",
			FriendlyName = "Campo Grande",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Campo Grande",
		};

		private static readonly TimeZoneLocation BR_America_Cuiaba = new TimeZoneLocation()
		{
			Id = "BR_America_Cuiaba",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Cuiaba",
			FriendlyName = "Cuiaba",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Cuiaba",
		};

		private static readonly TimeZoneLocation BR_America_Manaus = new TimeZoneLocation()
		{
			Id = "BR_America_Manaus",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Manaus",
			FriendlyName = "Manaus",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Manaus",
		};

		private static readonly TimeZoneLocation BR_America_Porto_Velho = new TimeZoneLocation()
		{
			Id = "BR_America_Porto_Velho",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Porto_Velho",
			FriendlyName = "Porto Velho",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Porto Velho",
		};

		private static readonly TimeZoneLocation BR_America_Araguaina = new TimeZoneLocation()
		{
			Id = "BR_America_Araguaina",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Araguaina",
			FriendlyName = "Araguaina",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Araguaina",
		};

		private static readonly TimeZoneLocation BR_America_Bahia = new TimeZoneLocation()
		{
			Id = "BR_America_Bahia",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Bahia",
			FriendlyName = "Salvador",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Salvador",
		};

		private static readonly TimeZoneLocation BR_America_Belem = new TimeZoneLocation()
		{
			Id = "BR_America_Belem",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Belem",
			FriendlyName = "Belem",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Belem",
		};

		private static readonly TimeZoneLocation BR_America_Fortaleza = new TimeZoneLocation()
		{
			Id = "BR_America_Fortaleza",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Fortaleza",
			FriendlyName = "Fortaleza",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Fortaleza",
		};

		private static readonly TimeZoneLocation BR_America_Maceio = new TimeZoneLocation()
		{
			Id = "BR_America_Maceio",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Maceio",
			FriendlyName = "Maceio",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Maceio",
		};

		private static readonly TimeZoneLocation BR_America_Recife = new TimeZoneLocation()
		{
			Id = "BR_America_Recife",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Recife",
			FriendlyName = "Recife",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Recife",
		};

		private static readonly TimeZoneLocation BR_America_Sao_Paulo = new TimeZoneLocation()
		{
			Id = "BR_America_Sao_Paulo",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Sao_Paulo",
			FriendlyName = "Sao Paulo",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Sao Paulo",
		};

		private static readonly TimeZoneLocation BR_America_Noronha = new TimeZoneLocation()
		{
			Id = "BR_America_Noronha",
			CountryCode = "BR",
			CountryName = "Brazil",
			OlsonTimeZone = "America/Noronha",
			FriendlyName = "Noronha",
			StandardGmtOffset = "-02:00",
			FullDisplayName = "(GMT-02:00) Noronha",
		};

		private static readonly TimeZoneLocation BS_America_Nassau = new TimeZoneLocation()
		{
			Id = "BS_America_Nassau",
			CountryCode = "BS",
			CountryName = "Bahamas",
			OlsonTimeZone = "America/Nassau",
			FriendlyName = "Nassau",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Nassau",
		};

		private static readonly TimeZoneLocation BT_Asia_Thimphu = new TimeZoneLocation()
		{
			Id = "BT_Asia_Thimphu",
			CountryCode = "BT",
			CountryName = "Bhutan",
			OlsonTimeZone = "Asia/Thimphu",
			FriendlyName = "Thimphu",
			StandardGmtOffset = "+06:00",
			FullDisplayName = "(GMT+06:00) Thimphu",
		};

		private static readonly TimeZoneLocation BV_Africa_Abidjan = new TimeZoneLocation()
		{
			Id = "BV_Africa_Abidjan",
			CountryCode = "BV",
			CountryName = "Bouvet Island",
			OlsonTimeZone = "Africa/Abidjan",
			FriendlyName = "Abidjan",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Abidjan",
		};

		private static readonly TimeZoneLocation BW_Africa_Maputo = new TimeZoneLocation()
		{
			Id = "BW_Africa_Maputo",
			CountryCode = "BW",
			CountryName = "Botswana",
			OlsonTimeZone = "Africa/Maputo",
			FriendlyName = "Maputo",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Maputo",
		};

		private static readonly TimeZoneLocation BY_Europe_Minsk = new TimeZoneLocation()
		{
			Id = "BY_Europe_Minsk",
			CountryCode = "BY",
			CountryName = "Belarus",
			OlsonTimeZone = "Europe/Minsk",
			FriendlyName = "Minsk",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Minsk",
		};

		private static readonly TimeZoneLocation BZ_America_Belize = new TimeZoneLocation()
		{
			Id = "BZ_America_Belize",
			CountryCode = "BZ",
			CountryName = "Belize",
			OlsonTimeZone = "America/Belize",
			FriendlyName = "Belize",
			StandardGmtOffset = "-06:00",
			FullDisplayName = "(GMT-06:00) Belize",
		};

		private static readonly TimeZoneLocation CA_America_Vancouver = new TimeZoneLocation()
		{
			Id = "CA_America_Vancouver",
			CountryCode = "CA",
			CountryName = "Canada",
			OlsonTimeZone = "America/Vancouver",
			FriendlyName = "Pacific Time - Vancouver",
			StandardGmtOffset = "-08:00",
			FullDisplayName = "(GMT-08:00) Pacific Time - Vancouver",
		};

		private static readonly TimeZoneLocation CA_America_Whitehorse = new TimeZoneLocation()
		{
			Id = "CA_America_Whitehorse",
			CountryCode = "CA",
			CountryName = "Canada",
			OlsonTimeZone = "America/Whitehorse",
			FriendlyName = "Pacific Time - Whitehorse",
			StandardGmtOffset = "-08:00",
			FullDisplayName = "(GMT-08:00) Pacific Time - Whitehorse",
		};

		private static readonly TimeZoneLocation CA_America_Dawson_Creek = new TimeZoneLocation()
		{
			Id = "CA_America_Dawson_Creek",
			CountryCode = "CA",
			CountryName = "Canada",
			OlsonTimeZone = "America/Dawson_Creek",
			FriendlyName = "Mountain Time - Dawson Creek",
			StandardGmtOffset = "-07:00",
			FullDisplayName = "(GMT-07:00) Mountain Time - Dawson Creek",
		};

		private static readonly TimeZoneLocation CA_America_Edmonton = new TimeZoneLocation()
		{
			Id = "CA_America_Edmonton",
			CountryCode = "CA",
			CountryName = "Canada",
			OlsonTimeZone = "America/Edmonton",
			FriendlyName = "Mountain Time - Edmonton",
			StandardGmtOffset = "-07:00",
			FullDisplayName = "(GMT-07:00) Mountain Time - Edmonton",
		};

		private static readonly TimeZoneLocation CA_America_Yellowknife = new TimeZoneLocation()
		{
			Id = "CA_America_Yellowknife",
			CountryCode = "CA",
			CountryName = "Canada",
			OlsonTimeZone = "America/Yellowknife",
			FriendlyName = "Mountain Time - Yellowknife",
			StandardGmtOffset = "-07:00",
			FullDisplayName = "(GMT-07:00) Mountain Time - Yellowknife",
		};

		private static readonly TimeZoneLocation CA_America_Regina = new TimeZoneLocation()
		{
			Id = "CA_America_Regina",
			CountryCode = "CA",
			CountryName = "Canada",
			OlsonTimeZone = "America/Regina",
			FriendlyName = "Central Time - Regina",
			StandardGmtOffset = "-06:00",
			FullDisplayName = "(GMT-06:00) Central Time - Regina",
		};

		private static readonly TimeZoneLocation CA_America_Winnipeg = new TimeZoneLocation()
		{
			Id = "CA_America_Winnipeg",
			CountryCode = "CA",
			CountryName = "Canada",
			OlsonTimeZone = "America/Winnipeg",
			FriendlyName = "Central Time - Winnipeg",
			StandardGmtOffset = "-06:00",
			FullDisplayName = "(GMT-06:00) Central Time - Winnipeg",
		};

		private static readonly TimeZoneLocation CA_America_Iqaluit = new TimeZoneLocation()
		{
			Id = "CA_America_Iqaluit",
			CountryCode = "CA",
			CountryName = "Canada",
			OlsonTimeZone = "America/Iqaluit",
			FriendlyName = "Eastern Time - Iqaluit",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Eastern Time - Iqaluit",
		};

		private static readonly TimeZoneLocation CA_America_Montreal = new TimeZoneLocation()
		{
			Id = "CA_America_Montreal",
			CountryCode = "CA",
			CountryName = "Canada",
			OlsonTimeZone = "America/Montreal",
			FriendlyName = "Eastern Time - Montreal",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Eastern Time - Montreal",
		};

		private static readonly TimeZoneLocation CA_America_Toronto = new TimeZoneLocation()
		{
			Id = "CA_America_Toronto",
			CountryCode = "CA",
			CountryName = "Canada",
			OlsonTimeZone = "America/Toronto",
			FriendlyName = "Eastern Time - Toronto",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Eastern Time - Toronto",
		};

		private static readonly TimeZoneLocation CA_America_Halifax = new TimeZoneLocation()
		{
			Id = "CA_America_Halifax",
			CountryCode = "CA",
			CountryName = "Canada",
			OlsonTimeZone = "America/Halifax",
			FriendlyName = "Atlantic Time - Halifax",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Atlantic Time - Halifax",
		};

		private static readonly TimeZoneLocation CA_America_St_Johns = new TimeZoneLocation()
		{
			Id = "CA_America_St_Johns",
			CountryCode = "CA",
			CountryName = "Canada",
			OlsonTimeZone = "America/St_Johns",
			FriendlyName = "Newfoundland Time - St. Johns",
			StandardGmtOffset = "-03:30",
			FullDisplayName = "(GMT-03:30) Newfoundland Time - St. Johns",
		};

		private static readonly TimeZoneLocation CC_Indian_Cocos = new TimeZoneLocation()
		{
			Id = "CC_Indian_Cocos",
			CountryCode = "CC",
			CountryName = "Cocos Islands",
			OlsonTimeZone = "Indian/Cocos",
			FriendlyName = "Cocos",
			StandardGmtOffset = "+06:30",
			FullDisplayName = "(GMT+06:30) Cocos",
		};

		private static readonly TimeZoneLocation CD_Africa_Lagos = new TimeZoneLocation()
		{
			Id = "CD_Africa_Lagos",
			CountryCode = "CD",
			CountryName = "Democratic Republic of the Congo",
			OlsonTimeZone = "Africa/Lagos",
			FriendlyName = "Lagos",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Lagos",
		};

		private static readonly TimeZoneLocation CD_Africa_Maputo = new TimeZoneLocation()
		{
			Id = "CD_Africa_Maputo",
			CountryCode = "CD",
			CountryName = "Democratic Republic of the Congo",
			OlsonTimeZone = "Africa/Maputo",
			FriendlyName = "Maputo",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Maputo",
		};

		private static readonly TimeZoneLocation CF_Africa_Lagos = new TimeZoneLocation()
		{
			Id = "CF_Africa_Lagos",
			CountryCode = "CF",
			CountryName = "Central African Republic",
			OlsonTimeZone = "Africa/Lagos",
			FriendlyName = "Lagos",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Lagos",
		};

		private static readonly TimeZoneLocation CG_Africa_Lagos = new TimeZoneLocation()
		{
			Id = "CG_Africa_Lagos",
			CountryCode = "CG",
			CountryName = "Republic of the Congo",
			OlsonTimeZone = "Africa/Lagos",
			FriendlyName = "Lagos",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Lagos",
		};

		private static readonly TimeZoneLocation CH_Europe_Zurich = new TimeZoneLocation()
		{
			Id = "CH_Europe_Zurich",
			CountryCode = "CH",
			CountryName = "Switzerland",
			OlsonTimeZone = "Europe/Zurich",
			FriendlyName = "Zurich",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Zurich",
		};

		private static readonly TimeZoneLocation CI_Africa_Abidjan = new TimeZoneLocation()
		{
			Id = "CI_Africa_Abidjan",
			CountryCode = "CI",
			CountryName = "Ivory Coast",
			OlsonTimeZone = "Africa/Abidjan",
			FriendlyName = "Abidjan",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Abidjan",
		};

		private static readonly TimeZoneLocation CK_Pacific_Rarotonga = new TimeZoneLocation()
		{
			Id = "CK_Pacific_Rarotonga",
			CountryCode = "CK",
			CountryName = "Cook Islands",
			OlsonTimeZone = "Pacific/Rarotonga",
			FriendlyName = "Rarotonga",
			StandardGmtOffset = "-10:00",
			FullDisplayName = "(GMT-10:00) Rarotonga",
		};

		private static readonly TimeZoneLocation CL_Pacific_Easter = new TimeZoneLocation()
		{
			Id = "CL_Pacific_Easter",
			CountryCode = "CL",
			CountryName = "Chile",
			OlsonTimeZone = "Pacific/Easter",
			FriendlyName = "Easter Island",
			StandardGmtOffset = "-06:00",
			FullDisplayName = "(GMT-06:00) Easter Island",
		};

		private static readonly TimeZoneLocation CL_America_Santiago = new TimeZoneLocation()
		{
			Id = "CL_America_Santiago",
			CountryCode = "CL",
			CountryName = "Chile",
			OlsonTimeZone = "America/Santiago",
			FriendlyName = "Santiago",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Santiago",
		};

		private static readonly TimeZoneLocation CM_Africa_Lagos = new TimeZoneLocation()
		{
			Id = "CM_Africa_Lagos",
			CountryCode = "CM",
			CountryName = "Cameroon",
			OlsonTimeZone = "Africa/Lagos",
			FriendlyName = "Lagos",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Lagos",
		};

		private static readonly TimeZoneLocation CN_Asia_Shanghai = new TimeZoneLocation()
		{
			Id = "CN_Asia_Shanghai",
			CountryCode = "CN",
			CountryName = "China",
			OlsonTimeZone = "Asia/Shanghai",
			FriendlyName = "China Time - Beijing",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) China Time - Beijing",
		};

		private static readonly TimeZoneLocation CO_America_Bogota = new TimeZoneLocation()
		{
			Id = "CO_America_Bogota",
			CountryCode = "CO",
			CountryName = "Colombia",
			OlsonTimeZone = "America/Bogota",
			FriendlyName = "Bogota",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Bogota",
		};

		private static readonly TimeZoneLocation CR_America_Costa_Rica = new TimeZoneLocation()
		{
			Id = "CR_America_Costa_Rica",
			CountryCode = "CR",
			CountryName = "Costa Rica",
			OlsonTimeZone = "America/Costa_Rica",
			FriendlyName = "Costa Rica",
			StandardGmtOffset = "-06:00",
			FullDisplayName = "(GMT-06:00) Costa Rica",
		};

		private static readonly TimeZoneLocation CS_Europe_Belgrade = new TimeZoneLocation()
		{
			Id = "CS_Europe_Belgrade",
			CountryCode = "CS",
			CountryName = "Serbia and Montenegro",
			OlsonTimeZone = "Europe/Belgrade",
			FriendlyName = "Central European Time - Belgrade",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Central European Time - Belgrade",
		};

		private static readonly TimeZoneLocation CU_America_Havana = new TimeZoneLocation()
		{
			Id = "CU_America_Havana",
			CountryCode = "CU",
			CountryName = "Cuba",
			OlsonTimeZone = "America/Havana",
			FriendlyName = "Havana",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Havana",
		};

		private static readonly TimeZoneLocation CV_Atlantic_Cape_Verde = new TimeZoneLocation()
		{
			Id = "CV_Atlantic_Cape_Verde",
			CountryCode = "CV",
			CountryName = "Cape Verde",
			OlsonTimeZone = "Atlantic/Cape_Verde",
			FriendlyName = "Cape Verde",
			StandardGmtOffset = "-01:00",
			FullDisplayName = "(GMT-01:00) Cape Verde",
		};

		private static readonly TimeZoneLocation CW_America_Curacao = new TimeZoneLocation()
		{
			Id = "CW_America_Curacao",
			CountryCode = "CW",
			CountryName = "Curacao",
			OlsonTimeZone = "America/Curacao",
			FriendlyName = "Curacao",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Curacao",
		};

		private static readonly TimeZoneLocation CX_Indian_Christmas = new TimeZoneLocation()
		{
			Id = "CX_Indian_Christmas",
			CountryCode = "CX",
			CountryName = "Christmas Island",
			OlsonTimeZone = "Indian/Christmas",
			FriendlyName = "Christmas",
			StandardGmtOffset = "+07:00",
			FullDisplayName = "(GMT+07:00) Christmas",
		};

		private static readonly TimeZoneLocation CY_Asia_Nicosia = new TimeZoneLocation()
		{
			Id = "CY_Asia_Nicosia",
			CountryCode = "CY",
			CountryName = "Cyprus",
			OlsonTimeZone = "Asia/Nicosia",
			FriendlyName = "Nicosia",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Nicosia",
		};

		private static readonly TimeZoneLocation CZ_Europe_Prague = new TimeZoneLocation()
		{
			Id = "CZ_Europe_Prague",
			CountryCode = "CZ",
			CountryName = "Czech Republic",
			OlsonTimeZone = "Europe/Prague",
			FriendlyName = "Central European Time - Prague",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Central European Time - Prague",
		};

		private static readonly TimeZoneLocation DE_Europe_Berlin = new TimeZoneLocation()
		{
			Id = "DE_Europe_Berlin",
			CountryCode = "DE",
			CountryName = "Germany",
			OlsonTimeZone = "Europe/Berlin",
			FriendlyName = "Berlin",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Berlin",
		};

		private static readonly TimeZoneLocation DJ_Africa_Nairobi = new TimeZoneLocation()
		{
			Id = "DJ_Africa_Nairobi",
			CountryCode = "DJ",
			CountryName = "Djibouti",
			OlsonTimeZone = "Africa/Nairobi",
			FriendlyName = "Nairobi",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Nairobi",
		};

		private static readonly TimeZoneLocation DK_Europe_Copenhagen = new TimeZoneLocation()
		{
			Id = "DK_Europe_Copenhagen",
			CountryCode = "DK",
			CountryName = "Denmark",
			OlsonTimeZone = "Europe/Copenhagen",
			FriendlyName = "Copenhagen",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Copenhagen",
		};

		private static readonly TimeZoneLocation DM_America_Port_of_Spain = new TimeZoneLocation()
		{
			Id = "DM_America_Port_of_Spain",
			CountryCode = "DM",
			CountryName = "Dominica",
			OlsonTimeZone = "America/Port_of_Spain",
			FriendlyName = "Port of Spain",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Port of Spain",
		};

		private static readonly TimeZoneLocation DO_America_Santo_Domingo = new TimeZoneLocation()
		{
			Id = "DO_America_Santo_Domingo",
			CountryCode = "DO",
			CountryName = "Dominican Republic",
			OlsonTimeZone = "America/Santo_Domingo",
			FriendlyName = "Santo Domingo",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Santo Domingo",
		};

		private static readonly TimeZoneLocation DZ_Africa_Algiers = new TimeZoneLocation()
		{
			Id = "DZ_Africa_Algiers",
			CountryCode = "DZ",
			CountryName = "Algeria",
			OlsonTimeZone = "Africa/Algiers",
			FriendlyName = "Algiers",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Algiers",
		};

		private static readonly TimeZoneLocation EC_Pacific_Galapagos = new TimeZoneLocation()
		{
			Id = "EC_Pacific_Galapagos",
			CountryCode = "EC",
			CountryName = "Ecuador",
			OlsonTimeZone = "Pacific/Galapagos",
			FriendlyName = "Galapagos",
			StandardGmtOffset = "-06:00",
			FullDisplayName = "(GMT-06:00) Galapagos",
		};

		private static readonly TimeZoneLocation EC_America_Guayaquil = new TimeZoneLocation()
		{
			Id = "EC_America_Guayaquil",
			CountryCode = "EC",
			CountryName = "Ecuador",
			OlsonTimeZone = "America/Guayaquil",
			FriendlyName = "Guayaquil",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Guayaquil",
		};

		private static readonly TimeZoneLocation EE_Europe_Tallinn = new TimeZoneLocation()
		{
			Id = "EE_Europe_Tallinn",
			CountryCode = "EE",
			CountryName = "Estonia",
			OlsonTimeZone = "Europe/Tallinn",
			FriendlyName = "Tallinn",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Tallinn",
		};

		private static readonly TimeZoneLocation EG_Africa_Cairo = new TimeZoneLocation()
		{
			Id = "EG_Africa_Cairo",
			CountryCode = "EG",
			CountryName = "Egypt",
			OlsonTimeZone = "Africa/Cairo",
			FriendlyName = "Cairo",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Cairo",
		};

		private static readonly TimeZoneLocation EH_Africa_El_Aaiun = new TimeZoneLocation()
		{
			Id = "EH_Africa_El_Aaiun",
			CountryCode = "EH",
			CountryName = "Western Sahara",
			OlsonTimeZone = "Africa/El_Aaiun",
			FriendlyName = "El Aaiun",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) El Aaiun",
		};

		private static readonly TimeZoneLocation ER_Africa_Nairobi = new TimeZoneLocation()
		{
			Id = "ER_Africa_Nairobi",
			CountryCode = "ER",
			CountryName = "Eritrea",
			OlsonTimeZone = "Africa/Nairobi",
			FriendlyName = "Nairobi",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Nairobi",
		};

		private static readonly TimeZoneLocation ES_Atlantic_Canary = new TimeZoneLocation()
		{
			Id = "ES_Atlantic_Canary",
			CountryCode = "ES",
			CountryName = "Spain",
			OlsonTimeZone = "Atlantic/Canary",
			FriendlyName = "Canary Islands",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Canary Islands",
		};

		private static readonly TimeZoneLocation ES_Africa_Ceuta = new TimeZoneLocation()
		{
			Id = "ES_Africa_Ceuta",
			CountryCode = "ES",
			CountryName = "Spain",
			OlsonTimeZone = "Africa/Ceuta",
			FriendlyName = "Ceuta",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Ceuta",
		};

		private static readonly TimeZoneLocation ES_Europe_Madrid = new TimeZoneLocation()
		{
			Id = "ES_Europe_Madrid",
			CountryCode = "ES",
			CountryName = "Spain",
			OlsonTimeZone = "Europe/Madrid",
			FriendlyName = "Madrid",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Madrid",
		};

		private static readonly TimeZoneLocation ET_Africa_Nairobi = new TimeZoneLocation()
		{
			Id = "ET_Africa_Nairobi",
			CountryCode = "ET",
			CountryName = "Ethiopia",
			OlsonTimeZone = "Africa/Nairobi",
			FriendlyName = "Nairobi",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Nairobi",
		};

		private static readonly TimeZoneLocation FI_Europe_Helsinki = new TimeZoneLocation()
		{
			Id = "FI_Europe_Helsinki",
			CountryCode = "FI",
			CountryName = "Finland",
			OlsonTimeZone = "Europe/Helsinki",
			FriendlyName = "Helsinki",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Helsinki",
		};

		private static readonly TimeZoneLocation FJ_Pacific_Fiji = new TimeZoneLocation()
		{
			Id = "FJ_Pacific_Fiji",
			CountryCode = "FJ",
			CountryName = "Fiji",
			OlsonTimeZone = "Pacific/Fiji",
			FriendlyName = "Fiji",
			StandardGmtOffset = "+12:00",
			FullDisplayName = "(GMT+12:00) Fiji",
		};

		private static readonly TimeZoneLocation FK_Atlantic_Stanley = new TimeZoneLocation()
		{
			Id = "FK_Atlantic_Stanley",
			CountryCode = "FK",
			CountryName = "Falkland Islands",
			OlsonTimeZone = "Atlantic/Stanley",
			FriendlyName = "Stanley",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Stanley",
		};

		private static readonly TimeZoneLocation FM_Pacific_Chuuk = new TimeZoneLocation()
		{
			Id = "FM_Pacific_Chuuk",
			CountryCode = "FM",
			CountryName = "Micronesia",
			OlsonTimeZone = "Pacific/Chuuk",
			FriendlyName = "Truk",
			StandardGmtOffset = "+10:00",
			FullDisplayName = "(GMT+10:00) Truk",
		};

		private static readonly TimeZoneLocation FM_Pacific_Kosrae = new TimeZoneLocation()
		{
			Id = "FM_Pacific_Kosrae",
			CountryCode = "FM",
			CountryName = "Micronesia",
			OlsonTimeZone = "Pacific/Kosrae",
			FriendlyName = "Kosrae",
			StandardGmtOffset = "+11:00",
			FullDisplayName = "(GMT+11:00) Kosrae",
		};

		private static readonly TimeZoneLocation FM_Pacific_Pohnpei = new TimeZoneLocation()
		{
			Id = "FM_Pacific_Pohnpei",
			CountryCode = "FM",
			CountryName = "Micronesia",
			OlsonTimeZone = "Pacific/Pohnpei",
			FriendlyName = "Ponape",
			StandardGmtOffset = "+11:00",
			FullDisplayName = "(GMT+11:00) Ponape",
		};

		private static readonly TimeZoneLocation FO_Atlantic_Faroe = new TimeZoneLocation()
		{
			Id = "FO_Atlantic_Faroe",
			CountryCode = "FO",
			CountryName = "Faroe Islands",
			OlsonTimeZone = "Atlantic/Faroe",
			FriendlyName = "Faeroe",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Faeroe",
		};

		private static readonly TimeZoneLocation FR_Europe_Paris = new TimeZoneLocation()
		{
			Id = "FR_Europe_Paris",
			CountryCode = "FR",
			CountryName = "France",
			OlsonTimeZone = "Europe/Paris",
			FriendlyName = "Paris",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Paris",
		};

		private static readonly TimeZoneLocation GA_Africa_Lagos = new TimeZoneLocation()
		{
			Id = "GA_Africa_Lagos",
			CountryCode = "GA",
			CountryName = "Gabon",
			OlsonTimeZone = "Africa/Lagos",
			FriendlyName = "Lagos",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Lagos",
		};

		private static readonly TimeZoneLocation GB_Europe_London = new TimeZoneLocation()
		{
			Id = "GB_Europe_London",
			CountryCode = "GB",
			CountryName = "United Kingdom",
			OlsonTimeZone = "Europe/London",
			FriendlyName = "London",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) London",
		};

		private static readonly TimeZoneLocation GD_America_Port_of_Spain = new TimeZoneLocation()
		{
			Id = "GD_America_Port_of_Spain",
			CountryCode = "GD",
			CountryName = "Grenada",
			OlsonTimeZone = "America/Port_of_Spain",
			FriendlyName = "Port of Spain",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Port of Spain",
		};

		private static readonly TimeZoneLocation GE_Asia_Tbilisi = new TimeZoneLocation()
		{
			Id = "GE_Asia_Tbilisi",
			CountryCode = "GE",
			CountryName = "Georgia",
			OlsonTimeZone = "Asia/Tbilisi",
			FriendlyName = "Tbilisi",
			StandardGmtOffset = "+04:00",
			FullDisplayName = "(GMT+04:00) Tbilisi",
		};

		private static readonly TimeZoneLocation GF_America_Cayenne = new TimeZoneLocation()
		{
			Id = "GF_America_Cayenne",
			CountryCode = "GF",
			CountryName = "French Guiana",
			OlsonTimeZone = "America/Cayenne",
			FriendlyName = "Cayenne",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Cayenne",
		};

		private static readonly TimeZoneLocation GG_Europe_London = new TimeZoneLocation()
		{
			Id = "GG_Europe_London",
			CountryCode = "GG",
			CountryName = "Guernsey",
			OlsonTimeZone = "Europe/London",
			FriendlyName = "London",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) London",
		};

		private static readonly TimeZoneLocation GH_Africa_Accra = new TimeZoneLocation()
		{
			Id = "GH_Africa_Accra",
			CountryCode = "GH",
			CountryName = "Ghana",
			OlsonTimeZone = "Africa/Accra",
			FriendlyName = "Accra",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Accra",
		};

		private static readonly TimeZoneLocation GI_Europe_Gibraltar = new TimeZoneLocation()
		{
			Id = "GI_Europe_Gibraltar",
			CountryCode = "GI",
			CountryName = "Gibraltar",
			OlsonTimeZone = "Europe/Gibraltar",
			FriendlyName = "Gibraltar",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Gibraltar",
		};

		private static readonly TimeZoneLocation GL_America_Thule = new TimeZoneLocation()
		{
			Id = "GL_America_Thule",
			CountryCode = "GL",
			CountryName = "Greenland",
			OlsonTimeZone = "America/Thule",
			FriendlyName = "Thule",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Thule",
		};

		private static readonly TimeZoneLocation GL_America_Godthab = new TimeZoneLocation()
		{
			Id = "GL_America_Godthab",
			CountryCode = "GL",
			CountryName = "Greenland",
			OlsonTimeZone = "America/Godthab",
			FriendlyName = "Godthab",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Godthab",
		};

		private static readonly TimeZoneLocation GL_America_Scoresbysund = new TimeZoneLocation()
		{
			Id = "GL_America_Scoresbysund",
			CountryCode = "GL",
			CountryName = "Greenland",
			OlsonTimeZone = "America/Scoresbysund",
			FriendlyName = "Scoresbysund",
			StandardGmtOffset = "-01:00",
			FullDisplayName = "(GMT-01:00) Scoresbysund",
		};

		private static readonly TimeZoneLocation GL_America_Danmarkshavn = new TimeZoneLocation()
		{
			Id = "GL_America_Danmarkshavn",
			CountryCode = "GL",
			CountryName = "Greenland",
			OlsonTimeZone = "America/Danmarkshavn",
			FriendlyName = "Danmarkshavn",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Danmarkshavn",
		};

		private static readonly TimeZoneLocation GM_Africa_Abidjan = new TimeZoneLocation()
		{
			Id = "GM_Africa_Abidjan",
			CountryCode = "GM",
			CountryName = "Gambia",
			OlsonTimeZone = "Africa/Abidjan",
			FriendlyName = "Abidjan",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Abidjan",
		};

		private static readonly TimeZoneLocation GN_Africa_Abidjan = new TimeZoneLocation()
		{
			Id = "GN_Africa_Abidjan",
			CountryCode = "GN",
			CountryName = "Guinea",
			OlsonTimeZone = "Africa/Abidjan",
			FriendlyName = "Abidjan",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Abidjan",
		};

		private static readonly TimeZoneLocation GP_America_Port_of_Spain = new TimeZoneLocation()
		{
			Id = "GP_America_Port_of_Spain",
			CountryCode = "GP",
			CountryName = "Guadeloupe",
			OlsonTimeZone = "America/Port_of_Spain",
			FriendlyName = "Port of Spain",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Port of Spain",
		};

		private static readonly TimeZoneLocation GQ_Africa_Lagos = new TimeZoneLocation()
		{
			Id = "GQ_Africa_Lagos",
			CountryCode = "GQ",
			CountryName = "Equatorial Guinea",
			OlsonTimeZone = "Africa/Lagos",
			FriendlyName = "Lagos",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Lagos",
		};

		private static readonly TimeZoneLocation GR_Europe_Athens = new TimeZoneLocation()
		{
			Id = "GR_Europe_Athens",
			CountryCode = "GR",
			CountryName = "Greece",
			OlsonTimeZone = "Europe/Athens",
			FriendlyName = "Athens",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Athens",
		};

		private static readonly TimeZoneLocation GS_Atlantic_South_Georgia = new TimeZoneLocation()
		{
			Id = "GS_Atlantic_South_Georgia",
			CountryCode = "GS",
			CountryName = "South Georgia and the South Sandwich Islands",
			OlsonTimeZone = "Atlantic/South_Georgia",
			FriendlyName = "South Georgia",
			StandardGmtOffset = "-02:00",
			FullDisplayName = "(GMT-02:00) South Georgia",
		};

		private static readonly TimeZoneLocation GT_America_Guatemala = new TimeZoneLocation()
		{
			Id = "GT_America_Guatemala",
			CountryCode = "GT",
			CountryName = "Guatemala",
			OlsonTimeZone = "America/Guatemala",
			FriendlyName = "Guatemala",
			StandardGmtOffset = "-06:00",
			FullDisplayName = "(GMT-06:00) Guatemala",
		};

		private static readonly TimeZoneLocation GU_Pacific_Guam = new TimeZoneLocation()
		{
			Id = "GU_Pacific_Guam",
			CountryCode = "GU",
			CountryName = "Guam",
			OlsonTimeZone = "Pacific/Guam",
			FriendlyName = "Guam",
			StandardGmtOffset = "+10:00",
			FullDisplayName = "(GMT+10:00) Guam",
		};

		private static readonly TimeZoneLocation GW_Africa_Bissau = new TimeZoneLocation()
		{
			Id = "GW_Africa_Bissau",
			CountryCode = "GW",
			CountryName = "Guinea-Bissau",
			OlsonTimeZone = "Africa/Bissau",
			FriendlyName = "Bissau",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Bissau",
		};

		private static readonly TimeZoneLocation GY_America_Guyana = new TimeZoneLocation()
		{
			Id = "GY_America_Guyana",
			CountryCode = "GY",
			CountryName = "Guyana",
			OlsonTimeZone = "America/Guyana",
			FriendlyName = "Guyana",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Guyana",
		};

		private static readonly TimeZoneLocation HK_Asia_Hong_Kong = new TimeZoneLocation()
		{
			Id = "HK_Asia_Hong_Kong",
			CountryCode = "HK",
			CountryName = "Hong Kong",
			OlsonTimeZone = "Asia/Hong_Kong",
			FriendlyName = "Hong Kong",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) Hong Kong",
		};

		private static readonly TimeZoneLocation HM_Indian_Kerguelen = new TimeZoneLocation()
		{
			Id = "HM_Indian_Kerguelen",
			CountryCode = "HM",
			CountryName = "Heard Island and McDonald Islands",
			OlsonTimeZone = "Indian/Kerguelen",
			FriendlyName = "Kerguelen",
			StandardGmtOffset = "+05:00",
			FullDisplayName = "(GMT+05:00) Kerguelen",
		};

		private static readonly TimeZoneLocation HN_America_Tegucigalpa = new TimeZoneLocation()
		{
			Id = "HN_America_Tegucigalpa",
			CountryCode = "HN",
			CountryName = "Honduras",
			OlsonTimeZone = "America/Tegucigalpa",
			FriendlyName = "Central Time - Tegucigalpa",
			StandardGmtOffset = "-06:00",
			FullDisplayName = "(GMT-06:00) Central Time - Tegucigalpa",
		};

		private static readonly TimeZoneLocation HR_Europe_Belgrade = new TimeZoneLocation()
		{
			Id = "HR_Europe_Belgrade",
			CountryCode = "HR",
			CountryName = "Croatia",
			OlsonTimeZone = "Europe/Belgrade",
			FriendlyName = "Central European Time - Belgrade",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Central European Time - Belgrade",
		};

		private static readonly TimeZoneLocation HT_America_Port_au_Prince = new TimeZoneLocation()
		{
			Id = "HT_America_Port_au_Prince",
			CountryCode = "HT",
			CountryName = "Haiti",
			OlsonTimeZone = "America/Port-au-Prince",
			FriendlyName = "Port-au-Prince",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Port-au-Prince",
		};

		private static readonly TimeZoneLocation HU_Europe_Budapest = new TimeZoneLocation()
		{
			Id = "HU_Europe_Budapest",
			CountryCode = "HU",
			CountryName = "Hungary",
			OlsonTimeZone = "Europe/Budapest",
			FriendlyName = "Budapest",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Budapest",
		};

		private static readonly TimeZoneLocation ID_Asia_Jakarta = new TimeZoneLocation()
		{
			Id = "ID_Asia_Jakarta",
			CountryCode = "ID",
			CountryName = "Indonesia",
			OlsonTimeZone = "Asia/Jakarta",
			FriendlyName = "Jakarta",
			StandardGmtOffset = "+07:00",
			FullDisplayName = "(GMT+07:00) Jakarta",
		};

		private static readonly TimeZoneLocation ID_Asia_Makassar = new TimeZoneLocation()
		{
			Id = "ID_Asia_Makassar",
			CountryCode = "ID",
			CountryName = "Indonesia",
			OlsonTimeZone = "Asia/Makassar",
			FriendlyName = "Makassar",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) Makassar",
		};

		private static readonly TimeZoneLocation ID_Asia_Jayapura = new TimeZoneLocation()
		{
			Id = "ID_Asia_Jayapura",
			CountryCode = "ID",
			CountryName = "Indonesia",
			OlsonTimeZone = "Asia/Jayapura",
			FriendlyName = "Jayapura",
			StandardGmtOffset = "+09:00",
			FullDisplayName = "(GMT+09:00) Jayapura",
		};

		private static readonly TimeZoneLocation IE_Europe_Dublin = new TimeZoneLocation()
		{
			Id = "IE_Europe_Dublin",
			CountryCode = "IE",
			CountryName = "Ireland",
			OlsonTimeZone = "Europe/Dublin",
			FriendlyName = "Dublin",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Dublin",
		};

		private static readonly TimeZoneLocation IL_Asia_Jerusalem = new TimeZoneLocation()
		{
			Id = "IL_Asia_Jerusalem",
			CountryCode = "IL",
			CountryName = "Israel",
			OlsonTimeZone = "Asia/Jerusalem",
			FriendlyName = "Jerusalem",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Jerusalem",
		};

		private static readonly TimeZoneLocation IM_Europe_London = new TimeZoneLocation()
		{
			Id = "IM_Europe_London",
			CountryCode = "IM",
			CountryName = "Isle of Man",
			OlsonTimeZone = "Europe/London",
			FriendlyName = "London",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) London",
		};

		private static readonly TimeZoneLocation IN_Asia_Calcutta = new TimeZoneLocation()
		{
			Id = "IN_Asia_Calcutta",
			CountryCode = "IN",
			CountryName = "India",
			OlsonTimeZone = "Asia/Calcutta",
			FriendlyName = "India Standard Time",
			StandardGmtOffset = "+05:30",
			FullDisplayName = "(GMT+05:30) India Standard Time",
		};

		private static readonly TimeZoneLocation IO_Indian_Chagos = new TimeZoneLocation()
		{
			Id = "IO_Indian_Chagos",
			CountryCode = "IO",
			CountryName = "British Indian Ocean Territory",
			OlsonTimeZone = "Indian/Chagos",
			FriendlyName = "Chagos",
			StandardGmtOffset = "+06:00",
			FullDisplayName = "(GMT+06:00) Chagos",
		};

		private static readonly TimeZoneLocation IQ_Asia_Baghdad = new TimeZoneLocation()
		{
			Id = "IQ_Asia_Baghdad",
			CountryCode = "IQ",
			CountryName = "Iraq",
			OlsonTimeZone = "Asia/Baghdad",
			FriendlyName = "Baghdad",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Baghdad",
		};

		private static readonly TimeZoneLocation IR_Asia_Tehran = new TimeZoneLocation()
		{
			Id = "IR_Asia_Tehran",
			CountryCode = "IR",
			CountryName = "Iran",
			OlsonTimeZone = "Asia/Tehran",
			FriendlyName = "Tehran",
			StandardGmtOffset = "+03:30",
			FullDisplayName = "(GMT+03:30) Tehran",
		};

		private static readonly TimeZoneLocation IS_Atlantic_Reykjavik = new TimeZoneLocation()
		{
			Id = "IS_Atlantic_Reykjavik",
			CountryCode = "IS",
			CountryName = "Iceland",
			OlsonTimeZone = "Atlantic/Reykjavik",
			FriendlyName = "Reykjavik",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Reykjavik",
		};

		private static readonly TimeZoneLocation IT_Europe_Rome = new TimeZoneLocation()
		{
			Id = "IT_Europe_Rome",
			CountryCode = "IT",
			CountryName = "Italy",
			OlsonTimeZone = "Europe/Rome",
			FriendlyName = "Rome",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Rome",
		};

		private static readonly TimeZoneLocation JE_Europe_London = new TimeZoneLocation()
		{
			Id = "JE_Europe_London",
			CountryCode = "JE",
			CountryName = "Jersey",
			OlsonTimeZone = "Europe/London",
			FriendlyName = "London",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) London",
		};

		private static readonly TimeZoneLocation JM_America_Jamaica = new TimeZoneLocation()
		{
			Id = "JM_America_Jamaica",
			CountryCode = "JM",
			CountryName = "Jamaica",
			OlsonTimeZone = "America/Jamaica",
			FriendlyName = "Jamaica",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Jamaica",
		};

		private static readonly TimeZoneLocation JO_Asia_Amman = new TimeZoneLocation()
		{
			Id = "JO_Asia_Amman",
			CountryCode = "JO",
			CountryName = "Jordan",
			OlsonTimeZone = "Asia/Amman",
			FriendlyName = "Amman",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Amman",
		};

		private static readonly TimeZoneLocation JP_Asia_Tokyo = new TimeZoneLocation()
		{
			Id = "JP_Asia_Tokyo",
			CountryCode = "JP",
			CountryName = "Japan",
			OlsonTimeZone = "Asia/Tokyo",
			FriendlyName = "Tokyo",
			StandardGmtOffset = "+09:00",
			FullDisplayName = "(GMT+09:00) Tokyo",
		};

		private static readonly TimeZoneLocation KE_Africa_Nairobi = new TimeZoneLocation()
		{
			Id = "KE_Africa_Nairobi",
			CountryCode = "KE",
			CountryName = "Kenya",
			OlsonTimeZone = "Africa/Nairobi",
			FriendlyName = "Nairobi",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Nairobi",
		};

		private static readonly TimeZoneLocation KG_Asia_Bishkek = new TimeZoneLocation()
		{
			Id = "KG_Asia_Bishkek",
			CountryCode = "KG",
			CountryName = "Kyrgyzstan",
			OlsonTimeZone = "Asia/Bishkek",
			FriendlyName = "Bishkek",
			StandardGmtOffset = "+06:00",
			FullDisplayName = "(GMT+06:00) Bishkek",
		};

		private static readonly TimeZoneLocation KH_Asia_Bangkok = new TimeZoneLocation()
		{
			Id = "KH_Asia_Bangkok",
			CountryCode = "KH",
			CountryName = "Cambodia",
			OlsonTimeZone = "Asia/Bangkok",
			FriendlyName = "Bangkok",
			StandardGmtOffset = "+07:00",
			FullDisplayName = "(GMT+07:00) Bangkok",
		};

		private static readonly TimeZoneLocation KI_Pacific_Tarawa = new TimeZoneLocation()
		{
			Id = "KI_Pacific_Tarawa",
			CountryCode = "KI",
			CountryName = "Kiribati",
			OlsonTimeZone = "Pacific/Tarawa",
			FriendlyName = "Tarawa",
			StandardGmtOffset = "+12:00",
			FullDisplayName = "(GMT+12:00) Tarawa",
		};

		private static readonly TimeZoneLocation KI_Pacific_Kiritimati = new TimeZoneLocation()
		{
			Id = "KI_Pacific_Kiritimati",
			CountryCode = "KI",
			CountryName = "Kiribati",
			OlsonTimeZone = "Pacific/Kiritimati",
			FriendlyName = "Kiritimati",
			StandardGmtOffset = "+14:00",
			FullDisplayName = "(GMT+14:00) Kiritimati",
		};

		private static readonly TimeZoneLocation KM_Africa_Nairobi = new TimeZoneLocation()
		{
			Id = "KM_Africa_Nairobi",
			CountryCode = "KM",
			CountryName = "Comoros",
			OlsonTimeZone = "Africa/Nairobi",
			FriendlyName = "Nairobi",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Nairobi",
		};

		private static readonly TimeZoneLocation KN_America_Port_of_Spain = new TimeZoneLocation()
		{
			Id = "KN_America_Port_of_Spain",
			CountryCode = "KN",
			CountryName = "Saint Kitts and Nevis",
			OlsonTimeZone = "America/Port_of_Spain",
			FriendlyName = "Port of Spain",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Port of Spain",
		};

		private static readonly TimeZoneLocation KP_Asia_Pyongyang = new TimeZoneLocation()
		{
			Id = "KP_Asia_Pyongyang",
			CountryCode = "KP",
			CountryName = "North Korea",
			OlsonTimeZone = "Asia/Pyongyang",
			FriendlyName = "Pyongyang",
			StandardGmtOffset = "+09:00",
			FullDisplayName = "(GMT+09:00) Pyongyang",
		};

		private static readonly TimeZoneLocation KR_Asia_Seoul = new TimeZoneLocation()
		{
			Id = "KR_Asia_Seoul",
			CountryCode = "KR",
			CountryName = "South Korea",
			OlsonTimeZone = "Asia/Seoul",
			FriendlyName = "Seoul",
			StandardGmtOffset = "+09:00",
			FullDisplayName = "(GMT+09:00) Seoul",
		};

		private static readonly TimeZoneLocation KW_Asia_Kuwait = new TimeZoneLocation()
		{
			Id = "KW_Asia_Kuwait",
			CountryCode = "KW",
			CountryName = "Kuwait",
			OlsonTimeZone = "Asia/Kuwait",
			FriendlyName = "Kuwait",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Kuwait",
		};

		private static readonly TimeZoneLocation KY_America_Cayman = new TimeZoneLocation()
		{
			Id = "KY_America_Cayman",
			CountryCode = "KY",
			CountryName = "Cayman Islands",
			OlsonTimeZone = "America/Cayman",
			FriendlyName = "Cayman",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Cayman",
		};

		private static readonly TimeZoneLocation KZ_Asia_Aqtau = new TimeZoneLocation()
		{
			Id = "KZ_Asia_Aqtau",
			CountryCode = "KZ",
			CountryName = "Kazakhstan",
			OlsonTimeZone = "Asia/Aqtau",
			FriendlyName = "Aqtau",
			StandardGmtOffset = "+05:00",
			FullDisplayName = "(GMT+05:00) Aqtau",
		};

		private static readonly TimeZoneLocation KZ_Asia_Aqtobe = new TimeZoneLocation()
		{
			Id = "KZ_Asia_Aqtobe",
			CountryCode = "KZ",
			CountryName = "Kazakhstan",
			OlsonTimeZone = "Asia/Aqtobe",
			FriendlyName = "Aqtobe",
			StandardGmtOffset = "+05:00",
			FullDisplayName = "(GMT+05:00) Aqtobe",
		};

		private static readonly TimeZoneLocation KZ_Asia_Almaty = new TimeZoneLocation()
		{
			Id = "KZ_Asia_Almaty",
			CountryCode = "KZ",
			CountryName = "Kazakhstan",
			OlsonTimeZone = "Asia/Almaty",
			FriendlyName = "Almaty",
			StandardGmtOffset = "+06:00",
			FullDisplayName = "(GMT+06:00) Almaty",
		};

		private static readonly TimeZoneLocation LA_Asia_Bangkok = new TimeZoneLocation()
		{
			Id = "LA_Asia_Bangkok",
			CountryCode = "LA",
			CountryName = "Laos",
			OlsonTimeZone = "Asia/Bangkok",
			FriendlyName = "Bangkok",
			StandardGmtOffset = "+07:00",
			FullDisplayName = "(GMT+07:00) Bangkok",
		};

		private static readonly TimeZoneLocation LB_Asia_Beirut = new TimeZoneLocation()
		{
			Id = "LB_Asia_Beirut",
			CountryCode = "LB",
			CountryName = "Lebanon",
			OlsonTimeZone = "Asia/Beirut",
			FriendlyName = "Beirut",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Beirut",
		};

		private static readonly TimeZoneLocation LC_America_Port_of_Spain = new TimeZoneLocation()
		{
			Id = "LC_America_Port_of_Spain",
			CountryCode = "LC",
			CountryName = "Saint Lucia",
			OlsonTimeZone = "America/Port_of_Spain",
			FriendlyName = "Port of Spain",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Port of Spain",
		};

		private static readonly TimeZoneLocation LI_Europe_Zurich = new TimeZoneLocation()
		{
			Id = "LI_Europe_Zurich",
			CountryCode = "LI",
			CountryName = "Liechtenstein",
			OlsonTimeZone = "Europe/Zurich",
			FriendlyName = "Zurich",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Zurich",
		};

		private static readonly TimeZoneLocation LK_Asia_Colombo = new TimeZoneLocation()
		{
			Id = "LK_Asia_Colombo",
			CountryCode = "LK",
			CountryName = "Sri Lanka",
			OlsonTimeZone = "Asia/Colombo",
			FriendlyName = "Colombo",
			StandardGmtOffset = "+05:30",
			FullDisplayName = "(GMT+05:30) Colombo",
		};

		private static readonly TimeZoneLocation LR_Africa_Monrovia = new TimeZoneLocation()
		{
			Id = "LR_Africa_Monrovia",
			CountryCode = "LR",
			CountryName = "Liberia",
			OlsonTimeZone = "Africa/Monrovia",
			FriendlyName = "Monrovia",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Monrovia",
		};

		private static readonly TimeZoneLocation LS_Africa_Johannesburg = new TimeZoneLocation()
		{
			Id = "LS_Africa_Johannesburg",
			CountryCode = "LS",
			CountryName = "Lesotho",
			OlsonTimeZone = "Africa/Johannesburg",
			FriendlyName = "Johannesburg",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Johannesburg",
		};

		private static readonly TimeZoneLocation LT_Europe_Vilnius = new TimeZoneLocation()
		{
			Id = "LT_Europe_Vilnius",
			CountryCode = "LT",
			CountryName = "Lithuania",
			OlsonTimeZone = "Europe/Vilnius",
			FriendlyName = "Vilnius",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Vilnius",
		};

		private static readonly TimeZoneLocation LU_Europe_Luxembourg = new TimeZoneLocation()
		{
			Id = "LU_Europe_Luxembourg",
			CountryCode = "LU",
			CountryName = "Luxembourg",
			OlsonTimeZone = "Europe/Luxembourg",
			FriendlyName = "Luxembourg",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Luxembourg",
		};

		private static readonly TimeZoneLocation LV_Europe_Riga = new TimeZoneLocation()
		{
			Id = "LV_Europe_Riga",
			CountryCode = "LV",
			CountryName = "Latvia",
			OlsonTimeZone = "Europe/Riga",
			FriendlyName = "Riga",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Riga",
		};

		private static readonly TimeZoneLocation LY_Africa_Tripoli = new TimeZoneLocation()
		{
			Id = "LY_Africa_Tripoli",
			CountryCode = "LY",
			CountryName = "Libya",
			OlsonTimeZone = "Africa/Tripoli",
			FriendlyName = "Tripoli",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Tripoli",
		};

		private static readonly TimeZoneLocation MA_Africa_Casablanca = new TimeZoneLocation()
		{
			Id = "MA_Africa_Casablanca",
			CountryCode = "MA",
			CountryName = "Morocco",
			OlsonTimeZone = "Africa/Casablanca",
			FriendlyName = "Casablanca",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Casablanca",
		};

		private static readonly TimeZoneLocation MC_Europe_Monaco = new TimeZoneLocation()
		{
			Id = "MC_Europe_Monaco",
			CountryCode = "MC",
			CountryName = "Monaco",
			OlsonTimeZone = "Europe/Monaco",
			FriendlyName = "Monaco",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Monaco",
		};

		private static readonly TimeZoneLocation MD_Europe_Chisinau = new TimeZoneLocation()
		{
			Id = "MD_Europe_Chisinau",
			CountryCode = "MD",
			CountryName = "Moldova",
			OlsonTimeZone = "Europe/Chisinau",
			FriendlyName = "Chisinau",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Chisinau",
		};

		private static readonly TimeZoneLocation ME_Europe_Belgrade = new TimeZoneLocation()
		{
			Id = "ME_Europe_Belgrade",
			CountryCode = "ME",
			CountryName = "Montenegro",
			OlsonTimeZone = "Europe/Belgrade",
			FriendlyName = "Central European Time - Belgrade",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Central European Time - Belgrade",
		};

		private static readonly TimeZoneLocation MF_America_Port_of_Spain = new TimeZoneLocation()
		{
			Id = "MF_America_Port_of_Spain",
			CountryCode = "MF",
			CountryName = "Saint Martin",
			OlsonTimeZone = "America/Port_of_Spain",
			FriendlyName = "Port of Spain",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Port of Spain",
		};

		private static readonly TimeZoneLocation MG_Africa_Nairobi = new TimeZoneLocation()
		{
			Id = "MG_Africa_Nairobi",
			CountryCode = "MG",
			CountryName = "Madagascar",
			OlsonTimeZone = "Africa/Nairobi",
			FriendlyName = "Nairobi",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Nairobi",
		};

		private static readonly TimeZoneLocation MH_Pacific_Kwajalein = new TimeZoneLocation()
		{
			Id = "MH_Pacific_Kwajalein",
			CountryCode = "MH",
			CountryName = "Marshall Islands",
			OlsonTimeZone = "Pacific/Kwajalein",
			FriendlyName = "Kwajalein",
			StandardGmtOffset = "+12:00",
			FullDisplayName = "(GMT+12:00) Kwajalein",
		};

		private static readonly TimeZoneLocation MH_Pacific_Majuro = new TimeZoneLocation()
		{
			Id = "MH_Pacific_Majuro",
			CountryCode = "MH",
			CountryName = "Marshall Islands",
			OlsonTimeZone = "Pacific/Majuro",
			FriendlyName = "Majuro",
			StandardGmtOffset = "+12:00",
			FullDisplayName = "(GMT+12:00) Majuro",
		};

		private static readonly TimeZoneLocation MK_Europe_Belgrade = new TimeZoneLocation()
		{
			Id = "MK_Europe_Belgrade",
			CountryCode = "MK",
			CountryName = "Macedonia",
			OlsonTimeZone = "Europe/Belgrade",
			FriendlyName = "Central European Time - Belgrade",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Central European Time - Belgrade",
		};

		private static readonly TimeZoneLocation ML_Africa_Abidjan = new TimeZoneLocation()
		{
			Id = "ML_Africa_Abidjan",
			CountryCode = "ML",
			CountryName = "Mali",
			OlsonTimeZone = "Africa/Abidjan",
			FriendlyName = "Abidjan",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Abidjan",
		};

		private static readonly TimeZoneLocation MM_Asia_Rangoon = new TimeZoneLocation()
		{
			Id = "MM_Asia_Rangoon",
			CountryCode = "MM",
			CountryName = "Myanmar",
			OlsonTimeZone = "Asia/Rangoon",
			FriendlyName = "Rangoon",
			StandardGmtOffset = "+06:30",
			FullDisplayName = "(GMT+06:30) Rangoon",
		};

		private static readonly TimeZoneLocation MN_Asia_Hovd = new TimeZoneLocation()
		{
			Id = "MN_Asia_Hovd",
			CountryCode = "MN",
			CountryName = "Mongolia",
			OlsonTimeZone = "Asia/Hovd",
			FriendlyName = "Hovd",
			StandardGmtOffset = "+07:00",
			FullDisplayName = "(GMT+07:00) Hovd",
		};

		private static readonly TimeZoneLocation MN_Asia_Choibalsan = new TimeZoneLocation()
		{
			Id = "MN_Asia_Choibalsan",
			CountryCode = "MN",
			CountryName = "Mongolia",
			OlsonTimeZone = "Asia/Choibalsan",
			FriendlyName = "Choibalsan",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) Choibalsan",
		};

		private static readonly TimeZoneLocation MN_Asia_Ulaanbaatar = new TimeZoneLocation()
		{
			Id = "MN_Asia_Ulaanbaatar",
			CountryCode = "MN",
			CountryName = "Mongolia",
			OlsonTimeZone = "Asia/Ulaanbaatar",
			FriendlyName = "Ulaanbaatar",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) Ulaanbaatar",
		};

		private static readonly TimeZoneLocation MO_Asia_Macau = new TimeZoneLocation()
		{
			Id = "MO_Asia_Macau",
			CountryCode = "MO",
			CountryName = "Macao",
			OlsonTimeZone = "Asia/Macau",
			FriendlyName = "Macau",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) Macau",
		};

		private static readonly TimeZoneLocation MP_Pacific_Saipan = new TimeZoneLocation()
		{
			Id = "MP_Pacific_Saipan",
			CountryCode = "MP",
			CountryName = "Northern Mariana Islands",
			OlsonTimeZone = "Pacific/Saipan",
			FriendlyName = "Saipan",
			StandardGmtOffset = "+10:00",
			FullDisplayName = "(GMT+10:00) Saipan",
		};

		private static readonly TimeZoneLocation MQ_America_Martinique = new TimeZoneLocation()
		{
			Id = "MQ_America_Martinique",
			CountryCode = "MQ",
			CountryName = "Martinique",
			OlsonTimeZone = "America/Martinique",
			FriendlyName = "Martinique",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Martinique",
		};

		private static readonly TimeZoneLocation MR_Africa_Abidjan = new TimeZoneLocation()
		{
			Id = "MR_Africa_Abidjan",
			CountryCode = "MR",
			CountryName = "Mauritania",
			OlsonTimeZone = "Africa/Abidjan",
			FriendlyName = "Abidjan",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Abidjan",
		};

		private static readonly TimeZoneLocation MS_America_Port_of_Spain = new TimeZoneLocation()
		{
			Id = "MS_America_Port_of_Spain",
			CountryCode = "MS",
			CountryName = "Montserrat",
			OlsonTimeZone = "America/Port_of_Spain",
			FriendlyName = "Port of Spain",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Port of Spain",
		};

		private static readonly TimeZoneLocation MT_Europe_Malta = new TimeZoneLocation()
		{
			Id = "MT_Europe_Malta",
			CountryCode = "MT",
			CountryName = "Malta",
			OlsonTimeZone = "Europe/Malta",
			FriendlyName = "Malta",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Malta",
		};

		private static readonly TimeZoneLocation MU_Indian_Mauritius = new TimeZoneLocation()
		{
			Id = "MU_Indian_Mauritius",
			CountryCode = "MU",
			CountryName = "Mauritius",
			OlsonTimeZone = "Indian/Mauritius",
			FriendlyName = "Mauritius",
			StandardGmtOffset = "+04:00",
			FullDisplayName = "(GMT+04:00) Mauritius",
		};

		private static readonly TimeZoneLocation MV_Indian_Maldives = new TimeZoneLocation()
		{
			Id = "MV_Indian_Maldives",
			CountryCode = "MV",
			CountryName = "Maldives",
			OlsonTimeZone = "Indian/Maldives",
			FriendlyName = "Maldives",
			StandardGmtOffset = "+05:00",
			FullDisplayName = "(GMT+05:00) Maldives",
		};

		private static readonly TimeZoneLocation MW_Africa_Maputo = new TimeZoneLocation()
		{
			Id = "MW_Africa_Maputo",
			CountryCode = "MW",
			CountryName = "Malawi",
			OlsonTimeZone = "Africa/Maputo",
			FriendlyName = "Maputo",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Maputo",
		};

		private static readonly TimeZoneLocation MX_America_Tijuana = new TimeZoneLocation()
		{
			Id = "MX_America_Tijuana",
			CountryCode = "MX",
			CountryName = "Mexico",
			OlsonTimeZone = "America/Tijuana",
			FriendlyName = "Pacific Time - Tijuana",
			StandardGmtOffset = "-08:00",
			FullDisplayName = "(GMT-08:00) Pacific Time - Tijuana",
		};

		private static readonly TimeZoneLocation MX_America_Hermosillo = new TimeZoneLocation()
		{
			Id = "MX_America_Hermosillo",
			CountryCode = "MX",
			CountryName = "Mexico",
			OlsonTimeZone = "America/Hermosillo",
			FriendlyName = "Mountain Time - Hermosillo",
			StandardGmtOffset = "-07:00",
			FullDisplayName = "(GMT-07:00) Mountain Time - Hermosillo",
		};

		private static readonly TimeZoneLocation MX_America_Mazatlan = new TimeZoneLocation()
		{
			Id = "MX_America_Mazatlan",
			CountryCode = "MX",
			CountryName = "Mexico",
			OlsonTimeZone = "America/Mazatlan",
			FriendlyName = "Mountain Time - Chihuahua, Mazatlan",
			StandardGmtOffset = "-07:00",
			FullDisplayName = "(GMT-07:00) Mountain Time - Chihuahua, Mazatlan",
		};

		private static readonly TimeZoneLocation MX_America_Mexico_City = new TimeZoneLocation()
		{
			Id = "MX_America_Mexico_City",
			CountryCode = "MX",
			CountryName = "Mexico",
			OlsonTimeZone = "America/Mexico_City",
			FriendlyName = "Central Time - Mexico City",
			StandardGmtOffset = "-06:00",
			FullDisplayName = "(GMT-06:00) Central Time - Mexico City",
		};

		private static readonly TimeZoneLocation MY_Asia_Kuala_Lumpur = new TimeZoneLocation()
		{
			Id = "MY_Asia_Kuala_Lumpur",
			CountryCode = "MY",
			CountryName = "Malaysia",
			OlsonTimeZone = "Asia/Kuala_Lumpur",
			FriendlyName = "Kuala Lumpur",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) Kuala Lumpur",
		};

		private static readonly TimeZoneLocation MZ_Africa_Maputo = new TimeZoneLocation()
		{
			Id = "MZ_Africa_Maputo",
			CountryCode = "MZ",
			CountryName = "Mozambique",
			OlsonTimeZone = "Africa/Maputo",
			FriendlyName = "Maputo",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Maputo",
		};

		private static readonly TimeZoneLocation NA_Africa_Windhoek = new TimeZoneLocation()
		{
			Id = "NA_Africa_Windhoek",
			CountryCode = "NA",
			CountryName = "Namibia",
			OlsonTimeZone = "Africa/Windhoek",
			FriendlyName = "Windhoek",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Windhoek",
		};

		private static readonly TimeZoneLocation NC_Pacific_Noumea = new TimeZoneLocation()
		{
			Id = "NC_Pacific_Noumea",
			CountryCode = "NC",
			CountryName = "New Caledonia",
			OlsonTimeZone = "Pacific/Noumea",
			FriendlyName = "Noumea",
			StandardGmtOffset = "+11:00",
			FullDisplayName = "(GMT+11:00) Noumea",
		};

		private static readonly TimeZoneLocation NE_Africa_Lagos = new TimeZoneLocation()
		{
			Id = "NE_Africa_Lagos",
			CountryCode = "NE",
			CountryName = "Niger",
			OlsonTimeZone = "Africa/Lagos",
			FriendlyName = "Lagos",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Lagos",
		};

		private static readonly TimeZoneLocation NF_Pacific_Norfolk = new TimeZoneLocation()
		{
			Id = "NF_Pacific_Norfolk",
			CountryCode = "NF",
			CountryName = "Norfolk Island",
			OlsonTimeZone = "Pacific/Norfolk",
			FriendlyName = "Norfolk",
			StandardGmtOffset = "+11:30",
			FullDisplayName = "(GMT+11:30) Norfolk",
		};

		private static readonly TimeZoneLocation NG_Africa_Lagos = new TimeZoneLocation()
		{
			Id = "NG_Africa_Lagos",
			CountryCode = "NG",
			CountryName = "Nigeria",
			OlsonTimeZone = "Africa/Lagos",
			FriendlyName = "Lagos",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Lagos",
		};

		private static readonly TimeZoneLocation NI_America_Managua = new TimeZoneLocation()
		{
			Id = "NI_America_Managua",
			CountryCode = "NI",
			CountryName = "Nicaragua",
			OlsonTimeZone = "America/Managua",
			FriendlyName = "Managua",
			StandardGmtOffset = "-06:00",
			FullDisplayName = "(GMT-06:00) Managua",
		};

		private static readonly TimeZoneLocation NL_Europe_Amsterdam = new TimeZoneLocation()
		{
			Id = "NL_Europe_Amsterdam",
			CountryCode = "NL",
			CountryName = "Netherlands",
			OlsonTimeZone = "Europe/Amsterdam",
			FriendlyName = "Amsterdam",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Amsterdam",
		};

		private static readonly TimeZoneLocation NO_Europe_Oslo = new TimeZoneLocation()
		{
			Id = "NO_Europe_Oslo",
			CountryCode = "NO",
			CountryName = "Norway",
			OlsonTimeZone = "Europe/Oslo",
			FriendlyName = "Oslo",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Oslo",
		};

		private static readonly TimeZoneLocation NP_Asia_Katmandu = new TimeZoneLocation()
		{
			Id = "NP_Asia_Katmandu",
			CountryCode = "NP",
			CountryName = "Nepal",
			OlsonTimeZone = "Asia/Katmandu",
			FriendlyName = "Katmandu",
			StandardGmtOffset = "+05:45",
			FullDisplayName = "(GMT+05:45) Katmandu",
		};

		private static readonly TimeZoneLocation NR_Pacific_Nauru = new TimeZoneLocation()
		{
			Id = "NR_Pacific_Nauru",
			CountryCode = "NR",
			CountryName = "Nauru",
			OlsonTimeZone = "Pacific/Nauru",
			FriendlyName = "Nauru",
			StandardGmtOffset = "+12:00",
			FullDisplayName = "(GMT+12:00) Nauru",
		};

		private static readonly TimeZoneLocation NU_Pacific_Niue = new TimeZoneLocation()
		{
			Id = "NU_Pacific_Niue",
			CountryCode = "NU",
			CountryName = "Niue",
			OlsonTimeZone = "Pacific/Niue",
			FriendlyName = "Niue",
			StandardGmtOffset = "-11:00",
			FullDisplayName = "(GMT-11:00) Niue",
		};

		private static readonly TimeZoneLocation NZ_Pacific_Auckland = new TimeZoneLocation()
		{
			Id = "NZ_Pacific_Auckland",
			CountryCode = "NZ",
			CountryName = "New Zealand",
			OlsonTimeZone = "Pacific/Auckland",
			FriendlyName = "Auckland",
			StandardGmtOffset = "+12:00",
			FullDisplayName = "(GMT+12:00) Auckland",
		};

		private static readonly TimeZoneLocation OM_Asia_Muscat = new TimeZoneLocation()
		{
			Id = "OM_Asia_Muscat",
			CountryCode = "OM",
			CountryName = "Oman",
			OlsonTimeZone = "Asia/Muscat",
			FriendlyName = "Muscat",
			StandardGmtOffset = "+04:00",
			FullDisplayName = "(GMT+04:00) Muscat",
		};

		private static readonly TimeZoneLocation PA_America_Panama = new TimeZoneLocation()
		{
			Id = "PA_America_Panama",
			CountryCode = "PA",
			CountryName = "Panama",
			OlsonTimeZone = "America/Panama",
			FriendlyName = "Panama",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Panama",
		};

		private static readonly TimeZoneLocation PE_America_Lima = new TimeZoneLocation()
		{
			Id = "PE_America_Lima",
			CountryCode = "PE",
			CountryName = "Peru",
			OlsonTimeZone = "America/Lima",
			FriendlyName = "Lima",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Lima",
		};

		private static readonly TimeZoneLocation PF_Pacific_Tahiti = new TimeZoneLocation()
		{
			Id = "PF_Pacific_Tahiti",
			CountryCode = "PF",
			CountryName = "French Polynesia",
			OlsonTimeZone = "Pacific/Tahiti",
			FriendlyName = "Tahiti",
			StandardGmtOffset = "-10:00",
			FullDisplayName = "(GMT-10:00) Tahiti",
		};

		private static readonly TimeZoneLocation PF_Pacific_Marquesas = new TimeZoneLocation()
		{
			Id = "PF_Pacific_Marquesas",
			CountryCode = "PF",
			CountryName = "French Polynesia",
			OlsonTimeZone = "Pacific/Marquesas",
			FriendlyName = "Marquesas",
			StandardGmtOffset = "-09:30",
			FullDisplayName = "(GMT-09:30) Marquesas",
		};

		private static readonly TimeZoneLocation PF_Pacific_Gambier = new TimeZoneLocation()
		{
			Id = "PF_Pacific_Gambier",
			CountryCode = "PF",
			CountryName = "French Polynesia",
			OlsonTimeZone = "Pacific/Gambier",
			FriendlyName = "Gambier",
			StandardGmtOffset = "-09:00",
			FullDisplayName = "(GMT-09:00) Gambier",
		};

		private static readonly TimeZoneLocation PG_Pacific_Port_Moresby = new TimeZoneLocation()
		{
			Id = "PG_Pacific_Port_Moresby",
			CountryCode = "PG",
			CountryName = "Papua New Guinea",
			OlsonTimeZone = "Pacific/Port_Moresby",
			FriendlyName = "Port Moresby",
			StandardGmtOffset = "+10:00",
			FullDisplayName = "(GMT+10:00) Port Moresby",
		};

		private static readonly TimeZoneLocation PH_Asia_Manila = new TimeZoneLocation()
		{
			Id = "PH_Asia_Manila",
			CountryCode = "PH",
			CountryName = "Philippines",
			OlsonTimeZone = "Asia/Manila",
			FriendlyName = "Manila",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) Manila",
		};

		private static readonly TimeZoneLocation PK_Asia_Karachi = new TimeZoneLocation()
		{
			Id = "PK_Asia_Karachi",
			CountryCode = "PK",
			CountryName = "Pakistan",
			OlsonTimeZone = "Asia/Karachi",
			FriendlyName = "Karachi",
			StandardGmtOffset = "+05:00",
			FullDisplayName = "(GMT+05:00) Karachi",
		};

		private static readonly TimeZoneLocation PL_Europe_Warsaw = new TimeZoneLocation()
		{
			Id = "PL_Europe_Warsaw",
			CountryCode = "PL",
			CountryName = "Poland",
			OlsonTimeZone = "Europe/Warsaw",
			FriendlyName = "Warsaw",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Warsaw",
		};

		private static readonly TimeZoneLocation PM_America_Miquelon = new TimeZoneLocation()
		{
			Id = "PM_America_Miquelon",
			CountryCode = "PM",
			CountryName = "Saint Pierre and Miquelon",
			OlsonTimeZone = "America/Miquelon",
			FriendlyName = "Miquelon",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Miquelon",
		};

		private static readonly TimeZoneLocation PN_Pacific_Pitcairn = new TimeZoneLocation()
		{
			Id = "PN_Pacific_Pitcairn",
			CountryCode = "PN",
			CountryName = "Pitcairn",
			OlsonTimeZone = "Pacific/Pitcairn",
			FriendlyName = "Pitcairn",
			StandardGmtOffset = "-08:00",
			FullDisplayName = "(GMT-08:00) Pitcairn",
		};

		private static readonly TimeZoneLocation PR_America_Puerto_Rico = new TimeZoneLocation()
		{
			Id = "PR_America_Puerto_Rico",
			CountryCode = "PR",
			CountryName = "Puerto Rico",
			OlsonTimeZone = "America/Puerto_Rico",
			FriendlyName = "Puerto Rico",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Puerto Rico",
		};

		private static readonly TimeZoneLocation PS_Asia_Gaza = new TimeZoneLocation()
		{
			Id = "PS_Asia_Gaza",
			CountryCode = "PS",
			CountryName = "Palestinian Territory",
			OlsonTimeZone = "Asia/Gaza",
			FriendlyName = "Gaza",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Gaza",
		};

		private static readonly TimeZoneLocation PT_Atlantic_Azores = new TimeZoneLocation()
		{
			Id = "PT_Atlantic_Azores",
			CountryCode = "PT",
			CountryName = "Portugal",
			OlsonTimeZone = "Atlantic/Azores",
			FriendlyName = "Azores",
			StandardGmtOffset = "-01:00",
			FullDisplayName = "(GMT-01:00) Azores",
		};

		private static readonly TimeZoneLocation PT_Europe_Lisbon = new TimeZoneLocation()
		{
			Id = "PT_Europe_Lisbon",
			CountryCode = "PT",
			CountryName = "Portugal",
			OlsonTimeZone = "Europe/Lisbon",
			FriendlyName = "Lisbon",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Lisbon",
		};

		private static readonly TimeZoneLocation PW_Pacific_Palau = new TimeZoneLocation()
		{
			Id = "PW_Pacific_Palau",
			CountryCode = "PW",
			CountryName = "Palau",
			OlsonTimeZone = "Pacific/Palau",
			FriendlyName = "Palau",
			StandardGmtOffset = "+09:00",
			FullDisplayName = "(GMT+09:00) Palau",
		};

		private static readonly TimeZoneLocation PY_America_Asuncion = new TimeZoneLocation()
		{
			Id = "PY_America_Asuncion",
			CountryCode = "PY",
			CountryName = "Paraguay",
			OlsonTimeZone = "America/Asuncion",
			FriendlyName = "Asuncion",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Asuncion",
		};

		private static readonly TimeZoneLocation QA_Asia_Qatar = new TimeZoneLocation()
		{
			Id = "QA_Asia_Qatar",
			CountryCode = "QA",
			CountryName = "Qatar",
			OlsonTimeZone = "Asia/Qatar",
			FriendlyName = "Qatar",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Qatar",
		};

		private static readonly TimeZoneLocation RE_Indian_Reunion = new TimeZoneLocation()
		{
			Id = "RE_Indian_Reunion",
			CountryCode = "RE",
			CountryName = "Reunion",
			OlsonTimeZone = "Indian/Reunion",
			FriendlyName = "Reunion",
			StandardGmtOffset = "+04:00",
			FullDisplayName = "(GMT+04:00) Reunion",
		};

		private static readonly TimeZoneLocation RO_Europe_Bucharest = new TimeZoneLocation()
		{
			Id = "RO_Europe_Bucharest",
			CountryCode = "RO",
			CountryName = "Romania",
			OlsonTimeZone = "Europe/Bucharest",
			FriendlyName = "Bucharest",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Bucharest",
		};

		private static readonly TimeZoneLocation RS_Europe_Belgrade = new TimeZoneLocation()
		{
			Id = "RS_Europe_Belgrade",
			CountryCode = "RS",
			CountryName = "Serbia",
			OlsonTimeZone = "Europe/Belgrade",
			FriendlyName = "Central European Time - Belgrade",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Central European Time - Belgrade",
		};

		private static readonly TimeZoneLocation RU_Europe_Kaliningrad = new TimeZoneLocation()
		{
			Id = "RU_Europe_Kaliningrad",
			CountryCode = "RU",
			CountryName = "Russia",
			OlsonTimeZone = "Europe/Kaliningrad",
			FriendlyName = "Moscow-01 - Kaliningrad",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Moscow-01 - Kaliningrad",
		};

		private static readonly TimeZoneLocation RU_Europe_Moscow = new TimeZoneLocation()
		{
			Id = "RU_Europe_Moscow",
			CountryCode = "RU",
			CountryName = "Russia",
			OlsonTimeZone = "Europe/Moscow",
			FriendlyName = "Moscow+00",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Moscow+00",
		};

		private static readonly TimeZoneLocation RU_Europe_Samara = new TimeZoneLocation()
		{
			Id = "RU_Europe_Samara",
			CountryCode = "RU",
			CountryName = "Russia",
			OlsonTimeZone = "Europe/Samara",
			FriendlyName = "Moscow+00 - Samara",
			StandardGmtOffset = "+04:00",
			FullDisplayName = "(GMT+04:00) Moscow+00 - Samara",
		};

		private static readonly TimeZoneLocation RU_Asia_Yekaterinburg = new TimeZoneLocation()
		{
			Id = "RU_Asia_Yekaterinburg",
			CountryCode = "RU",
			CountryName = "Russia",
			OlsonTimeZone = "Asia/Yekaterinburg",
			FriendlyName = "Moscow+02 - Yekaterinburg",
			StandardGmtOffset = "+05:00",
			FullDisplayName = "(GMT+05:00) Moscow+02 - Yekaterinburg",
		};

		private static readonly TimeZoneLocation RU_Asia_Omsk = new TimeZoneLocation()
		{
			Id = "RU_Asia_Omsk",
			CountryCode = "RU",
			CountryName = "Russia",
			OlsonTimeZone = "Asia/Omsk",
			FriendlyName = "Moscow+03 - Omsk, Novosibirsk",
			StandardGmtOffset = "+06:00",
			FullDisplayName = "(GMT+06:00) Moscow+03 - Omsk, Novosibirsk",
		};

		private static readonly TimeZoneLocation RU_Asia_Krasnoyarsk = new TimeZoneLocation()
		{
			Id = "RU_Asia_Krasnoyarsk",
			CountryCode = "RU",
			CountryName = "Russia",
			OlsonTimeZone = "Asia/Krasnoyarsk",
			FriendlyName = "Moscow+04 - Krasnoyarsk",
			StandardGmtOffset = "+07:00",
			FullDisplayName = "(GMT+07:00) Moscow+04 - Krasnoyarsk",
		};

		private static readonly TimeZoneLocation RU_Asia_Irkutsk = new TimeZoneLocation()
		{
			Id = "RU_Asia_Irkutsk",
			CountryCode = "RU",
			CountryName = "Russia",
			OlsonTimeZone = "Asia/Irkutsk",
			FriendlyName = "Moscow+05 - Irkutsk",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) Moscow+05 - Irkutsk",
		};

		private static readonly TimeZoneLocation RU_Asia_Yakutsk = new TimeZoneLocation()
		{
			Id = "RU_Asia_Yakutsk",
			CountryCode = "RU",
			CountryName = "Russia",
			OlsonTimeZone = "Asia/Yakutsk",
			FriendlyName = "Moscow+06 - Yakutsk",
			StandardGmtOffset = "+09:00",
			FullDisplayName = "(GMT+09:00) Moscow+06 - Yakutsk",
		};

		private static readonly TimeZoneLocation RU_Asia_Magadan = new TimeZoneLocation()
		{
			Id = "RU_Asia_Magadan",
			CountryCode = "RU",
			CountryName = "Russia",
			OlsonTimeZone = "Asia/Magadan",
			FriendlyName = "Moscow+08 - Magadan",
			StandardGmtOffset = "+10:00",
			FullDisplayName = "(GMT+10:00) Moscow+08 - Magadan",
		};

		private static readonly TimeZoneLocation RU_Asia_Vladivostok = new TimeZoneLocation()
		{
			Id = "RU_Asia_Vladivostok",
			CountryCode = "RU",
			CountryName = "Russia",
			OlsonTimeZone = "Asia/Vladivostok",
			FriendlyName = "Moscow+07 - Yuzhno-Sakhalinsk",
			StandardGmtOffset = "+10:00",
			FullDisplayName = "(GMT+10:00) Moscow+07 - Yuzhno-Sakhalinsk",
		};

		private static readonly TimeZoneLocation RU_Asia_Kamchatka = new TimeZoneLocation()
		{
			Id = "RU_Asia_Kamchatka",
			CountryCode = "RU",
			CountryName = "Russia",
			OlsonTimeZone = "Asia/Kamchatka",
			FriendlyName = "Moscow+08 - Petropavlovsk-Kamchatskiy",
			StandardGmtOffset = "+12:00",
			FullDisplayName = "(GMT+12:00) Moscow+08 - Petropavlovsk-Kamchatskiy",
		};

		private static readonly TimeZoneLocation RW_Africa_Maputo = new TimeZoneLocation()
		{
			Id = "RW_Africa_Maputo",
			CountryCode = "RW",
			CountryName = "Rwanda",
			OlsonTimeZone = "Africa/Maputo",
			FriendlyName = "Maputo",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Maputo",
		};

		private static readonly TimeZoneLocation SA_Asia_Riyadh = new TimeZoneLocation()
		{
			Id = "SA_Asia_Riyadh",
			CountryCode = "SA",
			CountryName = "Saudi Arabia",
			OlsonTimeZone = "Asia/Riyadh",
			FriendlyName = "Riyadh",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Riyadh",
		};

		private static readonly TimeZoneLocation SB_Pacific_Guadalcanal = new TimeZoneLocation()
		{
			Id = "SB_Pacific_Guadalcanal",
			CountryCode = "SB",
			CountryName = "Solomon Islands",
			OlsonTimeZone = "Pacific/Guadalcanal",
			FriendlyName = "Guadalcanal",
			StandardGmtOffset = "+11:00",
			FullDisplayName = "(GMT+11:00) Guadalcanal",
		};

		private static readonly TimeZoneLocation SC_Indian_Mahe = new TimeZoneLocation()
		{
			Id = "SC_Indian_Mahe",
			CountryCode = "SC",
			CountryName = "Seychelles",
			OlsonTimeZone = "Indian/Mahe",
			FriendlyName = "Mahe",
			StandardGmtOffset = "+04:00",
			FullDisplayName = "(GMT+04:00) Mahe",
		};

		private static readonly TimeZoneLocation SD_Africa_Khartoum = new TimeZoneLocation()
		{
			Id = "SD_Africa_Khartoum",
			CountryCode = "SD",
			CountryName = "Sudan",
			OlsonTimeZone = "Africa/Khartoum",
			FriendlyName = "Khartoum",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Khartoum",
		};

		private static readonly TimeZoneLocation SE_Europe_Stockholm = new TimeZoneLocation()
		{
			Id = "SE_Europe_Stockholm",
			CountryCode = "SE",
			CountryName = "Sweden",
			OlsonTimeZone = "Europe/Stockholm",
			FriendlyName = "Stockholm",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Stockholm",
		};

		private static readonly TimeZoneLocation SG_Asia_Singapore = new TimeZoneLocation()
		{
			Id = "SG_Asia_Singapore",
			CountryCode = "SG",
			CountryName = "Singapore",
			OlsonTimeZone = "Asia/Singapore",
			FriendlyName = "Singapore",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) Singapore",
		};

		private static readonly TimeZoneLocation SH_Africa_Abidjan = new TimeZoneLocation()
		{
			Id = "SH_Africa_Abidjan",
			CountryCode = "SH",
			CountryName = "Saint Helena",
			OlsonTimeZone = "Africa/Abidjan",
			FriendlyName = "Abidjan",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Abidjan",
		};

		private static readonly TimeZoneLocation SI_Europe_Belgrade = new TimeZoneLocation()
		{
			Id = "SI_Europe_Belgrade",
			CountryCode = "SI",
			CountryName = "Slovenia",
			OlsonTimeZone = "Europe/Belgrade",
			FriendlyName = "Central European Time - Belgrade",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Central European Time - Belgrade",
		};

		private static readonly TimeZoneLocation SJ_Europe_Oslo = new TimeZoneLocation()
		{
			Id = "SJ_Europe_Oslo",
			CountryCode = "SJ",
			CountryName = "Svalbard and Jan Mayen",
			OlsonTimeZone = "Europe/Oslo",
			FriendlyName = "Oslo",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Oslo",
		};

		private static readonly TimeZoneLocation SK_Europe_Prague = new TimeZoneLocation()
		{
			Id = "SK_Europe_Prague",
			CountryCode = "SK",
			CountryName = "Slovakia",
			OlsonTimeZone = "Europe/Prague",
			FriendlyName = "Central European Time - Prague",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Central European Time - Prague",
		};

		private static readonly TimeZoneLocation SL_Africa_Abidjan = new TimeZoneLocation()
		{
			Id = "SL_Africa_Abidjan",
			CountryCode = "SL",
			CountryName = "Sierra Leone",
			OlsonTimeZone = "Africa/Abidjan",
			FriendlyName = "Abidjan",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Abidjan",
		};

		private static readonly TimeZoneLocation SM_Europe_Rome = new TimeZoneLocation()
		{
			Id = "SM_Europe_Rome",
			CountryCode = "SM",
			CountryName = "San Marino",
			OlsonTimeZone = "Europe/Rome",
			FriendlyName = "Rome",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Rome",
		};

		private static readonly TimeZoneLocation SN_Africa_Abidjan = new TimeZoneLocation()
		{
			Id = "SN_Africa_Abidjan",
			CountryCode = "SN",
			CountryName = "Senegal",
			OlsonTimeZone = "Africa/Abidjan",
			FriendlyName = "Abidjan",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Abidjan",
		};

		private static readonly TimeZoneLocation SO_Africa_Nairobi = new TimeZoneLocation()
		{
			Id = "SO_Africa_Nairobi",
			CountryCode = "SO",
			CountryName = "Somalia",
			OlsonTimeZone = "Africa/Nairobi",
			FriendlyName = "Nairobi",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Nairobi",
		};

		private static readonly TimeZoneLocation SR_America_Paramaribo = new TimeZoneLocation()
		{
			Id = "SR_America_Paramaribo",
			CountryCode = "SR",
			CountryName = "Suriname",
			OlsonTimeZone = "America/Paramaribo",
			FriendlyName = "Paramaribo",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Paramaribo",
		};

		private static readonly TimeZoneLocation SS_Africa_Khartoum = new TimeZoneLocation()
		{
			Id = "SS_Africa_Khartoum",
			CountryCode = "SS",
			CountryName = "South Sudan",
			OlsonTimeZone = "Africa/Khartoum",
			FriendlyName = "Khartoum",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Khartoum",
		};

		private static readonly TimeZoneLocation ST_Africa_Abidjan = new TimeZoneLocation()
		{
			Id = "ST_Africa_Abidjan",
			CountryCode = "ST",
			CountryName = "Sao Tome and Principe",
			OlsonTimeZone = "Africa/Abidjan",
			FriendlyName = "Abidjan",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Abidjan",
		};

		private static readonly TimeZoneLocation SV_America_El_Salvador = new TimeZoneLocation()
		{
			Id = "SV_America_El_Salvador",
			CountryCode = "SV",
			CountryName = "El Salvador",
			OlsonTimeZone = "America/El_Salvador",
			FriendlyName = "El Salvador",
			StandardGmtOffset = "-06:00",
			FullDisplayName = "(GMT-06:00) El Salvador",
		};

		private static readonly TimeZoneLocation SX_America_Curacao = new TimeZoneLocation()
		{
			Id = "SX_America_Curacao",
			CountryCode = "SX",
			CountryName = "Sint Maarten",
			OlsonTimeZone = "America/Curacao",
			FriendlyName = "Curacao",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Curacao",
		};

		private static readonly TimeZoneLocation SY_Asia_Damascus = new TimeZoneLocation()
		{
			Id = "SY_Asia_Damascus",
			CountryCode = "SY",
			CountryName = "Syria",
			OlsonTimeZone = "Asia/Damascus",
			FriendlyName = "Damascus",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Damascus",
		};

		private static readonly TimeZoneLocation SZ_Africa_Johannesburg = new TimeZoneLocation()
		{
			Id = "SZ_Africa_Johannesburg",
			CountryCode = "SZ",
			CountryName = "Swaziland",
			OlsonTimeZone = "Africa/Johannesburg",
			FriendlyName = "Johannesburg",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Johannesburg",
		};

		private static readonly TimeZoneLocation TC_America_Grand_Turk = new TimeZoneLocation()
		{
			Id = "TC_America_Grand_Turk",
			CountryCode = "TC",
			CountryName = "Turks and Caicos Islands",
			OlsonTimeZone = "America/Grand_Turk",
			FriendlyName = "Grand Turk",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Grand Turk",
		};

		private static readonly TimeZoneLocation TD_Africa_Ndjamena = new TimeZoneLocation()
		{
			Id = "TD_Africa_Ndjamena",
			CountryCode = "TD",
			CountryName = "Chad",
			OlsonTimeZone = "Africa/Ndjamena",
			FriendlyName = "Ndjamena",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Ndjamena",
		};

		private static readonly TimeZoneLocation TF_Indian_Kerguelen = new TimeZoneLocation()
		{
			Id = "TF_Indian_Kerguelen",
			CountryCode = "TF",
			CountryName = "French Southern Territories",
			OlsonTimeZone = "Indian/Kerguelen",
			FriendlyName = "Kerguelen",
			StandardGmtOffset = "+05:00",
			FullDisplayName = "(GMT+05:00) Kerguelen",
		};

		private static readonly TimeZoneLocation TG_Africa_Abidjan = new TimeZoneLocation()
		{
			Id = "TG_Africa_Abidjan",
			CountryCode = "TG",
			CountryName = "Togo",
			OlsonTimeZone = "Africa/Abidjan",
			FriendlyName = "Abidjan",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) Abidjan",
		};

		private static readonly TimeZoneLocation TH_Asia_Bangkok = new TimeZoneLocation()
		{
			Id = "TH_Asia_Bangkok",
			CountryCode = "TH",
			CountryName = "Thailand",
			OlsonTimeZone = "Asia/Bangkok",
			FriendlyName = "Bangkok",
			StandardGmtOffset = "+07:00",
			FullDisplayName = "(GMT+07:00) Bangkok",
		};

		private static readonly TimeZoneLocation TJ_Asia_Dushanbe = new TimeZoneLocation()
		{
			Id = "TJ_Asia_Dushanbe",
			CountryCode = "TJ",
			CountryName = "Tajikistan",
			OlsonTimeZone = "Asia/Dushanbe",
			FriendlyName = "Dushanbe",
			StandardGmtOffset = "+05:00",
			FullDisplayName = "(GMT+05:00) Dushanbe",
		};

		private static readonly TimeZoneLocation TK_Pacific_Fakaofo = new TimeZoneLocation()
		{
			Id = "TK_Pacific_Fakaofo",
			CountryCode = "TK",
			CountryName = "Tokelau",
			OlsonTimeZone = "Pacific/Fakaofo",
			FriendlyName = "Fakaofo",
			StandardGmtOffset = "+13:00",
			FullDisplayName = "(GMT+13:00) Fakaofo",
		};

		private static readonly TimeZoneLocation TL_Asia_Dili = new TimeZoneLocation()
		{
			Id = "TL_Asia_Dili",
			CountryCode = "TL",
			CountryName = "East Timor",
			OlsonTimeZone = "Asia/Dili",
			FriendlyName = "Dili",
			StandardGmtOffset = "+09:00",
			FullDisplayName = "(GMT+09:00) Dili",
		};

		private static readonly TimeZoneLocation TM_Asia_Ashgabat = new TimeZoneLocation()
		{
			Id = "TM_Asia_Ashgabat",
			CountryCode = "TM",
			CountryName = "Turkmenistan",
			OlsonTimeZone = "Asia/Ashgabat",
			FriendlyName = "Ashgabat",
			StandardGmtOffset = "+05:00",
			FullDisplayName = "(GMT+05:00) Ashgabat",
		};

		private static readonly TimeZoneLocation TN_Africa_Tunis = new TimeZoneLocation()
		{
			Id = "TN_Africa_Tunis",
			CountryCode = "TN",
			CountryName = "Tunisia",
			OlsonTimeZone = "Africa/Tunis",
			FriendlyName = "Tunis",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Tunis",
		};

		private static readonly TimeZoneLocation TO_Pacific_Tongatapu = new TimeZoneLocation()
		{
			Id = "TO_Pacific_Tongatapu",
			CountryCode = "TO",
			CountryName = "Tonga",
			OlsonTimeZone = "Pacific/Tongatapu",
			FriendlyName = "Tongatapu",
			StandardGmtOffset = "+13:00",
			FullDisplayName = "(GMT+13:00) Tongatapu",
		};

		private static readonly TimeZoneLocation TR_Europe_Istanbul = new TimeZoneLocation()
		{
			Id = "TR_Europe_Istanbul",
			CountryCode = "TR",
			CountryName = "Turkey",
			OlsonTimeZone = "Europe/Istanbul",
			FriendlyName = "Istanbul",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Istanbul",
		};

		private static readonly TimeZoneLocation TT_America_Port_of_Spain = new TimeZoneLocation()
		{
			Id = "TT_America_Port_of_Spain",
			CountryCode = "TT",
			CountryName = "Trinidad and Tobago",
			OlsonTimeZone = "America/Port_of_Spain",
			FriendlyName = "Port of Spain",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Port of Spain",
		};

		private static readonly TimeZoneLocation TV_Pacific_Funafuti = new TimeZoneLocation()
		{
			Id = "TV_Pacific_Funafuti",
			CountryCode = "TV",
			CountryName = "Tuvalu",
			OlsonTimeZone = "Pacific/Funafuti",
			FriendlyName = "Funafuti",
			StandardGmtOffset = "+12:00",
			FullDisplayName = "(GMT+12:00) Funafuti",
		};

		private static readonly TimeZoneLocation TW_Asia_Taipei = new TimeZoneLocation()
		{
			Id = "TW_Asia_Taipei",
			CountryCode = "TW",
			CountryName = "Taiwan",
			OlsonTimeZone = "Asia/Taipei",
			FriendlyName = "Taipei",
			StandardGmtOffset = "+08:00",
			FullDisplayName = "(GMT+08:00) Taipei",
		};

		private static readonly TimeZoneLocation TZ_Africa_Nairobi = new TimeZoneLocation()
		{
			Id = "TZ_Africa_Nairobi",
			CountryCode = "TZ",
			CountryName = "Tanzania",
			OlsonTimeZone = "Africa/Nairobi",
			FriendlyName = "Nairobi",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Nairobi",
		};

		private static readonly TimeZoneLocation UA_Europe_Kiev = new TimeZoneLocation()
		{
			Id = "UA_Europe_Kiev",
			CountryCode = "UA",
			CountryName = "Ukraine",
			OlsonTimeZone = "Europe/Kiev",
			FriendlyName = "Kiev",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Kiev",
		};

		private static readonly TimeZoneLocation UG_Africa_Nairobi = new TimeZoneLocation()
		{
			Id = "UG_Africa_Nairobi",
			CountryCode = "UG",
			CountryName = "Uganda",
			OlsonTimeZone = "Africa/Nairobi",
			FriendlyName = "Nairobi",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Nairobi",
		};

		private static readonly TimeZoneLocation UM_Pacific_Midway = new TimeZoneLocation()
		{
			Id = "UM_Pacific_Midway",
			CountryCode = "UM",
			CountryName = "United States Minor Outlying Islands",
			OlsonTimeZone = "Pacific/Midway",
			FriendlyName = "Midway",
			StandardGmtOffset = "-11:00",
			FullDisplayName = "(GMT-11:00) Midway",
		};

		private static readonly TimeZoneLocation UM_Pacific_Honolulu = new TimeZoneLocation()
		{
			Id = "UM_Pacific_Honolulu",
			CountryCode = "UM",
			CountryName = "United States Minor Outlying Islands",
			OlsonTimeZone = "Pacific/Honolulu",
			FriendlyName = "Hawaii Time",
			StandardGmtOffset = "-10:00",
			FullDisplayName = "(GMT-10:00) Hawaii Time",
		};

		private static readonly TimeZoneLocation UM_Pacific_Wake = new TimeZoneLocation()
		{
			Id = "UM_Pacific_Wake",
			CountryCode = "UM",
			CountryName = "United States Minor Outlying Islands",
			OlsonTimeZone = "Pacific/Wake",
			FriendlyName = "Wake",
			StandardGmtOffset = "+12:00",
			FullDisplayName = "(GMT+12:00) Wake",
		};

		private static readonly TimeZoneLocation UM_Pacific_Enderbury = new TimeZoneLocation()
		{
			Id = "UM_Pacific_Enderbury",
			CountryCode = "UM",
			CountryName = "United States Minor Outlying Islands",
			OlsonTimeZone = "Pacific/Enderbury",
			FriendlyName = "Enderbury",
			StandardGmtOffset = "+13:00",
			FullDisplayName = "(GMT+13:00) Enderbury",
		};

		private static readonly TimeZoneLocation US_Pacific_Honolulu = new TimeZoneLocation()
		{
			Id = "US_Pacific_Honolulu",
			CountryCode = "US",
			CountryName = "United States",
			OlsonTimeZone = "Pacific/Honolulu",
			FriendlyName = "Hawaii Time",
			StandardGmtOffset = "-10:00",
			FullDisplayName = "(GMT-10:00) Hawaii Time",
		};

		private static readonly TimeZoneLocation US_America_Anchorage = new TimeZoneLocation()
		{
			Id = "US_America_Anchorage",
			CountryCode = "US",
			CountryName = "United States",
			OlsonTimeZone = "America/Anchorage",
			FriendlyName = "Alaska Time",
			StandardGmtOffset = "-09:00",
			FullDisplayName = "(GMT-09:00) Alaska Time",
		};

		private static readonly TimeZoneLocation US_America_Los_Angeles = new TimeZoneLocation()
		{
			Id = "US_America_Los_Angeles",
			CountryCode = "US",
			CountryName = "United States",
			OlsonTimeZone = "America/Los_Angeles",
			FriendlyName = "Pacific Time",
			StandardGmtOffset = "-08:00",
			FullDisplayName = "(GMT-08:00) Pacific Time",
		};

		private static readonly TimeZoneLocation US_America_Denver = new TimeZoneLocation()
		{
			Id = "US_America_Denver",
			CountryCode = "US",
			CountryName = "United States",
			OlsonTimeZone = "America/Denver",
			FriendlyName = "Mountain Time",
			StandardGmtOffset = "-07:00",
			FullDisplayName = "(GMT-07:00) Mountain Time",
		};

		private static readonly TimeZoneLocation US_America_Phoenix = new TimeZoneLocation()
		{
			Id = "US_America_Phoenix",
			CountryCode = "US",
			CountryName = "United States",
			OlsonTimeZone = "America/Phoenix",
			FriendlyName = "Mountain Time - Arizona",
			StandardGmtOffset = "-07:00",
			FullDisplayName = "(GMT-07:00) Mountain Time - Arizona",
		};

		private static readonly TimeZoneLocation US_America_Chicago = new TimeZoneLocation()
		{
			Id = "US_America_Chicago",
			CountryCode = "US",
			CountryName = "United States",
			OlsonTimeZone = "America/Chicago",
			FriendlyName = "Central Time",
			StandardGmtOffset = "-06:00",
			FullDisplayName = "(GMT-06:00) Central Time",
		};

		private static readonly TimeZoneLocation US_America_New_York = new TimeZoneLocation()
		{
			Id = "US_America_New_York",
			CountryCode = "US",
			CountryName = "United States",
			OlsonTimeZone = "America/New_York",
			FriendlyName = "Eastern Time",
			StandardGmtOffset = "-05:00",
			FullDisplayName = "(GMT-05:00) Eastern Time",
		};

		private static readonly TimeZoneLocation UY_America_Montevideo = new TimeZoneLocation()
		{
			Id = "UY_America_Montevideo",
			CountryCode = "UY",
			CountryName = "Uruguay",
			OlsonTimeZone = "America/Montevideo",
			FriendlyName = "Montevideo",
			StandardGmtOffset = "-03:00",
			FullDisplayName = "(GMT-03:00) Montevideo",
		};

		private static readonly TimeZoneLocation UZ_Asia_Tashkent = new TimeZoneLocation()
		{
			Id = "UZ_Asia_Tashkent",
			CountryCode = "UZ",
			CountryName = "Uzbekistan",
			OlsonTimeZone = "Asia/Tashkent",
			FriendlyName = "Tashkent",
			StandardGmtOffset = "+05:00",
			FullDisplayName = "(GMT+05:00) Tashkent",
		};

		private static readonly TimeZoneLocation VA_Europe_Rome = new TimeZoneLocation()
		{
			Id = "VA_Europe_Rome",
			CountryCode = "VA",
			CountryName = "Vatican",
			OlsonTimeZone = "Europe/Rome",
			FriendlyName = "Rome",
			StandardGmtOffset = "+01:00",
			FullDisplayName = "(GMT+01:00) Rome",
		};

		private static readonly TimeZoneLocation VC_America_Port_of_Spain = new TimeZoneLocation()
		{
			Id = "VC_America_Port_of_Spain",
			CountryCode = "VC",
			CountryName = "Saint Vincent and the Grenadines",
			OlsonTimeZone = "America/Port_of_Spain",
			FriendlyName = "Port of Spain",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Port of Spain",
		};

		private static readonly TimeZoneLocation VE_America_Caracas = new TimeZoneLocation()
		{
			Id = "VE_America_Caracas",
			CountryCode = "VE",
			CountryName = "Venezuela",
			OlsonTimeZone = "America/Caracas",
			FriendlyName = "Caracas",
			StandardGmtOffset = "-04:30",
			FullDisplayName = "(GMT-04:30) Caracas",
		};

		private static readonly TimeZoneLocation VG_America_Port_of_Spain = new TimeZoneLocation()
		{
			Id = "VG_America_Port_of_Spain",
			CountryCode = "VG",
			CountryName = "British Virgin Islands",
			OlsonTimeZone = "America/Port_of_Spain",
			FriendlyName = "Port of Spain",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Port of Spain",
		};

		private static readonly TimeZoneLocation VI_America_Port_of_Spain = new TimeZoneLocation()
		{
			Id = "VI_America_Port_of_Spain",
			CountryCode = "VI",
			CountryName = "U.S. Virgin Islands",
			OlsonTimeZone = "America/Port_of_Spain",
			FriendlyName = "Port of Spain",
			StandardGmtOffset = "-04:00",
			FullDisplayName = "(GMT-04:00) Port of Spain",
		};

		private static readonly TimeZoneLocation VN_Asia_Saigon = new TimeZoneLocation()
		{
			Id = "VN_Asia_Saigon",
			CountryCode = "VN",
			CountryName = "Vietnam",
			OlsonTimeZone = "Asia/Saigon",
			FriendlyName = "Hanoi",
			StandardGmtOffset = "+07:00",
			FullDisplayName = "(GMT+07:00) Hanoi",
		};

		private static readonly TimeZoneLocation VU_Pacific_Efate = new TimeZoneLocation()
		{
			Id = "VU_Pacific_Efate",
			CountryCode = "VU",
			CountryName = "Vanuatu",
			OlsonTimeZone = "Pacific/Efate",
			FriendlyName = "Efate",
			StandardGmtOffset = "+11:00",
			FullDisplayName = "(GMT+11:00) Efate",
		};

		private static readonly TimeZoneLocation WF_Pacific_Wallis = new TimeZoneLocation()
		{
			Id = "WF_Pacific_Wallis",
			CountryCode = "WF",
			CountryName = "Wallis and Futuna",
			OlsonTimeZone = "Pacific/Wallis",
			FriendlyName = "Wallis",
			StandardGmtOffset = "+12:00",
			FullDisplayName = "(GMT+12:00) Wallis",
		};

		private static readonly TimeZoneLocation WS_Pacific_Apia = new TimeZoneLocation()
		{
			Id = "WS_Pacific_Apia",
			CountryCode = "WS",
			CountryName = "Samoa",
			OlsonTimeZone = "Pacific/Apia",
			FriendlyName = "Apia",
			StandardGmtOffset = "+13:00",
			FullDisplayName = "(GMT+13:00) Apia",
		};

		private static readonly TimeZoneLocation YE_Asia_Aden = new TimeZoneLocation()
		{
			Id = "YE_Asia_Aden",
			CountryCode = "YE",
			CountryName = "Yemen",
			OlsonTimeZone = "Asia/Aden",
			FriendlyName = "Aden",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Aden",
		};

		private static readonly TimeZoneLocation YT_Africa_Nairobi = new TimeZoneLocation()
		{
			Id = "YT_Africa_Nairobi",
			CountryCode = "YT",
			CountryName = "Mayotte",
			OlsonTimeZone = "Africa/Nairobi",
			FriendlyName = "Nairobi",
			StandardGmtOffset = "+03:00",
			FullDisplayName = "(GMT+03:00) Nairobi",
		};

		private static readonly TimeZoneLocation ZA_Africa_Johannesburg = new TimeZoneLocation()
		{
			Id = "ZA_Africa_Johannesburg",
			CountryCode = "ZA",
			CountryName = "South Africa",
			OlsonTimeZone = "Africa/Johannesburg",
			FriendlyName = "Johannesburg",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Johannesburg",
		};

		private static readonly TimeZoneLocation ZM_Africa_Maputo = new TimeZoneLocation()
		{
			Id = "ZM_Africa_Maputo",
			CountryCode = "ZM",
			CountryName = "Zambia",
			OlsonTimeZone = "Africa/Maputo",
			FriendlyName = "Maputo",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Maputo",
		};

		private static readonly TimeZoneLocation ZW_Africa_Maputo = new TimeZoneLocation()
		{
			Id = "ZW_Africa_Maputo",
			CountryCode = "ZW",
			CountryName = "Zimbabwe",
			OlsonTimeZone = "Africa/Maputo",
			FriendlyName = "Maputo",
			StandardGmtOffset = "+02:00",
			FullDisplayName = "(GMT+02:00) Maputo",
		};

		private static readonly TimeZoneLocation ZZ_Etc_GMT = new TimeZoneLocation()
		{
			Id = "ZZ_Etc_GMT",
			CountryCode = "ZZ",
			CountryName = "(None)",
			OlsonTimeZone = "Etc/GMT",
			FriendlyName = "GMT (no daylight saving)",
			StandardGmtOffset = "+00:00",
			FullDisplayName = "(GMT+00:00) GMT (no daylight saving)",
		};

	}
}
