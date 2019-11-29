using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2017
{
    public static class Inputs
    {
        public const string Day1 = "818275977931166178424892653779931342156567268946849597948944469863818248114327524824136924486891794739281668741616818614613222585132742386168687517939432911753846817997473555693821316918473474459788714917665794336753628836231159578734813485687247273288926216976992516314415836985611354682821892793983922755395577592859959966574329787693934242233159947846757279523939217844194346599494858459582798326799512571365294673978955928416955127211624234143497546729348687844317864243859238665326784414349618985832259224761857371389133635711819476969854584123589566163491796442167815899539788237118339218699137497532932492226948892362554937381497389469981346971998271644362944839883953967698665427314592438958181697639594631142991156327257413186621923369632466918836951277519421695264986942261781256412377711245825379412978876134267384793694756732246799739464721215446477972737883445615664755923441441781128933369585655925615257548499628878242122434979197969569971961379367756499884537433839217835728263798431874654317137955175565253555735968376115749641527957935691487965161211853476747758982854811367422656321836839326818976668191525884763294465366151349347633968321457954152621175837754723675485348339261288195865348545793575843874731785852718281311481217515834822185477982342271937155479432673815629144664144538221768992733498856934255518875381672342521819499939835919827166318715849161715775427981485233467222586764392783699273452228728667175488552924399518855743923659815483988899924199449721321589476864161778841352853573584489497263216627369841455165476954483715112127465311353411346132671561568444626828453687183385215975319858714144975174516356117245993696521941589168394574287785233685284294357548156487538175462176268162852746996633977948755296869616778577327951858348313582783675149343562362974553976147259225311183729415381527435926224781181987111454447371894645359797229493458443522549386769845742557644349554641538488252581267341635761715674381775778868374988451463624332123361576518411234438681171864923916896987836734129295354684962897616358722633724198278552339794629939574841672355699222747886785616814449297817352118452284785694551841431869545321438468118";

        public const string Day2 = @"116	1470	2610	179	2161	2690	831	1824	2361	1050	2201	118	145	2275	2625	2333
976	220	1129	553	422	950	332	204	1247	1092	1091	159	174	182	984	713
84	78	773	62	808	83	1125	1110	1184	145	1277	982	338	1182	75	679
3413	3809	3525	2176	141	1045	2342	2183	157	3960	3084	2643	119	108	3366	2131
1312	205	343	616	300	1098	870	1008	1140	1178	90	146	980	202	190	774
4368	3905	3175	4532	3806	1579	4080	259	2542	221	4395	4464	208	3734	234	4225
741	993	1184	285	1062	372	111	118	63	843	325	132	854	105	956	961
85	79	84	2483	858	2209	2268	90	2233	1230	2533	322	338	68	2085	1267
2688	2022	112	130	1185	103	1847	3059	911	107	2066	1788	2687	2633	415	1353
76	169	141	58	161	66	65	225	60	152	62	64	156	199	80	56
220	884	1890	597	3312	593	4259	222	113	2244	3798	4757	216	1127	4400	178
653	369	216	132	276	102	265	889	987	236	239	807	1076	932	84	864
799	739	75	1537	82	228	69	1397	1396	1203	1587	63	313	1718	1375	469
1176	112	1407	136	1482	1534	1384	1202	604	851	190	284	1226	113	114	687
73	1620	81	1137	812	75	1326	1355	1545	1666	1356	1681	1732	85	128	902
571	547	160	237	256	30	496	592	385	576	183	692	192	387	647	233";

        public const string Day4 = @"nyot babgr babgr kqtu kqtu kzshonp ylyk psqk
iix ewj rojvbkk phrij iix zuajnk tadv givslju ewj bda
isjur jppvano vctnpjp ngwzdq pxqfrk mnxxes zqwgnd giqh
ojufqke gpd olzirc jfao cjfh rcivvw pqqpudp
ilgomox extiffg ylbd nqxhk lsi isl nrho yom
feauv scstmie qgbod enpltx jrhlxet qps lejrtxh
wlrxtdo tlwdxor ezg ztp uze xtmw neuga aojrixu zpt
wchrl pzibt nvcae wceb
rdwytj kxuyet bqnzlv nyntjan dyrpsn zhi kbxlj ivo
dab mwiz bapjpz jbzppa
hbcudl tsfvtc zlqgpuk xoxbuh whmo atsxt pzkivuo wsa gjoevr hbcudl
gxhqamx dradmqo gxhqamx gxhqamx
yvwykx uhto ten wkvxyy wdbw
kzc ndzatgb rlxrk hfgorm qwgdky ndzatgb rhvyene qaa wxibe qwmku nmxkjqo
qwx ubca dxudny oxagv wqrv lhzsl qmsgv dxs awbquc akelgma
rrdlfpk ohoszz qiznasf awchv qnvse
ggsyj czcrdn oolj sibjzp ibzjps asp
vbcs ypgzae xcvpsr ptvb leoxqlq zmpt fhawu yfi tvbp
ejkr qlmag nsz jwpurli nhsml asksnug mes
kkgkjml kklmgjk kjgpx iquytbj eccceb mfv iuyqjbt ovv
uoklkco zzey sdfhiyv ytdeg
azr mjv raz arz rdfb
pir dafgsah dafgsah kndjbml estcz yjeoijp kkcws ebq puwno
iqymwc tac vlqc bmnkz xustm leqi
gwdjed cfha axz xjuq
abfjsg pahat qlj zan qsfn iozfys jnvu bis jakggq
afwuejn zrbu zurb hrn lwvjb jnwixla aufejnw
vkqn cuzf humhriz webnf uzfc zfuc
eznxd kgbfy jqyc net vzfege tprzyc
mqnapzn vrgw ilzp vgw
aie zkkih fhpwu bbn fhpwu wvxxgmd
ksoasrn yll mvdjxdo wydymx dmodvjx drnjlm tcjpjhj xzakb wrsbuwl vaygdwf rsasonk
qahbh tfhkl apdqqpm tfhkl nsox
xkelwve mvdmesj xrto tgku gkb bpe
nni nyylpu cyusxe zydeyok yokzdye xiscesy
itwsfr eqwrx igqkvif whklwdb
lpa hwci suwqfln xis sfht lzek ajecd
svpf eulute eya gvmsd app claria tjtk zjt agdyemi bixewo
gmzglxi zlgouy bejg kte xlf giquj mjeq ivjkw ktbhaga hoffyrt
wwjy dtf ftd agei yde xhbfo fyridy
gexcy hetkz ufflrfi frifluf plb kqre etxo elg henqy fspm
khaemn buec ichau wxctsxg
cgmv ujyvcuu jta yux ccx skrafkn cmyc yidqhv ltb ycnajry zitq
ybsahqn pio veeze vdztjz iedou pio sue ijbz gvqncl vpa ijbz
hkfi xzrsyke hikf mxolx xlxmo ungfc tst xjzd
tpx ioprco qixlv ipocro
oahmwrv homvraw vws ntmbdvx
fxlg wnuz ogt bxgtul vmfh nwuz glfx tgxdq bxfv kajuh
vrhqn nrqvh tgogb vya ragbro ulrz uava kexoi yav vkfe
bxxy tyxgxd oabsud bauosd jlch bdmrqq wqhjwb ayblb hclj
sfzsgsc sfzsgsc jbrvh sfzsgsc bdhy
wixleal vhnqbfw qwfnhbv woco oowc
exkkwz wekxzk krxbua nshxqgh
gkn blxgui nkg gnk
otsa isqn otsa isqn
ude xedl ude xedl amkktp
teroe yuvbd inf mpytuvz xiq xqi ovqetn
zyq ybeifwx fvoqp vhoduy bcq wbxl
zymiid vafcqv vjbmekf lgxkma bjti qfavcv iqp fnbu lakmgx
rkaqvd vylkh jfdxh imxxg bbrt imxxg rkaqvd
yajg qnhhs bzmb eyk hijcg tkij iwr jvwp dipzd jvwp
btzhw zttheyo ravsbz bmbba majoe ykrs tbxqf tai cgsvpu srbavz
vsyczfs ymg vsyczfs wxlwaqb oouio owek wxlwaqb azvbqiq
ghrapd ghrapd wisq wisq
znmleu aztnkbs wxc gycxd vqenhh geqyo rpjg
kxbom gzz zzg zgz
dfsesc okwb dfsesc okwb
egpwqbe djlk xpkxa hoo eepbqwg
nxdfror yfhkhn zgea fkspva rjgg bnmq ddsf rjgg gkinm
vdrxfom wbdwu dhkt xtvzc zjobo aqvgrt
svddsgz mhcrbcp wmpd mhcrbcp klim ddlnxv wrdftrc ddow wrdftrc
obxr wscs new brxo wen epns cvjvxts ilnc
rwezl vmbut kgblt xfg vnhlebq nzqdzxm ynh wokrezy zub nzzqxdm
vephajp bzupele mltzglh sbgn vephajp lhve mltzglh
slajp kyaf vlnvy srfietn ayfk inaufex fanuexi
vazwg kjg qanzso ptuu vvlwq uupt kohhql jkg
xmmmpky rbqimi slvxsf tlcwm pbf pks iucx rbmiqi
irkup jvu tkeioz avdu suxamf
tmgih ldca jswka dblzzt rap rgqyy gyrqsk nnnn pok
pdbjhrl gsvxbqr nqfkhtc ngn okbgzd pdbjhrl oostjtm okbgzd
mzqfdat dujh aeplzqh acbguic vlzdt amyszu amyszu jqecky bhl hjqnimq xoy
dszafr bqampg epozj sfrlpe dszafr wfurku sotjpg wagtnxy
jbmo jbmo plbfkvw bkc jbmo
ehelldu vrid unnf vrid xqiu tbibjyi bmbpsmq tpqyefx xqiu
rpgm zzbj cjgfdyb bdjfgcy rzqecd miyvfbu aqlkagf hsuxwgl
gvywzp phvnd ypwypbm yfelxx egbr lcfyz hecdhkj xxfley
tsmebin tbsnmie mkijj ijjmk
cghxrqs vzxle wrfghv skighgt zviteab plcrgv
ezdirp rxkw horcek qcgny inx nikb tigzp
eidk sactjci sre vkapava owvf eyds eyds
vvjdm uye tjixj azklizl pnb
tcrimv xye twii xye twii tad
mtxcg lwjxdj zjudqu ekoujd ysf ajtfta dkj lwjxdj
aowhmvv kkic kjize fnohl ukx remfmii usbp
wkossu limxmhp xnoeocb wkossu lnrlqf kjozfg xeulstx sjncsw ekaimuv xnoeocb sxjegcg
lsfe zpewzlc yhjyiay lou ukhi lpwezzc slef zvtidgg kdeseq enka tfvgudr
ovfsa vuv tbtorv tbtorv gmxn opspw lli mfzvkv zlyhr oznalr
kugrpw sduq rdc ciaxwir ylnzwec kugrpw sduq
obevuau thu jpyfvof rpawwo obevuau gsvoutr quiaei
xpgua pbxa pxgau kdan
ohyzqk abxgg xozgai nib axozig bni fucgykm jpkswt
jrgu dmozts jrug ufpho
qojzue uzeojq txuhj eqjzou
wcvj qwlravl niyxf oiaptlk wlxnnzj jgdzap jgdzap lfgn bdt sfga adrypo
ylah eedu rvwdpmq eedu ylah
quages kmla yjqua dzxcfam srjag wujmcv qujya ssaol uzdwi
gdsppz yqxlish yfkjbbf ecnzu ejvtv cdjwre
slsls pcmrq zax btrc kliv ntho gymkk kkq pcrmq mvnw sjfegpx
ryz jfw eki wvibww qdzylg whbagp ffrfjg wdhnqpm hcrz
tcjqfh tmvzp mpztv vpmzt
xood xutgof teqov fqyyub oakm rzaheiq
axagoq jawbz sexucp sexucp atenr edekcwn edekcwn agl ecj gbje gipivfq
poqv qopv bos flhghs gshlfh
rxd dzphnb bwmna vxd rxd sbk kuor
kqeelq jqbyh xczqzqe jbkmx kelqeq xqcfqn
jdfy qzjyz xvqyo jdfy xvqyo
vyoqyd pwayqag eygmdt smakwc veftikz fzeikvt
aozgkne mpd mktgoew eepp zlwycr eepp hswbxcx nmi ddnfr eepp
dgpfp cfhhqdx vjrb uyimbm byx hfdhxqc
fxq jcouwfy uhuao zsab xjao
noudveu egxyuqw hmnnv vovt wmqkx syatiac whkd
gxyzk opgb kjxp delavq hsnvk kfn irkcfq lvc aadcwy opgb
exuiupk ddiiyvm nsggpj ddiiyvm nsggpj
hhjby rfejzp akxzs nconlt rynivtq voloj qwhhll ubvx yxuacz miuwxh ppe
uspqvx supvxq cekv niddfuw
optzcag sra ajs ozacptg yxkludq jjpvldz mxo mox
dko qyec iuxbrbj dlz jxribub
ywlyz vipfh amsfr fwiozi tahjov tap rsea zwlyy oqdyfbo
xeqml jwy eguc bvzvh
crp mxsihvo wwtg gsypx mxsihvo qpfw looca gewvy zjqki tdkuxo crp
mqlnzm yihsvrl hhtwcv kigymqu yswki hksk vbiujq xeqz irzcq cpnz
zxhfsw uuyhwid nzabem mmfk wszfhx shxzwf hqnrvsq
hfjajdl qwmk hjdalfj mwkq gqbku dsszk
fbiy pujq htgaqqq yro ztpe yiufb fnpi ggchdgz
sixq jsboan eoie msdrwzw sixq njsrc sixq yimqoi
pbxgv kqmi hjuk bbtrlta bqwm bgehofj ainqhm qoypsil manhiq ogebhfj lvmuo
wnax aen fthpcke tcz yadjmva mydavaj rcfkc krfcc
lkatiw zxliii usdj oopxl yylv bkjfy gtlyjv usdj muqazdb
yqonaxv wqnvoo hfpll oyxnlfs fgajc khhtzr hfpll gsvvipz wbjxsnp dcdikt hqw
vvuv kspmnz zvmryqd egvuz eazkhz kspmnz
xgq dziwiym gsl nbzmsta ccbzn yalof dbbugq aar ywmbvk yofla dcwb
qrtyhhw xeyo vlym ulzzbl hrxyb qeyu jqdkewk oxye evaxz kybc bssyt
eqrf cfyy kwhohw ozg jsc egz jsc
vct cet ixxvmz ibhvndq eks dpi jzfwdqv saeh jqzdfwv vwfdqjz
vus vus kitvvgq wpi alfncf gzj oxcy fith oxcy ecbsr
uacculk guwhwdp cankcv yswy bmby sve dvonm nran
ydftm wszgaex rgbw otd dbet lhsxndd jqfyx
vhawg hwagv uagy fveik nrsew zujw hawvg dzfmt agzgw
uqdj talb uqdj aizyuqm
pbbejee szdtohv tycfow xwne qzlqy dxcwejz pqdqrc wfyotc gdqt uxaeug wtldm
hmzmd oyp pyo opy
qwdh kwpll kwpll zsbez uxg klr uxg
myqr zza kqpcos adsql eumunrv qlaeumx
acyye xvdewe nwkhuz bzcmx asw ostiwk mfzu nwkhuz
memq uqadd kfj dses lrxb hxygp dsse bxbr hgpxy uavrar
mjmk lsdttuz qjkg yfthmkn pram
pctfq aly usim shihap uims xkfgp ksrbn ifvsyl
cdma nnnu hdm dhm
kpt upgsm ohvrrqf qwps wjcbve ohvrrqf
wowphgb nteme otizypb eumgvb puoctli opicult wbohwpg
fppz ftkql sbut lkqtf svif viqhlnn buts lljhbd
oqk uinby rqy vbjhf oul hzfo coca glpy brjy yglp qnvhvei
sbbwr dnyrux gpikv nsx aawyeq uhtucwq rhxzy jgx bdgdrl dnyrux lgfgi
agn mljz hgmglem popu jtapub agn
ehfpgr bnobvg bnobvg bnobvg
ozgzedn godezzn art atr
urz rzu xzyc rjhwi kgiodi doiigk layr dwbxu
rkcbav pnp bpsmm ifivfe csouqpw fyswzbd csouqpw bnjt rnnoxed
hpjgtcc ctcpgjh cchjtgp lxn
cinokbx uyaz uyaz uyaz
bphfwad bphfwad bphfwad yml izlhlb dvjvo jeropar
ocgftcl wshjk zbinw fcotlgc xdj nwibz
zbze hllno rmq invd gupoxr gwumc vnzj fcvvhjo dnn sfsxw
oqlhkz hgf yxiahks vhzvl ayshkxi irmwkmq
apeqic ahwu abxjrd tuwrd pynnil eohmlgo lafx ybpofe wbznxv swuafas
cpg jpsfo jposf rer ixeydpz
rhqrwvn wrhqnrv xptms jhc rnqvhwr
zfpl tukxzda lifkqtd ynfuno cttx ctxt tlqdkfi ueswv wbipfbe
eblw bwbjg fuu qqm qtv qtv isbl denfcb
ick yqwcffk pvcchd apkjyc ouu uyfe nplid ick caqscs sddkx
rtzh idn snnw xmlou idn kdhenl rtzh ujwttl pkynkhe
dnwha fpv dnwha iqi xggepo dnwha
yjvk saay enxqhw wigoah dzasyr nnt artl iqwia jpp xmfr hwigao
ryt heenuai ytr gqew hyb byh wdurx kmd adgjz
ypdqeji sfkkfhn stms cdmyh nqllx utiphia gxbx zflhtgo yurztx eni
pwlhlt lhlwpt rfkvlgr tucajej ckujc ntcyae xestygt eshmggk
gtfb codwc vjtli ffmjwx ruoekt cylrm ktroue dfaxzvs kkgejzi ewucgu jyatrum
ersbag cod xssha aqzbe kxu bzghhqk pbs bizvqk bhbbd bps
vhci ypxf bxzor unngl xilpzpk civh nykora vchi
cyb cceu negnld nbcfs pxsjgh xah nbcfs nbcfs jabpxg wtanv qhztvr
cljgzkn lrdeina hrjoz kdgpn vqkmpal nivk scvnu vzuausp
nif fin uxjbip xxztsn yyo opueh zxs qnso paedey hsd fttvqdn
gbnkmpr afo aof ryyudy gbmpnrk
uaa npb dkit npb buadan esv npb hwrj
hws dfgq fcyty qszhu chyxxl ytmpb azxl jrsn boqrx
hkzlnkd fkilvog xbubu fbgbp
fgi inmay uliytc vgkcw qsoe uliytc isjhix oyir ocaq
qrzkpm dpzetbr zommsxo cixg nwjyvp bet wyjpvn cgxi tsncd
uvlf lufv ulfv cigl
uwwf thr kdq fhjmty bvxue vcwwmk kdq nzajq bxkf
qcwduju idxaja qcwduju idxaja
fnarz pstzfne nco qzf kcevoo qwx csvsxga pstzfne
twug xrwy uoctfl bkh yxrw
unpdnbe apf cvm bpullu fyels tjpri jyw unpdnbe xfyekay vhk zpyb
rbv psirdv psirdv mnjrp qpwc vicismd qpwc
zjj zjj kesyhow eqcfqy vqy
zazpd gmea aobl dcs mage hqjdpwc bvxr srw
rhcdb nzsa jgcgc rhcdb wxs vsvvptn zvckqo wxs
unyet prchn fiwter wvgknes dvzbxfs ufet neuyt fczlrx bpocdci vdsfzbx
znfev fwrdarx knqkv ojiv ojiv fwrdarx
tbtlo hdashg kyspxm ypmkxs nmrk
fzr zqxaszt frz xzrre
shueb iraetk uhsv duvah uhsv zstysc nrfllbc emrknka
vzkrmp mgtkjnw njr bwjgp jdwyyhv yudha wbvmx ewu urhiioq
yjq xxr swvm aipdj apjid tfsq gfqg izrvhev
iljuqt fpo fxadit iljuqt iljuqt
zrj poewso vsje bsprbmc vsje yfwf ybu dmkqib ybu hlrpdi ymh
apxaeq bgdm mqty whyay mnuzfgk awm bgdm mwwi ekw bgdm
dpdbfkm crrg mkph kphm grcr ukbk
ilqm wroz mqil qlim
pnlx nwadw uabelu rueamxr wjer uwge jwer ywagrx
akuil nkh oitq werli werli
fkmhcr ieoj xfsa xfacoeb tcg poomcme vck zmpc djcqgkf kft
csyk qni hqfrye zyyxz ggynzad pjpokmu bigqa qie
lkpenw zyllii qtbvdq zqnu ichftg xazped agl irhlbiy snlwfe twliar
acsrba dzz ivylbl rfcdd rfcdd qcg
zbui fomvpx zjhmgl sivtffu xuhswzt fzeid tgj mzok mozk afbhuje tzswxuh
nupjiat fdxkbn tuatp jhdfnub yitdk yghqw nupjiat ibi edfv tuixw auwjm
focht mnprh tljj ayp
pjdnl uaoworh iqm gic dqlu spn heuymio
kvg ferrvhp unvzsd qdcpd rji zpch
nhvay chuzg pyhdd hnmrnq zeidhf pyhdd ohy hnmrnq
boa sau gxh grx
gwo utwpd zcsrx gow bnm
xoqniyd hmithl xoqniyd hmithl
yqqsbzo stca zcsjnqf skbueeu tlbkef mvqbg igzr wujuz yqqsbzo kkfe
wgzuepu wge fkrxuag csenx tkngoz wge azueyxs
get xiryxs xiryxs xiryxs
wammvx edy hahetl xmvawm dye
lscxxgi anmax quo cqprwn imocarq gnbfhe rcnqpw
znpmid yaluvzn ydm ckh uhso rrk wbby lwxsu
atppk byf dzz uift nqejgm njgeqm
dtqmy iog ahub habu
hkthdwt pfxlwsu hkthdwt hkthdwt
tsuiue tsuiue yais tsuiue
swooqmp rqrcs ngr vujrq inuu rqrcs
dhu zxdfiyv xuz xuz mgaty mgaty
kiiiz zco qdv vfgkj rders zco
trszp havbm redpeqk gktp ifvzvwl yfoxnm tzg avzd otiouso eks lqlutwb
cfiru lpdy kpeas mdc lxnjjqz nqyyb xkjsug rcifu dln
jga ijgkjo qhbnupb ofzqn iokjjg gaj lrh pkynrcr jgatk
bexwc tat tat otsngaa
feh mjxbs ehf cyfhlv vvdgdu hef
njlvq ojwaes awsejo ktyvxd qeyeze bpoaj ulgngn zyeqee kqc bsdzzvq
hbfp vnhs vnhs pko pxnxgm
bmy bzpn bzpn bcfep
cju nqjy yjqn bbrj esgzw swgl bjrb
cxvrshm rbglkyv kqwzcyd azqr ckwbbew fhgqv nfk lactzh ssqpwbr wbewbck
ptcb gqkb apcc okl jbbgk qni bqu slydyo qhh dqd osv
zbisefn bmxcljk bmxcljk arkamus vpq uxuwvb
ksik xbzk lahh ctfur sxh rduokr xqou zwbgqsp skik
hwhmfk hwhmfk bjpxzg qqftmu ijyv igvayf bjpxzg
askxqew tibx pqaczy fhzyec echzfy cezfhy
omzyy mbzfvsn kkoff qgqn crnnkn krx oqp jhn anb qte qxt
jypnwn vjbnbsl axf pldxbq pdoy rmxcvig cpad yhah rzqewkg nmzkkr erjo
visidzp bujlfn xuomjj mjnqn wgflg skb
oer oer lfi zyqnem lfi guljz
fannhwu wafma gcje cvcia qwyh ugtbpa geufqg
kwtjib pqwai tdmjj kuxr euzl rxuk
ovi splc hflutgw hflutgw
gvel gelv aeiygth elvg twwr kivxrrj jkmqa
bas ylxbdgn yliv pytkhq haujsyf fggrnbc wsgree rfnppcx key gvdzgfy evdtrrz
oblab wpgm bpyy xuroy qhb adqko
hneb law uzms fhhk yjymdx wjla ixfh yblh
qlvsd bxsq hjaq fuwspzu hyshq idbabc rqcih ilixp wft rglf lmqm
qdskj two ckd qdt hzjvd woo fmmuw
kumc zywzq srafcbb ihfu kfvav
qlkkrq qlkkrq qlkkrq qsc
hob bpecik zqtrfz iqizeu plrer epm zqtrfz xrekeql xrekeql
warszd sxyyorh sxyyorh eztjf warszd kszp
hjbrax liumjue liumjue liumjue
rfnqd folmiu dlicln pdyk uqd rfnqd
mjdu lytfvya xomdujn leaqiyc lgemz lihfnhv zgeml koukz luqda
yqsz zedjmwn aep qwbhd yqsz
etg rmovps abizj yqr kib
yznxec sfqkd ofkzep njr hmeym nsh xdq
ryoyq heoo zuo udvfev ehoo axcnbpu oeho mfenmd shrebzy
uaeh jwllsjp frkhqsy uaeh
giofw hwceb euikqp ldmb kqpkxwv namazcg hqyyzgs cglsqux
qledbd qledbd kbwo wgfmgp
olbsca muxw nxs locsba
gbxxgj xlzm gws pkpwy ofkxb sykhdo nbhrv
najr bfk tbqkm hxabe nvr mdi dmuujr bfil nyripr zcydzy
kiczhcn dfgylw yzkwk nytijj pceu yukj ekaol xpb uep
acyyxn rwczsud acyyxn payiek inusyb rwczsud
mzssokx bshs bshs ocrvlug nzsgvch riejkrd jkj mpmdgsp kvixdfq msmmx
uaxy wpvhf uaaq ranp vfhwp iik kii nvh
shecxef nqpx jly dzm qvmpu kxg hdg
xembm yzevult ljrllc yrlskyk zas wstnz yrlskyk vasra
yoaxppi kzax hvxfezf mek teo cbtlrfa ncxac yee
dzfpbi cynov dje vxypba wcwww cwnu cqtp cnuw wwwcw rkzas
xzwdt jcwv anb xzwdt
fodgjem fmmrsfl eovsneo etzutda paw fmmrsfl jcqql
yfztt alcw nwdmd afgknu njxkj zykz cvv jbnl han iatmruu trqls
yas hpulrmf dzts sltg qsbw fjj rjymnnx dkkv
hwjtgd abmb cfw xoumxn xnoumx cxo xnxmuo alb
hnl zgdiip lrddhl fyw mporhtp waedf dltdfmc lyipoth ubmg hnl
wxard wxard cibp nzquvb muuslvw igvewfh mika wxard
cjqjhva rrhzy qpdc nqnyd enbdee ewrhp cqdp xekgjai
axtmxb axtmxb phl urdqaar urdqaar
umce jult bkart dgdvdwc kqzlzn nqkzlz umlxx cmue xvehqag wxifal
lwsuc ski ubo ksi sik qwcudv
husdv tssr gfp bfzbrp jtmk svvdpb uvshd zbnpdmj svpdvb
nnbvf xbb dobqk xwloqca uxvqti blcwxpu kubwu nognin goywn
xhe dhddftc ggltd dhddftc wspf
jodq cgvnk lpl wkwwlqd prfby bpyfr tbgyqm
bdebxj cuvow jdwdxw kuzh dvxmsyb dyvcxo psf kjnoe odfwgfa
xpfb knzgfsi thmsnbi ymjxn bevohy xpfb
hphcu fjodpdt mfsp jkvvp jvypar nlud lfv uftupcr nul dunl
olz ihyhw qntr lwcbohv qntr wzralwl
kfz pkjhidy msnmwz exox xexo uakipj mmznws zbbji ozispqb
gfi kwdhx qqo kdxwh fig
ehh rfozwr caoisw qntlk pkv zulc kpv hrqz
exmlrj aacc rzb qie rzb
mxyqe cuqz feyd meqyx gdvpu rqyjtvw dmoo vugdp emem
advj xmnad uvh ufnbi xmnad xmnad zzwjksx chbrjas hrbp ruvyg
nasrghk pmol ryko ofgakhd korf vpy nakrsgh
mylyqg aeizp rnk krlwchk aaqg
edxursp sosyv zesgnpx zlo sly alurdc ypmez qib aqtt lmxd
ihm hwzhd jhiw raocjk nlxce yzuzu nhudri tvygl tmclg mdkz
psubdis qrmxebg kdac xvl raxwfx vlx sxme
tci tphdy tggam vqqiyjz sgfvdri sxhztz fhsmxx yaj ncxcxq tic
xkljs cuhrm fdjqwd fuzyzh dzuzgjd lzpye lzpey
jriwl ypkcxd fxrg eit okzzzsc yaykarm qzuv jurgek dzfbbfl
workf rrw absfl gxluw qprdsz absfl qwqbmi amepvz oiqmy workf
dxyyb brnerbx lykd oqmz ursl zqom
cqtuzva aih uhaswd auhwds ktyvc hufogcg
jre fhlgrse svedc prfspaj ghm qcjzfc nsd
fow xyo vlvg sgg jgzvff rjxh eovre xtupnz
pekj pgiecc igxd zbiqoob ovv
xofxmz rdzdiq yruoqkh arfunx yruoqkh ucm bxov
ctogwj lpv ivtoxkf faj ctogwj xfzluad ctogwj vvw
rmc vjxj strgo tykifpp
ulivozu bczond ywnmt shakc yknr psr
bfx alwedh jfomlf pzj tely alwedh vccsoer rgwftcl vccsoer
frkwbv uudwt qsfg onuhiml jrd usu
bgdx deybefo gdj dgbx luu cbuwawd wqqtq dqmwy gin mhtfgy
ohjp ykemg nrs leayrh brtipx jhop phoj
utaep ywsy utaep ywsy
qow dxagjwb qbki bqik
larkpq bdgw mly vvwgv
juar zaerof qekpe hhgd eygru epekq dhgh
xpblz xksc lzue xksc yid nnve trlndn gjczngs cifqoaf
fpv ekz eknldf uqjgeu awwnwxu eknldf eknldf txhxv
mzvk wqtbda ovdbh vnes uiuuc uicuu bpwwtm aaat cygej nio gnl
rkdkzp bjaxqif xuwx bjaxqif hgtz slkqw rkdkzp ztp xfvgk ycvg
zpwr wvxzfcd opgcrfc ytxeboe rcqa ehrga lmgm
brsdnk nqgkjab nbjkaqg gho zqe
szbysu oqrtbp wjpuv oqrtbp oqrtbp gjmqq
uoyi ctscw uoyi ggn ija
fop lxa cgwpw lyvrxbe tit fop fop kfigqnu
ldqmk rxo ajhrbc ahrcjb xqdk kdxq
ith vdrl kvaxktm grkzmon ith ywbz kmnoiz
zdoo omjo fbz dveiipw fbz
ivj mcnu tkijlq xkq lrkyit cumn sfkrk numc ezxeeoi
lcwzdi sbsdgdy olvc olvc bimubzf bimubzf
cdjd umhwh djdc cddj oxheq veazlm
gxszn zsgxn azy yaz
byvmj mjybv jvxkuy akas uxyjvk
whmkttq whgzm gwmzh pkvtljw zgmhw jasudeq
yyjri fxsj xffmna vbal ftff rwq uszym bznil rfuctp ejndv wqr
gnwzjbw dezfvq gzkhzkl ivrdvxx wfah xvivrxd qzdvfe
xnfo zqzn iaod zlcclsd onxf lpskrfk nzqz kqzr kffpwak eky
muc tafbzp nra gvzc xiu gvzc
gfnbnyj nyjbfgn eoosw yjzf
qwwls sqwwl mxph swwql
twor uzjftq twro orwt
qomjuob bqaim zvfqww cvqzm wwipc zsywb bsqkp aoj fus
nlyd gtbgox tajlzgs bgtgxo pqt
pjtmgz ulblj ussh gngagba hhtexq bjbj obe xctciay osriw obe shxri
agc ejjdtak jgq moj agc iua syhxih znavmrc iih qubj
zxwzwhm lipkqhz bbv birxsj gzg iefrjh mprsfs ofpltbl gbo srpmsf hirm
rbpgqoe kymrf uzsut gkbtd xctpg qul hirtfl
wfvg pnqhuv jayjm ftqt mbrotl aydmoc lfwlxk vpvcsi svbn bnsv
jxjxza ysl kls vmt fvgunx hketl oshgie
dfeyxv akx qagwayp qrs lnulrle rqs gbvd bvdg
aac ndptml oke edwrg aac xechxz
mpx yrb oervzb ydvkw avlt oervzb bxdqbo hzwls
dsynfk dsynfk epexzjd epexzjd zofb
vhe zxfolqk lkh fxt flzkxqo lztwkmo khl
izlthi wtokkuz ousbpxp pvr uuxueq lvbeff mfk syjq fwgnfmg yytqesm gdd
kjcg slt khz atzw twpspdx kgyk wgq hjat ntf xvhxol msvdjs
ymm arrggw mmmbvrs ist arrggw nbvvc cwyacp
kuzglex iemp iemp jsko iemp oqs dheqypr
tzztq dsxqbow qgaeo kqn dsxqbow qqzpv
ysr fctpiyn psgb gatavv zsfxoxq nynfoh qaimoj zotjk nxug syr
xvm qvr hdxyhpf cbo xmv lfv wltyjlx
hjq pohc xgqit tducggu zdqmnc xqgit tqxgi srfyzu vdikqx
msiqte ewvp bzrv cmuy gse qqayvb bzrv qehy
watdvu ametrc etlduhh vcc luehdth udavtw
jktj mkq jktj mkq
uekth ufjkmdi qzhge wzwcwk nvrodcc vrcdocn bhcvd
xumywk zwofh kuxmyw acgzsjj hfowz njnz bnklyi
hmm fexu fexu hmm
zeuoarc yoa ggff jazzd mjein yhj qwo qwo
rolkwf fcyat lwm wqqm juwkt wqqm udj tex xgps nyy pdbkkhb
gld ksl gld bnsuhqc gld rwmybj
tvyxk xgmk cri pef epf unsl yktxv
muiql ejq taetjkf ejq xzmo wmv qbtmrh hkfbch taetjkf sut
pqg icvv gpq tufd iixd duft
zekx ybbb gzml vrbwcl opfb fkrv tto cbipr
moh stkkf ynrtdf jlgb kstfk ksktf
nvysvf mdtdoq bqqvr bqqvr
dqyz mzoqtp gzhdgd symsq iwh bpwox
pkqi jgzsrah yfjxx kdp xjaf lbj gkpixnj tyvzzso qmjbo skg nlchzbk
culxfx jarwu eiwriu vwvg gvwv sgnasz
kyfsn dwc sbnoe xwpgjh nbmvec dwc qjdh mpw gefimue fvqjwt kkor
hcdcgxs fof flc hfpjy lii fihcao pxg xywei jwsq yxr
oxrcv pda oxrcv gdvojsz kmlga mixlmp hdcabsn qvoa fwt
poe joylchz humrjy cyxbqfm lyk ybrfmp qmtpqyk vtpr lyk vtpr
ffswqs yxbuj tfzkmc yxbuj giog ckubbfy rtigw rtigw rpitxd
kcvrn eejyftw ejytfew rnckv
lvk lkv cooumh vlk
loypv ukowl loypv nyoyfl vehnm uff
tst sei zovy itdwibj mcbtst wcf rzp xvbtax ffzp xieenuy aegkj
zkhi hvsbgza xbwtdns wypfngy lvabd pybhcd crczm buikdpo vqgon pynfwyg phbcdy
ihy irxrj entmc yxfhbta xsdv xsdv
ezrcv kfgm pjneez puccy gzpxdlf gkfm yucpc mli xezfug
umjppkq idkiri wmnbhi unl nteyw wmnbhi zyv idkiri shhcrau
dzj zveqwae ljnikvb baavr dhsohp zveqwae goq zveqwae
xhc xch bmttdr snd jakd
jmgnvda bdpzfw dfwpzb pimpv blqtbyo lzdzo bgrlfy anmjvdg
lwvu ksg gqbtibd ksg lwvu ohfzlt foajo apyrcwj uaro
vel qksrwp zei ipnvd hdua rkspqw bujf
iozkiu upa knmcug zidypn yswb zswkvx naqsu
tjktoe dqpt pbqi dqpt
lcl tui uoizm xrdpmwi fbsuuqq tgeac hpajm tegac nczlic
ntmm mskzb arem ntmm jayzfe wyurgsh eqwcqt edhska asxhjv jayzfe
jyq juifidx fokzxh cgo xofhzk nhro xyccuq ioa nwk nqaxpfw
cvag bpk cuo ocu buehhq tartafi ifs qwh cveurg
bwut xpfni qzg cmp cid jftawv twiszmo
zgxc sui kypkd vpam ymxicrw jcfbutd fgx jcfbutd
tkxn rjqzljh tkxn mdwcho
qbv zneocv zneocv zneocv
tywf soncr lyepx qzj xdsr pdqv swt
ulu rdk iomqu dgouoba icax
ddsc oxilqpd ddsc atbekg ouzmxf oxilqpd kwtzz yhmyd otvi
vtj llnfrpc vfighju urosrsz vurtse llnfrpc qeuo vfighju nnn smsnp tfom
updfjmz ngtgi zaitq rqqhcyn ladzx zaitq fbaphyz hipe
rii fpos atl tal qhubqdv lat
whxzwdj yznkngr eefbmub wnxitd tnwxid zja ziewilm xylwn ihhsha lrptuyf
fhmzaxv mdn udl gyv pqw qlrz flm rqtji
bgn clnm cnml qyh hhf qqnur sgvigvm
qjtbysc ycbqjts gbgvlz vgzlgb dgxks qbvp grji dcc
wmduuq qayymzo zvh ylbipw sin ybwpli ilypwb
qsvzktt qsvzktt dasmg knh gcgep qai
jxukj qlgr cjssj aavqv
xpxa glsdfxq ngxwon ytuue pizqu
fxl vegoed tct luwm ulwm eeovdg
ntmpe auasx vkwgi cryuiix dmiufo fcb ldl jauncf gyouym asjcryc
lgwdcs eoxm hcrpnuf pcfnhru vlye fpurcnh uquukv vjc
lfns riwpdh phwxvew hhu jfptvv ofxd hkotgfq
qvuwnq wnpvs xdivrfz yaenqr fipwgl
vhcexfd bishqsc gsbruxm yzccyot yjloa aptg vbr gsbruxm ihqhyz yzccyot
knfst zhihi swhhq zhihi
qfto abhjx abhjx bpnijn ogmqxn rclqag dmeb rdogx emfriui hyvp ogmqxn
ivaemm wlsc dvjv aivemm xvf shfonv
vowhosr vptlu ucrut rdynh ttqvhg rdynh abtja pnvdy puxfmf dyhd
uvrenol ycuhvy ygm fjsxiwo oftstid ygm
fix qrqeg dfgvlun fix iraxgtt lhgqdo eqkgshd jwmrm qrsbzba
mxdj icjqzqw fvew gtvlhm mxdj
cyjtkm crb pmg jwo iluc brc ttnd
dasmgp ool ool opc
ubi pmz mtkh ibu hlx ipcvjki sydw zpm eewfdeu oga
avex yjaoghv yjaoghv lwwx
kwkdst iuokd nmpw onayet zlavwnd wwvbr jtrkyku wfxx dumydgh gnd zgi
ahyjnc rjakp bhabq tsmfi ahyjnc tsmfi yitqgi uwnywil shnkbn
krr sbbfjtm yvunas hwppsjf ntuuzw ngyvdmt ynk nfq mfrb pyw hngr
eeecesf phoo ijmx sjp kgmtg sjp wyz
qwixmou oximqwu ixu lsmf
dyrzq lbstdjv ldvowml qjf fqj zpabc dwmvoll jnq
pdtlu hgcfvz mnwjyq ymi cvcp kmx mkx ooffp uiwg opoff uevqt
hflomt fhlmto gutdbyp xyi zpggxc wqe
jpsr wwex yjgdj fqah wrmmw nyrnw hcomcgv teajmu emw zrraid
tvgsca bzgzkga ypsxsk dqz exmu tvgsca dqz qnd
arzn hojpi bznw ejuupe bznw hojpi
rids dule qaefaon sspit mtzgdls cfujw xldhimi igdoy dule
nefsys plea obksngc zxqee avsi obksngc vnsxdrl gspadob avsi owmzpeh tcj
oweq fkr krf rfk ztwjdry shzcmew jhna
hdjizhg dfclic usds luz mcwyj luz qvomls mren otax
pmzzfj pmzzfj wfxyq mqv hyp lhf
dxeaw ckkey ccvawo keaf izlh oacvcw lgcpgeh kdiky
xkwe xekw kwex tzfyx
dmmyt mtdnqw pdw vdav ofrtsk
klz zlk snxnihg snhigxn zkynpd
ijzce xobf uojezxi xiuojez
ztepv zvpet nije aditjlg natkkk dtitg jprgia
fesuh wadrhc bayf kktfaf nxvhq smbdaop gqx ioez fkjufb abyf
hej sta pztkcd pesabzz szp iada iada cdae hej sqst luf
xlnuhn oljaf fljao ascxez fojal
dprclb fzn wgauz rxewtp cjrlgz zfn
fidwoa mvoqy afian ntzokap mkplgy jfukgjv cyfsz
hbvqnnt giinuzq uezugy qooxjc zsxr rnihg ipbels
qroi wtltjq suj tqit bxtc jidzhpe nizp wtltjq nadcdm wwyhjrg
qtr fkbl bpptu baen awjpwsg vvqbxz animt uqbk zvbxvq
nznq fdiul jbv umyrf yufrm hrl duilf
bkvlfuw onkqzeo iwrg rifqzhj mgroul rnor qqqc sbfi hny zosfp kopxb
nvifbx jbowbj fnyskt jbowbj xvun xvun
piyl haajm stwzpp xvjg amjah
gye efwwwiv kyv zmtcgmi ifwvwew
dflx gdtb jyoj jyoj dflx aqhycgi xffnn
inc mpys mzqmcwx vryz ibqrzc pmsy fat rojpxwy rcbqzi gjef";

        public const string Day5 = @"2
1
-1
-2
0
-1
1
-1
-7
-6
1
-4
-1
-12
-7
-3
-12
-5
-6
-13
-7
-17
-13
-11
-3
-7
-3
-2
-6
-27
-20
-15
-23
-23
-33
0
-10
-35
-29
-6
-10
-5
-20
-38
-30
-38
-12
-23
1
-4
-48
-45
-1
-30
-38
-27
-23
-53
-36
0
-3
-45
-32
-39
-32
-46
-23
-40
-10
-54
-38
-37
-44
1
-56
-11
-74
-41
-73
-34
-31
-42
-49
-75
-8
-48
-49
-82
-21
-58
-40
-75
-66
-31
-34
-35
-52
-23
-56
-58
-60
-18
-34
-50
-27
-1
-3
-6
-70
-93
-36
-15
-1
-51
0
-110
-7
-7
-56
-14
-66
-93
-56
-100
-19
-54
-79
-81
-19
-112
-13
-24
-40
-90
-8
-10
-14
-27
-62
-45
-137
-53
-53
-89
-48
-86
-139
-91
-146
-109
-52
-6
-32
-6
-113
-78
-12
-4
-113
-42
-145
-23
-64
-97
-98
-77
-155
-133
-65
-64
-59
-164
-155
-27
-65
-57
-133
-140
-95
-104
-46
-16
-139
-55
-15
-26
-63
-141
-93
-146
-51
-104
-84
-82
-87
-149
-19
-77
-154
-118
-96
-117
-96
-140
-47
-188
-158
-141
-192
-63
-58
-191
-63
-52
-135
-142
-109
-42
-134
-4
-11
-135
-13
-24
-39
-4
-183
-158
-25
-136
-35
-49
-54
-78
-18
-92
-19
-142
-40
-237
-119
-147
-198
-132
-73
-238
-106
-82
-51
-72
-9
-44
-151
-164
-35
-74
-252
-219
-40
-154
-229
-169
-130
-238
-64
-171
-174
-161
-67
-205
-160
-112
-191
1
-60
-147
0
-43
-67
-190
-256
-66
-189
-76
-86
-91
-243
-10
-142
-163
-52
-112
-162
-169
-269
-98
-188
-282
-212
-286
-28
-33
-6
-114
-89
-237
-90
-95
-202
-266
-72
-215
-50
-52
-78
-286
-32
-235
-7
-56
-194
-6
-32
-73
-48
-77
-69
-43
-279
-236
-79
-286
-105
-295
-61
-320
-130
-99
-90
-238
-294
-120
-9
-302
-327
-165
-267
-228
-250
-153
-28
-126
-187
-138
-163
-140
-26
-217
-197
-180
-338
-39
-71
-6
-56
-151
-272
-276
-246
-189
-183
-38
-249
0
-185
-8
-193
-213
-296
-3
-340
-76
-97
-87
-1
-172
-235
-38
-274
-169
-70
-162
-320
-78
-222
-69
-222
-219
-213
-313
-179
-182
-253
-135
-206
-54
-167
-101
-397
-367
-54
-143
-147
-156
-293
-144
-47
-254
-169
-307
-223
-339
-398
-414
-23
-107
-235
-302
-321
-111
-167
-345
-55
-64
-315
-266
-191
-265
-248
-426
-47
-409
-212
-212
-401
-87
-389
-146
-97
-65
-286
-447
-168
-26
-371
-153
-297
-285
-164
-215
-336
-14
-416
-278
-233
-234
-392
-113
-80
-237
-342
-85
0
-145
-75
-101
-88
-292
-285
-344
-254
-47
-310
-227
-60
-320
-102
-364
-131
-338
-17
-239
-124
-266
-380
-421
-217
-311
-287
-233
-223
-242
-16
-326
-407
-482
-470
-247
-365
-75
-278
-44
-404
-195
-348
-81
-309
-181
-176
-97
-274
-204
-485
-458
-364
-22
-89
-448
-235
-53
-50
-510
-89
-114
-158
-199
-189
-204
-528
-278
-274
-149
-208
-485
-313
-325
-246
-173
-478
-164
-153
-76
-407
-447
-109
-334
-199
-50
-361
-449
-338
-409
-66
-282
-510
-288
-380
-562
-543
-534
-500
-288
-526
-439
-142
-284
-421
-30
-243
-185
-433
-326
-102
-540
-391
-197
-580
-305
-436
-559
2
-30
-204
-97
-204
-207
-79
-329
-157
-284
-581
-182
-458
-232
-111
-352
-601
0
-245
-292
-167
-549
-456
-277
-63
-104
-493
-585
-369
-121
-122
-180
-466
-509
-405
-53
-555
-454
-549
-486
-80
-463
-385
-538
-274
-75
-90
-500
-434
-167
-142
-587
-92
-182
-95
-205
-49
-574
-352
-638
-204
-25
-375
-456
-400
-572
-37
-151
-81
2
-19
-579
-106
-344
-339
-188
-517
-12
-403
-623
-619
-429
-53
-227
-11
-548
-426
-115
-481
-425
-9
-43
-209
-145
-168
-241
-331
-521
-77
-642
-397
-37
-98
-333
-281
-162
-361
-119
-696
-440
-663
-347
-295
-692
-32
-331
-623
-275
-646
-517
-16
-193
-537
-403
-75
-607
-74
-393
-333
-665
-448
-419
-119
-213
-635
-668
-178
-46
-175
-537
-160
-467
-271
-594
-240
-262
-666
-205
-48
-319
-738
-240
-697
-685
-711
-98
-134
-28
-731
-317
-319
-288
-236
-425
-401
-625
-638
-496
-23
-751
-643
-382
-717
-269
-275
-764
-672
-758
-605
-530
-244
-526
-357
-175
-667
-282
-551
-642
-83
-116
-751
-381
-447
-266
-297
-88
-575
-246
-189
-662
-450
-91
-471
-209
-609
-151
-630
-345
-625
-743
-377
-789
-56
-370
-250
-661
-792
-560
-585
-231
-673
-725
-194
-317
-455
-234
-282
-516
-784
-2
-652
-427
-31
-755
-527
-725
-47
-606
-210
-172
-773
-819
-636
-348
-376
-700
-727
-156
-574
-414
-34
-439
-413
-604
-648
-381
-529
-82
-736
-816
-595
-352
-417
-836
-691
-660
-464
-314
-748
-698
-49
-97
-721
-294
-441
-446
-415
-187
-212
-506
-550
-131
-231
-637
-334
-853
-383
-407
-219
-518
-743
-83
-773
-162
-570
-611
-574
-355
-56
-775
-663
-131
-357
-560
-335
-390
-667
-516
-897
-752
-786
-246
-893
-693
-692
-647
-422
-361
-148
-231
-775
-62
-404
-783
-387
-559
-703
-403
-776
-588
-633
-831
-779
-23
-216
-381
-287
-517
-402
-814
-756
-646
-535
-270
-282
-157
-367
-356
-925
-333
-375
-469
-931
-347
-455
-942
-815
-311
-690
-65
-691
-64
-361
-409
-886
-488
-303
-806
-73
-653
-356
-71
-523
-370
-685
-526
-528
-519
-179
-762
-652
-388
-568
-296
-601
-822
-656
-258
-304
-670
-731
-352
-82
0
-116
-294
-652
-702
-933
-12
-348
-15
-662
-311
-695
-357
-872
-847
-791
-129
-574
-281
-42
-626
-36
-60
-864
-871
-246
-943
-500
-253
-684
-545
-1011
-330
-666
-468
-780
-596
-872
-812
-924
-836
-379
-528
-464
-99
-675
-317
-58
-641
-590
-227
-296
-303
-798
-39
-824
-300
-469
-251
-182
-40
-115
-997
-572
-743
-13
-557
-542
-832
-884
-385
-224
-932
-757
-405
-690
-745
-1008
-657
-846
-565
-508
-792
-245
-298
-793
-278";

        public const string Day7 = @"keztg (7)
uwbtawx (9)
mgyhaax (46)
fuvokrr (14) -> pnjbsm, glrua
cymmj (257) -> phyzvno, pmfprs, ozgprze, bgjngh
goilxo (80)
cumfrfc (102) -> yjivxcf, swqkqgz
yquljjj (20)
ehywag (18)
mmtyhkd (21)
paglk (98)
wtqfs (82)
oaynkf (8)
cupbfut (78)
vpcruoy (70)
wmdbo (50)
tmbtipi (48)
lkopm (9)
gluzk (18)
prvrg (76)
lkdkyk (30) -> oldwss, nadxwf
iqsztjd (181) -> hovelvz, pndcqot, naglm, oxxlsk
nxdkpuh (217) -> yhcsc, ydmeqtl
nxlhjq (306) -> hcwjxe, zixbap
vtkgj (89)
rzrzage (73)
ftegwk (284)
lircjh (23)
zosskdz (232) -> isrch, bwzvefg, dxodoee
dphcbfr (67)
pnmvk (180) -> wrabgy, vlfpuo
owmjbhg (120) -> szfxhin, czzpk, zwrfiyf
oonqts (26)
zjaqq (129) -> hopjmyt, cdwkezv
hxeoxk (33)
csaqixs (1237) -> alzipi, lhxycw, tkeuvp
avenz (7)
nnhknbl (55) -> owzwbpn, iaonkp
bxifcld (86)
neyeo (165) -> gxxzwq, fxwez
qnjpz (71)
qhxmh (61)
jmhfgr (139) -> ucuqxgm, hovhxsp
tyuhzom (80)
pqtboz (207) -> ayvns, codwosk
dqyjg (65)
nujppls (24)
mxbixyi (60)
xkzgz (85)
oxklzu (2285) -> ehwlw, fptoo, sgobq, eduwet, pqmpnzo
fuleuxt (6) -> ljzuyyk, pxydes
zktmxll (451) -> txsrez, ewjrko, drtrgwp, kiggy
qpxbow (40)
rshpnha (36)
pqmpnzo (1374) -> hpltoci, oxvwr, vrxeemw
wdazzdu (54)
kivcyus (53)
cvvncju (10)
dtkuik (36)
opkvs (64)
kwjnfg (28)
suoiohi (197) -> gluzk, fdhdpw
jkaxk (98)
zsoro (12)
fqvtm (15)
nqktjw (14)
cbhkkx (116) -> wrprrev, vyoxx
rmqdolg (55)
mdkes (95)
obxansb (343) -> uzyprc, uxaqq
pjitmnv (31)
vdkrvi (73)
nystxqv (35)
odgzsnk (73)
hehbbo (83)
zrthre (30)
zwoot (9)
mfawmsq (92)
sckaqs (1141) -> qpaei, cbhkkx, qezwkkx
vxfci (60) -> tdecuga, wssvxr, pchccgz, ypogtw
vauwilt (78)
qxkas (24) -> mzgyj, xappjar, cgbgm, muarkn
eqibqs (20)
wuefg (549) -> pwwyeqx, ylidl, qwbfod, mqztoa
jmchsu (77)
dinng (30)
nlpmbrd (37) -> fnzjtvw, qzjyi
yjivxcf (19)
yhjopn (34)
hqxdyv (17568) -> apktiv, ybekxtf, etoxfc
wvivxrz (82)
wszqat (85) -> eddmyv, edkwqih, mxbixyi
xcldsl (78)
rnbzlx (35)
hibxz (94) -> zgzsu, vzgsgk
rgyco (21)
lmvvs (22)
nezny (13)
tpcvq (251)
puxgb (15)
merrako (8)
nzweur (431) -> rfouw, sukktk, rreqg, fmpcnql
pwwyeqx (100) -> fmjhlia, yquljjj
lccoo (27) -> bmlid, prvrg
dudxud (202)
cmnzh (49)
nitvw (8)
dcakuo (21)
nnbty (81)
kjlxeat (318) -> nmhww, zacsvwk
frinpfj (88) -> lwfoqny, tdgel
zgqsgm (38) -> phdcpp, qwcrc
bvikij (91) -> obxansb, bizbsjd, usggwvu, zrhny, svngfr
dnycw (219) -> sibzrx, hdgvs, wnfqg
youpfn (38)
zixbap (47)
mpwldri (55)
rfqenw (80)
tjtzx (78)
zbfut (55)
eruxzoi (63)
nandmg (344) -> qpqplm, zrthre
bizbsjd (159) -> piecd, ghkdvw, caurb
jpkwter (19) -> mcjgfx, ujsbt
uwpbnv (83)
devljb (45)
euzztul (30)
frmbrb (1660) -> norkse, iitweo, mebwy, sckaqs, xdrge
duccgc (15)
bmlid (76)
clwwv (238) -> jofvyvx, zgjoaiw
llmmm (69) -> wvivxrz, pikvdx
rstdh (21)
afckjn (51)
ojqia (22)
qtlzten (155) -> fjgsw, uujpt
eqxgwfz (40)
ljwsi (20)
vuxbzm (48)
qzuwt (130) -> qnrjqj, bjdtdn
lnnwiq (20)
pbxpdo (281) -> vabmsx, kwjnfg
bfcdy (31)
ykpsfj (28)
uegcs (210)
qezwkkx (74) -> gquil, stfzaxc
jkvduo (44)
vtylgti (66) -> twgbxu, uukshmq, rlvggmr, aynpr
eyyokyd (28)
nrbcaqo (45)
caocs (35)
cfdpxpm (207) -> jhwmc, nezny
qwjmobb (28425) -> ohusizx, gqoxv, xatjlb
akniuo (129) -> zpczji, tugrmnp
kravhjd (17)
wtbwbpz (43) -> kybegv, qxhda
hovelvz (31)
jhwmc (13)
wctze (102) -> qwdhdrk, znooxvq, vhrxl, zfhkfwn
nmhww (43)
fqufwq (58)
zyxjg (81)
eltbyz (61)
ehtsbv (783) -> upaqlj, cckqr, pgprg, ubksf
zbrbb (12)
vjgvk (28)
mqulwk (15)
kywmnbd (404)
wcuvk (20)
ymfls (75)
spxwcuv (173) -> iobcvl, xwfbb, wxpauwt
eumzi (24)
kqoigs (53) -> krfgye, oxklzu, pinipk, ojatf, memkrd
alneqju (77)
joczsir (313) -> xwkoc, atkmjxg, gurxxfd, axxkh, jmpknjs
uwzvy (35)
xqxyx (386) -> avenz, keztg
erylwj (804) -> wdsbi, ugrhs, fzmaw
corfkob (87)
sibzrx (67) -> pqccp, audeogd
crrfxfn (38)
piecd (72)
bxefs (22)
lnufi (93)
qifuph (44)
uqccsbh (26)
jaqwzi (79) -> zkgoa, juymjz
nivpffu (169) -> tnccv, lfqca, sgfco, nnbbrbf, egsgwch
dfrkf (49)
cdrhm (56)
vaylgz (80)
ayvns (23)
mdddafe (56)
fpldxlq (195) -> gjnnmvb, ljwsi
eygaz (427) -> ascyv, kmjfxcf, puxgb
ymeelep (92)
iuzvl (23)
tkjeu (41)
xdlyd (75) -> cymmj, pbxpdo, vmjbgo, cwttq
jsltf (39)
ciojx (146) -> ioobamp, ahrfot
eqmeu (211) -> anrjxof, nepxnu, mwpbyo, rbzqabo
bogvr (202) -> zghrr, bompiu
jefztzv (91)
fvikm (80) -> zepvwyv, oonqts
zdqcu (194) -> ucbuez, nqktjw
pdvolf (75)
mkmci (40) -> ggaxx, xvzlrw
sqmfis (35)
chrqi (74)
tvgytpm (49)
bjoyw (29)
nkfvkp (62)
xbtswv (7446) -> iehfo, xcrkb, qksclw
qomxhp (721) -> agufw, djgzb, jxbksoh, twnfzz, ucxgom
ibmiu (9)
atmzoso (6) -> drosj, wcrrrlf
fuqvw (56)
jfaca (49)
yulga (213)
dxodoee (7)
gethyvd (39)
hjxcpi (30)
jlcgqt (55)
lzouo (144) -> ubjgijo, rnbzlx
djyxrkb (78)
bscpyic (61) -> nktmu, sqpdsk
sxmdnhl (31)
qbdafi (25)
vwbxg (35)
rlvggmr (63)
kiggy (27) -> pgsokae, ottiad, eruxzoi, zhttn
ocpngbz (73) -> hqzay, ewzryd, ipjbc, xjnhqlg
movmxq (216) -> kfxhl, ulpkj
mzgyj (85)
orwbdwn (52)
ixyqeq (6735) -> xgwjcx, nkkgyl, sykwd
htsjndf (211)
ndhsa (82)
jmpknjs (80) -> gdrcfwr, wgivp
hieel (65)
htdwe (25)
qrfuvjh (9)
ubjgijo (35)
vobnpuq (32)
elgyjo (141) -> ineoncq, pfdmmg
zsnge (71)
zbwxa (28)
ogczchc (31)
njdpm (53)
cpsce (84)
ftdylco (19)
zrwfi (22)
hyfuy (252) -> pmscqw, ecaph
nayudfl (320) -> ssvsso, zrwfi
kykfb (72) -> euzztul, vxrtejs
ggpjxwv (9)
aostqf (29)
zujltb (13) -> hatvlca, ppmrgga, cjoya, bogvr, gtbpbl, ocwkc, qzuwt
ajbtn (18)
fzmaw (20) -> qjixqo, fkhxkeg, uqccsbh
akmbqb (108) -> kqkzsm, grgsn
slrdn (55)
nrjwctg (96)
norkse (661) -> jmhfgr, anwxvv, ptwhbm, znubct, djrrc, hgmjvpp
bwzvefg (7)
peuadz (8)
kvmqsdx (308) -> zvtoom, twvdhg
bvnjiou (32)
lnwuqu (159) -> yeqnq, fqvtm
pksfx (54)
xatua (97)
tbrznk (37)
ucuqxgm (31)
hwjhf (78)
pinipk (7229) -> pqewl, zujltb, kfcowx
yyhzd (12) -> kvqspmf, dtkuik, wsvir
imyvlyt (38)
oldwss (96)
paegovu (86)
knjlz (83)
oevbo (23)
yeucm (98)
usvkq (56)
hatvlca (69) -> gpogy, eyrfvtl, subwna
qkhtsa (208) -> pyxgmtu, pqgpuv, pudnxf, dilqo, juqbdco, flufot, fzdyvo
gzvjxk (1397) -> wctze, zoijv, fuleuxt
bkwcwf (326) -> jazkpl, kfcgv, qpjctjw
vqghhbs (157) -> lsrvhoi, livmxo
fzdyvo (186) -> gwfrqr, tcgffi
rqkfkxw (47)
bntdh (76)
rfmiqz (158) -> omlwg, uhwvnbg
zorvsm (50)
edzgraw (83)
iwsknb (345) -> qhqnfsp, vrwkr
vyoxx (63)
livmxo (27)
foabep (92)
dbuccip (28)
oojme (73) -> ugkxkqe, keucu, zjqeu
cmmqbz (29868) -> frmbrb, ixyqeq, njatvu
syjvwzt (6039) -> bigkiu, wjipa, pmbnia
uxaqq (16)
vboha (79)
irsfgz (94)
lsrvhoi (27)
zdtvktq (99) -> ezrix, lyhfj
hgbkwjv (32)
inxivh (261) -> mzzxjcu, rkaxx
nfrtom (44)
xhzylb (97)
nuxqskl (39)
qhfxqrr (65)
foaayon (78)
rhtdtxv (234) -> rplxsw, fjqomax
kppxrk (73)
qjixqo (26)
sgngx (75)
ycsbsyn (87) -> gmeueu, wdhmsi, zrqqtx
kqkzsm (61)
irjvpam (39) -> ajozeez, xxlbk, nfwlplx
ldfofo (84)
mygcpku (84)
caurb (72)
gpysit (22)
gxfij (171) -> sxnsqj, ksxixz
mxbyg (39)
jlshk (29)
havdbe (132) -> dqyjg, wvdapsm
ocwkc (86) -> dtzws, fleszz
rqrtz (83)
eddmyv (60)
ecaph (56)
ebgsk (60) -> rshpnha, puexzf
lymsa (44) -> qcyypa, vbdcxx
mozvs (54) -> dfrkf, cmnzh
kpghxz (17)
wrpqf (83)
dzjsx (57)
vrzbmt (14)
dryngd (29) -> shawokt, elkflt, tjtzx, auiiuv
ittmm (28)
zqurr (284) -> fqufwq, htsuyvw
ktejrze (69)
pudnxf (192) -> aostqf, szwpt
tqjlm (74)
codwosk (23)
pmscqw (56)
cmcto (441)
edoycls (93) -> vvnzr, imnvt, vuxbzm, rhzco
zrhny (177) -> dcwfs, dppwsec
vffew (46)
hcwjxe (47)
dinlw (342) -> zzjuf, lnwuqu, gxfij, kmqurp
lgtpaqk (75)
fluwt (65)
syuoewb (288) -> uwbtawx, avjkgl, nkycb
anrjxof (6)
vrwkr (5)
pngubp (76)
vvnhe (89)
rnlaw (45) -> wszqat, ptizsk, mofyda, ttolm, velktz, nzsnkla, hhdzz
nadxwf (96)
sxpan (31)
gdrcfwr (71)
vabmsx (28)
tsiyp (52)
fptoo (1398) -> gintpbf, cklkizf, kjgtfqc
obxrn (756) -> yyhzd, afatio, uqjge
znkchkk (50)
hvapnf (121) -> siruccf, tgpxvyr
htsuyvw (58)
yifny (122) -> dcakuo, xhtzti
uvvqcxz (79)
suiyl (773) -> hjfwn, thknml, gkijw
shawokt (78)
ezdiq (37)
khrqmbo (9)
gkjbikb (79) -> nrjwctg, iamrpx
ysskib (76)
zufoz (93) -> smrvw, kkkjsil
uusiaqf (84)
cjxyt (69) -> deczzuu, ymeelep
gcefq (33)
tgebda (247) -> ngthpc, bnvlsm, afckjn
ljmve (55)
rqdcuf (144) -> xzxvwzf, bjoyw
sjxaxv (76)
jiybx (88)
wxpauwt (20)
clsbdm (10)
fmpcnql (56) -> rjvfwcu, xjjdapk, nwtlu
hchmn (258) -> bremy, vpcruoy
labnsw (157) -> wnwsbdq, jqjkgv
hvpcvdf (95)
xatjlb (40) -> aiunbee, keoaqjb, jxkofob, plbtdq
dflvw (86)
vmcgj (233)
jxwyzy (13)
mebwy (1107) -> uegez, dpiyhv, vdzuw, icpwoof
btqebbp (156)
mmvszxj (71)
gpysm (85)
dppwsec (99)
iodveqh (89)
xcycu (116) -> dnkiyf, njdpm
ijictm (38)
ineay (19)
hvdpzbv (73)
cckqr (148) -> rqhfhc, jcyciyq, jbqvpsb, uapwikr
opowpvm (265) -> aewie, phrume
ptwhbm (69) -> omzlzx, suxpc
bpdixmv (83)
mzlmr (43)
ezrix (79)
jovly (61)
audeogd (99)
hjfwn (168) -> wtqfs, uamje
wdhbym (184) -> pksfx, bgahvfu, krlep, pkmmfc
nmmtdv (83)
uftwml (50)
ycyyvdy (17)
dqdpop (53) -> ggllv, zatwq
egqmgr (37)
txsrez (99) -> iiznokx, dobmve
lqmdutk (25)
mfecx (33)
kldww (23)
dxbxha (135) -> uvswv, ydmrd
xmvdh (41)
ctinwus (96)
arkedwb (237) -> qsvckew, merrako
iaonkp (89)
uthjdye (124) -> awoedy, wuisqnk, qsfpaj
yzbccbx (36) -> fxemb, osryil, nkfvkp
xvlymgg (33)
wbbaxr (10)
wcrrrlf (98)
bclse (38) -> slgjon, tzltv
krzjli (33)
dnkiyf (53)
cklkizf (219)
pqccp (99)
bgahvfu (54)
gotqku (33)
vregap (88)
qjcqm (138) -> vdkrvi, qoijc
phocd (23)
lerycoe (84)
aidbql (35)
qwvmczr (187) -> youpfn, kkukqoj
achhc (30)
qxnkp (68)
znkzp (94) -> otpnx, drtxytc, ntonira, zyxjg
ewzryd (92)
xxssj (168) -> nhnrpz, rzwfp
lnaoiv (70) -> awqat, dnaoe, qombesj, eygaz
qzjyi (88)
aevhbim (49)
jeuzbj (44)
msskvkg (60)
douvhy (133) -> mqulwk, nnkmf
qrfgzm (552) -> lrtds, yrpat, tvjwhhy, atmzoso, dudxud, rqdcuf, xxssj
alankuj (75)
juymjz (77)
gcqaj (69)
ozwpmzc (43) -> bknogxz, ldfofo
gintpbf (59) -> byckty, tagyci
yrhid (222) -> phocd, wtzkvm, kldww, xugyewm
keucu (15) -> kwozg, xfmxo, rwepl
zicelk (67)
xwwxswj (40) -> frnhsjr, mmvszxj, qsmvtif
lcfyznt (151) -> klmvmt, bgmmb
ehwlw (55) -> tgebda, ehypcwy, xqxyx, vxfci, nxlhjq
uegez (150) -> rnjfcg, tusgzei
pjaxkr (92)
mdprv (179) -> paanydj, vtaejs
avjkgl (9)
sshfxeu (11) -> goilxo, ltichp
alzipi (53) -> cpsce, ezspcab
wxoqoa (100) -> mfvul, pwatre
trmwq (10)
ltmwbs (33)
kmdzlmk (235) -> mzauq, ycsbsyn, srqclhj, shhfy, xcycu, zsnatp
dfjvh (61)
zknesz (39)
ezglz (289) -> kyjgf, oaynkf
pqixzdw (128) -> nvvca, cwxgqrk, duccgc, sbnsoxi
zpczji (60)
rathd (135) -> rsbune, wmdbo, uftwml
pchccgz (85)
rzwfp (17)
umgzhmp (150) -> eqibqs, rwgpi, wcuvk
ouqtjz (127) -> ejkei, sdgdv
sstvew (52)
qxhda (96)
cvstod (96)
rbyiay (94)
vwzmkq (63) -> vhjcue, nnbty
dtzws (83)
nyepy (363) -> jsltf, nuxqskl
iiwkm (84) -> fluwt, clcixal
ucezr (10)
zvtoom (55)
fleszz (83)
hdtcizc (9)
wzatr (57)
teqswj (40) -> advhon, qhfxqrr, hieel
usuaiv (45)
eygdy (86) -> pqtboz, kmodn, dqklqo, tukyh
janrdqf (81)
jjukf (723) -> vqghhbs, ozwpmzc, htsjndf, wsupp
udmez (91)
lsvqox (1205) -> tpcvq, fvqvgw, jusfet
zjymq (33)
wuisqnk (34)
pxydes (62)
qegmu (84) -> hzcanxq, xfbosce, glyxk, fvlmvtk, akmbqb, lymsa, fbrwdf
mckrfxj (38)
keylghg (60)
dqwdx (215) -> hseaxj, ubxke
fzjgh (179) -> bafdzbu, uanvh
qsvckew (8)
pvhrim (52)
mzauq (98) -> sxpan, pjitmnv, ogczchc, aruczxj
nxwjvx (53)
agufw (229) -> wbbaxr, knrgg
urpnw (47) -> khtjh, dflvw, otxphme
klmvmt (17)
skgwztg (233)
ghaxvq (9)
sgobq (60) -> lsspa, srgmt, wofung, rathd, joaed, fzjgh, pbkfd
qaveutv (44)
dnaoe (80) -> vohepl, mymke, paglk, pahwxj
edgdvfa (23)
mrfmn (94)
hovhxsp (31)
hqlyg (47) -> aidbql, tfhij, krvyy
zuybvj (32)
kquxfy (1294) -> srcyajr, neako, vtuqq
htsuvhg (253)
tagyci (80)
ldnnoag (35)
qkougo (76)
fvmhrf (38)
spvcd (84)
tcbpqu (70)
yzxqp (76)
ihmqs (66) -> oydsj, qheany
neako (48) -> panao, fcufg
dkgmsse (18)
zupym (33)
pwumvgy (80)
ognax (83)
oxvwr (203) -> wixlvcp, wqgcqb
ysltqk (65) -> mrfmn, hrjgbc
dtqzu (61) -> tgnqn, corfkob
vmhwy (177) -> yaudo, eqxgwfz
pwatre (16)
uijtrw (247) -> cbdczg, idjhk
stfzaxc (84)
refya (15)
xfbosce (188) -> rstdh, nqzwt
kbrxrks (56)
fplihc (88)
fkoqh (251) -> ohvifiy, npckah
lwfoqny (61)
paanydj (39)
xzxvwzf (29)
bpebim (180) -> vvnohc, jlyaty, kixaco
aiunbee (1214) -> fpldxlq, eqmeu, teqswj, ngtkzm, yndyrey, wtbwbpz, eoqtf
wrdgs (220)
oxxlsk (31)
atlrd (269) -> dgszhd, dkgmsse
svtwviu (69) -> iiwkm, ieuwo, carbhvi, lzouo, cklpcr, fkkzg, ouubjrl
mfvul (16)
ndpwgdy (36)
rhzco (48)
nzetqt (8)
xvzlrw (87)
utsob (14)
rsbune (50)
tcgffi (32)
cwttq (9) -> mughfl, ponlfyf, tuyyte, ndhsa
wejvpzr (29)
ozgprze (20)
eemnlc (83)
omlwg (28)
hpmuqvl (37) -> gawck, yeucm
ohusizx (9151) -> fsokbvd, oojme, bonjgrt
mqllnxu (206)
cnqrxk (38)
qpjctjw (32)
wttpvzh (23)
tgnqn (87)
eyrfvtl (61)
mzzxjcu (27)
velktz (145) -> dxzlkz, keylghg
hvdhkw (210)
zafde (41)
qmwvc (558) -> hibxz, xqbvg, bgjzy, mvswhtp
knrgg (10)
xrbuyn (38)
wsupp (35) -> ecgpjx, jiybx
krlep (54)
gvajgxp (40)
yaudo (40)
prdkf (96) -> chrqi, tqjlm
suxpc (66)
pnmfw (51)
jldaz (64)
rucse (85)
ivcedgz (46)
zytvsav (21)
tytka (53)
pfdmmg (11)
hmumqsz (47)
cncicpd (93)
rrixk (27)
uzyprc (16)
ljctbd (13)
llgoq (76) -> rgwpu, movmxq, hvifpbk, hiiqp, kszkv, bjtza, hfttss
gqoxv (1646) -> bvikij, dcqpq, kquxfy, qrfgzm, qomxhp
apktiv (8441) -> obxrn, kqaksir, itjrw, supnaxw, wuefg, twtcx
nicjj (56)
nzmaui (18) -> wmxobe, eipmjyb, jovly, tjblqzk
ezspcab (84)
bclrfac (31)
jrcng (318)
pbkfd (157) -> pcdvdp, jldaz
vmqlqrp (46)
ynvqpm (92)
rnjfcg (20)
qhqnfsp (5)
ajozeez (92)
shciqu (127) -> ehywag, ajbtn
uujpt (29)
znooxvq (7)
mwblvo (257) -> ixmfiwz, jlcgqt, rmqdolg
rrazh (233) -> clsbdm, uavnq
ipjbc (92)
jovkydi (89)
rkfsa (102) -> pestqep, vnvkvb
owzwbpn (89)
cragbdx (19)
vtpldh (19)
rplxsw (82)
cbvamfw (47) -> wdnebh, vpqqbz
vhrxl (7)
cqvyvl (122) -> eemnlc, hehbbo
nmxmtaa (188) -> bvahtih, asklr
kfcgv (32)
pztxq (339) -> pqbar, bclrfac
gwfrqr (32)
dcqpq (1411) -> dqdpop, gtrgqb, lcfyznt
ksxixz (9)
itjrw (9) -> jjjpzm, mhofo, znljf, wrdgs, dcknzvh
omwrb (859) -> pqixzdw, hoqtxuf, weenw
rwgpi (20)
xoqxg (73)
rdyda (5)
dolng (83)
osvmh (77)
pqewl (185) -> hchmn, rhtdtxv, xzgejmu, fumvuu
dcknzvh (138) -> pdviq, hnpndnp
vjmwqzj (35)
zhttn (63)
lyuys (284) -> zicelk, joernlg
jjjpzm (164) -> vjgvk, yaiinhu
siruccf (37)
tzkuvl (87)
jpbiodh (10)
jodrf (56) -> lktgac, ysskib, qkougo
egvza (251) -> gotqku, viqlepb
jdpcmb (6)
ejlgch (133) -> mmoea, vvbcb
ecgpjx (88)
pdviq (41)
igqvq (288)
pndcqot (31)
kmjfxcf (15)
rqhfhc (12)
cgbgm (85)
jjmfi (33)
vpizq (37)
zynpfpv (73)
vnyllno (37)
sfyad (69)
sooqm (69)
dxdltnx (80) -> xtexo, ohpvt, acjtzxw, pnmfw
gcmpmnt (166) -> stqwvs, xmgkswu
jwgrqmj (44)
gcksx (73)
uswphji (1472) -> nzweur, pocxcw, xdlyd, joczsir, kymbpe, rhwgdsv, omwrb
lhifvp (49)
sgfco (305)
wqgcqb (12)
rgjxp (116) -> nujppls, eumzi
omzlzx (66)
jeplz (96) -> gpysit, gzmagb
bgjzy (78) -> ibmiu, ghaxvq, lkopm, khrqmbo
kvqsn (69) -> bpdixmv, knjlz, nmmtdv, edzgraw
ugkuxzz (314)
pryjaeo (21)
jzpwsg (78) -> paegovu, bxifcld, oijrg, wyftg
flufot (182) -> ftoskhn, afzlar
cmqaaw (83)
fvqvgw (26) -> ymfls, lgtpaqk, cumus
gurxxfd (46) -> qaveutv, bwtusip, jeuzbj, qifuph
jqtlcm (380) -> njeahp, sfyoyp
bywpbd (215) -> qrfuvjh, nrczybn
pcpnk (28)
pnjbsm (69)
lhxycw (161) -> achhc, ttwnws
qczhlyf (14)
sldytqh (49)
fmjhlia (20)
soqvass (53)
qptfj (21)
izuebwg (37)
iaafo (1335) -> iggtk, gkjbikb, gcvpqk
bkzdepq (56)
nqzwt (21)
frnhsjr (71)
nfwlplx (92)
egsgwch (279) -> jxwyzy, sbnot
ntonira (81)
ahrfot (9)
zjbiqnt (54)
tpozmfd (27)
jopepd (27)
kkukqoj (38)
panao (88)
szsntp (88) -> uvvqcxz, vboha, xgzexud, aaqcpt
lfqca (65) -> kieka, rfqenw, srbuc
ttwnws (30)
iobcvl (20)
gmeueu (45)
jazkpl (32)
carbhvi (118) -> vxrzo, ujlhns
jlyaty (11)
jwbxyd (75)
mlmzsqc (78)
sqpdsk (86)
gkijw (268) -> hgbkwjv, stmzb
sebxl (52)
anwxvv (59) -> qnjpz, kbibi
cylfwm (81)
sbnot (13)
cdcnp (5)
sohzsx (80)
gfmgl (47)
cbdczg (47)
uamje (82)
phrume (20)
jhpijl (185) -> mojjl, yhjopn
czzpk (17)
mwpdil (37)
lizssx (47)
otxphme (86)
vvnohc (11)
xmusk (10)
pqgpuv (210) -> lnnwiq, qqosg
iqumjrz (19)
khtjh (86)
sqfgpm (41)
qpqplm (30)
pqlav (8)
nzhprt (93) -> sohzsx, vaylgz
iehfo (624) -> fcsfrg, cbvamfw, dtqzu
vhfwgvx (83)
tbkhho (97)
uqymxu (58) -> egqmgr, izuebwg
xzgejmu (188) -> cwiwn, vtadj, tcbpqu
gjnnmvb (20)
ppmlbky (544) -> kvqsn, kcgui, chetpy, pztxq
jqqojdl (33)
qksclw (69) -> inxivh, dxbxha, irjvpam, syuoewb
axxkh (222)
tnccv (259) -> wttpvzh, edgdvfa
cumus (75)
jxkofob (1875) -> mrizfl, zgqsgm, bclse, ciojx, rgjxp, yifny
uydtye (8)
tuyyte (82)
twgbxu (63)
ulpkj (40)
lunefek (35)
pestqep (60)
kvxnjmq (25)
siitl (61)
chutuh (13)
gtjbuae (71)
fbrwdf (17) -> jzjrtvd, gtjbuae, zsnge
tukyh (71) -> ggzym, rfvehkx
xqpffoe (68) -> elthna, mwpdil, vpizq
iepmwr (176) -> irsfgz, rbyiay
lntikva (47)
kmodn (253)
ufsmed (81)
psrqv (54)
xluwv (30)
qombesj (380) -> rdghpyb, ivcedgz
shhfy (76) -> zynpfpv, kppxrk
fvlmvtk (130) -> ilpuzq, jzndr
gdqtqg (155) -> lhifvp, jfaca
osgjrb (69)
uqjge (88) -> nzetqt, nitvw, wxemcge, uydtye
ppafb (30)
opduu (38)
fpank (10)
sngnjdu (15)
ndidblx (52)
asklr (19)
wmxobe (61)
vvnzr (48)
usggwvu (375)
sukktk (202) -> oevbo, sitjrw
mqztoa (26) -> dzjsx, wzatr
kfxhl (40)
jsjexer (258) -> ljctbd, chutuh
bremy (70)
xugyewm (23)
djrrc (39) -> egcat, wdazzdu, zjbiqnt
juqbdco (144) -> vggsia, tytka
rfouw (28) -> yxzzaaq, zbfut, mpwldri, ljmve
svngfr (83) -> odgzsnk, rzrzage, lbzddgt, hvdpzbv
viqlepb (33)
pgsokae (63)
cobwyky (76)
zgjoaiw (25)
ohvifiy (6)
simmjy (65) -> mlksi, mfawmsq
zrqqtx (45)
yrpat (120) -> zlkzyr, zafde
nevkec (53)
gvxhl (125) -> liymk, psrqv
ohpvt (51)
kmqurp (155) -> ycyyvdy, slmxb
acrsmhw (99) -> cncicpd, tiwakam
yrdsj (149) -> mmtyhkd, omshqjl, pryjaeo, zytvsav
pahwxj (98)
nhnrpz (17)
mfzvywf (14)
fhphiyb (45183) -> ixktgj, zfzum, yzyzmzw
eduwet (1794) -> tzkuvl, jcmte, rndomrv
akrgqe (74)
bzjctqm (115) -> dphcbfr, sauzcee
xqbvg (104) -> cdcnp, wixfh
ljzuyyk (62)
egusv (173) -> qpxbow, gvajgxp
grmhpg (75)
gtbpbl (252)
fkdukrv (331) -> zbrbb, zsoro
aondpve (53)
vgsnxlm (23)
hcptw (44)
zkgoa (77)
dasyq (66)
skumcr (55)
afatio (30) -> hjxcpi, qmddtb, ppafb
ioobamp (9)
wrprrev (63)
nrczybn (9)
hoxdnl (32)
ndcfy (19)
tdecuga (85)
ugqqv (70) -> akrgqe, aeawrmy, ozjbwv
ravjm (83)
tsizsce (52)
uyopxvt (56)
djgzb (79) -> gpysm, rucse
ozbfh (64)
rwepl (73)
vkfrqct (56)
mansh (22)
bnsivw (336) -> vobnpuq, hoxdnl
omshqjl (21)
lktgac (76)
hgrua (66)
vrxeemw (49) -> vvnhe, nyejrrv
ydfajlk (88) -> qgjqyh, alneqju, jmchsu
ewjrko (167) -> kbrxrks, cygdj
oeftx (49) -> bpebim, sdbmop, nlpmbrd, yulga, qtlzten, hidrx
ypogtw (85)
eoqtf (97) -> ktejrze, osgjrb
cbbcj (46)
dvlyc (16) -> arkedwb, nzhprt, zjaqq, cjxyt, gdqtqg, jhpijl, egusv
tvjwhhy (120) -> tkjeu, vaeuo
cahxjyq (52)
muarkn (85)
zzjuf (95) -> rqkfkxw, lizssx
cygdj (56)
vlagh (5)
vohepl (98)
pgprg (152) -> jqdmk, bxefs
yrwyc (5) -> ocpngbz, ybfew, nyepy, cmcto
asfqik (180) -> orcyokv, tuyzi
jcyciyq (12)
twnfzz (149) -> vbateme, olydb
jofvyvx (25)
tazfdb (43)
jcmte (87)
ttolm (173) -> vmqlqrp, vffew
fndeqk (27)
xydxd (56)
elthna (37)
uspimc (85)
zatwq (66)
mwpbyo (6)
joaed (205) -> ycxlhqo, mgzox, nmemj, ljmkz
vtadj (70)
ilpuzq (50)
ubksf (106) -> nrbcaqo, shnrfq
mmnejdx (10)
srqclhj (90) -> jqqojdl, krzjli, ltmwbs, mtrnyd
rpegyn (23)
nzsnkla (265)
zfhkfwn (7)
hrjgbc (94)
stqwvs (28)
etkdg (38)
fumvuu (86) -> xcldsl, memrqz, ryfse, vauwilt
uavnq (10)
yaiinhu (28)
mlksi (92)
oyguh (32) -> ipxkky, lqmdutk, hrtgwt, kvxnjmq
ceeem (25)
pqbar (31)
aeawrmy (74)
fcufg (88)
hjnhdkp (27)
xmxzvhr (14) -> cvstod, jxcnmmo
mketjaw (45)
srbuc (80)
qqosg (20)
ynrctr (140)
kbibi (71)
lalfu (50)
iamrpx (96)
xgfsqq (309) -> qwvmczr, ladcna, fkoqh
dobmve (90)
nvvca (15)
vtaejs (39)
xgzexud (79)
tmvkuob (15)
foxjx (60)
ladcna (97) -> hbdwzm, cmqaaw
klnew (68)
vtdwe (37)
eayhoi (58) -> tvgytpm, pvlirjn
nccoxir (52)
wibfie (90) -> uqymxu, oyguh, wxoqoa, alomcle, fvikm, kykfb, ebgsk
yhcsc (34)
ptzbutd (38)
xmgkswu (28)
ajhio (301) -> jjmfi, mfecx, zjymq
lasluxv (87) -> etkdg, mckrfxj
msyvug (76)
weenw (188)
drtrgwp (185) -> hmumqsz, lntikva
gyojd (214)
zwrfiyf (17)
gquil (84)
erghvss (45)
mqmgirb (251) -> buffpzu, qpwiok
xaali (31)
clcixal (65)
pyxgmtu (169) -> hjnhdkp, jopepd, fndeqk
grgsn (61)
finkdao (78)
njeahp (10)
hidrx (175) -> ineay, vtpldh
qcyypa (93)
gnwlorj (48)
xjjdapk (64)
vxrtejs (30)
uukshmq (63)
hzcanxq (214) -> peuadz, pqlav
ptizsk (10) -> cbirs, syurke, ihpmp
cjoya (196) -> pcpnk, dbuccip
qpaei (86) -> djyxrkb, cupbfut
tjblqzk (61)
xjnhqlg (92)
qscpjx (39)
xptjtlm (108) -> utsob, lmxnloe, vrzbmt
rgwpu (161) -> xjuoid, oszlto, mketjaw
erdxj (299) -> mdprv, zdtvktq, labnsw, vmhwy
stmzb (32)
vxjjxhz (49)
xxlbk (92)
fxwez (7)
hbdwzm (83)
bjdtdn (61)
wnfqg (99) -> ravjm, dolng
sauzcee (67)
nkfrt (98)
rfvehkx (91)
fnzjtvw (88)
wdhmsi (45)
slmxb (17)
dkoxq (128) -> hvpcvdf, mdkes
qheany (80)
lpziczm (229) -> xydxd, fuqvw
gzmagb (22)
bgjngh (20)
krfgye (51) -> gzvjxk, dvlyc, niwzp, olqbic, iaixlte, tycqst, kfqrgj
dcwfs (99)
ixktgj (955) -> eabhh, iqvhov, lemnz
mbtsi (300) -> gbixdw, lalfu
dqklqo (57) -> jkaxk, nkfrt
qwsan (44)
iggtk (235) -> gyuyb, cjjbqxl
ascyv (15)
gtrgqb (17) -> coaznz, spvcd
awoedy (34)
mtrnyd (33)
wofung (133) -> ptzbutd, jlpxjeo, cnqrxk, crrfxfn
dpiyhv (86) -> tsizsce, gfdyf
surri (214)
tusgzei (20)
kzcyjtb (78) -> sqmfis, ppfmc, ldnnoag
memrqz (78)
javiioo (87) -> gnwlorj, tmbtipi
dzqrtc (206) -> zbwxa, ykpsfj
jtpgzp (31)
yndyrey (189) -> iuzvl, poinih
hkazlkt (235) -> adxeaf, rkfsa, yzbccbx, lkdkyk, gcmpmnt, zdqcu
bjqkaya (78) -> szsntp, nandmg, kjlxeat, kywmnbd
guywt (55)
qwcrc (63)
asdlfku (80)
vhjcue (81)
hiiqp (148) -> lhvyfsb, dltungt, tbrznk, vnyllno
deczzuu (92)
mymke (98)
subwna (61)
kmcad (1022) -> bzjctqm, akniuo, simmjy
uufxdt (328) -> hyfuy, iepmwr, asfqik, qxkas, nayudfl
ejkei (89)
afzlar (34)
buffpzu (33)
kyjgf (8)
bigkiu (748) -> uegcs, umgzhmp, frinpfj, nurclfr, hvdhkw
ryfse (78)
olztzl (25)
tgkbxa (33)
nktmu (86)
zlkzyr (41)
pmgwwzy (191) -> rgyco, qptfj
jfmts (56)
zacsvwk (43)
znljf (175) -> refya, tmvkuob, sngnjdu
kwozg (73)
eklqi (90)
cdwkezv (62)
ugmlsij (121) -> kpghxz, kravhjd
awqat (372) -> fdmbkt, znkchkk
ydgzjs (110) -> ymyzead, yzxqp
tugrmnp (60)
fmarl (5688) -> xbtswv, jvqwi, slgiv, uswphji, syjvwzt
memkrd (7478) -> nivpffu, bjqkaya, qegmu
jvfmwp (27)
qhqyt (66)
lbzddgt (73)
qsmvtif (71)
ytmpzku (49) -> jwgrqmj, nfrtom, lfiqwye, jkvduo
tdgel (61)
shnrfq (45)
hhrqz (129) -> rrixk, jvfmwp
ojatf (9518) -> qmwvc, wibfie, dnycw
yxzzaaq (55)
wjipa (1180) -> mqllnxu, xmxzvhr, qbynkmw
cwxgqrk (15)
aotajs (133) -> ucezr, mmnejdx, jpbiodh
lsspa (60) -> paldf, grmhpg, exjsjxd
ineoncq (11)
eipmjyb (61)
fjgsw (29)
wnwsbdq (50)
hdgvs (37) -> msyvug, bntdh, sjxaxv
npckah (6)
swqkqgz (19)
eabhh (379) -> jzpwsg, bkwcwf, mwblvo
ggaxx (87)
rjvfwcu (64)
bwtusip (44)
slgjon (63)
vlpqaxo (66)
mmoea (11)
xnltw (93)
tgpxvyr (37)
phdcpp (63)
dltungt (37)
ljvrcj (83)
upaqlj (44) -> cobwyky, pngubp
hwriv (97)
hopjmyt (62)
sizmuwa (180) -> sooqm, sfyad
jzndr (50)
ppmrgga (222) -> cvvncju, xmusk, trmwq
uvswv (90)
xstrla (46)
pcdvdp (64)
kszkv (164) -> hgrua, qhqyt
niwzp (855) -> nnhknbl, ichznto, llmmm, hpmuqvl
kybegv (96)
rxcbsdp (30) -> ynvqpm, pjaxkr
ihpmp (85)
hseaxj (51)
fuzhuf (38)
plbtdq (633) -> gkuma, jrcng, dkoxq, vtylgti, qifoay, sizmuwa, pjxttn
esooc (151) -> vtdwe, ezdiq
jvqwi (33) -> csaqixs, rnlaw, hvkhvwl, rkpcoen, nptoou, ypvztl
luqyr (81)
ggzym (91)
fcsfrg (113) -> siitl, dkntzn
nnbbrbf (135) -> uspimc, xkzgz
cwiwn (70)
zragt (58)
glyxk (22) -> pvhrim, ndidblx, sebxl, sstvew
rhwgdsv (481) -> ugkuxzz, yyjqegu, yrhid
bmltf (23)
gfdyf (52)
cbirs (85)
xhtzti (21)
advhon (65)
xcrkb (864) -> ugmlsij, jpkwter, ejlgch
kfqrgj (347) -> igqvq, cqvyvl, jzgzd, ashxu, clwwv
ouubjrl (36) -> iodveqh, wanom
nptoou (269) -> yrdsj, bywpbd, lmcqig, skgwztg, suoiohi, gvxhl, rgdvmy
jqdmk (22)
ljmkz (20)
dxzlkz (60)
svhqwim (9)
nurclfr (30) -> usuaiv, zyjxpjz, devljb, erghvss
vdzuw (146) -> ostrl, lmvvs
fsokbvd (262) -> owmjbhg, sshfxeu, zufoz
cdvkf (6)
lrtds (202)
ybfew (377) -> zuybvj, bvnjiou
lfiqwye (44)
htbjl (57) -> czdpe, gcqaj
cjjbqxl (18)
vucfp (53)
bnvlsm (51)
ybekxtf (10703) -> erylwj, xgfsqq, eygdy, dinlw
ashxu (96) -> ctinwus, ypdpmwi
qpwiok (33)
nrdlfop (84)
sbhiqhs (27) -> qxnkp, klnew
ujlhns (48)
ostrl (22)
vmjbgo (155) -> udmez, jefztzv
rkaxx (27)
pocxcw (823) -> blhgy, xptjtlm, kerjqr, ekfewi
gkuma (134) -> kvyjyt, foabep
ugrhs (32) -> mansh, hpkvfr, ojqia
gbixdw (50)
phkthld (75)
mofyda (109) -> finkdao, mlmzsqc
lxucxpm (73) -> iytknc, qhxmh, eltbyz, dfjvh
qgjqyh (77)
ucxgom (249)
mmufeg (13) -> gcksx, oybdjt, xoqxg, masykz
yexxg (319)
bvahtih (19)
lesmi (204) -> qwsan, hcptw
pmbnia (94) -> jsjexer, qjcqm, ftegwk, dxdltnx, negkd, jodrf
knmac (36)
hnpndnp (41)
qoijc (73)
lemnz (60) -> egvza, mqmgirb, dqwdx, whglbyy, lxucxpm
ihtfh (116) -> fplihc, vregap
lmxnloe (14)
whglbyy (201) -> vnkqnhh, zragt
vbateme (50)
inxav (77)
sykwd (860) -> jeplz, sttlom, ynrctr, cumfrfc
aaqcpt (79)
mwpatsx (64) -> nrdlfop, lerycoe, mygcpku, uusiaqf
uanvh (53)
pvlirjn (49)
kerjqr (150)
wrabgy (32)
xjzpum (148) -> vjmwqzj, uwzvy, vwbxg
tycqst (1112) -> ytmpzku, vwzmkq, esooc
gxxzwq (7)
knjbw (27)
hpkvfr (22)
xappjar (85)
oybdjt (73)
qmddtb (30)
krvyy (35)
mughfl (82)
hoqtxuf (74) -> xrbuyn, imyvlyt, fvmhrf
xtexo (51)
bknogxz (84)
rreqg (144) -> nccoxir, cahxjyq
icpwoof (172) -> wxhsqe, svhqwim
kszyl (113) -> sqfgpm, xmvdh
zyjxpjz (45)
ipxkky (25)
jxcnmmo (96)
ghkdvw (72)
cwphzk (25)
mgzox (20)
gcvpqk (143) -> ozbfh, opkvs
bompiu (25)
ckisc (103) -> alankuj, phkthld
ngtkzm (67) -> vkfrqct, usvkq, jfmts
qifoay (318)
rkpcoen (1788) -> uyopxvt, bkzdepq
vtuqq (30) -> tbkhho, xhzylb
ekfewi (96) -> knjbw, tpozmfd
paldf (75)
zghrr (25)
ggllv (66)
vlfpuo (32)
sdgdv (89)
osryil (62)
puexzf (36)
smrvw (39)
ozjbwv (74)
naglm (31)
aewie (20)
etoxfc (59) -> uxdeg, hcceg, ppmlbky, uufxdt, qbcscs, llgoq, iaafo
wxemcge (8)
xwkoc (63) -> ijcfw, aondpve, nevkec
byckty (80)
kvyjyt (92)
pkmmfc (54)
sxnsqj (9)
wtzkvm (23)
kfcowx (352) -> edoycls, pqdfbrl, nxdkpuh, acrsmhw, rrkqend
ngthpc (51)
nkycb (9)
otpnx (81)
jusfet (39) -> kivcyus, nxwjvx, vucfp, soqvass
mvswhtp (28) -> tazfdb, mzlmr
exjsjxd (75)
ugkxkqe (159) -> qbdafi, htdwe, olztzl
pikvdx (82)
vnvkvb (60)
sitjrw (23)
yyjqegu (94) -> guywt, skumcr, whoqvq, slrdn
qnrjqj (61)
szfxhin (17)
iiznokx (90)
vbpyoqo (97)
qwdhdrk (7)
iqvhov (120) -> atlrd, mmufeg, ouqtjz, xgitr, ezglz
wdnebh (94)
ylidl (82) -> wejvpzr, jlshk
qsfpaj (34)
qbcscs (1680) -> yazsie, eayhoi, btqebbp
auiiuv (78)
ixmfiwz (55)
hcceg (1083) -> dkoxwi, iwsknb, fkdukrv
kqaksir (152) -> ydfajlk, tyvhfhz, yexxg
wixlvcp (12)
tfhij (35)
vnkqnhh (58)
dkntzn (61)
oggnstj (279) -> ydgzjs, havdbe, dzqrtc, nzmaui
yzyzmzw (583) -> yrwyc, suiyl, kmcad
hfttss (5) -> xatua, hwriv, vbpyoqo
kieka (80)
czdpe (69)
vxrzo (48)
mpmue (9)
ujsbt (68)
oijrg (86)
vaeuo (41)
qbynkmw (114) -> mgyhaax, cbbcj
srgmt (165) -> msskvkg, foxjx
ycxlhqo (20)
pmfprs (20)
zbsxee (35)
ypvztl (1363) -> xqpffoe, neyeo, lccoo
hwrwnh (90)
szwpt (29)
mhofo (66) -> inxav, osvmh
masykz (73)
gawck (98)
drtxytc (81)
wyftg (86)
ssvsso (22)
koeqohh (275) -> zupym, hxeoxk
kcgui (335) -> kguwwze, gcefq
olqbic (911) -> ihtfh, ugqqv, lesmi
sttlom (62) -> zknesz, gethyvd
acjtzxw (51)
supnaxw (194) -> iqsztjd, urpnw, opowpvm
jzjrtvd (71)
rbzqabo (6)
keoaqjb (59) -> jqtlcm, wdhbym, mwpatsx, mbtsi, bnsivw, zqurr, ajhio
kkkjsil (39)
jzgzd (188) -> zorvsm, ainstbs
iitweo (96) -> ckisc, ysltqk, zosskdz, xjzpum, rrazh, htsuvhg, xwwxswj
xyzbni (58) -> xnltw, lnufi
rgdvmy (53) -> hwrwnh, eklqi
hhdzz (227) -> cragbdx, iqumjrz
mcjgfx (68)
jlpxjeo (38)
zfzum (16) -> lnaoiv, qkhtsa, lsvqox
njatvu (26) -> ehtsbv, hkazlkt, tvgwgq, zktmxll, jjukf, kmdzlmk, svtwviu
wdsbi (98)
ieuwo (196) -> hdtcizc, ggpjxwv
tuyzi (92)
dkoxwi (35) -> pwumvgy, asdlfku, aedcmjb, tyuhzom
ichznto (221) -> cdvkf, jdpcmb
tyvhfhz (179) -> nystxqv, caocs, zbsxee, lunefek
uxdeg (443) -> eewnnkx, dryngd, lpziczm, koeqohh, uijtrw
egcat (54)
kvqspmf (36)
ydmrd (90)
syurke (85)
tkeuvp (159) -> jtpgzp, bfcdy
ypdpmwi (96)
nmemj (20)
eewnnkx (341)
bafdzbu (53)
wgivp (71)
tvgwgq (835) -> prdkf, pnmvk, xyzbni
slgiv (7452) -> oeftx, erdxj, oggnstj
gpogy (61)
xdrge (889) -> shciqu, aotajs, douvhy, lasluxv, sbhiqhs, elgyjo
vbdcxx (93)
oydsj (80)
pjxttn (168) -> jwbxyd, isymgjd
edkwqih (60)
wanom (89)
hqzay (92)
xwfbb (20)
phyzvno (20)
glrua (69)
ijcfw (53)
alomcle (112) -> fpank, rfwvc
lmcqig (71) -> ufsmed, cylfwm
ltichp (80)
tzltv (63)
thknml (89) -> luqyr, janrdqf, wkxkv
zsnatp (118) -> orwbdwn, tsiyp
zoijv (130)
aynpr (63)
isymgjd (75)
pqdfbrl (117) -> nicjj, cdrhm, mdddafe
bonjgrt (319) -> fuvokrr, hqlyg, mozvs
vggsia (53)
ucbuez (14)
wixfh (5)
dgszhd (18)
joernlg (67)
elkflt (78)
lhvyfsb (37)
liymk (54)
xgitr (139) -> vhfwgvx, rqrtz
wxhsqe (9)
wssvxr (85)
bgmmb (17)
ehypcwy (334) -> xvlymgg, tgkbxa
qwbfod (68) -> ndpwgdy, knmac
nepxnu (6)
ftoskhn (34)
ponlfyf (82)
atkmjxg (162) -> xluwv, dinng
rrkqend (223) -> xaali, sxmdnhl
sbnsoxi (15)
fxemb (62)
sfyoyp (10)
lyhfj (79)
nnkmf (15)
xfmxo (73)
dilqo (84) -> ljvrcj, ognax
jxbksoh (157) -> xstrla, ykudi
fkhxkeg (26)
wsvir (36)
chetpy (363) -> ndcfy, ftdylco
iytknc (61)
hvifpbk (202) -> mhkxu, gfmgl
gyuyb (18)
whoqvq (55)
twtcx (524) -> htbjl, kszyl, hvapnf
wkxkv (81)
ainstbs (50)
ppfmc (35)
hvkhvwl (1351) -> hhrqz, kzcyjtb, javiioo
yeqnq (15)
aruczxj (31)
poinih (23)
kymbpe (745) -> ihmqs, uthjdye, nmxmtaa
kixaco (11)
oszlto (45)
ydmeqtl (34)
mojjl (34)
adxeaf (212) -> rdyda, vlagh
xjuoid (45)
rndomrv (87)
mhkxu (47)
znubct (69) -> dasyq, vlpqaxo
fdmbkt (50)
coaznz (84)
caxbgqp (23)
uhwvnbg (28)
orcyokv (92)
zgzsu (10)
xgwjcx (22) -> cfdpxpm, pmgwwzy, bscpyic, vmcgj, jaqwzi, spxwcuv
vpqqbz (94)
wvdapsm (65)
uapwikr (12)
olydb (50)
kjgtfqc (69) -> pdvolf, sgngx
cklpcr (58) -> hwjhf, foaayon
ottiad (63)
bjtza (250) -> caxbgqp, rpegyn
fdhdpw (18)
jqjkgv (50)
kguwwze (33)
blhgy (100) -> cwphzk, ceeem
aedcmjb (80)
drosj (98)
jbqvpsb (12)
isrch (7)
vzgsgk (10)
fjqomax (82)
twvdhg (55)
vvbcb (11)
yazsie (78) -> qscpjx, mxbyg
nkkgyl (166) -> kvmqsdx, znkzp, lyuys
mrizfl (108) -> ittmm, eyyokyd
fkkzg (145) -> vgsnxlm, bmltf, lircjh
zepvwyv (26)
idjhk (47)
hrtgwt (25)
iaixlte (717) -> surri, mkmci, rfmiqz, gyojd, rxcbsdp
ubxke (51)
imnvt (48)
hgmjvpp (35) -> wrpqf, uwpbnv
tiwakam (93)
rfwvc (10)
zjqeu (120) -> fuzhuf, opduu, ijictm
ymyzead (76)
veboyvy (61) -> qwjmobb, fmarl, hqxdyv, fhphiyb, cmmqbz, kqoigs
nwtlu (64)
rdghpyb (46)
srcyajr (77) -> vxjjxhz, aevhbim, sldytqh
hpltoci (199) -> qczhlyf, mfzvywf
sdbmop (35) -> vtkgj, jovkydi
nyejrrv (89)
negkd (266) -> zwoot, mpmue
ykudi (46)";

        public const string Day8 = @"yxr inc 119 if nev != 6
piw dec -346 if tl != 4
cli inc 165 if nev >= -5
nev dec 283 if xuu > -2
tem inc 745 if qym >= -9
xuu dec -104 if cli == 165
h dec 192 if u <= 5
ln dec -616 if ej > -7
tem dec -555 if ar > -5
tem dec 687 if tl > -8
h inc 120 if re < -8
bq dec -410 if ej > -4
re dec 476 if tem == 613
ej dec 686 if cli != 163
ar dec 676 if tl > -6
nfo inc 633 if s == 0
tl inc -471 if tem > 607
bb inc 157 if piw > 342
cli inc -830 if piw != 342
piw inc -645 if ar >= -674
bq dec 304 if piw != 356
u inc -274 if bb != 147
yxr inc -520 if ec >= 1
ec dec 631 if bb > 147
ar dec 732 if s >= 0
foz inc -617 if bb == 157
qym dec -197 if ej == -686
bb dec 111 if h <= -199
ln dec -585 if re != -476
foz dec -181 if nev < -280
foz dec 989 if xuu != 106
ec inc -930 if ec <= -626
foz dec 862 if s >= 5
tem inc 241 if xuu == 104
ar dec -460 if h >= -201
cli inc -317 if cli == -665
bb dec -483 if h > -194
tem inc -718 if tl <= -466
ln dec 362 if hb == 0
qym inc 95 if hb > 3
piw dec -463 if ln < 246
xuu inc 159 if s <= 5
ec inc -710 if cli < -977
bb inc -98 if xuu >= 260
qym inc 159 if bb >= 540
acc inc 610 if fe <= 9
ar dec 381 if ej < -695
acc dec 807 if nev > -284
foz dec 926 if h < -188
tl inc 279 if ar != -957
ec dec -39 if acc < -191
u dec -110 if piw == 346
ej dec 980 if ar == -948
ln dec -165 if hb < 2
nfo inc -370 if tem > 128
ar dec -886 if ar < -947
bb dec 624 if ej == -1666
tl inc 36 if ec > -2227
yxr dec 320 if cli <= -976
tem inc -808 if ar >= -52
cli dec 213 if h >= -198
ej inc -141 if nev < -281
bq inc -736 if yxr > -211
u dec -742 if nfo > 258
bq dec -727 if ar >= -64
u dec -248 if bq > 89
xuu inc 431 if yxr > -203
hb dec -407 if hb >= -7
ar inc 789 if acc >= -197
yxr inc -753 if piw <= 350
piw dec -973 if yxr >= -956
xuu dec 457 if ec <= -2228
bq inc -201 if bq >= 97
bq dec -923 if ar == 727
cli inc -560 if piw < 1329
ej dec -150 if ar != 733
h inc -198 if nev == -283
u inc -388 if piw == 1319
hb inc -212 if s < 8
xuu inc -988 if ej < -1653
ec inc 58 if re >= -485
hb inc -126 if xuu < -741
ar inc 534 if nev == -273
fe inc 668 if s <= 7
tem dec 25 if h >= -390
u inc -632 if tl > -198
u dec 721 if bq > 813
piw dec -299 if foz >= -2348
hb inc -407 if ej > -1663
h dec 563 if foz == -2351
bb dec 362 if fe != 670
nev inc -512 if bb != -437
fe dec -419 if yxr < -948
tl dec 576 if ej > -1665
acc dec -510 if xuu > -759
s dec -108 if u < -906
xuu dec -407 if xuu < -748
yxr dec 771 if bb > -454
u dec -879 if tem != 110
bq inc -759 if u < -27
s dec -295 if qym < 364
qym inc 807 if xuu == -344
h inc 545 if hb == -338
ej inc -896 if s != 394
s dec -961 if yxr > -1723
s dec -142 if nev != -799
s inc -692 if ln != 427
ar dec 152 if tl == -763
acc dec 304 if piw != 1328
ar inc -532 if piw != 1324
bq inc 124 if tem < 109
h inc 480 if nfo == 268
xuu dec -291 if ej >= -2556
hb inc -56 if nfo >= 257
ar dec -656 if bb > -447
tl dec -458 if ec <= -2167
xuu inc -100 if hb <= -397
nev dec 384 if foz <= -2344
acc dec -779 if acc == 9
u inc 949 if h != -416
xuu inc -865 if nev < -1182
nev dec 317 if bb < -434
foz inc -786 if bq > 51
xuu inc -901 if ej >= -2557
nev dec 750 if h != -398
qym dec 783 if re != -480
bb dec 54 if cli < -1752
tl dec -803 if yxr < -1724
s inc 690 if xuu != -954
piw inc -667 if s != -151
foz dec -946 if cli <= -1757
h dec -885 if re == -486
ar inc -765 if re < -468
h dec 340 if ec != -2170
fe dec 440 if tl > 492
re dec 398 if hb != -384
xuu inc -49 if fe > 641
s dec 623 if qym != 375
piw inc 429 if ec == -2174
ej inc 747 if hb != -394
xuu inc 761 if nfo > 255
re inc 519 if yxr != -1716
nev inc 863 if tl <= 499
qym inc -357 if foz > -3138
tl dec 186 if u < 915
s dec -442 if nev < -1373
bq inc -999 if ec == -2174
cli inc 735 if acc > 781
ar dec -983 if nev >= -1389
cli inc 285 if u < 917
xuu inc -970 if h >= -747
bq inc 716 if tl < 310
xuu dec 984 if bb > -503
h inc -881 if ej >= -2546
u inc 719 if fe >= 646
u inc 396 if hb > -393
ej inc 734 if acc != 784
fe inc 581 if re <= -350
piw dec -69 if hb < -384
ec dec 540 if acc < 798
cli dec -615 if foz <= -3130
ln inc 261 if foz <= -3130
acc dec 739 if ar > 1065
ln dec -520 if qym > 19
re inc -260 if bq != -230
ln inc -28 if h > -750
hb dec -794 if s == -325
nfo inc 79 if ln < 1176
acc inc 173 if ec == -2714
yxr inc 756 if re > -616
re inc 415 if fe >= 1219
hb dec -701 if u < 1638
xuu dec -325 if re != -200
ln dec -552 if piw != 1157
yxr inc -568 if qym >= 17
tl dec 756 if ec <= -2712
nev dec 430 if xuu <= -1219
bq dec -580 if yxr >= -1533
ej dec -357 if bb >= -493
ec inc 722 if ej >= -1822
tl dec 168 if nev == -1813
bb dec -393 if foz >= -3130
cli inc -298 if s == -328
h inc 885 if yxr != -1536
nev dec -188 if cli < -427
yxr dec 41 if cli > -416
qym inc 748 if u == 1632
re inc 457 if nfo > 339
yxr inc 781 if piw < 1153
qym inc 628 if cli != -417
bq inc -476 if piw < 1142
bb dec 547 if nfo >= 341
s dec 590 if piw == 1150
piw inc -804 if nfo != 342
ar dec -838 if xuu == -1226
ec inc 224 if h > 132
ec dec -963 if ln >= 1731
xuu inc 109 if u <= 1638
s dec -191 if fe >= 1220
ln dec -718 if h >= 133
u dec 46 if nev >= -1811
nfo inc -56 if s < -718
nev dec -346 if ar != 1905
h dec -501 if hb != 306
acc dec 651 if bb >= -1039
xuu dec 714 if ar > 1905
qym dec 304 if piw <= 1157
tl dec -62 if foz < -3138
h inc 448 if qym != 1095
hb inc 780 if tem != 112
hb dec 332 if tem <= 114
s dec -447 if acc != 226
s dec -560 if ej > -1829
nev dec -435 if piw == 1150
nev dec 259 if piw < 1155
tem inc 293 if nfo == 286
hb dec 656 if s < 284
hb inc -484 if acc < 213
ln inc 831 if s < 280
hb dec -394 if ec != -1771
nfo inc 124 if h != 628
ln dec -675 if yxr < -754
bb dec -69 if hb == 494
ln inc -139 if re <= 261
nev inc 325 if yxr >= -753
tl inc 551 if foz != -3137
bb dec -598 if nfo != 413
qym inc 771 if s >= 271
tl inc 903 if ej != -1820
fe inc -388 if re != 250
ln dec -163 if ej != -1827
nev dec -209 if re <= 261
bq inc -59 if h == 638
ej inc 793 if yxr < -749
ec inc -224 if s >= 276
ln inc 895 if foz <= -3132
acc dec -681 if ec < -1989
tem dec -161 if hb == 493
ar dec -436 if nfo >= 408
u dec -56 if re != 250
nfo inc -497 if hb < 495
ec dec -874 if acc > 911
bb dec 988 if xuu == -1838
nfo dec -257 if fe > 836
ec inc -332 if foz >= -3146
u inc 697 if u <= 1691
ej dec 777 if bb <= -440
nfo dec -99 if bq > -277
acc dec 552 if tem <= 573
fe dec 74 if ec == -2317
qym dec 829 if foz >= -3146
bq dec -149 if ec <= -2324
u dec -99 if hb == 493
yxr dec -546 if tl > 288
u inc 261 if cli >= -412
ej inc -341 if tem < 574
ec inc -83 if ar <= 2346
ec inc 847 if xuu <= -1830
re dec -364 if xuu < -1839
yxr inc -483 if ln <= 4033
tl dec 965 if tl == 286
re inc -63 if tl >= -674
cli inc 708 if acc < 352
xuu dec 494 if ej > -2154
tl inc 8 if foz > -3131
ec inc 983 if nfo == 170
bb inc 486 if cli < 292
ar dec -461 if ec >= -586
yxr dec -852 if hb < 500
u inc -874 if acc < 355
xuu inc 883 if re > 266
xuu dec 809 if ec == -577
tl dec 144 if ej > -2145
u inc -363 if fe >= 839
bb inc -194 if piw >= 1150
ln inc 780 if fe != 835
cli inc 213 if re >= 256
xuu dec -718 if hb >= 491
yxr dec -730 if u < 1251
nfo dec 1 if hb > 491
ar inc -556 if nev > -1085
ej dec -275 if bq < -128
nev dec -578 if foz != -3137
h inc -391 if h == 638
foz inc -291 if bq >= -134
bb inc -123 if fe == 840
tl dec 72 if bq == -133
qym dec -155 if yxr < 831
re inc 515 if s < 289
nfo dec -313 if ar >= 2242
cli dec 486 if tl < -904
bb dec -844 if ln >= 4810
hb inc -551 if tem == 565
ec inc -28 if yxr <= 828
cli inc -673 if h >= 241
re dec -937 if bb > 562
ec inc 214 if bb != 571
piw inc -142 if ar > 2240
ar dec 750 if tl < -898
re dec -844 if ej != -1877
bq inc -17 if qym <= 1200
acc dec -154 if foz > -3429
piw inc -13 if cli > -175
cli inc -374 if acc > 497
acc dec -751 if ln != 4821
xuu dec 821 if bq < -142
nev dec 867 if bb < 565
qym dec -883 if hb != -65
h inc -289 if ln <= 4818
hb dec 839 if s <= 282
cli dec 662 if ar > 2253
nev inc 975 if acc < 1249
foz inc -459 if nfo != 479
tem inc 721 if ar < 2244
hb dec 645 if bb >= 561
cli dec 973 if bq <= -148
qym inc 937 if piw <= 1003
bq inc -548 if tem != 561
nfo dec 98 if nev != -1082
u dec 789 if bq >= -688
u dec 389 if acc <= 1258
bq inc 818 if qym <= 3020
acc inc 224 if nfo < 492
ln inc -739 if re >= 2547
re dec -364 if fe != 843
piw dec -836 if piw > 991
foz inc 484 if cli < -1519
ln inc 869 if hb < -1533
piw dec 872 if yxr <= 834
bq inc -1 if bq >= 113
tl inc -649 if u >= 854
ec dec -447 if bb == 566
ar dec -702 if u < 861
s inc -445 if bb <= 574
xuu dec 323 if cli <= -1523
foz dec 589 if ln <= 4947
s inc -399 if nfo != 484
cli inc -704 if acc < 1481
yxr dec 712 if hb != -1534
nev dec -347 if nev <= -1087
ln dec -801 if foz > -4480
xuu dec -549 if h >= -47
re dec 127 if xuu > -2692
hb inc 96 if fe <= 845
acc dec 159 if hb >= -1451
bq inc 754 if u >= 865
u inc 23 if yxr > 106
re dec 940 if nfo <= 489
qym dec -599 if ar >= 2948
qym dec -481 if nfo == 482
nfo inc 767 if cli <= -2225
bb inc -174 if ec == 56
tem inc 615 if ec <= 55
tem inc 845 if re > 1848
hb inc 940 if tl > -1543
bq dec -892 if xuu >= -2686
bq inc 996 if bq >= 117
re dec 456 if u < 885
ln inc 879 if s < -568
s dec 605 if ar >= 2941
foz dec 585 if hb > -1449
ej inc 980 if ej <= -1866
re dec -409 if foz <= -5059
tem dec -394 if nfo != 476
yxr dec -765 if ej <= -888
ec inc -540 if fe < 843
cli dec 758 if foz != -5056
nfo inc 846 if re > 1802
re inc 800 if nev < -1078
nev dec 2 if yxr < 883
piw inc 282 if acc >= 1313
h inc -993 if ln <= 5741
ar inc 594 if tem <= 1804
h inc 502 if h >= -45
xuu inc -73 if acc <= 1326
re dec 116 if piw >= 1243
bq inc 62 if u <= 880
acc dec 166 if fe <= 846
ec dec -441 if re > 2612
re inc 214 if re != 2602
u dec 410 if s < -1160
ln dec -701 if piw <= 1244
tl inc -126 if nfo <= 1330
fe inc -861 if tl <= -1669
ar dec -998 if yxr <= 882
fe inc 629 if ln > 6445
hb dec -407 if foz <= -5071
s dec 654 if acc <= 1161
bb inc 304 if fe <= 615
xuu inc 979 if cli == -2969
cli inc -973 if fe == 607
cli inc 859 if tl <= -1665
tl dec 257 if foz > -5064
bq dec -253 if hb != -1446
s inc 82 if fe == 611
h inc -462 if xuu == -2761
nev dec 231 if bq <= 1123
fe inc -719 if re == 2817
nfo inc 553 if ec != -484
nev inc -457 if nfo != 1318
fe inc -936 if piw <= 1247
nev inc -615 if ar > 4539
fe inc -267 if ec >= -475
qym dec 336 if tem > 1802
ej inc 442 if foz > -5064
qym inc 864 if h < 0
nev inc 565 if foz >= -5057
tem inc 257 if ej <= -457
hb dec -202 if piw > 1243
bq dec -192 if ar != 4550
foz dec 374 if ln >= 6454
tem inc 381 if ej != -454
ec dec -630 if ej == -438
foz dec -821 if acc > 1161
nev dec 903 if bq != 1315
re inc -677 if ej > -448
re inc 588 if u < 473
xuu dec 114 if foz > -5062
acc inc -804 if ec > -492
nfo inc 728 if cli == -2120
xuu dec -258 if foz > -5064
tem dec -370 if ln < 6450
acc dec -717 if ej != -442
ec dec 262 if qym > 4613
nev inc 31 if u >= 468
xuu dec 84 if re == 2728
u inc 457 if xuu != -2697
acc dec 251 if acc != 1068
tem dec -745 if acc <= 1076
tl dec 581 if tem <= 3304
s dec -730 if hb <= -1444
ec dec 409 if tem < 3293
acc dec -884 if acc >= 1077
acc inc 160 if bb < 706
ar dec 110 if nfo != 2058
ej dec -349 if fe < -1038
s inc 681 if s >= -1096
cli inc -712 if fe < -1043
nfo dec 693 if u != 924
ln inc 170 if xuu != -2702
bb inc 759 if tl > -2518
ln inc 647 if tem > 3296
ej inc -35 if re >= 2734
qym inc 710 if nev < -3258
xuu inc 304 if fe == -1052
piw dec 237 if xuu >= -2707
tem dec -683 if hb <= -1441
piw inc -297 if re >= 2733
nfo dec -836 if bb == 1455
s inc 901 if u <= 921
bb inc 780 if bq == 1307
xuu dec 467 if yxr >= 878
acc dec -24 if h < 6
ec dec 412 if foz >= -5054
ec inc -990 if fe == -1047
nev dec -940 if nfo != 2208
ar dec -670 if qym == 5339
foz inc 391 if hb != -1438
yxr inc -86 if acc <= 1260
qym dec -36 if piw < 1008
nev inc -21 if yxr == 788
piw inc 581 if hb == -1446
bb inc -355 if bb != 2232
yxr dec 238 if ar < 4441
tem dec -974 if cli < -2826
xuu inc -237 if s <= -406
ej dec 51 if foz <= -4661
cli inc -416 if h < 6
fe inc 23 if s < -407
bq dec 598 if ej <= -152
cli inc -15 if piw > 1584
foz dec -781 if nfo < 2209
u inc 17 if bb < 1883
xuu dec 799 if ej >= -157
bb inc 914 if tem != 4960
foz dec 853 if fe != -1024
piw dec 628 if nfo != 2199
qym dec 303 if xuu >= -4207
bq dec 854 if yxr >= 549
hb inc -123 if xuu >= -4211
bb inc 767 if nev <= -2318
s inc 482 if nfo > 2196
yxr inc 185 if bb < 3570
yxr dec 683 if bq != 444
fe dec -316 if ec >= -1733
bb inc 368 if s < 78
tl dec 132 if yxr != 63
yxr dec 357 if bq == 453
fe inc -256 if ec > -1744
xuu inc -193 if ej <= -142
xuu dec -605 if cli != -3263
ar dec 571 if u != 945
nfo inc -430 if nfo < 2209
hb inc 236 if hb > -1564
ar dec -460 if fe < -1278
tl dec -127 if bq > 449
s inc -343 if nfo > 1764
fe inc 761 if nev < -2326
piw dec -136 if xuu != -4391
cli dec 639 if yxr >= -301
tl dec -524 if ar != 4890
ln dec -75 if ln < 7269
ln dec -376 if tem > 4956
yxr inc -317 if yxr >= -297
tem inc 593 if ej == -149
cli dec 297 if ar < 4894
ej dec -576 if xuu <= -4395
bq dec -681 if s >= -277
ec dec -404 if u >= 939
xuu dec -82 if yxr >= -292
nev inc -661 if u <= 954
yxr inc 941 if foz > -3896
ar dec 559 if ar < 4895
re inc 470 if tl <= -1981
qym inc 423 if hb <= -1564
ec inc -353 if cli >= -4208
qym inc 166 if nfo < 1770
ln inc 110 if h > -4
bb dec 459 if nfo < 1776
tem inc -466 if ej > 418
tem inc -223 if fe < -1271
bb inc 361 if qym > 5650
fe dec 698 if nfo <= 1768
h inc -761 if acc >= 1258
tl dec 307 if cli < -4195
ec dec -428 if bq == 1134
ec inc 200 if u == 945
fe dec 999 if re >= 3198
ej dec -150 if ej != 429
ar inc -19 if bb < 3822
cli inc -271 if piw == 1721
piw inc -317 if nev <= -2985
xuu dec 732 if xuu == -4393
ar dec -738 if bq != 1133
cli dec -925 if xuu >= -4400
tem dec -336 if acc == 1261
xuu dec -396 if tl < -2291
tem inc -726 if xuu < -3995
xuu inc 586 if yxr < 643
nfo inc 554 if re >= 3194
ln dec 425 if s < -276
s inc -678 if h >= -2
acc inc -669 if u == 945
nfo inc 136 if re <= 3207
nev inc -486 if fe > -2272
acc inc 146 if yxr < 650
bq inc 637 if u != 945
bq inc -562 if u < 949
fe dec -164 if tem >= 4128
ej inc -868 if ec > -1058
foz inc -646 if ej < -295
u inc 960 if bb < 3825
ln dec -6 if ln > 7826
bq dec 972 if acc > 723
piw inc 958 if fe != -2115
ln inc 179 if ln <= 7830
foz inc 206 if bb <= 3828
u inc -789 if bb > 3826
nev inc -597 if ln <= 8005
nev dec -112 if yxr <= 642
ej inc 670 if s <= -942
ec dec 623 if qym >= 5652
bb inc 35 if nev != -3470
u dec -50 if ej != 379
ar dec 952 if tl != -2306
tem inc -92 if re == 3192
yxr dec 866 if qym == 5652
nfo inc -457 if bb != 3876
tem inc 395 if fe != -2125
acc inc -37 if piw > 1711
tem dec -647 if fe <= -2113
tem dec -546 if xuu > -3422
piw dec 219 if acc < 699
ar dec -392 if piw == 1502
s inc 330 if bq > -407
bq inc -508 if nev <= -3473
ln dec -333 if cli != -3545
ln dec 42 if ec > -1683
acc inc -247 if ln <= 7966
foz inc 563 if tl <= -2287
ej inc -390 if ej <= 384
acc dec 659 if acc != 443
xuu dec -293 if ej >= -18
qym dec -169 if yxr > -217
cli inc 778 if ln >= 7960
xuu dec -179 if u != 163
nfo dec 600 if ej == -11
ar dec 261 if piw > 1492
re inc -889 if yxr > -228
h inc 37 if xuu != -2943
ln inc 148 if tem > 5731
bq dec 564 if piw == 1502
piw dec 822 if ar != 4242
xuu inc -35 if nfo != 1402
u dec -284 if cli > -2777
ar dec -521 if yxr >= -225
bb dec 412 if yxr <= -222
piw inc -199 if tem != 5715
bb inc 331 if qym < 5653
bq dec -359 if ec > -1687
acc inc 298 if bq == -605
bq inc -69 if tl < -2305
h inc -626 if h == 8
qym dec 609 if s <= -619
fe inc 165 if nev < -3456
xuu inc 690 if ej != -15
ec dec -280 if tl < -2294
qym dec 829 if bq != -610
xuu dec 888 if piw > 489
u inc 81 if acc > 80
qym dec 247 if h > -9
tl dec -558 if bq < -604
nfo dec 692 if ln == 7963
acc inc -23 if tl > -1735
xuu dec 478 if fe == -1950
s dec 551 if tl < -1736
ec inc -479 if fe == -1950
s dec -17 if foz > -3328
piw dec 351 if acc == 84
bq dec -437 if re == 2309
qym dec -808 if cli > -2774
h dec -390 if tl == -1738
foz dec 676 if ej >= -4
re dec 891 if bq != -167
bb dec -191 if re != 1418
nfo inc 380 if s == -1155
ec inc 69 if u < 531
nev dec -690 if s >= -1164
s dec 571 if bb >= 3776
re dec -224 if hb <= -1563
bq inc -252 if piw < 131
yxr dec -488 if tl == -1741
re inc 755 if re > 1638
bq inc -208 if qym != 4769
qym inc 695 if hb == -1563
fe inc -157 if piw < 121
xuu dec 579 if acc != 79
ln dec -262 if nfo > 1086
ec dec 235 if tl >= -1739
hb inc 188 if ej >= -13
s inc 124 if cli >= -2760
ec dec -643 if nfo != 1088
re dec -934 if fe > -1959
ej inc -58 if s == -1727
qym dec -558 if tl >= -1746
ln inc -555 if ec != -1402
foz inc -833 if cli != -2774
ln dec -589 if cli == -2775
tl inc -906 if re < 3334
tl inc 552 if fe < -1940
cli inc 976 if re >= 3322
bq inc -101 if xuu >= -3301
nev dec -217 if tl < -2087
ej dec 945 if u > 519
piw inc 447 if fe >= -1957
h inc 905 if piw <= 586
hb inc -995 if u == 521
acc inc 713 if tl >= -2100
ar inc -936 if ec <= -1400
tl inc 199 if u < 530
u dec 584 if ar != 3829
tl inc 787 if fe > -1954
ar inc 631 if qym >= 5325
tl inc -993 if ln < 8232
bq dec 900 if yxr > -231
u dec -226 if ln < 8235
yxr inc -966 if bq <= -1520
ar inc -83 if bq < -1520
bq dec 439 if bq == -1528
ej inc 608 if h < 1294
yxr inc 140 if nev >= -2567
qym dec 685 if nev >= -2566
re dec 957 if hb > -2378
tem dec -851 if bq <= -1966
nfo dec 421 if qym < 4649
acc inc 473 if ar == 4383
tem inc -407 if qym >= 4642
s dec -949 if tl >= -2103
h inc 549 if s >= -784
qym dec -311 if xuu >= -3308
s dec 751 if yxr > -1060
s inc -438 if ar != 4386
fe dec 734 if s <= -1965
ej inc 989 if hb == -2376
tl dec 84 if yxr > -1055
re dec 919 if ar < 4393
ec dec 314 if qym >= 4657
acc dec 572 if piw <= 579
bq dec -742 if tem >= 6166
ln inc 891 if qym < 4651
piw inc 125 if s >= -1956
nev inc 530 if piw != 577
ln inc 703 if nfo <= 670
bb inc 741 if foz >= -4155
ln inc -429 if u >= 163
ln dec -47 if nfo > 678
cli dec 217 if bq < -1222
tl dec -485 if fe >= -2690
tl dec -948 if fe == -2684
nfo inc 786 if qym != 4642
bb inc 336 if re != 1455
tl inc -8 if nfo != 1455
hb inc 173 if bq == -1225
s dec -53 if piw < 581
bq inc 905 if h == 1842
acc inc -450 if nev < -2551
ar dec 241 if s != -1914
bb inc 671 if ec <= -1400
acc inc 895 if fe <= -2691
fe dec 776 if s == -1913
foz inc -104 if nev >= -2558
nfo dec 629 if hb <= -2201
u dec 531 if ec < -1404
hb dec -37 if yxr < -1049
foz dec -586 if h <= 1848
nev inc -895 if acc == 248
qym dec 475 if bb <= 4461
piw inc 773 if fe < -3459
nfo dec -142 if cli == -2008
hb inc 103 if cli != -1999
bq inc 795 if ln == 9390
re dec 82 if nfo <= 975
u inc -275 if u != 163
xuu inc -599 if acc == 248
ln inc -642 if hb < -2069
hb dec 874 if nfo == 968
bb inc -283 if ej != 640
bq inc -999 if fe == -3460
tem dec 670 if tem != 6174
bb inc 890 if re > 1369
xuu dec 880 if foz >= -3678
ar dec -702 if ej == 641
h inc -43 if nev != -3453
tl inc -803 if qym >= 4166
ej inc 583 if foz > -3687
piw inc -517 if qym != 4173
nev dec -258 if tl >= -1552
tem inc -18 if ln >= 9398
qym inc -463 if tem == 5497
nfo inc -279 if ln >= 9392
nfo dec 627 if ln > 9388
acc inc -544 if ej >= 1219
xuu dec 201 if foz < -3667
qym inc -353 if s >= -1905
xuu inc -927 if tem <= 5506
cli dec -347 if bb != 5065
tl dec -339 if hb == -2937
s dec 503 if fe > -3470
s dec -187 if acc > -306
hb inc 77 if ej > 1214
u dec 103 if acc > -296
s dec 620 if bb < 5072
fe dec -752 if bb == 5063
u dec 930 if ec == -1410
ec inc -235 if cli != -1661
bq inc -361 if cli < -1664
xuu inc -582 if s <= -2849
re dec 812 if acc <= -292
h inc -938 if cli != -1652
ec inc -830 if re > 560
ec dec -888 if ln < 9385
cli inc -520 if tem < 5506
qym inc -224 if acc >= -302
tl inc -399 if nfo >= 342
tem dec 154 if foz == -3671
qym inc 500 if nev < -3443
tem dec 603 if acc != -295
nev inc 227 if ar == 4844
fe dec 658 if s > -2857
bb dec 327 if xuu < -6498
s inc -204 if acc <= -294
s inc 393 if s <= -3051
foz dec -71 if ec == -2232
piw inc 247 if acc != -306
tl dec 749 if cli >= -2189
bb dec -17 if qym != 3996
acc inc 890 if bq != -524
ar dec -532 if re == 561
ej dec -406 if ej >= 1224
ar dec -82 if hb < -2857
ej inc -685 if u <= 163
nfo dec -354 if yxr < -1053
ar dec -346 if yxr >= -1048
ej dec -575 if hb > -2864
bq inc 220 if bq != -521
fe dec -843 if cli <= -2185
ej inc -819 if ln > 9390
cli inc 105 if acc != -290
bb inc -828 if hb > -2866
s dec -508 if tem != 4900
re inc 153 if re <= 566
piw dec 370 if foz <= -3602
nfo inc 987 if bb >= 3922
fe inc -10 if foz > -3607
nfo inc -687 if yxr > -1060
nfo inc -580 if nev == -3226
fe inc -661 if s <= -2149
tl inc -521 if h == 896
nev dec 891 if tem > 4891
hb inc -162 if cli != -2076
yxr dec 696 if nev == -4112
tl inc 754 if s <= -2145
bq inc -457 if re >= 706
re dec -926 if acc >= -286
u inc 630 if re <= 719
ej dec -635 if u > 791
ln dec 631 if ln != 9400
qym inc 470 if re >= 722
ej dec 419 if cli == -2076
foz dec -108 if tl < -1201
fe inc -162 if cli <= -2078
ar dec 385 if yxr == -1059
ec inc 695 if hb < -2852
re dec 535 if cli > -2071
ej dec 135 if bb < 3926
ej dec 13 if hb != -2860
ec inc 967 if ec < -1540
ar dec 713 if ar >= 5453
piw inc -38 if tem >= 4887
piw inc 664 if bq == -761
ar dec 767 if hb > -2863
ej dec 908 if re > 715
nev inc 905 if acc <= -291
nev inc 395 if hb < -2854
piw inc 850 if yxr > -1050
tl dec 290 if nfo == 61
re inc -770 if xuu < -6496
fe inc 828 if ar == 3978
fe dec -295 if ar != 3980
fe dec 431 if foz >= -3506
nfo inc -433 if piw == 1853
tl dec -744 if acc > -299
s dec -609 if bb <= 3919
ar inc 390 if ec != -1547
acc inc 404 if hb == -2860
nfo inc -17 if s < -2152
u inc 338 if h != 910
s inc 921 if s >= -2159
ec inc -49 if hb > -2863
tem inc -144 if tem >= 4893
nev dec -847 if qym > 3985
yxr dec -885 if ln < 8762
cli dec 10 if u == 1131
tem dec -592 if yxr != -159
ec dec -594 if re >= -57
tem inc 66 if u == 1131
foz inc -810 if u == 1131
tem dec 880 if u > 1126
bq inc -604 if acc == 108
tem inc 344 if acc < 114
foz dec -550 if ej != 1594
ar inc 849 if s != -1233
nfo dec -903 if u == 1123
nev dec -945 if ec <= -987
re dec 715 if nev < -1019
ar dec -879 if hb == -2860
tl inc 432 if bb != 3926
s dec 474 if re <= -767
ej inc 356 if h >= 896
ec dec -229 if hb != -2863
bq inc 121 if ec <= -756
xuu inc 428 if u == 1131
ej inc 796 if xuu >= -6070
fe inc 889 if fe < -3341
cli dec 524 if acc > 102
piw dec -360 if acc != 117
fe dec 907 if h >= 907
piw dec -184 if ar != 6092
u dec 189 if hb >= -2866
nev dec -381 if nfo < -362
hb inc -568 if re == -771
hb inc -365 if xuu != -6079
nev dec 490 if qym == 3995
u dec 311 if u >= 933
hb inc 692 if yxr == -166
ej dec -524 if re > -767
ln dec 5 if h > 896
u dec 801 if u >= 628
ar dec -861 if s < -1695
nfo inc -921 if tem > 4862
ej inc -57 if bq == -1244
re dec 726 if ar == 6957
yxr dec -344 if s == -1705
ln dec -300 if foz != -3764
bb dec -372 if bq >= -1251
h inc 630 if tl <= -321
ln inc -586 if u != -161
ec dec -356 if ar != 6959
u dec -225 if piw >= 2399
ln inc -715 if tl < -321
nev inc -649 if u < -164
h inc 232 if ec != -407
bq dec 689 if piw <= 2399
bb inc 52 if xuu == -6071
foz inc 8 if s == -1705
fe inc 80 if nfo > -1299
ec inc 686 if u <= -166
foz inc 579 if bb < 4347
piw dec -551 if nev <= -1288
fe dec -271 if foz < -3743
nev dec -386 if qym <= 3993
nfo inc 791 if hb == -3101
xuu inc -206 if xuu != -6081
qym inc 53 if h > 1532
hb inc -238 if piw != 2955
h inc 947 if yxr < 181
re inc 668 if h < 2484
cli dec -989 if foz > -3754
tl inc -495 if h <= 2486
tl dec 884 if tl < -810
s inc 405 if fe >= -2107
ec dec 842 if yxr >= 174
h inc -451 if yxr < 180
yxr inc 364 if hb < -3331
nfo dec -736 if xuu < -6272
ec inc 37 if piw <= 2957
cli inc 839 if piw <= 2955
foz dec 787 if cli <= -777
ar inc 343 if hb == -3339
piw dec 939 if ej != 1892
piw inc -36 if bq != -1927
ej dec -684 if tl != -1710
acc inc 882 if h == 2030
re dec 372 if acc == 990
h inc 23 if qym <= 4041
ej dec 446 if u >= -169
foz dec 293 if yxr <= 539
tl dec -526 if fe > -2110
ar inc 35 if ec <= -521
ej dec -839 if s != -1295
bq inc -816 if ec > -534
tl dec -913 if fe >= -2108
bb dec 888 if acc >= 983
tem inc -951 if hb == -3339
ec dec -562 if qym < 4046
nfo dec -696 if h >= 2049
u dec -376 if yxr == 542
tem dec 130 if ej <= 3429
nev inc -484 if h >= 2046
nev dec -902 if yxr >= 539
qym inc 306 if nev >= -498
bq inc -306 if hb <= -3334
tl dec -807 if fe > -2113
nev inc -47 if nev <= -483
u dec -228 if xuu == -6277
hb dec 925 if s < -1297
acc dec 236 if cli > -786
h inc 684 if u >= 429
nfo dec 912 if u < 440
xuu inc 529 if bb < 3464
tl inc 143 if qym != 4354
ec dec 694 if tem == 3791
fe dec -542 if u < 441
piw dec 433 if yxr >= 540
ln dec -537 if hb > -4272
acc dec 419 if acc > 744
xuu dec 31 if fe == -1557
ej dec -297 if yxr < 533
foz inc -281 if ec <= -656
cli dec 712 if tl > 677
bq dec -871 if foz >= -4817
bb inc 381 if ln < 8294
nev inc -670 if tem > 3783
yxr inc 860 if nfo < 14
foz inc -120 if nfo > 25
ec inc 793 if fe >= -1563
qym dec -827 if qym < 4351
ar inc 687 if cli >= -1495
bq inc 975 if re < -1191
xuu inc 177 if u != 442
tem inc 363 if nev != -1207
acc inc 707 if cli < -1491
nfo dec -381 if tem > 4148
ec inc -347 if tl != 697
ej dec 995 if s > -1303
acc dec 452 if bq == -2080
u dec -851 if piw > 1539
ln inc -993 if re != -1211
nfo dec -591 if tl >= 692
s dec -410 if yxr != 549
yxr dec -54 if u >= 1288
bb dec -733 if re <= -1193
piw inc -984 if re < -1193
ln dec 133 if ec >= -211
acc dec -218 if fe < -1561
tem inc 792 if fe > -1567
bb dec 359 if yxr != 541
tem inc 273 if h != 2735
ec inc -714 if nfo < 401
hb dec -555 if bb <= 4206
nfo inc -151 if ln > 7294
hb dec -635 if yxr <= 550
acc inc -603 if u < 1282
nev inc 705 if cli >= -1488
cli inc 568 if ej < 2435
nfo dec 795 if nfo >= 246
s dec -996 if ln != 7289
u inc -530 if nfo > -550
tl dec -431 if qym >= 5171
fe inc -998 if ec < -920";

        public static string Day9 = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "\\Day9.txt");

        public const string Day11 = @"se,ne,ne,n,nw,s,sw,sw,n,nw,se,nw,s,nw,nw,nw,sw,sw,sw,sw,se,n,sw,sw,s,sw,sw,sw,s,s,s,s,sw,s,n,s,sw,s,s,s,s,s,s,se,s,s,se,s,se,se,nw,ne,se,se,nw,se,se,se,n,se,se,se,nw,se,se,se,se,se,se,ne,se,ne,se,ne,ne,se,ne,ne,se,s,s,sw,ne,ne,n,ne,nw,ne,ne,sw,ne,se,ne,ne,ne,ne,ne,ne,nw,ne,n,ne,nw,n,ne,se,ne,s,n,se,sw,ne,n,ne,ne,n,n,sw,n,ne,nw,ne,n,ne,n,n,n,n,nw,n,n,n,n,ne,sw,n,n,n,n,ne,se,n,n,n,n,n,n,nw,sw,n,n,n,n,n,n,n,n,n,n,n,n,nw,n,nw,n,n,sw,nw,sw,n,ne,n,n,s,n,n,ne,n,nw,n,ne,nw,nw,n,n,n,ne,se,nw,n,ne,nw,nw,n,n,nw,nw,nw,nw,s,nw,nw,nw,nw,nw,sw,n,nw,nw,nw,nw,n,nw,nw,nw,nw,nw,sw,nw,nw,nw,nw,nw,nw,ne,ne,n,se,nw,nw,nw,se,nw,nw,nw,nw,nw,nw,nw,ne,nw,nw,sw,nw,sw,n,nw,se,sw,nw,se,sw,nw,nw,nw,ne,sw,sw,n,sw,nw,sw,nw,sw,nw,sw,nw,sw,sw,nw,s,nw,nw,nw,sw,nw,ne,sw,sw,nw,sw,nw,sw,nw,se,nw,sw,nw,n,nw,nw,nw,sw,nw,sw,sw,sw,nw,sw,nw,nw,sw,sw,sw,nw,sw,sw,s,nw,sw,ne,sw,nw,sw,nw,sw,sw,sw,sw,sw,sw,sw,sw,nw,sw,sw,n,sw,sw,sw,ne,sw,s,se,sw,sw,nw,sw,sw,sw,sw,sw,nw,sw,sw,sw,sw,s,sw,sw,ne,sw,sw,sw,ne,n,sw,sw,sw,ne,s,ne,sw,ne,sw,s,sw,sw,sw,se,nw,sw,sw,sw,sw,s,n,sw,sw,sw,sw,nw,sw,sw,se,s,sw,sw,n,sw,sw,s,sw,ne,se,sw,sw,sw,sw,sw,s,s,s,se,sw,sw,s,s,sw,sw,s,sw,nw,s,s,sw,s,ne,sw,ne,s,s,s,sw,s,sw,s,sw,s,ne,nw,sw,nw,sw,sw,s,sw,sw,s,s,s,sw,s,s,s,s,s,s,s,s,s,se,nw,se,n,s,s,s,sw,sw,s,sw,ne,s,ne,s,s,s,s,s,s,s,s,s,s,s,s,s,s,s,s,s,n,nw,s,s,s,s,sw,s,s,s,s,s,s,s,s,s,se,s,s,s,sw,ne,s,se,s,s,s,s,se,s,s,s,se,s,s,sw,s,s,s,se,se,se,se,sw,se,s,s,ne,s,n,ne,s,s,sw,sw,s,s,s,se,n,nw,s,n,s,se,se,nw,s,se,nw,ne,s,s,se,sw,sw,ne,n,se,se,s,nw,n,s,s,se,s,se,se,se,s,se,sw,sw,se,s,s,se,s,se,n,s,s,se,se,sw,se,se,ne,s,s,se,se,nw,s,s,s,s,sw,se,ne,se,s,se,se,se,n,s,nw,se,se,se,se,ne,s,se,n,se,se,s,s,se,se,sw,se,s,se,se,s,se,se,se,se,se,se,s,nw,se,se,se,se,se,se,se,se,se,s,sw,n,se,se,s,se,ne,se,s,n,se,se,se,se,se,se,se,nw,se,se,se,sw,s,se,se,se,se,se,se,ne,s,se,n,se,se,se,se,s,ne,se,s,s,se,se,n,s,se,se,se,se,n,se,se,se,se,se,n,sw,se,se,se,se,se,se,se,se,se,se,se,se,se,se,ne,se,n,se,se,se,nw,ne,se,n,s,s,ne,se,se,se,se,se,ne,se,se,ne,se,se,sw,se,se,se,n,se,se,se,n,se,se,se,se,se,nw,se,nw,se,se,sw,se,sw,se,se,n,ne,se,n,se,s,ne,se,se,se,nw,ne,se,s,nw,ne,se,ne,se,se,se,ne,se,ne,nw,se,sw,se,se,n,se,ne,n,se,sw,se,se,se,se,sw,ne,se,se,sw,se,se,se,nw,ne,se,n,se,se,ne,se,ne,se,nw,ne,ne,se,sw,ne,se,se,sw,se,se,se,ne,se,ne,ne,se,ne,sw,se,se,ne,ne,se,se,se,ne,se,s,ne,se,se,n,ne,ne,se,se,ne,ne,ne,ne,ne,se,ne,ne,ne,se,s,ne,s,ne,nw,n,ne,se,se,se,n,se,ne,ne,se,ne,ne,ne,ne,ne,ne,ne,s,ne,ne,ne,ne,s,sw,nw,se,ne,ne,ne,ne,ne,ne,sw,se,ne,sw,se,s,ne,ne,ne,se,ne,n,ne,se,sw,se,n,ne,ne,nw,ne,ne,ne,n,s,ne,ne,ne,ne,ne,ne,nw,ne,sw,ne,se,ne,se,ne,ne,sw,n,se,ne,s,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,se,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,n,ne,sw,ne,ne,ne,ne,ne,ne,ne,ne,s,n,ne,ne,ne,ne,ne,ne,se,ne,ne,ne,nw,ne,ne,n,ne,ne,ne,ne,ne,se,ne,se,s,sw,ne,ne,ne,ne,ne,n,nw,ne,s,ne,ne,ne,ne,n,ne,ne,ne,ne,n,ne,sw,ne,ne,ne,s,ne,ne,ne,ne,n,nw,ne,n,ne,n,s,ne,ne,ne,ne,se,ne,ne,ne,ne,sw,n,ne,ne,s,nw,ne,n,ne,ne,ne,sw,nw,n,n,s,n,n,ne,n,ne,ne,ne,n,se,ne,sw,s,se,ne,ne,ne,s,nw,s,n,s,ne,n,ne,sw,ne,ne,sw,ne,sw,s,ne,ne,ne,se,n,n,se,ne,n,ne,ne,ne,ne,ne,ne,ne,n,se,n,n,n,s,ne,ne,ne,ne,ne,n,n,ne,sw,nw,se,ne,n,nw,ne,ne,ne,n,ne,ne,n,ne,nw,ne,nw,se,nw,ne,n,ne,ne,n,ne,n,ne,ne,nw,sw,ne,n,n,nw,se,sw,s,n,n,n,n,ne,n,n,se,nw,n,n,nw,ne,n,nw,n,ne,ne,ne,ne,n,ne,n,ne,n,n,se,n,sw,n,n,se,sw,ne,n,n,n,nw,n,n,ne,ne,n,ne,ne,ne,ne,n,se,ne,n,ne,se,n,ne,n,ne,s,ne,ne,n,n,n,ne,sw,n,n,n,ne,se,n,ne,n,ne,ne,n,n,n,ne,n,s,n,n,sw,n,n,n,ne,n,s,n,n,ne,s,n,s,s,se,ne,s,ne,se,n,n,n,n,n,n,n,n,n,n,ne,n,n,n,n,s,nw,n,sw,ne,n,ne,n,s,n,n,s,n,n,n,n,s,n,n,n,sw,n,se,nw,s,ne,n,nw,se,n,n,s,ne,s,n,n,n,sw,n,n,n,nw,sw,n,sw,n,ne,n,n,n,s,s,n,n,n,ne,n,n,n,n,ne,se,n,n,n,n,n,n,n,n,ne,n,n,se,s,n,n,n,n,n,n,se,s,se,n,n,n,n,n,n,n,sw,n,ne,n,se,n,n,n,n,nw,n,n,n,n,s,n,n,n,n,n,n,n,n,n,se,n,s,n,n,se,n,n,n,s,n,nw,n,n,nw,nw,n,n,se,n,n,se,n,ne,nw,n,n,se,n,nw,sw,se,n,sw,n,se,nw,n,n,n,n,nw,n,n,n,n,sw,n,nw,n,sw,n,ne,n,nw,s,n,n,nw,n,nw,n,n,sw,nw,n,n,n,n,n,n,n,n,n,n,n,n,n,n,se,ne,n,se,nw,sw,sw,n,n,n,n,nw,s,s,n,n,nw,n,n,n,n,ne,se,n,n,n,n,n,n,n,n,n,n,n,nw,n,nw,n,n,sw,sw,n,n,se,n,n,nw,n,se,sw,n,n,nw,n,s,se,ne,nw,nw,sw,nw,nw,ne,n,n,n,nw,n,nw,nw,s,nw,n,nw,se,n,n,n,n,nw,nw,n,s,n,n,n,se,n,sw,se,se,n,n,n,sw,n,sw,nw,sw,n,nw,n,n,ne,se,n,n,n,n,ne,se,s,s,nw,n,sw,n,se,n,ne,nw,nw,n,nw,ne,nw,nw,nw,n,n,ne,nw,n,n,se,n,sw,n,n,nw,s,n,n,nw,nw,n,nw,nw,n,se,n,nw,nw,n,n,n,ne,nw,n,nw,n,n,nw,s,ne,n,nw,nw,se,n,s,nw,s,nw,nw,n,nw,n,nw,nw,nw,nw,nw,n,n,sw,nw,s,nw,n,nw,nw,n,sw,n,n,n,sw,s,nw,nw,nw,nw,nw,nw,nw,ne,nw,nw,nw,nw,s,se,nw,nw,nw,nw,nw,ne,nw,nw,n,n,n,n,nw,n,nw,n,n,n,nw,n,n,nw,nw,nw,se,nw,nw,s,nw,nw,nw,sw,ne,se,nw,n,sw,nw,nw,nw,nw,n,nw,n,nw,n,nw,n,n,nw,nw,n,nw,nw,nw,nw,nw,nw,n,se,n,n,n,sw,nw,nw,se,se,nw,ne,n,nw,se,nw,nw,s,nw,nw,n,nw,nw,nw,nw,n,nw,n,nw,sw,nw,nw,nw,nw,nw,nw,nw,nw,sw,nw,ne,nw,n,nw,nw,nw,n,n,sw,sw,nw,s,nw,nw,nw,nw,n,s,n,nw,nw,n,nw,nw,nw,nw,nw,ne,sw,nw,nw,nw,nw,n,nw,nw,nw,n,ne,s,nw,nw,nw,nw,nw,nw,nw,nw,nw,ne,sw,n,se,nw,nw,nw,nw,nw,nw,n,nw,s,n,nw,nw,n,s,nw,nw,nw,nw,nw,nw,nw,se,nw,nw,nw,nw,nw,n,nw,n,n,nw,nw,nw,nw,nw,nw,nw,nw,n,n,nw,n,sw,nw,nw,nw,nw,se,nw,n,nw,nw,nw,nw,se,nw,ne,nw,nw,n,nw,nw,nw,nw,nw,ne,nw,n,nw,s,se,sw,se,nw,nw,nw,nw,se,sw,n,ne,ne,nw,se,s,ne,nw,s,nw,nw,nw,nw,nw,nw,s,nw,nw,n,n,ne,nw,nw,nw,nw,nw,nw,ne,ne,nw,nw,s,se,nw,nw,nw,n,nw,nw,nw,nw,nw,nw,nw,nw,nw,nw,s,nw,nw,nw,nw,sw,nw,sw,n,nw,nw,nw,se,nw,n,nw,nw,se,se,nw,sw,nw,s,nw,n,nw,nw,nw,se,nw,sw,s,nw,s,nw,nw,nw,nw,nw,ne,nw,nw,nw,nw,nw,nw,nw,s,sw,nw,se,s,nw,nw,se,nw,nw,nw,nw,n,nw,s,nw,nw,nw,nw,sw,sw,nw,nw,sw,nw,nw,nw,sw,nw,nw,ne,nw,nw,nw,nw,nw,nw,sw,sw,nw,nw,nw,sw,sw,se,n,ne,nw,nw,sw,s,sw,nw,s,ne,nw,sw,sw,nw,se,n,nw,nw,nw,nw,nw,nw,s,nw,se,se,ne,nw,nw,nw,ne,sw,nw,nw,nw,nw,se,nw,sw,nw,nw,nw,sw,nw,sw,nw,ne,sw,nw,nw,nw,nw,s,nw,nw,nw,se,nw,s,sw,nw,nw,nw,sw,nw,nw,nw,nw,sw,nw,nw,se,ne,sw,sw,sw,nw,se,nw,nw,sw,nw,nw,nw,nw,nw,nw,nw,s,ne,nw,nw,nw,sw,nw,nw,sw,s,sw,nw,sw,nw,nw,nw,nw,nw,sw,nw,se,sw,nw,nw,sw,se,nw,nw,nw,se,n,nw,nw,n,sw,nw,nw,nw,sw,se,nw,nw,nw,nw,sw,ne,nw,s,nw,se,sw,s,sw,sw,sw,n,nw,sw,n,nw,nw,se,nw,n,ne,se,sw,nw,nw,nw,nw,nw,se,se,nw,nw,nw,n,nw,n,nw,nw,nw,nw,sw,nw,sw,nw,n,sw,sw,nw,nw,se,ne,nw,sw,nw,sw,sw,nw,nw,sw,sw,se,n,sw,nw,sw,nw,sw,nw,nw,nw,nw,sw,se,nw,nw,sw,nw,sw,nw,nw,nw,ne,nw,sw,se,nw,s,nw,ne,nw,sw,nw,sw,nw,nw,nw,ne,sw,nw,nw,sw,nw,sw,nw,sw,nw,sw,sw,sw,sw,nw,sw,ne,nw,sw,nw,nw,nw,nw,nw,sw,nw,nw,sw,s,sw,nw,nw,nw,nw,sw,sw,s,nw,se,se,sw,sw,nw,nw,sw,ne,nw,sw,sw,sw,sw,sw,sw,nw,nw,n,sw,sw,nw,nw,n,nw,n,sw,sw,sw,sw,se,sw,nw,sw,sw,sw,nw,sw,nw,se,sw,nw,sw,sw,sw,nw,sw,sw,ne,sw,nw,s,se,nw,sw,nw,nw,sw,sw,nw,nw,nw,nw,sw,se,sw,n,sw,sw,sw,s,sw,se,se,nw,sw,sw,sw,nw,sw,sw,ne,nw,nw,sw,se,sw,s,sw,nw,n,nw,nw,sw,s,nw,sw,sw,sw,nw,sw,nw,ne,ne,sw,nw,nw,sw,sw,nw,ne,nw,sw,sw,ne,sw,nw,nw,nw,sw,sw,nw,s,nw,sw,nw,sw,sw,s,n,nw,sw,s,ne,sw,sw,sw,ne,ne,sw,sw,sw,sw,se,nw,sw,s,nw,se,sw,n,nw,s,sw,sw,sw,sw,sw,sw,se,sw,nw,sw,nw,se,sw,s,sw,nw,sw,ne,sw,sw,sw,sw,sw,sw,nw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,n,nw,n,sw,ne,nw,sw,n,sw,sw,sw,nw,sw,sw,nw,n,sw,nw,sw,sw,sw,sw,se,sw,sw,sw,nw,sw,nw,sw,nw,sw,sw,sw,nw,sw,sw,sw,sw,nw,sw,s,nw,sw,sw,sw,sw,sw,nw,sw,sw,sw,sw,nw,sw,sw,sw,nw,se,sw,se,sw,n,sw,sw,sw,sw,se,se,sw,nw,sw,sw,n,sw,s,sw,nw,sw,sw,sw,sw,sw,sw,sw,s,sw,nw,se,sw,sw,sw,se,sw,sw,sw,sw,sw,sw,sw,sw,nw,sw,sw,sw,s,sw,sw,nw,sw,sw,sw,nw,sw,sw,s,se,ne,sw,sw,s,nw,sw,sw,sw,sw,sw,s,sw,se,sw,s,s,sw,sw,ne,sw,sw,sw,sw,sw,sw,se,sw,sw,sw,n,sw,sw,sw,sw,ne,sw,sw,ne,se,sw,sw,sw,sw,sw,n,n,sw,nw,sw,s,sw,sw,sw,sw,ne,sw,sw,sw,ne,ne,nw,ne,sw,se,sw,n,sw,sw,sw,sw,sw,s,sw,sw,sw,sw,ne,sw,sw,sw,s,sw,sw,sw,sw,sw,n,sw,sw,sw,nw,n,sw,sw,sw,sw,sw,ne,sw,sw,n,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,nw,sw,sw,sw,sw,ne,sw,nw,sw,n,sw,sw,sw,sw,sw,n,sw,sw,sw,se,sw,sw,sw,sw,n,sw,nw,nw,sw,sw,sw,se,sw,sw,sw,s,sw,sw,nw,sw,sw,sw,nw,s,sw,n,s,s,sw,sw,sw,ne,sw,sw,sw,sw,se,s,ne,sw,sw,n,s,sw,sw,sw,se,sw,sw,se,sw,sw,ne,sw,nw,sw,sw,sw,sw,sw,sw,sw,sw,sw,s,sw,sw,sw,n,sw,sw,sw,nw,s,sw,s,se,sw,sw,sw,s,sw,s,sw,nw,s,sw,s,sw,se,n,sw,sw,sw,sw,sw,s,n,s,s,ne,nw,sw,sw,sw,se,sw,sw,sw,sw,sw,sw,n,sw,se,sw,nw,sw,sw,sw,s,n,sw,sw,n,sw,nw,sw,sw,sw,sw,sw,sw,s,nw,s,sw,sw,sw,s,n,sw,sw,sw,sw,sw,sw,ne,sw,n,sw,s,sw,s,sw,n,s,ne,sw,sw,s,s,sw,sw,nw,s,n,sw,se,sw,nw,sw,sw,sw,sw,n,sw,sw,sw,sw,ne,sw,sw,sw,sw,se,sw,sw,sw,sw,sw,n,sw,sw,s,sw,sw,sw,sw,sw,sw,sw,sw,sw,se,sw,ne,sw,sw,s,sw,sw,s,sw,sw,sw,sw,sw,s,se,nw,sw,n,sw,sw,sw,sw,sw,sw,n,sw,se,sw,s,sw,sw,ne,n,sw,n,sw,sw,sw,sw,sw,ne,s,sw,s,nw,s,sw,sw,sw,nw,s,sw,sw,sw,s,sw,s,nw,sw,sw,s,sw,sw,sw,sw,sw,n,sw,s,n,sw,s,n,s,sw,sw,sw,s,sw,sw,sw,s,n,s,sw,sw,s,sw,sw,sw,sw,s,se,se,s,sw,s,sw,sw,sw,sw,sw,sw,se,nw,sw,sw,s,nw,s,nw,sw,ne,sw,n,sw,sw,sw,s,ne,sw,s,sw,nw,sw,s,sw,s,sw,sw,ne,sw,sw,ne,s,sw,sw,ne,sw,se,nw,sw,s,s,s,sw,s,nw,nw,ne,sw,sw,sw,sw,se,sw,sw,sw,s,ne,sw,sw,sw,sw,sw,sw,sw,s,sw,se,s,sw,s,sw,sw,s,sw,s,sw,s,sw,sw,sw,ne,s,ne,s,ne,s,s,ne,nw,sw,s,sw,n,s,s,sw,sw,n,s,sw,sw,s,s,s,s,s,sw,sw,s,sw,sw,sw,sw,ne,s,sw,s,nw,sw,sw,sw,sw,sw,n,sw,sw,s,se,sw,s,sw,ne,sw,sw,se,sw,s,s,sw,se,sw,sw,n,sw,sw,sw,s,s,s,n,s,se,sw,sw,s,s,sw,sw,s,s,sw,sw,sw,sw,sw,s,se,sw,sw,n,sw,s,s,s,sw,s,s,sw,se,s,s,se,sw,sw,se,se,sw,s,n,n,n,s,s,se,s,nw,sw,sw,sw,s,sw,sw,sw,s,sw,sw,s,sw,sw,s,s,n,sw,s,sw,s,s,s,se,s,s,s,sw,s,sw,se,sw,sw,sw,sw,s,sw,s,n,se,s,s,n,sw,sw,se,s,sw,s,n,s,s,sw,nw,sw,sw,sw,n,sw,s,n,s,sw,sw,sw,s,n,sw,sw,sw,sw,s,sw,s,nw,s,s,sw,s,s,n,s,sw,s,n,n,sw,se,sw,s,sw,s,s,sw,sw,sw,s,sw,nw,nw,se,sw,sw,s,s,s,sw,s,s,sw,ne,s,sw,sw,s,sw,n,s,s,s,sw,s,sw,s,s,s,sw,sw,sw,sw,sw,s,s,sw,sw,sw,se,sw,sw,s,sw,n,sw,s,s,s,nw,s,s,sw,s,s,s,s,sw,se,sw,sw,s,sw,n,sw,s,sw,se,s,s,s,sw,sw,n,s,sw,s,s,sw,s,s,s,sw,ne,sw,s,sw,s,ne,n,s,s,sw,sw,sw,s,s,sw,sw,s,sw,s,sw,sw,sw,sw,s,s,sw,n,s,n,s,sw,se,s,sw,sw,s,sw,s,s,s,sw,s,s,s,s,s,s,nw,sw,s,sw,sw,s,s,sw,sw,sw,s,s,sw,sw,s,s,s,sw,s,s,se,se,s,se,s,s,s,s,s,nw,s,n,sw,sw,s,ne,s,s,s,s,sw,s,sw,se,se,sw,sw,sw,nw,s,s,s,ne,sw,s,s,s,s,n,s,s,sw,s,sw,s,n,s,sw,se,s,nw,s,n,s,s,s,n,s,nw,s,s,s,n,s,s,s,sw,ne,s,s,s,s,s,sw,s,ne,sw,ne,s,s,s,sw,sw,sw,s,ne,nw,ne,nw,s,sw,s,s,s,s,s,s,s,s,n,sw,s,s,s,s,ne,s,s,s,s,s,s,s,s,sw,s,se,s,s,s,s,s,s,sw,se,n,se,n,s,s,s,s,s,s,s,nw,sw,n,s,s,s,s,s,s,sw,sw,s,s,sw,s,nw,s,s,nw,s,s,s,sw,s,s,n,s,s,s,s,sw,s,s,s,sw,s,s,s,ne,se,sw,s,s,n,s,s,se,sw,sw,s,s,ne,sw,s,s,s,sw,n,s,nw,s,n,s,s,s,s,se,s,s,sw,nw,s,s,se,sw,s,s,s,s,se,sw,s,s,s,s,s,ne,sw,s,s,s,nw,s,s,s,ne,s,s,n,s,sw,s,s,s,s,s,ne,s,sw,nw,s,s,s,n,s,n,sw,s,n,s,s,s,s,s,s,n,s,nw,sw,s,nw,s,nw,s,s,s,s,s,sw,n,s,s,s,s,s,s,s,s,s,sw,s,s,s,s,s,s,s,s,s,n,s,s,s,s,s,n,s,s,s,s,s,s,s,n,nw,ne,s,s,nw,s,se,s,s,sw,s,s,s,s,n,s,s,s,s,s,sw,s,s,s,s,s,ne,s,s,s,s,s,s,s,s,s,n,s,s,s,s,s,s,s,s,s,n,s,nw,s,s,ne,s,s,ne,s,s,s,n,s,s,s,s,se,s,s,s,s,s,s,s,n,ne,s,s,s,s,se,s,n,s,sw,s,s,s,s,s,s,nw,ne,s,nw,s,s,s,ne,s,s,ne,s,s,s,s,s,sw,s,s,s,s,n,s,s,s,s,s,s,s,s,se,s,n,n,s,s,s,s,s,s,se,s,s,s,s,s,sw,n,ne,s,s,s,se,s,s,nw,s,n,s,ne,s,s,ne,se,s,s,s,s,s,s,n,n,s,nw,s,s,s,s,s,s,s,s,nw,se,s,s,se,s,ne,s,se,nw,s,nw,s,s,s,sw,nw,s,s,s,s,se,s,n,se,se,s,s,s,nw,s,s,nw,ne,ne,s,s,nw,s,s,s,se,s,se,s,ne,se,s,s,s,sw,s,s,ne,s,s,s,s,s,s,s,se,s,se,s,s,ne,s,s,s,s,s,se,s,s,nw,s,s,se,se,ne,se,se,s,s,s,s,s,s,s,se,nw,s,nw,s,s,s,n,s,s,s,s,s,s,s,s,s,s,s,nw,s,s,s,sw,s,n,s,se,s,s,s,s,s,ne,s,s,s,s,s,se,n,s,s,s,se,ne,s,s,s,s,s,sw,s,se,s,s,se,s,s,se,s,se,se,s,se,s,s,s,se,s,s,s,sw,se,s,s,s,s,s,s,s,s,nw,s,s,s,s,se,s,s,s,s,sw,ne,s,s,sw,s,s,s,se,n,s,s,sw,se,s,se,s,nw,s,s,se,s,s,s,s,n,s,nw,sw,s,s,s,n,s,s,s,s,s,s,se,s,se,se,s,s,s,s,sw,s,s,se,s,s,s,se,s,s,s,ne,se,s,s,s,nw,s,s,s,s,n,se,s,s,s,s,se,s,se,s,sw,s,ne,s,s,sw,s,sw,se,se,s,s,s,s,se,s,nw,nw,s,n,s,s,s,s,s,nw,s,s,n,s,s,sw,s,se,se,s,sw,s,s,n,s,s,s,s,se,nw,s,se,nw,s,s,s,se,se,s,se,s,ne,s,nw,sw,s,s,s,nw,s,se,s,s,s,se,s,s,s,se,se,sw,s,s,sw,s,se,s,s,s,se,sw,s,se,se,s,s,s,s,se,s,s,s,sw,se,ne,s,se,s,se,s,s,s,ne,s,sw,sw,s,s,se,s,se,se,se,s,s,s,se,s,s,sw,nw,se,nw,s,s,s,s,s,s,s,se,s,se,s,sw,se,se,s,se,s,sw,s,se,s,se,s,se,s,s,sw,nw,se,sw,s,se,s,nw,s,s,s,s,s,s,nw,n,s,se,s,se,sw,s,se,se,ne,nw,se,ne,se,se,se,s,s,s,se,sw,s,sw,se,se,se,s,se,se,se,s,s,se,sw,se,se,s,s,se,sw,s,se,s,s,se,se,s,sw,se,n,se,se,s,sw,s,se,ne,s,s,s,s,s,se,s,s,se,s,s,s,se,se,sw,s,se,s,s,n,s,se,s,se,s,n,sw,se,se,se,s,s,s,se,n,sw,s,se,sw,se,se,s,se,se,se,s,s,sw,s,s,nw,se,se,se,s,se,s,s,nw,s,s,s,s,se,s,s,s,se,s,ne,nw,s,s,se,s,sw,se,se,s,s,s,se,s,se,s,se,se,sw,n,se,se,se,s,ne,se,nw,s,s,se,s,s,se,s,s,se,se,se,s,s,ne,se,s,sw,n,s,se,se,se,s,s,s,s,se,se,se,s,se,s,nw,se,s,s,s,se,se,se,s,s,s,se,se,s,se,s,se,nw,s,s,se,s,sw,se,se,se,s,se,sw,s,se,s,s,s,s,s,se,s,se,s,se,se,se,s,sw,nw,nw,s,nw,sw,se,s,s,ne,nw,se,se,se,s,n,se,s,s,se,s,ne,se,ne,se,s,s,s,s,se,se,se,se,s,se,nw,se,s,s,ne,s,s,s,ne,se,s,sw,s,s,sw,s,se,se,se,se,sw,s,se,se,s,nw,se,s,s,se,ne,s,sw,s,s,nw,se,n,s,s,ne,se,n,ne,se,s,ne,se,s,s,ne,se,ne,n,s,se,nw,se,se,ne,s,s,s,s,ne,se,s,se,n,se,se,s,s,ne,se,s,se,se,se,s,se,nw,se,sw,se,s,s,se,sw,se,se,s,ne,se,s,ne,s,se,s,se,s,sw,se,s,s,se,s,sw,se,se,s,s,sw,s,se,s,sw,s,se,se,s,se,s,se,nw,sw,se,ne,se,se,se,s,se,se,se,nw,se,se,se,se,se,se,sw,se,se,s,se,sw,nw,se,se,s,se,s,s,se,se,s,se,se,s,nw,s,s,se,se,se,s,se,se,s,sw,sw,n,s,se,se,s,s,s,s,s,se,sw,s,se,s,nw,sw,se,sw,ne,s,se,se,se,se,n,s,se,se,se,s,s,se,s,se,s,ne,sw,se,se,sw,se,s,se,se,se,s,s,se,s,se,nw,se,s,n,se,s,se,nw,s,s,se,se,se,s,se,s,se,se,sw,se,s,sw,s,se,se,se,s,se,s,s,s,se,se,s,nw,se,nw,n,sw,s,s,s,se,se,s,se,se,se,se,s,s,ne,se,s,se,nw,se,se,ne,s,se,se,s,s,se,se,se,s,se,s,s,s,se,se,ne,s,ne,s,se,se,se,se,sw,se,se,se,se,se,se,se,sw,se,s,s,se,s,n,n,ne,se,s,ne,se,se,s,sw,se,s,nw,s,nw,se,s,s,se,se,se,se,nw,nw,se,se,se,s,n,se,se,se,ne,ne,n,se,se,se,s,se,n,s,s,ne,s,s,n,se,se,s,ne,se,se,s,nw,n,se,se,se,se,sw,se,s,s,se,se,se,se,n,n,se,se,s,s,se,nw,se,n,ne,s,se,nw,se,ne,se,se,ne,se,sw,s,s,se,se,s,se,s,se,se,se,n,s,se,se,s,s,n,s,s,se,se,se,se,se,sw,n,se,se,se,se,se,s,s,ne,s,n,s,se,s,se,se,se,se,se,ne,se,se,se,s,sw,se,ne,se,se,se,s,se,se,se,sw,se,s,ne,se,se,se,se,s,nw,ne,s,s,se,s,se,se,se,se,se,se,se,s,se,se,se,nw,s,se,sw,se,ne,ne,se,se,se,s,se,se,se,se,se,n,se,se,se,se,se,sw,nw,se,se,se,se,s,se,se,se,ne,s,ne,se,se,se,s,se,se,se,se,s,se,sw,se,se,se,se,se,sw,sw,se,se,s,se,se,se,se,n,se,se,se,se,se,se,ne,se,se,se,se,se,se,nw,se,se,se,s,se,se,se,se,se,se,se,se,se,se,se,se,s,se,s,s,se,ne,se,se,nw,nw,se,se,se,s,s,sw,s,se,se,se,se,se,se,se,se,se,se,se,n,se,se,nw,se,se,s,se,se,se,se,s,se,se,se,se,se,se,sw,se,se,se,se,se,se,se,n,se,n,se,n,nw,sw,se,sw,se,se,se,se,se,se,se,se,nw,se,se,se,se,se,se,se,se,ne,se,se,nw,ne,se,se,se,se,nw,sw,se,se,se,n,se,ne,se,ne,se,se,s,se,s,se,se,se,ne,ne,se,se,se,se,se,se,se,se,n,se,se,se,se,nw,se,se,sw,n,s,se,n,se,s,se,nw,sw,se,se,se,se,se,se,nw,se,se,se,sw,se,se,se,se,se,se,se,se,se,se,se,se,se,n,s,se,se,se,se,se,nw,n,se,se,nw,nw,se,se,se,se,n,se,se,se,se,se,se,s,sw,n,nw,se,nw,nw,n,n,n,se,n,n,n,n,s,se,n,ne,nw,ne,se,se,ne,ne,ne,se,nw,ne,sw,se,se,se,se,se,se,se,se,s,se,s,se,s,ne,se,s,sw,se,se,se,s,se,s,s,se,se,s,s,s,s,s,n,s,s,s,s,s,s,s,s,s,s,sw,s,n,s,sw,s,s,s,se,se,s,s,sw,sw,sw,sw,s,sw,ne,s,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,nw,sw,sw,sw,sw,nw,sw,nw,sw,sw,ne,nw,sw,nw,nw,se,nw,s,sw,nw,nw,sw,sw,se,sw,nw,nw,nw,s,sw,nw,ne,nw,nw,nw,nw,ne,nw,nw,sw,se,nw,nw,ne,nw,nw,nw,nw,n,nw,nw,nw,nw,nw,nw,nw,n,n,nw,nw,nw,nw,nw,se,nw,nw,nw,nw,nw,sw,se,n,n,n,nw,n,nw,ne,n,nw,nw,nw,n,nw,nw,n,n,nw,nw,n,n,n,n,sw,se,n,se,n,n,n,se,n,n,n,n,se,n,n,n,n,n,sw,n,n,n,sw,s,n,n,n,n,n,n,n,n,n,se,s,n,n,nw,ne,sw,s,n,s,s,s,n,n,n,ne,ne,n,n,n,n,n,n,n,ne,ne,n,n,ne,ne,n,n,ne,n,ne,ne,n,n,ne,ne,sw,ne,nw,ne,s,ne,sw,n,ne,n,se,ne,ne,se,nw,se,ne,sw,ne,ne,ne,ne,ne,s,ne,ne,ne,n,ne,n,ne,ne,ne,ne,ne,ne,ne,ne,se,se,ne,se,sw,ne,ne,ne,ne,ne,ne,ne,se,ne,ne,sw,ne,ne,ne,sw,ne,ne,ne,ne,ne,n,se,ne,ne,se,ne,nw,s,sw,ne,ne,ne,ne,n,n,ne,ne,se,ne,ne,ne,se,ne,ne,sw,n,sw,ne,ne,ne,ne,ne,se,nw,s,se,se,ne,ne,s,nw,ne,ne,ne,n,se,ne,ne,se,ne,ne,ne,ne,se,se,ne,ne,s,ne,ne,ne,ne,ne,se,ne,se,se,ne,ne,se,sw,ne,se,ne,ne,ne,ne,se,nw,ne,se,s,se,ne,se,sw,se,se,se,nw,se,se,ne,se,se,se,se,se,ne,ne,se,sw,ne,se,ne,ne,se,se,nw,se,se,ne,ne,se,se,se,se,se,ne,se,se,se,se,se,se,se,ne,se,se,sw,ne,s,se,s,se,se,nw,se,se,s,se,se,se,se,se,s,se,se,se,se,se,n,se,se,se,se,s,se,sw,se,se,n,se,se,se,ne,se,nw,n,nw,s,se,se,ne,s,s,se,se,s,se,n,se,sw,se,se,s,s,n,se,s,se,ne,se,se,se,se,s,se,se,sw,sw,s,se,s,s,se,s,se,s,nw,n,s,s,s,nw,se,nw,nw,ne,ne,ne,s,s,se,se,n,se,s,se,se,se,s,s,se,s,se,se,se,s,nw,ne,se,se,s,se,sw,sw,s,s,s,se,se,se,s,se,s,s,nw,se,se,se,se,ne,sw,s,se,s,s,nw,s,s,s,ne,se,nw,s,s,se,s,s,s,s,s,se,s,s,se,se,s,se,se,se,se,s,s,s,s,se,se,se,s,s,sw,se,se,s,ne,sw,n,s,s,n,s,se,s,s,s,nw,se,nw,s,s,s,s,s,sw,s,s,s,s,s,s,sw,n,ne,nw,ne,s,s,s,s,s,sw,s,s,s,s,ne,s,s,s,s,s,se,ne,se,s,s,s,sw,se,s,s,sw,sw,s,s,s,s,sw,sw,s,n,n,s,se,nw,nw,s,sw,nw,sw,s,s,ne,s,s,nw,s,s,s,s,sw,sw,n,nw,n,s,s,s,s,s,s,nw,s,s,sw,nw,s,s,n,s,s,s,s,s,s,sw,s,s,s,s,sw,s,s,s,s,s,se,n,s,sw,s,sw,s,s,nw,se,sw,s,s,sw,n,s,sw,se,s,s,s,s,s,s,sw,sw,s,sw,n,sw,se,s,sw,sw,s,s,nw,s,s,sw,s,ne,s,sw,se,sw,s,s,sw,se,n,sw,s,sw,ne,s,sw,s,s,s,sw,nw,s,s,n,sw,sw,sw,s,se,s,nw,s,s,s,sw,sw,s,ne,ne,sw,sw,s,sw,s,sw,s,sw,n,n,sw,n,sw,s,se,sw,sw,sw,ne,s,sw,s,sw,sw,sw,sw,ne,sw,sw,nw,nw,s,n,s,se,s,sw,sw,se,ne,ne,sw,sw,sw,s,n,s,sw,sw,sw,sw,s,sw,sw,s,s,sw,nw,s,s,sw,sw,s,sw,sw,sw,s,sw,sw,sw,sw,sw,ne,se,sw,s,sw,ne,sw,ne,s,n,sw,sw,s,sw,ne,s,sw,ne,sw,s,sw,sw,sw,s,ne,sw,s,s,sw,sw,sw,n,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,nw,s,sw,sw,sw,ne,sw,nw,nw,sw,sw,sw,sw,sw,s,sw,n,sw,nw,nw,s,sw,sw,s,sw,sw,sw,ne,sw,nw,sw,sw,sw,nw,sw,n,nw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,sw,s,sw,sw,sw,sw,se,nw,ne,sw,n,sw,sw,sw,s,sw,se,sw,nw,sw,n,sw,se,sw,sw,s,sw,nw,sw,sw,sw,sw,sw,nw,sw,sw,sw,sw,sw,sw,sw,sw,nw,sw,sw,sw,s,sw,ne,sw,sw,nw,sw,sw,sw,sw,sw,s,sw,sw,sw,n,sw,nw,se,sw,sw,sw,sw,nw,se,nw,nw,sw,sw,sw,sw,nw,ne,nw,sw,nw,se,n,sw,sw,sw,sw,sw,nw,sw,sw,se,sw,nw,sw,nw,n,s,s,nw,nw,sw,sw,nw,n,sw,nw,sw,nw,s,ne,nw,n,nw,nw,sw,sw,n,n,sw,nw,sw,se,nw,nw,sw,nw,n,sw,sw,sw,nw,nw,nw,sw,n,nw,sw,se,sw,nw,se,nw,sw,nw,nw,nw,ne,nw,nw,nw,sw,se,n,sw,nw,nw,sw,nw,sw,sw,sw,sw,sw,sw,sw,s,sw,sw,nw,sw,nw,nw,ne,sw,nw,n,sw,sw,nw,nw,sw,n,sw,sw,nw,sw,nw,nw,sw,nw,nw,sw,ne,nw,sw,nw,n,nw,nw,nw,nw,s,nw,se,nw,sw,sw,ne,nw,nw,nw,sw,se,nw,nw,nw,sw,nw,n,sw,nw,nw,nw,sw,sw,nw,ne,nw,ne,se,nw,ne,nw,nw,nw,sw,nw,nw,sw,se,nw,nw,nw,sw,ne,sw,nw,nw,nw,sw,nw,nw,sw,ne,nw,nw,nw,nw,nw,ne,nw,nw,nw,nw,nw,nw,nw,nw,ne,nw,sw,nw,se,ne,nw,nw,sw,nw,nw,nw,sw,sw,nw,sw,sw,se,ne,nw,sw,nw,nw,n,nw,nw,se,nw,se,nw,nw,nw,ne,nw,nw,nw,nw,ne,ne,nw,sw,se,nw,nw,nw,sw,nw,nw,nw,nw,sw,ne,nw,nw,s,ne,nw,nw,nw,nw,nw,nw,nw,n,nw,nw,nw,s,nw,n,sw,ne,ne,nw,nw,s,nw,se,nw,se,nw,nw,nw,nw,nw,n,nw,nw,s,nw,nw,nw,nw,nw,nw,nw,nw,nw,nw,ne,nw,nw,nw,nw,sw,nw,nw,ne,nw,nw,nw,nw,nw,nw,nw,nw,nw,nw,nw,ne,nw,n,nw,nw,nw,nw,nw,nw,nw,nw,nw,ne,sw,nw,ne,nw,s,nw,nw,nw,n,nw,nw,nw,nw,nw,nw,se,nw,nw,n,nw,se,nw,ne,se,ne,s,nw,se,nw,nw,n,n,nw,nw,n,nw,nw,nw,nw,se,nw,ne,n,nw,nw,nw,n,nw,sw,nw,s,nw,nw,n,nw,nw,n,nw,nw,ne,sw,nw,sw,nw,ne,nw,nw,se,nw,nw,n,n,nw,n,nw,n,s,nw,nw,nw,nw,se,nw,sw,nw,nw,nw,n,ne,se,n,nw,n,nw,nw,n,nw,n,n,nw,nw,nw,nw,n,nw,nw,nw,nw,n,nw,nw,nw,n,s,sw,sw,nw,nw,nw,nw,nw,nw,nw,sw,nw,nw,nw,nw,nw,nw,n,nw,nw,nw,n,nw,nw,s,nw,nw,n,nw,ne,ne,n,n,n,n,nw,n,n,nw,n,ne,n,nw,n,n,n,se,nw,se,n,nw,nw,nw,n,nw,s,n,nw,nw,nw,n,nw,nw,nw,nw,n,n,n,nw,n,s,se,n,nw,nw,nw,nw,n,nw,nw,nw,nw,n,ne,n,n,nw,s,nw,nw,nw,n,s,ne,n,nw,nw,nw,n,s,nw,se,sw,se,nw,n,n,nw,nw,nw,nw,n,nw,nw,nw,n,n,n,nw,ne,nw,n,nw,se,ne,s,nw,nw,n,nw,nw,s,nw,s,s,n,sw,nw,n,s,n,n,ne,se,nw,n,nw,nw,se,n,nw,nw,nw,n,nw,n,nw,nw,s,n,nw,nw,n,ne,n,ne,n,n,nw,se,sw,n,n,nw,nw,n,nw,ne,nw,n,n,nw,nw,n,n,n,nw,nw,nw,se,n,nw,sw,nw,n,n,se,n,nw,nw,nw,n,nw,nw,n,nw,nw,nw,nw,n,n,se,ne,n,n,nw,se,nw,n,n,n,se,nw,n,n,n,n,n,n,ne,n,nw,n,se,n,nw,nw,n,n,n,nw,n,n,s,nw,nw,n,n,n,n,n,nw,nw,n,sw,n,sw,s,n,n,n,n,n,n,n,n,nw,n,n,n,n,se,ne,n,s,n,n,nw,nw,n,nw,nw,n,n,nw,n,n,n,sw,nw,nw,se,n,n,nw,n,n,n,n,n,n,n,n,nw,sw,n,nw,n,nw,n,n,n,n,n,s,nw,nw,ne,n,s,ne,nw,n,n,n,n,s,nw,ne,n,n,n,nw,n,n,n,n,s,s,n,n,n,n,n,n,n,n,n,n,n,n,n,n,s,s,n,n,se,n,n,ne,n,n,n,n,n,n,n,n,n,n,n,nw,s,n,n,n,n,n,n,n,n,nw,n,n,nw,se,n,n,n,n,n,nw,n,n,n,n,n,n,n,sw,se,n,n,se,n,n,n,sw,n,n,n,s,n,n,sw,n,n,n,n,n,n,n,n,n,n,n,n,n,se,n,n,n,sw,n,ne,nw,s,n,nw,n,n,ne,se,ne,n,n,n,n,s,n,n,n,n,n,s,n,n,n,n,n,n,nw,n,sw,n,n,se,nw,n,n,n,n,se,n,n,n,n,n,n,nw,se,n,n,sw,n,n,n,n,n,n,n,n,n,n,n,n,n,n,n,n,n,n,se,nw,s,s,n,n,n,n,n,ne,s,n,n,sw,n,n,n,n,n,ne,n,n,n,n,ne,ne,sw,s,ne,n,ne,s,n,s,n,n,n,se,n,n,ne,ne,n,n,n,n,n,n,n,se,ne,s,ne,n,n,ne,n,ne,ne,n,n,se,n,ne,sw,n,n,n,n,n,n,n,n,n,n,n,ne,n,n,n,sw,n,n,s,se,sw,n,ne,ne,n,se,ne,n,n,n,n,n,n,ne,n,n,ne,n,ne,ne,ne,n,ne,n,s,n,se,nw,ne,nw,n,se,n,n,nw,n,ne,n,n,ne,n,ne,s,s,sw,nw,n,s,ne,n,n,se,se,n,n,n,n,ne,n,n,ne,n,n,ne,ne,ne,n,n,n,n,ne,ne,n,n,s,n,n,ne,n,n,n,ne,ne,n,n,ne,ne,n,n,n,ne,ne,n,se,ne,ne,ne,n,n,sw,ne,ne,ne,n,n,n,ne,n,n,n,sw,se,se,n,n,n,ne,n,n,n,ne,ne,n,se,s,n,n,n,ne,n,sw,ne,ne,ne,n,ne,n,n,n,ne,n,ne,n,se,n,ne,ne,se,n,n,n,n,n,n,n,se,n,n,n,n,s,n,ne,ne,nw,ne,ne,n,nw,n,n,n,n,n,n,n,n,ne,n,s,n,ne,ne,n,ne,ne,s,n,ne,n,ne,n,ne,ne,ne,ne,sw,n,ne,s,ne,ne,ne,se,ne,ne,ne,ne,n,ne,ne,ne,se,n,ne,ne,n,ne,n,ne,ne,se,n,ne,n,n,n,n,ne,ne,ne,n,n,ne,ne,ne,ne,sw,ne,sw,nw,nw,s,n,ne,se,ne,ne,n,n,ne,n,ne,ne,s,n,ne,sw,ne,n,n,ne,se,n,ne,sw,n,nw,n,n,ne,ne,s,ne,n,ne,sw,ne,n,ne,n,n,n,n,ne,sw,ne,se,n,n,sw,n,s,nw,n,ne,ne,ne,ne,n,n,ne,ne,sw,n,n,ne,ne,nw,ne,n,nw,nw,ne,n,ne,ne,ne,ne,n,n,ne,ne,ne,s,n,nw,ne,ne,ne,nw,nw,n,se,nw,ne,ne,ne,ne,n,n,ne,n,ne,nw,n,ne,s,ne,n,s,ne,ne,nw,ne,n,ne,nw,se,n,n,n,n,ne,s,ne,n,n,ne,ne,n,ne,ne,n,ne,ne,se,n,ne,n,ne,n,nw,ne,n,n,ne,ne,ne,n,ne,n,s,ne,ne,ne,n,ne,n,ne,s,n,n,ne,n,ne,ne,ne,n,n,ne,n,ne,ne,s,ne,n,n,ne,ne,ne,n,ne,ne,n,ne,nw,ne,ne,ne,s,ne,s,ne,se,n,ne,sw,ne,ne,n,ne,ne,ne,ne,ne,sw,ne,s,n,n,sw,s,ne,n,ne,n,ne,ne,ne,ne,nw,ne,ne,n,ne,ne,nw,se,ne,ne,nw,s,ne,ne,ne,ne,ne,ne,s,ne,ne,ne,ne,ne,ne,sw,ne,n,ne,ne,ne,ne,n,ne,ne,ne,se,ne,se,ne,n,n,ne,ne,ne,n,ne,sw,n,ne,n,ne,ne,n,n,n,se,ne,n,sw,se,s,sw,ne,ne,n,n,n,sw,ne,ne,s,ne,ne,n,n,ne,ne,ne,nw,ne,ne,s,ne,ne,ne,ne,ne,n,ne,ne,n,ne,ne,nw,ne,se,n,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,ne,n,ne,ne,ne,ne,ne,ne,ne,s,sw,ne,n,se,ne,ne,sw,ne,nw,ne,ne,nw,n,n,ne,ne,ne,ne,ne,ne,nw,ne,sw,ne,ne,ne,nw,ne,ne,ne,ne,ne,ne,ne,nw,ne,ne,ne,nw,ne,nw,nw,ne,nw,ne,ne,ne,n,se,n,sw,ne,ne,ne,ne,ne,ne,ne,se,sw,ne";

        public const string Day12 = @"0 <-> 199, 1774
1 <-> 350, 1328, 1920
2 <-> 477, 984, 1419
3 <-> 1465, 1568
4 <-> 359, 1047, 1215, 1580, 1969
5 <-> 613
6 <-> 49, 617, 1213
7 <-> 1263
8 <-> 410
9 <-> 1224
10 <-> 1157
11 <-> 304, 1168, 1875
12 <-> 868, 891, 1369, 1712
13 <-> 958, 1371
14 <-> 1814
15 <-> 261, 556
16 <-> 830, 1646, 1901, 1933
17 <-> 962, 1778
18 <-> 109, 1229
19 <-> 239, 1070, 1886, 1930
20 <-> 327, 1307, 1801, 1905
21 <-> 943, 1950
22 <-> 1310
23 <-> 659, 917
24 <-> 373
25 <-> 369
26 <-> 947, 1023
27 <-> 338, 1901
28 <-> 1691
29 <-> 132, 1219, 1699, 1962
30 <-> 424, 822, 1419
31 <-> 1444, 1464
32 <-> 702, 1517
33 <-> 1639
34 <-> 909
35 <-> 690, 1655
36 <-> 988, 1149, 1166
37 <-> 649, 1300, 1441, 1699
38 <-> 1848
39 <-> 382
40 <-> 827, 1203, 1510
41 <-> 714, 1056, 1184
42 <-> 1018, 1873
43 <-> 214
44 <-> 670, 957
45 <-> 45
46 <-> 1195
47 <-> 559, 1504
48 <-> 1958
49 <-> 6
50 <-> 50, 1248
51 <-> 1151
52 <-> 52, 521, 1791
53 <-> 304
54 <-> 601
55 <-> 1328
56 <-> 939
57 <-> 1583, 1995
58 <-> 1422, 1694
59 <-> 395, 1233
60 <-> 862, 1811
61 <-> 345, 1694
62 <-> 62, 276
63 <-> 280
64 <-> 199
65 <-> 117, 930
66 <-> 364, 697
67 <-> 1043
68 <-> 287, 504, 1554
69 <-> 498, 706
70 <-> 77, 333, 713, 972, 1299
71 <-> 1643
72 <-> 694
73 <-> 1381
74 <-> 955, 1790
75 <-> 1691, 1743
76 <-> 76, 638, 1429
77 <-> 70
78 <-> 1513
79 <-> 1397, 1716
80 <-> 897
81 <-> 968, 1841
82 <-> 649
83 <-> 522
84 <-> 84, 125, 399, 498
85 <-> 880, 1554, 1888
86 <-> 86
87 <-> 579, 1947
88 <-> 470, 1451, 1750
89 <-> 805, 1434
90 <-> 453
91 <-> 1208
92 <-> 688, 1358, 1746
93 <-> 357, 647
94 <-> 234, 1270, 1520
95 <-> 620, 1454
96 <-> 390, 869, 919
97 <-> 693, 1783
98 <-> 259, 529, 782, 1018
99 <-> 678
100 <-> 1215
101 <-> 459, 887
102 <-> 888, 1135
103 <-> 1006
104 <-> 1375, 1422
105 <-> 1657, 1730
106 <-> 216, 1434
107 <-> 333
108 <-> 468, 1654
109 <-> 18, 1791
110 <-> 372
111 <-> 111, 861, 1383
112 <-> 1359, 1937
113 <-> 414, 736, 1446
114 <-> 426, 1457
115 <-> 1605, 1672
116 <-> 116, 713, 1584, 1602
117 <-> 65
118 <-> 1611, 1897
119 <-> 541, 1569
120 <-> 412, 787
121 <-> 1344
122 <-> 698, 752, 1693
123 <-> 1173, 1576, 1634, 1802
124 <-> 735
125 <-> 84, 1032
126 <-> 126, 225, 332
127 <-> 1350
128 <-> 128, 319, 327, 1582
129 <-> 129, 654, 1260
130 <-> 1080, 1296, 1350
131 <-> 131
132 <-> 29, 856, 1064
133 <-> 659, 1367, 1776
134 <-> 648, 1147, 1450, 1910
135 <-> 411
136 <-> 353, 935, 1590
137 <-> 228
138 <-> 194, 452, 1746, 1794
139 <-> 139, 494, 1635
140 <-> 681
141 <-> 1507
142 <-> 1288
143 <-> 845
144 <-> 1516
145 <-> 502, 1146, 1155, 1809
146 <-> 146, 750
147 <-> 1600
148 <-> 1206
149 <-> 829, 1457
150 <-> 675, 915
151 <-> 651, 1678
152 <-> 888, 1503
153 <-> 498, 960, 1515
154 <-> 1468
155 <-> 751
156 <-> 528, 803, 1655
157 <-> 1486, 1937
158 <-> 590, 1876
159 <-> 159, 185, 1287, 1550, 1588
160 <-> 160, 548
161 <-> 1303, 1364
162 <-> 1855
163 <-> 1181
164 <-> 442
165 <-> 490
166 <-> 1105
167 <-> 1121
168 <-> 760, 1129
169 <-> 747
170 <-> 1890
171 <-> 1644
172 <-> 593, 665
173 <-> 1092, 1869
174 <-> 705
175 <-> 1345, 1999
176 <-> 234, 606
177 <-> 557, 688
178 <-> 373
179 <-> 1376
180 <-> 638
181 <-> 1996
182 <-> 1094, 1206, 1748
183 <-> 931
184 <-> 880
185 <-> 159, 1058, 1704
186 <-> 765, 1178, 1877
187 <-> 732
188 <-> 188
189 <-> 189, 1871
190 <-> 395, 1639
191 <-> 441
192 <-> 192, 1034
193 <-> 494
194 <-> 138, 995, 1308
195 <-> 1024
196 <-> 226, 1632, 1919
197 <-> 786
198 <-> 286, 758, 1852
199 <-> 0, 64, 1646
200 <-> 314
201 <-> 459, 658
202 <-> 321, 492, 599, 1081, 1460
203 <-> 225
204 <-> 331, 462, 600
205 <-> 898
206 <-> 734, 1321
207 <-> 558, 991
208 <-> 397
209 <-> 1145, 1886
210 <-> 1343, 1925
211 <-> 840, 1409
212 <-> 1308
213 <-> 1813
214 <-> 43, 282
215 <-> 1270
216 <-> 106, 836, 1275, 1507
217 <-> 312
218 <-> 290, 386, 639, 1920
219 <-> 784, 1001
220 <-> 220, 322
221 <-> 1681
222 <-> 1616, 1653
223 <-> 436, 1272, 1625
224 <-> 1398, 1696
225 <-> 126, 203, 1182
226 <-> 196, 1655
227 <-> 623
228 <-> 137, 923
229 <-> 253, 1387
230 <-> 1374
231 <-> 389, 1499
232 <-> 442
233 <-> 473, 1406
234 <-> 94, 176
235 <-> 235
236 <-> 607, 838, 1487, 1856
237 <-> 818
238 <-> 387, 628
239 <-> 19
240 <-> 818
241 <-> 1027, 1524
242 <-> 1085, 1971
243 <-> 1942
244 <-> 299, 390, 916
245 <-> 906
246 <-> 246, 534, 763, 1427
247 <-> 531, 1675
248 <-> 336, 1832
249 <-> 1497
250 <-> 1836
251 <-> 1309
252 <-> 581, 1104
253 <-> 229, 877, 1743
254 <-> 254, 621
255 <-> 831, 866, 874
256 <-> 1942
257 <-> 906
258 <-> 1224
259 <-> 98, 316, 419, 718, 1519
260 <-> 1223, 1516, 1547, 1845, 1944
261 <-> 15, 278, 1607, 1808
262 <-> 1112, 1172
263 <-> 424
264 <-> 680
265 <-> 1968
266 <-> 804, 1252
267 <-> 1739
268 <-> 538, 546
269 <-> 1265
270 <-> 270
271 <-> 1150
272 <-> 272
273 <-> 1208, 1537
274 <-> 1427
275 <-> 1349, 1829
276 <-> 62, 906
277 <-> 461, 634, 1887
278 <-> 261, 1224, 1904
279 <-> 303, 537
280 <-> 63, 280, 926, 931
281 <-> 862, 1041, 1119, 1863
282 <-> 214, 488, 644
283 <-> 646, 1124
284 <-> 860, 1759
285 <-> 746
286 <-> 198
287 <-> 68, 1045
288 <-> 332, 1133, 1277, 1628, 1744, 1770, 1934
289 <-> 1578, 1766
290 <-> 218, 439, 1661
291 <-> 596, 1377, 1620
292 <-> 700, 848, 1099
293 <-> 293, 1592, 1938
294 <-> 653, 1948
295 <-> 1505, 1936
296 <-> 625, 925
297 <-> 1105, 1185
298 <-> 298, 544, 1444
299 <-> 244, 933, 1012
300 <-> 300, 1461, 1883
301 <-> 880, 1698
302 <-> 1221
303 <-> 279, 375
304 <-> 11, 53, 967, 1362
305 <-> 777
306 <-> 344
307 <-> 582, 770
308 <-> 792, 1895
309 <-> 539
310 <-> 390, 1482
311 <-> 441, 1294
312 <-> 217, 743
313 <-> 1522
314 <-> 200, 502, 835, 1084, 1134
315 <-> 1970
316 <-> 259
317 <-> 1302, 1437
318 <-> 365
319 <-> 128, 976
320 <-> 1056, 1466, 1778
321 <-> 202
322 <-> 220, 1431
323 <-> 838, 1465, 1895
324 <-> 443
325 <-> 1056
326 <-> 463, 1741, 1761
327 <-> 20, 128, 681, 1797
328 <-> 328, 348
329 <-> 378, 1738
330 <-> 459
331 <-> 204, 331
332 <-> 126, 288
333 <-> 70, 107, 1747
334 <-> 517, 614
335 <-> 1259
336 <-> 248, 550, 1485
337 <-> 337
338 <-> 27, 1212, 1264
339 <-> 430, 963
340 <-> 769
341 <-> 341
342 <-> 593, 718, 895
343 <-> 569
344 <-> 306, 1440, 1650, 1742
345 <-> 61, 1006, 1664
346 <-> 448, 1928
347 <-> 1022, 1052
348 <-> 328, 1232
349 <-> 1232
350 <-> 1, 526, 1086, 1821
351 <-> 584
352 <-> 518, 686, 1324, 1437
353 <-> 136, 936
354 <-> 1470
355 <-> 1173, 1814
356 <-> 698
357 <-> 93
358 <-> 737, 986, 1169
359 <-> 4
360 <-> 363
361 <-> 417, 841
362 <-> 928
363 <-> 360, 1751
364 <-> 66, 364, 1596
365 <-> 318, 1766
366 <-> 366
367 <-> 367
368 <-> 1897
369 <-> 25, 369, 1460
370 <-> 370
371 <-> 1568
372 <-> 110, 582
373 <-> 24, 178, 1924
374 <-> 374
375 <-> 303
376 <-> 1331, 1990
377 <-> 388, 601, 837
378 <-> 329
379 <-> 623
380 <-> 671
381 <-> 938
382 <-> 39, 1458
383 <-> 383, 1490, 1763, 1844
384 <-> 832
385 <-> 745, 1673
386 <-> 218, 779
387 <-> 238
388 <-> 377, 1817
389 <-> 231, 656, 1038, 1960
390 <-> 96, 244, 310, 721, 1094, 1501
391 <-> 438, 819, 1870
392 <-> 697
393 <-> 443, 1275, 1463
394 <-> 480
395 <-> 59, 190, 1117, 1997
396 <-> 595
397 <-> 208, 397, 1727
398 <-> 1153
399 <-> 84
400 <-> 825, 1693
401 <-> 812
402 <-> 1191
403 <-> 1446, 1820
404 <-> 442, 871, 1637
405 <-> 426, 1067
406 <-> 460, 1290
407 <-> 1951
408 <-> 1335, 1391, 1897
409 <-> 984, 1217
410 <-> 8, 1607
411 <-> 135, 411, 454, 1393
412 <-> 120
413 <-> 1208
414 <-> 113
415 <-> 415, 1803
416 <-> 428
417 <-> 361
418 <-> 1129
419 <-> 259
420 <-> 628
421 <-> 1485
422 <-> 1110, 1785
423 <-> 1418
424 <-> 30, 263
425 <-> 1497
426 <-> 114, 405, 780
427 <-> 427
428 <-> 416, 782
429 <-> 429
430 <-> 339, 1513
431 <-> 886, 1408
432 <-> 586, 1725
433 <-> 889, 1753, 1881
434 <-> 1078, 1120
435 <-> 660, 1194, 1662
436 <-> 223, 1332
437 <-> 1487
438 <-> 391
439 <-> 290
440 <-> 1828
441 <-> 191, 311, 1003, 1561, 1702
442 <-> 164, 232, 404
443 <-> 324, 393
444 <-> 1215, 1251
445 <-> 792
446 <-> 1015, 1392
447 <-> 777
448 <-> 346, 1097
449 <-> 1117
450 <-> 1395
451 <-> 1414, 1845
452 <-> 138
453 <-> 90, 453
454 <-> 411
455 <-> 1801
456 <-> 456, 791, 902, 1111
457 <-> 457, 1075, 1384
458 <-> 770, 1600
459 <-> 101, 201, 330, 1108
460 <-> 406, 1529
461 <-> 277, 839, 1552
462 <-> 204
463 <-> 326, 1899
464 <-> 1098
465 <-> 764, 1630, 1779
466 <-> 627
467 <-> 904
468 <-> 108, 1849
469 <-> 469, 603, 780
470 <-> 88, 1276, 1533
471 <-> 1492
472 <-> 472, 1048, 1409, 1518, 1758
473 <-> 233, 1413, 1826
474 <-> 780
475 <-> 1005, 1968
476 <-> 809
477 <-> 2
478 <-> 753
479 <-> 479, 1296, 1615
480 <-> 394, 775, 1623
481 <-> 774, 1604
482 <-> 763
483 <-> 522, 591, 1344
484 <-> 894, 1219
485 <-> 507, 1114, 1250, 1351
486 <-> 1099, 1879
487 <-> 487
488 <-> 282, 1164, 1189
489 <-> 900, 1889
490 <-> 165, 918, 1007
491 <-> 1800
492 <-> 202
493 <-> 615, 899, 1200, 1326
494 <-> 139, 193
495 <-> 704, 1988
496 <-> 496
497 <-> 1149, 1216
498 <-> 69, 84, 153
499 <-> 1125, 1149
500 <-> 642
501 <-> 524, 1176
502 <-> 145, 314
503 <-> 1330, 1626
504 <-> 68, 699
505 <-> 672
506 <-> 1083
507 <-> 485, 1743
508 <-> 520, 1236, 1296
509 <-> 1676
510 <-> 875, 1066
511 <-> 511
512 <-> 512, 1240
513 <-> 705, 812
514 <-> 1758
515 <-> 1165, 1168
516 <-> 811
517 <-> 334, 1132, 1339
518 <-> 352, 1674
519 <-> 824, 1396, 1659
520 <-> 508
521 <-> 52, 915
522 <-> 83, 483, 1637
523 <-> 1317
524 <-> 501
525 <-> 525
526 <-> 350, 850, 930
527 <-> 527, 1338, 1449
528 <-> 156
529 <-> 98
530 <-> 691, 1175, 1505
531 <-> 247, 785, 1389, 1623
532 <-> 1159
533 <-> 1152, 1297
534 <-> 246
535 <-> 1144, 1491, 1622, 1935
536 <-> 708
537 <-> 279, 1656
538 <-> 268, 538, 1756
539 <-> 309, 802
540 <-> 1239
541 <-> 119, 1679, 1741
542 <-> 1204
543 <-> 642, 1926
544 <-> 298
545 <-> 1971
546 <-> 268
547 <-> 1465, 1613, 1614
548 <-> 160
549 <-> 820
550 <-> 336
551 <-> 1733
552 <-> 552, 1563
553 <-> 1654
554 <-> 554, 1641, 1665
555 <-> 555
556 <-> 15
557 <-> 177, 1204
558 <-> 207, 1004
559 <-> 47, 1297
560 <-> 1189, 1709
561 <-> 1013, 1709
562 <-> 762, 912
563 <-> 563
564 <-> 585
565 <-> 1333, 1494
566 <-> 566, 938
567 <-> 894
568 <-> 586, 1397
569 <-> 343, 1572
570 <-> 704, 1220, 1459
571 <-> 1451
572 <-> 651, 846, 909
573 <-> 1881
574 <-> 1866
575 <-> 1379
576 <-> 1060, 1210
577 <-> 1837
578 <-> 1346
579 <-> 87
580 <-> 1509
581 <-> 252, 1548
582 <-> 307, 372
583 <-> 624, 1599, 1753, 1908
584 <-> 351, 774
585 <-> 564, 977
586 <-> 432, 568, 773, 1789
587 <-> 826
588 <-> 1854
589 <-> 719, 845, 1214
590 <-> 158, 1259
591 <-> 483
592 <-> 743, 898
593 <-> 172, 342, 852, 943, 1053
594 <-> 594
595 <-> 396, 928
596 <-> 291, 596
597 <-> 597
598 <-> 1980
599 <-> 202, 1764
600 <-> 204
601 <-> 54, 377, 1340
602 <-> 1718, 1866
603 <-> 469, 789
604 <-> 1006, 1033, 1626
605 <-> 1535
606 <-> 176
607 <-> 236, 911, 1218
608 <-> 1193, 1825
609 <-> 1657
610 <-> 733, 841
611 <-> 747, 1892
612 <-> 1098, 1196, 1267
613 <-> 5, 1372
614 <-> 334, 1492
615 <-> 493, 798
616 <-> 1025, 1940
617 <-> 6, 666, 1155
618 <-> 762, 1621, 1895
619 <-> 1187
620 <-> 95, 1761
621 <-> 254
622 <-> 784, 1476
623 <-> 227, 379, 1081
624 <-> 583
625 <-> 296, 1222, 1882
626 <-> 905
627 <-> 466, 1692
628 <-> 238, 420, 1004, 1412
629 <-> 1532
630 <-> 630
631 <-> 977, 1092, 1458, 1713
632 <-> 777, 1049, 1404
633 <-> 994
634 <-> 277
635 <-> 635
636 <-> 703, 1756
637 <-> 840, 1585
638 <-> 76, 180, 1373
639 <-> 218, 639, 1835
640 <-> 1559
641 <-> 1800
642 <-> 500, 543
643 <-> 1808
644 <-> 282
645 <-> 1253, 1475
646 <-> 283, 646, 864
647 <-> 93, 1508
648 <-> 134, 956, 1762
649 <-> 37, 82
650 <-> 1480, 1916
651 <-> 151, 572, 1357
652 <-> 1261
653 <-> 294, 653
654 <-> 129, 1139, 1176
655 <-> 1251, 1656
656 <-> 389
657 <-> 1604
658 <-> 201, 1208
659 <-> 23, 133, 1868
660 <-> 435
661 <-> 1634
662 <-> 1667, 1701
663 <-> 974
664 <-> 664, 1167
665 <-> 172, 1370
666 <-> 617
667 <-> 1824
668 <-> 952, 1605
669 <-> 1822
670 <-> 44, 670
671 <-> 380, 1145, 1693, 1906
672 <-> 505, 693
673 <-> 1610
674 <-> 1249, 1302
675 <-> 150, 777
676 <-> 1675
677 <-> 910, 1282
678 <-> 99, 1004
679 <-> 679
680 <-> 264, 917, 1137, 1687
681 <-> 140, 327, 746
682 <-> 682
683 <-> 794, 1315
684 <-> 1000, 1342
685 <-> 1111, 1348, 1523, 1932
686 <-> 352
687 <-> 979, 1667
688 <-> 92, 177
689 <-> 937, 1939
690 <-> 35, 1608
691 <-> 530, 691
692 <-> 1871
693 <-> 97, 672
694 <-> 72, 694
695 <-> 1076
696 <-> 1954
697 <-> 66, 392, 1892
698 <-> 122, 356, 698
699 <-> 504, 1470
700 <-> 292, 1407
701 <-> 1231, 1327
702 <-> 32
703 <-> 636, 1083, 1210
704 <-> 495, 570
705 <-> 174, 513, 1332
706 <-> 69, 1088
707 <-> 1036, 1867
708 <-> 536, 805, 1958
709 <-> 709
710 <-> 915, 1578
711 <-> 711, 1478
712 <-> 813, 927
713 <-> 70, 116, 1469, 1539
714 <-> 41
715 <-> 840, 1473, 1562, 1705
716 <-> 716
717 <-> 949, 1864
718 <-> 259, 342, 1557, 1853
719 <-> 589, 781, 802
720 <-> 1125
721 <-> 390, 878
722 <-> 1026
723 <-> 1039, 1467
724 <-> 1535
725 <-> 883
726 <-> 1832, 1917
727 <-> 1245
728 <-> 1291
729 <-> 1203
730 <-> 824
731 <-> 1984
732 <-> 187, 1214
733 <-> 610, 1079, 1198
734 <-> 206, 872, 1479, 1855
735 <-> 124, 1371
736 <-> 113, 736
737 <-> 358, 1426
738 <-> 974, 1024, 1717, 1842
739 <-> 1489
740 <-> 1634
741 <-> 873, 1695
742 <-> 1700
743 <-> 312, 592, 1493
744 <-> 948, 1306, 1400
745 <-> 385, 1029, 1315, 1474
746 <-> 285, 681, 793
747 <-> 169, 611, 814, 1548
748 <-> 748
749 <-> 1134, 1498
750 <-> 146
751 <-> 155, 783, 1856
752 <-> 122, 1417
753 <-> 478, 1505
754 <-> 810, 1742, 1955
755 <-> 1735, 1847
756 <-> 978, 1095
757 <-> 1153, 1730
758 <-> 198, 1476
759 <-> 759
760 <-> 168
761 <-> 1496
762 <-> 562, 618
763 <-> 246, 482, 1258
764 <-> 465
765 <-> 186
766 <-> 1448
767 <-> 893, 896, 1019
768 <-> 1730
769 <-> 340, 1043, 1065
770 <-> 307, 458, 1453
771 <-> 1168
772 <-> 911
773 <-> 586
774 <-> 481, 584, 774, 1148
775 <-> 480, 1485, 1894
776 <-> 926
777 <-> 305, 447, 632, 675
778 <-> 1690
779 <-> 386
780 <-> 426, 469, 474
781 <-> 719, 1543
782 <-> 98, 428, 903
783 <-> 751, 1558
784 <-> 219, 622
785 <-> 531
786 <-> 197, 911, 1312
787 <-> 120, 880
788 <-> 1089, 1487
789 <-> 603, 844, 1681, 1731
790 <-> 790, 1126
791 <-> 456, 1363
792 <-> 308, 445
793 <-> 746
794 <-> 683, 951
795 <-> 1732, 1986
796 <-> 1210, 1878
797 <-> 804
798 <-> 615
799 <-> 1651
800 <-> 851, 860, 1907
801 <-> 1110, 1537, 1773
802 <-> 539, 719
803 <-> 156, 1528
804 <-> 266, 797, 1549
805 <-> 89, 708, 962
806 <-> 1429
807 <-> 1800
808 <-> 873, 1421
809 <-> 476, 809
810 <-> 754
811 <-> 516, 965
812 <-> 401, 513
813 <-> 712, 1023
814 <-> 747
815 <-> 1145
816 <-> 1413
817 <-> 1235
818 <-> 237, 240, 1506
819 <-> 391, 857
820 <-> 549, 1162
821 <-> 1410, 1607
822 <-> 30, 1485
823 <-> 1445, 1454
824 <-> 519, 730, 1824
825 <-> 400, 1381, 1472
826 <-> 587, 1040, 1198, 1618
827 <-> 40
828 <-> 1870
829 <-> 149
830 <-> 16
831 <-> 255
832 <-> 384, 1890, 1913
833 <-> 1529
834 <-> 834
835 <-> 314
836 <-> 216, 1166
837 <-> 377, 988
838 <-> 236, 323
839 <-> 461, 1825
840 <-> 211, 637, 715, 1710
841 <-> 361, 610, 841, 1815
842 <-> 1669
843 <-> 874, 1468
844 <-> 789
845 <-> 143, 589, 1053
846 <-> 572
847 <-> 1285
848 <-> 292
849 <-> 849
850 <-> 526
851 <-> 800, 1368, 1497
852 <-> 593, 1798
853 <-> 1339, 1593, 1749
854 <-> 1445, 1787
855 <-> 1026, 1356
856 <-> 132
857 <-> 819
858 <-> 1511
859 <-> 1191
860 <-> 284, 800, 1619
861 <-> 111, 1266
862 <-> 60, 281
863 <-> 1605
864 <-> 646
865 <-> 873
866 <-> 255, 924
867 <-> 871, 1707
868 <-> 12
869 <-> 96, 1278
870 <-> 1307
871 <-> 404, 867, 1482
872 <-> 734, 1200
873 <-> 741, 808, 865, 873
874 <-> 255, 843, 1201
875 <-> 510, 1325, 1797
876 <-> 1504, 1825
877 <-> 253
878 <-> 721
879 <-> 948, 1291, 1847
880 <-> 85, 184, 301, 787, 1503, 1617
881 <-> 1688
882 <-> 882
883 <-> 725, 1582, 1874
884 <-> 1352
885 <-> 885, 1974
886 <-> 431, 1650
887 <-> 101
888 <-> 102, 152
889 <-> 433, 1016
890 <-> 890
891 <-> 12
892 <-> 1402, 1923
893 <-> 767
894 <-> 484, 567
895 <-> 342, 1123, 1158, 1648
896 <-> 767
897 <-> 80, 986, 1418
898 <-> 205, 592, 1019
899 <-> 493, 1053
900 <-> 489
901 <-> 901
902 <-> 456
903 <-> 782
904 <-> 467, 904, 1924
905 <-> 626, 1881
906 <-> 245, 257, 276
907 <-> 907, 1101, 1826
908 <-> 908, 1230
909 <-> 34, 572, 1186
910 <-> 677, 961
911 <-> 607, 772, 786, 1196, 1405
912 <-> 562
913 <-> 1636
914 <-> 1892, 1963
915 <-> 150, 521, 710
916 <-> 244
917 <-> 23, 680, 1336
918 <-> 490, 1483
919 <-> 96
920 <-> 1880
921 <-> 921
922 <-> 975, 1255
923 <-> 228, 1202, 1452
924 <-> 866
925 <-> 296, 1270
926 <-> 280, 776, 1170, 1788, 1970
927 <-> 712
928 <-> 362, 595, 1103
929 <-> 929
930 <-> 65, 526, 1256, 1500, 1722
931 <-> 183, 280, 1484
932 <-> 1737
933 <-> 299
934 <-> 1387, 1851
935 <-> 136, 935, 1537, 1775
936 <-> 353
937 <-> 689, 1347
938 <-> 381, 566
939 <-> 56, 1762
940 <-> 1559, 1860
941 <-> 1504, 1671, 1723, 1724
942 <-> 1293
943 <-> 21, 593
944 <-> 1335
945 <-> 1650
946 <-> 1556
947 <-> 26
948 <-> 744, 879
949 <-> 717, 1604
950 <-> 1201, 1322
951 <-> 794
952 <-> 668, 1371
953 <-> 1272
954 <-> 954
955 <-> 74
956 <-> 648, 1870
957 <-> 44, 1769
958 <-> 13, 1388, 1660
959 <-> 959
960 <-> 153
961 <-> 910
962 <-> 17, 805
963 <-> 339, 1783
964 <-> 1100
965 <-> 811, 1677
966 <-> 966
967 <-> 304, 1029, 1269, 1910
968 <-> 81, 1091
969 <-> 1379, 1693
970 <-> 1289
971 <-> 971
972 <-> 70
973 <-> 973
974 <-> 663, 738, 1005
975 <-> 922
976 <-> 319
977 <-> 585, 631
978 <-> 756, 1628
979 <-> 687, 979
980 <-> 1151, 1317
981 <-> 1199, 1902
982 <-> 1223
983 <-> 1931
984 <-> 2, 409
985 <-> 985
986 <-> 358, 897, 1564
987 <-> 987, 1644
988 <-> 36, 837
989 <-> 1275
990 <-> 990, 1295
991 <-> 207, 1415
992 <-> 1242, 1397, 1467, 1579
993 <-> 1042, 1767
994 <-> 633, 1595, 1813
995 <-> 194
996 <-> 1096, 1369
997 <-> 1231, 1973
998 <-> 1367
999 <-> 999
1000 <-> 684, 1078
1001 <-> 219
1002 <-> 1442
1003 <-> 441
1004 <-> 558, 628, 678
1005 <-> 475, 974
1006 <-> 103, 345, 604
1007 <-> 490, 1274
1008 <-> 1708, 1819
1009 <-> 1009, 1118
1010 <-> 1223, 1803
1011 <-> 1867
1012 <-> 299, 1923
1013 <-> 561, 1187, 1477, 1926
1014 <-> 1861
1015 <-> 446, 1015, 1858
1016 <-> 889
1017 <-> 1435
1018 <-> 42, 98
1019 <-> 767, 898, 1764
1020 <-> 1020
1021 <-> 1666
1022 <-> 347, 1022, 1310
1023 <-> 26, 813, 1109, 1538, 1988
1024 <-> 195, 738
1025 <-> 616
1026 <-> 722, 855, 1337, 1415
1027 <-> 241, 1309
1028 <-> 1028
1029 <-> 745, 967
1030 <-> 1577, 1689
1031 <-> 1031
1032 <-> 125
1033 <-> 604, 1127, 1194
1034 <-> 192
1035 <-> 1992
1036 <-> 707, 1509
1037 <-> 1347
1038 <-> 389
1039 <-> 723, 1535
1040 <-> 826, 1245, 1918
1041 <-> 281
1042 <-> 993
1043 <-> 67, 769, 1142
1044 <-> 1690
1045 <-> 287
1046 <-> 1561
1047 <-> 4
1048 <-> 472, 1703
1049 <-> 632, 1816
1050 <-> 1157, 1899
1051 <-> 1818
1052 <-> 347, 1904
1053 <-> 593, 845, 899
1054 <-> 1983
1055 <-> 1599
1056 <-> 41, 320, 325, 1567
1057 <-> 1372, 1569
1058 <-> 185
1059 <-> 1112, 1939
1060 <-> 576, 1314, 1557, 1751, 1752
1061 <-> 1285
1062 <-> 1162, 1338, 1739
1063 <-> 1291
1064 <-> 132
1065 <-> 769, 1317
1066 <-> 510
1067 <-> 405, 1452, 1953
1068 <-> 1200
1069 <-> 1069
1070 <-> 19
1071 <-> 1361, 1382
1072 <-> 1307, 1534
1073 <-> 1282
1074 <-> 1323, 1653
1075 <-> 457
1076 <-> 695, 1703
1077 <-> 1180
1078 <-> 434, 1000
1079 <-> 733
1080 <-> 130, 1757
1081 <-> 202, 623
1082 <-> 1082
1083 <-> 506, 703, 1279
1084 <-> 314, 1812
1085 <-> 242
1086 <-> 350
1087 <-> 1524
1088 <-> 706, 1900
1089 <-> 788
1090 <-> 1260
1091 <-> 968, 1522
1092 <-> 173, 631, 1850
1093 <-> 1093, 1390
1094 <-> 182, 390
1095 <-> 756
1096 <-> 996
1097 <-> 448
1098 <-> 464, 612
1099 <-> 292, 486
1100 <-> 964, 1326
1101 <-> 907, 1799
1102 <-> 1927
1103 <-> 928, 1103
1104 <-> 252
1105 <-> 166, 297
1106 <-> 1106, 1896
1107 <-> 1107
1108 <-> 459
1109 <-> 1023
1110 <-> 422, 801
1111 <-> 456, 685
1112 <-> 262, 1059
1113 <-> 1267
1114 <-> 485
1115 <-> 1115, 1827
1116 <-> 1596
1117 <-> 395, 449, 1382
1118 <-> 1009
1119 <-> 281, 1670
1120 <-> 434, 1165
1121 <-> 167, 1121
1122 <-> 1809
1123 <-> 895
1124 <-> 283
1125 <-> 499, 720, 1308
1126 <-> 790, 1526
1127 <-> 1033
1128 <-> 1500
1129 <-> 168, 418, 1642, 1947
1130 <-> 1454
1131 <-> 1683
1132 <-> 517, 1784
1133 <-> 288
1134 <-> 314, 749, 1586
1135 <-> 102
1136 <-> 1136
1137 <-> 680
1138 <-> 1755
1139 <-> 654
1140 <-> 1140
1141 <-> 1141
1142 <-> 1043, 1862
1143 <-> 1550
1144 <-> 535, 1144, 1849
1145 <-> 209, 671, 815, 1268
1146 <-> 145
1147 <-> 134
1148 <-> 774
1149 <-> 36, 497, 499, 1652
1150 <-> 271, 1150
1151 <-> 51, 980, 1651
1152 <-> 533
1153 <-> 398, 757
1154 <-> 1313
1155 <-> 145, 617, 1336, 1721
1156 <-> 1838
1157 <-> 10, 1050
1158 <-> 895
1159 <-> 532, 1708
1160 <-> 1357
1161 <-> 1200, 1999
1162 <-> 820, 1062
1163 <-> 1821
1164 <-> 488, 1572
1165 <-> 515, 1120
1166 <-> 36, 836
1167 <-> 664
1168 <-> 11, 515, 771, 1967
1169 <-> 358
1170 <-> 926
1171 <-> 1666, 1827
1172 <-> 262, 1439
1173 <-> 123, 355, 1341
1174 <-> 1204, 1525
1175 <-> 530
1176 <-> 501, 654
1177 <-> 1311, 1796
1178 <-> 186, 1536, 1551, 1853
1179 <-> 1822, 1947
1180 <-> 1077, 1264
1181 <-> 163, 1181
1182 <-> 225
1183 <-> 1237, 1715, 1798
1184 <-> 41
1185 <-> 297, 1185
1186 <-> 909
1187 <-> 619, 1013
1188 <-> 1698
1189 <-> 488, 560
1190 <-> 1834, 1933
1191 <-> 402, 859, 1191
1192 <-> 1839
1193 <-> 608, 1438
1194 <-> 435, 1033, 1754
1195 <-> 46, 1828
1196 <-> 612, 911, 1975
1197 <-> 1503, 1854
1198 <-> 733, 826
1199 <-> 981
1200 <-> 493, 872, 1068, 1161
1201 <-> 874, 950
1202 <-> 923
1203 <-> 40, 729, 1719
1204 <-> 542, 557, 1174
1205 <-> 1332
1206 <-> 148, 182
1207 <-> 1207
1208 <-> 91, 273, 413, 658, 1234
1209 <-> 1995
1210 <-> 576, 703, 796
1211 <-> 1227, 1891
1212 <-> 338, 1362
1213 <-> 6
1214 <-> 589, 732
1215 <-> 4, 100, 444, 1842
1216 <-> 497, 1745
1217 <-> 409, 1354
1218 <-> 607
1219 <-> 29, 484, 1712
1220 <-> 570
1221 <-> 302, 1429
1222 <-> 625, 1412
1223 <-> 260, 982, 1010, 1591
1224 <-> 9, 258, 278, 1506, 1893
1225 <-> 1906
1226 <-> 1226
1227 <-> 1211
1228 <-> 1773
1229 <-> 18
1230 <-> 908
1231 <-> 701, 997
1232 <-> 348, 349
1233 <-> 59
1234 <-> 1208
1235 <-> 817, 1994
1236 <-> 508
1237 <-> 1183
1238 <-> 1529
1239 <-> 540, 1524, 1552
1240 <-> 512
1241 <-> 1241
1242 <-> 992, 1685
1243 <-> 1934
1244 <-> 1574, 1839
1245 <-> 727, 1040
1246 <-> 1380
1247 <-> 1506, 1923
1248 <-> 50, 1610
1249 <-> 674
1250 <-> 485
1251 <-> 444, 655, 1718
1252 <-> 266, 1862
1253 <-> 645, 1709
1254 <-> 1254
1255 <-> 922, 1255, 1341
1256 <-> 930, 1346
1257 <-> 1465, 1844
1258 <-> 763
1259 <-> 335, 590, 1259
1260 <-> 129, 1090
1261 <-> 652, 1261, 1838
1262 <-> 1262, 1912
1263 <-> 7, 1438, 1554
1264 <-> 338, 1180
1265 <-> 269, 1265
1266 <-> 861, 1281, 1423
1267 <-> 612, 1113, 1289
1268 <-> 1145
1269 <-> 967
1270 <-> 94, 215, 925, 1860
1271 <-> 1376
1272 <-> 223, 953
1273 <-> 1301
1274 <-> 1007, 1860
1275 <-> 216, 393, 989, 1275
1276 <-> 470
1277 <-> 288
1278 <-> 869
1279 <-> 1083, 1755
1280 <-> 1588
1281 <-> 1266
1282 <-> 677, 1073, 1575, 1625
1283 <-> 1571
1284 <-> 1828
1285 <-> 847, 1061, 1641
1286 <-> 1494, 1649, 1889
1287 <-> 159
1288 <-> 142, 1288
1289 <-> 970, 1267, 1668
1290 <-> 406
1291 <-> 728, 879, 1063, 1885
1292 <-> 1407
1293 <-> 942, 1318, 1459
1294 <-> 311, 1754
1295 <-> 990, 1512
1296 <-> 130, 479, 508
1297 <-> 533, 559
1298 <-> 1839
1299 <-> 70
1300 <-> 37, 1886, 1998
1301 <-> 1273, 1340
1302 <-> 317, 674, 1485
1303 <-> 161, 1624
1304 <-> 1304
1305 <-> 1410
1306 <-> 744
1307 <-> 20, 870, 1072
1308 <-> 194, 212, 1125
1309 <-> 251, 1027
1310 <-> 22, 1022, 1777
1311 <-> 1177
1312 <-> 786
1313 <-> 1154, 1706
1314 <-> 1060
1315 <-> 683, 745
1316 <-> 1793, 1898
1317 <-> 523, 980, 1065, 1787
1318 <-> 1293
1319 <-> 1319
1320 <-> 1320
1321 <-> 206
1322 <-> 950, 1957
1323 <-> 1074, 1823
1324 <-> 352
1325 <-> 875, 1740
1326 <-> 493, 1100
1327 <-> 701, 1633
1328 <-> 1, 55
1329 <-> 1633
1330 <-> 503, 1687, 1782
1331 <-> 376, 1531, 1766
1332 <-> 436, 705, 1205
1333 <-> 565
1334 <-> 1805
1335 <-> 408, 944
1336 <-> 917, 1155
1337 <-> 1026
1338 <-> 527, 1062
1339 <-> 517, 853
1340 <-> 601, 1301, 1708
1341 <-> 1173, 1255
1342 <-> 684
1343 <-> 210
1344 <-> 121, 483
1345 <-> 175
1346 <-> 578, 1256
1347 <-> 937, 1037, 1735
1348 <-> 685
1349 <-> 275, 1594
1350 <-> 127, 130
1351 <-> 485
1352 <-> 884, 1352
1353 <-> 1604, 1800
1354 <-> 1217
1355 <-> 1355, 1985
1356 <-> 855, 1840
1357 <-> 651, 1160, 1388
1358 <-> 92
1359 <-> 112
1360 <-> 1455
1361 <-> 1071, 1909
1362 <-> 304, 1212
1363 <-> 791
1364 <-> 161, 1426
1365 <-> 1365
1366 <-> 1366, 1433
1367 <-> 133, 998
1368 <-> 851
1369 <-> 12, 996, 1425
1370 <-> 665
1371 <-> 13, 735, 952, 1371, 1857
1372 <-> 613, 1057
1373 <-> 638, 1511
1374 <-> 230, 1593
1375 <-> 104
1376 <-> 179, 1271, 1639
1377 <-> 291
1378 <-> 1919
1379 <-> 575, 969
1380 <-> 1246, 1501, 1903
1381 <-> 73, 825, 1922
1382 <-> 1071, 1117, 1541, 1810
1383 <-> 111
1384 <-> 457
1385 <-> 1878, 1966
1386 <-> 1396
1387 <-> 229, 934, 1853
1388 <-> 958, 1357, 1424
1389 <-> 531
1390 <-> 1093, 1603
1391 <-> 408
1392 <-> 446
1393 <-> 411
1394 <-> 1866
1395 <-> 450, 1851
1396 <-> 519, 1386
1397 <-> 79, 568, 992
1398 <-> 224
1399 <-> 1443, 1799, 1915
1400 <-> 744
1401 <-> 1685
1402 <-> 892
1403 <-> 1714
1404 <-> 632
1405 <-> 911, 1532
1406 <-> 233, 1606
1407 <-> 700, 1292
1408 <-> 431, 1408, 1416
1409 <-> 211, 472
1410 <-> 821, 1305
1411 <-> 1653, 1993
1412 <-> 628, 1222
1413 <-> 473, 816
1414 <-> 451
1415 <-> 991, 1026
1416 <-> 1408
1417 <-> 752
1418 <-> 423, 897
1419 <-> 2, 30
1420 <-> 1420
1421 <-> 808
1422 <-> 58, 104
1423 <-> 1266
1424 <-> 1388
1425 <-> 1369
1426 <-> 737, 1364, 1847, 1913
1427 <-> 246, 274
1428 <-> 1964
1429 <-> 76, 806, 1221
1430 <-> 1430
1431 <-> 322
1432 <-> 1719
1433 <-> 1366, 1988
1434 <-> 89, 106
1435 <-> 1017, 1730
1436 <-> 1997
1437 <-> 317, 352
1438 <-> 1193, 1263
1439 <-> 1172
1440 <-> 344
1441 <-> 37
1442 <-> 1002, 1860
1443 <-> 1399
1444 <-> 31, 298
1445 <-> 823, 854
1446 <-> 113, 403
1447 <-> 1508, 1720
1448 <-> 766, 1791
1449 <-> 527
1450 <-> 134
1451 <-> 88, 571
1452 <-> 923, 1067
1453 <-> 770
1454 <-> 95, 823, 1130, 1454
1455 <-> 1360, 1533
1456 <-> 1456, 1489, 1529
1457 <-> 114, 149, 1956
1458 <-> 382, 631, 1458
1459 <-> 570, 1293
1460 <-> 202, 369
1461 <-> 300
1462 <-> 1636
1463 <-> 393, 1659, 1939
1464 <-> 31
1465 <-> 3, 323, 547, 1257, 1732
1466 <-> 320
1467 <-> 723, 992, 1706
1468 <-> 154, 843
1469 <-> 713
1470 <-> 354, 699
1471 <-> 1471
1472 <-> 825
1473 <-> 715
1474 <-> 745
1475 <-> 645
1476 <-> 622, 758
1477 <-> 1013, 1645, 1669
1478 <-> 711
1479 <-> 734
1480 <-> 650
1481 <-> 1481
1482 <-> 310, 871
1483 <-> 918, 1504
1484 <-> 931
1485 <-> 336, 421, 775, 822, 1302
1486 <-> 157, 1631
1487 <-> 236, 437, 788, 1980
1488 <-> 1560
1489 <-> 739, 1456
1490 <-> 383
1491 <-> 535
1492 <-> 471, 614
1493 <-> 743
1494 <-> 565, 1286
1495 <-> 1627
1496 <-> 761, 1496
1497 <-> 249, 425, 851
1498 <-> 749
1499 <-> 231
1500 <-> 930, 1128
1501 <-> 390, 1380
1502 <-> 1713
1503 <-> 152, 880, 1197
1504 <-> 47, 876, 941, 1483, 1945
1505 <-> 295, 530, 753
1506 <-> 818, 1224, 1247
1507 <-> 141, 216, 1565, 1726
1508 <-> 647, 1447, 1521, 1590
1509 <-> 580, 1036, 1605, 1609
1510 <-> 40, 1885
1511 <-> 858, 1373
1512 <-> 1295
1513 <-> 78, 430
1514 <-> 1772
1515 <-> 153
1516 <-> 144, 260, 1818
1517 <-> 32, 1616, 1806
1518 <-> 472
1519 <-> 259
1520 <-> 94, 1542
1521 <-> 1508
1522 <-> 313, 1091, 1631
1523 <-> 685
1524 <-> 241, 1087, 1239
1525 <-> 1174
1526 <-> 1126
1527 <-> 1835
1528 <-> 803
1529 <-> 460, 833, 1238, 1456
1530 <-> 1784
1531 <-> 1331
1532 <-> 629, 1405
1533 <-> 470, 1455, 1533, 1796
1534 <-> 1072
1535 <-> 605, 724, 1039
1536 <-> 1178
1537 <-> 273, 801, 935
1538 <-> 1023, 1734
1539 <-> 713
1540 <-> 1748
1541 <-> 1382, 1683
1542 <-> 1520
1543 <-> 781
1544 <-> 1631
1545 <-> 1910
1546 <-> 1942
1547 <-> 260
1548 <-> 581, 747
1549 <-> 804
1550 <-> 159, 1143
1551 <-> 1178
1552 <-> 461, 1239, 1846
1553 <-> 1553, 1982
1554 <-> 68, 85, 1263, 1597
1555 <-> 1713, 1931
1556 <-> 946, 1556
1557 <-> 718, 1060
1558 <-> 783
1559 <-> 640, 940
1560 <-> 1488, 1806, 1898, 1949
1561 <-> 441, 1046
1562 <-> 715, 1889
1563 <-> 552
1564 <-> 986
1565 <-> 1507, 1689
1566 <-> 1570
1567 <-> 1056
1568 <-> 3, 371
1569 <-> 119, 1057, 1852
1570 <-> 1566, 1570
1571 <-> 1283, 1736
1572 <-> 569, 1164, 1995
1573 <-> 1573, 1784, 1987
1574 <-> 1244, 1574
1575 <-> 1282, 1575, 1866
1576 <-> 123
1577 <-> 1030
1578 <-> 289, 710
1579 <-> 992, 1684
1580 <-> 4
1581 <-> 1581
1582 <-> 128, 883
1583 <-> 57
1584 <-> 116
1585 <-> 637
1586 <-> 1134
1587 <-> 1587
1588 <-> 159, 1280
1589 <-> 1915
1590 <-> 136, 1508
1591 <-> 1223
1592 <-> 293, 1891
1593 <-> 853, 1374
1594 <-> 1349, 1886
1595 <-> 994, 1595
1596 <-> 364, 1116
1597 <-> 1554
1598 <-> 1729
1599 <-> 583, 1055
1600 <-> 147, 458, 1600
1601 <-> 1894
1602 <-> 116
1603 <-> 1390
1604 <-> 481, 657, 949, 1353, 1983
1605 <-> 115, 668, 863, 1509
1606 <-> 1406
1607 <-> 261, 410, 821
1608 <-> 690
1609 <-> 1509
1610 <-> 673, 1248
1611 <-> 118, 1788
1612 <-> 1854
1613 <-> 547
1614 <-> 547, 1807
1615 <-> 479
1616 <-> 222, 1517
1617 <-> 880, 1989
1618 <-> 826
1619 <-> 860, 1807
1620 <-> 291
1621 <-> 618, 1957
1622 <-> 535
1623 <-> 480, 531
1624 <-> 1303
1625 <-> 223, 1282
1626 <-> 503, 604
1627 <-> 1495, 1933
1628 <-> 288, 978
1629 <-> 1629
1630 <-> 465, 1872
1631 <-> 1486, 1522, 1544
1632 <-> 196
1633 <-> 1327, 1329
1634 <-> 123, 661, 740
1635 <-> 139
1636 <-> 913, 1462, 1752
1637 <-> 404, 522
1638 <-> 1779, 1813
1639 <-> 33, 190, 1376, 1639
1640 <-> 1816
1641 <-> 554, 1285
1642 <-> 1129
1643 <-> 71, 1844
1644 <-> 171, 987
1645 <-> 1477
1646 <-> 16, 199
1647 <-> 1702
1648 <-> 895
1649 <-> 1286
1650 <-> 344, 886, 945
1651 <-> 799, 1151
1652 <-> 1149, 1961, 1984
1653 <-> 222, 1074, 1411
1654 <-> 108, 553
1655 <-> 35, 156, 226, 1992
1656 <-> 537, 655
1657 <-> 105, 609
1658 <-> 1658
1659 <-> 519, 1463
1660 <-> 958
1661 <-> 290, 1929
1662 <-> 435
1663 <-> 1855
1664 <-> 345
1665 <-> 554
1666 <-> 1021, 1171
1667 <-> 662, 687
1668 <-> 1289
1669 <-> 842, 1477, 1795, 1975
1670 <-> 1119, 1921
1671 <-> 941
1672 <-> 115
1673 <-> 385
1674 <-> 518
1675 <-> 247, 676
1676 <-> 509, 1987
1677 <-> 965, 1677
1678 <-> 151, 1692
1679 <-> 541
1680 <-> 1680
1681 <-> 221, 789
1682 <-> 1736, 1767, 1947
1683 <-> 1131, 1541
1684 <-> 1579
1685 <-> 1242, 1401
1686 <-> 1736
1687 <-> 680, 1330
1688 <-> 881, 1829
1689 <-> 1030, 1565
1690 <-> 778, 1044, 1900
1691 <-> 28, 75
1692 <-> 627, 1678
1693 <-> 122, 400, 671, 969
1694 <-> 58, 61
1695 <-> 741
1696 <-> 224, 1958
1697 <-> 1935
1698 <-> 301, 1188
1699 <-> 29, 37
1700 <-> 742, 1883
1701 <-> 662
1702 <-> 441, 1647
1703 <-> 1048, 1076
1704 <-> 185
1705 <-> 715
1706 <-> 1313, 1467
1707 <-> 867
1708 <-> 1008, 1159, 1340
1709 <-> 560, 561, 1253, 1976
1710 <-> 840
1711 <-> 1711
1712 <-> 12, 1219
1713 <-> 631, 1502, 1555
1714 <-> 1403, 1714, 1902
1715 <-> 1183
1716 <-> 79
1717 <-> 738
1718 <-> 602, 1251
1719 <-> 1203, 1432
1720 <-> 1447
1721 <-> 1155
1722 <-> 930
1723 <-> 941
1724 <-> 941
1725 <-> 432
1726 <-> 1507
1727 <-> 397
1728 <-> 1728, 1937
1729 <-> 1598, 1913
1730 <-> 105, 757, 768, 1435, 1730
1731 <-> 789
1732 <-> 795, 1465
1733 <-> 551, 1765, 1835
1734 <-> 1538
1735 <-> 755, 1347
1736 <-> 1571, 1682, 1686
1737 <-> 932, 1795
1738 <-> 329, 1738
1739 <-> 267, 1062, 1848
1740 <-> 1325
1741 <-> 326, 541, 1952
1742 <-> 344, 754
1743 <-> 75, 253, 507
1744 <-> 288
1745 <-> 1216
1746 <-> 92, 138
1747 <-> 333
1748 <-> 182, 1540
1749 <-> 853
1750 <-> 88
1751 <-> 363, 1060
1752 <-> 1060, 1636
1753 <-> 433, 583, 1873
1754 <-> 1194, 1294
1755 <-> 1138, 1279
1756 <-> 538, 636
1757 <-> 1080
1758 <-> 472, 514
1759 <-> 284
1760 <-> 1760
1761 <-> 326, 620
1762 <-> 648, 939, 1989
1763 <-> 383
1764 <-> 599, 1019, 1941
1765 <-> 1733
1766 <-> 289, 365, 1331
1767 <-> 993, 1682, 1767
1768 <-> 1768, 1859
1769 <-> 957
1770 <-> 288
1771 <-> 1875
1772 <-> 1514, 1772
1773 <-> 801, 1228
1774 <-> 0
1775 <-> 935
1776 <-> 133
1777 <-> 1310
1778 <-> 17, 320
1779 <-> 465, 1638
1780 <-> 1906
1781 <-> 1969
1782 <-> 1330
1783 <-> 97, 963, 1960, 1983
1784 <-> 1132, 1530, 1573
1785 <-> 422
1786 <-> 1786
1787 <-> 854, 1317
1788 <-> 926, 1611
1789 <-> 586, 1829
1790 <-> 74, 1790
1791 <-> 52, 109, 1448
1792 <-> 1860
1793 <-> 1316, 1981
1794 <-> 138
1795 <-> 1669, 1737, 1861
1796 <-> 1177, 1533
1797 <-> 327, 875
1798 <-> 852, 1183
1799 <-> 1101, 1399, 1964
1800 <-> 491, 641, 807, 1353
1801 <-> 20, 455
1802 <-> 123
1803 <-> 415, 1010
1804 <-> 1804
1805 <-> 1334, 1926
1806 <-> 1517, 1560
1807 <-> 1614, 1619
1808 <-> 261, 643
1809 <-> 145, 1122
1810 <-> 1382
1811 <-> 60
1812 <-> 1084
1813 <-> 213, 994, 1638
1814 <-> 14, 355
1815 <-> 841, 1996
1816 <-> 1049, 1640
1817 <-> 388
1818 <-> 1051, 1516
1819 <-> 1008
1820 <-> 403
1821 <-> 350, 1163
1822 <-> 669, 1179, 1927
1823 <-> 1323
1824 <-> 667, 824, 1879
1825 <-> 608, 839, 876, 1965
1826 <-> 473, 907
1827 <-> 1115, 1171
1828 <-> 440, 1195, 1284, 1913
1829 <-> 275, 1688, 1789
1830 <-> 1830
1831 <-> 1831
1832 <-> 248, 726
1833 <-> 1833
1834 <-> 1190
1835 <-> 639, 1527, 1733
1836 <-> 250, 1836
1837 <-> 577, 1970
1838 <-> 1156, 1261
1839 <-> 1192, 1244, 1298
1840 <-> 1356
1841 <-> 81
1842 <-> 738, 1215
1843 <-> 1843
1844 <-> 383, 1257, 1643
1845 <-> 260, 451
1846 <-> 1552
1847 <-> 755, 879, 1426
1848 <-> 38, 1739
1849 <-> 468, 1144
1850 <-> 1092
1851 <-> 934, 1395
1852 <-> 198, 1569
1853 <-> 718, 1178, 1387
1854 <-> 588, 1197, 1612
1855 <-> 162, 734, 1663
1856 <-> 236, 751
1857 <-> 1371
1858 <-> 1015
1859 <-> 1768
1860 <-> 940, 1270, 1274, 1442, 1792
1861 <-> 1014, 1795
1862 <-> 1142, 1252
1863 <-> 281
1864 <-> 717
1865 <-> 1865
1866 <-> 574, 602, 1394, 1575
1867 <-> 707, 1011
1868 <-> 659, 1868
1869 <-> 173, 1991
1870 <-> 391, 828, 956, 1880
1871 <-> 189, 692
1872 <-> 1630
1873 <-> 42, 1753
1874 <-> 883
1875 <-> 11, 1771
1876 <-> 158
1877 <-> 186
1878 <-> 796, 1385
1879 <-> 486, 1824
1880 <-> 920, 1870
1881 <-> 433, 573, 905
1882 <-> 625, 1954
1883 <-> 300, 1700
1884 <-> 1884
1885 <-> 1291, 1510
1886 <-> 19, 209, 1300, 1594
1887 <-> 277
1888 <-> 85
1889 <-> 489, 1286, 1562
1890 <-> 170, 832
1891 <-> 1211, 1592, 1973
1892 <-> 611, 697, 914
1893 <-> 1224
1894 <-> 775, 1601
1895 <-> 308, 323, 618
1896 <-> 1106
1897 <-> 118, 368, 408
1898 <-> 1316, 1560, 1944
1899 <-> 463, 1050
1900 <-> 1088, 1690, 1951
1901 <-> 16, 27
1902 <-> 981, 1714
1903 <-> 1380
1904 <-> 278, 1052
1905 <-> 20
1906 <-> 671, 1225, 1780
1907 <-> 800
1908 <-> 583
1909 <-> 1361, 1940
1910 <-> 134, 967, 1545
1911 <-> 1973
1912 <-> 1262
1913 <-> 832, 1426, 1729, 1828
1914 <-> 1914
1915 <-> 1399, 1589
1916 <-> 650, 1916
1917 <-> 726, 1917
1918 <-> 1040
1919 <-> 196, 1378, 1919
1920 <-> 1, 218
1921 <-> 1670, 1952
1922 <-> 1381
1923 <-> 892, 1012, 1247
1924 <-> 373, 904
1925 <-> 210, 1935
1926 <-> 543, 1013, 1805
1927 <-> 1102, 1822
1928 <-> 346, 1928
1929 <-> 1661
1930 <-> 19
1931 <-> 983, 1555
1932 <-> 685
1933 <-> 16, 1190, 1627, 1933
1934 <-> 288, 1243
1935 <-> 535, 1697, 1925
1936 <-> 295
1937 <-> 112, 157, 1728
1938 <-> 293
1939 <-> 689, 1059, 1463
1940 <-> 616, 1909
1941 <-> 1764
1942 <-> 243, 256, 1546
1943 <-> 1950
1944 <-> 260, 1898
1945 <-> 1504
1946 <-> 1946
1947 <-> 87, 1129, 1179, 1682
1948 <-> 294
1949 <-> 1560
1950 <-> 21, 1943
1951 <-> 407, 1900
1952 <-> 1741, 1921
1953 <-> 1067
1954 <-> 696, 1882
1955 <-> 754
1956 <-> 1457
1957 <-> 1322, 1621
1958 <-> 48, 708, 1696
1959 <-> 1959
1960 <-> 389, 1783
1961 <-> 1652
1962 <-> 29
1963 <-> 914
1964 <-> 1428, 1799
1965 <-> 1825
1966 <-> 1385
1967 <-> 1168
1968 <-> 265, 475
1969 <-> 4, 1781
1970 <-> 315, 926, 1837
1971 <-> 242, 545, 1971
1972 <-> 1972
1973 <-> 997, 1891, 1911
1974 <-> 885
1975 <-> 1196, 1669
1976 <-> 1709
1977 <-> 1977
1978 <-> 1978
1979 <-> 1979
1980 <-> 598, 1487
1981 <-> 1793
1982 <-> 1553
1983 <-> 1054, 1604, 1783
1984 <-> 731, 1652
1985 <-> 1355
1986 <-> 795
1987 <-> 1573, 1676
1988 <-> 495, 1023, 1433
1989 <-> 1617, 1762
1990 <-> 376
1991 <-> 1869
1992 <-> 1035, 1655
1993 <-> 1411
1994 <-> 1235, 1994
1995 <-> 57, 1209, 1572
1996 <-> 181, 1815
1997 <-> 395, 1436
1998 <-> 1300
1999 <-> 175, 1161";

        public const string Day13 = @"0: 3
1: 2
2: 6
4: 4
6: 4
8: 10
10: 6
12: 8
14: 5
16: 6
18: 8
20: 8
22: 12
24: 6
26: 9
28: 8
30: 8
32: 10
34: 12
36: 12
38: 8
40: 12
42: 12
44: 14
46: 12
48: 12
50: 12
52: 12
54: 14
56: 14
58: 14
60: 12
62: 14
64: 14
66: 17
68: 14
72: 18
74: 14
76: 20
78: 14
82: 18
86: 14
90: 18
92: 14";

        public const string Day16 = @"x15/10,ph/c,x3/14,s1,pf/b,x12/0,ph/m,x14/11,s4,x6/13,s2,x7/14,pn/f,x1/9,s7,x14/11,s9,x15/6,s14,x0/5,s1,x6/7,pp/i,s8,x4/3,s5,x15/6,s3,x4/3,s13,x11/6,pf/m,x13/5,s9,x0/3,s13,x15/5,pl/h,s1,x9/0,pf/a,x12/4,s5,x15/10,pn/i,x9/14,pm/l,x10/6,s8,x14/5,s6,x9/11,s2,x8/0,s6,x7/14,s2,x10/15,s1,x11/13,pf/b,x12/8,s8,pd/j,x1/13,s9,x3/6,s13,x2/8,s9,pp/e,x6/14,pm/b,x13/12,s6,x10/4,s10,x5/1,pi/a,x9/15,s8,x10/11,ph/j,x7/3,s9,x4/2,pb/g,x14/13,s10,x8/11,s11,x6/14,s10,x4/7,s6,x13/1,pn/k,s12,x9/7,pl/e,x2/13,s9,x10/9,po/c,x7/2,s4,x3/0,s8,x7/10,pl/h,x2/8,s9,x10/4,s15,x8/14,s1,x4/2,s8,x8/5,s15,x11/4,pd/c,x12/3,s5,x5/6,s4,x7/10,pa/k,x6/15,s8,x3/13,pg/b,x12/9,s11,x14/2,s5,x5/13,s2,x1/0,pj/l,x10/2,s5,pa/m,x12/5,s3,x4/8,s9,x15/5,pg/j,x12/2,pl/f,x3/1,s15,x6/14,pp/i,x0/13,pm/o,x6/8,pd/b,x15/10,s15,pg/k,x0/5,s3,x10/14,pc/j,x9/12,s13,x7/1,s11,x12/3,pk/h,x11/8,s15,x9/6,s2,x11/0,s5,x14/4,pe/d,x5/0,pc/j,x11/14,s3,x8/0,s14,pp/e,x14/12,s7,x13/5,pk/j,x9/4,s15,pm/g,x0/5,s14,x11/10,s6,x1/7,s9,x6/4,s2,x5/8,s1,x1/7,pj/c,x2/10,s7,pm/g,x15/5,ph/c,s9,x11/13,pp/f,s9,x8/4,s2,x12/14,s11,x10/1,s3,x0/8,s8,x11/13,s12,x1/14,s5,pk/n,x3/5,s12,x8/11,s14,x6/14,pg/o,x1/7,s7,x2/8,pc/l,x0/10,pn/p,x3/5,po/m,s15,x15/14,pi/c,x11/3,s8,x7/4,s14,pp/l,x2/11,pa/d,x1/8,pb/k,x13/14,s4,x0/4,pl/c,x14/11,pe/m,x9/5,s3,x11/10,s15,pk/j,s10,x7/9,s7,x1/12,po/c,x0/5,s4,x15/9,pg/h,s4,x5/11,s13,x3/7,s2,x14/13,s15,x8/12,pf/c,x7/5,s10,x4/13,pn/j,x7/9,pc/k,x14/12,pi/j,x0/11,pb/o,x15/3,s15,ph/l,x14/0,pn/g,x9/3,pj/d,s15,x11/6,s2,x5/4,ph/c,x7/8,s14,x13/11,pa/i,x2/6,s15,x4/3,pk/h,x5/12,s7,x2/4,pf/j,x13/15,pc/d,x11/4,s12,x9/0,pa/m,x10/7,s3,x9/13,pc/j,x3/8,s11,x12/15,pg/l,x5/0,pa/j,s3,x13/7,s15,x14/2,s3,x0/3,s9,x13/8,s4,x15/0,s13,x7/4,pm/i,x3/8,po/a,x11/1,pn/e,x2/7,pc/p,s15,x11/1,s2,ph/d,x10/7,s9,x9/3,s6,pi/j,x6/0,s10,x13/3,pd/n,x2/7,s7,x9/11,pf/k,x1/13,pj/p,x12/0,s13,x2/9,pc/l,x7/14,s8,x2/5,pe/d,x1/6,s15,x8/15,s11,x3/0,s3,x13/14,s5,x8/6,pb/n,s2,x3/1,pk/d,x6/8,s6,x15/9,s3,x2/3,s13,x1/10,s8,x11/7,pe/b,x13/8,s3,x6/15,s9,x9/7,s11,x1/11,pp/a,x7/12,s6,x8/2,pi/g,x15/6,s3,x2/1,s2,x7/11,s6,x14/0,ph/n,x8/2,s1,x11/14,s2,x3/15,pb/g,x12/8,s5,x1/14,pl/c,x8/2,pp/g,x0/14,s2,x6/13,pb/h,x11/7,s9,x6/4,s2,x8/15,pd/o,x13/14,pe/p,x15/9,s6,x3/12,pa/g,x1/9,s12,x15/4,s6,x11/10,pc/o,x8/3,s11,x15/9,pa/p,x2/6,po/d,x7/13,s12,x0/5,s15,x13/8,s12,x5/12,s9,x15/10,pe/i,s9,x1/8,po/a,x13/4,s2,x10/8,s11,x6/3,pc/k,x0/4,pd/p,x6/13,s15,x3/5,s4,x6/7,s13,x5/14,s8,x6/8,s6,x10/5,s13,x9/1,s11,x11/5,pf/n,x9/10,s6,x13/5,pc/a,x9/6,pd/n,x14/15,s7,x8/7,pl/f,x2/12,pj/k,x9/0,s1,x3/15,s5,x6/9,s9,x11/8,pd/l,x13/0,s13,x2/4,s15,x5/15,pb/a,x8/3,s13,x2/15,s3,x5/1,s3,x4/3,s11,x8/11,s2,x0/15,s15,x8/4,s10,x13/6,pm/i,x2/3,pk/l,x11/6,pi/h,x3/8,s15,x9/11,pn/g,x12/5,pj/d,x15/11,ph/f,s13,x13/0,pg/i,x10/9,s10,x1/12,pf/o,x0/14,s9,x3/15,s10,x2/6,s2,x10/8,s9,x14/1,s6,x7/2,s3,x12/11,s10,x7/15,s12,x11/2,s1,x0/15,s3,x12/13,s2,x10/15,s6,pg/b,x9/1,s11,x12/3,pf/l,x7/15,s9,x12/4,s12,x10/11,pg/b,x7/15,s1,x6/2,pn/m,x4/5,pd/p,s9,x9/12,s6,x8/7,s10,x12/15,pm/g,x5/9,s7,x1/10,s1,x6/12,s5,x13/5,s14,x3/14,s11,pl/f,x1/12,s4,x10/13,pk/c,x11/0,pf/o,x3/2,s9,x9/12,ph/m,x0/11,s15,x13/5,s7,x8/7,pk/o,x4/14,pf/j,x8/11,pm/i,x3/4,pb/l,x0/12,ph/j,x11/4,s12,x1/12,pk/n,x6/3,pe/a,x11/0,pp/o,x10/12,pa/j,x4/11,s7,x0/3,s3,x11/8,s1,x10/3,pp/h,x1/9,pe/m,x0/8,pc/a,x15/5,s12,x13/0,pl/e,x3/15,s6,x9/11,s2,x0/12,s8,x7/13,s7,x10/6,pm/n,x15/4,po/a,x3/7,s10,x14/9,s2,x6/2,s13,x5/8,s4,pk/i,x1/9,s1,x12/10,s9,x8/9,pn/c,x1/10,s11,x0/13,s7,x11/3,pe/j,s13,x13/7,pa/m,x12/14,pl/p,x10/8,pd/o,x11/1,s12,x14/3,s2,x12/8,s14,x11/7,pc/b,x8/0,ph/p,x12/1,pf/k,x14/13,s14,x9/10,s13,x8/3,s11,x9/6,pj/g,x0/15,pp/o,x7/5,pi/j,x3/11,s13,x10/2,pm/o,x4/14,pc/e,x8/9,s15,x7/12,s6,x9/4,pi/l,x12/14,s1,pn/p,s7,x2/11,pj/f,x15/9,pm/d,x3/11,s11,x6/1,s14,x14/10,pn/o,x8/7,s3,x6/0,pi/m,x4/5,s10,x9/7,s13,x3/14,s11,x5/6,s8,x1/12,s11,x10/8,s7,x5/14,s15,x15/2,pa/f,x6/13,s12,x4/15,s6,x13/14,s1,x10/6,s13,x7/14,s7,x15/6,s13,pj/c,x10/2,s14,x3/11,s11,x7/14,pf/a,x15/6,s5,x3/9,s10,x10/4,pg/m,x15/11,pa/h,x12/0,s10,x7/10,s4,pf/k,x4/14,s11,x1/11,pm/o,s9,x10/13,s13,x12/14,s5,x3/5,s9,x0/1,pa/e,x4/6,pp/c,x10/13,pl/b,x15/7,s5,x3/9,pp/j,x6/13,pd/f,x14/15,s10,x4/8,pe/g,x14/10,pc/d,s13,x11/15,s9,x1/14,pj/h,x4/6,s12,x0/14,pg/p,x3/13,pj/h,x4/10,po/d,x5/1,s9,x2/10,s8,x11/12,s6,x7/15,s14,x6/10,pe/c,x11/1,pi/h,x10/14,po/g,x11/3,s9,x8/5,s14,x9/12,s11,x4/8,s4,x10/14,s2,x13/9,pl/d,x12/5,s6,x4/0,pm/g,s6,x6/14,s2,pj/i,x12/4,s2,x3/13,s6,x15/4,pa/p,x11/7,pf/o,x10/12,s12,pb/i,x15/0,pn/m,x8/12,s10,x15/5,s8,x8/1,pc/f,x13/9,pl/h,x6/2,s9,pa/e,x9/8,pb/j,x10/14,s12,x9/5,pk/o,x11/15,pb/l,x14/9,ph/k,s11,x12/7,pc/l,s5,x10/0,s6,x4/14,s2,x11/0,s5,pf/a,x15/12,pn/d,x2/6,s13,x14/15,s7,x7/4,pp/c,x10/5,s5,x0/14,pg/h,x1/6,s3,x4/14,pn/i,x0/13,s3,x7/1,s15,x11/0,s9,x5/7,s12,x4/13,pk/e,x6/9,pa/o,x2/10,pf/l,x6/12,s14,x1/7,s10,x14/2,s4,x1/5,pb/n,x6/4,s15,x2/0,s15,x11/12,s3,x10/3,s11,x4/15,s9,x11/13,s14,x7/12,s2,x3/2,s7,pm/p,x14/10,s15,x8/13,pf/j,x15/9,s7,x4/6,pk/l,x7/15,pg/d,x5/12,po/i,x1/7,s14,x6/12,pk/b,x0/5,s7,x15/10,po/a,x7/3,pb/l,x8/15,pm/f,x11/1,pb/e,x0/9,s2,x13/10,s12,x2/12,s6,x11/3,s10,x0/4,s7,x5/3,s12,x13/7,pn/p,s8,x10/8,pe/d,x15/5,pj/a,x13/4,s4,x9/0,s5,x12/6,s10,x1/0,s1,x10/6,pe/c,x14/13,s5,x10/9,s10,x4/5,pg/n,x1/13,s7,x2/14,pb/k,x11/6,s10,x10/9,ph/d,x11/3,s10,pm/c,x0/5,s12,x13/14,po/n,x7/1,pc/m,x8/4,pa/e,x5/15,s15,x14/7,s12,x4/12,s11,pl/j,x10/2,s12,x8/9,s3,x10/4,s6,x12/0,pm/k,x14/3,pn/f,x12/8,pm/j,s1,x13/6,s13,x12/7,pc/e,x11/4,s15,pm/g,x5/2,s4,x9/15,pd/p,x10/2,s13,x3/9,pl/m,x0/7,pj/o,x1/3,pm/d,x12/0,pp/h,x14/5,pf/j,x3/2,s13,x9/8,s10,x6/11,s9,x8/14,s5,x7/11,s15,x5/3,s1,x0/8,s8,x12/4,s12,x2/13,pi/d,x15/12,pk/n,s7,x5/2,s13,x13/4,s4,x14/8,pi/j,x4/7,s9,x0/2,pl/b,x6/14,s2,x3/10,pp/o,x11/15,s2,x2/10,pd/m,x12/3,s12,x4/15,s6,x1/2,pe/h,s6,x8/13,pm/k,x1/9,pi/o,s8,x6/8,pb/l,x9/10,pe/f,x13/5,s1,pb/h,x8/12,s11,x1/3,s15,pk/d,x2/8,s14,ph/j,x12/10,s1,x4/1,pp/k,x2/12,s8,x15/9,s6,x7/12,pe/a,x2/15,s11,x4/1,s5,pl/o,x0/2,s5,x1/3,s10,x9/5,s2,x15/11,s10,x10/1,pm/a,x15/13,s6,x0/12,pk/b,x5/7,s5,pe/m,s5,x13/12,s5,x8/2,pi/f,s11,x0/3,pn/d,x4/15,s1,x12/5,pp/c,x4/10,s7,x1/12,pg/o,x0/2,s4,x7/13,s11,pc/d,x3/15,s10,x4/8,s12,x13/12,pe/b,x14/6,s14,pk/j,s9,x2/5,s15,x13/0,pl/e,x6/8,s9,x11/10,s12,x3/1,s13,x2/7,s12,x10/15,pa/i,x4/13,pf/p,x15/0,s15,x3/11,s12,x15/10,s3,x4/2,pc/d,x14/13,pk/j,x12/8,pb/m,x11/6,s9,x0/1,pg/f,s3,x14/11,po/j,s9,x0/2,pa/c,x11/3,s1,x7/6,s8,x9/2,s10,x7/14,s8,x15/12,pl/g,x7/13,s6,x0/11,s9,x4/9,s1,x7/10,pc/n,x4/6,s2,x8/3,pp/h,s5,x2/7,pn/k,x1/11,pf/m,x4/3,pj/i,x9/8,pp/k,x4/1,po/l,x14/2,s5,x15/12,s6,x6/2,s13,x1/10,pp/b,s9,x12/6,s12,x10/14,po/j,x7/2,s12,x1/10,s10,x9/4,s6,x2/6,s8,x1/8,s4,pd/f,x5/3,s9,x0/4,s1,x6/1,ph/n,x10/12,s3,x7/15,pg/e,x4/8,s15,x3/0,s1,x9/13,s8,x12/6,pp/k,x13/2,s9,x0/4,pl/a,x8/3,s6,x15/7,pi/f,x0/5,pn/e,x11/6,ph/l,x0/12,s14,x2/1,s11,x13/0,s7,x12/2,pe/c,x3/0,s4,x12/14,s7,x8/13,pl/h,x10/4,pf/a,x14/15,s7,x9/12,pp/n,x4/10,s1,x5/2,s10,x0/6,pl/o,x8/10,s9,x7/1,s11,x0/11,pd/k,x10/3,pb/l,x4/12,s15,x6/0,s15,x15/12,s14,x2/11,s5,x7/8,s4,x6/4,pj/h,x3/8,pn/g,x11/10,s1,pc/e,x12/13,pn/i,x14/2,pe/l,x0/11,s14,x8/15,pp/d,x3/12,pj/g,x4/10,s12,x0/12,s11,x8/13,pe/i,s8,x1/3,s5,x10/7,s6,x4/12,s9,x15/8,pc/k,x3/7,s9,x13/2,pm/h,x14/12,pi/p,x7/4,s6,x14/9,s3,x7/3,pm/o,x1/6,s9,x11/7,s5,x3/10,pi/j,x11/1,s1,x4/3,pk/g,x15/13,pn/o,x1/3,s14,x8/4,pc/a,x14/11,pg/o,x6/13,s8,x3/2,pm/h,s8,x6/4,s13,x8/9,po/n,x15/5,s12,x2/7,s6,pi/h,x0/14,pa/b,x2/12,pe/f,s15,x13/8,s5,x9/4,s1,x0/8,pk/o,x2/9,s12,x13/8,pm/c,x1/10,ph/p,x12/5,s4,x15/10,s1,po/m,x8/2,pn/j,x14/6,pd/m,x0/4,s7,x12/1,pb/o,x0/4,pn/e,s7,x7/11,s14,x2/1,pp/b,x9/7,pc/j,x0/3,s10,x12/14,s7,x3/11,pi/b,x8/0,s2,x6/13,s4,x14/9,s10,x6/4,s6,pj/f,x3/7,pg/a,x11/5,s14,x9/14,pf/i,x6/2,pa/p,x13/10,s10,x5/15,pf/m,x12/14,s11,x13/7,s13,x11/5,pp/d,x14/0,pg/n,x2/1,s7,x3/12,po/l,x1/6,pg/a,x9/15,pe/n,x5/11,s15,x4/3,s9,x0/2,s13,x1/3,pg/f,x12/11,s12,x8/1,s1,x13/5,pp/h,x9/0,s9,x12/2,pd/i,x3/0,pb/m,x1/11,s13,pi/o,x12/0,pn/c,x8/4,pl/b,x3/9,po/e,x8/10,pf/b,x15/5,s8,x4/12,s10,x1/10,s3,x7/11,pp/i,x0/9,s6,x11/10,s1,x5/3,s15,x15/10,s3,x14/12,s6,x11/6,pl/j,x7/8,pd/m,x4/3,po/e,x10/2,s14,x15/6,pd/m,x13/1,pc/e,s10,x4/5,s6,x11/3,s5,x7/9,pn/j,x11/13,pi/g,x6/7,pb/p,x11/0,pe/h,x7/4,s7,x12/0,s10,x11/3,pg/a,x5/9,s4,x4/7,pc/d,x1/5,s9,x9/12,pk/a,x1/14,pn/i,x2/11,s13,x15/12,pf/g,x2/4,s7,x9/15,s2,x14/6,s3,x13/4,s14,x1/15,s14,x3/8,s11,x9/15,s14,x3/2,s10,x0/9,s11,x4/5,s1,x11/15,s14,x14/4,s11,x2/9,pd/k,x6/0,pi/p,x12/8,s3,x3/2,s4,x6/4,s3,x1/11,s5,x2/14,s5,x4/3,s2,x14/15,po/m,s2,x10/7,s8,ph/a,x3/9,s6,x1/8,s4,x11/14,s4,x13/9,pb/m,x5/8,s7,pj/f,x2/1,pn/b,x14/0,pp/e,x8/11,pc/n,x10/2,s1,x8/3,pl/o,x14/15,s4,x8/9,s11,x0/15,pk/p,x1/14,s11,x7/0,s4,x6/1,pj/b,x9/14,pd/i,x13/4,pj/e,x0/12,s13,x6/2,pd/g,x8/7,s13,x2/3,pl/b,s11,x4/15,pe/h,x3/6,pd/c,s2,x10/2,po/n,x5/9,pm/i,s15,pf/e,x8/1,s14,x6/12,s14,ph/b,x1/3,s14,x5/12,po/g,s11,x0/13,s1,x3/15,pd/e,x10/7,pj/l,x8/15,s7,x10/14,s8,x2/13,s8,x11/5,s4,x14/3,s7,x12/15,s2,x10/8,pn/o,x4/3,s6,pm/l,x7/8,s6,x10/3,s14,x0/2,pa/o,x13/6,s6,x4/12,s6,x8/9,s14,x6/14,pl/p,x1/2,s13,x8/15,s1,x6/7,s7,x11/5,s5,x4/3,s11,x10/14,pj/a,x8/15,s9,x5/10,s12,x3/11,s12,x4/2,pf/m,x0/15,pc/b,x4/8,pi/n,x11/7,s15,x1/3,pj/d,x7/12,s2,x9/0,s6,x14/5,s7,x11/0,pb/e,x5/12,s2,x15/9,pp/j,x5/7,s7,x4/10,s8,x11/13,pe/m,x15/8,s14,x3/10,pn/p,x4/0,pc/e,x1/9,pi/a,x7/15,s9,pd/p,x5/3,s9,x14/12,s14,x13/11,s14,x5/1,s3,x4/14,pi/n,x12/5,s12,x1/6,pe/h,x12/11,s15,x5/8,s7,x0/3,s3,x6/7,s8,x8/5,s7,x7/12,s6,x6/13,s8,x9/1,s3,x7/5,pj/m,x10/11,po/g,s15,x6/4,pd/a,x2/5,s9,pf/p,s5,x7/14,pm/d,x9/0,s5,x1/10,pb/p,x8/6,s7,x9/12,pk/d,x0/4,s2,x10/14,pf/l,x9/3,s14,x15/7,s1,x2/13,s14,x11/9,s8,x13/14,s4,x7/12,s8,x1/13,s1,x9/2,s7,x15/4,s13,x12/1,pp/c,x5/10,s15,pj/l,x12/2,s8,x8/7,s6,x14/12,s14,x15/13,pb/p,s1,x10/2,s15,x0/8,pj/h,x1/11,pk/d,x3/8,s8,x5/1,s3,x9/14,ph/n,x5/13,s5,x6/14,s1,x3/11,s10,x0/10,po/a,x13/15,s6,x8/6,pl/f,x13/14,s15,x5/9,pb/k,x8/12,s1,x3/2,pg/o,x14/6,s3,pj/e,x3/11,s9,x0/12,s4,x2/14,po/p,x6/12,pg/j,x1/4,ph/b,x12/6,pn/i,x4/11,pp/a,x7/3,po/h,x10/8,pb/n,x0/15,s8,x11/8,po/a,x14/5,s9,x15/8,s13,x0/10,s3,x12/4,s5,x5/6,s3,pp/g,x13/11,pl/d,x15/8,pk/h,x10/13,s9,x15/2,s8,x11/7,pg/p,x12/1,ph/d,x13/3,s2,x10/14,pi/p,s4,x3/7,s3,x9/14,s6,pc/n,x4/6,s1,x13/1,s2,x0/11,pf/d,s7,x10/6,pb/i,x3/9,s3,x10/13,pe/g,x2/0,s2,x9/6,pa/n,x2/5,s2,x15/8,pm/d,x4/13,pe/o,x14/7,s7,x12/5,pa/k,s7,x0/4,pc/o,x3/2,s5,pi/m,x14/6,s8,x10/1,s1,x3/12,po/h,x8/15,pm/c,x0/3,pn/b,x12/8,s14,x0/14,s4,x9/1,pp/j,x3/14,s2,x10/7,pb/e,x5/2,s1,pj/n,x6/1,s5,x12/14,s14,x1/0,s1,x5/9,pd/f,x7/11,s5,x6/5,pp/a,x0/3,s9,x13/11,pc/n,x10/2,s1,pa/m,x14/1,s13,x7/9,s6,x14/10,pe/d,x13/7,pc/j,x9/6,s10,x4/14,s6,x6/3,s14,x11/12,s9,x8/14,s13,x4/10,s9,x3/12,pp/e,x6/0,pn/j,x13/11,s12,x5/9,s14,x11/15,pk/p,x13/1,s6,x12/10,s14,pg/m,x5/4,ph/i,s13,x7/10,pk/m,x15/11,s15,x13/14,pn/o,x6/3,pf/i,x1/14,pj/b,s10,x0/15,pc/n,x12/1,s14,x3/10,s9,x4/11,s15,x8/12,s12,x14/15,s13,x9/5,pf/o,x7/0,s12,x8/5,s10,x0/4,s1,x7/12,s5,x11/8,s15,x3/12,pn/d,x0/15,s3,x11/12,pj/o,x14/15,s1,x6/13,pd/h,x0/3,s13,x1/9,pk/i,x0/6,pc/n,x4/14,s14,x5/10,s14,x14/11,pk/d,x12/3,s6,x7/13,s7,x5/4,pf/e,x3/14,pk/d,x6/12,s10,x2/13,s13,x3/1,s11,x9/0,s9,x10/1,pp/m,x15/0,s4,x3/11,pg/j,s12,x13/9,s10,x0/11,pf/a,x3/7,s11,x4/2,s12,x1/3,s4,x2/7,pg/b,x14/5,s14,x12/6,s14,x14/7,pn/a,x2/10,s6,x0/13,s9,x9/12,ph/j,x14/5,pf/g,x7/15,pj/d,x1/11,pf/p,x6/4,s6,x1/5,pc/o,x3/15,ph/a,x4/0,s7,x5/9,s10,x4/6,pe/j,x8/15,pa/f,x9/11,s10,x0/7,s4,x10/12,pj/l,x11/9,pn/e,x12/0,s14,x13/2,s15,x1/6,s1,x11/2,s4,pp/o,x15/6,s8,pj/c,x0/7,pe/k,x1/5,pi/d,s8,x6/12,s12,x1/4,s7,x6/13,s9,x15/0,po/f,x1/12,s4,x9/8,pb/i,x13/1,pm/l,x5/6,s14,x2/10,pb/o,s8,x7/1,s3,x8/5,pi/a,x7/3,s12,pp/d,x9/0,s6,x2/13,s8,x5/15,pm/f,s12,x11/7,pe/n,x3/13,s12,x8/12,s7,x3/9,pi/o,s12,x5/1,s14,x3/9,s12,x5/6,s15,x3/9,s11,x4/1,pe/c,x8/9,s7,pi/k,x12/15,pm/l,x6/0,pp/f,x11/3,pb/g,s10,x7/12,s2,x15/10,s7,x11/7,s11,x0/6,po/c,x13/2,s6,x4/0,s10,x6/1,s11,x0/10,pp/m,x2/8,s14,x12/14,pj/c,x5/4,s7,x9/7,s7,x4/13,po/a,x3/9,pj/g,x10/7,pe/i,x2/15,s6,x8/6,s11,x11/15,pa/l,s15,x1/3,s9,x11/10,ph/o,x12/13,s9,x0/6,pc/e,x8/10,s5,x5/2,s4,x1/0,pp/g,x12/15,s2,x8/9,pi/j,x10/4,s6,x7/8,s15,x0/1,s9,x6/8,s5,x10/5,s12,x4/3,s9,x5/0,s4,x6/4,ph/g,x0/3,s6,pp/a,x14/15,s7,x6/9,s4,pl/n,x15/4,s14,x10/12,s9,pc/a,x14/4,pf/h,x0/15,s2,x8/14,pg/d,x2/15,s4,x12/11,s15,x13/6,pl/b,x7/11,s7,x10/12,pd/o,x0/3,s11,pj/i,s12,x10/8,pf/k,x1/0,pe/l,x7/14,s12,x13/1,pf/i,x14/5,pj/h,s15,x3/10,pl/p,x15/8,pi/j,x12/13,s14,x14/1,pk/f,s7,x0/15,s5,x12/4,s10,x15/5,s4,x8/12,s13,x1/6,s12,x2/10,pl/j,x4/15,pe/m,x6/11,s2,x12/5,s13,x6/1,s7,x8/14,pf/a,x15/4,s3,x1/13,s15,x2/12,pi/b,x6/3,pf/n,x5/8,pb/d,x6/1,s10,pj/o,s7,x14/4,pg/e,s7,x10/2,s10,x3/15,s6,x10/9,s13,x13/6,s3,x9/7,s4,x13/11,s12,x9/10,s10,x14/5,s12,x15/8,pd/h,x0/3,s10,x2/14,pa/j,s6,x15/9,s2,x10/6,pi/b,x7/2,pj/f,s12,x10/12,s7,x11/5,s3,x0/3,s7,x5/2,s7,x1/10,s11,x13/11,s3,pp/h,x1/3,s11,x12/7,s14,x1/8,pn/c,x9/15,s1,pg/a,x12/4,s1,pb/m,x5/7,s9,x10/2,pa/d,x5/1,pi/f,x14/10,s13,x6/11,s3,x5/12,s13,x8/15,s1,x1/6,ph/o,x13/3,pk/l,x10/0,pd/j,x2/4,pa/i,x14/9,pb/e,x13/12,pk/c,s3,x14/9,s8,x1/2,pi/l,x15/11,pa/j,x14/2,s13,x9/7,pi/g,s8,x12/4,pe/f,x5/14,pa/j,x1/2,pg/m,x7/6,s10,x9/12,s15,x3/1,pb/l,x9/6,pd/g,x12/1,pn/o,x11/6,pi/l,x1/0,s3,x13/10,pj/g,x1/0,pi/a,x4/10,pn/h,x2/9,s6,x7/12,s3,x5/9,pa/l,s1,x12/15,pk/o,x11/5,s9,pm/d,x14/15,s13,x12/11,pg/j,x2/14,s3,x5/15,s9,x2/4,s3,x8/3,pn/d,x14/15,s11,x4/5,s14,x8/15,pm/p,x2/9,po/a,x0/15,s14,x8/7,s4,x1/3,s12,x5/7,s8,x15/2,pi/c,s5,x13/4,s11,x9/7,s10,x4/2,s13,x7/3,pp/l,x0/14,po/h,x3/12,s12,x10/2,pl/d,x8/5,s5,x0/4,s3,x12/6,s8,x8/5,s14,x7/9,s2,pf/g,x4/3,ph/e,x5/15,pb/l,x2/9,pm/p,s1,x1/6,s7,x0/10,pg/h,x5/3,pm/j,x2/15,s8,pi/a,x0/8,s13,x13/15,pg/l,x5/0,s14,x2/6,pp/b,x1/12,pi/g,x10/2,ph/p,x5/3,pi/g,x0/10,s10,x11/9,s4,x4/3,s8,pn/f,x12/13,s5,ph/a,x5/14,s10,pk/l,x4/12,s3,x3/11,pc/b,s11,x0/8,s1,pg/h,x6/3,s1,x15/10,s5,x2/3,s4,x10/7,s12,x14/13,pn/i,s10,x10/2,s14,x13/1,pl/a,x15/2,po/n,x6/1,s15,pd/e,x5/0,pp/h,x4/12,s5,x14/11,s12,x6/5,s10,x9/15,s13,x2/12,s14,x4/3,pb/c,x12/1,s4,x11/9,pd/k,x0/6,s7,x4/13,s6,po/h,x0/11,pg/f,x12/2,pj/n,x10/4,pe/c,x2/7,pk/m,x15/12,s14,x10/9,pi/d,x2/5,s11,x13/0,pg/h,s2,x15/12,po/b,x14/8,ph/l,s14,x10/6,s15,x5/9,pf/c,x14/2,pm/j,x6/11,s14,x3/9,pb/g,s6,x7/15,s6,x0/12,s8,x5/11,s10,x3/9,pa/d,x15/14,s10,x5/6,s1,x1/4,s8,x14/6,s3,x12/7,s14,x1/2,pg/h,x7/0,s4,x12/5,pn/d,x3/15,s13,x2/13,pb/o,x3/10,s14,ph/d,x1/15,pk/i,x3/11,s10,pp/f,s10,x2/15,s10,x5/6,s13,x2/10,s7,x11/9,pl/j,x0/6,s7,x1/15,s8,x8/12,s13,x1/5,s10,x10/15,pk/b,x1/6,s3,x15/7,pe/l,x12/5,s1,x2/3,pi/d,s9,x10/0,s10,x9/11,s8,pj/m,x3/4,s15,x1/14,s14,x9/7,s7,x11/14,pg/h,x13/1,po/p,x0/4,s5,x13/6,s7,x0/7,s7,x15/11,s7,pk/c,x8/10,s4,x1/6,pa/l,s3,x12/0,s7,x10/7,pk/f,x0/2,pj/p,x1/6,ph/b,x5/10,s6,x11/7,pa/g,x12/2,s1,x14/7,s8,x0/4,pj/b,s4,x3/1,s9,x5/10,s7,x0/8,s4,x1/13,s3,x12/8,pn/k,x11/7,pp/h,s14,x4/13,s7,x5/7,pn/i,x14/12,s6,x13/7,s13,x4/3,s11,x12/2,ph/p,x9/6,s8,x10/11,pc/m,x6/8,s1,pe/d,x15/1,s10,x12/5,pj/n,x14/6,pb/g,x5/4,s13,pi/c,x10/2,pd/k,x13/4,pl/f,x8/14,pj/d,x12/3,s3,x1/4,s15,x6/0,s12,x2/15,po/p,s10,x9/6,s9,x5/15,pc/e,x4/2,pp/j,x10/6,pb/g,x14/13,s13,x5/7,s15,x13/8,pd/j,x2/3,s13,x10/15,s4,x6/13,s5,x7/15,pp/i,x3/4,ph/e,x11/6,po/f,x14/5,s12,x2/1,s8,x14/13,s1,x11/3,s14,x13/10,pa/n,x6/4,pm/d,x15/7,pe/l,x10/11,pp/f,x1/0,s11,x13/12,s14,x15/9,s6,x5/0,pk/c,x15/6,pb/m,s5,x14/8,s7,x2/12,pi/g,x6/10,s5,x7/8,s15,x10/2,pb/p,x7/6,s3,x0/4,s12,x14/5,s2,x7/9,s7,x8/6,s8,x13/0,pi/h,x3/12,s10,x6/10,s6,x14/1,pe/a,x2/13,pl/h,x8/1,pn/k,x3/5,s8,x1/11,s3,x4/15,pm/p,x5/12,s3,x1/15,s15,x10/13,pg/c,x14/7,pe/i,x8/15,pa/l,x2/13,s7,x4/0,s4,x12/15,pc/j,x7/13,s3,x0/5,s1,pf/d,x7/15,pi/o,x0/11,pk/g,x8/10,s12,x6/15,s5,po/a,x3/13,s1,x1/11,pf/c,x5/10,s13,x1/8,s8,x14/9,s3,x7/11,s6,x0/13,pj/d,s4,x12/7,s3,x13/11,pf/a,x1/4,pk/d,x8/12,s9,x10/0,s12,pp/l,x8/3,pa/i,x7/5,s4,x1/13,s14,x10/9,pc/b,s5,x5/0,po/h,s11,pf/c,s5,x8/1,s8,ph/b,x4/3,pi/k,x7/0,s12,x8/14,pc/j,x1/7,s1,x10/6,s9,x5/15,s10,x9/3,pp/o,x0/15,pn/c,x9/1,pb/j,s10,x13/7,s13,x11/0,s6,x9/7,s9,x0/1,s1,x13/4,s11,x1/12,s15,x13/4,s12,x6/12,s1,x13/4,pi/o,x6/11,s12,x2/10,s1,pj/c,x0/12,po/p,x2/3,pk/n,x8/12,s15,x9/0,s5,x1/4,pi/p,x11/6,pa/f,x7/8,s5,x15/10,pk/m,s7,x2/8,s3,x1/14,ph/o,x11/10,s13,pg/k,x14/13,pc/j,x4/3,pk/g,s11,x7/6,s1,x5/0,s11,x11/3,s4,ph/m,s12,x8/2,s5,x4/14,pj/l,x11/2,s11,x3/9,pp/k,x5/6,s4,x8/15,po/j,x11/14,s8,x8/9,s1,x4/7,s2,x6/0,pm/g,x5/2,s4,pe/b,x6/13,pk/h,x4/2,pf/d,x11/8,s3,x10/5,s11,x6/12,s4,x15/14,s4,x13/8,pi/a,x6/10,pf/c,x4/7,s12,x10/14,s2,x1/6,s1,x15/9,s10,x10/5,s11,x13/7,s11,x11/3,pl/d,s15,x12/1,s9,pm/e,x15/0,pk/b,x7/5,pm/n,s5,x8/6,pe/d,x12/7,pb/o,x0/11,s11,x7/8,s14,pe/n,x13/2,s2,x0/15,pl/d,x6/10,pk/a,x8/13,s11,x12/0,s1,x13/15,pj/e,x8/11,s13,x10/9,s15,x11/0,s2,x14/5,s14,pl/k,x7/12,pi/p,x5/9,s5,x6/11,ph/j,x15/8,s8,x2/11,pc/o,s5,x7/12,pa/m,s1,pk/b,x5/15,s14,x3/4,pp/l,x7/14,s11,x8/10,s15,x2/4,s10,x8/0,pj/f,x2/1,pi/d,x7/10,s10,x4/9,s14,x5/7,s3,x3/15,s10,x11/12,s2,x8/15,pl/m,s9,x0/12,s1,x3/11,pn/k,x12/4,s4,x8/14,pe/a,x0/6,s8,x11/7,pj/n,x2/10,pc/o,x8/14,pn/i,x6/10,s14,x15/11,ph/j,x14/5,s9,x0/10,s8,x7/12,pi/k,x2/14,s11,x0/15,s1,x4/11,s13,x10/2,s15,x5/14,s2,x2/12,s12,x5/10,s14,x15/7,pp/n,x13/6,s2,x0/14,pb/d,x3/1,pk/p,x5/4,pb/h,x13/0,po/e,x1/12,pf/g,x13/10,ph/p,x1/3,s3,x12/4,s4,x2/0,s11,x7/6,pj/d,x11/14,pf/o,x4/10,pd/c,x15/7,s8,x2/6,s4,x7/10,s8,x9/14,s6,x5/1,ph/e,x12/3,s11,x7/4,s7,x14/2,s11,x12/0,pn/j,x15/1,pg/b,x3/8,pd/j,x14/1,s13,x4/9,s2,pp/h,x14/5,pn/a,x2/0,s15,x10/13,s9,x3/6,pd/g,x1/15,s14,x14/13,s13,x9/2,pm/i,x8/7,s9,x0/12,s9,pk/a,x8/2,s6,x3/0,s10,x8/4,s5,x3/5,s5,x1/14,s3,x2/4,s13,x9/13,pg/f,x7/1,s2,x13/2,s5,x14/7,s8,x13/6,s6,x4/7,s10,x3/11,s6,x5/1,s12,x8/12,s13,x0/6,s10,x7/9,ph/k,x3/11,pg/j,x4/5,s4,x8/1,s14,x15/6,s8,x0/1,s13,x9/4,s8,x1/15,pd/i,s8,x3/13,pj/b,x2/10,pf/c,x9/8,s15,x3/6,pg/m,x9/0,pd/j,x7/11,ph/i,x9/1,pk/m,x13/5,s15,x14/1,pb/d,x11/9,pk/p,x3/13,pa/i,x1/8,s15,x4/3,s1,x0/13,s6,x3/1,pg/d,x7/14,s2,x15/1,s5,x10/12,ph/e,x9/2,pn/m,x10/7,s5,x14/12,po/e,x9/2,s13,x0/13,s10,x6/8,s8,x5/3,s3,x2/10,s5,x7/0,s10,x2/13,s8,x1/11,s9,x2/8,s4,x4/5,pm/d,x0/10,pn/i,x6/5,s4,pk/j,x11/0,s2,x10/5,s13,x1/11,pi/m,x12/10,s15,x7/3,s5,x14/13,s1,x11/3,po/j,x13/0,pm/l,x15/4,pe/p,x7/5,pk/l,x6/3,s12,x0/2,pm/n,x8/14,s13,x13/9,s1,x15/3,s4,x5/7,s3,x15/11,pp/f,x10/6,pe/o,x1/15,s11,x8/12,pc/m,x4/13,ph/o,x5/7,pi/l,x10/2,pp/j,x12/1,s12,x3/14,pi/k,x5/2,s10,x3/14,pp/g,x4/7,s10,x6/13,s6,x1/3,pc/k,x11/14,s3,x3/12,s13,x8/15,pb/m,x13/9,pg/d,x14/8,s1,x10/9,pl/e,s8,x3/14,pp/m,x2/10,s4,x15/11,pc/k,x5/13,s2,x7/3,s1,x0/5,po/e,x1/6,s10,x3/8,s4,x13/6,s8,x15/5,s2,ph/a,s10,x7/1,s8,x11/2,s15,x8/9,s10,x6/1,pb/e,x7/10,pc/g,x3/0,pj/e,x7/12,pp/d,s10,x8/1,s10,x10/4,s6,x0/5,pe/l,s13,pa/i,s13,x7/14,pk/p,x3/10,s7,x7/4,s10,x12/11,pl/b,s4,x9/5,s4,x6/10,pm/i,x12/9,s7,x10/14,s12,x3/1,pf/b,x9/11,s1,x3/12,pl/e,x7/9,pp/o,x4/6,s2,x11/9,pi/j,x7/3,pd/e,x13/6,s14,x1/12,s8,x11/15,pp/k,x12/9,pa/h,x2/11,pp/o,s14,x7/10,pm/h,s2,x15/1,pj/d,x13/5,s13,x0/4,s15,x9/12,s11,x2/7,s7,x12/3,s5,x0/2,s12,x3/11,s13,x9/12,pi/h,x14/10,s6,pf/p,x9/6,s1,pg/o,x5/3,s14,x11/0,pl/h,x8/14,s7,x7/10,s1,x9/12,pi/d,x10/1,s11,pg/h,x8/6,s7,x4/11,s10,x6/14,s9,x12/0,pi/k,x15/1,pa/h,x8/11,s9,pn/e,x6/2,s1,x7/15,s8,pg/o,x11/13,pb/e,s7,x1/10,s4,x3/0,s11,x6/8,s9,x5/3,pj/i,x11/15,s7,x4/14,pk/e,x15/1,s14,x11/12,pm/c,x6/13,s10,x5/8,s11,pp/n,x1/2,s15,x5/4,s12,x10/0,pe/l,s10,x5/2,pm/h,x1/6,pi/d,x5/7,pb/j,x0/8,pf/k,x1/3,pd/i,x13/15,s3,pk/e,x9/10,s4,x2/0,s7,x15/13,pg/d,x3/4,s7,x14/13,s8,x15/7,pk/j,x2/12,s6,x14/0,pl/a,x8/15,pn/c,s8,x13/0,s14,x15/4,ph/k,x8/13,s9,x1/12,s4,x6/3,s10,x0/1,pp/o,x14/12,pc/l,x15/4,s10,x12/13,pn/j,x14/11,pc/a,x8/13,pi/m,x10/1,s14,x4/2,s14,x13/6,pj/h,x12/2,pi/g,x5/7,s15,x6/14,pd/p,x13/0,s8,x3/10,pj/b,x9/4,pf/h,s11,x11/3,s9,x9/13,s7,x0/14,po/g,x7/6,s7,x8/2,pl/m,x15/13,s14,pn/c,x11/8,s7,x1/13,s8,x11/5,s9,x0/1,s3,x8/12,ph/g,x13/15,pm/i,x5/0,s10,x8/3,s1,x6/4,pc/j,x13/12,s5,x9/11,pl/e,x6/7,s1,x1/8,s9,pb/i,x10/6,s6,x1/5,pf/c,x12/11,pb/g,x0/4,s4,x12/7,pd/l,x2/6,pe/b,x10/0,pc/j,x12/5,pa/g,x14/6,pp/e,x9/11,pk/g,x14/10,s3,x11/3,s12,x10/8,s2,x12/5,s14,x13/9,s4,x1/2,s2,x13/12,pl/f,x4/8,s12,x7/0,s10,x6/8,s7,pk/n,x0/12,pa/j,x9/6,s9,x8/5,s14,x3/15,s2,x11/1,s9,x4/3,s4,x0/8,s7,x1/6,s4,x3/4,pk/i,x1/6,pf/b,x2/3,s11,ph/n,x14/9,s1,x0/5,pi/o,x14/11,pp/e,x12/0,pl/k,x15/6,pm/e,s14,x11/4,s9,x9/3,s4,x4/11,s14,x10/8,s7,x1/0,s4,x13/7,pk/b,x2/8,pe/m,x1/5,s7,x6/7,s15,x15/5,s12,x2/8,s10,x1/3,s8,x11/9,pp/c,x10/4,s12,x11/1,s10,x0/6,s7,x3/11,s13,x15/0,po/f,x4/14,s11,x3/1,pk/p,x14/4,s6,x6/11,ph/b,x10/7,pj/n,x5/3,pp/g,x1/11,s6,x2/4,s5,pk/d,x10/13,pp/o,x7/15,s8,x5/10,s15,x7/3,s10,x12/2,s9,x8/13,s6,x7/15,s13,x12/13,s8,x10/0,s8,x12/4,s14,x15/2,pc/i,s15,pj/p,x12/1,po/n,x14/9,pf/p,s11,x12/13,s6,pd/n,s3,po/e,x2/15,pl/p,x1/11,s5,x10/12,s12,pb/o,x9/1,s15,x13/3,s8,x8/15,pf/j,x0/1,pb/o,x6/15,pi/n,x10/12,s6,x13/15,pl/e,x0/14,ph/g,x1/13,s9,x3/14,s11,x1/5,pk/i,x0/4,s8,x5/1,s8,x6/0,pf/p,x11/7,s13,x0/10,s6,x11/1,s4,x15/14,s4,x4/1,s2,x11/13,s11,x4/8,s8,x9/11,pi/n,x1/7,s15,x9/4,pp/b,x3/15,s11,pn/j,x5/13,s13,x6/15,pk/a,x9/8,pb/j,x13/2,pg/c,x1/8,s15,x6/5,s10,pj/i,x3/4,po/f,x0/5,s7,x6/9,s7,x13/3,s15,x8/1,s7,x9/11,s9,x7/0,s4,x10/5,s13,x0/14,s14,x6/10,s10,x2/3,s6,pa/k,x14/13,s2,x8/15,s11,pn/m,x12/2,pl/i,x6/9,s7,x12/7,s7,x11/0,s10,x12/9,s1,x2/4,pp/a,s14,x15/11,s7,x6/5,pb/f,x10/3,pg/m,x7/12,s4,x4/13,pj/o,x9/0,s11,x8/2,s2,x10/11,pc/d,x4/0,s11,pb/k,x5/11,pg/l,s11,x8/13,s14,x5/7,ph/p,s3,x0/12,pc/m,x11/3,pg/i,x12/4,pc/o,x7/13,s7,x14/6,s6,x15/9,s13,pl/e,x14/4,s4,x5/2,s11,x3/12,s7,x6/8,s15,x14/3,s10,x8/10,pp/g,x11/6,pa/o,x4/0,ph/b,x14/10,pi/o,s12,x7/6,s15,x5/10,s4,x8/4,s6,x5/11,pd/n,x15/1,s10,x8/10,s1,x14/15,pf/i,x4/11,pn/p,x0/12,s15,pd/c,x15/2,s14,x13/6,pk/e,x10/7,pg/d,x3/0,pk/h,x9/12,pn/m,x7/14,pg/i,x11/13,s7,x15/1,s10,x2/11,s14,x15/8,s8,x4/5,s1,x7/9,s11,x13/4,s10,x1/14,s14,x13/0,s3,x11/6,pm/o,x13/10,s7,x0/3,pf/d,x14/1,pi/o,x2/10,pb/c,s3,x3/0,pg/p,x6/13,s13,x8/10,pa/j,x5/12,s9,x9/2,s7,x0/5,po/k,x12/4,s13,x13/7,s2,x12/5,pg/h,x6/13,s11,x15/2,pe/f,x10/13,s10,x15/6,pk/o,x8/10,s10,x0/11,pd/n,x9/4,pj/o,x5/1,s15,x15/14,pl/g,x6/7,s10,x8/3,po/p,s10,x5/15,pb/n,x14/4,s14,x2/9,s6,x14/8,s11,x15/3,pd/j,x14/5,pb/k,x2/13,s8,x8/12,pn/l,x10/11,pe/k,x14/15,pm/i,x4/1,pd/n,x12/0,s4,x3/2,pj/e,x11/7,s11,pi/d,x6/3,s2,x11/5,pm/o,x9/3,s8,x15/11,s8,x0/3,pf/l,x15/10,pm/b,s3,x8/3,s13,x6/4,pj/k,x9/11,pe/o,x2/14,pb/f,s13,x5/3,pe/l,s1,x14/10,pc/d,x3/2,s6,x1/14,s9,x7/12,s11,x8/10,pn/j,x14/11,s6,x15/2,s4,pd/c,x11/4,s3,x13/10,pf/b,x14/9,pk/a,x15/5,s11,x3/7,pe/g,x11/10,pd/n,x4/0,pp/e,x13/3,s13,x5/7,pa/b,s12,x15/11,pj/d,x3/13,pp/o,s10,x1/0,pf/a,s12,x8/12,s10,x4/6,s1,x10/3,pe/i,x13/9,s7,x12/8,s4,x7/4,pd/p,x6/13,s9,x11/10,s10,x5/4,s8,x2/1,pb/e,x4/12,s11,x7/1,pa/n,x15/14,s3,pl/p,x1/12,pa/i,x3/7,s3,x1/11,pk/j,x14/12,s10,x15/10,s1,x13/2,s7,x8/1,s13,x9/3,pa/o,x6/7,s15,x4/0,s8,x13/11,s3,x15/10,s8,x8/5,s14,x13/4,s1,x3/10,ph/e,x1/8,pf/n,s10,pi/j,x6/0,s8,x10/14,s8,x15/5,pp/n,x13/4,pl/e,x7/14,s5,x0/15,s5,x9/8,s15,x5/6,s5,x3/15,s6,x7/14,pb/j,x10/5,s5,x13/1,pp/o,x0/2,s11,x15/4,s2,pl/f,x9/3,s6,x13/4,s8,x15/8,s11,x7/12,s9,x9/3,ph/i,s11,x1/10,s6,x7/0,s4,x1/9,pd/c,x5/0,s7,x9/6,pb/j,x13/3,s9,x9/6,pf/d,x7/0,pk/j,x2/1,s5,x6/5,s5,pi/o,x14/1,ph/d,x5/15,s8,x1/6,pj/e,x13/8,pf/o,x5/7,s6,x13/15,s15,x4/2,s6,x3/12,s3,x8/10,s12,x2/9,s3,x6/1,s1,x0/3,pl/g,s7,x12/5,s14,x3/13,s7,x10/1,pa/e,x11/4,pl/c,x10/13,s2,x15/0,pe/j,x1/12,s1,x11/7,pl/k,s13,x8/4,pc/m,x14/6,s8,x12/11,pj/p,x0/7,s5,x1/12,s7,x10/7,s9,x6/4,s7,x2/11,pi/e,x7/4,pa/b,x15/2,s8,x6/12,pj/f,x4/8,pm/p,x14/13,po/b,x10/9,pg/k,x2/1,s8,x15/9,s5,x0/6,pi/m,x15/4,s5,x13/12,s10,x4/11,ph/d,s14,x14/5,pl/b,x0/12,s1,x4/8,ph/f,x14/10,s3,pg/i,x12/15,pc/p,x7/4,s12,x6/5,s2,x3/0,s2,pe/f,x9/7,s6,pb/g,x10/12,po/p,x1/15,s13,x12/0,s7,x5/9,pd/k,x0/3,s14,x11/9,s8,x6/3,s9,x2/11,s1,x12/5,pl/b,s13,x14/10,ph/n,x4/15,s5,pc/b,x9/0,pe/i,x13/1,pk/b,x8/14,s3,x12/3,s13,x7/4,pd/c,x10/15,pf/a,s11,x13/8,s8,x4/5,pn/e,x3/12,pj/p,x7/4,po/a,x2/10,s8,x7/3,pk/h,x2/14,pa/i,x0/15,ph/g,x11/12,s11,x0/9,s11,x13/15,s7,x10/3,s11,x12/1,pd/k,x0/10,s10,x6/11,s3,x1/2,s5,x12/8,s6,x3/2,s7,x9/5,s12,x14/4,pb/c,x15/0,po/n,s2,x5/10,s12,x7/13,s15,x10/4,s1,x3/1,pc/h,x11/0,s5,pm/f,s3,x9/7,s10,x0/11,s11,x13/10,pc/a,x3/0,s2,x13/1,s8,x9/4,s1,x6/14,s9,x9/0,pg/k,x6/1,s5,x2/15,pc/i,x9/13,ph/e,x6/12,s14,pi/p,x15/10,s13,x0/6,pg/n,x3/8,s7,x7/9,s14,x0/10,s9,x12/6,pe/j,x9/13,s5,x5/6,pa/h,x9/14,s11,x7/4,s8,x6/2,pm/b,s9,x14/10,s14,x2/8,s11,x10/7,s15,pk/o,x4/2,pp/f,s12,x6/8,s14,x5/11,pg/h,x0/13,s6,x2/6,pn/i,x14/10,pa/o,x8/4,s6,x3/6,s4,x4/9,pp/d,x13/15,ph/o,x10/14,s9,x12/13,s9,x10/0,s4,pi/n,x8/13,s15,x15/2,s12,x3/1,pp/j,x13/0,pd/a,x2/8,pn/e,x0/13,pi/b,x14/2,s8,x15/8,s8,x2/10,s13,x6/9,pf/j,x3/5,s6,x15/2,pi/c,x4/9,s1,x6/1,s3,x12/8,s9,x13/9,pb/o,x4/5,pj/k,x7/13,pm/f,x10/5,s11,x3/15,s4,x1/0,pj/p,x7/3,s4,x2/0,s12,x6/3,s7,pe/o,x9/13,s6,x15/1,s11,x14/6,s2,x10/11,s6,x0/2,pm/d,x9/3,pk/c,x14/10,s11,x3/15,s11,x9/5,s1,x7/0,s15,x12/11,s6,x1/10,pf/i,x14/4,s13,x3/2,s10,x15/6,pd/p,x4/8,s9,x15/7,pe/i,x3/8,s14,x14/1,s8,x2/11,pd/c,x8/9,s1,x15/5,s15,x9/1,s5,x10/11,pa/b,x7/6,s14,x11/4,s8,x5/8,pp/o,x13/9,pj/h,s5,x15/4,s6,x13/11,s2,x10/1,s1,x6/9,s9,x11/4,s2,x2/12,pf/d,s8,x5/1,pk/g,x2/13,s12,x3/1,s12,x6/9,ph/m,x2/10,pi/p,x4/5,ph/n,s8,x8/14,pl/i,x1/10,pp/a,x5/2,pb/g,x0/11,s5,x14/1,s15,x4/2,s15,x6/13,s5,x12/9,po/h,x10/1,s15,x15/6,s5,x2/0,s9,x6/5,s3,x7/10,pf/l,x9/6,s12,po/h,x3/15,pk/g,x10/1,s7,x0/6,s1,x5/15,pf/e,x6/8,s5,x4/11,s2,x8/2,s11,x7/0,s11,x6/8,s13,x11/15,pp/h,x13/0,pd/l,x9/6,s13,x11/2,pa/m,x13/12,pc/j,x1/6,pm/i,x8/11,s3,x3/6,pe/d,x4/7,s10,x6/15,pg/f,s2,x9/0,s13,x15/8,s12,x12/6,pl/b,x11/8,pc/f,x0/7,pb/j,x15/5,s12,x6/14,pp/i,s1,x2/10,s4,x11/7,s9,x6/12,pd/o,x8/0,s11,x7/2,pk/g,x1/12,s1,pm/i,x3/11,s1,x5/15,pn/b,s6,x3/12,s2,x11/0,s14,x5/4,s2,x8/9,s12,x12/0,s11,x1/9,s14,x15/2,po/e,s12,pp/k,x3/11,pf/n,x2/0,s15,po/c,x15/14,s9,x6/2,pe/a,x10/12,pn/l,x9/14,s13,x0/7,pd/m,x12/6,s12,x3/0,s11,x11/12,pf/g,x14/2,s2,pl/e,x4/6,s2,x11/0,pg/i,x1/7,pj/b,x10/13,s6,x8/9,pl/e,x10/6,pp/k,x7/0,s1,pe/b,x13/12,pp/c,x5/2,s4,x1/10,s13,pi/o,s10,x13/7,pb/h,x5/4,s12,x12/0,pa/f,s7,x7/13,s14,x2/9,pm/n,s6,x12/6,ph/g,x14/11,s12,x4/8,pn/f,x5/9,s13,x4/8,s13,pc/h,s10,x15/13,s5,x12/11,s2,x15/0,pd/g,x3/7,pl/e,x10/14,s7,x9/7,s15,x12/11,s7,x0/9,s2,x10/7,pj/b,s10,x11/15,s4,x7/6,s13,pa/k,x9/5,pe/n,x8/4,pg/h,x5/2,s13,x8/12,s6,x11/2,pe/i,x5/9,s7,x4/13,s4,x8/0,s9,x2/13,s2,x4/8,pb/g,x1/5,po/p,x6/10,pi/d,x13/14,pg/c,x3/9,pl/a,x13/15,s1,x9/2,s15,x8/7,s12,x4/1,pn/j,x11/8,s11,x1/13,pg/i,x7/4,s4,x9/0,ph/m,x6/1,s8,x7/14,pi/f,x4/3,s1,x12/8,s10,x4/13,s11,x9/15,s1,pn/a,x2/13,pl/p,s10,x4/12,pm/o,s7,x13/8,s9,x2/6,s6,x15/11,pa/c,x1/7,pb/f,x3/13,s8,x5/0,s1,x15/4,pe/c,x3/1,s9,x14/12,pm/f,x0/10,s1,x3/12,s4,x4/10,s5,x3/7,s7,x8/14,pc/n,s2,x11/7,pf/g,x3/15,s8,x4/8,s8,x5/13,s9,x12/14,s11,x13/1,s7,x2/6,pl/c,x8/10,po/d,x4/9,s2,x11/8,s6,x9/15,s1,pf/n,x11/0,pd/e,x8/3,s7,x0/10,pn/f,x4/5,pc/k,x8/10,s8,pe/g,x5/13,pi/d,s9,x0/12,s7,x2/8,s7,x5/4,s3,x12/7,pp/n,x10/3,s13,pe/h,s1,pk/d,x13/11,s5,x4/2,s15,x15/13,s5,x14/6,s14,x15/2,s14,x10/6,s7,x2/3,s9,x14/15,s12,x12/0,pn/m,x5/14,pp/e,x11/2,s2,x4/0,s8,x10/12,s2,x0/7,s9,x13/4,pb/l,x15/10,s6,x0/8,s2,x12/1,s7,x11/7,s7,x13/15,pf/a,s8,x8/1,s6,x7/2,s7,x13/6,pe/m,x4/11,pf/c,x12/15,s11,x5/4,s6,x0/10,s5,pl/b,s5,x11/6,s7,x8/13,pm/h,x5/2,s6,x8/12,pk/f,x5/10,po/j,x3/14,s6,x9/1,s4,x5/14,s10,pe/a,s5,x8/15,s2,x9/10,s13,pj/m,x6/1,s11,x4/8,s1,x15/13,s13,x8/6,pg/i,x12/3,s10,pa/j,x13/10,pl/b,x6/1,pf/k,x10/11,pn/o,x8/4,ph/a,x3/7,s6,x10/13,s12,pd/k,x6/8,s1,x5/4,pa/o,x12/0,s11,x3/9,s3,x2/5,s15,x7/13,s8,x15/6,pf/g,x12/7,pn/h,x3/6,s7,x11/1,s1,x7/5,pg/c,x11/10,s12,x2/13,s14,x3/4,s11,x15/8,s13,x10/7,s4,x8/9,s2,x6/7,s9,x15/0,s10,x11/3,s5,x12/6,s14,x2/4,pp/j,x7/6,pm/d,x5/9,pn/e,x15/2,pi/j,x11/6,s7,x2/0,s11,x6/1,pl/k,x8/3,s13,x4/13,pa/h,x5/7,s14,x6/2,pm/d,x12/4,pi/b,x10/3,s7,x15/6,po/e,x12/7,pg/a,x0/6,pl/c,x4/3,pp/g,x12/11,s4,x5/9,pk/n,x13/6,pj/l,s9,x12/10,pa/n,s9,x8/4,s8,x12/2,pk/i,x14/7,s11,x5/15,po/e,x6/4,s4,x2/10,s1,x13/11,pn/g,x2/9,s10,x5/7,pp/b,x9/3,pg/h,x2/8,pa/f,s2,x7/15,s13,x4/13,s2,x11/5,s8,x0/14,s11,x8/13,pb/j,x4/7,pf/k,x12/10,s12,x7/9,pl/i,x6/5,s5,x2/1,s1,x8/15,s13,x10/2,s9,x11/14,s8,x10/8,s8,x2/12,pb/e,x8/10,ph/n,x7/1,s11,x9/12,s11,x10/0,s15,pk/p,x2/1,s2,x3/15,s15,pd/b,s3,ph/f,x10/1,pc/i,x14/2,s12,x5/4,pl/g,x6/0,pc/h,x8/10,s1,x0/6,s7,x1/10,s2,x14/3,pm/d,x7/2,pc/f,x14/12,s8,x5/13,s12,x1/11,pl/m,x13/0,pa/d,x2/14,pc/j,x9/12,s8,x11/0,po/e,x12/8,s9,x7/11,s10,x8/15,pd/f,s15,x0/11,ph/k,x3/8,s5,x13/7,s2,x1/14,s14,x3/0,s12,x13/11,pi/g,x2/14,s9,x9/11,s13,x10/14,pd/j,s10,x8/5,s8,pi/p,x6/7,pd/a,x11/0,s6,pb/p,x2/13,pa/i,x5/0,s1,x12/8,s6,x11/6,s14,x1/15,pl/f,x7/10,pb/c,x13/1,s7,x2/11,s5,ph/d,x6/15,s6,x4/13,s2,x10/14,pn/b,x9/12,pp/k,x14/6,s10,x8/7,s12,x6/15,pi/a,x13/7,s15,x6/14,pp/j,s13,x3/8,s4,x13/7,pc/i,x9/11,s9,x7/1,pl/f,x11/6,s12,x3/10,pp/h,x15/12,s6,pa/n,x7/11,pc/k,x15/8,s15,x1/9,pe/h,x4/11,s11,pi/b,s5,x1/9,pa/l,x3/11,pj/b,x9/4,po/c,x6/2,s5,x15/4,pe/h,x5/11,pi/l,x12/2,s4,x10/14,s14,x8/0,s1,x10/11,pd/m,x0/8,pp/l,x1/5,s9,x0/11,s11,x9/15,s3,x11/5,s13,x1/3,s3,x13/15,s11,x9/8,pa/g,x11/2,s9,x12/3,pi/c,x1/2,pp/l,x6/9,s12,x2/0,pa/j,x15/14,pn/c,s14,x7/5,s2,x12/0,po/k,x3/13,s3,x2/11,s1,x3/14,s15,x11/9,s1,x8/5,s7,x13/0,s9,x1/3,s15,x0/10,pa/h,s5,x11/5,s10,x14/8,pl/f,x13/0,s1,x8/4,s6,x10/7,s13,x12/9,pm/i,s11,pc/a,x7/3,s2,x14/11,po/h,x1/13,s9,pj/i,x8/10,pf/o,x3/4,s2,x11/15,s13,x2/7,s9,x4/13,pi/n,x1/14,s4,x10/12,s7,x14/8,pe/f,x2/12,pj/l,x10/1,pg/e,s14,x2/13,pa/b,x15/3,s1,x7/6,s6,x14/2,ph/o,x7/10,pn/d,x4/0,s3,x7/3,s13,pg/b,x12/13,s6,x14/3,s12,x9/8,s11,x4/10,s13,x2/3,pc/j,s13,x10/15,s4,x9/2,pg/m,x10/4,po/l,x3/12,s7,x14/9,pm/a,x10/4,po/n,x0/7,pa/c,x15/8,s6,x3/2,pe/m,s5,x14/8,s15,x10/13,pk/d,s14,x14/4,ph/o,x0/11,s9,x8/6,s6,pc/k,x15/9,s12,x4/3,s2,x0/8,s4,x7/15,pa/i,x4/0,s8,x12/2,pb/e,x14/10,pk/m,x9/15,pe/o,x3/10,s9,x4/8,pm/d,x2/7,s1,x9/14,s10,x4/2,s13,x7/0,pa/l,x13/11,pf/g,x6/2,s6,x3/15,pl/b,x5/14,s11,x1/8,pp/g,x13/0,po/c,s3,x6/8,pb/i,s10,x1/0,s3,x10/6,pa/h,x1/7,pp/j,x15/5,pa/o,s14,x9/10,ph/f,x3/7,pb/m,x2/6,s5,x1/4,pa/g,x2/3,pk/m,x4/15,s2,x3/7,pj/c,x5/15,s12,x14/8,s6,x6/3,pk/b,x2/12,s14,x14/6,pd/o,x4/0,s9,x14/13,pl/f,x4/5,s3,x3/0,s11,x2/8,pe/k,x14/9,s13,x12/13,s7,x3/1,pb/h,x6/12,s9,x3/13,s3,x6/15,s10,x9/12,pd/i,x5/6,s8,x0/7,pb/j,x3/1,pg/m,x14/10,s15,x5/13,pf/d,x10/7,s3,x13/1,s7,x12/8,s9,x2/0,pi/b,x13/9,s2,x3/5,s6,x7/0,s7,x14/13,pm/n,x10/0,pd/k,x1/3,pa/i,x12/9,pd/g,x4/5,s10,x6/7,s8,x9/8,s9,x0/2,s5,x3/10,s12,x6/7,pn/j,x11/2,s2,pk/m,x1/15,s12,pd/o,x10/4,s10,x3/13,pl/k,x10/12,s10,x11/14,pe/j,x0/3,s6,x6/2,s8,x14/1,s15,x11/13,pi/d,x7/2,pl/f,x15/8,pc/m,s15,x2/7,s4,x15/6,pf/d,x9/1,pk/c,x0/5,s10,x4/12,s14,pl/n,x11/15,pc/h,s5,x14/3,s11,x1/4,pf/k,x9/3,s1,x12/6,pn/j,s5,x14/15,s11,x5/12,s2,x2/1,s8,x6/8,pe/l,x7/15,pd/j,x13/11,pl/o,x6/1,s13,x3/15,pd/g,s8,x4/13,po/e,x9/7,s1,x1/4,s6,x3/6,s14,x13/10,s7,x9/3,pb/c,x5/12,s3,x4/13,pd/f,x0/2,s13,x11/5,s3,x6/15,s3,x3/7,pn/a,x8/2,s1,x13/5,s1,x10/0,pb/j,s10,x14/15,pf/p,s2,x6/2,s13,x15/14,pj/g,x9/10,s2,pi/e,x1/14,s15,x2/5,po/a,x8/7,s8,x2/11,pf/h,x4/1,pi/c,x6/11,s9,x0/8,po/h,s15,x7/14,s15,x4/6,s8,x7/11,s4,x14/8,pp/a,x0/6,s3,x9/1,pm/n,x0/12,s7,x8/11,s10,x2/14,s4,x6/4,pj/g,x8/15,pn/f,x10/2,s2,x3/1,ph/k,x10/5,pe/g,x0/12,s12,x2/1,pf/p,x9/8,s7,pl/b,x3/6,pm/a,x10/2,pb/f,x3/8,pl/o,x1/2,pe/b,x6/11,s1,x5/1,s4,x12/15,s13,x4/2,pa/f,x8/12,s9,x5/10,s14,x9/4,s15,x2/5,s11,x15/13,s13,x10/6,s3,x13/9,pm/j,x4/6,pi/p,x10/14,s3,x8/7,pd/h,s14,x15/14,s5,x7/10,pi/g,x9/11,pl/c,x1/5,pa/k,x7/15,s9,x3/6,po/b,s10,x13/0,s2,x9/3,pa/n,x10/1,s6,x6/11,pc/g,s8,x9/13,s10,x4/15,s4,x6/2,s9,x7/4,pm/p,x3/6,s3,pe/f,x10/4,pa/h,x1/13,s2,pd/k,x14/11,pb/g,s3,x4/9,pd/i,x8/10,s8,x9/13,s7,x6/12,s1,x9/1,pj/b,x7/14,s5,x8/10,s13,x11/3,po/i,x10/12,s1,x7/11,s6,x0/1,s1,x8/2,s10,x1/14,s11,x13/0,s3,x7/12,pf/m,x11/8,pl/g,x4/13,s7,x1/2,s1,pj/o,s11,x7/8,s15,x6/4,s12,x12/0,ph/c,x15/5,s15,x4/1,pp/g,x14/0,s8,pi/o,s11,x1/13,s7,x11/6,s9,x7/0,pk/n,x10/11,pl/f,x9/1,s9,x15/13,s7,x7/11,s10,x0/2,s3,x11/8,s2,x3/13,s7,x5/0,s7,x3/11,pb/i,x6/4,pf/l,s5,x13/1,s5,x7/5,s7,x4/14,s11,x0/11,s10,x6/4,s1,x7/0,pi/n,x12/4,s3,x8/6,s15,x10/15,pa/e,x3/2,s1,x10/14,s10,x1/6,s9,x14/3,s9,x8/4,s4,x5/14,s4,x9/12,s9,x4/14,s12,x9/0,pk/g,s2,x8/1,s5,x15/9,s11,x11/5,s4,x15/10,s3,x13/14,s12,pl/e,x15/12,pk/j,x8/14,s5,x11/2,s3,x6/9,s2,x0/8,s1,pm/e,x14/1,s9,x8/5,pc/a,x12/14,pk/f,x15/5,s13,x6/7,s8,x1/13,pc/i,s7,x2/5,pp/l,x7/3,s11,x2/6,s11,x11/4,pb/o,x9/15,s8,x2/1,pc/a,s10,x5/8,s2,x7/15,pf/j,x0/2,pi/d,x11/4,pa/k,x7/0,s9,x11/5,s13,x7/2,pm/l,x11/4,s12,x3/7,s7,pd/j,x9/5,pg/a,s15,x0/14,s13,x13/11,pj/f,x3/6,pp/d,x0/13,pb/g,x8/2,s15,x15/11,pi/k,x7/12,s1,x6/5,pd/b,x8/13,s15,x4/5,s2,x13/6,pf/p,s6,x7/1,s14,x6/14,s7,x2/1,s2,x8/4,s10,x6/13,s7,x1/4,s5,x11/6,pa/c,x9/13,pd/k,x5/3,s8,x7/9,pf/e,x1/13,pm/j,x12/8,s3,x10/9,s14,x7/5,pf/p,s12,x10/11,pl/j,x14/0,pp/d,x13/6,s1,x9/4,ph/b,x15/8,s12,x12/13,s3,x9/3,s10,x5/11,s10,x14/13,pn/a,x15/10,s14,x6/11,s12,pe/h,x13/8,s9,x11/5,s6,x0/7,pm/d,x4/6,s13,x3/11,s7,x0/4,s13,x10/6,s2,x13/4,s1,x11/6,s15,x3/5,s5,x11/2,s10,pp/a,x10/12,s11,x7/0,po/d,x4/11,s13,x14/7,s6,pi/m,x8/11,s15,ph/f,x13/10,s10,x15/5,pm/j,x4/6,s3,x9/8,s4,x2/3,pg/c,x1/11,po/i,x15/8,pe/b,x9/10,s2,x4/6,pd/j,x15/13,s3,x10/8,po/e,x4/9,s9,x13/12,s14,x10/1,s1,x5/8,pk/l,x13/2,s9,x8/5,s7,x0/10,pf/m,x1/4,s4,x3/5,s5,x1/7,s7,x3/5,s6,x8/6,s13,x12/1,pj/b,x13/8,po/k,x12/5,pp/g,x2/1,pk/i,x7/6,s5,x14/2,s14,x11/3,pe/j,x9/13,s3,x15/1,s15,pf/o,x3/4,s10,x7/0,s11,x1/8,s9,x0/9,s11,x10/7,s6,x8/3,s1,x2/10,s2,x1/3,s1,x5/12,s13,x1/4,s11,x7/10,s13,x12/3,s3,x8/6,s9,pb/i,x1/11,s10,x5/9,ph/m,x10/8,pi/n,x5/12,s2,x0/14,s2,x1/6,s15,x11/10,s14,x6/7,pj/b,s9,x4/5,s15,x13/9,s7,x2/4,s9,pg/h,x6/8,s10,x9/3,s13,x13/7,s15,x10/2,s4,x14/5,s5,x2/11,pa/m,x13/10,pg/n,x4/3,pc/j,x2/10,pe/n,x8/0,s3,x6/5,pa/k,x15/12,pn/f,x3/10,s1,x8/15,s10,x14/10,pi/o,x2/7,s3,x10/8,s15,x1/5,pb/h,x13/0,s5,x15/10,s11,x13/8,s3,x6/3,pi/d,s1,x15/9,s9,x4/1,pj/g,x7/9,s8,x15/3,pf/d,x6/8,s3,x15/14,s12,x4/5,s6,x11/12,s7,x2/8,pc/n,x12/15,pj/b,x4/7,pg/h,x15/12,pn/b,x10/14,pe/l,x11/5,s7,pa/n,x3/12,s15,x11/14,s3,x6/1,s8,x7/8,s7,x0/6,s6,x12/13,s9,ph/g,x8/14,s9,x4/5,pe/l,x11/7,pk/a,s14,x1/9,pc/f,x0/7,po/m,x1/8,pe/n,x5/14,s11,ph/b,x10/4,pa/p,s14,x12/5,pm/e,x14/8,s5,x15/11,s6,x8/12,s1,pc/l,x0/1,s3,x6/15,ph/d,s10,pa/f,x10/9,pg/h,x7/0,pj/o,x13/14,s2,x7/10,pg/k,x1/3,s10,x9/15,pm/d,x6/13,s11,x7/2,s14,x5/11,s12,x9/3,pg/i,x15/2,s14,x4/13,s6,x5/9,po/j,x6/2,pl/p,x12/9,pe/n,x4/2,s5,x13/10,s14,x1/7,pk/l,x6/12,s4,x1/2,s5,x3/11,po/e,x13/0,s8,x7/3,s3,x13/12,s7,x5/8,s11,x10/0,pa/m,x2/3,s11,x5/1,pb/o,x6/10,pa/i,x0/11,s14,x6/4,s10,x0/2,s15,pj/l,x10/13,s5,pg/e,x4/15,s2,x2/6,s3,x13/0,s3,x3/2,s12,x8/4,s2,x5/12,pj/a,x3/13,pl/m,x6/1,s10,x9/15,s8,x1/5,pk/c,x7/6,pi/m,x11/3,s1,x13/10,pn/l,s12,x4/0,s12,x6/10,pg/d,x9/5,pp/l,x14/1,s2,x15/3,ph/o,x4/11,pb/j,x12/0,pg/e,x11/6,pf/l,s11,x3/0,s9,x13/12,s13,x3/7,pd/h,x14/6,pk/e,x2/7,pj/l,x13/3,pd/e,x0/7,pm/a,s8,x1/15,pf/d,x0/7,s12,x11/3,pc/n,x13/10,s13,x9/5,pi/m,s3,pd/g,x8/11,s1,x15/9,s12,pe/l,x11/13,s12,x3/12,s6,x7/1,s14,x10/6,s2,x4/0,pm/o,s5,ph/j,s12,x15/9,s11,pg/b,x10/2,s10,x8/9,s3,x12/0,po/j,x3/14,s5,x2/6,pd/m,x3/11,pi/h,x1/13,s12,x11/4,s4,x9/13,s4,x8/12,s13,x4/2,s8,x5/8,pg/a,x13/1,s1,x14/10,pp/d,s4,x5/6,pa/h,x10/15,pi/n,x1/8,s6,x0/14,s10,pe/l,x7/13,s8,x9/15,pc/o,x11/6,pa/b,x4/0,pd/c,s3,x5/9,s1,x12/8,s8,pj/e,x4/13,pm/k,x14/1,s12,pl/i,x2/13,s12,pm/j,x4/7,s9,x2/1,s5,x12/15,s3,x14/2,pg/o,x8/9,pf/l,x2/10,s13,x15/8,s3,x9/10,pg/k,s14,x1/7,s1,x14/9,pl/h,x7/5,s10,x8/4,s4,x10/15,s1,x12/11,pd/n,x0/6,pl/e,x5/10,s2,x6/15,pn/a,x7/3,s7,pg/e,s8,x5/4,s7,x11/8,s2,x2/12,pm/p,x13/3,pg/o,x0/2,s13,x5/8,s15,x6/14,s6,x13/1,s14,x8/9,s9,x4/15,pc/k,s5,x11/8,pf/h,x14/12,s1,x11/8,s2,x0/12,s1,x11/1,s8,x12/4,s9,x10/2,s15,x11/6,po/k,x3/14,s1,x13/15,s9,x8/11,s13,x7/6,pi/g,x10/9,pe/a,x8/13,s14,pc/d,x2/15,pi/k,x0/11,s12,x14/8,ph/o,x6/13,s10,x10/15,pp/j,x3/7,s2,x6/9,s4,po/k,x13/1,pf/m,x4/9,s9,x0/2,pn/o,x13/9,ph/i,x2/15,s4,x12/3,s8,pc/m,x4/9,pg/d,x2/13,s9,x12/4,pc/n,x2/8,pl/a,s13,x3/13,s14,x15/8,pg/f,x14/2,ph/l,s5,x11/13,pk/f,x7/1,s2,x5/13,s1,po/e,x8/11,s1,x3/12,pf/m,x9/0,pp/o,x14/5,s15,x11/7,s15,x9/5,s2,x2/0,s4,x5/14,s9,x12/4,s5,pe/i,x10/14,s2,pb/a,s13,x1/11,s12,pc/g,x14/0,s3,x5/7,pp/a,x10/13,s5,x3/6,s12,ph/o,s1,x7/8,s10,x3/5,s15,x15/2,pd/i,x7/14,po/c,x8/15,s13,x10/0,s13,pl/d,x3/7,s10,x6/1,s5,x14/8,s14,x12/4,ph/k,x2/11,s5,x1/15,s14,x4/0,pd/m,x9/2,s15,x7/15,s1,x13/6,s4,x7/10,s1,x9/1,ph/j,s1,x7/10,s14,x15/2,s12,x13/10,s8,x12/3,s7,x6/5,s13,x12/7,s12,x3/4,pc/a,x14/5,pn/h,x12/2,pk/j,x13/5,ph/c,x14/2,s2,x8/13,pj/g,x5/11,s14,pn/h,s6,x0/8,s6,x4/1,pe/g,x2/11,pm/k,x14/7,s15,x0/15,pe/j,x1/10,pd/h,s7,x11/2,s6,x0/12,pc/p,x2/10,s8,x15/12,pa/l,x10/14,s2,x4/11,s9,x3/15,s5,x10/1,pi/b,x12/2,s14,x3/13,s11,x10/6,po/h,x14/15,s4,x2/8,s8,x9/3,pm/j,x4/0,s12,x3/6,pd/o,x5/7,s10,x12/6,s15,x13/10,s5,pc/f,x12/6,pa/k,x1/2,s6,x15/5,s13,x0/12,s2,x15/11,s2,x8/9,s7,x2/0,s5,x11/6,s5,x1/8,pe/n,x11/4,pp/k,x2/10,s9,x15/14,s6,x4/5,s9,x9/1,pm/b,s8,x15/13,s2,x5/0,s6,x13/2,s15,x8/9,pg/p,x13/12,s15,pb/o,s1,x5/15,pk/a,x3/12,s13,x6/8,s1,x3/9,s11,x13/2,s2,x9/5,s1,x13/10,pm/p,x5/14,s13,pb/k,x15/7,pi/g,x6/4,s11,x10/9,s10,x1/7,pa/k,x3/8,s14,x13/15,s11,x6/8,s12,x3/7,pp/g,x10/0,pb/o,s8,x1/11,ph/a,x14/13,s5,x6/8,s10,x14/0,pg/c,s14,x6/9,s2,pe/j,x0/3,pm/i,x9/10,s14,x15/2,pf/g,x13/0,s8,x7/4,s14,x1/15,po/k,x7/8,pc/a,s10,x2/9,s6,x13/8,s11,x7/15,s13,x6/4,s11,x3/2,pb/l,x7/1,s9,x4/6,s15,x9/14,s6,x15/5,s11,x2/6,s3,x7/3,s7,x15/2,s6,x14/13,s11,x1/9,s7,pd/g,x4/2,s13,x7/6,s4,x9/5,s4,x13/3,po/l,x4/5,s15,x8/10,s9,pm/n,x9/14,pk/e,x1/5,s8,po/g,x8/13,s11,x10/15,s5,x6/8,s7,pe/f,s4,x14/1,pj/m,x10/8,s5,x0/5,s7,x7/11,s10,x12/9,s5,x1/0,pi/g,x15/7,s9,x14/10,s12,x15/6,s9,pl/b,x2/9,s15,x3/15,s14,pe/n,x0/10,pa/c,x3/8,s9,x7/10,pp/f,x11/14,s8,pa/e,x0/2,pk/b,x10/7,s13,x1/5,ph/m,x10/0,s11,x3/9,pj/e,x10/15,s7,x12/13,s12,x10/3,s8,x7/0,s8,x2/4,s7,x3/12,po/b,x13/10,pk/e,x15/5,pb/n,x0/8,s6,x9/4,ph/l,x7/11,pp/k,x12/3,pb/l,x6/15,pg/i,s2,x10/4,s3,x9/12,s4,x1/7,s4,pj/o,x8/5,pb/g,s4,x1/11,s2,x6/3,pl/d,x14/0,po/b,x5/12,s7,x13/7,s14,pp/i,x1/9,s3,x15/12,s3,x0/1,s3,x2/4,po/l,x10/14,s13,x8/3,pg/j,x6/14,po/i,x3/11,s7,x4/8,s8,pa/f,x12/3,pb/h,s11,x5/6,s14,x11/0,s8,pg/p,x13/5,s15,pj/n,x10/1,s10,x9/12,s7,x5/1,s4,x11/2,pm/i,x0/1,s3,x3/4,pc/n,x2/15,s7,x3/7,s1,x1/4,pd/b,x10/5,s15,x13/11,s10,x14/10,s13,x1/4,s4,x5/14,pe/m,x1/4,pb/h,x10/2,s14,x13/11,pp/k,x12/0,s14,x3/7,s14,x13/5,s7,x10/11,pd/g,x9/4,s4,x2/10,s10,x7/8,s4,x1/15,pe/l,s3,x0/12,s12,x2/7,s15,x1/14,s2,x12/3,po/p,x11/8,ph/l,x12/9,s2,x5/3,s8,x7/4,s11,pk/e,x1/15,s13,x13/8,pc/p,x3/4,s5,x7/6,s3,x14/10,s5,x1/11,s14,x0/15,pa/l,x9/14,pj/k,x12/11,s3,x7/3,s11,x0/13,pp/a,x3/8,pg/h,x12/1,pi/j,x6/2,pg/p,x7/4,s13,pm/j,s5,x11/12,s7,x9/10,s15,x15/6,pc/l,x2/11,s11,x0/13,s3,x11/5,pa/d,x14/2,s13,x8/0,pn/h,s1,x14/5,pp/e,x0/3,pj/k,x13/2,s1,x15/12,pm/i,x10/6,s7,x4/9,s5,x12/0,pe/n,x6/9,s6,x13/0,pj/o,x6/9,s13,x10/15,s14,x5/6,s8,x15/3,pe/b,x5/8,ph/i,x1/7,s2,x3/11,po/g,x0/13,pj/f,s4,x10/4,s1,x15/7,pa/n,x6/13,pm/j,x9/5,s8,x14/11,pp/h,x9/10,pn/l,x8/1,pa/j,x13/4,s10,x15/6,s15,pi/f,x11/12,s14,x1/10,s15,x12/7,pl/j,x8/10,s1,x9/14,s7,x2/12,pd/o,x11/15,pl/c,x4/3,pi/e,x6/13,s9,x9/10,s11,x1/13,pa/f,x5/6,s9,x11/10,pb/g,x15/13,pe/h,x0/2,pl/j,x9/7,s6,x3/10,pm/e,x9/11,pk/f,s11,pm/p,x4/6,s3,x0/7,pj/a,x4/15,s6,x3/5,s7,x9/0,s14,x12/2,s1,x9/3,s12,x7/2,s14,x14/3,s12,x9/15,pl/g,x13/4,s10,x14/3,s7,x13/12,pm/f,x0/8,pa/i,x9/3,s9,x15/8,ph/b,x6/4,s11,x8/13,s7,x10/2,s10,x3/0,pi/o,x14/5,s10,pa/g,x12/4,pf/m,x0/7,s2,x12/15,s13,x1/14,s13,x8/11,pk/i,x5/14,pj/p,x11/8,ph/f,x6/14,s9,x9/7,pb/a,x14/13,s5,x3/7,s14,x14/15,pc/g,x6/10,s6,x14/7,pj/n,s6,x1/3,s1,x5/4,s5,x3/0,s3,x7/4,s6,x5/13,s7,x4/0,pb/i,x1/6,s1,pa/h,x10/3,s6,x11/12,pj/e,x13/5,pg/d,x3/0,po/k,x1/8,s5,x6/14,pn/h,x10/0,s8,x9/5,s6,x13/3,s8,x10/12,s9,x1/8,s3,x7/10,s3,x12/1,po/m,x15/6,s1,x11/13,s7,x3/9,ph/j,x6/10,pl/o,x15/1,pp/e,x2/0,pg/n,x3/6,ph/o,s3,x13/14,pi/b,x6/9,s8,x15/8,s12,pe/j,x10/12,pi/o,x11/9,s3,x7/10,s6,x1/4,s11,x10/3,pp/f,s9,x5/12,s7,x1/9,s14,x13/5,s5,x4/8,s11,x9/11,ph/j,x6/1,pc/p,x14/10,s9,x4/12,pl/a,x6/11,s10,x2/9,s13,x3/14,s13,x5/0,s3,x12/11,pp/m,x0/10,s15,pk/d,x11/7,pp/o,x14/6,s6,x13/15,s15,x9/7,s5,x11/6,pn/h,x8/3,pe/i,s14,x7/4,s13,x3/6,s2,x8/7,ph/a,x5/14,pp/c,x1/7,pd/l,s14,pa/p,x3/10,s7,x4/6,s3,ph/o,x1/2,s14,x14/4,s10,pd/b,x15/6,pc/a,x7/4,s7,x5/2,s5,x4/0,s8,pb/p,x10/3,s4,x15/9,pe/c,x2/4,s15,x7/11,s8,x10/12,s2,x9/7,s14,pd/p,x0/5,pk/o,x11/2,s11,x10/9,pi/c,x12/4,s9,x0/11,pj/d,x5/4,s9,x0/9,s8,x3/2,s14,x5/11,po/g,x8/1,pl/i,x12/13,s14,x11/7,s14,x14/9,s11,x13/8,s2,pa/g,x14/12,pp/o,s15,x2/15,pf/c,x10/5,pd/o,x11/7,s6,x14/3,pf/h,x11/2,s9,x13/12,s8,x4/11,s7,x5/14,s4,pi/n,s3,x10/13,s3,x9/8,s2,po/h,x14/12,pb/k,x15/4,pm/h,s7,pg/k,s14,x3/2,s4,x10/13,ph/f,s2,pk/e,x7/12,s10,x13/8,pc/b,x11/2,s4,x7/5,s9,x1/9,pe/n,x5/12,s2,po/m,x6/8,s12,x1/0,s8,x15/2,s13,x5/0,pe/j,x12/3,s8,x8/6,s14,pb/d,s4,x10/7,s10,x1/12,pm/i,x14/5,s1,x0/6,s4,x5/4,pb/o,x3/8,ph/j,x12/9,pb/g,x6/8,s4,x0/9,s9,x6/14,s7,ph/n,x8/9,pj/a,s10,x5/1,s6,x0/3,s6,x10/4,s9,x2/1,s8,x4/3,s6,x15/7,s13,x9/0,pn/k,x8/11,s5,x2/3,s13,x15/1,s15,x14/2,s6,x15/10,s14,x1/7,s7,x6/10,s9,x1/4,pc/a,x10/9,pm/h,x1/6,pd/g,x3/11,s2,x10/4,s4,x8/2,s14,x11/3,s4,x4/9,pp/h,x6/12,s4,pn/g,x9/5,pc/d,x7/15,s3,x14/4,s13,x13/10,s8,x14/3,pi/f,x0/15,pd/l,x5/10,po/p,x6/12,ph/m,x15/13,pc/k,x12/1,s5,x2/10,s4,x3/15,pn/m,x9/14,s13,x7/11,pj/e,x12/6,pm/d,x2/15,pl/j,x4/7,s8,x6/10,s10,x13/5,s1,x8/3,pf/d,x2/1,s3,x7/4,s15,pm/e,x8/0,pd/i,x13/10,s4,pc/b,x6/14,s15,x13/4,s2,x12/3,s11,x10/1,s5,x14/15,pj/o,x0/2,pl/p,x14/8,s8,x4/3,pn/m,x7/0,s14,x9/4,s13,x11/3,pb/j,x9/4,s1,x7/3,s15,x0/1,pk/f,x7/8,pc/i,x9/15,s10,x13/4,s12,x9/7,s5,x13/1,po/b,x12/15,s15,x5/2,pj/g,x1/0,pe/o,x6/4,s11,x5/7,s7,x12/0,pm/i,x4/7,pf/c,x2/6,pm/n,x11/3,pi/d,x7/9,s15,x8/15,s5,x11/7,s6,x10/2,pb/p,x3/13,s4,x1/2,pk/n,s12,x11/5,pj/f,s15,x13/15,pg/n,x9/6,s13,x13/3,pj/e,x7/11,s2,x13/0,s13,x3/15,s14,x7/2,s3,x13/5,s1,x12/7,pi/g,x15/2,s5,pm/j,x0/1,s15,x5/8,pa/d,x11/9,s2,x10/14,s10,x9/12,s4,pg/f,x6/7,pd/k,x13/14,s9,pm/c,s10,x5/10,pn/i,x8/3,po/e,x4/9,s3,x11/14,pg/j,x0/10,s10,x14/6,s6,x11/7,pk/o,s5,x12/8,s9,ph/m,x5/15,s8,x3/12,s10,x1/9,s6,x15/11,s6,x0/5,s15,x4/1,s14,x14/15,s15,x13/6,pd/o,x8/11,s1,x15/5,pg/a,x4/14,pi/e,x10/6,pm/c,s12,x1/14,po/b,x6/3,s12,x13/4,pe/n,x0/14,s8,x7/2,pj/g,s13,x10/3,pn/m,x15/11,pb/f,x10/5,s5,x8/11,pi/d,x3/5,s4,pg/o,x12/8,pa/m,x3/1,s2,x11/8,s11,x13/5,s11,x4/6,pe/d,x15/3,s10,x14/1,s10,x9/2,s6,x8/7,pf/o,x14/11,s2,pa/j,x0/5,pb/e,x12/13,ph/g,x8/1,s8,x2/3,s7,x10/14,s9,x4/15,pn/i,x1/14,s2,x4/3,pd/e,x15/5,pm/p,x0/13,s12,x3/11,po/l,x5/9,s4,pp/e,x8/13,s11,x15/14,pm/l,x3/5,s15,x8/15,s13,x2/3,s10,x4/12,s11,x7/0,s14,x4/5,s2,x13/11,pk/p,x0/10,s8,x4/7,s14,x9/8,pi/f,s4,x15/1,s10,x7/3,pe/h,x0/10,s14,x2/7,s2,x5/14,s5,x10/4,s1,x15/5,pb/c,x11/13,s14,x5/6,pn/h,s6,x9/14,pf/o,x10/7,pl/n,x13/6,s14,x0/3,s15,x7/6,s9,x3/8,s7,pg/c,x10/0,s5,pk/m,x6/15,s11,x13/14,s1,x7/15,pa/l,x1/14,po/k,x11/3,pn/b,x13/4,s2,x14/7,s5,x8/9,pp/c,s7,pj/o,x7/3,s12,ph/i,x9/1,pg/j,s15,x13/7,s4,x8/5,ph/d,x7/6,pj/b,x3/8,pc/f,s7,x14/11,s9,x13/9,s12,pa/e,x7/3,pp/l,x0/13,s3,x8/6,s5,x12/1,s5,x4/0,pc/d,x5/15,s14,x10/1,pm/f,s15,x8/0,s9,x15/14,s3,pd/h,x2/10,pa/b,x13/8,pj/k,s8,x0/11,s2,pb/a,x14/1,s13,x0/6,s8,x13/4,pm/p,s15,x3/5,pi/n,x12/4,s1,x5/14,pf/j,x10/8,pg/o,s5,x13/3,pi/h,s9,x14/12,pp/e,x0/4,pg/o,x3/1,s8,x4/14,s15,x9/11,pc/k,x4/5,s2,x6/1,s6,x7/2,pn/j,x14/1,s8,x0/10,s12,x5/11,s14,x3/13,pd/m,x5/10,s14,x3/0,pl/a,x12/7,s10,x8/0,s14,x12/5,s11,x11/7,pe/k,x2/12,pp/d,s8,pf/l,x7/10,pa/o,x2/14,pf/e,x11/13,po/c,x0/8,pl/g,x11/15,s5,x4/3,pi/f,x10/14,s6,x5/9,s11,x14/11,s12,x4/8,pm/c,x10/15,pa/o,x7/9,pj/d,x10/5,pc/f,x4/2,s1,x1/5,s10,x12/7,s13,x2/1,s15,x5/7,s10,x0/12,s8,x2/11,s3,pa/b,x5/15,pp/k,x2/10,s3,x11/7,pd/o,s13,x6/3,pl/a,x13/2,s4,x4/14,pg/o,x3/13,s1,x6/5,pa/d,x10/7,s9,x12/9,pf/k,s11,x14/1,s10,x15/0,s1,pd/a,x12/7,s3,x0/11,pf/o,x7/6,s15,x1/0,pd/l,x11/8,s11,x5/9,s14,pk/h,x3/7,s9,pe/n,x6/14,s3,x7/0,pd/k,x3/8,pn/o,x1/14,pg/d,x9/3,s14,x8/12,s15,x11/1,s6,x13/0,s5,pi/a,x12/2,pg/k,x4/10,pp/j,s14,x5/8,s10,x3/10,s11,x13/6,pi/a,x0/2,s5,x15/3,pb/m,s3,x13/1,pn/k,x4/8,s9,x7/1,ph/g,x6/0,s3,x4/15,s12,x2/9,s1,x7/3,s6,pn/k,x2/11,s15,x9/6,pd/i,x2/7,pe/a,x14/9,s9,x11/12,s7,pi/j,x2/1,s14,x12/8,ph/l,x13/6,s3,x15/11,po/m,s6,x2/8,s2,x13/0,s6,x8/15,s11,x1/13,s1,x5/2,s1,pc/k,x3/6,pn/a,x14/5,po/g,x4/2,s1,x10/5,s7,x15/6,pk/c,x9/12,po/b,x7/6,s7,pi/e,x13/10,pm/a,s8,x7/4,s7,x8/3,s13,x6/9,s11,x3/2,pe/b,x9/0,pf/p,x8/1,s8,x3/14,s4,x11/12,ph/j,x3/10,s7,x11/4,s15,x12/6,s9,x3/9,pm/i,x11/12,pj/n,x3/8,po/b,x6/10,pn/i,x5/8,s9,x13/12,po/l,x6/10,pp/e,s14,x12/4,pb/h,x0/11,pe/c,x7/14,pk/i,x11/15,pn/f,s8,x12/13,pk/o,x8/14,pn/p,x9/11,s10,x13/10,pg/b,x1/11,pc/d,s10,x7/9,s8,x13/4,pl/k,x1/15,s6,x13/5,po/c,x0/8,s9,x13/14,s12,x9/11,ph/l,x2/14,pi/m,x12/9,pp/n,x6/5,pf/i,x12/9,s4,x8/2,s11,x12/14,pg/n,x4/7,s13,x2/1,s1,x9/12,po/l,x3/4,s7,x8/1,s6,x5/4,s13,x11/12,pe/f,x7/14,s6,pj/m,x0/4,s5,x10/1,pc/k,x11/2,s8,x4/8,pi/m,s8,x10/12,pf/h,s14,x14/0,pi/a,x7/6,s14,x0/14,pp/n,x6/10,pl/d,x3/12,s3,x4/5,pa/i,s8,x9/1,s1,x11/7,s11,x12/8,s12,x7/13,s13,x1/5,s7,x4/8,pj/g,x14/1,pa/d,x5/12,pg/j,x8/9,pb/i,x11/1,s5,x5/13,s11,x15/0,pg/c,x8/11,pp/o,x13/0,pl/b,x7/12,pp/k,x3/15,pc/l,s4,x7/12,s11,x15/10,pb/g,x7/12,s6,x10/11,pa/o,x12/13,s3,x15/5,s3,x0/12,pd/m,x9/5,s1,x14/10,s8,x1/6,ph/o,s15,x12/13,pb/e,s6,x11/14,s6,x2/10,s6,x0/1,s13,x14/15,s5,x7/10,s1,x12/13,pf/i,x8/2,pl/h,x11/15,s10,x10/3,s1,x6/9,s1,x10/7,s1,x12/13,s6,x7/9,pd/p,x13/10,pj/b,x7/6,s15,x8/13,s3,x3/11,pd/g,x5/12,s2,x2/7,pf/p,x6/3,s7,x4/7,s7,x13/12,s13,x8/7,pd/l,x12/6,pc/i,x11/9,s4,pa/h,x8/15,s12,x10/6,pf/g,x4/5,pm/j,x13/11,ph/f,x9/6,pa/c,s8,x5/7,s11,x4/10,pn/d,x11/14,s5,x3/13,po/a,x2/5,pb/j,x3/15,pn/e,x8/0,s10,x1/11,s7,x15/4,s13,x13/1,s7,x9/3,s1,pb/c,x1/14,pp/h,s7,x12/0,pm/d,s2,x9/7,pn/g,x15/3,s4,x10/7,pe/m,s7,x4/12,s8,x0/10,s7,x8/12,pc/o,x2/1,s11,x5/3,s8,x8/1,s12,x4/11,s6,x8/2,s3,x12/4,pl/n,x7/3,s14,x14/0,pi/e,x5/13,pb/d,x15/1,s8,x9/4,s4,x2/10,pe/n,x13/9,pp/g,x2/10,s9,x0/7,s4,x2/8,s2,x3/0,s8,pb/m,x12/6,ph/p,x8/5,pb/a,x6/3,po/l,x13/7,pj/k,x10/14,pf/g,x9/2,pa/b,s8,x14/15,s4,x6/10,pg/j,x12/15,pf/h,x11/7,s5,x5/3,pc/i,x11/12,pa/l,x2/8,s8,x3/13,pp/f,x15/11,s11,x12/8,po/g,x13/15,s13,x6/11,s6,x0/13,pa/d,x8/6,s7,x10/9,pe/n,x8/12,s6,x7/10,pm/a,s9,x14/12,s5,x3/2,s5,x0/10,pj/g,x4/9,s8,x0/12,s8,x8/14,pf/k,x3/11,s5,x15/0,ph/a,x14/13,pn/o,x15/3,s8,x0/14,pj/g,s7,pc/d,x10/9,s1,x11/4,s6,x2/3,s2,x13/15,s12,x14/3,s10,x0/11,pm/g,x10/15,s4,x13/7,ph/l,x2/10,s10,x0/14,s10,x15/10,s14,x5/3,s7,x10/13,pg/p,x4/6,s9,x1/12,s8,x0/15,s1,x9/6,s5,x3/4,s9,x13/14,ph/n,s3,x10/3,pg/f,x12/7,s6,pk/m,x1/15,pe/d,x8/3,pa/c,s11,x10/1,pm/i,x4/0,po/h,x13/10,s15,x9/11,s9,x13/1,s14,x14/7,pa/k,x0/11,s10,x4/13,s10,x14/11,s2,x4/10,ph/m,x1/13,s2,x4/6,s15,x13/12,pc/p,x15/2,pn/e,x0/7,s15,x13/12,pd/c,x4/10,pi/g,x14/15,s1,x1/11,pm/b,x13/4,s3,x7/0,pe/f,x8/6,pg/a,s4,x1/12,s7,x10/2,s3,x7/9,s2,x13/10,s4,x11/3,s6,pm/d,x14/9,s9,x1/5,ph/e,s13,pb/d,s10,x13/14,s1,x7/8,pp/f,x2/15,pm/h,x5/6,s14,x4/12,s6,x1/7,s8,x4/11,s3,x2/14,s7,x11/1,s3,x7/10,s6,x0/9,s1,pd/a,x1/13,s3,x11/8,s12,x5/3,s15,x1/11,s3,x0/12,s14,x6/9,s3,x3/10,s15,x13/2,pj/g,x10/9,pf/c,x3/15,s5,x1/14,pd/e,x4/13,s6,x1/5,pn/a,x6/11,pe/h,x4/7,pd/p,x11/6,pe/i,x0/15,s10,x10/6,pk/b,s1,x8/15,pd/n,x2/12,pj/m,s1,x9/5,s3,x0/11,s9,x4/2,pa/i,x12/9,s1,x2/8,pf/b,x12/15,s8,x6/4,s7,x9/14,ph/a,x10/2,s5,x12/3,s12,x15/6,s11,x0/12,pd/j,s7,x11/8,pm/o,x9/14,pc/k,x4/10,s10,x11/2,s4,x15/4,s12,x11/10,s14,x9/13,po/e,s14,x14/11,pj/l,x0/9,s6,x4/10,s1,x0/7,s2,x1/13,pp/n,s15,x11/12,pc/e,x1/8,po/d,x11/2,s4,x7/13,ph/b,x12/9,s8,x7/6,s15,pg/d,x12/3,pn/h,s8,x4/6,s9,pc/a,x10/13,s5,x4/8,s4,x12/13,ph/o,x4/5,pn/b,x14/8,s14,x1/12,s1,x10/4,s1,x5/6,pk/i,x14/3,pc/g,x12/4,pm/a,x10/1,s7,x14/13,pf/c,s1,x2/12,s9,x11/4,pa/e,x15/1,pi/o,s13,x8/3,pm/f,x1/2,pc/d,x10/14,s11,x7/13,s9,pp/b,s11,x12/0,s4,x9/5,s6,pa/g,x13/3,s11,x6/14,pe/k,x1/10,pc/g,x8/4,s5,x0/7,s8,x12/3,s2,x13/14,s15,pl/k,x0/5,s9,x2/3,ph/i,x8/15,s7,x7/11,pa/l,x10/1,s3,pf/i,s14,x0/13,s13,x9/3,s8,pd/h,x0/11,s7,x6/2,pa/f,x10/4,s7,x2/3,s7,x11/8,s15,pp/n,s2,x13/3,s15,pf/h,s13,x5/11,s9,x8/13,s8,x10/9,pi/m,x12/14,pe/f,x6/13,s1,x1/9,s7,x3/15,pc/l,s1,x7/9,s10,x3/2,s5,x8/11,s10,x10/5,pd/g,x3/8,s9,x13/0,s4,x10/6,s2,x15/4,pp/i,x8/9,s5,x13/0,pf/h,x10/3,pl/o,x8/4,s7,x12/5,s15,x4/14,pi/k,s2,x3/5,s5,x8/2,s1,x7/4,pb/c,x0/15,pl/g,x2/4,pe/p,s1,x1/9,s5,pj/b,x2/7,s1,x12/11,s8,x7/14,s10,x11/10,pl/p,x5/9,s13,x14/6,s3,x4/10,s9,x14/6,s4,x5/15,s10,x7/6,s11,x14/3,pm/g,s3,x0/4,s13,x11/8,pc/b,x7/2,pg/a,x12/0,s15,x1/5,s7,x14/4,pd/m,x0/5,s11,x13/12,s9,pl/o,s2,x1/5,s11,x4/6,pn/i,x0/2,s2,x12/1,pj/e,x11/5,s5,x7/8,pb/g,x1/4,s10,x13/9,pd/i,x6/8,pc/f,x10/15,pn/m,x9/11,s4,pg/h,x6/7,s3,x14/2,pi/d,x9/11,pe/l,x12/4,s8,x2/9,pg/i,x10/15,s8,x14/11,s11,x9/2,s12,x14/13,pa/m,x8/3,s10,x9/15,s4,x11/4,s9,x7/14,pl/k,x9/12,pe/d,x10/7,pf/o,x12/4,pl/h,x14/9,s5,x5/1,s12,x15/11,pc/j,x0/3,pa/i,s6,x1/10,s13,x5/13,s7,x15/14,s4,x5/10,ph/d,x13/8,s14,x6/10,s10,x0/14,s15,x15/2,s13,x13/1,s8,x11/0,s4,x12/2,pn/e,x1/15,s4,pk/a,x0/6,po/m,x9/13,s2,x1/10,s2,x5/8,ph/j,x14/13,s9,x5/9,s11,pb/f,x1/12,s2,pe/n,x2/14,s1,x15/8,s15,x3/0,s13,x9/14,s5,pi/j,x0/6,s11,x13/2,pc/g,s3,x5/9,pn/e,x12/1,s4,x6/7,pf/p,x0/13,s13,x1/12,s10,x14/6,s9,x5/10,s3,x0/13,pj/m,x5/10,pc/a,x2/3,ph/p,x13/0,s12,x7/1,s5,po/n,x8/2,s3,x4/6,s15,x14/15,s7,x13/4,s5,x2/0,s9,x12/6,s15,x3/10,s5,x13/7,s6,x4/9,s2,x2/15,s6,x4/13,s6,x0/9,s10,x3/5,pb/g,x2/13,s8,x14/3,s15,x9/0,s13,x15/11,s15,x4/14,s5,x5/9,pf/k,x14/6,s2,x7/9,pj/o,x1/6,s5,pa/c,x8/3,pj/k,x9/12,pe/g,x6/3,s9,x0/4,s10,x11/12,s1,x6/2,s1,x3/7,s7,x11/14,s8,ph/m,x5/2,pi/k,x7/12,s5,x13/15,pm/b,x5/2,s13,x15/12,s8,x9/14,s6,x3/12,s6,x13/2,s5,x12/5,s5,x15/1,s2,x3/10,pa/f,s4,x9/12,s6,x8/5,pn/e,x2/1,pc/j,x12/14,s4,x0/2,s13,x13/8,po/f,x5/0,pl/g,x1/6,s1,x14/4,s12,x15/5,s1,x4/10,s4,x15/12,pe/j,x4/14,pm/c,x11/2,s13,x12/5,pl/n";

        public const string Day18 = @"set i 31
set a 1
mul p 17
jgz p p
mul a 2
add i -1
jgz i -2
add a -1
set i 127
set p 622
mul p 8505
mod p a
mul p 129749
add p 12345
mod p a
set b p
mod b 10000
snd b
add i -1
jgz i -9
jgz a 3
rcv b
jgz b -1
set f 0
set i 126
rcv a
rcv b
set p a
mul p -1
add p b
jgz p 4
snd a
set a b
jgz 1 3
snd b
set f 1
add i -1
jgz i -11
snd a
jgz f -16
jgz a -19";

        public const string Day19 = @"                                                                             |                                                                                                                           
             +-------+       +-------+   +-+                                 | +-------------------------------------------+                   +---------------+     +-+ +---------------------------+   
             |       |       |       |   | |                                 | |                                           |                   |               |     | | |                           |   
 +---------------------------+       |   | +---------------------------------|-|---------+   +-----------------------------------------------------------------|-----|-|-----+                       |   
 |           |       |               |   |                                   | |         |   |                             |                   |               |     | | |   |                       |   
 |           +-----------------------|---------------------------------------|-|---------|---|-----------------+           |                   |               | +---|-+ +-------------------------+ |   
 |                   |               |   |                                   | |         |   |                 |           |                   |               | |   |       |                     | |   
 |                   |         +-----|-+ |                 +-----------------|-+ +-------|---|-+               +---------------------------------------+       | |   | +-+   |     +-----+ +-+   +-|-|-+ 
 |                   |         |     | | |                 |                 |   |       |   | |                           |                   |       |       | |   | | |   |     |     | | |   | | | | 
 |           +---------------------------------------------+                 |   +-----------|-|-----------+               |                   |       |       | |   | | |   |     |     | | |   | | | | 
 |           |       |         |     | | |                                   |           |   | |           |               |                   |       |       | |   | | |   |     |     | | |   | | | | 
 |           | +-----|---------|-----|-|---------------+                     |           |   | |         +-|---------------|-----------+       |       |       | |   | | |   |   +-+     | | |   | | | | 
 |           | |     |         |     | | |             |                     |           |   | |         | |               |           |       |       |       | |   | | |   |   |       | | |   | | | | 
 |           | |     |         |     | | |             |                     |           | +----Q----------+               |           |       |       |       | |   | | |   |   |     +-|---+   | | | | 
 |           | |     |         |     | | |             |                     |           | | | |         |                 |           |       |       |       | |   | | |   |   |     | | |     | | | | 
 |           | |     |         |     | | |             | +---------------------------+   +-|---|---------|-------------------------------+     |     +---------|-|-----------|---|-----|---------|-+ | | 
 |           | |     |         |     | | |             | |                   |       |     | | |         |                 |           | |     |     | |       | |   | | |   |   |     | | |     |   | | 
 +-+ +-+     | |   +-----+     |     | +-|---------+   | |                   |       |     | | +-+       |                 |   +-------|-------------|-|---------|---|-|-----|---|-----|---|-----+   | | 
   | | |     | |   | |   |     |     |   |         |   | |                   |       |     | |   |       |                 |   |       | |     |     | |       | |   | | |   |   |     | | |         | | 
 +-----|-+   | |   | |   +-----|-------------+     |   | |                   |       |     | |   |       |       +-----+   |   |   +---|-------|-----|-|-----+ | | +-|-|-|-+ | +-|---+ | | |         | | 
 | | | | |   | |   | |         |     |   |   |     |   | |                   |       |     | |   |       |       |     |   |   |   |   | |     |     | |     | | | | | | | | | | |   | | | |         | | 
 | | | | |   | |   | |         |     |   |   |     |   | |         +-----------------------------|-------|-------------|---------------|-------|-----+ |     +---|-|-|-|-----|-|---+ | | | |         | | 
 | | | | |   | |   | |         |     |   |   |     |   | |         |         |       |     | |   |       |       |     |   |   |   |   | |     |       |       | | | | | | | | | | | | | | |         | | 
 | +-----|-----|---------------|-----|---|---|---------|-|-------------------|-------------|-|---------+ |       +-------------|---|---|-------|-------|-------+ | | +---|-----|-|-------|-|-------+ | | 
 |   | | |   | |   | |         |     |   |   |     |   | |         |         |       |     | |   |     | |             |   |   |   |   | |     |       |         | |   | | | | | | | | | | |       | | | 
 +-------|---|-|---+ |         +-+   |   +---------|---|-|---------|---------|---------------|---|-----|---------------------------|---|-------|-------|-------------+ | | | | | | | | | | |       | | | 
     | | |   | |     |           |   |       |     |   | |         |         |       |     | |   |     | |             |   |   |   |   | |     |       |         | | | | | | | | | | | | | |       | | | 
   +-|---------|-----|-------+   |   |       |     |   | |   +---------------|-------------|-----|-------|-------------|---|-----------|-|-----|---------------------|-|-|-------------|-+ |       | | | 
   | | | |   | |     |       |   |   |       |     |   | |   |     |         |       |     | |   |     | |             |   |   |   |   | |     |       |         | | | | | | | | | | | |   |       | | | 
 +-+ | +-|---------+ |       |   |   |       |     |   | |   |     |         | +-----------|-----------|-|-+     +---------|---|---|---|-|---------------------------------|-|---|---|---+ |       | | | 
 |   |   |   | |   | |       |   |   |       |     |   | |   |     |         | |     |     | |   |     | | |     |     |   |   |   |   | |     |       |         | | | | | | | | | | | | | |       | | | 
 |   +-------------|-|-----------|-----------------|-----|---------|-----------|-------------|---|-----|-+ |     |     |   |   |   |   +-|-------------|---------------------|-|-+ | | | | |       | | | 
 |       |   | |   | |       |   |   |       |     |   | |   |     |         | |     |     | |   |     |   |     |     |   |   |   |     |     |       |         | | | | | | | |   | | | | |       | | | 
 +-------+   | |   | |       |   |   |       |     +---|---+ | +-------------|-|-----------|-+   |     |   +-----|-----|-+ |   |   +-----|-----|-------|---------+ | | | | | | |   | | | | |       | | | 
             | |   | |       |   |   |       |         | | | | |   |         | |     |     |     |     |         |     | | |   |         |     |       |           | | | | | | |   | | | | |       | | | 
 +-------------------------------|---|-------|---------|-|-|-------|-----------------|-----|---+ |     |   +---------------|---|---------|-----|---------------------+ | | | | |   | | | | |       | | | 
 |           | |   | |       |   |   |       |         | | | | |   |         | |     |     |   | |     |   |     |     | | |   |         |     |       |           |   | | | | |   | | | | |       | | | 
 |           | |   | |       | +-|-----------|---------|---|-------|---------|-------------|---------------|-----|---------|---|-------------------------------+   | +-|-|---|-|---+ | | | |       | | | 
 |           | |   | |       | | |   |       |         | | | | |   |         | |     |     |   | |     |   |     |     | | |   |         |     |       |       |   | | | | | | |     | | | |       | | | 
 |           | |   | |       | | | +-|-------|-----------|-|-|-|---|---------|-|---------------|-------|-------------------|-------------|-------------+       |   | | | | | | |     | | | |       | | | 
 |           | |   | |       | | | | |       |         | | | | |   |         | |     |     |   | |     |   |     |     | | |   |         |     |               |   | | | | | | |     | | | |       | | | 
 |           | |   | |       | | +-|-------------------|-|---|-----|-----------|-----|---------|-----------------|-------|-|---|---------|-----|-------------------|-+ | | | | |     | | | |       | | | 
 |           | |   | |       | |   | |       |         | | | | |   |         | |     |     |   | |     |   |     |     | | |   |         |     |               |   |   | | | | |     | | | |       | | | 
 |       +---|-|-----|-------|-------|-----------------------|-|---|---------|-----+ |     |   | |     |   +-+   |     | | |   |       +-|-----|---+           |   |   | | | | |     | +-|-------+ | | | 
 |       |   | |   | |       | |   | |       |         | | | | |   |         | |   | |     |   | |     |     |   |     | | |   |       | |     |   |           |   |   | | | | |     |   | |     | | | | 
 |       |   | |   | |       | |   | |       |         | | | | |   |         | |   | |     |   | | +---|---------|-----|-------|---------|---------|-----+     |   |   | | | | +---+ | +-----+   | | | | 
 |       |   | |   | |       | |   | |       |         | | | | |   |         | |   | |     |   | | |   |     |   |     | | |   |       | |     |   |     |     |   |   | | | |     | | | | | |   | | | | 
 |       |   | |   | |       | | +-|---------------------|---|-|---|-----------|---|-------|-----|-----|-----|-----------|-|---|---------|---------------|-+   |   |   | | | | +-+ | | | | | +-+ | | | | 
 |       |   | |   | |       | | | | |       |         | | | | |   |         | |   | |     |   | | |   |     |   |     | | |   |       | |     |   |     | |   |   N   | | | | | | | | | | |   | | | | | 
 |       | +-|-----|-|-------|-|-|---+       |         | | | | |   |         | |   | |     |   | | |   |     |   +-----|---|---|-----+ | |     |   |     | | +-|---|---|-------+ A | | | | | +---|-+ | | 
 |       | | | |   | |       | | | |         |         | | | | X   |         | |   | |     |   | | |   |     |         | | |   |     | | |     |   |     | | | |   |   | | | |     | | | | | | | |   | | 
 |       | | | |   | |       +-|-----------------------|-------|-------------|-|-----|-----|-----|---------------------|---|---------|---|-----------------|-|-----+   | | | |     | | +-----+ | |   | | 
 |       | | | |   | |         | | |         |         | | | | |   |         | |   | |     |   | | |   |     |         | | |   |     | | |     |   |     | | | |       | | | |     | |   | |   | |   | | 
 |       | | | |   | |         +-------------|---------|-|---|-|---|---------------|-|-----|---|-------------------------|-|-----------|-|---------------|-|-------------|-|-------|-+   | |   | |   | | 
 |       | | | |   | |           | |         |         | | | | |   |         | |   | |     |   | | |   |     |         | | |   |     | | |     |   Y     | | | |       | | | |     |     | |   | |   | | 
 +-------|-----|---+ |     +-----|-|-------+ |         | | | | |   |   +-----------|-|-------------|-------------+ +-------|---------|-------------|---------|---------+ | | | +-+ |     | +---|-|-----+ 
         | | | |     |     |     | |       | |         | | | | |   |   |     | |   | |     |   | | |   |     |   | |   | | |   |     | | |     |   |     | | | |         | | | | | |     |     | |   |   
         | | | |     |     |     | |       | |         | +---|---------|-----|-----|-------|-------|---------------|-----+ |   |     | | |     |   |     | | | | +---+ +-----|-+ | +-----------|-+   |   
         | | | |     |     |     | |       | |         |   | | |   |   |     | |   | |     |   | | |   |     |   | |   |   |   |     | | |     |   |     | | | | |   | | | | |   |       |     |     |   
         +-|---|-----+     |     | |       | | +-------|-----+ |   |   |     | |   | |     |   | | |   |     |   | |   | +-|---------|-|-------|---|---------|-+ | +-------|-----|-+     |     |     |   
           | | |           |     | |       | | |       |   |   |   |   |     | |   | |     |   | | |   |     |   | |   | | |   |     | | |     |   |     | | |   | | | | | | |   | |     |     |     |   
           | | | +---+     |     | |       | +-+       |   |   |   |   |     | +-----------|-----|-----------|-------+ | | |   |     | | |     |   |     | | |   | | +-----|-|-----|-------+   |     |   
           | | | |   |     |     | |       |           |   |   |   |   |     |     | |     |   | | |   |     |   | | | | | |   |     | | |     |   |     | | |   | |   | | | |   | |     | |   |     |   
           | | | |   |     |     | |       |           |   |   |   |   |     +-------|-----|---|-|-|-------------|-|-|-------+ | +---|-|-|---------|-------+ +-+ | | +-|-|---|-+ | |     | |   |     |   
           | | | |   |     |     | |       |           |   |   |   |   |           | |     |   | | |   |     |   | | | | | | | | |   | | |     |   |     |     | | | | | | | | | | |     | |   |     |   
     +-----+ | | +---------|-----+ |       |           +-------|-+ |   |           | |     |   | | |   |   +---------|-|---|-|-------|---|-----|---|-------+ +-----|-----+ | | | +-|-----|-+   |     |   
     |       | |     |     |       |       |               |   | | |   |           | |     |   | | |   |   | |   | | | | | | | | |   | | |     |   |     | | | | | | | |   | | |   |     |     |     |   
     |       | |     +-------------|-------|---------------|-----|-----|-----------|-------|---|---|---|-----|-----|-----|---|-|-|---|-|-|-----|---------|-|-|-|-|-|-|-|---|-|---+ +-----|-----+     |   
     |       | |           |       |       |               |   | | |   |           | |     |   | | |   |   | |   | | | | | | | | |   | | |     |   |     | | | | | | | |   | | | |       |           |   
     |       | |           |   +---|-------|-------------------+ | |   |           | |     |   | | |   |   | |   | | | | | | | | |   | | |     | +-|-----------+ | | | |   | | | | +-------------+   |   
     |       | |           |   |   |       |               |     | |   |           | |     |   | | |   |   | |   | | | | | | | | |   | | |     | | |     | | |   | | | |   | | | | |     |       |   |   
     +---------|---------------|---|-------|---------------|-------|-----+         | | +---|---|-|-|---|-----|---|-|-----|---|---|---|-|-----------|-----|---|---|-+ | |   | | | | |     |     +-|-+ |   
             | |           |   |   |       |               |     | |   | |         | | |   |   | | |   |   | |   | | | | | | | | |   | | |     | | |     | | |   |   | |   | | | | |     |     | | | |   
             | |           |   | +-|-------|---------------------|-----------------|-|-----|-----------------|-----|---|-|-|---|---------------|-+ |     | | |   |   | |   | | | | |     |     | | | |   
             | |           |   | | |       |               |     | |   | |         | | |   |   | | |   |   | |   | | | | | | | | |   | | |     |   |     | | |   |   | |   | | | | |     |     | | | |   
             | |   +-------|-----|---------|---------------|-------|---|-|-----------|-|---|-----+ |   |   | |   | | | | | | | | |   | | |     |   |     | | |   |   | |   | | | | |     |     | | | |   
             | |   |       |   | | |       |               |     | |   | |         | | |   |   |   |   |   | |   | | | | | | | | |   | | |     |   |     | | |   |   | |   | | | | |     |     | | | |   
             | | +-|-------|---|-|-|-----+ |               +-----|-------------------+ |   |   |   |   |   +-|-----|-------+ | | |   | | |     |   |     | | |   |   | |   | | | | |     | +-+ | | +-|-+ 
             | | | |       |   | | |     | |                     | |   | |         |   |   |   |   |   |     |   | | | | |   | | |   | | |     |   |     | | |   |   | |   | | | | |     | | | | |   | | 
             | | | +-----------|---|-------|-+                   | |   | |         |   |   |   |   |   |     |   | | | | |   | | +---|---+     |   |     | | |   |   | |   | | | | |     | | | | |   | | 
             | | |         |   | | |     | | |                   | |   | |         |   |   |   |   |   |     |   | | | | |   | |     | |       |   |     | | |   |   | |   | | | | |     | | | | |   | | 
             | | |   +-----|---|---|-----|-|---------------------|-|-----------------------------------|-----|---|-|---|-|-----|-----|-|-------|---|---------|---|---|-------|-|-----------|-|-|-|---|-+ 
             | | |   |     |   | | |     | | |                   | |   | |         |   |   |   |   |   |     |   | | | | |   | |     | |       |   |     | | |   |   | |   | | | | |     | | | | |   |   
 +-------------|---------------|---|-----|-|-------------------+ | |   | |         |   |   |   |   |   |     |   | | +-|-|-----|-+   | |       |   |     | | |   |   | |   | | | | |     | | | | |   |   
 |           | | |   |     |   | | |     | | |                 | | |   | |         |   |   |   |   |   |     |   | |   | |   | | |   | |       |   |     | | |   |   | |   | | | | |     | | | | |   |   
 |           | | |   |     |   | | |     | | | +-------+       | | |   | |         |   |   | +-|-------------|---------|-|---|-|-----|-|-----------|-----|-|-------+ | +---------+ | +-------|-|---+ |   
 |           | | |   |     |   | | |     | | | |       |       | | |   | |         |   |   | | |   |   |     |   | |   | |   | | |   | |       |   |     | | |   | | |     | | |   | |   | | | | | | |   
 |           | | |   |     |   | | |     | | | |       |       | | |   | |         |   |   | | |   |   |     |   | |   +-|---|---+   | |       |   |     | | |   | | |     | | |   | |   | | | | | | |   
 |           | | |   |     |   | | |     | | | |       |       | | |   | |         |   |   | | |   |   |     |   | |     |   | |     | |       |   |     | | |   R | |     | | |   | |   | | | | | | |   
 |           | | |   |     |   | +-|-----|---+ |       |       | | |   | |         |   |   | | | +-----|---------|-------|---|-----+ | |       |   |     | | |   | | |     | | |   | |   +-|-|-+ | | |   
 |           | | |   |     |   |   |     | |   |       |       | | |   | |         |   |   | | | | |   |     |   | |     |   | |   | | |       |   |     | | |   | | |     | | |   | |     | |   | | |   
 |           | | |   |     |   |   |     | |   |       |       | | |   | |         |   |   | | | | |   |     |   | |     |   | |   | | |       |   |     | | +---+ | |     | | |   | |     | |   | | |   
 |           | | |   |     |   |   |     | |   |       |       | | |   | |         |   |   | | | | |   |     |   | |     |   | |   | | |       |   |     | |       | |     | | |   | |     | |   | | |   
 |           | | |   |     |   |   |     | |   |       |       | | |   | |         |   |   | | | | |   |     |   | |     |   | |   | | |       |   |     | |       | |     | | |   | |     | |   | | |   
 |           | | |   |     |   |   |     | |   |       |       | | |   | |         |   |   | | | | |   |     |   | |     |   | |   | | |       |   |     | |       | |     | | |   | |     | |   | | |   
 |           | | | +-|---------------------|-------------------|-------|-|---------|---|---|---|-------------|---|-|---------|-------|---------|---------|-|-------|-|-------|-------|-----|-+   | | |   
 |           | | | | |     |   |   |     | |   |       |       | | |   | |         |   |   | | | | |   |     |   | |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 |           | | | | |     |   |   |     | |   |       |       | | |   | |         |   |   | | | | |   |     |   | |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 |           | | | | |     |   |   |     | |   |       |       | | |   | |         |   |   | | | | |   |     |   | |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 |           | | | | |     |   |   |     | |   |       |       | | |   | |         |   |   | | | | |   |     |   | |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 |           | | | | |     |   |   |     | |   |       |       | | |   | |         |   |   | | | | |   |     |   | |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 |           | | | | |     |   |   | +---------------------------+ |   | |         |   |   | | | | |   |     |   | |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 |           | | | | |     |   |   | |   | |   J       |       |   |   | |         |   |   | | | | |   |     |   | |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 |           | | | | |     |   |   | |   | |   |       |       |   |   | |         |   |   | | +-|-|---------|---+ |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 |           | | | | |     |   |   | |   | |   |       |       |   |   | |         |   |   | |   | |   |     |     |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 |         +-----|-|-|-----|-------|-|---|-|-----------+       |   |   | |         |   |   | |   | |   |     |     |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 |         | | | | | |     |   |   | |   | |   |               |   |   | |         |   |   | |   | |   |     |     |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 |         | | | | | |     |   |   | |   | |   |               |   |   | |   +-------------|-------|---|---+ |     |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 |         | | | | | |     |   |   | |   | |   |               |   |   | |   |     |   |   | |   | |   |   | |     |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 | +-------|-----|-+ |     |   |   | |   | |   |               |   |   | |   |     |   |   | |   | |   |   | |     |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 | |       | | | |   |     |   |   | |   | |   |               |   |   | |   |     |   |   | |   | |   |   | |     |     |   | |   | | |       |   |     | |       | |     | | |   | |     |     | | |   
 | |     +---|-|-----|-----+   |   | |   | |   |     +---------|---------|---|-----|---|---|-------|---|---|-------|---------|-------|-|-------|-----------|-------|---+   | | |   | |   +---------+ |   
 | |     | | | | |   |         |   | |   | |   |     |         |   |   | |   |     |   |   | |   | |   |   | |     |     |   | |   | | |       |   |     | |       | | |   | | |   | |   | |     |   |   
 | +---------|---|-------------|---------|-|---|---------------|---|---|-----|-+   |   +-----|---|-|---|---|-------|-----|---------|---|-------|---|-------|-------|-|-------|---+ | |   | |     |   +-+ 
 |       | | | | |   |         |   | |   | |   |     |         |   |   | |   | |   |       | |   | |   |   | |     |     |   | |   | | |       |   |     | |       | | |   | | | | | |   | |     |     | 
 | +-----|-+ | | | +-|-----+   |   | |   | |   |     |         |   |   | |   | |   |       | |   | |   |   | |     |     |   | |   | | |       |   |     | |       | | |   | | | | | |   | |     |     | 
 | |     |   | | | | C     |   |   | |   | |   |     |         |   |   | |   | |   |       | |   | |   |   | |     |     |   | |   | | |       |   |     | |       | | |   | | | | | |   | |     |     | 
 | |     | +---|-+ +-------|---|---------|-|---------|-------------------|---|-----|-------|-------|---|---|-|-----|-----|-----|---|-|-|-------|---------------------|-----|-----|-+ |   | |     |     | 
 | |     | | | |     |     |   |   | |   | |   |     |         |   |   | |   | |   |       | |   | |   |   | |     |     |   | |   | | |       |   |     | |       | | |   | | | |   |   | |     |     | 
 | +-----|-|-|-|---+ |     |   |   | |   | |   |     |       +-|-------|-----|-|-------------|---------|---|-|-----|---------------|---------------------+ |       | | |   | | | |   |   | |     |     | 
 |       | | | |   | |     |   |   | |   | |   |     |       | |   |   | |   | |   |       | |   | |   |   | |     |     |   | |   | | |       |   |       |       | | |   | | | |   |   | |     |     | 
 | +-------|-----+ +-|-----|---|-----|---|-----|-----|---------|---|---|-|-------------------|---|---------+ |     |     |   | |   | | |       |   |       |       | | |   | | | |   |   | |     |     | 
 | |     | | | | |   |     |   |   | |   | |   |     |       | |   |   | |   | |   |       | |   | |   |     |     |     |   | |   | | |       |   |       |       | | |   | | | |   |   | |     |     | 
 +-|-----------|-|-+ |     |   |   | |   | |   |     |       | |   |   | |   | |   |       | |   | |   |     |     |     |   | |   | | |       |   |       |       | | +---|-|-+ |   |   | |     |     | 
   |     | | | | | | |     |   |   | |   | |   |     |       | |   |   | |   | |   |       | |   | |   |     |     |     |   | |   | | |       |   |       |       | |     | |   |   |   | |     |     | 
   +-+   | | | | +-|-------|---|---|-----|-|---------|-------|-----------|-----|-------------------|---|-----|-----+     |   | |   | | |       |   |       |       | +-----|-|--D----|---|-+     |     | 
     |   | | | |   | |     |   |   | |   | |   |     |       | |   |   | |   | |   |       | |   | |   |     |           |   | |   | | |       |   |       |       |       | |   |   |   |       |     | 
     |   | | | |   | |     |   |   | |   | | +-|-------------|-|---|---|-------+   |       +-------|---|-----|-----------|-----|---------------|-+ |       |       |       | |   |   |   |       |     | 
     |   | | | |   | |     |   |   | |   | | | |     |       | |   |   | |   |     |         |   | |   |     |           |   | |   | | |       | | |       |       |       | |   |   |   |       |     | 
     |   | | | |   | |     |   |   | |   | | | |     |       | |   |   | |   |     | +-----------|-----|-----|---------------------|-------------|-|-------+       |       | |   |   |   |       |     | 
     |   | | | |   | |     |   |   | |   | | | |     |       | |   |   | |   |     | |       |   | |   |     |           |   | |   | | |       | | |               |       | |   |   |   |       |     | 
     |   | | | |   +-|---------|---|-|---|-+ | |     |       | |   +---|-|---|-------|-------|---|-|---|---------------------+ |   | | |       | +-------------------------|-|---+   |   |       |     | 
     |   | | | |     |     |   |   | |   |   | |     |       | |       | |   |     | |       |   | |   |     |           |     |   | | |       |   |               |       | |       |   |       |     | 
     |   | | | |     |     |   |   | |   |   | |     |       | |       | |   |     | |       |   | |   |     |           | +---|---|-------------------------------|-------------+   |   |       |     | 
     |   | | | |     |     |   |   | |   |   | |     |       | |       | |   |     | |       |   | |   |     |           | |   |   | | |       |   |               |       | |   |   |   |       |     | 
 +---+ +-+ +---------|---------------|---|-----------------+ | |       | |   |     | |       |   | |   |     |           | |   |   | | |       |   |               |       | +-------|-----------|-----+ 
 |     |     | |     |     |   |   | |   |   | |     |     | | |       | |   |     | |       |   | |   |     |           | |   |   | | |       |   |               |       |     |   |   |       |       
 |     |     +-|-----|-----|---|---|-|-------|-------------|-|---------|-------+   | |       |   | |   |     |           | |   |   | | |       |   |               |       |     |   |   |       +-----+ 
 |     |       |     |     |   |   | |   |   | |     |     | | |       | |   | |   | |       |   | |   |     |           | |   |   | | |       |   |               |       |     |   |   |             | 
 |     |       |     |     |   +---------------------|---------|-------------|-|-------------|---|-|-----------------------|---|---+ | |       |   |               |       |     |   |   |             | 
 |     |       |     |     |       | |   |   | |     |     | | |       | |   | |   | |       |   | |   |     |           | |   |     | |       |   |               |       |     |   |   |             | 
 |     |       |     |     |       | |   |   | |     |     | | |       | |   | |   | |       |   | |   |     |           | |   |     | |       |   |               |       |     |   |   |             | 
 |     |       |     |     |       | |   |   | |     |     | | |       | |   | |   | |       |   | |   |     |           | |   |     | |       |   |               |       |     |   |   |             | 
 |     |       | +---|-------------|-----|---|-|-----|-------------------|-----+   | |       |   | |   |     |           | |   |     | |       |   |               |       |     |   |   |             | 
 |     |       | |   |     |       | |   |   | |     |     | | |       | |   |     | |       |   | |   |     |           | |   |     | |       |   |               |       |     |   |   |             | 
 +-+   | +-+   | |   |     |       | |   |   | |     +-----|-------------|---|-----|-|-------|-----------------------------|---|-----|-|-------|---------------------------|-----|-------|-------------+ 
   |   | | |   | |   |     |       | |   |   | |           | | |       | |   |     | |       |   | |   |     |           | |   |     | |       |   |               |       |     |   |   |               
 +-----|-|-------|---------|---------|---|-------------------|-----------|-----------|-----------------------------------|-|---------|-|-------|-----------------+ |       |     |   |   |               
 | |   | | |   | |   |     |       | |   |   | |           | | |       | |   |     | |       |   | |   |     |           | |   |     | |       |   |             | |       |     |   |   |               
 | |   | | |   | |   |     |       | |   |   | +-----------|-|-----------|---|-----|-------------|-----|-----|---------+ | |   |     | |       |   |             | |       |     |   |   |               
 | |   | | |   | |   |     |       | |   |   |             | | |       | |   |     | |       |   | |   |     |         | | |   |     | |       |   |             | |       |     |   |   |               
 | |   | | +-+ | |   |     |       | |   |   |             | | |       | |   |     | |       |   | |   |     |         | | |   |     | |       |   |             | |       |     |   |   |               
 | |   | |   | | |   |     |       | |   |   |             | | |       | |   |     | |       |   | |   |     |         | | |   |     | |       |   |             | |       |     |   |   |               
 | |   | |   | | |   |     |       | |   |   |             | | |       | |   |     | |       |   | |   |     |         | | |   |     | |       |   |             | |       |     |   |   |               
 | |   | |   | | |   |     |       | |   |   |             | | |       | |   |     | |       |   | |   |     |         | | |   |     | |       |   |             | |       |     |   |   |               
 | |   | |   | | |   |     |       | |   |   |   +---------+ | |       | |   |     | |       |   | |   |     |         | | |   |     | |       |   |       +-----|---------------+   |   |               
 | |   | |   | | |   |     |       | |   |   |   |           | |       | |   |     | |       |   | |   |     |         | | |   |     | |       |   |       |     | |       |         |   |               
 | +---|-+ +-|-------------|-------------------+ |           | |       | |   |     | |       |   | |   |     |         | | |   |     | |       |   |       |     | |       |         |   |               
 |     |   | | | |   |     |       | |   |   | | |           | |       | |   |     | |       |   | |   |     |         | | |   |     | |       |   |       |     | |       |         |   |               
 | +---+ +-|---|-----+     |       | |   |   | | |           | +-----------------------------|-+ | |   |     |         | | |   +-----|-|-------|-+ |       |     | |       |         |   |               
 | |     | | | | |         |       | |   |   | | |           |         | |   |     | |       | | | |   |     |         | | |         | |       | | |       |     | |       |         |   |               
 | |     | | | | |         |       | +---|---|-|-------------|---------|-----------------------|-------|-----|-----------|-------------|-------|-|---------|-------|-------|---------+   |               
 | |     | | | | |         |       |     |   | | |           |         | |   |     | |       | | | |   |     |         | | |         | |       | | |       |     | |       |             |               
 | |     | | | | |         |       |     |   | | |           |         | |   |     | |       | | | |   |     |         | | |         | |       | | |       +-------|-------|-------+     |               
 | |     | | | | |         |       |     |   | | |           |         | |   |     | |       | | | |   |     |         | | |         | |       | | |             | |       |       |     |               
 | |     | | | | |         |       |     |   | | |           |         | |   |     | |       | | | |   |     |         +-|-|---------|-------------|-------------|---------------------------------+     
 | |     | | | | |         |       |     |   | | |           |         | |   |     | |       | | | |   |     |           | |         | |       | | |             | |       |       |     |         |     
 | |     | | | | |         |       |     |   | | |           |         | +---|-----|-|-------|---|-|---------|-----------|-|-----------+       | | +-------------------------------|-----+         |     
 | |     | | | | |         |       |     |   | | |           |         |     |     | |       | | | |   |     |           | |         |         | |               | |       |       |               |     
 | |     +---|-|-|---------------+ |     |   | | | +-------------------|-+   |     | |       | | | |   |     |           | |         |         | |               | |       |       |               |     
 | |       | | | |         |     | |     |   | | | |         |         | |   |     | |       | | | |   |     |           | |         |         | |               | |       |       |               |     
 +-+   +-+ | | | |         |     | |     |   | | | |         |         | |   |     | |       | +-+ |   |     +-------------+         |         | |               | |       |       |               |     
       | | | | | |         |     | |     |   | | | |         |         | |   |     | |       |     |   |                 |           |         | |               | |       |       |               |     
 +-------+ | +-|-|-+       |     | |     | +-----|-|---------|-----------|---------|-|-------|---------|-----------------------------|-----------+               | |       |       +---------------|---+ 
 |     |   |   | | |       |     | |     | | | | | |         |         | |   |     | |       |     |   |                 |           |         |                 | |       |                       |   | 
 |   +---------+ | |       |     +-|-------|-----|-----------|-----------|---|-------|-----+ |     |   |                 |           |         |                 | |       |                       |   | 
 |   | |   |     | |       |       |     | | | | | |         |         | |   |     | |     | |     |   |                 |           |         |                 | |       |                       |   | 
 |   | | +-|-----|-|---------------|-----|-|---|-----------------------|-----|-----+ |     +-|-----|---|-----------------|---------------------+                 | |       |                       |   | 
 |   | | | |     | |       |       |     | | | | | |         |         | |   |       |       |     |   |                 |           |                           | |       |                       |   | 
 |   | | | | +-------------+       |     +-|-+ | | |         |         | |   |       |       | +-------|-----------------|-----------+                           | |       |                       |   | 
 |   | | | | |   | |               |       |   | | |         |         | |   |       |       | |   |   |                 |                                       | |       |                       |   | 
 | +---|-|-+ |   | | +-------------|-------|---|---|-------------------+ |   +-----+ |       | +---|---------------------|---------------------------------------|-|-----------------------------------+ 
 | | | | |   |   | | |             |       |   | | |         |           |         | |       |     |   |                 |                                       | |       |                       |     
 +-|-------------|---+         +---|-------+ +---|-|---------------------|-----------|-------------|---|-----------------|---------------------------------------|-|-------|---------------------------+ 
   | | | |   |   | |           |   |         | | | |         |           |         | |       |     |   |                 |                                       | |       |                       |   | 
   | | | |   |   | |       +-------------+   | | | |         |           |         | |       +-----|---------------------|-----------------------------------------|-----------------------------------+ 
   | | | |   |   | |       |   |   |     |   | | | |         |           |         | |             |   |                 |                                       | |       |                       |     
   | | | +---|-----|----------F----|-----|---+ | | +-+       |           |         | |             |   |                 |   +-----------------------------------|-------------------------------------+ 
   | | |     |   | |       |   |   |     |     | |   |       |           |         | |             |   |                 |   |                                   | |       |                       |   | 
   | +-|-----|-----------------|-----------------------------|-----------------------|-------------|---------------------|---|---------------------+             | |       |                 +-+   | +-+ 
   |   |     |   | |       |   |   |     |     | |   |       |           |         | |             |   |                 |   |                     |             | |       |                 | |   | |   
   |   |     |   | |       |   |   +-----------|-|-----------|-----------|---------|-|-------------|---|---------------------|---------------------+             | |       |                 | |   | |   
   |   |     |   | |       |   |         |     | |   |       |           |         | |             |   |                 |   |                                   | |       |                 | |   | |   
   |   |     |   | |       +---|---------|-------+   |       |           |         | |             |   |                 +---------------------------------------|---------------------------+ |   | |   
   |   |     |   | |           |         |     |     |       |           |         | |             |   |                     |                                   | |       |                   |   | |   
   |   |     |   | +-----------+         |     +-+   |       |           +---------|-------------------|---------------------+         +---------------------------+       |                   |   | |   
   |   |     |   |                       |       |   |       |                     | |             |   |                               |                         |         |                   |   | |   
 +-+   |   +-----|-----------------------|-------|---|-------+                     +-+             +---|-------------------------------+                         |     +---+                   |   +-+   
 |     |   | |   |                       |       |   |                                                 |                                                         |     |                       |         
 +-----+   +-+   +-----------------------+       +---+                                                 +---------------------------------------------------------+     +-----------------------+         
                                                                                                                                                                                                         ";

        public const string Day20 = @"p=<-3787,-3683,3352>, v=<41,-25,-124>, a=<5,9,1>
p=<6815,2269,3786>, v=<-93,23,38>, a=<-8,-6,-10>
p=<-1586,-5016,3166>, v=<2,66,-70>, a=<3,6,-2>
p=<-2392,-397,3538>, v=<76,-19,-114>, a=<0,2,0>
p=<1669,1370,376>, v=<41,68,-28>, a=<-6,-7,1>
p=<-3601,3943,-6010>, v=<35,-79,-30>, a=<5,-3,14>
p=<1235,3943,-771>, v=<-57,-31,41>, a=<1,-6,-1>
p=<-1925,-314,1287>, v=<80,16,-73>, a=<1,0,1>
p=<3325,5104,720>, v=<-5,-55,-68>, a=<-14,-17,3>
p=<-1841,1744,615>, v=<76,61,-8>, a=<1,-13,-2>
p=<-3983,316,-78>, v=<90,-14,-63>, a=<9,0,6>
p=<4459,-902,279>, v=<-48,66,-14>, a=<-15,-2,0>
p=<7,673,-4068>, v=<21,68,171>, a=<-2,-9,2>
p=<289,-1454,-927>, v=<-50,154,6>, a=<4,-5,11>
p=<979,160,-1257>, v=<-23,-13,105>, a=<-9,0,0>
p=<1165,-494,-195>, v=<-97,22,-42>, a=<0,3,9>
p=<-785,574,183>, v=<72,-2,24>, a=<-1,-7,-6>
p=<2395,-194,549>, v=<-141,23,-78>, a=<-9,-1,5>
p=<-1535,1156,531>, v=<50,-57,-44>, a=<12,-6,0>
p=<-1391,-26,-213>, v=<77,9,18>, a=<6,-1,0>
p=<682,-573,391>, v=<-27,-65,6>, a=<-2,13,-4>
p=<1582,-423,3016>, v=<1,21,-153>, a=<-13,1,-6>
p=<-113,477,1471>, v=<42,-79,-10>, a=<-4,6,-11>
p=<6617,1504,5263>, v=<-48,-5,-1>, a=<-12,-3,-12>
p=<-4432,1997,-798>, v=<93,-22,13>, a=<4,-3,1>
p=<1832,-5601,9584>, v=<-168,0,-60>, a=<7,13,-18>
p=<585,4201,4335>, v=<-80,-38,-59>, a=<4,-7,-6>
p=<3601,-845,5466>, v=<-4,1,-8>, a=<-8,2,-12>
p=<411,3795,1145>, v=<91,6,-69>, a=<-7,-9,2>
p=<-3852,-6355,-421>, v=<118,71,0>, a=<1,10,1>
p=<2760,3186,-6946>, v=<-65,-93,135>, a=<-2,-1,7>
p=<-951,-1228,3140>, v=<-10,94,-118>, a=<5,-3,-3>
p=<1359,-94,-3622>, v=<56,62,61>, a=<-11,-5,10>
p=<792,1943,-724>, v=<-16,-123,-33>, a=<-2,3,6>
p=<540,-115,3014>, v=<7,41,-90>, a=<-3,-3,-5>
p=<1191,2993,-976>, v=<-13,-63,12>, a=<-4,-7,3>
p=<3459,-409,-3055>, v=<-132,110,67>, a=<-3,-8,7>
p=<-1686,-1144,410>, v=<113,35,56>, a=<-3,2,-7>
p=<2934,-2488,-2593>, v=<-52,66,-65>, a=<-8,5,17>
p=<1348,4231,-3011>, v=<-52,-158,114>, a=<-1,-3,2>
p=<-3646,-752,2049>, v=<152,149,-93>, a=<1,-10,0>
p=<-2386,-2979,-2756>, v=<91,45,40>, a=<0,5,5>
p=<-1242,115,2834>, v=<47,7,-121>, a=<0,-1,1>
p=<3945,1168,2132>, v=<-58,7,41>, a=<-7,-4,-9>
p=<-5675,-522,156>, v=<42,-90,-45>, a=<13,8,3>
p=<-4167,6420,-1404>, v=<119,-33,-66>, a=<3,-16,9>
p=<1800,1545,-2314>, v=<-70,-48,-31>, a=<0,-1,9>
p=<1388,1782,-773>, v=<-93,-63,-11>, a=<-1,-9,9>
p=<-803,1537,2146>, v=<56,22,-122>, a=<0,-18,-4>
p=<-1195,1411,-493>, v=<24,-29,44>, a=<8,-10,-1>
p=<-572,-1690,-24>, v=<62,110,-27>, a=<-3,1,4>
p=<-103,396,-234>, v=<66,-24,-42>, a=<-8,-1,8>
p=<1010,-3,-1501>, v=<9,-18,71>, a=<-11,2,5>
p=<604,2839,-1655>, v=<8,-161,52>, a=<-7,-6,9>
p=<4007,1834,-226>, v=<-125,42,-35>, a=<-5,-11,4>
p=<-3275,-1774,984>, v=<114,-47,71>, a=<3,11,-10>
p=<-4778,-1464,-2405>, v=<78,0,52>, a=<8,4,3>
p=<3854,-3219,-221>, v=<16,-27,-5>, a=<-12,11,1>
p=<1748,-6950,-3185>, v=<-38,157,136>, a=<-2,8,-1>
p=<3373,3021,-4394>, v=<-87,84,61>, a=<-3,-15,8>
p=<-1214,3662,695>, v=<9,-112,-1>, a=<5,-7,-3>
p=<-814,332,-2555>, v=<10,23,25>, a=<3,-4,10>
p=<-2674,-1248,1755>, v=<61,60,-138>, a=<7,0,5>
p=<-34,-2408,2505>, v=<-29,-8,-60>, a=<3,12,-6>
p=<1016,-4018,65>, v=<118,83,-1>, a=<-16,11,0>
p=<-14,1622,115>, v=<12,-94,28>, a=<-1,1,-3>
p=<-1794,2202,3335>, v=<80,-81,-133>, a=<1,-3,-3>
p=<-2634,-1248,-2425>, v=<122,-24,155>, a=<1,8,-3>
p=<-1484,480,-806>, v=<52,-62,154>, a=<11,3,-13>
p=<196,-270,430>, v=<29,20,-14>, a=<-7,0,-3>
p=<-1154,900,118>, v=<18,-32,-92>, a=<12,-7,13>
p=<-500,72,-212>, v=<35,-41,-71>, a=<1,5,14>
p=<268,-66,-182>, v=<-42,81,-54>, a=<3,-12,11>
p=<-1576,638,-4953>, v=<55,-82,111>, a=<0,4,4>
p=<-8884,348,-255>, v=<157,3,-21>, a=<10,-1,2>
p=<2542,-4611,1862>, v=<18,84,-4>, a=<-7,5,-4>
p=<-6216,-9396,-1154>, v=<80,99,40>, a=<9,15,0>
p=<-996,-2987,-3880>, v=<-55,103,104>, a=<6,0,2>
p=<773,-899,-1618>, v=<-26,-29,-94>, a=<0,4,10>
p=<-213,-2581,-2720>, v=<-67,29,94>, a=<5,4,0>
p=<-788,-3423,-8000>, v=<-21,-8,156>, a=<3,8,7>
p=<-1613,8217,2905>, v=<-71,-55,-6>, a=<8,-14,-6>
p=<-5768,-4248,-590>, v=<-10,35,2>, a=<13,7,1>
p=<1837,-3153,4825>, v=<62,-110,-39>, a=<-8,14,-8>
p=<637,-1983,5590>, v=<9,37,-80>, a=<-2,2,-7>
p=<2512,1947,310>, v=<-100,-1,34>, a=<1,-4,-3>
p=<1267,-4233,-13565>, v=<-74,-12,171>, a=<2,10,18>
p=<-1118,-603,-305>, v=<52,22,39>, a=<-1,0,-2>
p=<487,-3228,1975>, v=<14,1,-68>, a=<-2,7,0>
p=<-432,-704,1002>, v=<-165,-50,-11>, a=<16,7,-3>
p=<-960,627,-714>, v=<-3,-76,136>, a=<4,4,-9>
p=<-278,143,6029>, v=<-34,38,-67>, a=<4,-4,-18>
p=<-25,2189,-3079>, v=<81,14,48>, a=<-7,-10,8>
p=<-2621,-99,-208>, v=<-31,3,-117>, a=<13,0,11>
p=<3913,1903,-659>, v=<17,-65,30>, a=<-17,-2,0>
p=<-1279,2420,-2804>, v=<46,-8,70>, a=<1,-9,5>
p=<168,-1797,2373>, v=<19,88,-49>, a=<-2,-1,-4>
p=<-2400,-741,-4755>, v=<26,-31,123>, a=<6,5,6>
p=<-2172,4131,4857>, v=<4,16,-65>, a=<7,-15,-11>
p=<-5460,-2013,-4179>, v=<141,-3,199>, a=<7,7,-2>
p=<-3648,351,-3711>, v=<78,-14,92>, a=<6,0,5>
p=<4560,2763,1221>, v=<-14,-102,-151>, a=<-14,-1,8>
p=<-148,-1129,1285>, v=<18,132,-59>, a=<-1,-4,-12>
p=<-143,581,-450>, v=<34,-39,32>, a=<-4,-4,3>
p=<137,136,905>, v=<-27,-66,-43>, a=<2,9,-8>
p=<287,976,1180>, v=<-64,-73,-76>, a=<6,-5,-7>
p=<-248,-1019,-685>, v=<83,110,72>, a=<-11,-2,0>
p=<-125,-2118,-1067>, v=<20,61,37>, a=<-1,18,8>
p=<655,462,1417>, v=<-19,-76,-131>, a=<-5,6,2>
p=<115,-432,-599>, v=<0,5,63>, a=<-1,5,-2>
p=<1441,1362,-671>, v=<-117,-99,56>, a=<0,-2,0>
p=<-10582,505,9362>, v=<20,-166,-63>, a=<14,8,-10>
p=<1776,-2085,-517>, v=<9,94,33>, a=<-3,-2,-1>
p=<-4070,-1937,-2145>, v=<72,33,77>, a=<2,1,-1>
p=<-40,-612,2263>, v=<33,-3,-148>, a=<-5,8,-6>
p=<332,-414,-1139>, v=<-76,13,77>, a=<7,3,3>
p=<-280,468,763>, v=<-25,24,-114>, a=<7,-10,8>
p=<1639,85,-384>, v=<-27,0,23>, a=<-10,-1,0>
p=<-1571,-905,2421>, v=<67,42,-156>, a=<5,2,-1>
p=<-2156,1960,1731>, v=<106,-85,-46>, a=<5,-6,-9>
p=<-2111,3243,-422>, v=<-18,-118,102>, a=<13,-5,-8>
p=<-857,-1849,2637>, v=<-4,100,-59>, a=<5,0,-8>
p=<-192,773,-1201>, v=<-19,-18,23>, a=<3,-2,4>
p=<-1293,5243,-7446>, v=<-64,-56,158>, a=<6,-6,4>
p=<-7134,-1390,-7182>, v=<-23,26,99>, a=<14,1,7>
p=<984,1250,-5796>, v=<20,65,74>, a=<-3,-6,6>
p=<-5055,1283,4962>, v=<101,30,-99>, a=<3,-4,-3>
p=<-1194,-6637,-7875>, v=<154,168,18>, a=<-7,2,13>
p=<918,-3337,2586>, v=<-29,136,-27>, a=<0,-2,-3>
p=<-4164,1415,-1836>, v=<40,-25,5>, a=<5,-1,3>
p=<-270,-5548,-2331>, v=<-27,-1,71>, a=<2,10,0>
p=<-814,-147,-908>, v=<56,18,59>, a=<2,-1,3>
p=<704,-15,-1544>, v=<-51,20,34>, a=<-1,-3,15>
p=<-1336,-2115,-1172>, v=<80,104,68>, a=<5,11,5>
p=<758,2493,568>, v=<-88,-150,-64>, a=<4,-9,3>
p=<1124,-33,-680>, v=<-34,-76,53>, a=<-9,12,1>
p=<1778,1929,244>, v=<-134,-103,-63>, a=<-2,-9,7>
p=<158,-621,466>, v=<79,38,-75>, a=<-14,2,6>
p=<-394,759,-1274>, v=<-18,1,83>, a=<8,-10,4>
p=<-3820,1040,4623>, v=<131,9,-83>, a=<0,-3,-5>
p=<-1065,663,1839>, v=<-99,67,-92>, a=<9,-6,2>
p=<6504,1098,-1583>, v=<-90,-53,-34>, a=<-9,1,6>
p=<5837,4549,-1554>, v=<-67,-22,-20>, a=<-9,-9,5>
p=<2792,-2121,4797>, v=<-7,58,-44>, a=<-6,1,-8>
p=<-3410,-2195,1083>, v=<-56,-22,56>, a=<9,5,-5>
p=<-5926,-5272,-1552>, v=<18,86,-24>, a=<9,4,4>
p=<9918,-1294,5571>, v=<42,39,-6>, a=<-19,0,-9>
p=<-2271,-7108,-6924>, v=<-37,105,-6>, a=<6,6,12>
p=<5532,-6088,2018>, v=<-4,75,-24>, a=<-9,6,-2>
p=<3645,3262,-1178>, v=<-36,-60,-35>, a=<-4,-2,4>
p=<-8901,2276,-5581>, v=<-17,109,112>, a=<16,-10,3>
p=<-486,-7312,-1773>, v=<103,6,0>, a=<-5,12,3>
p=<6909,1290,-2895>, v=<-167,33,-2>, a=<-2,-4,5>
p=<-3674,4150,5465>, v=<-38,-8,37>, a=<11,-9,-15>
p=<-1267,1656,-1582>, v=<-61,-12,10>, a=<7,-3,3>
p=<1416,2688,-1339>, v=<-64,-111,40>, a=<0,-1,2>
p=<2670,961,4161>, v=<-6,2,-141>, a=<-10,-4,-4>
p=<3488,2857,-2980>, v=<-136,-51,-48>, a=<1,-3,10>
p=<-2399,4307,848>, v=<-8,-71,-60>, a=<6,-5,2>
p=<443,-4451,-283>, v=<149,21,39>, a=<-11,9,-2>
p=<-4835,4510,1080>, v=<-29,87,-38>, a=<13,-16,0>
p=<-1413,-5031,-515>, v=<123,176,17>, a=<-5,0,0>
p=<5460,-1000,-167>, v=<-9,52,5>, a=<-12,-1,0>
p=<2589,-1493,645>, v=<-60,-51,-53>, a=<-2,7,2>
p=<-2567,3930,375>, v=<-81,-9,31>, a=<12,-9,-3>
p=<4965,3216,-6107>, v=<-89,-114,103>, a=<-6,0,8>
p=<-2343,-8180,515>, v=<85,177,-148>, a=<0,8,9>
p=<4013,-998,-1459>, v=<-113,-65,53>, a=<-2,7,0>
p=<-775,-928,-1949>, v=<29,-53,-118>, a=<0,6,13>
p=<849,584,2713>, v=<116,38,49>, a=<-10,-4,-10>
p=<-131,4210,-2131>, v=<-52,-77,77>, a=<4,-5,0>
p=<-1041,4448,2769>, v=<111,103,-11>, a=<-5,-18,-6>
p=<-551,-536,1383>, v=<-8,-9,-92>, a=<2,2,3>
p=<888,1290,-578>, v=<-1,-9,26>, a=<-3,-4,0>
p=<-1895,2371,641>, v=<-60,-104,-15>, a=<12,0,-1>
p=<-1435,2739,-2763>, v=<-92,36,73>, a=<13,-13,4>
p=<4039,2605,1438>, v=<-38,-45,-27>, a=<-5,-2,-1>
p=<1597,-4358,-4403>, v=<-15,-72,-37>, a=<-2,12,10>
p=<-10118,-7031,3814>, v=<85,196,3>, a=<13,1,-7>
p=<-7808,2176,-1169>, v=<-2,19,-135>, a=<14,-5,10>
p=<970,-4490,5134>, v=<-64,17,-88>, a=<2,7,-4>
p=<1333,691,4903>, v=<-92,-4,-149>, a=<3,-1,0>
p=<2965,-3628,-352>, v=<8,46,14>, a=<-9,7,0>
p=<3758,961,-872>, v=<-63,18,-47>, a=<-6,-4,6>
p=<-2261,51,-1275>, v=<47,26,63>, a=<3,-2,-1>
p=<-5329,-625,1130>, v=<57,52,65>, a=<11,-2,-8>
p=<1756,-5890,4107>, v=<68,133,-90>, a=<-10,7,-5>
p=<3030,-2757,2014>, v=<-116,53,-104>, a=<0,4,2>
p=<430,-560,-300>, v=<-43,9,12>, a=<2,1,0>
p=<2484,2339,3171>, v=<94,-8,-54>, a=<-14,-6,-5>
p=<1730,-2211,-3953>, v=<15,-22,-50>, a=<-6,8,15>
p=<-7383,-6644,844>, v=<109,54,-59>, a=<13,15,2>
p=<-328,-1454,-1296>, v=<2,116,54>, a=<5,2,11>
p=<1740,-1542,1718>, v=<-108,88,-46>, a=<-8,8,-18>
p=<1377,1010,783>, v=<-117,-72,-63>, a=<-1,-4,-1>
p=<-1351,-1685,-1065>, v=<77,107,45>, a=<8,7,9>
p=<-306,339,629>, v=<-36,-17,-13>, a=<11,-3,-7>
p=<167,570,1058>, v=<-43,-104,-88>, a=<5,8,-1>
p=<2,-222,1201>, v=<-52,4,-107>, a=<9,2,0>
p=<9566,1711,1873>, v=<-76,-48,55>, a=<-11,0,-6>
p=<4001,-7179,-3062>, v=<-79,-10,16>, a=<-2,12,4>
p=<3441,1116,8068>, v=<-45,5,58>, a=<-3,-2,-16>
p=<4596,-844,-4882>, v=<66,79,86>, a=<-11,-3,3>
p=<-3957,2431,8169>, v=<-89,-64,-118>, a=<10,0,-5>
p=<4175,-9254,6402>, v=<-30,29,104>, a=<-4,11,-14>
p=<-3501,-5549,-666>, v=<-62,68,-22>, a=<8,4,2>
p=<-11101,-685,-7810>, v=<21,18,10>, a=<14,0,10>
p=<-13932,-1502,-10432>, v=<-2,20,79>, a=<19,1,10>
p=<10274,-6518,-3117>, v=<63,-43,23>, a=<-17,11,3>
p=<147,-4409,9404>, v=<-41,38,-53>, a=<2,4,-10>
p=<2085,18,113>, v=<64,-59,-62>, a=<-6,3,3>
p=<-2926,623,1213>, v=<-16,27,-126>, a=<17,-6,6>
p=<-3116,-1144,1745>, v=<14,130,26>, a=<15,-7,-12>
p=<-4389,471,-592>, v=<71,95,-1>, a=<16,-12,3>
p=<3458,-745,-801>, v=<-42,-21,0>, a=<-14,6,4>
p=<-1197,-612,1099>, v=<-57,12,-120>, a=<12,2,6>
p=<-456,528,738>, v=<114,2,39>, a=<-9,-3,-8>
p=<-1843,-1011,-3974>, v=<97,-47,77>, a=<0,10,13>
p=<3713,-862,1017>, v=<4,59,18>, a=<-10,-2,-4>
p=<-3199,-2320,5607>, v=<64,29,-208>, a=<4,4,0>
p=<-2173,-808,3096>, v=<124,29,-115>, a=<-3,0,0>
p=<1661,-4075,-306>, v=<-102,-4,-31>, a=<3,11,3>
p=<-7600,-1915,3744>, v=<157,28,-13>, a=<9,3,-9>
p=<-2902,3404,612>, v=<-3,-127,103>, a=<8,0,-9>
p=<3308,5132,-333>, v=<-51,-121,-30>, a=<-5,-5,3>
p=<1445,731,-414>, v=<-66,98,-27>, a=<1,-9,3>
p=<-10565,2019,2714>, v=<134,-37,-89>, a=<14,-2,0>
p=<1480,-2841,3374>, v=<27,125,13>, a=<-5,-2,-8>
p=<-2510,-516,1169>, v=<5,63,-22>, a=<5,-3,-1>
p=<-11840,714,-1711>, v=<99,-71,-81>, a=<19,3,9>
p=<-5045,-906,1034>, v=<74,76,-64>, a=<6,-3,2>
p=<-2975,-2226,-3091>, v=<98,120,58>, a=<0,-3,3>
p=<5740,-3531,-3811>, v=<-84,24,51>, a=<-7,6,5>
p=<-7685,1734,7739>, v=<7,19,-24>, a=<16,-5,-15>
p=<-1460,-6546,-331>, v=<-123,47,-65>, a=<11,11,5>
p=<-3125,1299,1754>, v=<-21,18,-57>, a=<8,-4,0>
p=<449,1458,-1639>, v=<3,-44,87>, a=<-2,-2,-1>
p=<2440,-1083,-2684>, v=<-76,60,8>, a=<-3,-1,10>
p=<-189,-324,3146>, v=<9,-9,-50>, a=<0,2,-8>
p=<-57,1271,-110>, v=<-43,-24,6>, a=<4,-3,0>
p=<-1124,-874,3674>, v=<63,-30,-28>, a=<-1,6,-12>
p=<-4105,-379,-1980>, v=<3,5,45>, a=<16,1,4>
p=<-2059,-1072,2057>, v=<94,140,-173>, a=<0,-8,7>
p=<-1828,985,1034>, v=<95,12,-115>, a=<-1,-5,6>
p=<-112,50,561>, v=<-98,-3,79>, a=<9,0,-9>
p=<7466,-3573,4226>, v=<0,74,-111>, a=<-10,1,0>
p=<-6689,360,-1037>, v=<-76,107,-70>, a=<13,-6,5>
p=<-12370,7048,5252>, v=<54,-69,96>, a=<14,-6,-12>
p=<191,1067,-2062>, v=<15,-79,168>, a=<-6,-3,4>
p=<521,1848,-1424>, v=<-21,-108,122>, a=<-5,-10,2>
p=<-348,297,1095>, v=<82,-33,-119>, a=<-9,1,4>
p=<1060,-319,-335>, v=<-70,5,-49>, a=<-5,4,14>
p=<-1569,-946,-1512>, v=<91,8,88>, a=<8,13,9>
p=<906,1188,1161>, v=<-92,-90,-143>, a=<1,-3,7>
p=<994,0,699>, v=<-88,0,-5>, a=<-1,0,-9>
p=<1412,-561,-38>, v=<-60,39,-4>, a=<-12,2,2>
p=<-1452,-2819,-1429>, v=<-53,87,20>, a=<12,5,5>
p=<-2652,-669,-1979>, v=<112,32,-5>, a=<2,0,10>
p=<1398,-1069,321>, v=<-59,52,-15>, a=<-1,0,0>
p=<-152,-239,-1469>, v=<29,21,-83>, a=<-2,-1,15>
p=<-1292,312,-3629>, v=<-37,29,31>, a=<9,-4,13>
p=<1480,585,1621>, v=<-26,16,-43>, a=<-4,-4,-3>
p=<-5828,-2544,-1445>, v=<190,22,-62>, a=<8,9,12>
p=<-1667,3267,6380>, v=<1,-132,-151>, a=<5,0,-8>
p=<3708,3542,-2020>, v=<-58,-78,29>, a=<-7,-5,4>
p=<4608,-2558,-1420>, v=<-81,-29,18>, a=<-8,10,3>
p=<-817,-2983,-2445>, v=<-20,14,33>, a=<4,8,5>
p=<333,1642,-2695>, v=<12,-15,95>, a=<-2,-4,1>
p=<1508,5392,2205>, v=<-204,-87,29>, a=<11,-10,-9>
p=<1208,3217,-1595>, v=<-36,-26,-66>, a=<-1,-8,10>
p=<1658,117,1705>, v=<50,-32,23>, a=<-9,2,-7>
p=<2065,4044,-947>, v=<-17,1,35>, a=<-4,-10,0>
p=<9079,4170,5073>, v=<-79,-105,-122>, a=<-17,-3,-4>
p=<2345,-856,3127>, v=<31,60,-154>, a=<-8,-2,3>
p=<3577,-7002,33>, v=<-71,120,29>, a=<-4,9,-2>
p=<-8981,3162,-261>, v=<131,-11,112>, a=<13,-7,-7>
p=<-1428,-1516,-312>, v=<0,100,35>, a=<12,0,-2>
p=<12,1049,993>, v=<8,-87,4>, a=<-1,2,-9>
p=<-528,-1621,-927>, v=<28,35,172>, a=<1,9,-14>
p=<867,779,108>, v=<-57,59,-9>, a=<0,-14,0>
p=<912,-181,108>, v=<-116,-5,15>, a=<7,2,-3>
p=<3297,-1081,738>, v=<-139,-17,-3>, a=<-10,11,-6>
p=<372,704,348>, v=<-16,-16,-41>, a=<-1,-4,2>
p=<2783,-1197,-556>, v=<-89,120,83>, a=<0,-5,-4>
p=<-3473,4099,500>, v=<90,-128,-82>, a=<1,0,4>
p=<1583,-861,-8364>, v=<31,-72,63>, a=<-5,6,12>
p=<-1841,-1133,3412>, v=<6,151,25>, a=<3,-7,-8>
p=<2719,-925,-7980>, v=<12,-70,51>, a=<-6,6,12>
p=<-913,35,-6236>, v=<109,-1,-53>, a=<-5,0,15>
p=<-8865,-3773,-2444>, v=<44,118,76>, a=<14,0,0>
p=<4943,-1693,3524>, v=<58,20,5>, a=<-13,2,-7>
p=<67,771,312>, v=<16,-25,-31>, a=<-5,-9,0>
p=<-758,-364,-588>, v=<-28,-27,37>, a=<18,12,4>
p=<2188,-1779,-292>, v=<312,-258,-41>, a=<-20,21,5>
p=<-14,-1868,-2439>, v=<-1,-269,-346>, a=<0,18,24>
p=<500,2611,494>, v=<72,374,69>, a=<-9,-26,-4>
p=<-1308,-1096,-2149>, v=<-185,-153,-307>, a=<13,14,25>
p=<113,-2599,-664>, v=<19,-372,-91>, a=<-7,25,6>
p=<3129,-248,-559>, v=<448,-38,-79>, a=<-28,2,8>
p=<-1186,-34,2992>, v=<-170,-5,426>, a=<6,-9,-29>
p=<711,1912,1704>, v=<94,276,238>, a=<-12,-14,-16>
p=<166,-990,2824>, v=<24,-141,407>, a=<2,8,-26>
p=<331,-607,2900>, v=<45,-89,412>, a=<-3,8,-28>
p=<325,-2866,952>, v=<45,-408,134>, a=<0,31,-13>
p=<4,329,2833>, v=<0,45,403>, a=<4,-3,-29>
p=<-2442,-1537,616>, v=<-349,-219,88>, a=<30,17,-6>
p=<-2169,-1523,-319>, v=<-307,-218,-45>, a=<20,18,3>
p=<1205,2161,1773>, v=<169,313,253>, a=<-14,-17,-22>
p=<-2813,-158,-1606>, v=<-399,-24,-223>, a=<27,0,16>
p=<-300,-1872,2672>, v=<-43,-267,381>, a=<-2,17,-29>
p=<173,332,-2892>, v=<22,47,-409>, a=<0,-6,30>
p=<-1011,1097,2671>, v=<-144,156,381>, a=<9,-11,-24>
p=<-1617,1789,2160>, v=<-233,255,306>, a=<21,-20,-22>
p=<-1291,-1689,-1940>, v=<-181,-242,-277>, a=<16,18,19>
p=<2383,181,-1111>, v=<336,28,-160>, a=<-27,-1,19>
p=<-2188,1190,-1339>, v=<-313,169,-192>, a=<21,-12,13>
p=<358,337,-2787>, v=<45,48,-398>, a=<-5,0,24>
p=<692,34,3136>, v=<98,0,448>, a=<-6,3,-31>
p=<-2628,106,-710>, v=<-375,18,-101>, a=<26,0,7>
p=<2942,1538,-532>, v=<420,222,-69>, a=<-29,-20,6>
p=<1185,-1436,-1371>, v=<165,-209,-195>, a=<-12,17,10>
p=<385,-2376,-1471>, v=<56,-340,-212>, a=<-5,23,9>
p=<528,1670,1371>, v=<71,238,195>, a=<-10,-17,-14>
p=<-337,1671,2331>, v=<-55,238,327>, a=<-2,-19,-23>
p=<1299,-2197,-1241>, v=<184,-319,-174>, a=<-12,20,12>
p=<-977,461,2808>, v=<-136,65,396>, a=<8,-7,-28>
p=<-1874,2613,223>, v=<-267,373,38>, a=<15,-22,-6>
p=<2638,-874,860>, v=<373,-125,122>, a=<-26,7,-8>
p=<1542,2290,1781>, v=<217,327,255>, a=<-14,-21,-18>
p=<57,-2694,143>, v=<5,-386,23>, a=<-4,21,0>
p=<622,2253,-630>, v=<88,321,-85>, a=<-5,-22,10>
p=<-1986,-1627,-478>, v=<-281,-234,-70>, a=<19,11,4>
p=<1565,2487,-162>, v=<220,353,-24>, a=<-11,-23,-3>
p=<-950,-3131,379>, v=<-138,-450,54>, a=<11,26,-3>
p=<2670,-674,-228>, v=<379,-97,-30>, a=<-30,2,4>
p=<-184,1762,-2096>, v=<-24,250,-304>, a=<1,-14,17>
p=<-315,-2805,-274>, v=<-48,-402,-36>, a=<2,28,-1>
p=<-2545,-1535,-137>, v=<-361,-219,-21>, a=<25,12,-6>
p=<1266,-81,2471>, v=<180,-5,359>, a=<-9,3,-24>
p=<23,-1250,2058>, v=<3,-179,294>, a=<3,13,-16>
p=<7,2644,-1868>, v=<3,377,-266>, a=<-2,-20,18>
p=<947,3137,-310>, v=<136,451,-44>, a=<-9,-31,3>
p=<1560,936,2139>, v=<222,136,306>, a=<-15,-9,-21>
p=<1131,277,3042>, v=<159,38,436>, a=<-15,-5,-30>
p=<137,-2691,807>, v=<18,-383,112>, a=<-1,26,-4>
p=<384,-3124,-394>, v=<57,-443,-64>, a=<0,31,0>
p=<-2030,-1742,668>, v=<-289,-248,93>, a=<17,16,-1>
p=<-833,1144,-2673>, v=<-119,160,-385>, a=<9,-11,27>
p=<-534,2413,-1086>, v=<-76,345,-159>, a=<0,-21,11>
p=<-995,2372,2371>, v=<-142,341,338>, a=<14,-21,-26>
p=<2214,1170,1826>, v=<320,167,264>, a=<-23,-16,-15>
p=<-3093,-1336,848>, v=<-438,-191,122>, a=<30,12,-14>
p=<3209,1025,216>, v=<460,150,29>, a=<-34,-17,-2>
p=<1480,-2536,1412>, v=<211,-364,202>, a=<-13,25,-13>
p=<2893,295,-616>, v=<417,42,-86>, a=<-27,0,5>
p=<851,1398,2433>, v=<118,199,347>, a=<-5,-12,-25>
p=<-1840,-1609,-1923>, v=<-263,-229,-273>, a=<18,12,19>
p=<850,-1721,-2928>, v=<119,-244,-414>, a=<-8,19,34>
p=<-2894,143,432>, v=<-411,19,66>, a=<26,-2,-4>
p=<2408,1463,-396>, v=<343,209,-55>, a=<-25,-10,6>
p=<369,-2641,1368>, v=<52,-375,196>, a=<0,24,-17>
p=<397,-2193,2390>, v=<61,-312,342>, a=<-3,17,-20>
p=<1986,-2104,-1171>, v=<284,-301,-163>, a=<-17,27,14>
p=<1834,1489,2595>, v=<264,214,373>, a=<-15,-16,-20>
p=<478,1346,2188>, v=<71,192,308>, a=<-4,-10,-22>
p=<2008,1479,-9>, v=<288,208,-3>, a=<-18,-17,2>
p=<2201,-2102,-309>, v=<312,-300,-40>, a=<-20,21,3>
p=<737,-2404,-89>, v=<105,-340,-12>, a=<-7,27,-1>
p=<-2442,-1325,1632>, v=<-348,-183,235>, a=<22,12,-16>
p=<489,2622,1386>, v=<69,376,201>, a=<-3,-21,-21>
p=<-198,2995,-1624>, v=<-24,425,-230>, a=<5,-29,16>
p=<1567,-1382,1833>, v=<220,-196,256>, a=<-14,13,-11>
p=<1693,2479,480>, v=<242,354,68>, a=<-11,-22,-4>
p=<2553,-2,-637>, v=<364,-1,-92>, a=<-21,-6,6>
p=<-2364,-1883,-1419>, v=<-337,-269,-200>, a=<22,21,10>
p=<-67,-1949,-2365>, v=<-9,-276,-340>, a=<1,15,19>
p=<1641,1328,-2310>, v=<237,187,-330>, a=<-19,-8,20>
p=<-938,1121,-2845>, v=<-137,165,-407>, a=<5,-8,28>
p=<355,976,-2543>, v=<46,139,-357>, a=<-4,-6,24>
p=<1151,-1687,-2021>, v=<162,-241,-287>, a=<-11,12,15>
p=<-2636,-356,1808>, v=<-377,-52,259>, a=<25,3,-19>
p=<-599,-2522,1038>, v=<-81,-362,150>, a=<8,25,-10>
p=<1387,-1548,2223>, v=<198,-220,320>, a=<-12,17,-22>
p=<-1670,1172,1702>, v=<-240,167,242>, a=<14,-9,-18>
p=<1687,336,-2300>, v=<244,48,-328>, a=<-11,-3,21>
p=<2193,1563,1082>, v=<310,227,153>, a=<-26,-18,-11>
p=<1228,2696,-325>, v=<178,383,-49>, a=<-16,-28,2>
p=<2970,421,194>, v=<427,54,26>, a=<-27,1,-2>
p=<-2521,821,1079>, v=<-360,122,158>, a=<21,-5,-10>
p=<1568,463,-2375>, v=<222,64,-342>, a=<-17,-7,23>
p=<548,1669,-2413>, v=<78,243,-350>, a=<-5,-23,26>
p=<2409,-980,283>, v=<343,-142,40>, a=<-18,11,2>
p=<2264,1316,-1915>, v=<320,189,-275>, a=<-25,-14,15>
p=<1841,-1577,875>, v=<267,-224,125>, a=<-16,15,-7>
p=<-1831,1691,346>, v=<-257,236,52>, a=<22,-14,-8>
p=<-3009,853,284>, v=<-429,125,40>, a=<27,-8,-2>
p=<-2756,358,232>, v=<-396,51,33>, a=<24,-2,-8>
p=<990,-2183,-1353>, v=<142,-312,-193>, a=<-9,27,11>
p=<657,1930,2754>, v=<93,278,400>, a=<-6,-21,-27>
p=<-2619,844,862>, v=<-373,116,116>, a=<28,-10,-5>
p=<169,-2404,-1146>, v=<23,-343,-170>, a=<-1,22,12>
p=<1393,2666,2063>, v=<196,375,295>, a=<-10,-29,-20>
p=<2385,907,-63>, v=<340,126,-11>, a=<-21,-10,0>
p=<474,3043,412>, v=<66,437,59>, a=<-6,-24,-4>
p=<-1701,-2278,2098>, v=<-242,-327,298>, a=<13,23,-20>
p=<-1772,2184,408>, v=<-246,307,54>, a=<22,-17,-6>
p=<516,3071,1237>, v=<69,437,176>, a=<-3,-29,-15>
p=<-554,-1995,1941>, v=<-80,-288,276>, a=<12,13,-18>
p=<-2224,-1927,683>, v=<-321,-280,97>, a=<26,19,-5>
p=<-2627,-67,-1184>, v=<-372,-9,-164>, a=<26,-5,11>
p=<-821,1088,-2949>, v=<-113,153,-424>, a=<7,-13,30>
p=<1651,-2632,-1297>, v=<232,-376,-186>, a=<-12,23,8>
p=<-2310,-213,-1194>, v=<-331,-29,-169>, a=<18,2,7>
p=<-1282,3071,1548>, v=<-189,438,224>, a=<12,-28,-18>
p=<-674,2974,561>, v=<-97,419,78>, a=<12,-23,-5>
p=<1167,1934,-2616>, v=<168,279,-373>, a=<-14,-15,23>
p=<-1150,2312,-1926>, v=<-163,333,-275>, a=<8,-26,21>
p=<-163,-217,2985>, v=<-25,-34,425>, a=<1,5,-25>
p=<-2435,-1936,-113>, v=<-353,-276,-17>, a=<24,19,-2>
p=<2061,-1809,-1618>, v=<296,-254,-231>, a=<-21,17,15>
p=<-1071,764,2154>, v=<-152,110,306>, a=<10,-4,-20>
p=<508,2933,1271>, v=<68,421,182>, a=<-4,-30,-8>
p=<-666,288,-2349>, v=<-95,45,-340>, a=<7,-6,23>
p=<-691,3138,-678>, v=<-103,452,-95>, a=<6,-29,5>
p=<2962,-3,219>, v=<423,0,33>, a=<-33,2,-3>
p=<-819,2041,1696>, v=<-117,293,239>, a=<6,-24,-16>
p=<-46,-481,2854>, v=<-6,-65,399>, a=<3,5,-27>
p=<2391,1583,449>, v=<346,229,63>, a=<-17,-10,-1>
p=<-1791,1138,-1735>, v=<-252,157,-249>, a=<17,-14,20>
p=<-2418,-1644,-514>, v=<-343,-232,-75>, a=<24,12,1>
p=<-643,1747,-2570>, v=<-98,249,-375>, a=<3,-16,25>
p=<-2413,871,-1930>, v=<-344,117,-273>, a=<29,-9,16>
p=<-1575,1634,-1254>, v=<-226,233,-179>, a=<13,-13,16>
p=<-1031,2918,-296>, v=<-145,416,-40>, a=<6,-28,2>
p=<-2196,1641,393>, v=<-313,234,60>, a=<21,-20,-1>
p=<772,2956,270>, v=<108,416,37>, a=<-2,-30,2>
p=<1645,276,2168>, v=<234,39,309>, a=<-18,-3,-20>
p=<-2688,1325,1364>, v=<-386,188,193>, a=<31,-9,-12>
p=<-336,-603,2928>, v=<-41,-89,418>, a=<3,10,-31>
p=<1584,-579,2473>, v=<225,-89,356>, a=<-15,4,-29>
p=<1186,-2609,159>, v=<174,-377,23>, a=<-14,22,-4>
p=<269,1939,-2607>, v=<40,271,-371>, a=<-2,-14,27>
p=<2883,-547,1047>, v=<412,-77,153>, a=<-28,-1,-7>
p=<-1467,2250,-1596>, v=<-209,321,-227>, a=<15,-26,12>
p=<-2193,2376,-778>, v=<-315,342,-109>, a=<19,-25,5>
p=<-2372,1756,1>, v=<-337,256,2>, a=<27,-13,-2>
p=<1989,1867,-675>, v=<286,266,-94>, a=<-20,-15,5>
p=<1845,-1237,-1255>, v=<262,-178,-179>, a=<-19,13,9>
p=<-1527,995,-2082>, v=<-216,141,-298>, a=<16,-8,21>
p=<2026,474,2489>, v=<289,72,352>, a=<-23,-6,-25>
p=<-3037,-849,172>, v=<-430,-123,23>, a=<30,2,-5>
p=<-1220,-2308,-1274>, v=<-178,-335,-184>, a=<6,20,13>
p=<-1530,1337,-2110>, v=<-221,196,-302>, a=<19,-12,24>
p=<986,2939,579>, v=<139,419,78>, a=<-6,-28,-4>
p=<-519,3113,-324>, v=<-75,442,-48>, a=<4,-30,5>
p=<623,400,2869>, v=<92,58,411>, a=<-6,-7,-27>
p=<-2859,2033,23>, v=<-410,296,2>, a=<28,-20,4>
p=<2291,866,1023>, v=<331,124,147>, a=<-18,-2,-6>
p=<-2354,468,-1398>, v=<-340,69,-201>, a=<25,-1,13>
p=<-826,-2105,2171>, v=<-119,-301,314>, a=<6,20,-20>
p=<-1783,-846,-2140>, v=<-255,-117,-302>, a=<17,10,21>
p=<-461,-1430,-2780>, v=<-71,-204,-402>, a=<6,15,28>
p=<1450,1057,-2673>, v=<202,149,-380>, a=<-14,-7,27>
p=<1245,-878,-2194>, v=<182,-122,-316>, a=<-12,14,22>
p=<1957,-1934,-844>, v=<286,-275,-123>, a=<-19,20,8>
p=<-956,2263,1313>, v=<-138,323,188>, a=<10,-23,-14>
p=<672,1409,2280>, v=<92,202,325>, a=<-6,-10,-22>
p=<-1199,1640,-2481>, v=<-175,233,-352>, a=<8,-20,26>
p=<2569,-143,1896>, v=<369,-24,276>, a=<-24,0,-18>
p=<3229,-1012,-465>, v=<455,-140,-66>, a=<-35,13,7>
p=<522,2771,-1124>, v=<73,392,-161>, a=<-3,-27,10>
p=<1318,1086,2289>, v=<189,155,327>, a=<-18,-10,-26>
p=<-2751,1414,-700>, v=<-393,204,-104>, a=<26,-12,7>
p=<289,2728,1002>, v=<39,391,141>, a=<4,-25,-10>
p=<-681,2596,-887>, v=<-98,370,-128>, a=<10,-25,9>
p=<245,-648,-2307>, v=<34,-90,-328>, a=<-4,3,23>
p=<-597,-1842,-2021>, v=<-86,-263,-285>, a=<6,14,18>
p=<408,1040,-2584>, v=<58,148,-372>, a=<-5,-7,28>
p=<-1432,1467,-2591>, v=<-201,206,-371>, a=<11,-18,23>
p=<1676,785,2325>, v=<242,113,326>, a=<-12,-6,-27>
p=<2498,1965,-541>, v=<360,278,-77>, a=<-24,-17,0>
p=<2116,1344,-728>, v=<301,195,-107>, a=<-23,-6,7>
p=<407,2884,-1110>, v=<58,412,-158>, a=<-9,-24,15>
p=<-1234,-1299,1541>, v=<-179,-183,219>, a=<10,10,-14>
p=<1685,-2959,482>, v=<238,-418,66>, a=<-16,22,-3>
p=<-1711,2164,-1663>, v=<-242,316,-235>, a=<17,-21,15>
p=<-486,821,-3035>, v=<-74,117,-433>, a=<4,-4,25>
p=<-2216,439,-2538>, v=<-316,62,-367>, a=<22,-10,25>
p=<1750,956,2772>, v=<249,137,395>, a=<-17,-9,-24>
p=<241,-2811,113>, v=<37,-404,14>, a=<-2,28,-8>
p=<1952,-2173,-978>, v=<279,-312,-139>, a=<-21,24,9>
p=<-399,-476,-2838>, v=<-58,-69,-399>, a=<3,9,26>
p=<2649,-909,-811>, v=<375,-126,-112>, a=<-26,9,9>
p=<1185,-3030,-694>, v=<169,-431,-97>, a=<-11,28,6>
p=<3291,-684,-732>, v=<468,-96,-98>, a=<-35,6,4>
p=<2117,-2314,658>, v=<303,-332,97>, a=<-22,19,-4>
p=<-2713,-2148,823>, v=<-382,-311,118>, a=<28,21,-8>
p=<-1144,-1737,1860>, v=<-163,-242,268>, a=<11,17,-18>
p=<2243,-762,-1692>, v=<320,-113,-236>, a=<-24,6,16>
p=<987,-3416,-561>, v=<136,-490,-80>, a=<-10,36,5>
p=<-1807,904,2051>, v=<-261,128,293>, a=<21,-9,-20>
p=<438,2334,1762>, v=<60,334,251>, a=<0,-27,-14>
p=<2,46,-3436>, v=<0,10,-488>, a=<-2,1,31>
p=<-1177,-602,2688>, v=<-165,-92,386>, a=<11,4,-32>
p=<-217,271,2592>, v=<-30,38,368>, a=<4,-2,-25>
p=<1792,-1995,-1160>, v=<258,-287,-165>, a=<-17,18,11>
p=<2,1663,-2381>, v=<1,233,-341>, a=<-2,-20,19>
p=<-8,-2386,1157>, v=<-4,-339,165>, a=<0,23,-11>
p=<2003,-234,1803>, v=<288,-33,263>, a=<-22,1,-15>
p=<630,-846,2724>, v=<88,-118,392>, a=<-5,7,-26>
p=<-2040,2048,-410>, v=<-288,291,-58>, a=<23,-18,4>
p=<-1668,-1654,-1541>, v=<-240,-243,-225>, a=<19,16,14>
p=<1073,3398,-685>, v=<153,485,-97>, a=<-18,-26,0>
p=<1857,-795,2387>, v=<265,-117,347>, a=<-18,9,-18>
p=<291,-2404,1768>, v=<38,-345,253>, a=<-10,25,-22>
p=<3417,57,102>, v=<486,15,18>, a=<-30,7,-6>
p=<-2512,-1564,875>, v=<-357,-227,123>, a=<30,12,-12>
p=<-401,-984,2290>, v=<-60,-137,328>, a=<-1,6,-23>
p=<-2897,1393,470>, v=<-414,203,63>, a=<27,-11,-5>
p=<2120,-1868,2166>, v=<302,-266,308>, a=<-26,14,-16>
p=<2384,-1322,-552>, v=<340,-188,-80>, a=<-22,10,2>
p=<713,-2545,1199>, v=<101,-358,171>, a=<-8,22,-5>
p=<-2297,1488,-523>, v=<-326,210,-78>, a=<21,-19,6>
p=<671,-2505,1993>, v=<101,-354,283>, a=<-6,27,-23>
p=<-457,344,-2487>, v=<-66,49,-359>, a=<4,-6,31>
p=<1793,2089,607>, v=<252,302,84>, a=<-18,-21,-6>
p=<1301,160,2730>, v=<183,20,391>, a=<-11,-4,-27>
p=<-2556,-1504,280>, v=<-363,-217,35>, a=<32,15,3>
p=<-2950,-305,591>, v=<-420,-41,83>, a=<30,7,-5>
p=<-785,-2888,-446>, v=<-113,-417,-67>, a=<5,26,2>
p=<2366,-1464,297>, v=<334,-211,47>, a=<-24,14,-5>
p=<2124,2101,128>, v=<310,301,18>, a=<-25,-20,-3>
p=<-2588,1208,1043>, v=<-370,174,152>, a=<25,-9,-10>
p=<-77,1471,2855>, v=<-12,206,408>, a=<4,-11,-30>
p=<2010,-198,1833>, v=<287,-28,257>, a=<-24,0,-18>
p=<269,-2506,1724>, v=<38,-358,246>, a=<4,23,-18>
p=<1829,898,2407>, v=<261,136,342>, a=<-15,-5,-23>
p=<-1568,2235,-192>, v=<-222,321,-32>, a=<15,-24,3>
p=<1222,387,1941>, v=<174,54,277>, a=<-15,-7,-19>
p=<-1855,-1480,-730>, v=<-266,-208,-102>, a=<16,17,11>
p=<1510,1678,-2298>, v=<215,239,-332>, a=<-15,-16,27>
p=<-32,-1092,-2283>, v=<-8,-153,-329>, a=<-1,6,20>
p=<2002,2411,-1006>, v=<286,337,-146>, a=<-17,-19,5>
p=<-2321,503,1709>, v=<-326,67,244>, a=<26,-9,-10>
p=<-384,899,2598>, v=<-51,128,376>, a=<2,-4,-28>
p=<-742,2625,-1683>, v=<-106,375,-243>, a=<4,-32,19>
p=<-642,2461,1776>, v=<-96,348,253>, a=<6,-24,-13>
p=<2135,-367,-2069>, v=<306,-49,-292>, a=<-15,1,20>
p=<2782,1411,-730>, v=<394,202,-102>, a=<-28,-18,6>
p=<1824,1582,-2002>, v=<260,223,-282>, a=<-18,-13,26>
p=<-611,0,2243>, v=<-91,6,320>, a=<9,-2,-22>
p=<-1861,-1775,1956>, v=<-265,-252,277>, a=<19,18,-23>
p=<-1596,2567,490>, v=<-224,367,69>, a=<17,-24,-4>
p=<-2211,-1408,636>, v=<-316,-203,90>, a=<24,14,-11>
p=<-2692,427,1481>, v=<-388,61,213>, a=<26,-6,-14>
p=<-2431,727,361>, v=<-347,102,51>, a=<24,-10,-2>
p=<-1524,1727,-2390>, v=<-222,249,-342>, a=<15,-15,18>
p=<211,-445,2665>, v=<29,-66,380>, a=<-4,4,-26>
p=<-2670,-1396,-1446>, v=<-381,-199,-205>, a=<28,14,16>
p=<2605,232,1156>, v=<376,33,160>, a=<-27,-3,-10>
p=<1061,2095,1379>, v=<151,291,198>, a=<-16,-22,-15>
p=<1279,2266,-1930>, v=<179,322,-275>, a=<-12,-20,19>
p=<748,2623,1803>, v=<104,374,258>, a=<-4,-24,-17>
p=<-2241,1418,1292>, v=<-320,202,187>, a=<19,-13,-16>
p=<-1707,-1193,-2327>, v=<-241,-169,-331>, a=<19,11,20>
p=<-128,938,-2614>, v=<-15,133,-373>, a=<0,-9,30>
p=<-2533,-2580,600>, v=<-358,-367,87>, a=<25,25,1>
p=<0,-1072,2908>, v=<1,-151,414>, a=<-1,10,-29>
p=<619,590,-2429>, v=<90,89,-347>, a=<-6,-2,24>
p=<100,2315,-2174>, v=<14,329,-304>, a=<-1,-30,25>
p=<2934,-289,-121>, v=<420,-45,-16>, a=<-27,-3,-3>
p=<889,-1040,-2956>, v=<126,-142,-422>, a=<-5,7,27>
p=<-1877,2064,-40>, v=<-265,296,-9>, a=<17,-20,2>
p=<1280,-511,2799>, v=<181,-70,399>, a=<-11,1,-27>
p=<734,-109,-2350>, v=<98,-15,-337>, a=<-6,0,24>
p=<2445,1061,214>, v=<351,154,30>, a=<-20,-3,3>
p=<3120,529,291>, v=<447,73,41>, a=<-39,-5,1>
p=<3115,325,1422>, v=<448,48,199>, a=<-29,2,-19>
p=<-372,828,-3199>, v=<-57,118,-457>, a=<6,-1,33>
p=<1297,-2385,1218>, v=<185,-341,174>, a=<-13,23,-9>
p=<-732,-1820,-2349>, v=<-101,-256,-337>, a=<4,22,24>
p=<1377,433,-2179>, v=<198,56,-312>, a=<-8,-8,24>
p=<711,-2745,-1064>, v=<99,-392,-152>, a=<-7,23,12>
p=<-2531,246,515>, v=<-363,36,70>, a=<22,4,-5>
p=<2625,-447,-1147>, v=<373,-67,-165>, a=<-23,7,12>
p=<-481,2838,162>, v=<-62,409,24>, a=<6,-31,-1>
p=<-423,1373,-2207>, v=<-61,197,-314>, a=<3,-13,22>
p=<-1062,-1058,-2785>, v=<-154,-149,-397>, a=<6,11,20>
p=<1621,-2158,1113>, v=<231,-313,159>, a=<-15,21,-12>
p=<-2367,-754,-963>, v=<-337,-107,-138>, a=<25,7,13>
p=<898,-650,2531>, v=<123,-88,358>, a=<-6,7,-23>
p=<-2587,-2141,125>, v=<-367,-301,15>, a=<26,22,-3>
p=<1536,193,-2387>, v=<218,32,-341>, a=<-13,-2,24>
p=<-265,-2951,808>, v=<-34,-421,111>, a=<10,27,-10>
p=<-1032,697,-2689>, v=<-147,98,-383>, a=<14,-3,23>
p=<-2330,-264,-1914>, v=<-332,-34,-270>, a=<23,5,23>
p=<-2774,-783,1233>, v=<-392,-107,173>, a=<26,7,-10>
p=<-1499,2316,-470>, v=<-212,327,-63>, a=<12,-21,6>
p=<-1991,-1013,1068>, v=<-284,-146,156>, a=<16,10,-10>
p=<2695,1135,-414>, v=<387,162,-59>, a=<-24,-11,3>
p=<1924,-512,1635>, v=<274,-74,228>, a=<-22,-1,-13>
p=<1309,3595,-99>, v=<187,513,-15>, a=<-13,-36,0>
p=<-707,-107,3343>, v=<-103,-18,478>, a=<6,2,-34>
p=<-2530,1704,-374>, v=<-360,240,-53>, a=<22,-19,3>
p=<-495,2671,940>, v=<-70,384,138>, a=<7,-21,-8>
p=<1981,-425,-1481>, v=<283,-60,-211>, a=<-15,7,15>
p=<-1210,1776,2085>, v=<-172,257,293>, a=<10,-12,-20>
p=<-1728,1981,-2466>, v=<-249,288,-357>, a=<15,-19,25>
p=<-75,2475,-418>, v=<-7,357,-52>, a=<4,-29,3>
p=<2040,-2062,-239>, v=<290,-293,-35>, a=<-21,23,2>
p=<-2372,1372,-1054>, v=<-335,196,-148>, a=<23,-11,9>
p=<-2520,1814,44>, v=<-364,260,10>, a=<30,-18,-1>
p=<-2792,642,-888>, v=<-402,92,-125>, a=<26,-5,12>
p=<501,3245,-1171>, v=<72,456,-173>, a=<-3,-34,13>
p=<-103,2219,-1402>, v=<-18,317,-203>, a=<6,-23,15>
p=<304,-2801,-10>, v=<42,-397,-5>, a=<4,29,-1>
p=<-1973,-1719,-1333>, v=<-281,-245,-190>, a=<23,20,13>
p=<-2362,-82,2136>, v=<-332,-10,302>, a=<24,1,-21>
p=<1158,1874,-2098>, v=<166,265,-297>, a=<-14,-22,20>
p=<-3260,216,-192>, v=<-464,30,-27>, a=<30,1,1>
p=<-1305,-1478,1113>, v=<-189,-215,161>, a=<10,15,-14>
p=<-3123,1047,-264>, v=<-446,149,-37>, a=<29,-8,-1>
p=<1007,2014,-1183>, v=<141,289,-164>, a=<-14,-20,11>
p=<-962,1515,-3144>, v=<-129,216,-449>, a=<7,-16,33>
p=<453,-606,-2933>, v=<59,-86,-415>, a=<-1,3,32>
p=<438,38,3090>, v=<62,9,439>, a=<-3,7,-31>
p=<-800,2909,1463>, v=<-115,416,209>, a=<6,-26,-15>
p=<-1029,-1612,1442>, v=<-146,-232,210>, a=<10,17,-11>
p=<-215,-581,2970>, v=<-28,-81,422>, a=<5,6,-29>
p=<-1092,1178,-2160>, v=<-157,168,-306>, a=<12,-10,19>
p=<3054,154,-393>, v=<436,22,-52>, a=<-30,-1,2>
p=<819,-2274,-1823>, v=<113,-322,-259>, a=<-8,21,19>
p=<2406,112,-1490>, v=<344,22,-214>, a=<-28,-1,14>
p=<2304,-1879,42>, v=<330,-274,7>, a=<-24,19,0>
p=<-1983,-2227,-778>, v=<-282,-319,-109>, a=<14,27,7>
p=<1565,2189,-786>, v=<227,310,-112>, a=<-20,-26,9>
p=<1284,3289,1173>, v=<183,468,163>, a=<-10,-32,-13>
p=<1621,-3067,-110>, v=<231,-438,-14>, a=<-16,30,4>
p=<2563,-550,1553>, v=<370,-81,223>, a=<-25,8,-13>
p=<2706,-1390,927>, v=<386,-201,127>, a=<-26,16,-12>
p=<1752,-1777,-1759>, v=<248,-252,-249>, a=<-16,22,17>
p=<-2005,-1348,-1771>, v=<-284,-194,-258>, a=<23,12,18>
p=<1674,1036,-2739>, v=<236,146,-391>, a=<-16,-9,28>
p=<-252,-2441,1544>, v=<-36,-349,219>, a=<7,24,-16>
p=<450,-84,3034>, v=<66,-14,434>, a=<-4,2,-30>
p=<199,-2438,-2157>, v=<30,-351,-299>, a=<-1,20,21>
p=<27,3498,248>, v=<-3,499,39>, a=<-1,-32,-5>
p=<-653,183,-2557>, v=<-94,23,-365>, a=<6,0,26>
p=<-1620,1277,2376>, v=<-233,188,337>, a=<15,-11,-24>
p=<-2379,-944,122>, v=<-341,-133,17>, a=<23,9,-8>
p=<2032,-2476,-339>, v=<295,-350,-45>, a=<-17,23,5>
p=<1274,1982,1296>, v=<182,280,179>, a=<-12,-17,-11>
p=<-65,-499,-2956>, v=<-6,-68,-413>, a=<4,1,29>
p=<649,2593,-1539>, v=<88,369,-221>, a=<0,-19,14>
p=<-18,-2787,-2384>, v=<-4,-398,-340>, a=<-4,27,22>
p=<2327,-617,-1543>, v=<331,-91,-222>, a=<-22,7,19>
p=<-2558,-1609,475>, v=<-366,-235,73>, a=<29,16,-3>
p=<-1271,-2545,951>, v=<-182,-361,138>, a=<12,28,-9>
p=<2227,-2376,-491>, v=<318,-339,-68>, a=<-22,25,2>
p=<864,2543,-1344>, v=<130,364,-190>, a=<-8,-30,16>
p=<-865,2454,283>, v=<-125,350,42>, a=<0,-20,-2>
p=<-405,3314,-733>, v=<-57,473,-102>, a=<5,-34,10>
p=<-732,-1380,2366>, v=<-105,-197,338>, a=<6,13,-24>
p=<2591,-552,-346>, v=<370,-78,-56>, a=<-29,9,5>
p=<2852,-560,-991>, v=<411,-86,-146>, a=<-26,5,10>
p=<-831,2687,-1146>, v=<-118,383,-160>, a=<10,-27,10>
p=<-1687,2115,1090>, v=<-241,302,156>, a=<16,-21,-9>
p=<1895,-1293,1262>, v=<267,-185,178>, a=<-16,12,-10>
p=<-99,-2438,1934>, v=<-9,-351,281>, a=<-3,23,-19>
p=<-8,1489,-2433>, v=<-4,212,-343>, a=<2,-13,26>
p=<1071,2234,1710>, v=<149,320,244>, a=<-11,-22,-21>
p=<-928,1848,-2161>, v=<-123,260,-308>, a=<12,-19,20>
p=<-2443,-1594,1161>, v=<-345,-227,165>, a=<24,20,-11>
p=<1108,1515,-2565>, v=<158,216,-369>, a=<-12,-15,18>
p=<986,-685,-2792>, v=<140,-95,-397>, a=<-9,5,27>
p=<2690,352,-1348>, v=<380,50,-190>, a=<-32,2,13>
p=<-2265,384,1333>, v=<-325,54,188>, a=<21,-6,-8>
p=<-2614,265,1245>, v=<-370,41,177>, a=<26,0,-18>
p=<-1562,839,-1981>, v=<-226,121,-284>, a=<13,-13,17>
p=<-1013,-2808,123>, v=<-145,-401,17>, a=<10,25,4>
p=<550,3163,-1756>, v=<77,449,-250>, a=<-4,-31,15>
p=<-524,-1801,2191>, v=<-79,-253,311>, a=<5,16,-17>
p=<-2278,1892,-1780>, v=<-327,275,-257>, a=<26,-18,17>
p=<-924,-1510,-2529>, v=<-129,-215,-364>, a=<8,17,27>
p=<2660,2252,236>, v=<386,321,32>, a=<-25,-20,-8>
p=<-2559,365,609>, v=<-367,48,90>, a=<23,-4,-6>
p=<-2536,-1949,19>, v=<-359,-278,5>, a=<28,16,-3>
p=<-2427,-457,-2244>, v=<-339,-62,-317>, a=<27,3,24>
p=<-189,2608,1587>, v=<-27,370,224>, a=<1,-23,-13>
p=<2052,-1944,580>, v=<293,-284,83>, a=<-17,19,-9>
p=<-2499,-2477,-505>, v=<-354,-353,-72>, a=<24,27,1>
p=<-988,-3071,-67>, v=<-142,-445,-9>, a=<6,26,-3>
p=<-11,-1520,2471>, v=<-1,-217,358>, a=<0,19,-24>
p=<-1616,940,1959>, v=<-229,139,279>, a=<15,-13,-23>
p=<2286,-1105,2005>, v=<326,-161,280>, a=<-25,11,-22>
p=<2773,326,1096>, v=<397,46,158>, a=<-24,-3,-3>
p=<-1274,1126,3228>, v=<-178,159,466>, a=<13,-13,-31>
p=<2002,2105,-789>, v=<289,297,-116>, a=<-18,-20,11>
p=<-1607,-1891,1559>, v=<-231,-272,217>, a=<19,15,-17>
p=<-2443,328,1730>, v=<-346,48,242>, a=<19,-3,-17>
p=<-124,-2257,-2187>, v=<-18,-317,-310>, a=<1,28,25>
p=<977,2937,809>, v=<141,414,110>, a=<-7,-28,-8>
p=<-1770,-561,2468>, v=<-248,-80,358>, a=<11,8,-30>
p=<282,-779,2846>, v=<36,-112,404>, a=<1,9,-29>
p=<2065,1043,1200>, v=<295,152,173>, a=<-18,-10,-13>
p=<-521,1757,2183>, v=<-76,251,310>, a=<7,-15,-25>
p=<1643,-1282,-2278>, v=<234,-183,-327>, a=<-22,10,22>
p=<601,-3123,-601>, v=<83,-444,-85>, a=<-2,31,10>
p=<-1277,2094,1940>, v=<-180,299,276>, a=<8,-22,-18>
p=<-2838,253,124>, v=<-411,38,15>, a=<29,1,4>
p=<1383,-835,-2109>, v=<203,-115,-301>, a=<-13,9,20>
p=<-1873,119,-2339>, v=<-267,10,-335>, a=<12,2,27>
p=<-2413,375,800>, v=<-340,50,111>, a=<22,1,-8>
p=<702,-3024,-288>, v=<98,-432,-39>, a=<-7,31,2>
p=<1277,-781,2109>, v=<182,-111,301>, a=<-13,9,-20>
p=<832,2016,1739>, v=<115,289,252>, a=<-5,-23,-14>
p=<-1155,-2757,1552>, v=<-169,-392,222>, a=<13,29,-13>
p=<-1329,256,2377>, v=<-189,35,343>, a=<18,-2,-26>
p=<2419,1833,-792>, v=<345,259,-119>, a=<-24,-14,7>
p=<241,714,2725>, v=<29,102,389>, a=<-1,-7,-27>
p=<-184,2410,-2083>, v=<-21,344,-296>, a=<2,-26,20>
p=<2496,-1266,-2236>, v=<359,-180,-316>, a=<-22,14,22>
p=<2268,635,-1640>, v=<326,88,-231>, a=<-20,-6,10>
p=<93,2119,-2807>, v=<12,302,-398>, a=<1,-17,29>
p=<1489,457,2571>, v=<213,67,372>, a=<-15,-8,-25>
p=<-1438,2415,18>, v=<-212,347,1>, a=<14,-21,4>
p=<364,109,2641>, v=<54,16,377>, a=<-1,-1,-24>
p=<-71,-2655,-646>, v=<-13,-379,-92>, a=<0,28,6>
p=<-2426,835,490>, v=<-343,122,70>, a=<24,-8,-4>
p=<-1922,-987,-2604>, v=<-279,-144,-375>, a=<19,11,31>
p=<-1474,1048,-1854>, v=<-209,150,-267>, a=<14,-14,19>
p=<2573,1000,-618>, v=<369,140,-91>, a=<-24,-14,1>
p=<41,848,-2842>, v=<7,118,-402>, a=<2,-12,25>
p=<-1236,-1211,-1623>, v=<-180,-172,-229>, a=<12,5,20>
p=<-183,-1308,-2598>, v=<-23,-182,-366>, a=<4,13,24>
p=<499,938,-2348>, v=<75,135,-338>, a=<-1,-9,24>
p=<-1265,2818,982>, v=<-176,405,139>, a=<5,-33,-14>
p=<-1839,2205,-1206>, v=<-261,310,-170>, a=<18,-20,8>
p=<821,2287,2099>, v=<115,323,298>, a=<-9,-26,-23>
p=<-539,2490,-969>, v=<-74,353,-143>, a=<5,-20,12>
p=<-1224,-2661,1842>, v=<-174,-380,263>, a=<13,26,-15>
p=<3285,-848,-766>, v=<472,-121,-111>, a=<-33,3,4>
p=<157,-1772,-1939>, v=<23,-253,-281>, a=<0,18,19>
p=<-1258,-2428,1623>, v=<-181,-346,235>, a=<12,24,-18>
p=<975,-471,3090>, v=<139,-67,442>, a=<-11,11,-25>
p=<2327,1337,-1355>, v=<335,182,-195>, a=<-21,-12,18>
p=<3470,-1113,-532>, v=<492,-165,-81>, a=<-35,9,7>
p=<-2535,-1236,-1132>, v=<-360,-178,-165>, a=<25,8,13>
p=<-2956,-58,501>, v=<-421,-8,71>, a=<31,6,-5>
p=<1947,-2018,1007>, v=<279,-286,144>, a=<-19,23,-6>
p=<1919,-431,2612>, v=<272,-60,371>, a=<-20,0,-29>
p=<633,2705,1301>, v=<91,386,186>, a=<-3,-30,-8>
p=<869,-1260,2982>, v=<123,-180,429>, a=<-11,18,-29>
p=<1111,2210,-1828>, v=<156,315,-258>, a=<-9,-18,18>
p=<-2039,1932,-967>, v=<-291,273,-137>, a=<25,-17,9>
p=<2443,-575,-489>, v=<349,-85,-69>, a=<-22,7,4>
p=<-1542,-1993,-1714>, v=<-218,-281,-245>, a=<13,19,17>
p=<-1229,-1709,-1753>, v=<-168,-247,-254>, a=<11,17,13>
p=<47,-3085,544>, v=<10,-442,76>, a=<0,32,-6>
p=<-1196,2148,657>, v=<-165,312,93>, a=<11,-21,-8>
p=<2167,892,1499>, v=<312,126,219>, a=<-19,-5,-11>
p=<-458,2463,1779>, v=<-63,351,250>, a=<5,-25,-16>
p=<2181,-2030,-2251>, v=<316,-288,-325>, a=<-23,22,24>
p=<1132,-2375,1966>, v=<161,-337,281>, a=<-10,23,-19>
p=<1326,-925,2582>, v=<189,-133,364>, a=<-13,7,-29>
p=<-2830,471,-1333>, v=<-399,69,-190>, a=<25,-5,13>
p=<-2452,-989,29>, v=<-350,-145,4>, a=<29,9,-2>
p=<2630,-1093,-1159>, v=<367,-156,-166>, a=<-27,13,6>
p=<-339,2520,984>, v=<-48,361,147>, a=<3,-21,-8>
p=<-503,2613,1595>, v=<-74,375,227>, a=<3,-21,-17>
p=<3088,-1474,361>, v=<443,-212,51>, a=<-30,12,-2>
p=<220,2549,-157>, v=<28,364,-25>, a=<2,-25,9>
p=<-594,2664,1984>, v=<-78,376,287>, a=<5,-28,-25>
p=<-160,2576,-436>, v=<-21,366,-63>, a=<2,-23,4>
p=<-1565,-928,-2696>, v=<-223,-134,-381>, a=<19,10,29>
p=<2420,2122,1260>, v=<346,305,179>, a=<-23,-19,-14>
p=<3001,-1087,776>, v=<424,-155,109>, a=<-27,13,-5>
p=<-2132,1415,-1022>, v=<-309,201,-148>, a=<24,-10,8>
p=<1553,-2439,-2314>, v=<223,-352,-330>, a=<-16,26,19>
p=<2632,770,-487>, v=<377,113,-71>, a=<-26,-4,4>
p=<433,2471,-2463>, v=<64,353,-351>, a=<-10,-29,25>
p=<1911,-446,-1288>, v=<273,-65,-186>, a=<-15,4,16>
p=<-1989,-2,-2281>, v=<-284,-3,-325>, a=<20,-3,22>
p=<974,3084,-53>, v=<139,438,1>, a=<-9,-30,-1>
p=<1472,-1397,2034>, v=<210,-199,297>, a=<-13,13,-24>
p=<439,1947,-2359>, v=<62,278,-339>, a=<-3,-17,25>
p=<-1630,-2668,132>, v=<-236,-384,15>, a=<18,24,-2>
p=<2219,-2538,-465>, v=<320,-358,-63>, a=<-22,30,3>
p=<-1390,513,-2033>, v=<-198,76,-291>, a=<12,-4,22>
p=<-536,3186,-1385>, v=<-71,453,-197>, a=<5,-32,14>
p=<1897,295,-1548>, v=<269,45,-223>, a=<-19,-6,15>
p=<-961,-2470,-2104>, v=<-136,-355,-303>, a=<11,26,21>
p=<1425,2243,-942>, v=<207,320,-135>, a=<-16,-25,5>
p=<-3127,-1220,164>, v=<-445,-178,23>, a=<31,12,-6>
p=<1051,2750,485>, v=<148,396,71>, a=<-10,-30,1>
p=<974,-3351,231>, v=<139,-479,33>, a=<-7,28,0>
p=<-2537,-1194,884>, v=<-362,-172,123>, a=<27,11,-8>
p=<2442,-734,1421>, v=<353,-104,199>, a=<-25,5,-11>
p=<-2809,990,-738>, v=<-407,141,-102>, a=<28,-10,5>
p=<-461,-2438,1011>, v=<-58,-351,140>, a=<4,20,-12>
p=<-643,-3060,1761>, v=<-94,-436,247>, a=<6,29,-20>
p=<1608,-1350,-1814>, v=<227,-197,-259>, a=<-14,4,16>
p=<-1709,2331,-487>, v=<-244,334,-67>, a=<21,-25,4>
p=<-829,-2716,-1205>, v=<-118,-387,-171>, a=<8,27,12>
p=<-89,-1816,-2959>, v=<-8,-259,-423>, a=<-6,14,34>
p=<483,2766,-1161>, v=<71,397,-167>, a=<-1,-22,9>
p=<-1468,167,2269>, v=<-211,22,324>, a=<11,-2,-22>
p=<240,467,-2714>, v=<41,59,-389>, a=<-6,2,27>
p=<2559,-1576,541>, v=<366,-231,77>, a=<-26,20,-8>
p=<-2457,753,-1913>, v=<-351,108,-272>, a=<23,-8,19>
p=<-519,224,-3112>, v=<-74,36,-443>, a=<5,-3,35>
p=<381,1916,2204>, v=<54,272,314>, a=<-3,-18,-23>
p=<1574,-2589,-1385>, v=<227,-365,-203>, a=<-17,25,13>
p=<1608,-15,-2506>, v=<229,-3,-364>, a=<-16,-1,23>
p=<2239,1530,-1939>, v=<320,218,-275>, a=<-21,-15,23>
p=<-337,-802,-3284>, v=<-50,-113,-463>, a=<-3,9,30>
p=<1248,-2057,1255>, v=<173,-293,183>, a=<-14,22,-12>
p=<-235,3523,916>, v=<-34,506,131>, a=<6,-36,-13>
p=<321,-64,-2686>, v=<47,-6,-384>, a=<-6,0,29>
p=<1974,-2125,-1208>, v=<279,-306,-168>, a=<-17,21,12>
p=<2743,1537,265>, v=<394,227,38>, a=<-27,-19,-3>
p=<1891,-2193,1798>, v=<269,-316,254>, a=<-18,22,-17>
p=<1617,1908,-606>, v=<231,274,-93>, a=<-13,-19,8>
p=<2653,1078,1691>, v=<384,152,243>, a=<-20,-5,-19>
p=<-123,2818,-1707>, v=<-13,403,-244>, a=<2,-31,19>
p=<1988,-1709,1042>, v=<284,-237,145>, a=<-17,13,-10>
p=<966,1598,1902>, v=<138,230,271>, a=<-2,-15,-19>
p=<2484,-243,259>, v=<358,-34,37>, a=<-24,7,-2>
p=<1749,1711,685>, v=<248,242,96>, a=<-17,-17,-10>
p=<1781,304,-2587>, v=<257,42,-373>, a=<-17,1,17>
p=<2995,-1163,-71>, v=<426,-167,-8>, a=<-28,11,-3>
p=<1226,-960,-2324>, v=<170,-140,-332>, a=<-13,8,24>
p=<-2390,2047,-66>, v=<-341,294,-12>, a=<23,-21,1>
p=<-2443,693,-1982>, v=<-348,99,-286>, a=<21,-4,15>
p=<214,2125,-1733>, v=<29,303,-247>, a=<-2,-19,22>
p=<-718,2844,-1493>, v=<-102,404,-213>, a=<2,-31,14>
p=<1935,-2115,-190>, v=<274,-303,-24>, a=<-20,26,-1>
p=<-128,-1409,2593>, v=<-12,-201,369>, a=<3,13,-27>
p=<416,2531,1874>, v=<59,361,270>, a=<-1,-23,-22>
p=<-2665,1458,821>, v=<-383,209,121>, a=<25,-14,-14>
p=<2411,-1155,1925>, v=<343,-163,280>, a=<-22,7,-13>
p=<-1894,1374,-1907>, v=<-263,192,-272>, a=<19,-12,20>
p=<3057,1155,-469>, v=<436,164,-68>, a=<-29,-11,-1>
p=<-1211,2277,-1878>, v=<-178,324,-268>, a=<14,-25,22>
p=<-1919,-2247,1057>, v=<-277,-320,149>, a=<20,25,-8>
p=<1330,-2094,-2531>, v=<187,-298,-358>, a=<-13,20,24>
p=<1795,-643,2275>, v=<259,-91,325>, a=<-17,3,-21>
p=<1694,-1901,-1556>, v=<244,-271,-223>, a=<-13,16,15>
p=<1791,622,-2528>, v=<258,87,-359>, a=<-17,-1,24>
p=<1493,-2677,-564>, v=<213,-381,-78>, a=<-19,30,8>
p=<1643,-772,-1966>, v=<231,-113,-280>, a=<-18,9,20>
p=<1526,1497,2157>, v=<218,211,308>, a=<-18,-15,-26>
p=<-2783,656,151>, v=<-395,94,18>, a=<31,-7,-4>
p=<-2050,111,-2440>, v=<-288,15,-347>, a=<26,-1,25>
p=<3065,-748,41>, v=<438,-109,10>, a=<-27,6,4>
p=<1417,-2521,-255>, v=<207,-362,-41>, a=<-14,29,5>
p=<-357,3259,0>, v=<-53,468,-1>, a=<3,-27,5>
p=<-2090,-1781,-240>, v=<-298,-253,-35>, a=<20,14,-2>
p=<-2290,1405,-426>, v=<-331,202,-65>, a=<22,-13,4>
p=<-275,-2158,790>, v=<-38,-306,113>, a=<6,21,-5>
p=<-2557,-1176,384>, v=<-365,-173,59>, a=<24,10,-3>
p=<1053,2102,1292>, v=<148,298,184>, a=<-11,-22,-15>
p=<-2056,-2009,-617>, v=<-293,-284,-92>, a=<20,20,10>
p=<-2418,239,1276>, v=<-338,36,182>, a=<23,0,-12>
p=<-1344,2049,194>, v=<-194,292,28>, a=<10,-15,3>
p=<-2930,466,320>, v=<-417,66,45>, a=<32,-2,-2>
p=<-3165,-250,-1>, v=<-454,-36,0>, a=<30,2,-1>
p=<-953,-450,-2539>, v=<-132,-66,-360>, a=<9,5,25>
p=<-1697,2249,-351>, v=<-245,314,-50>, a=<16,-20,1>
p=<-2349,-898,-2429>, v=<-338,-126,-346>, a=<18,12,25>
p=<-1414,-2428,-203>, v=<-198,-342,-32>, a=<14,22,2>
p=<-2339,-1380,-825>, v=<-334,-197,-115>, a=<27,12,6>
p=<-196,-3182,884>, v=<-25,-456,125>, a=<2,33,-10>
p=<226,-2718,-888>, v=<34,-387,-129>, a=<-3,27,6>
p=<-716,-2247,-1409>, v=<-98,-323,-200>, a=<6,25,17>
p=<-424,-2459,1078>, v=<-68,-358,151>, a=<3,26,-14>
p=<-775,359,2267>, v=<-109,45,323>, a=<5,-2,-19>
p=<1660,-2576,-703>, v=<231,-368,-96>, a=<-16,25,8>
p=<1857,432,-2190>, v=<265,61,-314>, a=<-16,-6,21>
p=<-2082,-2187,-1189>, v=<-304,-315,-168>, a=<23,20,11>
p=<284,1521,-2602>, v=<39,218,-368>, a=<-3,-14,24>
p=<-1408,-2059,-2126>, v=<-197,-294,-301>, a=<14,20,23>
p=<-2614,-58,-1825>, v=<-373,-4,-259>, a=<20,-3,13>
p=<-2540,-824,-279>, v=<-361,-120,-40>, a=<19,7,6>
p=<-2938,-786,337>, v=<-418,-109,47>, a=<29,8,-4>
p=<-521,-463,-2777>, v=<-79,-66,-394>, a=<1,2,30>
p=<-2833,-75,796>, v=<-401,-8,110>, a=<28,1,-8>
p=<-1631,-1713,613>, v=<-230,-240,93>, a=<20,18,-11>
p=<-3002,-1285,-869>, v=<-424,-185,-127>, a=<31,14,7>
p=<2689,-1087,1151>, v=<386,-155,165>, a=<-29,12,-8>
p=<-1402,-2606,1014>, v=<-192,-373,138>, a=<13,26,-6>
p=<-1310,2523,-1830>, v=<-184,357,-264>, a=<14,-25,14>
p=<-2050,1903,-1542>, v=<-290,268,-217>, a=<25,-24,19>
p=<-2125,1399,-1968>, v=<-303,193,-281>, a=<21,-7,20>
p=<746,2152,1158>, v=<107,307,161>, a=<-7,-21,-7>
p=<-980,2307,1552>, v=<-135,328,221>, a=<9,-23,-15>
p=<-711,-474,-2627>, v=<-103,-63,-374>, a=<7,9,28>
p=<-888,-2767,1661>, v=<-123,-392,237>, a=<10,28,-12>
p=<1385,2490,-872>, v=<195,350,-124>, a=<-15,-19,13>
p=<145,-1342,3219>, v=<16,-193,455>, a=<1,10,-32>
p=<-1004,-1789,-1292>, v=<-146,-255,-181>, a=<9,14,12>
p=<-1587,1323,1786>, v=<-223,189,254>, a=<15,-14,-17>
p=<-1486,831,2141>, v=<-210,116,307>, a=<15,-7,-25>
p=<403,-2548,-1204>, v=<63,-367,-172>, a=<-3,21,12>
p=<1805,-919,1933>, v=<262,-136,272>, a=<-18,9,-19>
p=<-1283,69,-2265>, v=<-183,9,-324>, a=<12,1,21>
p=<-2399,277,-1162>, v=<-342,40,-165>, a=<18,4,13>
p=<-2094,-1739,1321>, v=<-304,-249,190>, a=<22,17,-16>
p=<2906,145,-603>, v=<412,20,-83>, a=<-33,2,2>
p=<2814,-426,1349>, v=<401,-63,187>, a=<-30,3,-12>
p=<-1167,1084,-2148>, v=<-163,151,-308>, a=<15,-11,21>
p=<1058,-1855,1681>, v=<151,-264,242>, a=<-9,19,-18>
p=<2168,2549,-119>, v=<310,359,-17>, a=<-20,-25,-3>
p=<760,-1296,2452>, v=<108,-184,352>, a=<-13,11,-27>
p=<3491,-369,767>, v=<496,-53,105>, a=<-34,5,-11>
p=<-1175,-1652,-2416>, v=<-170,-236,-346>, a=<7,19,26>
p=<-1471,2121,-158>, v=<-212,304,-20>, a=<10,-21,2>
p=<-114,1850,2257>, v=<-16,264,320>, a=<-1,-17,-22>
p=<-545,-2052,1999>, v=<-76,-297,286>, a=<5,16,-16>
p=<-1523,-2237,2079>, v=<-221,-318,295>, a=<9,23,-20>
p=<-656,2442,2198>, v=<-94,347,319>, a=<7,-24,-19>
p=<654,893,2748>, v=<93,129,396>, a=<-6,-7,-26>
p=<-1810,2017,-772>, v=<-251,288,-109>, a=<17,-21,7>
p=<404,-337,-3134>, v=<51,-52,-446>, a=<-5,0,29>
p=<2196,1520,1528>, v=<311,218,216>, a=<-18,-10,-15>
p=<-2996,-164,183>, v=<-422,-28,23>, a=<29,0,-3>
p=<1529,-2030,1414>, v=<210,-291,203>, a=<-22,16,-19>
p=<-864,600,-2986>, v=<-119,89,-426>, a=<11,-7,33>
p=<3233,-463,-1070>, v=<463,-65,-151>, a=<-39,5,8>
p=<-1323,546,2234>, v=<-188,77,315>, a=<17,-5,-20>
p=<-1795,1784,2001>, v=<-251,259,286>, a=<14,-20,-20>
p=<-956,-1971,1927>, v=<-138,-279,275>, a=<5,22,-22>
p=<480,2809,-1219>, v=<71,399,-177>, a=<1,-29,12>
p=<761,1867,-1701>, v=<110,267,-246>, a=<-12,-19,17>
p=<257,-2019,-2164>, v=<34,-288,-311>, a=<0,18,18>
p=<2321,-1049,-134>, v=<337,-149,-21>, a=<-22,8,-3>
p=<-1575,2758,429>, v=<-220,394,59>, a=<15,-24,-6>
p=<-916,1954,1160>, v=<-129,275,160>, a=<13,-16,-7>
p=<-1357,2092,-245>, v=<-195,293,-33>, a=<9,-19,6>
p=<2239,635,-1345>, v=<322,89,-191>, a=<-25,-1,18>
p=<2150,-2562,-510>, v=<307,-370,-69>, a=<-23,25,5>
p=<307,1795,-3091>, v=<38,251,-442>, a=<-3,-23,31>
p=<-3101,9,-884>, v=<-437,1,-124>, a=<31,0,11>
p=<932,-1917,-2367>, v=<138,-267,-340>, a=<-9,19,26>
p=<-704,-2729,-1232>, v=<-106,-389,-176>, a=<5,31,9>
p=<-194,2670,-70>, v=<-27,383,-15>, a=<2,-28,0>
p=<-149,1536,-2560>, v=<-22,214,-365>, a=<1,-10,22>
p=<-1974,-866,2946>, v=<-283,-123,417>, a=<17,6,-33>
p=<-293,3063,-19>, v=<-39,440,-2>, a=<-1,-28,-1>
p=<-1994,507,2293>, v=<-281,74,333>, a=<23,-12,-19>
p=<-2775,2,1238>, v=<-402,0,172>, a=<25,0,-15>
p=<-59,494,-3207>, v=<-10,70,-462>, a=<0,-5,32>
p=<2462,-1241,-1508>, v=<351,-177,-215>, a=<-21,11,15>
p=<894,503,3184>, v=<130,74,455>, a=<-10,-4,-25>
p=<-2784,1041,-821>, v=<-399,143,-117>, a=<27,-10,6>
p=<-3557,641,-814>, v=<-506,92,-115>, a=<41,-1,10>
p=<1756,2605,1147>, v=<250,381,166>, a=<-18,-29,-7>
p=<-2018,-745,-2018>, v=<-288,-106,-291>, a=<22,4,20>
p=<1774,-1769,-2443>, v=<255,-248,-352>, a=<-13,16,27>
p=<-1808,-1619,-2086>, v=<-254,-232,-296>, a=<17,16,25>
p=<-487,2638,-2146>, v=<-72,380,-305>, a=<-2,-20,21>
p=<673,365,-2492>, v=<95,50,-352>, a=<-7,-4,28>
p=<580,-535,2437>, v=<86,-78,348>, a=<-5,4,-27>
p=<1214,-1551,1839>, v=<171,-216,255>, a=<-12,16,-13>
p=<71,-712,2278>, v=<11,-100,327>, a=<0,6,-19>
p=<-127,-2891,-1143>, v=<-19,-413,-163>, a=<6,26,9>
p=<1519,-1941,-115>, v=<217,-276,-13>, a=<-15,20,4>
p=<-2652,-747,1782>, v=<-378,-106,253>, a=<29,7,-16>
p=<330,-2794,1074>, v=<46,-401,148>, a=<-1,27,-12>
p=<-1937,2054,1449>, v=<-272,291,207>, a=<20,-21,-12>
p=<477,0,-2974>, v=<68,-1,-420>, a=<-7,0,25>
p=<1223,2111,979>, v=<174,299,137>, a=<-12,-25,-6>
p=<1778,2523,1819>, v=<254,360,261>, a=<-12,-25,-16>
p=<779,2174,1920>, v=<107,308,274>, a=<-8,-24,-19>
p=<1407,2080,-1148>, v=<199,293,-162>, a=<-22,-20,14>
p=<756,2555,-1660>, v=<108,365,-237>, a=<-9,-26,16>
p=<947,2694,-1614>, v=<134,385,-230>, a=<-6,-23,20>
p=<-467,2686,-1318>, v=<-65,385,-187>, a=<8,-24,11>
p=<-1745,2010,-734>, v=<-247,291,-100>, a=<15,-16,11>
p=<-2122,2324,-225>, v=<-303,330,-32>, a=<21,-23,6>
p=<-2100,-1040,238>, v=<-300,-154,34>, a=<24,13,-2>
p=<499,-123,-2992>, v=<71,-19,-426>, a=<-2,2,27>
p=<1108,606,-2708>, v=<161,79,-384>, a=<-10,-4,24>
p=<1020,-1999,-1485>, v=<145,-286,-211>, a=<-11,16,15>
p=<2961,1773,-477>, v=<426,253,-68>, a=<-32,-15,8>
p=<1080,-1409,-2768>, v=<157,-205,-395>, a=<-8,13,23>
p=<-2820,1025,-102>, v=<-404,142,-15>, a=<24,-12,2>
p=<-2206,1070,1743>, v=<-316,155,246>, a=<22,-10,-18>
p=<2020,-47,2201>, v=<285,-8,318>, a=<-20,-2,-26>
p=<-1015,-1884,1659>, v=<-139,-269,231>, a=<17,14,-16>
p=<-2307,-23,-2040>, v=<-323,-5,-299>, a=<19,0,28>
p=<-1086,-413,2876>, v=<-158,-55,410>, a=<10,0,-28>
p=<-2018,-1615,1955>, v=<-290,-230,282>, a=<24,11,-17>
p=<1959,-1556,-1800>, v=<279,-221,-257>, a=<-22,12,22>
p=<-1397,-2058,-1670>, v=<-199,-292,-239>, a=<12,21,13>
p=<2336,541,2059>, v=<337,76,299>, a=<-22,-2,-18>
p=<2821,786,-668>, v=<400,114,-92>, a=<-28,-7,9>
p=<-1149,76,-2164>, v=<-164,12,-307>, a=<16,1,18>
p=<2179,1193,1791>, v=<311,173,255>, a=<-20,-11,-17>
p=<-100,-73,-2909>, v=<-11,-14,-413>, a=<4,0,21>";

        public const string Day21 = @"../.. => ..#/#../.#.
#./.. => #../#../...
##/.. => ###/#.#/#..
.#/#. => ###/##./.#.
##/#. => .../.#./..#
##/## => ##./#.#/###
.../.../... => ##../.#../#.#./....
#../.../... => ..../##.#/...#/##.#
.#./.../... => ###./####/#.../#..#
##./.../... => ###./.##./...#/..##
#.#/.../... => .###/.##./#.../#.##
###/.../... => ##.#/#..#/#.#./#.##
.#./#../... => #.#./.###/#.../#.##
##./#../... => #.../####/#.##/....
..#/#../... => #.##/..#./...#/...#
#.#/#../... => #.##/####/.#.#/#.#.
.##/#../... => #.../##../##.#/.##.
###/#../... => ..../#.#./.###/#...
.../.#./... => .#.#/#..#/##../#.##
#../.#./... => ###./.###/.#.#/..#.
.#./.#./... => ..##/.##./..##/.#.#
##./.#./... => ..#./##../###./...#
#.#/.#./... => ..##/.##./.###/###.
###/.#./... => ..#./.###/###./#.##
.#./##./... => ###./..../.#../#...
##./##./... => .#.#/##../##.#/...#
..#/##./... => ##.#/.##./.###/..##
#.#/##./... => .###/..#./#.##/####
.##/##./... => ##.#/..#./..##/###.
###/##./... => ..../.#.#/.#../#...
.../#.#/... => ###./.#.#/.#../#.##
#../#.#/... => ####/#..#/..../....
.#./#.#/... => #.../..##/#.##/#.#.
##./#.#/... => #.#./###./##../#.#.
#.#/#.#/... => ...#/.##./.##./.#..
###/#.#/... => ..../.##./####/#.#.
.../###/... => .###/.#../.###/#.##
#../###/... => ..##/..##/.##./##..
.#./###/... => .#.#/..#./..##/##.#
##./###/... => ...#/#.##/#.#./##.#
#.#/###/... => #.##/.##./...#/###.
###/###/... => ##../...#/..##/####
..#/.../#.. => #.##/#.../.#../#.#.
#.#/.../#.. => .##./.##./.#.#/.##.
.##/.../#.. => .#.#/#.##/...#/##.#
###/.../#.. => ##../..#./...#/##..
.##/#../#.. => ##../..##/#..#/#..#
###/#../#.. => ##../..#./#.#./....
..#/.#./#.. => .##./##.#/##../####
#.#/.#./#.. => ####/...#/.#.#/..#.
.##/.#./#.. => .#.#/..#./##.#/.#..
###/.#./#.. => #.../#.##/..../##.#
.##/##./#.. => #.#./#.#./#.##/#.#.
###/##./#.. => ...#/###./.##./.#.#
#../..#/#.. => ####/####/..../.##.
.#./..#/#.. => #.##/...#/..#./####
##./..#/#.. => ..#./#.../..##/####
#.#/..#/#.. => #.../#.##/#.##/..##
.##/..#/#.. => ####/..../##../####
###/..#/#.. => ..../##.#/.##./####
#../#.#/#.. => ...#/..##/###./#..#
.#./#.#/#.. => #..#/..#./.###/##.#
##./#.#/#.. => ###./####/#.##/..#.
..#/#.#/#.. => ##../##.#/..##/.##.
#.#/#.#/#.. => .#.#/.##./#.../##.#
.##/#.#/#.. => .#.#/#..#/.##./..#.
###/#.#/#.. => ...#/.#../.##./##.#
#../.##/#.. => ###./##../#.#./####
.#./.##/#.. => .#../##../#.#./.#.#
##./.##/#.. => ##.#/.#../.#.#/####
#.#/.##/#.. => ####/.#.#/..../....
.##/.##/#.. => ####/##../#..#/####
###/.##/#.. => .###/##.#/.#../#.##
#../###/#.. => #..#/###./####/.#.#
.#./###/#.. => ..##/##../##.#/.#.#
##./###/#.. => #..#/.#../####/...#
..#/###/#.. => ##../##.#/...#/#..#
#.#/###/#.. => ..#./.##./#..#/....
.##/###/#.. => #..#/#.../..../.#..
###/###/#.. => ..#./#.##/.##./#...
.#./#.#/.#. => .#.#/.##./##.#/.##.
##./#.#/.#. => #..#/.###/.#.#/.##.
#.#/#.#/.#. => #.../##../#.../.###
###/#.#/.#. => ###./.###/###./....
.#./###/.#. => .#../####/...#/##..
##./###/.#. => ####/###./..../....
#.#/###/.#. => ...#/.###/..../####
###/###/.#. => ..../#.../..#./.###
#.#/..#/##. => #.#./#.../####/#.##
###/..#/##. => .#.#/#..#/.###/#...
.##/#.#/##. => ..##/..#./..../##..
###/#.#/##. => #.#./##.#/####/#..#
#.#/.##/##. => ..../.#../#.#./##.#
###/.##/##. => ..../..../.#../##.#
.##/###/##. => #.#./.###/#.#./#.##
###/###/##. => ##.#/##.#/.###/..#.
#.#/.../#.# => #..#/.#../#.../...#
###/.../#.# => ##../.#../##.#/..#.
###/#../#.# => ..##/#.#./####/.#..
#.#/.#./#.# => ...#/...#/#..#/#.#.
###/.#./#.# => ..../####/.##./.#.#
###/##./#.# => #..#/.#.#/..##/####
#.#/#.#/#.# => #.#./..#./...#/.#..
###/#.#/#.# => ...#/##.#/.###/.#..
#.#/###/#.# => .#.#/###./.#../.##.
###/###/#.# => ...#/.###/.#.#/###.
###/#.#/### => #.##/.#.#/...#/.#..
###/###/### => ..##/.#../#.#./.#..";
    }
}
