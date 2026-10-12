using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the associated currency for an amount of money. Values correspond
/// to <see href="https://wikipedia.org/wiki/ISO_4217">ISO 4217</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Currency>))]
public sealed record Currency : OpenStringEnum<Currency>
{
    private Currency(string value) : base(value)
    {
    }

    /// <summary>
    /// Unknown currency
    /// </summary>
    public static readonly Currency UnknownCurrency = new("UNKNOWN_CURRENCY");

    /// <summary>
    /// United Arab Emirates dirham
    /// </summary>
    public static readonly Currency Aed = new("AED");

    /// <summary>
    /// Afghan afghani
    /// </summary>
    public static readonly Currency Afn = new("AFN");

    /// <summary>
    /// Albanian lek
    /// </summary>
    public static readonly Currency All = new("ALL");

    /// <summary>
    /// Armenian dram
    /// </summary>
    public static readonly Currency Amd = new("AMD");

    /// <summary>
    /// Netherlands Antillean guilder
    /// </summary>
    public static readonly Currency Ang = new("ANG");

    /// <summary>
    /// Angolan kwanza
    /// </summary>
    public static readonly Currency Aoa = new("AOA");

    /// <summary>
    /// Argentine peso
    /// </summary>
    public static readonly Currency Ars = new("ARS");

    /// <summary>
    /// Australian dollar
    /// </summary>
    public static readonly Currency Aud = new("AUD");

    /// <summary>
    /// Aruban florin
    /// </summary>
    public static readonly Currency Awg = new("AWG");

    /// <summary>
    /// Azerbaijani manat
    /// </summary>
    public static readonly Currency Azn = new("AZN");

    /// <summary>
    /// Bosnia and Herzegovina convertible mark
    /// </summary>
    public static readonly Currency Bam = new("BAM");

    /// <summary>
    /// Barbados dollar
    /// </summary>
    public static readonly Currency Bbd = new("BBD");

    /// <summary>
    /// Bangladeshi taka
    /// </summary>
    public static readonly Currency Bdt = new("BDT");

    /// <summary>
    /// Bulgarian lev
    /// </summary>
    public static readonly Currency Bgn = new("BGN");

    /// <summary>
    /// Bahraini dinar
    /// </summary>
    public static readonly Currency Bhd = new("BHD");

    /// <summary>
    /// Burundian franc
    /// </summary>
    public static readonly Currency Bif = new("BIF");

    /// <summary>
    /// Bermudian dollar
    /// </summary>
    public static readonly Currency Bmd = new("BMD");

    /// <summary>
    /// Brunei dollar
    /// </summary>
    public static readonly Currency Bnd = new("BND");

    /// <summary>
    /// Boliviano
    /// </summary>
    public static readonly Currency Bob = new("BOB");

    /// <summary>
    /// Bolivian Mvdol
    /// </summary>
    public static readonly Currency Bov = new("BOV");

    /// <summary>
    /// Brazilian real
    /// </summary>
    public static readonly Currency Brl = new("BRL");

    /// <summary>
    /// Bahamian dollar
    /// </summary>
    public static readonly Currency Bsd = new("BSD");

    /// <summary>
    /// Bhutanese ngultrum
    /// </summary>
    public static readonly Currency Btn = new("BTN");

    /// <summary>
    /// Botswana pula
    /// </summary>
    public static readonly Currency Bwp = new("BWP");

    /// <summary>
    /// Belarusian ruble
    /// </summary>
    public static readonly Currency Byr = new("BYR");

    /// <summary>
    /// Belize dollar
    /// </summary>
    public static readonly Currency Bzd = new("BZD");

    /// <summary>
    /// Canadian dollar
    /// </summary>
    public static readonly Currency Cad = new("CAD");

    /// <summary>
    /// Congolese franc
    /// </summary>
    public static readonly Currency Cdf = new("CDF");

    /// <summary>
    /// WIR Euro
    /// </summary>
    public static readonly Currency Che = new("CHE");

    /// <summary>
    /// Swiss franc
    /// </summary>
    public static readonly Currency Chf = new("CHF");

    /// <summary>
    /// WIR Franc
    /// </summary>
    public static readonly Currency Chw = new("CHW");

    /// <summary>
    /// Unidad de Fomento
    /// </summary>
    public static readonly Currency Clf = new("CLF");

    /// <summary>
    /// Chilean peso
    /// </summary>
    public static readonly Currency Clp = new("CLP");

    /// <summary>
    /// Chinese yuan
    /// </summary>
    public static readonly Currency Cny = new("CNY");

    /// <summary>
    /// Colombian peso
    /// </summary>
    public static readonly Currency Cop = new("COP");

    /// <summary>
    /// Unidad de Valor Real
    /// </summary>
    public static readonly Currency Cou = new("COU");

    /// <summary>
    /// Costa Rican colon
    /// </summary>
    public static readonly Currency Crc = new("CRC");

    /// <summary>
    /// Cuban convertible peso
    /// </summary>
    public static readonly Currency Cuc = new("CUC");

    /// <summary>
    /// Cuban peso
    /// </summary>
    public static readonly Currency Cup = new("CUP");

    /// <summary>
    /// Cape Verdean escudo
    /// </summary>
    public static readonly Currency Cve = new("CVE");

    /// <summary>
    /// Czech koruna
    /// </summary>
    public static readonly Currency Czk = new("CZK");

    /// <summary>
    /// Djiboutian franc
    /// </summary>
    public static readonly Currency Djf = new("DJF");

    /// <summary>
    /// Danish krone
    /// </summary>
    public static readonly Currency Dkk = new("DKK");

    /// <summary>
    /// Dominican peso
    /// </summary>
    public static readonly Currency Dop = new("DOP");

    /// <summary>
    /// Algerian dinar
    /// </summary>
    public static readonly Currency Dzd = new("DZD");

    /// <summary>
    /// Egyptian pound
    /// </summary>
    public static readonly Currency Egp = new("EGP");

    /// <summary>
    /// Eritrean nakfa
    /// </summary>
    public static readonly Currency Ern = new("ERN");

    /// <summary>
    /// Ethiopian birr
    /// </summary>
    public static readonly Currency Etb = new("ETB");

    /// <summary>
    /// Euro
    /// </summary>
    public static readonly Currency Eur = new("EUR");

    /// <summary>
    /// Fiji dollar
    /// </summary>
    public static readonly Currency Fjd = new("FJD");

    /// <summary>
    /// Falkland Islands pound
    /// </summary>
    public static readonly Currency Fkp = new("FKP");

    /// <summary>
    /// Pound sterling
    /// </summary>
    public static readonly Currency Gbp = new("GBP");

    /// <summary>
    /// Georgian lari
    /// </summary>
    public static readonly Currency Gel = new("GEL");

    /// <summary>
    /// Ghanaian cedi
    /// </summary>
    public static readonly Currency Ghs = new("GHS");

    /// <summary>
    /// Gibraltar pound
    /// </summary>
    public static readonly Currency Gip = new("GIP");

    /// <summary>
    /// Gambian dalasi
    /// </summary>
    public static readonly Currency Gmd = new("GMD");

    /// <summary>
    /// Guinean franc
    /// </summary>
    public static readonly Currency Gnf = new("GNF");

    /// <summary>
    /// Guatemalan quetzal
    /// </summary>
    public static readonly Currency Gtq = new("GTQ");

    /// <summary>
    /// Guyanese dollar
    /// </summary>
    public static readonly Currency Gyd = new("GYD");

    /// <summary>
    /// Hong Kong dollar
    /// </summary>
    public static readonly Currency Hkd = new("HKD");

    /// <summary>
    /// Honduran lempira
    /// </summary>
    public static readonly Currency Hnl = new("HNL");

    /// <summary>
    /// Croatian kuna
    /// </summary>
    public static readonly Currency Hrk = new("HRK");

    /// <summary>
    /// Haitian gourde
    /// </summary>
    public static readonly Currency Htg = new("HTG");

    /// <summary>
    /// Hungarian forint
    /// </summary>
    public static readonly Currency Huf = new("HUF");

    /// <summary>
    /// Indonesian rupiah
    /// </summary>
    public static readonly Currency Idr = new("IDR");

    /// <summary>
    /// Israeli new shekel
    /// </summary>
    public static readonly Currency Ils = new("ILS");

    /// <summary>
    /// Indian rupee
    /// </summary>
    public static readonly Currency Inr = new("INR");

    /// <summary>
    /// Iraqi dinar
    /// </summary>
    public static readonly Currency Iqd = new("IQD");

    /// <summary>
    /// Iranian rial
    /// </summary>
    public static readonly Currency Irr = new("IRR");

    /// <summary>
    /// Icelandic króna
    /// </summary>
    public static readonly Currency Isk = new("ISK");

    /// <summary>
    /// Jamaican dollar
    /// </summary>
    public static readonly Currency Jmd = new("JMD");

    /// <summary>
    /// Jordanian dinar
    /// </summary>
    public static readonly Currency Jod = new("JOD");

    /// <summary>
    /// Japanese yen
    /// </summary>
    public static readonly Currency Jpy = new("JPY");

    /// <summary>
    /// Kenyan shilling
    /// </summary>
    public static readonly Currency Kes = new("KES");

    /// <summary>
    /// Kyrgyzstani som
    /// </summary>
    public static readonly Currency Kgs = new("KGS");

    /// <summary>
    /// Cambodian riel
    /// </summary>
    public static readonly Currency Khr = new("KHR");

    /// <summary>
    /// Comoro franc
    /// </summary>
    public static readonly Currency Kmf = new("KMF");

    /// <summary>
    /// North Korean won
    /// </summary>
    public static readonly Currency Kpw = new("KPW");

    /// <summary>
    /// South Korean won
    /// </summary>
    public static readonly Currency Krw = new("KRW");

    /// <summary>
    /// Kuwaiti dinar
    /// </summary>
    public static readonly Currency Kwd = new("KWD");

    /// <summary>
    /// Cayman Islands dollar
    /// </summary>
    public static readonly Currency Kyd = new("KYD");

    /// <summary>
    /// Kazakhstani tenge
    /// </summary>
    public static readonly Currency Kzt = new("KZT");

    /// <summary>
    /// Lao kip
    /// </summary>
    public static readonly Currency Lak = new("LAK");

    /// <summary>
    /// Lebanese pound
    /// </summary>
    public static readonly Currency Lbp = new("LBP");

    /// <summary>
    /// Sri Lankan rupee
    /// </summary>
    public static readonly Currency Lkr = new("LKR");

    /// <summary>
    /// Liberian dollar
    /// </summary>
    public static readonly Currency Lrd = new("LRD");

    /// <summary>
    /// Lesotho loti
    /// </summary>
    public static readonly Currency Lsl = new("LSL");

    /// <summary>
    /// Lithuanian litas
    /// </summary>
    public static readonly Currency Ltl = new("LTL");

    /// <summary>
    /// Latvian lats
    /// </summary>
    public static readonly Currency Lvl = new("LVL");

    /// <summary>
    /// Libyan dinar
    /// </summary>
    public static readonly Currency Lyd = new("LYD");

    /// <summary>
    /// Moroccan dirham
    /// </summary>
    public static readonly Currency Mad = new("MAD");

    /// <summary>
    /// Moldovan leu
    /// </summary>
    public static readonly Currency Mdl = new("MDL");

    /// <summary>
    /// Malagasy ariary
    /// </summary>
    public static readonly Currency Mga = new("MGA");

    /// <summary>
    /// Macedonian denar
    /// </summary>
    public static readonly Currency Mkd = new("MKD");

    /// <summary>
    /// Myanmar kyat
    /// </summary>
    public static readonly Currency Mmk = new("MMK");

    /// <summary>
    /// Mongolian tögrög
    /// </summary>
    public static readonly Currency Mnt = new("MNT");

    /// <summary>
    /// Macanese pataca
    /// </summary>
    public static readonly Currency Mop = new("MOP");

    /// <summary>
    /// Mauritanian ouguiya
    /// </summary>
    public static readonly Currency Mro = new("MRO");

    /// <summary>
    /// Mauritian rupee
    /// </summary>
    public static readonly Currency Mur = new("MUR");

    /// <summary>
    /// Maldivian rufiyaa
    /// </summary>
    public static readonly Currency Mvr = new("MVR");

    /// <summary>
    /// Malawian kwacha
    /// </summary>
    public static readonly Currency Mwk = new("MWK");

    /// <summary>
    /// Mexican peso
    /// </summary>
    public static readonly Currency Mxn = new("MXN");

    /// <summary>
    /// Mexican Unidad de Inversion
    /// </summary>
    public static readonly Currency Mxv = new("MXV");

    /// <summary>
    /// Malaysian ringgit
    /// </summary>
    public static readonly Currency Myr = new("MYR");

    /// <summary>
    /// Mozambican metical
    /// </summary>
    public static readonly Currency Mzn = new("MZN");

    /// <summary>
    /// Namibian dollar
    /// </summary>
    public static readonly Currency Nad = new("NAD");

    /// <summary>
    /// Nigerian naira
    /// </summary>
    public static readonly Currency Ngn = new("NGN");

    /// <summary>
    /// Nicaraguan córdoba
    /// </summary>
    public static readonly Currency Nio = new("NIO");

    /// <summary>
    /// Norwegian krone
    /// </summary>
    public static readonly Currency Nok = new("NOK");

    /// <summary>
    /// Nepalese rupee
    /// </summary>
    public static readonly Currency Npr = new("NPR");

    /// <summary>
    /// New Zealand dollar
    /// </summary>
    public static readonly Currency Nzd = new("NZD");

    /// <summary>
    /// Omani rial
    /// </summary>
    public static readonly Currency Omr = new("OMR");

    /// <summary>
    /// Panamanian balboa
    /// </summary>
    public static readonly Currency Pab = new("PAB");

    /// <summary>
    /// Peruvian sol
    /// </summary>
    public static readonly Currency Pen = new("PEN");

    /// <summary>
    /// Papua New Guinean kina
    /// </summary>
    public static readonly Currency Pgk = new("PGK");

    /// <summary>
    /// Philippine peso
    /// </summary>
    public static readonly Currency Php = new("PHP");

    /// <summary>
    /// Pakistani rupee
    /// </summary>
    public static readonly Currency Pkr = new("PKR");

    /// <summary>
    /// Polish złoty
    /// </summary>
    public static readonly Currency Pln = new("PLN");

    /// <summary>
    /// Paraguayan guaraní
    /// </summary>
    public static readonly Currency Pyg = new("PYG");

    /// <summary>
    /// Qatari riyal
    /// </summary>
    public static readonly Currency Qar = new("QAR");

    /// <summary>
    /// Romanian leu
    /// </summary>
    public static readonly Currency Ron = new("RON");

    /// <summary>
    /// Serbian dinar
    /// </summary>
    public static readonly Currency Rsd = new("RSD");

    /// <summary>
    /// Russian ruble
    /// </summary>
    public static readonly Currency Rub = new("RUB");

    /// <summary>
    /// Rwandan franc
    /// </summary>
    public static readonly Currency Rwf = new("RWF");

    /// <summary>
    /// Saudi riyal
    /// </summary>
    public static readonly Currency Sar = new("SAR");

    /// <summary>
    /// Solomon Islands dollar
    /// </summary>
    public static readonly Currency Sbd = new("SBD");

    /// <summary>
    /// Seychelles rupee
    /// </summary>
    public static readonly Currency Scr = new("SCR");

    /// <summary>
    /// Sudanese pound
    /// </summary>
    public static readonly Currency Sdg = new("SDG");

    /// <summary>
    /// Swedish krona
    /// </summary>
    public static readonly Currency Sek = new("SEK");

    /// <summary>
    /// Singapore dollar
    /// </summary>
    public static readonly Currency Sgd = new("SGD");

    /// <summary>
    /// Saint Helena pound
    /// </summary>
    public static readonly Currency Shp = new("SHP");

    /// <summary>
    /// Sierra Leonean first leone
    /// </summary>
    public static readonly Currency Sll = new("SLL");

    /// <summary>
    /// Sierra Leonean second leone
    /// </summary>
    public static readonly Currency Sle = new("SLE");

    /// <summary>
    /// Somali shilling
    /// </summary>
    public static readonly Currency Sos = new("SOS");

    /// <summary>
    /// Surinamese dollar
    /// </summary>
    public static readonly Currency Srd = new("SRD");

    /// <summary>
    /// South Sudanese pound
    /// </summary>
    public static readonly Currency Ssp = new("SSP");

    /// <summary>
    /// São Tomé and Príncipe dobra
    /// </summary>
    public static readonly Currency Std = new("STD");

    /// <summary>
    /// Salvadoran colón
    /// </summary>
    public static readonly Currency Svc = new("SVC");

    /// <summary>
    /// Syrian pound
    /// </summary>
    public static readonly Currency Syp = new("SYP");

    /// <summary>
    /// Swazi lilangeni
    /// </summary>
    public static readonly Currency Szl = new("SZL");

    /// <summary>
    /// Thai baht
    /// </summary>
    public static readonly Currency Thb = new("THB");

    /// <summary>
    /// Tajikstani somoni
    /// </summary>
    public static readonly Currency Tjs = new("TJS");

    /// <summary>
    /// Turkmenistan manat
    /// </summary>
    public static readonly Currency Tmt = new("TMT");

    /// <summary>
    /// Tunisian dinar
    /// </summary>
    public static readonly Currency Tnd = new("TND");

    /// <summary>
    /// Tongan pa'anga
    /// </summary>
    public static readonly Currency Top = new("TOP");

    /// <summary>
    /// Turkish lira
    /// </summary>
    public static readonly Currency Try = new("TRY");

    /// <summary>
    /// Trinidad and Tobago dollar
    /// </summary>
    public static readonly Currency Ttd = new("TTD");

    /// <summary>
    /// New Taiwan dollar
    /// </summary>
    public static readonly Currency Twd = new("TWD");

    /// <summary>
    /// Tanzanian shilling
    /// </summary>
    public static readonly Currency Tzs = new("TZS");

    /// <summary>
    /// Ukrainian hryvnia
    /// </summary>
    public static readonly Currency Uah = new("UAH");

    /// <summary>
    /// Ugandan shilling
    /// </summary>
    public static readonly Currency Ugx = new("UGX");

    /// <summary>
    /// United States dollar
    /// </summary>
    public static readonly Currency Usd = new("USD");

    /// <summary>
    /// United States dollar (next day)
    /// </summary>
    public static readonly Currency Usn = new("USN");

    /// <summary>
    /// United States dollar (same day)
    /// </summary>
    public static readonly Currency Uss = new("USS");

    /// <summary>
    /// Uruguay Peso en Unidedades Indexadas
    /// </summary>
    public static readonly Currency Uyi = new("UYI");

    /// <summary>
    /// Uruguyan peso
    /// </summary>
    public static readonly Currency Uyu = new("UYU");

    /// <summary>
    /// Uzbekistan som
    /// </summary>
    public static readonly Currency Uzs = new("UZS");

    /// <summary>
    /// Venezuelan bolívar soberano
    /// </summary>
    public static readonly Currency Vef = new("VEF");

    /// <summary>
    /// Vietnamese đồng
    /// </summary>
    public static readonly Currency Vnd = new("VND");

    /// <summary>
    /// Vanuatu vatu
    /// </summary>
    public static readonly Currency Vuv = new("VUV");

    /// <summary>
    /// Samoan tala
    /// </summary>
    public static readonly Currency Wst = new("WST");

    /// <summary>
    /// CFA franc BEAC
    /// </summary>
    public static readonly Currency Xaf = new("XAF");

    /// <summary>
    /// Silver
    /// </summary>
    public static readonly Currency Xag = new("XAG");

    /// <summary>
    /// Gold
    /// </summary>
    public static readonly Currency Xau = new("XAU");

    /// <summary>
    /// European Composite Unit
    /// </summary>
    public static readonly Currency Xba = new("XBA");

    /// <summary>
    /// European Monetary Unit
    /// </summary>
    public static readonly Currency Xbb = new("XBB");

    /// <summary>
    /// European Unit of Account 9
    /// </summary>
    public static readonly Currency Xbc = new("XBC");

    /// <summary>
    /// European Unit of Account 17
    /// </summary>
    public static readonly Currency Xbd = new("XBD");

    /// <summary>
    /// East Caribbean dollar
    /// </summary>
    public static readonly Currency Xcd = new("XCD");

    /// <summary>
    /// Special drawing rights (International Monetary Fund)
    /// </summary>
    public static readonly Currency Xdr = new("XDR");

    /// <summary>
    /// CFA franc BCEAO
    /// </summary>
    public static readonly Currency Xof = new("XOF");

    /// <summary>
    /// Palladium
    /// </summary>
    public static readonly Currency Xpd = new("XPD");

    /// <summary>
    /// CFP franc
    /// </summary>
    public static readonly Currency Xpf = new("XPF");

    /// <summary>
    /// Platinum
    /// </summary>
    public static readonly Currency Xpt = new("XPT");

    /// <summary>
    /// Code reserved for testing
    /// </summary>
    public static readonly Currency Xts = new("XTS");

    /// <summary>
    /// No currency
    /// </summary>
    public static readonly Currency Xxx = new("XXX");

    /// <summary>
    /// Yemeni rial
    /// </summary>
    public static readonly Currency Yer = new("YER");

    /// <summary>
    /// South African rand
    /// </summary>
    public static readonly Currency Zar = new("ZAR");

    /// <summary>
    /// Zambian kwacha
    /// </summary>
    public static readonly Currency Zmk = new("ZMK");

    /// <summary>
    /// Zambian kwacha
    /// </summary>
    public static readonly Currency Zmw = new("ZMW");

    /// <summary>
    /// Bitcoin
    /// </summary>
    public static readonly Currency Btc = new("BTC");

    /// <summary>
    /// USD Coin
    /// </summary>
    public static readonly Currency Xus = new("XUS");

    public TResult Match<TResult>(Func<TResult> onUnknownCurrency,
        Func<TResult> onAed,
        Func<TResult> onAfn,
        Func<TResult> onAll,
        Func<TResult> onAmd,
        Func<TResult> onAng,
        Func<TResult> onAoa,
        Func<TResult> onArs,
        Func<TResult> onAud,
        Func<TResult> onAwg,
        Func<TResult> onAzn,
        Func<TResult> onBam,
        Func<TResult> onBbd,
        Func<TResult> onBdt,
        Func<TResult> onBgn,
        Func<TResult> onBhd,
        Func<TResult> onBif,
        Func<TResult> onBmd,
        Func<TResult> onBnd,
        Func<TResult> onBob,
        Func<TResult> onBov,
        Func<TResult> onBrl,
        Func<TResult> onBsd,
        Func<TResult> onBtn,
        Func<TResult> onBwp,
        Func<TResult> onByr,
        Func<TResult> onBzd,
        Func<TResult> onCad,
        Func<TResult> onCdf,
        Func<TResult> onChe,
        Func<TResult> onChf,
        Func<TResult> onChw,
        Func<TResult> onClf,
        Func<TResult> onClp,
        Func<TResult> onCny,
        Func<TResult> onCop,
        Func<TResult> onCou,
        Func<TResult> onCrc,
        Func<TResult> onCuc,
        Func<TResult> onCup,
        Func<TResult> onCve,
        Func<TResult> onCzk,
        Func<TResult> onDjf,
        Func<TResult> onDkk,
        Func<TResult> onDop,
        Func<TResult> onDzd,
        Func<TResult> onEgp,
        Func<TResult> onErn,
        Func<TResult> onEtb,
        Func<TResult> onEur,
        Func<TResult> onFjd,
        Func<TResult> onFkp,
        Func<TResult> onGbp,
        Func<TResult> onGel,
        Func<TResult> onGhs,
        Func<TResult> onGip,
        Func<TResult> onGmd,
        Func<TResult> onGnf,
        Func<TResult> onGtq,
        Func<TResult> onGyd,
        Func<TResult> onHkd,
        Func<TResult> onHnl,
        Func<TResult> onHrk,
        Func<TResult> onHtg,
        Func<TResult> onHuf,
        Func<TResult> onIdr,
        Func<TResult> onIls,
        Func<TResult> onInr,
        Func<TResult> onIqd,
        Func<TResult> onIrr,
        Func<TResult> onIsk,
        Func<TResult> onJmd,
        Func<TResult> onJod,
        Func<TResult> onJpy,
        Func<TResult> onKes,
        Func<TResult> onKgs,
        Func<TResult> onKhr,
        Func<TResult> onKmf,
        Func<TResult> onKpw,
        Func<TResult> onKrw,
        Func<TResult> onKwd,
        Func<TResult> onKyd,
        Func<TResult> onKzt,
        Func<TResult> onLak,
        Func<TResult> onLbp,
        Func<TResult> onLkr,
        Func<TResult> onLrd,
        Func<TResult> onLsl,
        Func<TResult> onLtl,
        Func<TResult> onLvl,
        Func<TResult> onLyd,
        Func<TResult> onMad,
        Func<TResult> onMdl,
        Func<TResult> onMga,
        Func<TResult> onMkd,
        Func<TResult> onMmk,
        Func<TResult> onMnt,
        Func<TResult> onMop,
        Func<TResult> onMro,
        Func<TResult> onMur,
        Func<TResult> onMvr,
        Func<TResult> onMwk,
        Func<TResult> onMxn,
        Func<TResult> onMxv,
        Func<TResult> onMyr,
        Func<TResult> onMzn,
        Func<TResult> onNad,
        Func<TResult> onNgn,
        Func<TResult> onNio,
        Func<TResult> onNok,
        Func<TResult> onNpr,
        Func<TResult> onNzd,
        Func<TResult> onOmr,
        Func<TResult> onPab,
        Func<TResult> onPen,
        Func<TResult> onPgk,
        Func<TResult> onPhp,
        Func<TResult> onPkr,
        Func<TResult> onPln,
        Func<TResult> onPyg,
        Func<TResult> onQar,
        Func<TResult> onRon,
        Func<TResult> onRsd,
        Func<TResult> onRub,
        Func<TResult> onRwf,
        Func<TResult> onSar,
        Func<TResult> onSbd,
        Func<TResult> onScr,
        Func<TResult> onSdg,
        Func<TResult> onSek,
        Func<TResult> onSgd,
        Func<TResult> onShp,
        Func<TResult> onSll,
        Func<TResult> onSle,
        Func<TResult> onSos,
        Func<TResult> onSrd,
        Func<TResult> onSsp,
        Func<TResult> onStd,
        Func<TResult> onSvc,
        Func<TResult> onSyp,
        Func<TResult> onSzl,
        Func<TResult> onThb,
        Func<TResult> onTjs,
        Func<TResult> onTmt,
        Func<TResult> onTnd,
        Func<TResult> onTop,
        Func<TResult> onTry,
        Func<TResult> onTtd,
        Func<TResult> onTwd,
        Func<TResult> onTzs,
        Func<TResult> onUah,
        Func<TResult> onUgx,
        Func<TResult> onUsd,
        Func<TResult> onUsn,
        Func<TResult> onUss,
        Func<TResult> onUyi,
        Func<TResult> onUyu,
        Func<TResult> onUzs,
        Func<TResult> onVef,
        Func<TResult> onVnd,
        Func<TResult> onVuv,
        Func<TResult> onWst,
        Func<TResult> onXaf,
        Func<TResult> onXag,
        Func<TResult> onXau,
        Func<TResult> onXba,
        Func<TResult> onXbb,
        Func<TResult> onXbc,
        Func<TResult> onXbd,
        Func<TResult> onXcd,
        Func<TResult> onXdr,
        Func<TResult> onXof,
        Func<TResult> onXpd,
        Func<TResult> onXpf,
        Func<TResult> onXpt,
        Func<TResult> onXts,
        Func<TResult> onXxx,
        Func<TResult> onYer,
        Func<TResult> onZar,
        Func<TResult> onZmk,
        Func<TResult> onZmw,
        Func<TResult> onBtc,
        Func<TResult> onXus,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UnknownCurrency => onUnknownCurrency(),
            _ when this == Aed => onAed(),
            _ when this == Afn => onAfn(),
            _ when this == All => onAll(),
            _ when this == Amd => onAmd(),
            _ when this == Ang => onAng(),
            _ when this == Aoa => onAoa(),
            _ when this == Ars => onArs(),
            _ when this == Aud => onAud(),
            _ when this == Awg => onAwg(),
            _ when this == Azn => onAzn(),
            _ when this == Bam => onBam(),
            _ when this == Bbd => onBbd(),
            _ when this == Bdt => onBdt(),
            _ when this == Bgn => onBgn(),
            _ when this == Bhd => onBhd(),
            _ when this == Bif => onBif(),
            _ when this == Bmd => onBmd(),
            _ when this == Bnd => onBnd(),
            _ when this == Bob => onBob(),
            _ when this == Bov => onBov(),
            _ when this == Brl => onBrl(),
            _ when this == Bsd => onBsd(),
            _ when this == Btn => onBtn(),
            _ when this == Bwp => onBwp(),
            _ when this == Byr => onByr(),
            _ when this == Bzd => onBzd(),
            _ when this == Cad => onCad(),
            _ when this == Cdf => onCdf(),
            _ when this == Che => onChe(),
            _ when this == Chf => onChf(),
            _ when this == Chw => onChw(),
            _ when this == Clf => onClf(),
            _ when this == Clp => onClp(),
            _ when this == Cny => onCny(),
            _ when this == Cop => onCop(),
            _ when this == Cou => onCou(),
            _ when this == Crc => onCrc(),
            _ when this == Cuc => onCuc(),
            _ when this == Cup => onCup(),
            _ when this == Cve => onCve(),
            _ when this == Czk => onCzk(),
            _ when this == Djf => onDjf(),
            _ when this == Dkk => onDkk(),
            _ when this == Dop => onDop(),
            _ when this == Dzd => onDzd(),
            _ when this == Egp => onEgp(),
            _ when this == Ern => onErn(),
            _ when this == Etb => onEtb(),
            _ when this == Eur => onEur(),
            _ when this == Fjd => onFjd(),
            _ when this == Fkp => onFkp(),
            _ when this == Gbp => onGbp(),
            _ when this == Gel => onGel(),
            _ when this == Ghs => onGhs(),
            _ when this == Gip => onGip(),
            _ when this == Gmd => onGmd(),
            _ when this == Gnf => onGnf(),
            _ when this == Gtq => onGtq(),
            _ when this == Gyd => onGyd(),
            _ when this == Hkd => onHkd(),
            _ when this == Hnl => onHnl(),
            _ when this == Hrk => onHrk(),
            _ when this == Htg => onHtg(),
            _ when this == Huf => onHuf(),
            _ when this == Idr => onIdr(),
            _ when this == Ils => onIls(),
            _ when this == Inr => onInr(),
            _ when this == Iqd => onIqd(),
            _ when this == Irr => onIrr(),
            _ when this == Isk => onIsk(),
            _ when this == Jmd => onJmd(),
            _ when this == Jod => onJod(),
            _ when this == Jpy => onJpy(),
            _ when this == Kes => onKes(),
            _ when this == Kgs => onKgs(),
            _ when this == Khr => onKhr(),
            _ when this == Kmf => onKmf(),
            _ when this == Kpw => onKpw(),
            _ when this == Krw => onKrw(),
            _ when this == Kwd => onKwd(),
            _ when this == Kyd => onKyd(),
            _ when this == Kzt => onKzt(),
            _ when this == Lak => onLak(),
            _ when this == Lbp => onLbp(),
            _ when this == Lkr => onLkr(),
            _ when this == Lrd => onLrd(),
            _ when this == Lsl => onLsl(),
            _ when this == Ltl => onLtl(),
            _ when this == Lvl => onLvl(),
            _ when this == Lyd => onLyd(),
            _ when this == Mad => onMad(),
            _ when this == Mdl => onMdl(),
            _ when this == Mga => onMga(),
            _ when this == Mkd => onMkd(),
            _ when this == Mmk => onMmk(),
            _ when this == Mnt => onMnt(),
            _ when this == Mop => onMop(),
            _ when this == Mro => onMro(),
            _ when this == Mur => onMur(),
            _ when this == Mvr => onMvr(),
            _ when this == Mwk => onMwk(),
            _ when this == Mxn => onMxn(),
            _ when this == Mxv => onMxv(),
            _ when this == Myr => onMyr(),
            _ when this == Mzn => onMzn(),
            _ when this == Nad => onNad(),
            _ when this == Ngn => onNgn(),
            _ when this == Nio => onNio(),
            _ when this == Nok => onNok(),
            _ when this == Npr => onNpr(),
            _ when this == Nzd => onNzd(),
            _ when this == Omr => onOmr(),
            _ when this == Pab => onPab(),
            _ when this == Pen => onPen(),
            _ when this == Pgk => onPgk(),
            _ when this == Php => onPhp(),
            _ when this == Pkr => onPkr(),
            _ when this == Pln => onPln(),
            _ when this == Pyg => onPyg(),
            _ when this == Qar => onQar(),
            _ when this == Ron => onRon(),
            _ when this == Rsd => onRsd(),
            _ when this == Rub => onRub(),
            _ when this == Rwf => onRwf(),
            _ when this == Sar => onSar(),
            _ when this == Sbd => onSbd(),
            _ when this == Scr => onScr(),
            _ when this == Sdg => onSdg(),
            _ when this == Sek => onSek(),
            _ when this == Sgd => onSgd(),
            _ when this == Shp => onShp(),
            _ when this == Sll => onSll(),
            _ when this == Sle => onSle(),
            _ when this == Sos => onSos(),
            _ when this == Srd => onSrd(),
            _ when this == Ssp => onSsp(),
            _ when this == Std => onStd(),
            _ when this == Svc => onSvc(),
            _ when this == Syp => onSyp(),
            _ when this == Szl => onSzl(),
            _ when this == Thb => onThb(),
            _ when this == Tjs => onTjs(),
            _ when this == Tmt => onTmt(),
            _ when this == Tnd => onTnd(),
            _ when this == Top => onTop(),
            _ when this == Try => onTry(),
            _ when this == Ttd => onTtd(),
            _ when this == Twd => onTwd(),
            _ when this == Tzs => onTzs(),
            _ when this == Uah => onUah(),
            _ when this == Ugx => onUgx(),
            _ when this == Usd => onUsd(),
            _ when this == Usn => onUsn(),
            _ when this == Uss => onUss(),
            _ when this == Uyi => onUyi(),
            _ when this == Uyu => onUyu(),
            _ when this == Uzs => onUzs(),
            _ when this == Vef => onVef(),
            _ when this == Vnd => onVnd(),
            _ when this == Vuv => onVuv(),
            _ when this == Wst => onWst(),
            _ when this == Xaf => onXaf(),
            _ when this == Xag => onXag(),
            _ when this == Xau => onXau(),
            _ when this == Xba => onXba(),
            _ when this == Xbb => onXbb(),
            _ when this == Xbc => onXbc(),
            _ when this == Xbd => onXbd(),
            _ when this == Xcd => onXcd(),
            _ when this == Xdr => onXdr(),
            _ when this == Xof => onXof(),
            _ when this == Xpd => onXpd(),
            _ when this == Xpf => onXpf(),
            _ when this == Xpt => onXpt(),
            _ when this == Xts => onXts(),
            _ when this == Xxx => onXxx(),
            _ when this == Yer => onYer(),
            _ when this == Zar => onZar(),
            _ when this == Zmk => onZmk(),
            _ when this == Zmw => onZmw(),
            _ when this == Btc => onBtc(),
            _ when this == Xus => onXus(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknownCurrency,
        Action onAed,
        Action onAfn,
        Action onAll,
        Action onAmd,
        Action onAng,
        Action onAoa,
        Action onArs,
        Action onAud,
        Action onAwg,
        Action onAzn,
        Action onBam,
        Action onBbd,
        Action onBdt,
        Action onBgn,
        Action onBhd,
        Action onBif,
        Action onBmd,
        Action onBnd,
        Action onBob,
        Action onBov,
        Action onBrl,
        Action onBsd,
        Action onBtn,
        Action onBwp,
        Action onByr,
        Action onBzd,
        Action onCad,
        Action onCdf,
        Action onChe,
        Action onChf,
        Action onChw,
        Action onClf,
        Action onClp,
        Action onCny,
        Action onCop,
        Action onCou,
        Action onCrc,
        Action onCuc,
        Action onCup,
        Action onCve,
        Action onCzk,
        Action onDjf,
        Action onDkk,
        Action onDop,
        Action onDzd,
        Action onEgp,
        Action onErn,
        Action onEtb,
        Action onEur,
        Action onFjd,
        Action onFkp,
        Action onGbp,
        Action onGel,
        Action onGhs,
        Action onGip,
        Action onGmd,
        Action onGnf,
        Action onGtq,
        Action onGyd,
        Action onHkd,
        Action onHnl,
        Action onHrk,
        Action onHtg,
        Action onHuf,
        Action onIdr,
        Action onIls,
        Action onInr,
        Action onIqd,
        Action onIrr,
        Action onIsk,
        Action onJmd,
        Action onJod,
        Action onJpy,
        Action onKes,
        Action onKgs,
        Action onKhr,
        Action onKmf,
        Action onKpw,
        Action onKrw,
        Action onKwd,
        Action onKyd,
        Action onKzt,
        Action onLak,
        Action onLbp,
        Action onLkr,
        Action onLrd,
        Action onLsl,
        Action onLtl,
        Action onLvl,
        Action onLyd,
        Action onMad,
        Action onMdl,
        Action onMga,
        Action onMkd,
        Action onMmk,
        Action onMnt,
        Action onMop,
        Action onMro,
        Action onMur,
        Action onMvr,
        Action onMwk,
        Action onMxn,
        Action onMxv,
        Action onMyr,
        Action onMzn,
        Action onNad,
        Action onNgn,
        Action onNio,
        Action onNok,
        Action onNpr,
        Action onNzd,
        Action onOmr,
        Action onPab,
        Action onPen,
        Action onPgk,
        Action onPhp,
        Action onPkr,
        Action onPln,
        Action onPyg,
        Action onQar,
        Action onRon,
        Action onRsd,
        Action onRub,
        Action onRwf,
        Action onSar,
        Action onSbd,
        Action onScr,
        Action onSdg,
        Action onSek,
        Action onSgd,
        Action onShp,
        Action onSll,
        Action onSle,
        Action onSos,
        Action onSrd,
        Action onSsp,
        Action onStd,
        Action onSvc,
        Action onSyp,
        Action onSzl,
        Action onThb,
        Action onTjs,
        Action onTmt,
        Action onTnd,
        Action onTop,
        Action onTry,
        Action onTtd,
        Action onTwd,
        Action onTzs,
        Action onUah,
        Action onUgx,
        Action onUsd,
        Action onUsn,
        Action onUss,
        Action onUyi,
        Action onUyu,
        Action onUzs,
        Action onVef,
        Action onVnd,
        Action onVuv,
        Action onWst,
        Action onXaf,
        Action onXag,
        Action onXau,
        Action onXba,
        Action onXbb,
        Action onXbc,
        Action onXbd,
        Action onXcd,
        Action onXdr,
        Action onXof,
        Action onXpd,
        Action onXpf,
        Action onXpt,
        Action onXts,
        Action onXxx,
        Action onYer,
        Action onZar,
        Action onZmk,
        Action onZmw,
        Action onBtc,
        Action onXus,
        Action<string> otherwise)
    {
        if (this == UnknownCurrency) onUnknownCurrency();
        else if (this == Aed) onAed();
        else if (this == Afn) onAfn();
        else if (this == All) onAll();
        else if (this == Amd) onAmd();
        else if (this == Ang) onAng();
        else if (this == Aoa) onAoa();
        else if (this == Ars) onArs();
        else if (this == Aud) onAud();
        else if (this == Awg) onAwg();
        else if (this == Azn) onAzn();
        else if (this == Bam) onBam();
        else if (this == Bbd) onBbd();
        else if (this == Bdt) onBdt();
        else if (this == Bgn) onBgn();
        else if (this == Bhd) onBhd();
        else if (this == Bif) onBif();
        else if (this == Bmd) onBmd();
        else if (this == Bnd) onBnd();
        else if (this == Bob) onBob();
        else if (this == Bov) onBov();
        else if (this == Brl) onBrl();
        else if (this == Bsd) onBsd();
        else if (this == Btn) onBtn();
        else if (this == Bwp) onBwp();
        else if (this == Byr) onByr();
        else if (this == Bzd) onBzd();
        else if (this == Cad) onCad();
        else if (this == Cdf) onCdf();
        else if (this == Che) onChe();
        else if (this == Chf) onChf();
        else if (this == Chw) onChw();
        else if (this == Clf) onClf();
        else if (this == Clp) onClp();
        else if (this == Cny) onCny();
        else if (this == Cop) onCop();
        else if (this == Cou) onCou();
        else if (this == Crc) onCrc();
        else if (this == Cuc) onCuc();
        else if (this == Cup) onCup();
        else if (this == Cve) onCve();
        else if (this == Czk) onCzk();
        else if (this == Djf) onDjf();
        else if (this == Dkk) onDkk();
        else if (this == Dop) onDop();
        else if (this == Dzd) onDzd();
        else if (this == Egp) onEgp();
        else if (this == Ern) onErn();
        else if (this == Etb) onEtb();
        else if (this == Eur) onEur();
        else if (this == Fjd) onFjd();
        else if (this == Fkp) onFkp();
        else if (this == Gbp) onGbp();
        else if (this == Gel) onGel();
        else if (this == Ghs) onGhs();
        else if (this == Gip) onGip();
        else if (this == Gmd) onGmd();
        else if (this == Gnf) onGnf();
        else if (this == Gtq) onGtq();
        else if (this == Gyd) onGyd();
        else if (this == Hkd) onHkd();
        else if (this == Hnl) onHnl();
        else if (this == Hrk) onHrk();
        else if (this == Htg) onHtg();
        else if (this == Huf) onHuf();
        else if (this == Idr) onIdr();
        else if (this == Ils) onIls();
        else if (this == Inr) onInr();
        else if (this == Iqd) onIqd();
        else if (this == Irr) onIrr();
        else if (this == Isk) onIsk();
        else if (this == Jmd) onJmd();
        else if (this == Jod) onJod();
        else if (this == Jpy) onJpy();
        else if (this == Kes) onKes();
        else if (this == Kgs) onKgs();
        else if (this == Khr) onKhr();
        else if (this == Kmf) onKmf();
        else if (this == Kpw) onKpw();
        else if (this == Krw) onKrw();
        else if (this == Kwd) onKwd();
        else if (this == Kyd) onKyd();
        else if (this == Kzt) onKzt();
        else if (this == Lak) onLak();
        else if (this == Lbp) onLbp();
        else if (this == Lkr) onLkr();
        else if (this == Lrd) onLrd();
        else if (this == Lsl) onLsl();
        else if (this == Ltl) onLtl();
        else if (this == Lvl) onLvl();
        else if (this == Lyd) onLyd();
        else if (this == Mad) onMad();
        else if (this == Mdl) onMdl();
        else if (this == Mga) onMga();
        else if (this == Mkd) onMkd();
        else if (this == Mmk) onMmk();
        else if (this == Mnt) onMnt();
        else if (this == Mop) onMop();
        else if (this == Mro) onMro();
        else if (this == Mur) onMur();
        else if (this == Mvr) onMvr();
        else if (this == Mwk) onMwk();
        else if (this == Mxn) onMxn();
        else if (this == Mxv) onMxv();
        else if (this == Myr) onMyr();
        else if (this == Mzn) onMzn();
        else if (this == Nad) onNad();
        else if (this == Ngn) onNgn();
        else if (this == Nio) onNio();
        else if (this == Nok) onNok();
        else if (this == Npr) onNpr();
        else if (this == Nzd) onNzd();
        else if (this == Omr) onOmr();
        else if (this == Pab) onPab();
        else if (this == Pen) onPen();
        else if (this == Pgk) onPgk();
        else if (this == Php) onPhp();
        else if (this == Pkr) onPkr();
        else if (this == Pln) onPln();
        else if (this == Pyg) onPyg();
        else if (this == Qar) onQar();
        else if (this == Ron) onRon();
        else if (this == Rsd) onRsd();
        else if (this == Rub) onRub();
        else if (this == Rwf) onRwf();
        else if (this == Sar) onSar();
        else if (this == Sbd) onSbd();
        else if (this == Scr) onScr();
        else if (this == Sdg) onSdg();
        else if (this == Sek) onSek();
        else if (this == Sgd) onSgd();
        else if (this == Shp) onShp();
        else if (this == Sll) onSll();
        else if (this == Sle) onSle();
        else if (this == Sos) onSos();
        else if (this == Srd) onSrd();
        else if (this == Ssp) onSsp();
        else if (this == Std) onStd();
        else if (this == Svc) onSvc();
        else if (this == Syp) onSyp();
        else if (this == Szl) onSzl();
        else if (this == Thb) onThb();
        else if (this == Tjs) onTjs();
        else if (this == Tmt) onTmt();
        else if (this == Tnd) onTnd();
        else if (this == Top) onTop();
        else if (this == Try) onTry();
        else if (this == Ttd) onTtd();
        else if (this == Twd) onTwd();
        else if (this == Tzs) onTzs();
        else if (this == Uah) onUah();
        else if (this == Ugx) onUgx();
        else if (this == Usd) onUsd();
        else if (this == Usn) onUsn();
        else if (this == Uss) onUss();
        else if (this == Uyi) onUyi();
        else if (this == Uyu) onUyu();
        else if (this == Uzs) onUzs();
        else if (this == Vef) onVef();
        else if (this == Vnd) onVnd();
        else if (this == Vuv) onVuv();
        else if (this == Wst) onWst();
        else if (this == Xaf) onXaf();
        else if (this == Xag) onXag();
        else if (this == Xau) onXau();
        else if (this == Xba) onXba();
        else if (this == Xbb) onXbb();
        else if (this == Xbc) onXbc();
        else if (this == Xbd) onXbd();
        else if (this == Xcd) onXcd();
        else if (this == Xdr) onXdr();
        else if (this == Xof) onXof();
        else if (this == Xpd) onXpd();
        else if (this == Xpf) onXpf();
        else if (this == Xpt) onXpt();
        else if (this == Xts) onXts();
        else if (this == Xxx) onXxx();
        else if (this == Yer) onYer();
        else if (this == Zar) onZar();
        else if (this == Zmk) onZmk();
        else if (this == Zmw) onZmw();
        else if (this == Btc) onBtc();
        else if (this == Xus) onXus();
        else otherwise(Value);
    }
}
