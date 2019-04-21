using System.Linq;
using MicroKnights.Collections;

namespace MicroKnights.Enumerations.Country
{
    public class CountryType : Enumeration<CountryType>
    {
        public string CountryName => DisplayName;
        public string OfficialStateName { get; }
        public string Sovereignty { get; }
        public string Alpha2Code { get; }
        public string Alpha3Code { get; }
        public int CountryCode => Value;
        public string SubdivisionCode { get; }
        public string InternetCcTld { get; }

        public CountryType() 
            : this("Unknown", "", "", "", "", 0, "", "")
        {
        }

        public CountryType(string countryName, string officialStateName, string sovereignty, string alpha2Code, string alpha3Code, int countryCode, string subdivisionCode, string internetCcTld) 
            : base(countryCode, countryName)
        {
            OfficialStateName = officialStateName;
            Sovereignty = sovereignty;
            Alpha2Code = alpha2Code;
            Alpha3Code = alpha3Code;
            SubdivisionCode = subdivisionCode;
            InternetCcTld = internetCcTld;
        }

        public static readonly CountryType Unknown = new CountryType();
        public static readonly CountryType Afghanistan = new CountryType("Afghanistan", "The Islamic Republic of Afghanistan", "UN member state", "AF", "AFG", 4, "ISO 3166-2:AF", ".af");
        public static readonly CountryType ÅlandIslands = new CountryType("Åland Islands", "Åland", "Finland", "AX", "ALA", 248, "ISO 3166-2:AX", ".ax");
        public static readonly CountryType Albania = new CountryType("Albania", "The Republic of Albania", "UN member state", "AL", "ALB", 8, "ISO 3166-2:AL", ".al");
        public static readonly CountryType Algeria = new CountryType("Algeria", "The People's Democratic Republic of Algeria", "UN member state", "DZ", "DZA", 12, "ISO 3166-2:DZ", ".dz");
        public static readonly CountryType AmericanSamoa = new CountryType("American Samoa", "The Territory of American Samoa", "United States", "AS", "ASM", 16, "ISO 3166-2:AS", ".as");
        public static readonly CountryType Andorra = new CountryType("Andorra", "The Principality of Andorra", "UN member state", "AD", "AND", 20, "ISO 3166-2:AD", ".ad");
        public static readonly CountryType Angola = new CountryType("Angola", "The Republic of Angola", "UN member state", "AO", "AGO", 24, "ISO 3166-2:AO", ".ao");
        public static readonly CountryType Anguilla = new CountryType("Anguilla", "Anguilla", "United Kingdom", "AI", "AIA", 660, "ISO 3166-2:AI", ".ai");
        public static readonly CountryType Antarctica = new CountryType("Antarctica", "Antarctica", "All land and ice shelves south of the 60th parallel south Antarctic Treaty", "AQ", "ATA", 10, "ISO 3166-2:AQ", ".aq");
        public static readonly CountryType AntiguaAndBarbuda = new CountryType("Antigua and Barbuda", "Antigua and Barbuda", "UN member state", "AG", "ATG", 28, "ISO 3166-2:AG", ".ag");
        public static readonly CountryType Denmark = new CountryType("Denmark", "The Kingdom of Denmark", "UN member state", "DK", "DNK", 208, "ISO 3166-2:DK", ".dk");
        public static readonly CountryType Argentina = new CountryType("Argentina","The Argentine Republic","UN member state","AR","ARG",32,"ISO 3166-2:AR",".ar");
        public static readonly CountryType Armenia = new CountryType("Armenia", "The Republic of Armenia", "UN member state", "AM", "ARM", 51, "ISO 3166-2:AM", ".am");
        public static readonly CountryType Aruba = new CountryType("Aruba", "Aruba", "Netherlands", "AW", "ABW", 533, "ISO 3166-2:AW", ".aw");
        public static readonly CountryType Australia = new CountryType("Australia", "The Commonwealth of Australia", "UN member state", "AU", "AUS", 36, "ISO 3166-2:AU", ".au");
        public static readonly CountryType Austria = new CountryType("Austria", "The Republic of Austria", "UN member state", "AT", "AUT", 40, "ISO 3166-2:AT", ".at");
        public static readonly CountryType Azerbaijan = new CountryType("Azerbaijan", "The Republic of Azerbaijan", "UN member state", "AZ", "AZE", 31, "ISO 3166-2:AZ", ".az");
        public static readonly CountryType Bahamas = new CountryType("Bahamas", "The Commonwealth of The Bahamas", "UN member state", "BS", "BHS", 44, "ISO 3166-2:BS", ".bs");
        public static readonly CountryType Bahrain = new CountryType("Bahrain", "The Kingdom of Bahrain", "UN member state", "BH", "BHR", 48, "ISO 3166-2:BH",".bh");
        public static readonly CountryType Bangladesh = new CountryType("Bangladesh", "The People's Republic of Bangladesh", "UN member state", "BD", "BGD", 50, "ISO 3166-2:BD", ".bd");
        public static readonly CountryType Barbados = new CountryType("Barbados", "Barbados","UN member state", "BB", "BRB", 052, "ISO 3166-2:BB", ".bb");
        public static readonly CountryType Belarus = new CountryType("Belarus", "Belarus The Republic of Belarus", "UN member state", "BY", "BLR", 112, "ISO 3166-2:BY", ".by");
        public static readonly CountryType Belgium = new CountryType("Belgium", "Belgium The Kingdom of Belgium", "UN member state", "BE", "BEL", 056, "ISO 3166-2:BE", ".be");
        public static readonly CountryType Belize = new CountryType("Belize", "Belize Belize","UN member state", "BZ ", "BLZ", 084,"ISO 3166 - 2:BZ",".bz");
        public static readonly CountryType Benin = new CountryType("Benin", "Benin The Republic of Benin", "UN member state", "BJ", "BEN", 204, "ISO 3166-2:BJ", ".bj");
        public static readonly CountryType Bermuda = new CountryType("Bermuda", "Bermuda Bermuda", "United Kingdom", "BM", "BMU", 60, "ISO 3166-2:BM", ".bm");
        public static readonly CountryType Bhutan = new CountryType("Bhutan", "Bhutan The Kingdom of Bhutan", "UN member state", "BT", "BTN", 64, "ISO 3166-2:BT", ".bt");
        public static readonly CountryType Bolivia = new CountryType("Bolivia (Plurinational State of)", "The Plurinational State of Bolivia", "UN member state", "BO", "BOL", 68, "ISO 3166-2:BO", ".bo");
        public static readonly CountryType Bonaire = new CountryType("Bonaire,Sint Eustatius,Saba", "Bonaire, Sint Eustatius and Saba", "Netherlands BQ BES", "535", "ISO", 535, "ISO 3166-2:BQ", ".bq.nl");
        public static readonly CountryType BosniaAndHerzegovina = new CountryType("Bosnia and Herzegovina", "Bosnia and Herzegovina", "UN member state", "BA ", "BIH", 70, "ISO 3166-2:BA", ".ba");
        public static readonly CountryType Botswana = new CountryType("Botswana", "Botswana The Republic of Botswana", "UN member state", "BW", "BWA", 72, "ISO 3166-2:BW", ".bw");
        public static readonly CountryType Bouvet = new CountryType("Bouvet", "Island Bouvet Island Bouvet Island", "Norway", "BV", "BVT", 74, "ISO 3166-2:BV", "[d]");
        public static readonly CountryType Brazil = new CountryType("Brazil", "Brazil The Federative Republic of Brazil", "UN member state", "BR ", "BRA", 76, "ISO 3166-2:BR", ".br");
        public static readonly CountryType BritishIndianOceanTerritory = new CountryType("British Indian Ocean Territory", "The British Indian Ocean Territory", "United Kingdom", "IO", "IOT", 86, "ISO 3166-2:IO", ".io");
        public static readonly CountryType Brunei = new CountryType("Brunei", "Brunei Darussalam[e] The Nation of Brunei, the Abode of Peace", "UN member state", "BN", "BRN", 96, "ISO 3166-2:BN", ".bn");
        public static readonly CountryType Bulgaria = new CountryType("Bulgaria", "Bulgaria The Republic of Bulgaria", "UN member state", "BG", "BGR", 100, "ISO 3166-2:BG", ".bg");
        public static readonly CountryType Burkina = new CountryType("Burkina", "Faso Burkina Faso Burkina Faso", "UN member state", "BF", "BFA", 854,"ISO 3166 - 2:BF",".bf");
        public static readonly CountryType Burundi = new CountryType("Burundi", "Burundi The Republic of Burundi", "UN member state", "BI", "BDI", 108,"ISO 3166 - 2:BI",".bi");
        public static readonly CountryType CapeVerde = new CountryType("Cape Verde", "The Republic of Cabo Verde", "UN member state", "CV ", "CPV", 132,"ISO 3166 - 2:CV",".cv");
        public static readonly CountryType Cambodia = new CountryType("Cambodia", "Cambodia The Kingdom of Cambodia", "UN member state", "KH", "KHM", 116, "ISO 3166-2:KH", ".kh");
        public static readonly CountryType Cameroon = new CountryType("Cameroon", "Cameroon The Republic of Cameroon", "UN member state", "CM", "CMR", 120, "ISO 3166-2:CM", ".cm");
        public static readonly CountryType Canada = new CountryType("Canada", "Canada Canada", "UN member state", "CA", "CAN", 124, "ISO 3166-2:CA", ".ca");
        public static readonly CountryType Cayman = new CountryType("Cayman Islands Cayman Islands", "The Cayman Islands", "United Kingdom", "KY", "CYM", 136, "ISO 3166-2:KY", ".ky");
        public static readonly CountryType CentralAfricanRepublic = new CountryType("Central African Republic Central African Republic", "The Central African Republic", "UN member state", "CF", "CAF", 140, "ISO 3166-2:CF", ".cf");
        public static readonly CountryType Chad = new CountryType("Chad", "Chad The Republic of Chad", "UN member state", "TD", "TCD", 148, "ISO 3166-2:TD", ".td");
        public static readonly CountryType Chile = new CountryType("Chile", "Chile The Republic of Chile", "UN member state", "CL", "CHL", 152, "ISO 3166-2:CL", ".cl");
        public static readonly CountryType China = new CountryType("China", "China The People's Republic of China", "UN member state", "CN", "CHN", 156, "ISO 3166-2:CN", ".cn");
        public static readonly CountryType ChristmasIsland = new CountryType("Christmas Island", "The Territory of Christmas Island","Australia", "CX", "CXR", 162, "ISO 3166-2:CX", ".cx");
        public static readonly CountryType CocoKeelingIslands = new CountryType("Coco (Keeling) Islands", "Cocos(Keeling) Islands(the)", "The Territory of Cocos(Keeling) Islands Australia", "CC", "CCK", 166, "ISO 3166-2:CC", ".cc");
        public static readonly CountryType Colombia = new CountryType("Colombia", "Colombia The Republic of Colombia", "UN member state", "CO", "COL", 170, "ISO 3166-2:CO", ".co");
        public static readonly CountryType Comoros = new CountryType("Comoros", "The Union of the Comoros", "UN member state", "KM", "COM", 174, "ISO 3166-2:KM", ".km");
        public static readonly CountryType DemocraticRepublicoftheCongo = new CountryType("Democratic Republic of the Congo", "Congo(the Democratic Republic of the) The Democratic Republic of the Congo", "UN member state", "CD ", "COD", 180, "ISO 3166-2:CD", ".cd");
        public static readonly CountryType Republic = new CountryType("Republic of the Congo Congo(the)", "The Republic of the Congo", "UN member state", "CG", "COG", 178, "ISO 3166-2:CG", ".cg");
        public static readonly CountryType CookIslandsCookIslands = new CountryType("Cook Islands Cook Islands", "The Cook Islands", "New Zealand", "CK ", "COK", 184, "ISO 3166-2:CK", ".ck");
        public static readonly CountryType CostaRica = new CountryType("Costa Rica", "The Republic of Costa Rica", "UN member state", "CR", "CRI", 188, "ISO 3166-2:CR", ".cr");
        public static readonly CountryType CôtedIvoire = new CountryType("Côte d'Ivoire", "The Republic of Côte d'Ivoire", "UN member state", "CI", "CIV", 384, "ISO 3166-2:CI", ".ci");
        public static readonly CountryType Croatia = new CountryType("Croatia", "Croatia The Republic of Croatia", "UN member state", "HR", "HRV", 191, "ISO 3166-2:HR", ".hr");
        public static readonly CountryType Cuba = new CountryType("Cuba", "Cuba The Republic of Cuba", "UN member state", "CU", "CUB", 192, "ISO 3166-2:CU", ".cu");
        public static readonly CountryType Curaçao = new CountryType("Curaçao", "Curaçao The Country of Curaçao", "Netherlands", "CW", "CUW", 531, "ISO 3166-2:CW", ".cw");
        public static readonly CountryType Cyprus = new CountryType("Cyprus", "Cyprus The Republic of Cyprus", "UN member state", "CY", "CYP", 196, "ISO 3166-2:CY", ".cy");
        public static readonly CountryType RepublicCzechia = new CountryType("Republic Czechia", "The Czech Republic", "UN member state", "CZ", "CZE", 203, "ISO 3166-2:CZ", ".cz");
        public static readonly CountryType Djibouti = new CountryType("Djibouti", "Djibouti The Republic of Djibouti", "UN member state", "DJ", "DJI", 262, "ISO 3166-2:DJ", ".dj");
        public static readonly CountryType Dominica = new CountryType("Dominica", "Dominica The Commonwealth of Dominica", "UN member state", "DM", "DMA", 212, "ISO 3166-2:DM", ".dm");
        public static readonly CountryType RepublicDominicanRepublic = new CountryType("Republic Dominican Republic", "The Dominican Republic", "UN member state", "DO ", "DOM", 214,"ISO 3166 - 2:DO",".do");
        public static readonly CountryType Ecuador = new CountryType("Ecuador", "The Republic of Ecuador", "UN member state", "EC ", "ECU", 218, "ISO 3166-2:EC", ".ec");
        public static readonly CountryType Egypt = new CountryType("Egypt", "Egypt The Arab Republic of Egypt", "UN member state", "EG ", "EGY", 818, "ISO 3166-2:EG", ".eg");
        public static readonly CountryType ElSalvador = new CountryType("El Salvador", "The Republic of El Salvador", "UN member state", "SV ", "SLV", 222, "ISO 3166-2:SV", ".sv");
        public static readonly CountryType GuineaEquatorial = new CountryType("Guinea Equatorial", "Guinea The Republic of Equatorial Guinea", "UN member state", "GQ", "GNQ", 226, "ISO 3166-2:GQ", ".gq");
        public static readonly CountryType Eritrea = new CountryType("Eritrea", "Eritrea The State of Eritrea", "UN member state", "ER", "ERI", 232, "ISO 3166-2:ER", ".er");
        public static readonly CountryType Estonia = new CountryType("Estonia", "Estonia The Republic of Estonia", "UN member state", "EE", "EST", 233, "ISO 3166-2:EE", ".ee");
        public static readonly CountryType Eswatini = new CountryType("Eswatini", "The Kingdom of Eswatini", "UN member state", "SZ", "SWZ", 748, "ISO 3166-2:SZ", ".sz");
        public static readonly CountryType Ethiopia = new CountryType("Ethiopia", "The Federal Democratic Republic of Ethiopia", "UN member state", "ET", "ETH", 231,"ISO 3166 - 2:ET",".et");
        public static readonly CountryType IslandsMalvinas = new CountryType("Islands Malvinas", "The Falkland Islands", "United Kingdom", "FK", "FLK", 238, "ISO 3166-2:FK", ".fk");
        public static readonly CountryType FaroeIslands = new CountryType("Faroe Islands", "The Faroe Islands", "Denmark", "FO ", "FRO", 234, "ISO 3166-2:FO", ".fo");
        public static readonly CountryType Fiji = new CountryType("Fiji", "The Republic of Fiji", "UN member state", "FJ", "FJI", 242, "ISO 3166-2:FJ", ".fj");
        public static readonly CountryType Finland = new CountryType("Finland", "The Republic of Finland", "UN member state", "FI", "FIN", 246, "ISO 3166-2:FI", ".fi");
        public static readonly CountryType France = new CountryType("France", "The French Republic", "UN member state", "FR ", "FRA", 250,"ISO 3166 - 2:FR",".fr");
        public static readonly CountryType FrenchGuiana = new CountryType("French Guiana", "Guyane", "France", "GF", "GUF", 254, "ISO 3166-2:GF", ".gf");
        public static readonly CountryType FrenchPolynesia = new CountryType("French Polynesia", "French Polynesia", "France", "PF", "PYF", 258, "ISO 3166-2:PF", ".pf");
        public static readonly CountryType FrenchSouthernandAntarcticLands = new CountryType("French Southern and Antarctic Lands", "French Southern Territories (the)", "The French Southern and Antarctic Lands France", "TF", "ATF", 260, "ISO 3166-2:TF", ".tf");
        public static readonly CountryType Gabon = new CountryType("Gabon", "Gabon The Gabonese Republic", "UN member state", "GA", "GAB", 266, "ISO 3166-2:GA", ".ga");
        public static readonly CountryType TheGambiaGambia = new CountryType("The Gambia Gambia", "The Republic of The Gambia", "UN member state", "GM", "GMB", 270, "ISO 3166-2:GM", ".gm");
        public static readonly CountryType Georgia = new CountryType("Georgia", "Georgia", "UN member state", "GE", "GEO", 268, "ISO 3166-2:GE", ".ge");
        public static readonly CountryType Germany = new CountryType("Germany", "Germany The Federal Republic of Germany", "UN member state", "DE ", "DEU", 276, "ISO 3166-2:DE", ".de");
        public static readonly CountryType Ghana = new CountryType("Ghana", "Ghana The Republic of Ghana", "UN member state", "GH", "GHA", 288,"ISO 3166 - 2:GH",".gh");
        public static readonly CountryType Gibraltar = new CountryType("Gibraltar", "Gibraltar", "United Kingdom", "GI", "GIB", 292, "ISO 3166-2:GI", ".gi");
        public static readonly CountryType Greece = new CountryType("Greece", "The Hellenic Republic", "UN member state", "GR", "GRC", 300, "ISO 3166-2:GR", ".gr");
        public static readonly CountryType Greenland = new CountryType("Greenland", "Kalaallit Nunaat", "Denmark", "GL", "GRL", 304, "ISO 3166-2:GL", ".gl");
        public static readonly CountryType Grenada = new CountryType("Grenada", "Grenada", "UN member state", "GD ", "GRD", 308, "ISO 3166-2:GD", ".gd");
        public static readonly CountryType Guadeloupe = new CountryType("Guadeloupe", "Guadeloupe", "France", "GP ", "GLP", 312, "ISO 3166-2:GP", ".gp");
        public static readonly CountryType Guam = new CountryType("Guam", "The Territory of Guam", "United States", "GU ", "GUM", 316, "ISO 3166-2:GU", ".gu");
        public static readonly CountryType Guatemala = new CountryType("Guatemala", "The Republic of Guatemala", "UN member state", "GT", "GTM", 320, "ISO 3166-2:GT", ".gt");
        public static readonly CountryType Guernsey = new CountryType("Guernsey", "The Bailiwick of Guernsey", "British Crown", "GG ", "GGY", 831, "ISO 3166-2:GG", ".gg");
        public static readonly CountryType Guinea = new CountryType("Guinea", "The Republic of Guinea", "UN member state", "GN", "GIN", 324, "ISO 3166-2:GN", ".gn");
        public static readonly CountryType GuineBissauxx = new CountryType("Guine-Bissau", "The Republic of Guinea-Bissau", "UN member state", "GW", "GNB", 624, "ISO 3166-2:GW", ".gw");
        public static readonly CountryType Guyana = new CountryType("Guyana", "The Co-operative Republic of Guyana", "UN member state", "GY ", "GUY", 328, "ISO 3166-2:GY", ".gy");
        public static readonly CountryType Haiti = new CountryType("Haiti", "The Republic of Haiti", "UN member state", "HT", "HTI", 332, "ISO 3166-2:HT", ".ht");
        public static readonly CountryType HeardIslandandMcDonaldIslands = new CountryType("Heard Island and McDonald Islands", "The Territory of Heard Island and McDonald Islands", "Australia", "HM ", "HMD", 334, "ISO 3166-2:HM", ".hm");
        public static readonly CountryType Honduras = new CountryType("Honduras", "The Republic of Honduras", "UN member state", "HN", "HND", 340, "ISO 3166-2:HN", ".hn");
        public static readonly CountryType Hong = new CountryType("Hong", " The Hong Kong Special Administrative Region of China", "China", "HK", "HKG", 344, "ISO 3166-2:HK", ".hk");
        public static readonly CountryType Hungary = new CountryType("Hungary", "Hungary", "UN member state", "HU ", "HUN", 348, "ISO 3166-2:HU", ".hu");
        public static readonly CountryType Iceland = new CountryType("Iceland", "Iceland", "UN member state", "IS ", "ISL", 352, "ISO 3166-2:IS", ".is");
        public static readonly CountryType India = new CountryType("India", "The Republic of India", "UN member state", "IN", "IND", 356, "ISO 3166-2:IN", ".in");
        public static readonly CountryType Indonesia = new CountryType("Indonesia", "The Republic of Indonesia", "UN member state", "ID ", "IDN", 360, "ISO 3166-2:ID", ".id");
        public static readonly CountryType Iran = new CountryType("Iran", "The Islamic Republic of Iran", "UN member state", "IR", "IRN", 364, "ISO 3166-2:IR", ".ir");
        public static readonly CountryType Iraq = new CountryType("Iraq", "The Republic of Iraq", "UN member state", "IQ", "IRQ", 368, "ISO 3166-2:IQ", ".iq");
        public static readonly CountryType RepublicofIreland = new CountryType("Republic of Ireland", "Ireland", "UN member state", "IE ", "IRL", 372, "ISO 3166-2:IE", ".ie");
        public static readonly CountryType IsleofMan = new CountryType("Isle of Man", "The Isle of Man", "British Crown", "IM ", "IMN", 833, "ISO 3166-2:IM", ".im");
        public static readonly CountryType Israel = new CountryType("Israel", "The State of Israel", "UN member state", "IL", "ISR", 376, "ISO 3166-2:IL", ".il");
        public static readonly CountryType Italy = new CountryType("Italy", "The Italian Republic", "UN member state", "IT ", "ITA", 380, "ISO 3166-2:IT", ".it");
        public static readonly CountryType Jamaica = new CountryType("Jamaica", "Jamaica", "UN member state", "JM", "JAM", 388, "ISO 3166-2:JM", ".jm");
        public static readonly CountryType Japan = new CountryType("Japan", "Japan", "UN member state", "JP", "JPN", 392, "ISO 3166-2:JP", ".jp");
        public static readonly CountryType Jersey = new CountryType("Jersey", "The Bailiwick of Jersey", "British Crown", "JE ", "JEY", 832, "ISO 3166-2:JE", ".je");
        public static readonly CountryType Jordan = new CountryType("Jordan", "The Hashemite Kingdom of Jordan", "UN member state", "JO ", "JOR", 400, "ISO 3166-2:JO", ".jo");
        public static readonly CountryType Kazakhstan = new CountryType("Kazakhstan", "The Republic of Kazakhstan", "UN member state", "KZ", "KAZ", 398, "ISO 3166-2:KZ", ".kz");
        public static readonly CountryType Kenya = new CountryType("Kenya", "The Republic of Kenya", "UN member state", "KE", "KEN", 404, "ISO 3166-2:KE", ".ke");
        public static readonly CountryType Kiribati = new CountryType("Kiribati", "The Republic of Kiribati", "UN member state", "KI", "KIR", 296,"ISO 3166 - 2:KI",".ki");
        public static readonly CountryType NorthKorea = new CountryType("North Korea", "The Democratic People's Republic of Korea", "UN member state", "KP ", "PRK", 408, "ISO 3166-2:KP", ".kp");
        public static readonly CountryType SouthKorea = new CountryType("South Korea", "(the Republic of) The Republic of Korea", "UN member state", "KR ", "KOR", 410, "ISO 3166-2:KR", ".kr");
        public static readonly CountryType Kuwait = new CountryType("Kuwait", "The State of Kuwait", "UN member state", "KW", "KWT", 414, "ISO 3166-2:KW", ".kw");
        public static readonly CountryType Kyrgyzstan = new CountryType("Kyrgyzstan", "The Kyrgyz Republic", "UN member state", "KG ", "KGZ", 417, "ISO 3166-2:KG", ".kg");
        public static readonly CountryType Laos = new CountryType("Laos", "The Lao People's Democratic Republic", "UN member state", "LA", "LAO", 418,"ISO 3166 - 2:LA",".la");
        public static readonly CountryType Latvia = new CountryType("Latvia", "The Republic of Latvia", "UN member state", "LV", "LVA", 428, "ISO 3166-2:LV", ".lv");
        public static readonly CountryType Lebanon = new CountryType("Lebanon", "The Lebanese Republic", "UN member state", "LB ", "LBN", 422, "ISO 3166-2:LB", ".lb");
        public static readonly CountryType Lesotho = new CountryType("Lesotho", "The Kingdom of Lesotho", "UN member state", "LS", "LSO", 426, "ISO 3166-2:LS", ".ls");
        public static readonly CountryType Liberia = new CountryType("Liberia", "The Republic of Liberia", "UN member state", "LR", "LBR", 430, "ISO 3166-2:LR", ".lr");
        public static readonly CountryType Libya = new CountryType("Libya", "The State of Libya", "UN member state", "LY", "LBY", 434, "ISO 3166-2:LY", ".ly");
        public static readonly CountryType Liechtenstein = new CountryType("Liechtenstein", "The Principality of Liechtenstein", "UN member state", "LI", "LIE", 438, "ISO 3166-2:LI", ".li");
        public static readonly CountryType Lithuania = new CountryType("Lithuania", "The Republic of Lithuania", "UN member state", "LT", "LTU", 440, "ISO 3166-2:LT", ".lt");
        public static readonly CountryType Luxembourg = new CountryType("Luxembourg", "The Grand Duchy of Luxembourg", "UN member state", "LU", "LUX", 442, "ISO 3166-2:LU", ".lu");
        public static readonly CountryType Macau = new CountryType("Macau", "Macao Special Administrative Region of China", "China", "MO", "MAC", 446, "ISO 3166-2:MO", ".mo");
        public static readonly CountryType NorthMacedonia = new CountryType("North Macedonia", "Republic of North Macedonia", "UN member state", "MK", "MKD", 807, "ISO 3166-2:MK", ".mk");
        public static readonly CountryType Madagascar = new CountryType("Madagascar", "The Republic of Madagascar", "UN member state", "MG", "MDG", 450,"ISO 3166 - 2:MG",".mg");
        public static readonly CountryType Malawi = new CountryType("Malawi", "The Republic of Malawi", "UN member state", "MW", "MWI", 454, "ISO 3166-2:MW", ".mw");
        public static readonly CountryType Malaysia = new CountryType("Malaysia", "Malaysia", "UN member state", "MY ", "MYS", 458, "ISO 3166-2:MY", ".my");
        public static readonly CountryType Maldives = new CountryType("Maldives", "The Republic of Maldives", "UN member state", "MV", "MDV", 462, "ISO 3166-2:MV", ".mv");
        public static readonly CountryType Mali = new CountryType("Mali", "The Republic of Mali", "UN member state", "ML", "MLI", 466, "ISO 3166-2:ML", ".ml");
        public static readonly CountryType Malta = new CountryType("Malta", "The Republic of Malta", "UN member state", "MT", "MLT", 470, "ISO 3166-2:MT", ".mt");
        public static readonly CountryType MarshallIslands = new CountryType("Marshall Islands", "The Republic of the Marshall Islands", "UN member state", "MH ", "MHL", 584, "ISO 3166-2:MH", ".mh");
        public static readonly CountryType Martinique = new CountryType("Martinique", "Martinique", "France", "MQ ", "MTQ", 474, "ISO 3166-2:MQ", ".mq");
        public static readonly CountryType Mauritania = new CountryType("Mauritania", "The Islamic Republic of Mauritania", "UN member state", "MR ", "MRT", 478, "ISO 3166-2:MR", ".mr");
        public static readonly CountryType Mauritius = new CountryType("Mauritius", "The Republic of Mauritius", "UN member state", "MU", "MUS", 480, "ISO 3166-2:MU", ".mu");
        public static readonly CountryType Mayotte = new CountryType("Mayotte", "The Department of Mayotte", "France", "YT", "MYT", 175, "ISO 3166-2:YT", ".yt");
        public static readonly CountryType Mexico = new CountryType("Mexico", "The United Mexican States", "UN member state", "MX", "MEX", 484, "ISO 3166-2:MX", ".mx");
        public static readonly CountryType FederatedStatesofMicronesia = new CountryType("Federated States of Micronesia", "The Federated States of Micronesia", "UN member state", "FM", "FSM", 583, "ISO 3166-2:FM", ".fm");
        public static readonly CountryType Moldova = new CountryType("Moldova", "The Republic of Moldova", "UN member state", "MD ", "MDA", 498, "ISO 3166-2:MD", ".md");
        public static readonly CountryType Monaco = new CountryType("Monaco", "The Principality of Monaco", "UN member state", "MC", "MCO", 492, "ISO 3166-2:MC", ".mc");
        public static readonly CountryType Mongolia = new CountryType("Mongolia", "The State of Mongolia", "UN member state", "MN", "MNG", 496, "ISO 3166-2:MN", ".mn");
        public static readonly CountryType Montenegro = new CountryType("Montenegro", "Montenegro", "UN member state", "ME ", "MNE", 499, "ISO 3166-2:ME", ".me");
        public static readonly CountryType Montserrat = new CountryType("Montserrat", "Montserrat", "United Kingdom", "MS", "MSR", 500, "ISO 3166-2:MS", ".ms");
        public static readonly CountryType Morocco = new CountryType("Morocco", "The Kingdom of Morocco", "UN member state", "MA", "MAR", 504, "ISO 3166-2:MA", ".ma");
        public static readonly CountryType Mozambique = new CountryType("Mozambique", "The Republic of Mozambique", "UN member state", "MZ", "MOZ", 508, "ISO 3166-2:MZ", ".mz");
        public static readonly CountryType Myanmar = new CountryType("Myanmar", "The Republic of the Union of Myanmar", "UN member state", "MM ", "MMR", 104, "ISO 3166-2:MM", ".mm");
        public static readonly CountryType Namibia = new CountryType("Namibia", "The Republic of Namibia", "UN member state", "NA", "NAM", 516, "ISO 3166-2:NA", ".na");
        public static readonly CountryType Nauru = new CountryType("Nauru", "The Republic of Nauru", "UN member state", "NR", "NRU", 520, "ISO 3166-2:NR", ".nr");
        public static readonly CountryType Nepal = new CountryType("Nepal", "The Federal Democratic Republic of Nepal", "UN member state", "NP", "NPL", 524, "ISO 3166-2:NP", ".np");
        public static readonly CountryType Netherlands = new CountryType("Netherlands", "The Kingdom of the Netherlands", "UN member state", "NL", "NLD", 528, "ISO 3166-2:NL", ".nl");
        public static readonly CountryType NewCaledonia = new CountryType("New Caledonia", "New Caledonia New Caledonia","France", "NC", "NCL", 540,"ISO 3166 - 2:NC",".nc");
        public static readonly CountryType NewZealand = new CountryType("New Zealand", "New Zealand", "UN member state", "NZ", "NZL", 554, "ISO 3166-2:NZ", ".nz");
        public static readonly CountryType Nicaragua = new CountryType("Nicaragua", "The Republic of Nicaragua", "UN member state", "NI", "NIC", 558, "ISO 3166-2:NI", ".ni");
        public static readonly CountryType Niger = new CountryType("Niger", "The Republic of the Niger", "UN member state", "NE", "NER", 562, "ISO 3166-2:NE", ".ne");
        public static readonly CountryType Nigeria = new CountryType("Nigeria", "The Federal Republic of Nigeria", "UN member state", "NG ", "NGA", 566, "ISO 3166-2:NG", ".ng");
        public static readonly CountryType Niue = new CountryType("Niue", "Niue", "New Zealand", "NU", "NIU", 570, "ISO 3166-2:NU", ".nu");
        public static readonly CountryType NorfolkIsland = new CountryType("Norfolk Island", "The Territory of Norfolk Island", "Australia", "NF", "NFK", 574, "ISO 3166-2:NF", ".nf");
        public static readonly CountryType NorthernMarianaIslands = new CountryType("Northern Mariana Islands", "The Commonwealth of the Northern Mariana Islands", "United States", "MP ", "MNP", 580, "ISO 3166-2:MP", ".mp");
        public static readonly CountryType Norway = new CountryType("Norway", "The Kingdom of Norway", "UN member state", "NO", "NOR", 578, "ISO 3166-2:NO", ".no");
        public static readonly CountryType Oman = new CountryType("Oman", "The Sultanate of Oman", "UN member state", "OM", "OMN", 512, "ISO 3166-2:OM", ".om");
        public static readonly CountryType Pakistan = new CountryType("Pakistan", "The Islamic Republic of Pakistan", "UN member state", "PK", "PAK", 586, "ISO 3166-2:PK", ".pk");
        public static readonly CountryType Palau = new CountryType("Palau", "The Republic of Palau", "UN member state", "PW", "PLW", 585, "ISO 3166-2:PW", ".pw");
        public static readonly CountryType StateofPalestine = new CountryType("State of Palestine", "The State of Palestine", "UN observer", "PS", "PSE", 275, "ISO 3166-2:PS", ".ps");
        public static readonly CountryType Panama = new CountryType("Panama", "The Republic of Panamá", "UN member state", "PA", "PAN", 591, "ISO 3166-2:PA", ".pa");
        public static readonly CountryType PapuaNewGuinea = new CountryType("Papua New Guinea", "The Independent State of Papua New Guinea", "UN member state", "PG ", "PNG", 598, "ISO 3166-2:PG", ".pg");
        public static readonly CountryType Paraguay = new CountryType("Paraguay", "The Republic of Paraguay", "UN member state", "PY", "PRY", 600, "ISO 3166-2:PY", ".py");
        public static readonly CountryType Peru = new CountryType("Peru", "The Republic of Perú", "UN member state", "PE", "PER", 604, "ISO 3166-2:PE", ".pe");
        public static readonly CountryType Philippines = new CountryType("Philippines", "The Republic of the Philippines", "UN member state", "PH", "PHL", 608, "ISO 3166-2:PH", ".ph");
        public static readonly CountryType Pitcairn = new CountryType("Pitcairn", "The Pitcairn, Henderson, Ducie and Oeno Islands", "United Kingdom", "PN ", "PCN", 612, "ISO 3166-2:PN", ".pn");
        public static readonly CountryType Poland = new CountryType("Poland", "The Republic of Poland", "UN member state", "PL", "POL", 616, "ISO 3166-2:PL", ".pl");
        public static readonly CountryType Portugal = new CountryType("Portugal", "The Portuguese Republic", "UN member state", "PT", "PRT", 620, "ISO 3166-2:PT", ".pt");
        public static readonly CountryType PuertoRico = new CountryType("Puerto Rico", "The Commonwealth of Puerto Rico", "United States", "PR", "PRI", 630,"ISO 3166 - 2:PR",".pr");
        public static readonly CountryType Qatar = new CountryType("Qatar", "The State of Qatar", "UN member state", "QA", "QAT", 634, "ISO 3166-2:QA", ".qa");
        public static readonly CountryType Réunion = new CountryType("Réunion", "Réunion", "France", "RE", "REU", 638, "ISO 3166-2:RE", ".re");
        public static readonly CountryType Romania = new CountryType("Romania", "Romania", "UN member state", "RO ", "ROU", 642, "ISO 3166-2:RO", ".ro");
        public static readonly CountryType Russia = new CountryType("Russia", "The Russian Federation", "UN member state", "RU ", "RUS", 643, "ISO 3166-2:RU", ".ru");
        public static readonly CountryType Rwanda = new CountryType("Rwanda", "The Republic of Rwanda", "UN member state", "RW", "RWA", 646, "ISO 3166-2:RW", ".rw");
        public static readonly CountryType SaintBarthélemy = new CountryType("Saint Barthélemy", "The Collectivity of Saint-Barthélemy", "France", "BL", "BLM", 652, "ISO 3166-2:BL", ".bl");
        public static readonly CountryType SaintHelena = new CountryType("Saint Helena, Ascension and Tristan da Cunha Saint Helena", "Ascension and Tristan da Cunha", "United Kingdom", "SH", "SHN", 654, "ISO 3166-2:SH", ".sh");
        public static readonly CountryType SaintKittsandNevis = new CountryType("Saint Kitts and Nevis", "Saint Kitts and Nevis", "UN member state", "KN", "KNA", 659, "ISO 3166-2:KN", ".kn");
        public static readonly CountryType SaintLucia = new CountryType("Saint Lucia", "Saint Lucia", "UN member state", "LC", "LCA", 662, "ISO 3166-2:LC", ".lc");
        public static readonly CountryType CollectivityofSaintMartin = new CountryType("Collectivity of Saint Martin", "The Collectivity of Saint-Martin", "France", "MF", "MAF", 663, "ISO 3166-2:MF", ".mf");
        public static readonly CountryType SaintPierreandMiquelon = new CountryType("Saint Pierre and Miquelon", "The Overseas Collectivity of Saint-Pierre and Miquelon", "France", "PM", "SPM", 666, "ISO 3166-2:PM", ".pm");
        public static readonly CountryType SaintVincentandtheGrenadines = new CountryType("Saint Vincent and the Grenadines", "Saint Vincent and the Grenadines", "UN member state", "VC", "VCT", 670, "ISO 3166-2:VC", ".vc");
        public static readonly CountryType Samoa = new CountryType("Samoa", "The Independent State of Samoa", "UN member state", "WS", "WSM", 882, "ISO 3166-2:WS", ".ws");
        public static readonly CountryType SanMarino = new CountryType("San Marino", "The Republic of San Marino", "UN member state", "SM", "SMR", 674, "ISO 3166-2:SM", ".sm");
        public static readonly CountryType SãoToméandPríncipe = new CountryType("São Tomé and Príncipe", "The Democratic Republic of São Tomé and Príncipe", "UN member state", "ST", "STP", 678, "ISO 3166-2:ST", ".st");
        public static readonly CountryType SaudArabia = new CountryType("Saud Arabia", "The Kingdom of Saudi Arabia", "UN member state", "SA", "SAU", 682, "ISO 3166-2:SA", ".sa");
        public static readonly CountryType Senegal = new CountryType("Senegal", "The Republic of Senegal", "UN member state", "SN ", "SEN", 686, "ISO 3166-2:SN", ".sn");
        public static readonly CountryType Serbia = new CountryType("Serbia", "The Republic of Serbia", "UN member state", "RS", "SRB", 688, "ISO 3166-2:RS", ".rs");
        public static readonly CountryType Seychelles = new CountryType("Seychelles", "The Republic of Seychelles", "UN member state", "SC", "SYC", 690, "ISO 3166-2:SC", ".sc");
        public static readonly CountryType SierraLeone = new CountryType("Sierra Leone", "The Republic of Sierra Leone", "UN member state", "SL ", "SLE", 694, "ISO 3166-2:SL", ".sl");
        public static readonly CountryType Singapore = new CountryType("Singapore", "The Republic of Singapore", "UN member state", "SG", "SGP", 702, "ISO 3166-2:SG", ".sg");
        public static readonly CountryType SintMaarten = new CountryType("Sint Maarten", "Sint Maarten","Netherlands", "SX", "SXM", 534, "ISO 3166-2:SX", ".sx");
        public static readonly CountryType Slovakia = new CountryType("Slovakia", "The Slovak Republic", "UN member state", "SK ", "SVK", 703, "ISO 3166-2:SK", ".sk");
        public static readonly CountryType Slovenia = new CountryType("Slovenia", "The Republic of Slovenia", "UN member state", "SI", "SVN", 705, "ISO 3166-2:SI", ".si");
        public static readonly CountryType SolomonIslands = new CountryType("Solomon Islands", "The Solomon Islands", "UN member state", "SB ", "SLB", 090, "ISO 3166-2:SB", ".sb");
        public static readonly CountryType Somalia = new CountryType("Somalia", "The Federal Republic of Somalia", "UN member state", "SO ", "SOM", 706, "ISO 3166-2:SO", ".so");
        public static readonly CountryType SouthAfrica = new CountryType("South Africa", "The Republic of South Africa", "UN member state", "ZA ", "ZAF", 710, "ISO 3166-2:ZA", ".za");
        public static readonly CountryType SouthGeorgiaandtheSouthSandwichIslands = new CountryType("South Sudan", "The Republic of South Sudan", "UN member state", "SS", "SSD", 728, "ISO 3166-2:SS", ".ss");
        public static readonly CountryType Spain = new CountryType("Spain", "The Kingdom of Spain", "UN member state", "ES", "ESP", 724, "ISO 3166-2:ES", ".es");
        public static readonly CountryType SriLanka = new CountryType("Sri Lanka", "The Democratic Socialist Republic of Sri Lanka", "UN member state", "LK", "LKA", 144, "ISO 3166-2:LK", ".lk");
        public static readonly CountryType Sudan = new CountryType("Sudan", "The Republic of the Sudan", "UN member state", "SD", "SDN", 729, "ISO 3166-2:SD", ".sd");
        public static readonly CountryType Suriname = new CountryType("Suriname", "The Republic of Suriname", "UN member state", "SR", "SUR", 740, "ISO 3166-2:SR", ".sr");
        public static readonly CountryType SvalbardJanMayen = new CountryType("Svalbard,Jan Mayen", "Svalbard and Jan Mayen", "Norway", "SJ", "SJM", 744, "ISO 3166-2:SJ", "[w]");
        public static readonly CountryType Sweden = new CountryType("Sweden", "The Kingdom of Sweden", "UN member state", "SE", "SWE", 752, "ISO 3166-2:SE", ".se");
        public static readonly CountryType Switzerland = new CountryType("Switzerland", "The Swiss Confederation", "UN member state", "CH", "CHE", 756, "ISO 3166-2:CH", ".ch");
        public static readonly CountryType Syria = new CountryType("Syria", "The Syrian Arab Republic", "UN member state", "SY", "SYR", 760, "ISO 3166-2:SY", ".sy");
        public static readonly CountryType Taiwan = new CountryType("Taiwan", "The Republic of China disputed", "China", "TW", "TWN", 158, "ISO 3166-2:TW", ".tw");
        public static readonly CountryType Tajikistan = new CountryType("Tajikistan", "The Republic of Tajikistan", "UN member state", "TJ", "TJK", 762, "ISO 3166-2:TJ", ".tj");
        public static readonly CountryType Tanzania = new CountryType("Tanzania", "The United Republic of Tanzania", "UN member state", "TZ", "TZA", 834, "ISO 3166-2:TZ", ".tz");
        public static readonly CountryType Thailand = new CountryType("Thailand", "The Kingdom of Thailand", "UN member state", "TH", "THA", 764, "ISO 3166-2:TH", ".th");
        public static readonly CountryType EastTimor = new CountryType("East Timor", "The Democratic Republic of Timor-Leste", "UN member state", "TL", "TLS", 626, "ISO 3166-2:TL", ".tl");
        public static readonly CountryType Togo = new CountryType("Togo", "The Togolese Republic", "UN member state", "TG", "TGO", 768, "ISO 3166-2:TG", ".tg");
        public static readonly CountryType Tokelau = new CountryType("Tokelau", "Tokelau", "New Zealand", "TK", "TKL", 772, "ISO 3166-2:TK", ".tk");
        public static readonly CountryType Tonga = new CountryType("Tonga", "The Kingdom of Tonga", "UN member state", "TO", "TON", 776, "ISO 3166-2:TO", ".to");
        public static readonly CountryType TrinidadandTobago = new CountryType("Trinidad and Tobago", "The Republic of Trinidad and Tobago", "UN member state", "TT", "TTO", 780, "ISO 3166-2:TT", ".tt");
        public static readonly CountryType Tunisia = new CountryType("Tunisia", "The Republic of Tunisia", "UN member state", "TN", "TUN", 788, "ISO 3166-2:TN", ".tn");
        public static readonly CountryType Turkey = new CountryType("Turkey", "The Republic of Turkey", "UN member state", "TR", "TUR", 792, "ISO 3166-2:TR", ".tr");
        public static readonly CountryType Turkmenistan = new CountryType("Turkmenistan", "Turkmenistan", "UN member state", "TM ", "TKM", 795, "ISO 3166-2:TM", ".tm");
        public static readonly CountryType TurksandCaicosIslands = new CountryType("Turks and Caicos Islands", "The Turks and Caicos Islands","United Kingdom", "TC ", "TCA", 796, "ISO 3166-2:TC", ".tc");
        public static readonly CountryType Tuvalu = new CountryType("Tuvalu", "Tuvalu", "UN member state", "TV ", "TUV", 798, "ISO 3166-2:TV", ".tv");
        public static readonly CountryType Uganda = new CountryType("Uganda", "The Republic of Uganda", "UN member state", "UG", "UGA", 800, "ISO 3166-2:UG", ".ug");
        public static readonly CountryType Ukraine = new CountryType("Ukraine", "Ukraine", "UN member state", "UA", "UKR", 804, "ISO 3166-2:UA", ".ua");
        public static readonly CountryType UnitedArabEmirates = new CountryType("United Arab Emirates", "The United Arab Emirates", "UN member state", "AE ", "ARE", 784, "ISO 3166-2:AE", ".ae");
        public static readonly CountryType UnitedKingdomUnited = new CountryType("United Kingdom United", "The United Kingdom of Great Britain and Northern Ireland", "UN member state", "GB", "GBR", 826, "ISO 3166-2:GB", ".gb.uk");
        public static readonly CountryType UnitedStatesUnitedStatesMinorOutlyingIslands = new CountryType("United States United States Minor Outlying Islands", "Baker Island, Howland Island, Jarvis Island, Johnston Atoll, Kingman Reef, Midway Atoll, Navassa Island, Palmyra Atoll, and Wake Island", "United States", "UM ", "UMI", 581, "ISO 3166-2:UM", "");
        public static readonly CountryType UnitedStatesUnitedStatesofAmerica = new CountryType("United States United States of America", "The United States of America", "UN member state", "US", "USA", 840, "ISO 3166-2:US", ".us");
        public static readonly CountryType Uruguay = new CountryType("Uruguay", "The Oriental Republic of Uruguay", "UN member state", "UY", "URY", 858, "ISO 3166-2:UY", ".uy");
        public static readonly CountryType Uzbekistan = new CountryType("Uzbekistan", "The Republic of Uzbekistan", "UN member state", "UZ", "UZB", 860, "ISO 3166-2:UZ", ".uz");
        public static readonly CountryType Vanuatu = new CountryType("Vanuatu", "The Republic of Vanuatu", "UN member state", "VU", "VUT", 548, "ISO 3166-2:VU", ".vu");
        public static readonly CountryType Venezuela = new CountryType("Venezuela", "The Bolivarian Republic of Venezuela", "UN member state", "VE", "VEN", 862, "ISO 3166-2:VE", ".ve");
        public static readonly CountryType Vietnam = new CountryType("Vietnam", "The Socialist Republic of Viet Nam", "UN member state", "VN ", "VNM", 704, "ISO 3166-2:VN", ".vn");
        public static readonly CountryType BritishVirginIslands = new CountryType("British Virgin Islands", "The Virgin Islands", "United Kingdom", "VG ", "VGB", 092, "ISO 3166-2:VG", ".vg");
        public static readonly CountryType UnitedStatesVirginIslands = new CountryType("United States Virgin Islands", "The Virgin Islands of the United States", "United States", "VI ", "VIR", 850, "ISO 3166-2:VI", ".vi");
        public static readonly CountryType WallisandFutunaWallisandFutuna = new CountryType("Wallis and Futuna Wallis and Futuna", "The Territory of the Wallis and Futuna Islands", "France", "WF ", "WLF", 876, "ISO 3166-2:WF", ".wf");
        public static readonly CountryType WesternSaharaWesternSahara = new CountryType("Western Sahara","The Sahrawi Arab Democratic Republic","disputed", "EH ", "ESH", 732, "ISO 3166-2:EH", "");
        public static readonly CountryType Yemen = new CountryType("Yemen", "The Republic of Yemen", "UN member state", "YE", "YEM", 887, "ISO 3166-2:YE", ".ye");
        public static readonly CountryType Zambia = new CountryType("Zambia", "The Republic of Zambia", "UN member state", "ZM", "ZMB", 894, "ISO 3166-2:ZM", ".zm");
        public static readonly CountryType Zimbabwe = new CountryType("Zimbabwe", "The Republic of Zimbabwe", "UN member state", "ZW", "ZWE", 716, "ISO 3166-2:ZW", ".zw");

        public static CountryType GetByAlpha2CodeOrDefault(string countryAlpha2Code, CountryType defaultType)
        {
            return GetAll().SingleOrDefault(_ => _.Alpha2Code == countryAlpha2Code) ?? defaultType;
        }

        public static CountryType GetByAlpha3CodeOrDefault(string countryAlpha3Code, CountryType defaultType)
        {
            return GetAll().SingleOrDefault(_ => _.Alpha3Code == countryAlpha3Code) ?? defaultType;
        }

        public bool IsSelectable => Value > 0;
    }
}
