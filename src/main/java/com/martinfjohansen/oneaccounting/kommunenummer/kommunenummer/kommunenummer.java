package com.martinfjohansen.oneaccounting.kommunenummer.kommunenummer;

import com.martinfjohansen.oneaccounting.references.references.StringReference;

import static com.martinfjohansen.oneaccounting.arraysarrays.arrays.arrays.arraysStringsEqual;
import static com.martinfjohansen.oneaccounting.strstrings.strings.strings.strSplitByString;


public class kommunenummer{
	public static boolean HentKommunenavnFraNummer(char [] kommunenummer, StringReference kommunenavnReference, StringReference errorMessages){
		double nr;
		boolean success;
		StringReference [] nummer, kommunenavn;

		kommunenavn = HentKommunenavn();

		nummer = HentGyldigeKommunenummer();
		success = false;

		for(nr = 0d; nr < nummer.length && !success; nr = nr + 1d){
			if(arraysStringsEqual(nummer[(int)(nr)].string, kommunenummer)){
				success = true;
				kommunenavnReference.string = kommunenavn[(int)(nr)].string;
			}
		}

		if(!success){
			errorMessages.string = "Kommunenummer er ikke gyldig.".toCharArray();
		}

		return success;
	}

	public static boolean ErGyldigKommunenummer(char [] kommunenummer){
		boolean gyldig;
		double i;
		StringReference [] nummer;

		gyldig = false;

		if(kommunenummer.length == 4d){
			nummer = HentGyldigeKommunenummer();

			for(i = 0d; i < nummer.length && !gyldig; i = i + 1d){
				if(arraysStringsEqual(nummer[(int)(i)].string, kommunenummer)){
					gyldig = true;
				}
			}
		}

		return gyldig;
	}

	public static StringReference [] HentKommunenavn(){
		StringReference [] kommunenavn;
		char [] kommunenavnliste;

		kommunenavnliste = "\u00c5fjord, Agdenes, \u00c5l, \u00c5lesund, Alstahaug, Alta, Alvdal, \u00c5mli, \u00c5mot, And\u00f8y, \u00c5rdal, Aremark, Arendal, \u00c5s, \u00c5seral, Asker, Askim, Ask\u00f8y, Askvoll, \u00c5snes, Audnedal, Aukra, Aure, Aurland, Aurskog-H\u00f8land, Austevoll, Austrheim, Aver\u00f8y, B\u00e6rum, Balestrand, Ballangen, Balsfjord, Bamble, Bardu, B\u00e5tsfjord, Beiarn, Berg, Bergen, Berlev\u00e5g, Bindal, Birkenes, Bjerkreim, Bjugn, B\u00f8 i Nordland , B\u00f8 i Telemark, Bod\u00f8, Bokn, B\u00f8mlo, Bremanger, Br\u00f8nn\u00f8y, Bygland, Bykle, Deatnu - Tana, Divtasvuodna - Tysfjord, D\u00f8nna, Dovre, Drammen, Drangedal, Dyr\u00f8y, Eid, Eide, Eidfjord, Eidsberg, Eidskog, Eidsvoll, Eigersund, Elverum, Enebakk, Engerdal, Etne, Etnedal, Evenes, Evje og Hornnes, F\u00e6rder, Farsund, Fauske - Fuossko, Fedje, Fet, Finn\u00f8y, Fitjar, Fjaler, Fjell, Fl\u00e5, Flakstad, Flatanger, Flekkefjord, Flesberg, Flora, Folldal, F\u00f8rde, Forsand, Fosnes, Fr\u00e6na, Fredrikstad, Frogn, Froland, Frosta, Fr\u00f8ya, Fusa, Fyresdal, G\u00e1ivuotna - K\u00e5fjord - Kaivuono, Gamvik, Gaular, Gausdal, Gildesk\u00e5l, Giske, Gjemnes, Gjerdrum, Gjerstad, Gjesdal, Gj\u00f8vik, Gloppen, Gol, Gran, Grane, Granvin, Gratangen, Grimstad, Grong, Grue, Gulen, Guovdageaidnu - Kautokeino, H\u00e5, Hadsel, H\u00e6gebostad, Halden, Halsa, Hamar, Hamar\u00f8y - H\u00e1bmer, Hammerfest, Haram, Hareid, Harstad - H\u00e1rstt\u00e1k, Hasvik, Hattfjelldal, Haugesund, Hemne, Hemnes, Hemsedal, Her\u00f8y i  M\u00f8re og Romsdal, Her\u00f8y i Nordland, Hitra, Hjartdal, Hjelmeland, Hob\u00f8l, Hol, Hole, Holmestrand, Holt\u00e5len, Hornindal, Horten, H\u00f8yanger, H\u00f8ylandet, Hurdal, Hurum, Hvaler, Hyllestad, Ibestad, Inder\u00f8y, Indre Fosen, Iveland, Jevnaker, J\u00f8lster, Jondal, K\u00e1r\u00e1\u0161johka - Karasjok, Karls\u00f8y, Karm\u00f8y, Kl\u00e6bu, Klepp, Kongsberg, Kongsvinger, Krager\u00f8, Kristiansand, Kristiansund, Kr\u00f8dsherad, Kv\u00e6fjord, Kv\u00e6nangen, Kvalsund, Kvam, Kvinesdal, Kvinnherad, Kviteseid, Kvits\u00f8y, L\u00e6rdal, Larvik, Lebesby, Leikanger, Leirfjord, Leka, Lenvik, Lesja, Levanger, Lier, Lierne, Lillehammer, Lillesand, Lind\u00e5s, Lindesnes, Loab\u00e1k - Lavangen, L\u00f8dingen, Lom, Loppa, L\u00f8renskog, L\u00f8ten, Lund, Lunner, Lur\u00f8y, Luster, Lyngdal, Lyngen, M\u00e5lselv, Malvik, Mandal, Marker, Marnardal, Masfjorden, M\u00e5s\u00f8y, Meland, Meldal, Melhus, Mel\u00f8y, Mer\u00e5ker, Midsund, Midtre Gauldal, Modalen, Modum, Molde, Moskenes, Moss, N\u00e6r\u00f8y, Namdalseid, Namsos, Namsskogan, Nannestad, Narvik, Naustdal, Nedre Eiker, Nes i Akershus, Nes i Buskerud, Nesna, Nesodden, Nesset, Nissedal, Nittedal, Nome, Nord-Aurdal, Norddal, Nord-Fron, Nordkapp, Nord-Odal, Nordre Land, Nordreisa - R\u00e1isa - Raisi, Nore og Uvdal, Notodden, Odda, \u00d8ksnes, Oppdal, Oppeg\u00e5rd, Orkdal, \u00d8rland, \u00d8rskog, \u00d8rsta, Os i Hedmark, Os i Hordaland, Osen, Oslo, Oster\u00f8y, \u00d8stre Toten, Overhalla, \u00d8vre Eiker, \u00d8yer, \u00d8ygarden, \u00d8ystre Slidre, Porsanger - Pors\u00e1\u014bgu - Porsanki, Porsgrunn, Raarvikhe - R\u00f8yrvik, R\u00e5de, Rad\u00f8y, R\u00e6lingen, Rakkestad, Rana, Randaberg, Rauma, Re, Rendalen, Rennebu, Rennes\u00f8y, Rindal, Ringebu, Ringerike, Ringsaker, Ris\u00f8r, Roan, R\u00f8d\u00f8y, Rollag, R\u00f8mskog, R\u00f8ros, R\u00f8st, R\u00f8yken, Rygge, Salangen, Saltdal, Samnanger, Sande i M\u00f8re og Romsdal, Sande i Vestfold, Sandefjord, Sandnes, Sand\u00f8y, Sarpsborg, Sauda, Sauherad, Sel, Selbu, Selje, Seljord, Sigdal, Siljan, Sirdal, Sk\u00e5nland, Skaun, Skedsmo, Ski, Skien, Skiptvet, Skj\u00e5k, Skjerv\u00f8y, Skodje, Sm\u00f8la, Sn\u00e5ase - Sn\u00e5sa, Snillfjord, Sogndal, S\u00f8gne, Sokndal, Sola, Solund, S\u00f8mna, S\u00f8ndre Land, Songdalen, S\u00f8r-Aurdal, S\u00f8rfold, S\u00f8r-Fron, S\u00f8r-Odal, S\u00f8rreisa, Sortland - Suort\u00e1, S\u00f8rum, S\u00f8r-Varanger, Spydeberg, Stange, Stavanger, Steigen, Steinkjer, Stj\u00f8rdal, Stord, Stordal, Stor-Elvdal, Storfjord - Omasvuotna - Omasvuono, Strand, Stranda, Stryn, Sula, Suldal, Sund, Sunndal, Surnadal, Sveio, Svelvik, Sykkylven, Time, Tingvoll, Tinn, Tjeldsund, Tokke, Tolga, T\u00f8nsberg, Torsken, Tr\u00e6na, Tran\u00f8y, Tr\u00f8gstad, Troms\u00f8, Trondheim , Trysil, Tvedestrand, Tydal, Tynset, Tysnes, Tysv\u00e6r, Ullensaker, Ullensvang, Ulstein, Ulvik, Unj\u00e1rga - Nesseby, Utsira, Vads\u00f8, V\u00e6r\u00f8y, V\u00e5g\u00e5, V\u00e5gan, V\u00e5gs\u00f8y, Vaksdal, V\u00e5ler i Hedmark, V\u00e5ler i \u00d8stfold, Valle, Vang, Vanylven, Vard\u00f8, Vefsn, Vega, Veg\u00e5rshei, Vennesla, Verdal, Verran, Vestby, Vestnes, Vestre Slidre, Vestre Toten, Vestv\u00e5g\u00f8y, Vevelstad, Vik, Vikna, Vindafjord, Vinje, Volda, Voss, ".toCharArray();

		kommunenavn = strSplitByString(kommunenavnliste, ", ".toCharArray());

		return kommunenavn;
	}

	public static StringReference [] HentGyldigeKommunenummer(){
		char [] kommunenummerliste;
		StringReference [] kommunenummer;

		kommunenummerliste = "5018, 5016, 0619, 1504, 1820, 2012, 0438, 0929, 0429, 1871, 1424, 0118, 0906, 0214, 1026, 0220, 0124, 1247, 1428, 0425, 1027, 1547, 1576, 1421, 0221, 1244, 1264, 1554, 0219, 1418, 1854, 1933, 0814, 1922, 2028, 1839, 1929, 1201, 2024, 1811, 0928, 1114, 5017, 1867, 0821, 1804, 1145, 1219, 1438, 1813, 0938, 0941, 2025, 1850, 1827, 0511, 0602, 0817, 1926, 1443, 1551, 1232, 0125, 0420, 0237, 1101, 0427, 0229, 0434, 1211, 0541, 1853, 0937, 0729, 1003, 1841, 1265, 0227, 1141, 1222, 1429, 1246, 0615, 1859, 5049, 1004, 0631, 1401, 0439, 1432, 1129, 5048, 1548, 0106, 0215, 0919, 5036, 5014, 1241, 0831, 1940, 2023, 1430, 0522, 1838, 1532, 1557, 0234, 0911, 1122, 0502, 1445, 0617, 0534, 1825, 1234, 1919, 0904, 5045, 0423, 1411, 2011, 1119, 1866, 1034, 0101, 1571, 0403, 1849, 2004, 1534, 1517, 1903, 2015, 1826, 1106, 5011, 1832, 0618, 1515, 1818, 5013, 0827, 1133, 0138, 0620, 0612, 0715, 5026, 1444, 0701, 1416, 5046, 0239, 0628, 0111, 1413, 1917, 5053, 5054, 0935, 0532, 1431, 1227, 2021, 1936, 1149, 5030, 1120, 0604, 0402, 0815, 1001, 1505, 0622, 1911, 1943, 2017, 1238, 1037, 1224, 0829, 1144, 1422, 0712, 2022, 1419, 1822, 5052, 1931, 0512, 5037, 0626, 5042, 0501, 0926, 1263, 1029, 1920, 1851, 0514, 2014, 0230, 0415, 1112, 0533, 1834, 1426, 1032, 1938, 1924, 5031, 1002, 0119, 1021, 1266, 2018, 1256, 5023, 5028, 1837, 5034, 1545, 5027, 1252, 0623, 1502, 1874, 0104, 5051, 5040, 5005, 5044, 0238, 1805, 1433, 0625, 0236, 0616, 1828, 0216, 1543, 0830, 0233, 0819, 0542, 1524, 0516, 2019, 0418, 0538, 1942, 0633, 0807, 1228, 1868, 5021, 0217, 5024, 5015, 1523, 1520, 0441, 1243, 5020, 0301, 1253, 0528, 5047, 0624, 0521, 1259, 0544, 2020, 0805, 5043, 0135, 1260, 0228, 0128, 1833, 1127, 1539, 0716, 0432, 5022, 1142, 5061, 0520, 0605, 0412, 0901, 5019, 1836, 0632, 0121, 5025, 1856, 0627, 0136, 1923, 1840, 1242, 1514, 0713, 0710, 1102, 1546, 0105, 1135, 0822, 0517, 5032, 1441, 0828, 0621, 0811, 1046, 1913, 5029, 0231, 0213, 0806, 0127, 0513, 1941, 1529, 1573, 5041, 5012, 1420, 1018, 1111, 1124, 1412, 1812, 0536, 1017, 0540, 1845, 0519, 0419, 1925, 1870, 0226, 2030, 0123, 0417, 1103, 1848, 5004, 5035, 1221, 1526, 0430, 1939, 1130, 1525, 1449, 1531, 1134, 1245, 1563, 1566, 1216, 0711, 1528, 1121, 1560, 0826, 1852, 0833, 0436, 0704, 1928, 1835, 1927, 0122, 1902, 5001, 0428, 0914, 5033, 0437, 1223, 1146, 0235, 1231, 1516, 1233, 2027, 1151, 2003, 1857, 0515, 1865, 1439, 1251, 0426, 0137, 0940, 0545, 1511, 2002, 1824, 1815, 0912, 1014, 5038, 5039, 0211, 1535, 0543, 0529, 1860, 1816, 1417, 5050, 1160, 0834, 1519, 1235".toCharArray();

		kommunenummer = strSplitByString(kommunenummerliste, ", ".toCharArray());

		return kommunenummer;
	}

  public static void delete(Object object){
    // Java has garbage collection.
  }
}
