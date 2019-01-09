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
    }
}
