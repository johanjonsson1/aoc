﻿namespace AoC2021;

public static class Inputs
{
    public const string Day1 = @"137
138
139
140
143
146
147
149
155
156
159
153
163
169
175
180
183
184
206
219
226
233
231
232
234
231
234
231
234
232
230
235
225
237
245
254
263
275
288
290
291
292
316
334
343
346
359
354
352
374
377
378
391
409
419
427
433
437
411
416
435
442
438
440
443
459
460
466
467
468
467
470
488
493
504
505
506
517
523
526
525
532
541
558
559
561
563
565
582
589
595
586
571
603
607
621
634
642
646
648
651
685
702
707
729
738
741
736
737
761
763
765
769
772
774
779
795
809
835
841
836
845
848
849
874
878
880
881
889
890
915
932
936
945
946
966
965
968
980
987
989
993
994
996
997
1027
1028
1049
1047
1048
1047
1062
1057
1066
1071
1084
1093
1095
1098
1100
1104
1105
1117
1160
1165
1166
1184
1180
1181
1182
1202
1206
1204
1217
1227
1228
1248
1249
1258
1262
1267
1288
1285
1280
1286
1288
1303
1307
1308
1309
1338
1346
1357
1367
1368
1373
1386
1387
1389
1380
1407
1405
1419
1440
1465
1480
1485
1489
1490
1492
1497
1498
1497
1499
1500
1493
1503
1523
1530
1536
1544
1553
1569
1573
1574
1605
1613
1620
1628
1629
1632
1625
1626
1631
1630
1632
1633
1639
1655
1654
1670
1668
1673
1675
1676
1671
1673
1675
1677
1671
1669
1692
1695
1698
1701
1712
1711
1712
1715
1732
1728
1726
1742
1743
1744
1746
1739
1744
1757
1758
1760
1769
1772
1773
1782
1789
1794
1799
1828
1852
1856
1859
1866
1867
1868
1876
1877
1869
1874
1873
1901
1910
1912
1913
1919
1939
1940
1941
1948
1977
1976
1978
2011
2012
2015
2025
2035
2046
2040
2041
2062
2063
2064
2086
2104
2112
2111
2120
2121
2130
2139
2141
2154
2155
2157
2158
2185
2181
2183
2188
2189
2192
2197
2191
2200
2192
2220
2223
2231
2237
2246
2254
2245
2257
2258
2263
2268
2269
2281
2280
2284
2291
2328
2331
2313
2319
2321
2324
2327
2328
2346
2347
2346
2347
2348
2350
2353
2344
2335
2337
2339
2338
2342
2347
2350
2351
2356
2378
2379
2387
2386
2385
2384
2393
2407
2408
2409
2412
2413
2409
2422
2430
2431
2432
2457
2458
2459
2468
2472
2473
2480
2511
2493
2506
2514
2522
2524
2525
2530
2540
2527
2536
2546
2548
2552
2547
2552
2551
2569
2573
2590
2607
2626
2624
2641
2642
2643
2645
2666
2691
2702
2719
2734
2735
2743
2750
2769
2796
2797
2800
2804
2806
2820
2821
2822
2826
2834
2835
2836
2840
2841
2842
2838
2826
2827
2844
2843
2844
2857
2875
2877
2878
2908
2912
2913
2916
2921
2920
2923
2924
2925
2942
2943
2972
2984
2987
2999
3020
3014
3018
3017
3015
3016
3018
3021
2997
3000
2989
2981
2988
2989
2988
2989
2990
2993
2998
2999
3000
3007
3012
3013
3023
3022
3028
3063
3079
3085
3086
3085
3087
3097
3102
3103
3110
3114
3120
3136
3141
3163
3164
3166
3168
3179
3174
3175
3180
3196
3210
3188
3202
3204
3201
3207
3208
3217
3225
3231
3230
3231
3230
3274
3292
3296
3321
3351
3365
3367
3378
3381
3379
3380
3385
3383
3384
3393
3403
3404
3411
3426
3420
3422
3423
3440
3449
3460
3459
3460
3463
3464
3468
3492
3506
3513
3520
3525
3526
3529
3535
3553
3555
3556
3548
3563
3565
3568
3571
3572
3578
3583
3585
3586
3590
3602
3604
3610
3611
3612
3640
3649
3668
3658
3650
3652
3654
3657
3639
3640
3651
3639
3653
3655
3662
3683
3684
3686
3692
3693
3707
3717
3722
3735
3737
3743
3756
3753
3754
3756
3759
3760
3764
3766
3796
3800
3809
3817
3818
3819
3820
3799
3798
3801
3810
3811
3818
3819
3826
3833
3840
3842
3853
3851
3835
3836
3841
3846
3847
3852
3861
3864
3861
3869
3871
3872
3887
3889
3913
3928
3929
3937
3961
3966
3975
3998
3999
3994
3989
3965
3955
3959
3983
3994
3995
3996
3997
4000
4005
4004
4005
4012
4027
4007
4008
4011
4023
4037
4040
4062
4063
4066
4073
4078
4106
4113
4114
4126
4131
4126
4129
4164
4165
4176
4162
4172
4196
4200
4198
4199
4196
4205
4208
4220
4255
4252
4249
4259
4275
4281
4283
4286
4295
4296
4273
4271
4290
4291
4296
4302
4303
4315
4316
4317
4329
4330
4335
4336
4340
4341
4342
4314
4307
4309
4308
4313
4322
4319
4321
4318
4319
4322
4317
4318
4320
4324
4347
4355
4358
4363
4364
4375
4379
4378
4390
4399
4390
4395
4408
4425
4419
4430
4431
4437
4460
4470
4472
4473
4502
4494
4495
4509
4514
4513
4523
4527
4544
4573
4583
4584
4552
4586
4587
4598
4601
4607
4613
4607
4617
4649
4647
4642
4649
4659
4661
4651
4652
4673
4679
4684
4685
4686
4687
4689
4690
4696
4702
4710
4683
4694
4695
4696
4697
4698
4700
4698
4699
4701
4686
4688
4712
4713
4711
4729
4739
4742
4762
4763
4767
4773
4781
4785
4775
4776
4779
4777
4779
4780
4787
4773
4784
4789
4793
4809
4828
4830
4824
4827
4829
4830
4834
4842
4843
4844
4847
4848
4849
4866
4867
4868
4879
4880
4883
4897
4900
4904
4910
4922
4931
4932
4934
4935
4934
4936
4946
4947
4974
4978
4983
4984
4985
4992
4998
5007
5052
5059
5067
5072
5088
5087
5093
5114
5115
5118
5117
5118
5121
5127
5128
5132
5134
5135
5157
5151
5156
5160
5155
5151
5140
5141
5163
5158
5163
5166
5172
5176
5179
5180
5171
5174
5188
5190
5212
5213
5214
5215
5229
5234
5237
5244
5249
5250
5251
5255
5256
5258
5270
5272
5276
5292
5293
5303
5317
5325
5308
5310
5318
5324
5346
5356
5373
5370
5384
5385
5383
5387
5391
5398
5399
5413
5415
5416
5444
5443
5450
5444
5446
5447
5448
5465
5470
5455
5461
5441
5443
5452
5457
5460
5465
5466
5470
5473
5510
5515
5516
5517
5521
5519
5510
5524
5526
5531
5555
5529
5541
5543
5545
5549
5559
5572
5574
5601
5622
5631
5633
5659
5661
5669
5698
5701
5685
5682
5708
5707
5694
5695
5698
5699
5700
5711
5712
5720
5721
5723
5730
5723
5721
5729
5738
5739
5740
5741
5744
5747
5748
5750
5751
5761
5756
5761
5764
5768
5786
5798
5799
5808
5829
5840
5842
5834
5842
5843
5861
5863
5882
5898
5904
5909
5927
5931
5925
5927
5920
5921
5946
5954
5971
6002
6005
6001
6015
6018
6020
6030
6031
6032
6034
6035
6050
6051
6055
6059
6020
6014
6015
6011
5990
5991
5969
5970
5950
5951
5961
5962
5964
5970
5972
5977
5987
5989
5998
6001
6006
6009
6012
6017
6023
6028
6029
6030
6051
6053
6055
6056
6058
6082
6090
6094
6106
6108
6111
6128
6131
6150
6157
6158
6183
6180
6182
6191
6153
6152
6178
6174
6164
6167
6175
6187
6186
6187
6199
6204
6205
6210
6213
6214
6217
6228
6206
6212
6211
6210
6216
6221
6224
6226
6243
6245
6237
6238
6246
6247
6250
6256
6269
6260
6261
6266
6268
6271
6281
6279
6268
6229
6231
6233
6235
6241
6248
6250
6261
6263
6276
6286
6288
6291
6274
6273
6276
6285
6292
6297
6330
6331
6295
6311
6312
6325
6319
6321
6322
6325
6327
6340
6341
6350
6356
6357
6365
6370
6383
6382
6396
6394
6395
6403
6404
6399
6400
6409
6411
6414
6421
6424
6429
6430
6440
6441
6450
6455
6464
6481
6495
6474
6475
6476
6478
6482
6506
6524
6497
6490
6492
6508
6507
6511
6518
6519
6528
6554
6555
6562
6563
6571
6574
6564
6581
6582
6584
6585
6586
6587
6590
6617
6623
6653
6652
6636
6638
6640
6660
6663
6668
6673
6675
6679
6680
6683
6699
6698
6694
6701
6715
6697
6700
6706
6715
6702
6705
6707
6719
6720
6721
6722
6723
6727
6724
6725
6726
6732
6739
6741
6760
6771
6773
6772
6775
6783
6785
6791
6800
6808
6809
6810
6811
6793
6797
6799
6801
6805
6806
6833
6839
6840
6845
6846
6856
6869
6861
6878
6881
6903
6914
6915
6931
6934
6936
6938
6940
6954
6952
6953
6961
6951
6953
6961
6963
6968
6976
6977
6980
6986
6995
6996
7006
7011
6991
6992
6996
7002
7025
7029
7041
7040
7041
7033
7036
7038
7042
7044
7058
7064
7071
7076
7078
7079
7091
7090
7086
7088
7105
7140
7143
7132
7146
7137
7139
7141
7142
7151
7153
7154
7160
7162
7164
7167
7171
7183
7205
7218
7220
7252
7264
7270
7274
7275
7285
7286
7289
7311
7299
7301
7325
7331
7341
7343
7348
7380
7388
7390
7392
7400
7412
7414
7419
7448
7430
7436
7450
7451
7484
7493
7503
7494
7495
7521
7507
7514
7517
7519
7532
7558
7574
7575
7593
7595
7620
7636
7643
7644
7634
7637
7639
7650
7651
7652
7666
7673
7690
7693
7702
7703
7735
7736
7727
7743
7745
7763
7764
7734
7735
7739
7743
7744
7750
7751
7754
7759
7765
7770
7804
7808
7790
7791
7793
7794
7795
7796
7798
7808
7775
7776
7777
7799
7800
7803
7817
7818
7834
7832
7834
7843
7849
7850
7853
7856
7859
7861
7862
7864
7860
7859
7861
7862
7863
7862
7867
7853
7854
7860
7855
7859
7860
7865
7845
7855
7858
7881
7882
7899
7902
7930
7931
7932
7933
7935
7938
7941
7953
7954
7952
7965
7967
7976
7977
7980
7982
7991
8001
8017
8018
8036
8037
8047
8049
8051
8041
8043
8044
8045
8046
8047
8048
8054
8055
8082
8083
8084
8093
8094
8116
8117
8118
8124
8125
8142
8145
8150
8154
8156
8175
8176
8184
8190
8184
8200
8214
8236
8237
8253
8264
8271
8280
8282
8284
8296
8297
8299
8304
8329
8341
8345
8358
8359
8366
8370
8368
8374
8377
8378
8379
8390
8391
8394
8399
8405
8406
8405
8404
8397
8400
8406
8426
8427
8451
8457
8458
8459
8470
8448
8450
8452
8474
8494
8495
8500
8499
8496
8500
8501
8502
8503
8530
8541
8545
8547
8566
8593
8596
8597
8596
8609
8612
8627
8631
8623
8624
8626
8641
8642
8644
8646
8651
8654
8657
8666
8673
8674
8687
8707
8715
8722
8711
8712
8715
8712
8719
8722
8719
8720
8722
8723
8727
8729
8731
8732
8733
8737
8743
8741
8742
8747
8749
8753
8766
8771
8776
8784
8789
8806
8816
8840
8847
8858
8859
8860
8862
8863
8866
8867
8873
8884
8882
8884
8890
8858
8861
8862
8860
8861
8879
8900
8928
8940
8942
8940
8961
8962
8969
8988
8993
8998
9006
9011
9013
9037
9050
9060
9067
9068
9090
9108
9113
9116
9137
9138
9115
9116
9119
9125
9126
9124
9151
9161
9170
9173
9182
9187
9202
9203
9221
9223
9222
9223
9234
9235
9249
9268
9260
9284
9302
9305
9324
9325
9326
9320
9315
9317
9319
9320
9336
9347
9354
9371
9376
9386
9387
9397
9396
9397
9399
9404
9405
9407
9423
9424
9432
9434
9435
9436
9438
9448
9456
9457
9458
9457
9448
9449
9453
9454
9460
9469
9458
9459
9469
9477
9481
9482
9488
9496
9497
9498
9500
9501
9518
9520
9523
9539
9537
9548
9555
9568
9576
9579
9589
9591
9590
9594
9595
9596
9598
9605
9602
9604
9600
9613
9610
9616
9638
9639
9640
9648
9653
9667
9679
9680
9681
9677
9679
9680
9681
9706
9707
9709
9710
9714
9719
9736
9739
9762
9753
9770
9739
9752
9753
9752
9753
9762
9764
9765
9766
9769
9774
9773
9782
9792
9793
9798
9809
9810
9809
9806
9807
9806
9808
9810
9813
9818
9816
9832
9833
9831
9851
9839
9847
9849
9850
9851
9853
9854
9858
9862
9865
9872
9875
9881
9883
9884
9885
9898
9903
9904
9899
9906
9907
9909
9939
9955
9956
9957
9963
9964
9965
9969
9972
9980
10002
10003
10004
10007
10008
10015
10032
10047
10060
10066
10071
10078
10079
10083
10095
10096
10097
10090
10091
10088
10085
10095
10096
10099
10089
10108
10109
10110
10107
10112
10119
10135
10133
10121
10130
10125
10127
10128
10131
10121
10134
10137
10139
10179
10180
10182
10194
";

    public const string Day2 = @"forward 7
down 8
forward 5
down 3
forward 6
down 9
down 2
forward 1
down 2
down 9
forward 8
down 8
up 6
forward 8
down 3
forward 9
up 3
up 7
forward 6
up 3
down 5
up 9
down 6
up 1
forward 7
up 2
forward 3
forward 3
up 9
down 9
up 4
forward 9
down 8
up 1
forward 8
forward 6
up 8
down 5
up 7
up 5
up 5
up 4
up 3
forward 8
forward 9
down 9
forward 7
forward 1
forward 2
forward 4
up 2
forward 4
up 3
down 7
forward 6
down 9
down 3
down 4
forward 4
forward 8
forward 9
down 8
forward 3
forward 3
forward 7
forward 3
down 7
forward 6
down 8
forward 6
up 3
forward 9
down 7
down 6
down 6
down 5
forward 7
down 9
down 9
forward 6
forward 5
forward 6
up 3
forward 1
forward 8
down 5
up 2
up 7
up 9
forward 5
forward 3
down 6
forward 8
forward 6
down 8
down 2
forward 5
down 8
forward 7
down 6
down 2
forward 3
down 6
up 3
down 4
down 5
down 6
forward 9
down 8
down 9
forward 3
up 5
up 2
up 6
forward 3
down 4
down 6
forward 7
forward 9
up 3
up 8
up 4
down 4
up 9
up 9
down 1
forward 6
down 8
forward 4
down 1
forward 8
up 1
up 4
forward 8
forward 8
down 9
forward 6
forward 4
forward 6
forward 7
down 2
down 6
forward 1
forward 8
up 4
forward 3
forward 5
down 2
forward 5
forward 6
forward 9
forward 3
down 6
down 5
down 1
forward 2
forward 7
forward 2
forward 2
down 3
down 5
forward 2
forward 7
forward 6
forward 8
up 8
forward 9
down 4
down 7
forward 4
down 9
up 1
forward 5
forward 5
up 3
forward 3
up 2
forward 4
down 6
down 6
down 5
forward 5
forward 9
down 8
forward 9
forward 5
forward 4
up 4
forward 9
forward 2
forward 2
up 8
up 4
forward 8
forward 3
forward 6
forward 1
up 8
forward 2
forward 6
up 6
down 5
up 9
forward 1
down 5
forward 5
down 1
down 6
up 3
up 4
down 3
forward 3
down 2
forward 3
down 1
down 6
forward 6
down 7
up 2
forward 2
forward 9
forward 7
up 5
up 8
up 8
down 4
up 5
forward 6
up 1
forward 4
forward 5
up 4
up 8
up 2
down 4
up 3
down 2
forward 1
down 8
forward 5
up 2
forward 7
down 4
down 5
forward 4
forward 7
down 9
up 9
forward 2
up 3
up 8
up 3
up 3
down 3
forward 1
forward 2
forward 6
forward 3
up 4
forward 1
down 2
forward 4
down 9
forward 5
down 6
down 5
forward 9
forward 3
forward 9
forward 3
forward 8
down 3
forward 5
down 1
forward 7
forward 6
down 7
down 8
up 9
down 2
forward 7
down 9
forward 5
forward 3
down 1
forward 6
down 6
up 8
down 6
up 9
forward 2
down 1
forward 2
down 8
down 2
down 6
up 9
down 3
down 5
up 4
down 4
down 3
up 2
forward 2
down 1
down 2
forward 8
forward 3
down 6
forward 9
up 5
down 5
down 1
forward 1
down 3
down 7
down 5
forward 6
up 4
down 2
forward 8
down 9
up 8
forward 9
forward 5
down 6
up 4
forward 1
forward 2
forward 5
up 3
up 2
up 8
up 6
forward 9
down 3
down 7
down 7
up 5
forward 1
down 3
forward 9
down 5
up 6
down 4
up 5
up 4
up 9
forward 2
up 7
down 7
up 3
up 1
forward 6
down 1
down 9
down 9
down 4
forward 1
forward 6
up 9
down 3
up 8
forward 7
forward 3
down 6
up 9
forward 3
up 9
down 3
up 6
down 4
up 3
down 2
forward 9
forward 2
down 1
forward 4
down 5
up 4
forward 6
down 4
down 8
forward 4
down 8
down 9
up 4
up 7
down 7
forward 6
up 9
down 9
down 7
forward 3
up 4
up 8
down 2
down 5
down 9
forward 3
forward 2
up 6
down 8
forward 2
forward 7
up 4
forward 4
forward 7
forward 7
forward 3
down 2
down 6
up 6
down 8
down 4
forward 2
down 2
forward 2
forward 7
forward 2
down 1
down 1
down 3
down 3
forward 4
down 9
forward 2
forward 4
forward 1
forward 7
forward 3
down 1
down 7
forward 9
forward 7
up 2
down 5
forward 4
down 8
down 8
forward 5
down 3
up 6
down 3
forward 3
forward 8
up 9
up 8
up 7
forward 4
forward 6
forward 6
down 6
forward 1
up 8
down 6
forward 1
down 3
down 2
up 7
forward 5
down 2
down 6
down 8
up 2
forward 6
forward 3
forward 9
up 8
up 2
down 4
forward 3
down 9
forward 9
forward 2
down 7
forward 6
up 4
forward 1
down 5
forward 7
up 6
down 2
up 2
forward 6
down 6
forward 1
forward 5
down 8
down 2
up 8
forward 2
forward 2
down 4
down 9
forward 9
down 9
forward 5
down 6
down 8
forward 4
down 8
up 8
forward 5
forward 8
up 1
up 3
forward 3
down 7
down 8
up 3
forward 1
up 2
up 9
down 8
up 5
forward 7
forward 7
down 7
down 3
forward 1
forward 3
forward 7
down 8
forward 7
forward 6
down 5
down 8
down 1
forward 4
down 5
down 9
forward 1
forward 3
forward 3
up 2
forward 5
down 3
forward 2
down 7
up 7
up 7
forward 5
up 1
down 8
up 4
up 6
forward 4
forward 4
forward 4
down 7
down 9
down 7
forward 8
down 6
down 3
forward 5
down 6
forward 5
forward 3
forward 9
forward 9
up 6
down 9
up 4
up 1
down 5
down 2
up 9
forward 9
forward 8
up 5
down 6
up 6
down 4
down 6
up 3
forward 2
up 7
up 1
up 4
down 7
up 2
forward 7
up 9
up 3
forward 9
forward 6
forward 1
up 5
down 4
down 3
up 3
forward 5
down 3
down 4
up 4
up 9
up 6
forward 5
down 9
down 7
forward 4
forward 9
down 9
down 9
down 8
forward 1
up 6
down 7
down 1
down 3
down 3
forward 1
forward 8
up 1
forward 2
down 2
down 5
down 9
forward 1
forward 4
down 7
forward 1
down 1
down 8
down 3
forward 3
down 9
up 9
down 7
down 1
down 2
down 2
forward 1
up 3
up 1
down 5
forward 5
down 4
down 4
down 3
up 9
forward 9
down 3
forward 6
forward 1
forward 2
forward 8
forward 9
down 3
down 5
up 7
down 4
forward 8
up 9
forward 9
forward 2
down 2
forward 3
down 4
forward 2
forward 6
forward 9
up 8
down 1
down 4
up 9
forward 2
down 9
forward 4
down 7
up 5
down 2
forward 5
forward 7
forward 9
forward 1
down 1
forward 1
down 3
forward 5
up 8
down 8
forward 1
down 5
up 3
down 5
forward 3
forward 7
forward 2
down 2
forward 7
forward 4
forward 4
down 3
forward 5
down 5
down 9
up 4
down 6
down 5
forward 5
forward 9
down 9
forward 9
down 6
forward 4
down 5
down 8
up 9
down 7
up 7
forward 4
down 6
forward 5
forward 4
up 7
forward 9
forward 7
up 7
down 8
down 1
forward 3
down 3
down 6
up 6
up 5
up 8
down 7
forward 6
down 9
forward 9
forward 6
up 7
down 4
down 5
down 8
forward 9
forward 8
forward 2
forward 4
up 6
down 7
forward 8
down 9
forward 3
forward 1
forward 4
forward 8
down 4
down 1
forward 5
down 7
down 3
up 2
up 5
down 6
forward 5
down 9
down 3
forward 8
up 5
down 6
forward 3
down 5
forward 1
down 3
up 3
forward 9
forward 9
forward 8
down 4
down 1
forward 7
forward 7
down 9
up 2
forward 2
forward 2
forward 1
forward 2
down 2
down 7
forward 5
forward 3
forward 2
down 1
down 6
up 4
down 3
forward 2
down 2
down 2
forward 9
up 8
forward 9
down 8
up 8
down 8
down 1
forward 9
up 7
up 6
down 3
forward 5
up 9
forward 5
forward 8
up 3
forward 8
forward 9
forward 2
forward 4
down 7
forward 1
forward 1
down 7
forward 8
forward 4
forward 2
forward 7
forward 6
forward 5
down 8
down 9
up 9
forward 1
forward 4
down 1
forward 6
up 4
forward 8
forward 6
up 5
forward 9
down 8
down 4
down 9
forward 2
up 4
down 2
forward 4
down 9
forward 3
down 8
forward 7
forward 3
down 7
down 7
down 8
forward 8
down 2
forward 7
up 7
down 5
down 7
down 5
up 9
up 8
down 1
down 9
forward 7
up 2
forward 1
forward 3
forward 8
down 5
forward 7
up 6
forward 5
up 5
forward 4
down 6
down 4
forward 1
up 1
forward 2
forward 2
forward 8
forward 7
down 4
down 1
forward 5
forward 9
up 4
down 4
up 9
up 4
down 8
down 7
forward 1
down 8
forward 9
down 4
forward 5
forward 2
down 1
forward 7
forward 4
down 9
forward 8
down 1
forward 7
forward 6
up 9
forward 6
forward 6
forward 8
forward 3
up 1
forward 9
down 3
down 9
down 8
forward 5
down 7
forward 6
forward 1
up 1
up 3
up 7
forward 1
forward 8
forward 6
forward 9
down 6
forward 9
down 2
up 2
down 7
down 7
forward 8
down 2
down 3
forward 7
forward 5
down 3
down 1
up 8
up 6
down 3
forward 1
forward 6
forward 4
forward 7
down 3
down 9
up 6
down 7
forward 9
forward 2
forward 7
down 2
down 8
down 1
down 9
up 8
forward 3
down 9
forward 6
down 4
forward 1
up 8
up 4
down 5
forward 2
forward 9
forward 5
forward 6
down 4
up 4
down 6
down 8
down 2
down 7
down 2
up 8
forward 4
down 7
forward 2
down 5
forward 3
forward 1
down 2
up 3
down 2
forward 1
forward 2
down 6
down 2
down 9
forward 9
down 1
up 2
down 4
forward 1
forward 6
forward 8
forward 3
";

    public const string Day3 = @"110011101111
011110010111
101010111001
110011100110
110010000101
000111001111
001111110011
100000111010
101010000110
001000100011
110000000100
000100110000
010010101110
101110111101
100000100111
111011010111
001101010010
010010001111
010101100001
111001101101
110110000011
000110111111
111111100010
110010101011
010011100100
110011010010
100001111010
000101000110
110001000111
110110000001
101011010110
101001011010
100101000110
101010110001
111000110110
111000001111
010111101111
000001001011
000001111101
000111010101
110101111110
110000100101
011101110101
011101000000
111011100101
011100001101
000010100001
010010010100
001010100110
001111110110
111110101001
000010101101
100111000100
000001110000
011010110011
111111110111
011100010011
010001100101
000100110101
101101001111
001000011101
101100000000
000100101000
100100010010
111010011011
101010001010
110111111100
010111000001
010110111010
001011110110
100010001100
010000000011
101101101001
011110101101
101101010101
011011101110
001110110100
110100101000
101000000101
000101100010
100000111111
110100101011
010011110110
011001100110
011000100010
100110001101
010011110010
010011010010
111001110011
001010101100
001011100111
001101110011
110011101011
100001100110
011011101000
001001011100
110000110110
111100010010
011110110100
110000111000
110000001100
101110111011
110010111001
100001010110
011111110110
001101010000
101110110010
011101001101
011100001001
011110101111
010000101011
101110111111
000010100011
001010110010
111101111011
000101101010
111011101011
101001000001
100010100101
100110100010
101001111011
010110001111
010001000100
100101001111
100100110101
011010101110
111100001000
010000110001
000101000100
100011011011
101101010111
011110101000
011011100110
010111101001
001110000101
100100100011
010001110011
000111101111
001100011000
010100010011
110000100011
000010010001
000101110111
101011011101
101001111000
011101111010
111011000011
110111100101
000110111010
100101011110
000010000001
010110011111
011011000100
101001111100
101101101010
100011100111
001100100101
111010101101
010010010101
110001101100
011000100101
011010100010
010110010001
100101011010
001011100001
000100010001
110001100000
001011001100
110111111001
100110110000
001110101001
100001001101
101111101101
101010001110
000010011000
010011101100
101000110100
010001001110
000111100110
010010011100
011011111100
011000110110
101000011110
110111011001
111011000000
101000101111
011110100111
101000011010
011100000110
110100001000
010101100011
100110001010
001100111101
101100111111
000000100101
000110010001
000010101011
111100000001
101011001000
010100111111
010001010011
010001010100
010000100001
110101001011
000010001101
101110011001
100010101100
110000011111
100111010111
010100000110
000000100010
111001000100
000010110111
111010000100
101001010110
110000000010
001110000001
111001100001
001001001011
000111111000
000001101000
001010100011
011110010011
011110110101
101010001011
110110110011
001100010011
001011000011
100011011010
101001110011
111011111111
011100101110
101101101111
011001000000
100110011001
111011000100
001010110001
010000111011
101101111010
010001111111
001010101110
000111011111
100010100011
011001100101
010010000000
110001101011
000010010000
011001110010
011111111111
000100010101
000001010001
101111110010
010100001010
001100101110
010010101001
100010000110
100110010001
011001111100
000000111011
100011101000
100110101101
110111001110
110101001100
101101011110
100100111101
101000100101
011010011101
010011110011
101110111000
110000010110
101110000110
001001100110
000001001010
001111011001
110100000011
101011010011
111010101001
000100111000
011001010100
001101101011
011110011001
000100101001
000010001000
011101100100
110000001000
010111000100
101101111100
110100011110
001111000100
001011000110
011110011010
010101100111
110111010110
001001011101
011111100100
110001000101
001101011000
001001110001
000001100101
111100010001
111100100110
001000001000
010111110010
011011111011
101101111011
100100000010
001010001000
011100110011
010101000101
101110001010
001001001101
110011010101
000101010101
100101010100
101001101000
000111011001
001110110101
000011100101
001100101111
001110010101
000111010100
110001110111
101110010100
010110111111
010110111001
101011111001
101101100010
100010110000
111110000011
011101011010
010101101110
100000001101
111001010001
101010101101
111110001110
010101010000
011100001010
011011110100
101001001111
011110110010
101101000000
111000101101
001001111000
011000010111
001000000011
010111110111
111011100001
010110011000
110010000100
010001101011
000110000010
100011100100
010100101111
110011001111
100001111110
100000011110
000001010010
001001010100
000110100110
010010011101
101000000100
010010111000
000001000010
110010100101
101010000100
111110101101
100000110010
100110110001
001011001101
110111011111
101111011000
111010110001
101111100111
110100111100
110000000001
000010100110
110000010101
010101111000
001001110101
010101001000
010011011101
100111100010
111010011000
011001000110
010101110111
101111100001
101110101100
101010010110
101100001001
110111101101
100101001100
111111010010
010010100010
111100010111
000101011100
100100101100
100111011100
100000000010
110110001100
011000110010
011000010101
101110011110
101001110000
001000001010
001101101001
011001000111
010010100001
011100100100
001000111001
110111111110
011100101000
110101100010
111110110010
100001110111
101011110101
001101010011
001000110100
001000110010
110101111010
101010010011
110111010111
001001011110
010110101011
100100101101
000000001100
001111101010
000000000000
110011010011
101010111101
011010000000
110111000101
111000010111
101100000110
011001101110
100001100011
000110000110
110010000010
100011101111
011010110001
101111100110
111110000101
000100110111
101111000010
011111001010
000110111000
101011100101
111100011011
111000011011
011001100001
000110001110
101000111010
011000110011
001101000011
010011100000
011101001110
001010100000
101111110011
100111111010
001110010010
111000110001
101110001000
011010110000
100011110110
010100101001
000011111101
111000000001
001001011000
000110000000
011001010110
111001101010
101001011000
011000010011
001010101101
010100010000
111111000010
101001001011
101000111001
010110110010
111010110100
110100100100
001000011000
011011011000
011000111110
010010010001
001010010000
100100001110
110101010000
011011010000
011011100000
100010010010
001000001001
111011011101
010110010011
111111101100
100111011011
010010111010
001101101110
010000011111
111011000110
111000011100
111100110000
111100101011
010100000100
001111111100
000111100111
100110001111
001111001100
000010001001
101011100111
110010010100
011010001011
011100111100
010101011111
110010110000
110110100010
011001110000
010011111000
001001001001
101110010011
000111110100
100110000100
011100101011
000110001000
001111100101
000111000000
101110100011
000100000011
111111100011
101011101001
010000111101
011110111100
110100111011
110110011001
101111110110
011000100001
101100111011
110010111011
001101011101
110010110001
000000101011
111011110101
011000010110
110011110010
011111011000
010111100101
110111111101
000001101001
011111110000
101000111101
011010000100
110000010100
110101101111
111000110011
001100001111
111101010110
001000111111
000101000101
000000101100
000111011011
010110000011
001111000101
111000001000
001001101100
011011110111
001000101100
111011001001
010001100100
011011100010
101111010011
101111010101
100100101110
111011011111
010100011011
000000000110
010011101001
011001110101
110010101110
011100011001
110001101110
001111010100
000011001100
100010010001
101011110100
000111010111
000101101001
111001101000
000110110001
010110111110
101011000101
110000000111
010110011010
001101000000
101111001100
001000100000
000101110010
111010111001
000110011110
011011100101
001101111110
000010010100
101001001100
000010010110
000010010101
011000000110
000111000011
101010011100
111100001110
011000011010
001110001001
101010111100
101111001110
011100010010
011110001000
111011110001
101100110011
010000000100
010001011010
101111101010
100101101011
110011011010
101011010001
101100110010
000111101000
101011100011
100010010110
111001110101
100011111011
101011010100
111100110001
001011111111
010000001111
011111101111
001011001011
000111001110
101111000111
110001111010
100001100111
110110101110
110100010000
110101010110
101101000100
000101100111
001110111101
110100100000
011000101000
010000001001
001101001010
101111001000
100001110110
111110100011
110011111010
101100011100
011000100000
011111111101
101101101100
111100110011
010011101010
011010111101
000100010111
101001011101
110111000111
011101100001
111101000010
000100011010
010111010010
000011110010
010001110100
011100110101
011001100010
010100001100
000001110101
001111100001
001110000110
100101110000
000100100000
101100111101
001100011010
011011011010
011101100110
001101001000
001001010111
000001100000
100110001000
010010111111
101110100010
001101110101
011101010100
101001010111
111100111101
101110100101
110110110110
011011100011
000111010001
100000011100
000111111101
111111011101
111000100110
001000011011
000101001111
011101010101
100100010111
111101100100
011100001100
101001001101
001101001001
001111000111
001100010101
000010111111
011001100100
111100100010
010100100011
001011111000
110100101111
011010010000
101011000011
100100110010
010111001101
101011010111
010000110010
011111101000
001000000111
101011000110
001111101011
000001101110
000100011111
110100010010
010011101110
001111011101
010100011100
101101001000
101010000101
010111010000
001100001101
011111011101
101101100101
010111010111
001000010000
111100100111
011010001000
111111001000
100010100001
010010010111
001110011100
010111011011
111000111000
111100001010
100100011111
110010100100
101010001001
110011100111
110101000101
000011100001
100111011111
110011011011
101000010110
110010111111
111000001011
111001000111
111101101111
110000100100
011011110000
010000100010
000011010010
000000011100
100110000010
110110111101
010010001011
000010111100
100000010110
110010101010
110001000110
000110101110
000010100000
011111000001
100010011001
111111101010
001001111011
101111010110
010010110000
111000010010
111011010110
010001111000
011100000101
001001101000
110101101001
110010101000
111111000101
101000010111
111101010011
101110101010
001000101000
001101111111
111100111111
110011000001
011000111001
111000000011
111110011110
011101000001
001111110000
000000000010
011011001101
110000001101
000001110111
011000111111
001101100110
100000011000
010100001110
011100010100
011111011100
100100011000
110011001011
111111011010
101111010100
110101010101
011110011011
111100101101
010001010000
101010101010
101101101110
010101101001
010101011110
110001000000
101101111001
100011101110
001101010110
100111101010
011010111010
110010100010
010100111000
110010110100
010011000110
110010111000
111010001001
000000111110
110101010100
110010001001
110101011000
110111000001
000110110100
110010010110
011000011100
100011001001
111000111011
001100100111
001111101000
100100000001
000111001101
000000101111
000111110111
100000000101
010111011100
011101100111
011111000101
010010011110
000001110110
111001110010
111000011101
111101110010
110110010011
000010111110
010011101000
111010011100
111011001010
101011001011
110000000011
101000010010
110100110011
100101010111
101101110100
010001000001
111001001011
011011010110
110100010111
111000011010
000100011011
101000011011
001010110011
100110111000
010001011111
111101111110
111100001100
010011011011
101101110000
111001010101
010101011100
011001011110
001000000110
010011011000
000000001001
010110100101
110101101010
011100011010
101101011100
100000111100
100111100000
111001111000
000110011111
010110100000
000010011100
110101001110
000001001001
011010010001
010101000010
001011101011
110001000011
110111100001
110101011010
101001111110
000001111001
001100110010
110000101001
000111000001
011000000111
100010101110
011111001110
001111111111
011111010001
000111110101
100010010100
111100000010
001011111001
100101111111
101111110100
111101010100
011100011101
111011001100
010111000011
010011010100
110011000100
000011101111
100111111111
100010001000
111101010001
111101001011
101100000010
011010111001
101101001101
100011110100
111101111111
011110010001
001011001001
100000011001
101011011010
011100101100
111100100000
100000000001
010000011011
101010011000
111101101000
101011001101
011111000111
100010110011
001100110100
000111010000
100101101100
010011100001
010101001111
011101010001
100011000011
010101100100
111111010001
000011111100
111100101000
100100010011
101000001000
110010000110
010101010011
000110011010
110010010101
001101011010
101100010111
100010011100
101001101010
100100000110
100101111101
011001001101
001101001111
011110001111
000101011010
111101001100
001100010001
101100001100
011001000001
011101110010
001011001110
100101110001
111111110001
001100010110
101001010100
001011111010
000011001001
000101011000
000111011000
010000010101
101010110101
010101000000
100010110101
111110010001
110010100001
000111010110
";
}