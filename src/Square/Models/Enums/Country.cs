using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the country associated with another entity, such as a business.
/// Values are in <see href="http://www.iso.org/iso/home/standards/country_codes.htm">ISO 3166-1-alpha-2 format</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Country>))]
public sealed record Country : OpenStringEnum<Country>
{
    private Country(string value) : base(value)
    {
    }

    /// <summary>
    /// Unknown
    /// </summary>
    public static readonly Country Zz = new("ZZ");

    /// <summary>
    /// Andorra
    /// </summary>
    public static readonly Country Ad = new("AD");

    /// <summary>
    /// United Arab Emirates
    /// </summary>
    public static readonly Country Ae = new("AE");

    /// <summary>
    /// Afghanistan
    /// </summary>
    public static readonly Country Af = new("AF");

    /// <summary>
    /// Antigua and Barbuda
    /// </summary>
    public static readonly Country Ag = new("AG");

    /// <summary>
    /// Anguilla
    /// </summary>
    public static readonly Country Ai = new("AI");

    /// <summary>
    /// Albania
    /// </summary>
    public static readonly Country Al = new("AL");

    /// <summary>
    /// Armenia
    /// </summary>
    public static readonly Country Am = new("AM");

    /// <summary>
    /// Angola
    /// </summary>
    public static readonly Country Ao = new("AO");

    /// <summary>
    /// Antartica
    /// </summary>
    public static readonly Country Aq = new("AQ");

    /// <summary>
    /// Argentina
    /// </summary>
    public static readonly Country Ar = new("AR");

    /// <summary>
    /// American Samoa
    /// </summary>
    public static readonly Country As = new("AS");

    /// <summary>
    /// Austria
    /// </summary>
    public static readonly Country At = new("AT");

    /// <summary>
    /// Australia
    /// </summary>
    public static readonly Country Au = new("AU");

    /// <summary>
    /// Aruba
    /// </summary>
    public static readonly Country Aw = new("AW");

    /// <summary>
    /// Åland Islands
    /// </summary>
    public static readonly Country Ax = new("AX");

    /// <summary>
    /// Azerbaijan
    /// </summary>
    public static readonly Country Az = new("AZ");

    /// <summary>
    /// Bosnia and Herzegovina
    /// </summary>
    public static readonly Country Ba = new("BA");

    /// <summary>
    /// Barbados
    /// </summary>
    public static readonly Country Bb = new("BB");

    /// <summary>
    /// Bangladesh
    /// </summary>
    public static readonly Country Bd = new("BD");

    /// <summary>
    /// Belgium
    /// </summary>
    public static readonly Country Be = new("BE");

    /// <summary>
    /// Burkina Faso
    /// </summary>
    public static readonly Country Bf = new("BF");

    /// <summary>
    /// Bulgaria
    /// </summary>
    public static readonly Country Bg = new("BG");

    /// <summary>
    /// Bahrain
    /// </summary>
    public static readonly Country Bh = new("BH");

    /// <summary>
    /// Burundi
    /// </summary>
    public static readonly Country Bi = new("BI");

    /// <summary>
    /// Benin
    /// </summary>
    public static readonly Country Bj = new("BJ");

    /// <summary>
    /// Saint Barthélemy
    /// </summary>
    public static readonly Country Bl = new("BL");

    /// <summary>
    /// Bermuda
    /// </summary>
    public static readonly Country Bm = new("BM");

    /// <summary>
    /// Brunei
    /// </summary>
    public static readonly Country Bn = new("BN");

    /// <summary>
    /// Bolivia
    /// </summary>
    public static readonly Country Bo = new("BO");

    /// <summary>
    /// Bonaire
    /// </summary>
    public static readonly Country Bq = new("BQ");

    /// <summary>
    /// Brazil
    /// </summary>
    public static readonly Country Br = new("BR");

    /// <summary>
    /// Bahamas
    /// </summary>
    public static readonly Country Bs = new("BS");

    /// <summary>
    /// Bhutan
    /// </summary>
    public static readonly Country Bt = new("BT");

    /// <summary>
    /// Bouvet Island
    /// </summary>
    public static readonly Country Bv = new("BV");

    /// <summary>
    /// Botswana
    /// </summary>
    public static readonly Country Bw = new("BW");

    /// <summary>
    /// Belarus
    /// </summary>
    public static readonly Country By = new("BY");

    /// <summary>
    /// Belize
    /// </summary>
    public static readonly Country Bz = new("BZ");

    /// <summary>
    /// Canada
    /// </summary>
    public static readonly Country Ca = new("CA");

    /// <summary>
    /// Cocos Islands
    /// </summary>
    public static readonly Country Cc = new("CC");

    /// <summary>
    /// Democratic Republic of the Congo
    /// </summary>
    public static readonly Country Cd = new("CD");

    /// <summary>
    /// Central African Republic
    /// </summary>
    public static readonly Country Cf = new("CF");

    /// <summary>
    /// Congo
    /// </summary>
    public static readonly Country Cg = new("CG");

    /// <summary>
    /// Switzerland
    /// </summary>
    public static readonly Country Ch = new("CH");

    /// <summary>
    /// Ivory Coast
    /// </summary>
    public static readonly Country Ci = new("CI");

    /// <summary>
    /// Cook Islands
    /// </summary>
    public static readonly Country Ck = new("CK");

    /// <summary>
    /// Chile
    /// </summary>
    public static readonly Country Cl = new("CL");

    /// <summary>
    /// Cameroon
    /// </summary>
    public static readonly Country Cm = new("CM");

    /// <summary>
    /// China
    /// </summary>
    public static readonly Country Cn = new("CN");

    /// <summary>
    /// Colombia
    /// </summary>
    public static readonly Country Co = new("CO");

    /// <summary>
    /// Costa Rica
    /// </summary>
    public static readonly Country Cr = new("CR");

    /// <summary>
    /// Cuba
    /// </summary>
    public static readonly Country Cu = new("CU");

    /// <summary>
    /// Cabo Verde
    /// </summary>
    public static readonly Country Cv = new("CV");

    /// <summary>
    /// Curaçao
    /// </summary>
    public static readonly Country Cw = new("CW");

    /// <summary>
    /// Christmas Island
    /// </summary>
    public static readonly Country Cx = new("CX");

    /// <summary>
    /// Cyprus
    /// </summary>
    public static readonly Country Cy = new("CY");

    /// <summary>
    /// Czechia
    /// </summary>
    public static readonly Country Cz = new("CZ");

    /// <summary>
    /// Germany
    /// </summary>
    public static readonly Country De = new("DE");

    /// <summary>
    /// Djibouti
    /// </summary>
    public static readonly Country Dj = new("DJ");

    /// <summary>
    /// Denmark
    /// </summary>
    public static readonly Country Dk = new("DK");

    /// <summary>
    /// Dominica
    /// </summary>
    public static readonly Country Dm = new("DM");

    /// <summary>
    /// Dominican Republic
    /// </summary>
    public static readonly Country Do = new("DO");

    /// <summary>
    /// Algeria
    /// </summary>
    public static readonly Country Dz = new("DZ");

    /// <summary>
    /// Ecuador
    /// </summary>
    public static readonly Country Ec = new("EC");

    /// <summary>
    /// Estonia
    /// </summary>
    public static readonly Country Ee = new("EE");

    /// <summary>
    /// Egypt
    /// </summary>
    public static readonly Country Eg = new("EG");

    /// <summary>
    /// Western Sahara
    /// </summary>
    public static readonly Country Eh = new("EH");

    /// <summary>
    /// Eritrea
    /// </summary>
    public static readonly Country Er = new("ER");

    /// <summary>
    /// Spain
    /// </summary>
    public static readonly Country Es = new("ES");

    /// <summary>
    /// Ethiopia
    /// </summary>
    public static readonly Country Et = new("ET");

    /// <summary>
    /// Finland
    /// </summary>
    public static readonly Country Fi = new("FI");

    /// <summary>
    /// Fiji
    /// </summary>
    public static readonly Country Fj = new("FJ");

    /// <summary>
    /// Falkland Islands
    /// </summary>
    public static readonly Country Fk = new("FK");

    /// <summary>
    /// Federated States of Micronesia
    /// </summary>
    public static readonly Country Fm = new("FM");

    /// <summary>
    /// Faroe Islands
    /// </summary>
    public static readonly Country Fo = new("FO");

    /// <summary>
    /// France
    /// </summary>
    public static readonly Country Fr = new("FR");

    /// <summary>
    /// Gabon
    /// </summary>
    public static readonly Country Ga = new("GA");

    /// <summary>
    /// United Kingdom
    /// </summary>
    public static readonly Country Gb = new("GB");

    /// <summary>
    /// Grenada
    /// </summary>
    public static readonly Country Gd = new("GD");

    /// <summary>
    /// Georgia
    /// </summary>
    public static readonly Country Ge = new("GE");

    /// <summary>
    /// French Guiana
    /// </summary>
    public static readonly Country Gf = new("GF");

    /// <summary>
    /// Guernsey
    /// </summary>
    public static readonly Country Gg = new("GG");

    /// <summary>
    /// Ghana
    /// </summary>
    public static readonly Country Gh = new("GH");

    /// <summary>
    /// Gibraltar
    /// </summary>
    public static readonly Country Gi = new("GI");

    /// <summary>
    /// Greenland
    /// </summary>
    public static readonly Country Gl = new("GL");

    /// <summary>
    /// Gambia
    /// </summary>
    public static readonly Country Gm = new("GM");

    /// <summary>
    /// Guinea
    /// </summary>
    public static readonly Country Gn = new("GN");

    /// <summary>
    /// Guadeloupe
    /// </summary>
    public static readonly Country Gp = new("GP");

    /// <summary>
    /// Equatorial Guinea
    /// </summary>
    public static readonly Country Gq = new("GQ");

    /// <summary>
    /// Greece
    /// </summary>
    public static readonly Country Gr = new("GR");

    /// <summary>
    /// South Georgia and the South Sandwich Islands
    /// </summary>
    public static readonly Country Gs = new("GS");

    /// <summary>
    /// Guatemala
    /// </summary>
    public static readonly Country Gt = new("GT");

    /// <summary>
    /// Guam
    /// </summary>
    public static readonly Country Gu = new("GU");

    /// <summary>
    /// Guinea-Bissau
    /// </summary>
    public static readonly Country Gw = new("GW");

    /// <summary>
    /// Guyana
    /// </summary>
    public static readonly Country Gy = new("GY");

    /// <summary>
    /// Hong Kong
    /// </summary>
    public static readonly Country Hk = new("HK");

    /// <summary>
    /// Heard Island and McDonald Islands
    /// </summary>
    public static readonly Country Hm = new("HM");

    /// <summary>
    /// Honduras
    /// </summary>
    public static readonly Country Hn = new("HN");

    /// <summary>
    /// Croatia
    /// </summary>
    public static readonly Country Hr = new("HR");

    /// <summary>
    /// Haiti
    /// </summary>
    public static readonly Country Ht = new("HT");

    /// <summary>
    /// Hungary
    /// </summary>
    public static readonly Country Hu = new("HU");

    /// <summary>
    /// Indonesia
    /// </summary>
    public static readonly Country Id = new("ID");

    /// <summary>
    /// Ireland
    /// </summary>
    public static readonly Country Ie = new("IE");

    /// <summary>
    /// Israel
    /// </summary>
    public static readonly Country Il = new("IL");

    /// <summary>
    /// Isle of Man
    /// </summary>
    public static readonly Country Im = new("IM");

    /// <summary>
    /// India
    /// </summary>
    public static readonly Country In = new("IN");

    /// <summary>
    /// British Indian Ocean Territory
    /// </summary>
    public static readonly Country Io = new("IO");

    /// <summary>
    /// Iraq
    /// </summary>
    public static readonly Country Iq = new("IQ");

    /// <summary>
    /// Iran
    /// </summary>
    public static readonly Country Ir = new("IR");

    /// <summary>
    /// Iceland
    /// </summary>
    public static readonly Country IsMember = new("IS");

    /// <summary>
    /// Italy
    /// </summary>
    public static readonly Country It = new("IT");

    /// <summary>
    /// Jersey
    /// </summary>
    public static readonly Country Je = new("JE");

    /// <summary>
    /// Jamaica
    /// </summary>
    public static readonly Country Jm = new("JM");

    /// <summary>
    /// Jordan
    /// </summary>
    public static readonly Country Jo = new("JO");

    /// <summary>
    /// Japan
    /// </summary>
    public static readonly Country Jp = new("JP");

    /// <summary>
    /// Kenya
    /// </summary>
    public static readonly Country Ke = new("KE");

    /// <summary>
    /// Kyrgyzstan
    /// </summary>
    public static readonly Country Kg = new("KG");

    /// <summary>
    /// Cambodia
    /// </summary>
    public static readonly Country Kh = new("KH");

    /// <summary>
    /// Kiribati
    /// </summary>
    public static readonly Country Ki = new("KI");

    /// <summary>
    /// Comoros
    /// </summary>
    public static readonly Country Km = new("KM");

    /// <summary>
    /// Saint Kitts and Nevis
    /// </summary>
    public static readonly Country Kn = new("KN");

    /// <summary>
    /// Democratic People's Republic of Korea
    /// </summary>
    public static readonly Country Kp = new("KP");

    /// <summary>
    /// Republic of Korea
    /// </summary>
    public static readonly Country Kr = new("KR");

    /// <summary>
    /// Kuwait
    /// </summary>
    public static readonly Country Kw = new("KW");

    /// <summary>
    /// Cayman Islands
    /// </summary>
    public static readonly Country Ky = new("KY");

    /// <summary>
    /// Kazakhstan
    /// </summary>
    public static readonly Country Kz = new("KZ");

    /// <summary>
    /// Lao People's Democratic Republic
    /// </summary>
    public static readonly Country La = new("LA");

    /// <summary>
    /// Lebanon
    /// </summary>
    public static readonly Country Lb = new("LB");

    /// <summary>
    /// Saint Lucia
    /// </summary>
    public static readonly Country Lc = new("LC");

    /// <summary>
    /// Liechtenstein
    /// </summary>
    public static readonly Country Li = new("LI");

    /// <summary>
    /// Sri Lanka
    /// </summary>
    public static readonly Country Lk = new("LK");

    /// <summary>
    /// Liberia
    /// </summary>
    public static readonly Country Lr = new("LR");

    /// <summary>
    /// Lesotho
    /// </summary>
    public static readonly Country Ls = new("LS");

    /// <summary>
    /// Lithuania
    /// </summary>
    public static readonly Country Lt = new("LT");

    /// <summary>
    /// Luxembourg
    /// </summary>
    public static readonly Country Lu = new("LU");

    /// <summary>
    /// Latvia
    /// </summary>
    public static readonly Country Lv = new("LV");

    /// <summary>
    /// Libya
    /// </summary>
    public static readonly Country Ly = new("LY");

    /// <summary>
    /// Morocco
    /// </summary>
    public static readonly Country Ma = new("MA");

    /// <summary>
    /// Monaco
    /// </summary>
    public static readonly Country Mc = new("MC");

    /// <summary>
    /// Moldova
    /// </summary>
    public static readonly Country Md = new("MD");

    /// <summary>
    /// Montenegro
    /// </summary>
    public static readonly Country Me = new("ME");

    /// <summary>
    /// Saint Martin
    /// </summary>
    public static readonly Country Mf = new("MF");

    /// <summary>
    /// Madagascar
    /// </summary>
    public static readonly Country Mg = new("MG");

    /// <summary>
    /// Marshall Islands
    /// </summary>
    public static readonly Country Mh = new("MH");

    /// <summary>
    /// North Macedonia
    /// </summary>
    public static readonly Country Mk = new("MK");

    /// <summary>
    /// Mali
    /// </summary>
    public static readonly Country Ml = new("ML");

    /// <summary>
    /// Myanmar
    /// </summary>
    public static readonly Country Mm = new("MM");

    /// <summary>
    /// Mongolia
    /// </summary>
    public static readonly Country Mn = new("MN");

    /// <summary>
    /// Macao
    /// </summary>
    public static readonly Country Mo = new("MO");

    /// <summary>
    /// Northern Mariana Islands
    /// </summary>
    public static readonly Country Mp = new("MP");

    /// <summary>
    /// Martinique
    /// </summary>
    public static readonly Country Mq = new("MQ");

    /// <summary>
    /// Mauritania
    /// </summary>
    public static readonly Country Mr = new("MR");

    /// <summary>
    /// Montserrat
    /// </summary>
    public static readonly Country Ms = new("MS");

    /// <summary>
    /// Malta
    /// </summary>
    public static readonly Country Mt = new("MT");

    /// <summary>
    /// Mauritius
    /// </summary>
    public static readonly Country Mu = new("MU");

    /// <summary>
    /// Maldives
    /// </summary>
    public static readonly Country Mv = new("MV");

    /// <summary>
    /// Malawi
    /// </summary>
    public static readonly Country Mw = new("MW");

    /// <summary>
    /// Mexico
    /// </summary>
    public static readonly Country Mx = new("MX");

    /// <summary>
    /// Malaysia
    /// </summary>
    public static readonly Country My = new("MY");

    /// <summary>
    /// Mozambique
    /// </summary>
    public static readonly Country Mz = new("MZ");

    /// <summary>
    /// Namibia
    /// </summary>
    public static readonly Country Na = new("NA");

    /// <summary>
    /// New Caledonia
    /// </summary>
    public static readonly Country Nc = new("NC");

    /// <summary>
    /// Niger
    /// </summary>
    public static readonly Country Ne = new("NE");

    /// <summary>
    /// Norfolk Island
    /// </summary>
    public static readonly Country Nf = new("NF");

    /// <summary>
    /// Nigeria
    /// </summary>
    public static readonly Country Ng = new("NG");

    /// <summary>
    /// Nicaragua
    /// </summary>
    public static readonly Country Ni = new("NI");

    /// <summary>
    /// Netherlands
    /// </summary>
    public static readonly Country Nl = new("NL");

    /// <summary>
    /// Norway
    /// </summary>
    public static readonly Country No = new("NO");

    /// <summary>
    /// Nepal
    /// </summary>
    public static readonly Country Np = new("NP");

    /// <summary>
    /// Nauru
    /// </summary>
    public static readonly Country Nr = new("NR");

    /// <summary>
    /// Niue
    /// </summary>
    public static readonly Country Nu = new("NU");

    /// <summary>
    /// New Zealand
    /// </summary>
    public static readonly Country Nz = new("NZ");

    /// <summary>
    /// Oman
    /// </summary>
    public static readonly Country Om = new("OM");

    /// <summary>
    /// Panama
    /// </summary>
    public static readonly Country Pa = new("PA");

    /// <summary>
    /// Peru
    /// </summary>
    public static readonly Country Pe = new("PE");

    /// <summary>
    /// French Polynesia
    /// </summary>
    public static readonly Country Pf = new("PF");

    /// <summary>
    /// Papua New Guinea
    /// </summary>
    public static readonly Country Pg = new("PG");

    /// <summary>
    /// Philippines
    /// </summary>
    public static readonly Country Ph = new("PH");

    /// <summary>
    /// Pakistan
    /// </summary>
    public static readonly Country Pk = new("PK");

    /// <summary>
    /// Poland
    /// </summary>
    public static readonly Country Pl = new("PL");

    /// <summary>
    /// Saint Pierre and Miquelon
    /// </summary>
    public static readonly Country Pm = new("PM");

    /// <summary>
    /// Pitcairn
    /// </summary>
    public static readonly Country Pn = new("PN");

    /// <summary>
    /// Puerto Rico
    /// </summary>
    public static readonly Country Pr = new("PR");

    /// <summary>
    /// Palestine
    /// </summary>
    public static readonly Country Ps = new("PS");

    /// <summary>
    /// Portugal
    /// </summary>
    public static readonly Country Pt = new("PT");

    /// <summary>
    /// Palau
    /// </summary>
    public static readonly Country Pw = new("PW");

    /// <summary>
    /// Paraguay
    /// </summary>
    public static readonly Country Py = new("PY");

    /// <summary>
    /// Qatar
    /// </summary>
    public static readonly Country Qa = new("QA");

    /// <summary>
    /// Réunion
    /// </summary>
    public static readonly Country Re = new("RE");

    /// <summary>
    /// Romania
    /// </summary>
    public static readonly Country Ro = new("RO");

    /// <summary>
    /// Serbia
    /// </summary>
    public static readonly Country Rs = new("RS");

    /// <summary>
    /// Russia
    /// </summary>
    public static readonly Country Ru = new("RU");

    /// <summary>
    /// Rwanda
    /// </summary>
    public static readonly Country Rw = new("RW");

    /// <summary>
    /// Saudi Arabia
    /// </summary>
    public static readonly Country Sa = new("SA");

    /// <summary>
    /// Solomon Islands
    /// </summary>
    public static readonly Country Sb = new("SB");

    /// <summary>
    /// Seychelles
    /// </summary>
    public static readonly Country Sc = new("SC");

    /// <summary>
    /// Sudan
    /// </summary>
    public static readonly Country Sd = new("SD");

    /// <summary>
    /// Sweden
    /// </summary>
    public static readonly Country Se = new("SE");

    /// <summary>
    /// Singapore
    /// </summary>
    public static readonly Country Sg = new("SG");

    /// <summary>
    /// Saint Helena, Ascension and Tristan da Cunha
    /// </summary>
    public static readonly Country Sh = new("SH");

    /// <summary>
    /// Slovenia
    /// </summary>
    public static readonly Country Si = new("SI");

    /// <summary>
    /// Svalbard and Jan Mayen
    /// </summary>
    public static readonly Country Sj = new("SJ");

    /// <summary>
    /// Slovakia
    /// </summary>
    public static readonly Country Sk = new("SK");

    /// <summary>
    /// Sierra Leone
    /// </summary>
    public static readonly Country Sl = new("SL");

    /// <summary>
    /// San Marino
    /// </summary>
    public static readonly Country Sm = new("SM");

    /// <summary>
    /// Senegal
    /// </summary>
    public static readonly Country Sn = new("SN");

    /// <summary>
    /// Somalia
    /// </summary>
    public static readonly Country So = new("SO");

    /// <summary>
    /// Suriname
    /// </summary>
    public static readonly Country Sr = new("SR");

    /// <summary>
    /// South Sudan
    /// </summary>
    public static readonly Country Ss = new("SS");

    /// <summary>
    /// Sao Tome and Principe
    /// </summary>
    public static readonly Country St = new("ST");

    /// <summary>
    /// El Salvador
    /// </summary>
    public static readonly Country Sv = new("SV");

    /// <summary>
    /// Sint Maarten
    /// </summary>
    public static readonly Country Sx = new("SX");

    /// <summary>
    /// Syrian Arab Republic
    /// </summary>
    public static readonly Country Sy = new("SY");

    /// <summary>
    /// Eswatini
    /// </summary>
    public static readonly Country Sz = new("SZ");

    /// <summary>
    /// Turks and Caicos Islands
    /// </summary>
    public static readonly Country Tc = new("TC");

    /// <summary>
    /// Chad
    /// </summary>
    public static readonly Country Td = new("TD");

    /// <summary>
    /// French Southern Territories
    /// </summary>
    public static readonly Country Tf = new("TF");

    /// <summary>
    /// Togo
    /// </summary>
    public static readonly Country Tg = new("TG");

    /// <summary>
    /// Thailand
    /// </summary>
    public static readonly Country Th = new("TH");

    /// <summary>
    /// Tajikistan
    /// </summary>
    public static readonly Country Tj = new("TJ");

    /// <summary>
    /// Tokelau
    /// </summary>
    public static readonly Country Tk = new("TK");

    /// <summary>
    /// Timor-Leste
    /// </summary>
    public static readonly Country Tl = new("TL");

    /// <summary>
    /// Turkmenistan
    /// </summary>
    public static readonly Country Tm = new("TM");

    /// <summary>
    /// Tunisia
    /// </summary>
    public static readonly Country Tn = new("TN");

    /// <summary>
    /// Tonga
    /// </summary>
    public static readonly Country To = new("TO");

    /// <summary>
    /// Turkey
    /// </summary>
    public static readonly Country Tr = new("TR");

    /// <summary>
    /// Trinidad and Tobago
    /// </summary>
    public static readonly Country Tt = new("TT");

    /// <summary>
    /// Tuvalu
    /// </summary>
    public static readonly Country Tv = new("TV");

    /// <summary>
    /// Taiwan
    /// </summary>
    public static readonly Country Tw = new("TW");

    /// <summary>
    /// Tanzania
    /// </summary>
    public static readonly Country Tz = new("TZ");

    /// <summary>
    /// Ukraine
    /// </summary>
    public static readonly Country Ua = new("UA");

    /// <summary>
    /// Uganda
    /// </summary>
    public static readonly Country Ug = new("UG");

    /// <summary>
    /// United States Minor Outlying Islands
    /// </summary>
    public static readonly Country Um = new("UM");

    /// <summary>
    /// United States of America
    /// </summary>
    public static readonly Country Us = new("US");

    /// <summary>
    /// Uruguay
    /// </summary>
    public static readonly Country Uy = new("UY");

    /// <summary>
    /// Uzbekistan
    /// </summary>
    public static readonly Country Uz = new("UZ");

    /// <summary>
    /// Vatican City
    /// </summary>
    public static readonly Country Va = new("VA");

    /// <summary>
    /// Saint Vincent and the Grenadines
    /// </summary>
    public static readonly Country Vc = new("VC");

    /// <summary>
    /// Venezuela
    /// </summary>
    public static readonly Country Ve = new("VE");

    /// <summary>
    /// British Virgin Islands
    /// </summary>
    public static readonly Country Vg = new("VG");

    /// <summary>
    /// U.S. Virgin Islands
    /// </summary>
    public static readonly Country Vi = new("VI");

    /// <summary>
    /// Vietnam
    /// </summary>
    public static readonly Country Vn = new("VN");

    /// <summary>
    /// Vanuatu
    /// </summary>
    public static readonly Country Vu = new("VU");

    /// <summary>
    /// Wallis and Futuna
    /// </summary>
    public static readonly Country Wf = new("WF");

    /// <summary>
    /// Samoa
    /// </summary>
    public static readonly Country Ws = new("WS");

    /// <summary>
    /// Yemen
    /// </summary>
    public static readonly Country Ye = new("YE");

    /// <summary>
    /// Mayotte
    /// </summary>
    public static readonly Country Yt = new("YT");

    /// <summary>
    /// South Africa
    /// </summary>
    public static readonly Country Za = new("ZA");

    /// <summary>
    /// Zambia
    /// </summary>
    public static readonly Country Zm = new("ZM");

    /// <summary>
    /// Zimbabwe
    /// </summary>
    public static readonly Country Zw = new("ZW");

    public TResult Match<TResult>(Func<TResult> onZz,
        Func<TResult> onAd,
        Func<TResult> onAe,
        Func<TResult> onAf,
        Func<TResult> onAg,
        Func<TResult> onAi,
        Func<TResult> onAl,
        Func<TResult> onAm,
        Func<TResult> onAo,
        Func<TResult> onAq,
        Func<TResult> onAr,
        Func<TResult> onAs,
        Func<TResult> onAt,
        Func<TResult> onAu,
        Func<TResult> onAw,
        Func<TResult> onAx,
        Func<TResult> onAz,
        Func<TResult> onBa,
        Func<TResult> onBb,
        Func<TResult> onBd,
        Func<TResult> onBe,
        Func<TResult> onBf,
        Func<TResult> onBg,
        Func<TResult> onBh,
        Func<TResult> onBi,
        Func<TResult> onBj,
        Func<TResult> onBl,
        Func<TResult> onBm,
        Func<TResult> onBn,
        Func<TResult> onBo,
        Func<TResult> onBq,
        Func<TResult> onBr,
        Func<TResult> onBs,
        Func<TResult> onBt,
        Func<TResult> onBv,
        Func<TResult> onBw,
        Func<TResult> onBy,
        Func<TResult> onBz,
        Func<TResult> onCa,
        Func<TResult> onCc,
        Func<TResult> onCd,
        Func<TResult> onCf,
        Func<TResult> onCg,
        Func<TResult> onCh,
        Func<TResult> onCi,
        Func<TResult> onCk,
        Func<TResult> onCl,
        Func<TResult> onCm,
        Func<TResult> onCn,
        Func<TResult> onCo,
        Func<TResult> onCr,
        Func<TResult> onCu,
        Func<TResult> onCv,
        Func<TResult> onCw,
        Func<TResult> onCx,
        Func<TResult> onCy,
        Func<TResult> onCz,
        Func<TResult> onDe,
        Func<TResult> onDj,
        Func<TResult> onDk,
        Func<TResult> onDm,
        Func<TResult> onDo,
        Func<TResult> onDz,
        Func<TResult> onEc,
        Func<TResult> onEe,
        Func<TResult> onEg,
        Func<TResult> onEh,
        Func<TResult> onEr,
        Func<TResult> onEs,
        Func<TResult> onEt,
        Func<TResult> onFi,
        Func<TResult> onFj,
        Func<TResult> onFk,
        Func<TResult> onFm,
        Func<TResult> onFo,
        Func<TResult> onFr,
        Func<TResult> onGa,
        Func<TResult> onGb,
        Func<TResult> onGd,
        Func<TResult> onGe,
        Func<TResult> onGf,
        Func<TResult> onGg,
        Func<TResult> onGh,
        Func<TResult> onGi,
        Func<TResult> onGl,
        Func<TResult> onGm,
        Func<TResult> onGn,
        Func<TResult> onGp,
        Func<TResult> onGq,
        Func<TResult> onGr,
        Func<TResult> onGs,
        Func<TResult> onGt,
        Func<TResult> onGu,
        Func<TResult> onGw,
        Func<TResult> onGy,
        Func<TResult> onHk,
        Func<TResult> onHm,
        Func<TResult> onHn,
        Func<TResult> onHr,
        Func<TResult> onHt,
        Func<TResult> onHu,
        Func<TResult> onId,
        Func<TResult> onIe,
        Func<TResult> onIl,
        Func<TResult> onIm,
        Func<TResult> onIn,
        Func<TResult> onIo,
        Func<TResult> onIq,
        Func<TResult> onIr,
        Func<TResult> onIsMember,
        Func<TResult> onIt,
        Func<TResult> onJe,
        Func<TResult> onJm,
        Func<TResult> onJo,
        Func<TResult> onJp,
        Func<TResult> onKe,
        Func<TResult> onKg,
        Func<TResult> onKh,
        Func<TResult> onKi,
        Func<TResult> onKm,
        Func<TResult> onKn,
        Func<TResult> onKp,
        Func<TResult> onKr,
        Func<TResult> onKw,
        Func<TResult> onKy,
        Func<TResult> onKz,
        Func<TResult> onLa,
        Func<TResult> onLb,
        Func<TResult> onLc,
        Func<TResult> onLi,
        Func<TResult> onLk,
        Func<TResult> onLr,
        Func<TResult> onLs,
        Func<TResult> onLt,
        Func<TResult> onLu,
        Func<TResult> onLv,
        Func<TResult> onLy,
        Func<TResult> onMa,
        Func<TResult> onMc,
        Func<TResult> onMd,
        Func<TResult> onMe,
        Func<TResult> onMf,
        Func<TResult> onMg,
        Func<TResult> onMh,
        Func<TResult> onMk,
        Func<TResult> onMl,
        Func<TResult> onMm,
        Func<TResult> onMn,
        Func<TResult> onMo,
        Func<TResult> onMp,
        Func<TResult> onMq,
        Func<TResult> onMr,
        Func<TResult> onMs,
        Func<TResult> onMt,
        Func<TResult> onMu,
        Func<TResult> onMv,
        Func<TResult> onMw,
        Func<TResult> onMx,
        Func<TResult> onMy,
        Func<TResult> onMz,
        Func<TResult> onNa,
        Func<TResult> onNc,
        Func<TResult> onNe,
        Func<TResult> onNf,
        Func<TResult> onNg,
        Func<TResult> onNi,
        Func<TResult> onNl,
        Func<TResult> onNo,
        Func<TResult> onNp,
        Func<TResult> onNr,
        Func<TResult> onNu,
        Func<TResult> onNz,
        Func<TResult> onOm,
        Func<TResult> onPa,
        Func<TResult> onPe,
        Func<TResult> onPf,
        Func<TResult> onPg,
        Func<TResult> onPh,
        Func<TResult> onPk,
        Func<TResult> onPl,
        Func<TResult> onPm,
        Func<TResult> onPn,
        Func<TResult> onPr,
        Func<TResult> onPs,
        Func<TResult> onPt,
        Func<TResult> onPw,
        Func<TResult> onPy,
        Func<TResult> onQa,
        Func<TResult> onRe,
        Func<TResult> onRo,
        Func<TResult> onRs,
        Func<TResult> onRu,
        Func<TResult> onRw,
        Func<TResult> onSa,
        Func<TResult> onSb,
        Func<TResult> onSc,
        Func<TResult> onSd,
        Func<TResult> onSe,
        Func<TResult> onSg,
        Func<TResult> onSh,
        Func<TResult> onSi,
        Func<TResult> onSj,
        Func<TResult> onSk,
        Func<TResult> onSl,
        Func<TResult> onSm,
        Func<TResult> onSn,
        Func<TResult> onSo,
        Func<TResult> onSr,
        Func<TResult> onSs,
        Func<TResult> onSt,
        Func<TResult> onSv,
        Func<TResult> onSx,
        Func<TResult> onSy,
        Func<TResult> onSz,
        Func<TResult> onTc,
        Func<TResult> onTd,
        Func<TResult> onTf,
        Func<TResult> onTg,
        Func<TResult> onTh,
        Func<TResult> onTj,
        Func<TResult> onTk,
        Func<TResult> onTl,
        Func<TResult> onTm,
        Func<TResult> onTn,
        Func<TResult> onTo,
        Func<TResult> onTr,
        Func<TResult> onTt,
        Func<TResult> onTv,
        Func<TResult> onTw,
        Func<TResult> onTz,
        Func<TResult> onUa,
        Func<TResult> onUg,
        Func<TResult> onUm,
        Func<TResult> onUs,
        Func<TResult> onUy,
        Func<TResult> onUz,
        Func<TResult> onVa,
        Func<TResult> onVc,
        Func<TResult> onVe,
        Func<TResult> onVg,
        Func<TResult> onVi,
        Func<TResult> onVn,
        Func<TResult> onVu,
        Func<TResult> onWf,
        Func<TResult> onWs,
        Func<TResult> onYe,
        Func<TResult> onYt,
        Func<TResult> onZa,
        Func<TResult> onZm,
        Func<TResult> onZw,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Zz => onZz(),
            _ when this == Ad => onAd(),
            _ when this == Ae => onAe(),
            _ when this == Af => onAf(),
            _ when this == Ag => onAg(),
            _ when this == Ai => onAi(),
            _ when this == Al => onAl(),
            _ when this == Am => onAm(),
            _ when this == Ao => onAo(),
            _ when this == Aq => onAq(),
            _ when this == Ar => onAr(),
            _ when this == As => onAs(),
            _ when this == At => onAt(),
            _ when this == Au => onAu(),
            _ when this == Aw => onAw(),
            _ when this == Ax => onAx(),
            _ when this == Az => onAz(),
            _ when this == Ba => onBa(),
            _ when this == Bb => onBb(),
            _ when this == Bd => onBd(),
            _ when this == Be => onBe(),
            _ when this == Bf => onBf(),
            _ when this == Bg => onBg(),
            _ when this == Bh => onBh(),
            _ when this == Bi => onBi(),
            _ when this == Bj => onBj(),
            _ when this == Bl => onBl(),
            _ when this == Bm => onBm(),
            _ when this == Bn => onBn(),
            _ when this == Bo => onBo(),
            _ when this == Bq => onBq(),
            _ when this == Br => onBr(),
            _ when this == Bs => onBs(),
            _ when this == Bt => onBt(),
            _ when this == Bv => onBv(),
            _ when this == Bw => onBw(),
            _ when this == By => onBy(),
            _ when this == Bz => onBz(),
            _ when this == Ca => onCa(),
            _ when this == Cc => onCc(),
            _ when this == Cd => onCd(),
            _ when this == Cf => onCf(),
            _ when this == Cg => onCg(),
            _ when this == Ch => onCh(),
            _ when this == Ci => onCi(),
            _ when this == Ck => onCk(),
            _ when this == Cl => onCl(),
            _ when this == Cm => onCm(),
            _ when this == Cn => onCn(),
            _ when this == Co => onCo(),
            _ when this == Cr => onCr(),
            _ when this == Cu => onCu(),
            _ when this == Cv => onCv(),
            _ when this == Cw => onCw(),
            _ when this == Cx => onCx(),
            _ when this == Cy => onCy(),
            _ when this == Cz => onCz(),
            _ when this == De => onDe(),
            _ when this == Dj => onDj(),
            _ when this == Dk => onDk(),
            _ when this == Dm => onDm(),
            _ when this == Do => onDo(),
            _ when this == Dz => onDz(),
            _ when this == Ec => onEc(),
            _ when this == Ee => onEe(),
            _ when this == Eg => onEg(),
            _ when this == Eh => onEh(),
            _ when this == Er => onEr(),
            _ when this == Es => onEs(),
            _ when this == Et => onEt(),
            _ when this == Fi => onFi(),
            _ when this == Fj => onFj(),
            _ when this == Fk => onFk(),
            _ when this == Fm => onFm(),
            _ when this == Fo => onFo(),
            _ when this == Fr => onFr(),
            _ when this == Ga => onGa(),
            _ when this == Gb => onGb(),
            _ when this == Gd => onGd(),
            _ when this == Ge => onGe(),
            _ when this == Gf => onGf(),
            _ when this == Gg => onGg(),
            _ when this == Gh => onGh(),
            _ when this == Gi => onGi(),
            _ when this == Gl => onGl(),
            _ when this == Gm => onGm(),
            _ when this == Gn => onGn(),
            _ when this == Gp => onGp(),
            _ when this == Gq => onGq(),
            _ when this == Gr => onGr(),
            _ when this == Gs => onGs(),
            _ when this == Gt => onGt(),
            _ when this == Gu => onGu(),
            _ when this == Gw => onGw(),
            _ when this == Gy => onGy(),
            _ when this == Hk => onHk(),
            _ when this == Hm => onHm(),
            _ when this == Hn => onHn(),
            _ when this == Hr => onHr(),
            _ when this == Ht => onHt(),
            _ when this == Hu => onHu(),
            _ when this == Id => onId(),
            _ when this == Ie => onIe(),
            _ when this == Il => onIl(),
            _ when this == Im => onIm(),
            _ when this == In => onIn(),
            _ when this == Io => onIo(),
            _ when this == Iq => onIq(),
            _ when this == Ir => onIr(),
            _ when this == IsMember => onIsMember(),
            _ when this == It => onIt(),
            _ when this == Je => onJe(),
            _ when this == Jm => onJm(),
            _ when this == Jo => onJo(),
            _ when this == Jp => onJp(),
            _ when this == Ke => onKe(),
            _ when this == Kg => onKg(),
            _ when this == Kh => onKh(),
            _ when this == Ki => onKi(),
            _ when this == Km => onKm(),
            _ when this == Kn => onKn(),
            _ when this == Kp => onKp(),
            _ when this == Kr => onKr(),
            _ when this == Kw => onKw(),
            _ when this == Ky => onKy(),
            _ when this == Kz => onKz(),
            _ when this == La => onLa(),
            _ when this == Lb => onLb(),
            _ when this == Lc => onLc(),
            _ when this == Li => onLi(),
            _ when this == Lk => onLk(),
            _ when this == Lr => onLr(),
            _ when this == Ls => onLs(),
            _ when this == Lt => onLt(),
            _ when this == Lu => onLu(),
            _ when this == Lv => onLv(),
            _ when this == Ly => onLy(),
            _ when this == Ma => onMa(),
            _ when this == Mc => onMc(),
            _ when this == Md => onMd(),
            _ when this == Me => onMe(),
            _ when this == Mf => onMf(),
            _ when this == Mg => onMg(),
            _ when this == Mh => onMh(),
            _ when this == Mk => onMk(),
            _ when this == Ml => onMl(),
            _ when this == Mm => onMm(),
            _ when this == Mn => onMn(),
            _ when this == Mo => onMo(),
            _ when this == Mp => onMp(),
            _ when this == Mq => onMq(),
            _ when this == Mr => onMr(),
            _ when this == Ms => onMs(),
            _ when this == Mt => onMt(),
            _ when this == Mu => onMu(),
            _ when this == Mv => onMv(),
            _ when this == Mw => onMw(),
            _ when this == Mx => onMx(),
            _ when this == My => onMy(),
            _ when this == Mz => onMz(),
            _ when this == Na => onNa(),
            _ when this == Nc => onNc(),
            _ when this == Ne => onNe(),
            _ when this == Nf => onNf(),
            _ when this == Ng => onNg(),
            _ when this == Ni => onNi(),
            _ when this == Nl => onNl(),
            _ when this == No => onNo(),
            _ when this == Np => onNp(),
            _ when this == Nr => onNr(),
            _ when this == Nu => onNu(),
            _ when this == Nz => onNz(),
            _ when this == Om => onOm(),
            _ when this == Pa => onPa(),
            _ when this == Pe => onPe(),
            _ when this == Pf => onPf(),
            _ when this == Pg => onPg(),
            _ when this == Ph => onPh(),
            _ when this == Pk => onPk(),
            _ when this == Pl => onPl(),
            _ when this == Pm => onPm(),
            _ when this == Pn => onPn(),
            _ when this == Pr => onPr(),
            _ when this == Ps => onPs(),
            _ when this == Pt => onPt(),
            _ when this == Pw => onPw(),
            _ when this == Py => onPy(),
            _ when this == Qa => onQa(),
            _ when this == Re => onRe(),
            _ when this == Ro => onRo(),
            _ when this == Rs => onRs(),
            _ when this == Ru => onRu(),
            _ when this == Rw => onRw(),
            _ when this == Sa => onSa(),
            _ when this == Sb => onSb(),
            _ when this == Sc => onSc(),
            _ when this == Sd => onSd(),
            _ when this == Se => onSe(),
            _ when this == Sg => onSg(),
            _ when this == Sh => onSh(),
            _ when this == Si => onSi(),
            _ when this == Sj => onSj(),
            _ when this == Sk => onSk(),
            _ when this == Sl => onSl(),
            _ when this == Sm => onSm(),
            _ when this == Sn => onSn(),
            _ when this == So => onSo(),
            _ when this == Sr => onSr(),
            _ when this == Ss => onSs(),
            _ when this == St => onSt(),
            _ when this == Sv => onSv(),
            _ when this == Sx => onSx(),
            _ when this == Sy => onSy(),
            _ when this == Sz => onSz(),
            _ when this == Tc => onTc(),
            _ when this == Td => onTd(),
            _ when this == Tf => onTf(),
            _ when this == Tg => onTg(),
            _ when this == Th => onTh(),
            _ when this == Tj => onTj(),
            _ when this == Tk => onTk(),
            _ when this == Tl => onTl(),
            _ when this == Tm => onTm(),
            _ when this == Tn => onTn(),
            _ when this == To => onTo(),
            _ when this == Tr => onTr(),
            _ when this == Tt => onTt(),
            _ when this == Tv => onTv(),
            _ when this == Tw => onTw(),
            _ when this == Tz => onTz(),
            _ when this == Ua => onUa(),
            _ when this == Ug => onUg(),
            _ when this == Um => onUm(),
            _ when this == Us => onUs(),
            _ when this == Uy => onUy(),
            _ when this == Uz => onUz(),
            _ when this == Va => onVa(),
            _ when this == Vc => onVc(),
            _ when this == Ve => onVe(),
            _ when this == Vg => onVg(),
            _ when this == Vi => onVi(),
            _ when this == Vn => onVn(),
            _ when this == Vu => onVu(),
            _ when this == Wf => onWf(),
            _ when this == Ws => onWs(),
            _ when this == Ye => onYe(),
            _ when this == Yt => onYt(),
            _ when this == Za => onZa(),
            _ when this == Zm => onZm(),
            _ when this == Zw => onZw(),
            _ => otherwise(Value)
        };

    public void Match(Action onZz,
        Action onAd,
        Action onAe,
        Action onAf,
        Action onAg,
        Action onAi,
        Action onAl,
        Action onAm,
        Action onAo,
        Action onAq,
        Action onAr,
        Action onAs,
        Action onAt,
        Action onAu,
        Action onAw,
        Action onAx,
        Action onAz,
        Action onBa,
        Action onBb,
        Action onBd,
        Action onBe,
        Action onBf,
        Action onBg,
        Action onBh,
        Action onBi,
        Action onBj,
        Action onBl,
        Action onBm,
        Action onBn,
        Action onBo,
        Action onBq,
        Action onBr,
        Action onBs,
        Action onBt,
        Action onBv,
        Action onBw,
        Action onBy,
        Action onBz,
        Action onCa,
        Action onCc,
        Action onCd,
        Action onCf,
        Action onCg,
        Action onCh,
        Action onCi,
        Action onCk,
        Action onCl,
        Action onCm,
        Action onCn,
        Action onCo,
        Action onCr,
        Action onCu,
        Action onCv,
        Action onCw,
        Action onCx,
        Action onCy,
        Action onCz,
        Action onDe,
        Action onDj,
        Action onDk,
        Action onDm,
        Action onDo,
        Action onDz,
        Action onEc,
        Action onEe,
        Action onEg,
        Action onEh,
        Action onEr,
        Action onEs,
        Action onEt,
        Action onFi,
        Action onFj,
        Action onFk,
        Action onFm,
        Action onFo,
        Action onFr,
        Action onGa,
        Action onGb,
        Action onGd,
        Action onGe,
        Action onGf,
        Action onGg,
        Action onGh,
        Action onGi,
        Action onGl,
        Action onGm,
        Action onGn,
        Action onGp,
        Action onGq,
        Action onGr,
        Action onGs,
        Action onGt,
        Action onGu,
        Action onGw,
        Action onGy,
        Action onHk,
        Action onHm,
        Action onHn,
        Action onHr,
        Action onHt,
        Action onHu,
        Action onId,
        Action onIe,
        Action onIl,
        Action onIm,
        Action onIn,
        Action onIo,
        Action onIq,
        Action onIr,
        Action onIsMember,
        Action onIt,
        Action onJe,
        Action onJm,
        Action onJo,
        Action onJp,
        Action onKe,
        Action onKg,
        Action onKh,
        Action onKi,
        Action onKm,
        Action onKn,
        Action onKp,
        Action onKr,
        Action onKw,
        Action onKy,
        Action onKz,
        Action onLa,
        Action onLb,
        Action onLc,
        Action onLi,
        Action onLk,
        Action onLr,
        Action onLs,
        Action onLt,
        Action onLu,
        Action onLv,
        Action onLy,
        Action onMa,
        Action onMc,
        Action onMd,
        Action onMe,
        Action onMf,
        Action onMg,
        Action onMh,
        Action onMk,
        Action onMl,
        Action onMm,
        Action onMn,
        Action onMo,
        Action onMp,
        Action onMq,
        Action onMr,
        Action onMs,
        Action onMt,
        Action onMu,
        Action onMv,
        Action onMw,
        Action onMx,
        Action onMy,
        Action onMz,
        Action onNa,
        Action onNc,
        Action onNe,
        Action onNf,
        Action onNg,
        Action onNi,
        Action onNl,
        Action onNo,
        Action onNp,
        Action onNr,
        Action onNu,
        Action onNz,
        Action onOm,
        Action onPa,
        Action onPe,
        Action onPf,
        Action onPg,
        Action onPh,
        Action onPk,
        Action onPl,
        Action onPm,
        Action onPn,
        Action onPr,
        Action onPs,
        Action onPt,
        Action onPw,
        Action onPy,
        Action onQa,
        Action onRe,
        Action onRo,
        Action onRs,
        Action onRu,
        Action onRw,
        Action onSa,
        Action onSb,
        Action onSc,
        Action onSd,
        Action onSe,
        Action onSg,
        Action onSh,
        Action onSi,
        Action onSj,
        Action onSk,
        Action onSl,
        Action onSm,
        Action onSn,
        Action onSo,
        Action onSr,
        Action onSs,
        Action onSt,
        Action onSv,
        Action onSx,
        Action onSy,
        Action onSz,
        Action onTc,
        Action onTd,
        Action onTf,
        Action onTg,
        Action onTh,
        Action onTj,
        Action onTk,
        Action onTl,
        Action onTm,
        Action onTn,
        Action onTo,
        Action onTr,
        Action onTt,
        Action onTv,
        Action onTw,
        Action onTz,
        Action onUa,
        Action onUg,
        Action onUm,
        Action onUs,
        Action onUy,
        Action onUz,
        Action onVa,
        Action onVc,
        Action onVe,
        Action onVg,
        Action onVi,
        Action onVn,
        Action onVu,
        Action onWf,
        Action onWs,
        Action onYe,
        Action onYt,
        Action onZa,
        Action onZm,
        Action onZw,
        Action<string> otherwise)
    {
        if (this == Zz) onZz();
        else if (this == Ad) onAd();
        else if (this == Ae) onAe();
        else if (this == Af) onAf();
        else if (this == Ag) onAg();
        else if (this == Ai) onAi();
        else if (this == Al) onAl();
        else if (this == Am) onAm();
        else if (this == Ao) onAo();
        else if (this == Aq) onAq();
        else if (this == Ar) onAr();
        else if (this == As) onAs();
        else if (this == At) onAt();
        else if (this == Au) onAu();
        else if (this == Aw) onAw();
        else if (this == Ax) onAx();
        else if (this == Az) onAz();
        else if (this == Ba) onBa();
        else if (this == Bb) onBb();
        else if (this == Bd) onBd();
        else if (this == Be) onBe();
        else if (this == Bf) onBf();
        else if (this == Bg) onBg();
        else if (this == Bh) onBh();
        else if (this == Bi) onBi();
        else if (this == Bj) onBj();
        else if (this == Bl) onBl();
        else if (this == Bm) onBm();
        else if (this == Bn) onBn();
        else if (this == Bo) onBo();
        else if (this == Bq) onBq();
        else if (this == Br) onBr();
        else if (this == Bs) onBs();
        else if (this == Bt) onBt();
        else if (this == Bv) onBv();
        else if (this == Bw) onBw();
        else if (this == By) onBy();
        else if (this == Bz) onBz();
        else if (this == Ca) onCa();
        else if (this == Cc) onCc();
        else if (this == Cd) onCd();
        else if (this == Cf) onCf();
        else if (this == Cg) onCg();
        else if (this == Ch) onCh();
        else if (this == Ci) onCi();
        else if (this == Ck) onCk();
        else if (this == Cl) onCl();
        else if (this == Cm) onCm();
        else if (this == Cn) onCn();
        else if (this == Co) onCo();
        else if (this == Cr) onCr();
        else if (this == Cu) onCu();
        else if (this == Cv) onCv();
        else if (this == Cw) onCw();
        else if (this == Cx) onCx();
        else if (this == Cy) onCy();
        else if (this == Cz) onCz();
        else if (this == De) onDe();
        else if (this == Dj) onDj();
        else if (this == Dk) onDk();
        else if (this == Dm) onDm();
        else if (this == Do) onDo();
        else if (this == Dz) onDz();
        else if (this == Ec) onEc();
        else if (this == Ee) onEe();
        else if (this == Eg) onEg();
        else if (this == Eh) onEh();
        else if (this == Er) onEr();
        else if (this == Es) onEs();
        else if (this == Et) onEt();
        else if (this == Fi) onFi();
        else if (this == Fj) onFj();
        else if (this == Fk) onFk();
        else if (this == Fm) onFm();
        else if (this == Fo) onFo();
        else if (this == Fr) onFr();
        else if (this == Ga) onGa();
        else if (this == Gb) onGb();
        else if (this == Gd) onGd();
        else if (this == Ge) onGe();
        else if (this == Gf) onGf();
        else if (this == Gg) onGg();
        else if (this == Gh) onGh();
        else if (this == Gi) onGi();
        else if (this == Gl) onGl();
        else if (this == Gm) onGm();
        else if (this == Gn) onGn();
        else if (this == Gp) onGp();
        else if (this == Gq) onGq();
        else if (this == Gr) onGr();
        else if (this == Gs) onGs();
        else if (this == Gt) onGt();
        else if (this == Gu) onGu();
        else if (this == Gw) onGw();
        else if (this == Gy) onGy();
        else if (this == Hk) onHk();
        else if (this == Hm) onHm();
        else if (this == Hn) onHn();
        else if (this == Hr) onHr();
        else if (this == Ht) onHt();
        else if (this == Hu) onHu();
        else if (this == Id) onId();
        else if (this == Ie) onIe();
        else if (this == Il) onIl();
        else if (this == Im) onIm();
        else if (this == In) onIn();
        else if (this == Io) onIo();
        else if (this == Iq) onIq();
        else if (this == Ir) onIr();
        else if (this == IsMember) onIsMember();
        else if (this == It) onIt();
        else if (this == Je) onJe();
        else if (this == Jm) onJm();
        else if (this == Jo) onJo();
        else if (this == Jp) onJp();
        else if (this == Ke) onKe();
        else if (this == Kg) onKg();
        else if (this == Kh) onKh();
        else if (this == Ki) onKi();
        else if (this == Km) onKm();
        else if (this == Kn) onKn();
        else if (this == Kp) onKp();
        else if (this == Kr) onKr();
        else if (this == Kw) onKw();
        else if (this == Ky) onKy();
        else if (this == Kz) onKz();
        else if (this == La) onLa();
        else if (this == Lb) onLb();
        else if (this == Lc) onLc();
        else if (this == Li) onLi();
        else if (this == Lk) onLk();
        else if (this == Lr) onLr();
        else if (this == Ls) onLs();
        else if (this == Lt) onLt();
        else if (this == Lu) onLu();
        else if (this == Lv) onLv();
        else if (this == Ly) onLy();
        else if (this == Ma) onMa();
        else if (this == Mc) onMc();
        else if (this == Md) onMd();
        else if (this == Me) onMe();
        else if (this == Mf) onMf();
        else if (this == Mg) onMg();
        else if (this == Mh) onMh();
        else if (this == Mk) onMk();
        else if (this == Ml) onMl();
        else if (this == Mm) onMm();
        else if (this == Mn) onMn();
        else if (this == Mo) onMo();
        else if (this == Mp) onMp();
        else if (this == Mq) onMq();
        else if (this == Mr) onMr();
        else if (this == Ms) onMs();
        else if (this == Mt) onMt();
        else if (this == Mu) onMu();
        else if (this == Mv) onMv();
        else if (this == Mw) onMw();
        else if (this == Mx) onMx();
        else if (this == My) onMy();
        else if (this == Mz) onMz();
        else if (this == Na) onNa();
        else if (this == Nc) onNc();
        else if (this == Ne) onNe();
        else if (this == Nf) onNf();
        else if (this == Ng) onNg();
        else if (this == Ni) onNi();
        else if (this == Nl) onNl();
        else if (this == No) onNo();
        else if (this == Np) onNp();
        else if (this == Nr) onNr();
        else if (this == Nu) onNu();
        else if (this == Nz) onNz();
        else if (this == Om) onOm();
        else if (this == Pa) onPa();
        else if (this == Pe) onPe();
        else if (this == Pf) onPf();
        else if (this == Pg) onPg();
        else if (this == Ph) onPh();
        else if (this == Pk) onPk();
        else if (this == Pl) onPl();
        else if (this == Pm) onPm();
        else if (this == Pn) onPn();
        else if (this == Pr) onPr();
        else if (this == Ps) onPs();
        else if (this == Pt) onPt();
        else if (this == Pw) onPw();
        else if (this == Py) onPy();
        else if (this == Qa) onQa();
        else if (this == Re) onRe();
        else if (this == Ro) onRo();
        else if (this == Rs) onRs();
        else if (this == Ru) onRu();
        else if (this == Rw) onRw();
        else if (this == Sa) onSa();
        else if (this == Sb) onSb();
        else if (this == Sc) onSc();
        else if (this == Sd) onSd();
        else if (this == Se) onSe();
        else if (this == Sg) onSg();
        else if (this == Sh) onSh();
        else if (this == Si) onSi();
        else if (this == Sj) onSj();
        else if (this == Sk) onSk();
        else if (this == Sl) onSl();
        else if (this == Sm) onSm();
        else if (this == Sn) onSn();
        else if (this == So) onSo();
        else if (this == Sr) onSr();
        else if (this == Ss) onSs();
        else if (this == St) onSt();
        else if (this == Sv) onSv();
        else if (this == Sx) onSx();
        else if (this == Sy) onSy();
        else if (this == Sz) onSz();
        else if (this == Tc) onTc();
        else if (this == Td) onTd();
        else if (this == Tf) onTf();
        else if (this == Tg) onTg();
        else if (this == Th) onTh();
        else if (this == Tj) onTj();
        else if (this == Tk) onTk();
        else if (this == Tl) onTl();
        else if (this == Tm) onTm();
        else if (this == Tn) onTn();
        else if (this == To) onTo();
        else if (this == Tr) onTr();
        else if (this == Tt) onTt();
        else if (this == Tv) onTv();
        else if (this == Tw) onTw();
        else if (this == Tz) onTz();
        else if (this == Ua) onUa();
        else if (this == Ug) onUg();
        else if (this == Um) onUm();
        else if (this == Us) onUs();
        else if (this == Uy) onUy();
        else if (this == Uz) onUz();
        else if (this == Va) onVa();
        else if (this == Vc) onVc();
        else if (this == Ve) onVe();
        else if (this == Vg) onVg();
        else if (this == Vi) onVi();
        else if (this == Vn) onVn();
        else if (this == Vu) onVu();
        else if (this == Wf) onWf();
        else if (this == Ws) onWs();
        else if (this == Ye) onYe();
        else if (this == Yt) onYt();
        else if (this == Za) onZa();
        else if (this == Zm) onZm();
        else if (this == Zw) onZw();
        else otherwise(Value);
    }
}
