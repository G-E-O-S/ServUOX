using System;

namespace Server.Items
{
    public class TheFellowshipHouse : BlackthornBaseAddon
    {
        public static TheFellowshipHouse InstanceTram { get; set; }
        public static TheFellowshipHouse InstanceFel { get; set; }

        private static int[,] m_AddOnSimpleComponents = new int[,]
        {
              {3314, 8, -8, 19}, {3314, 8, -4, 18}, {2147, -2, 6, 11}// 1	2	3	
			, {2147, -2, 6, 17}, {2147, -2, 6, 23}, {2147, -1, 6, 11}// 4	5	6	
			, {2147, -1, 6, 17}, {2147, -1, 6, 23}, {2147, 0, 6, 11}// 7	8	9	
			, {2147, 1, 6, 11}, {2147, 2, 6, 11}, {2147, 3, 6, 11}// 10	11	12	
			, {2147, 0, 6, 17}, {2147, 0, 6, 23}, {2147, 1, 6, 17}// 13	14	15	
			, {2147, 1, 6, 23}, {2147, 2, 6, 17}, {2147, 3, 6, 17}// 16	17	18	
			, {2147, 2, 6, 23}, {2147, 3, 6, 23}, {1872, -5, 6, 27}// 19	20	21	
			, {1872, -6, 6, 27}, {1872, -4, 6, 27}, {1872, -3, 6, 27}// 22	23	24	
			, {1872, -2, 6, 27}, {1872, -1, 6, 27}, {1872, 1, 6, 27}// 25	26	27	
			, {1872, 2, 6, 27}, {1872, 3, 6, 27}, {1872, 0, 6, 27}// 28	29	30	
			, {1872, -6, 6, 12}, {1872, -5, 6, 12}, {1872, -4, 6, 12}// 31	32	33	
			, {1880, -7, 7, 26}, {1431, -1, 6, 61}, {1431, 0, 6, 64}// 34	35	36	
			, {1431, 1, 6, 67}, {1430, 2, 6, 67}, {1430, 3, 6, 64}// 37	38	39	
			, {2147, 4, 6, 11}, {2147, 5, 6, 11}, {2147, 4, 6, 17}// 40	41	42	
			, {2147, 5, 6, 17}, {2147, 4, 6, 23}, {2147, 5, 6, 23}// 43	44	45	
			, {2146, 6, 6, 11}, {2146, 6, 6, 17}, {2146, 6, 6, 23}// 46	47	48	
			, {1872, 4, 6, 27}, {1872, 5, 6, 27}, {1872, 6, 6, 27}// 49	50	51	
			, {1430, 4, 6, 61}, {3309, 6, 7, 10}, {11515, 1, 7, 9}// 52	53	54	
			, {3310, 5, 7, 6}, {11516, 5, 7, 9}, {1873, -6, 11, 8}// 55	56	57	
			, {1873, -5, 11, 8}, {1873, -4, 11, 8}, {1873, -3, 11, 8}// 58	59	60	
			, {1872, -3, 8, 6}, {1872, -3, 9, 6}, {1872, -3, 10, 7}// 61	62	63	
			, {1872, -3, 9, 11}, {1872, -3, 8, 11}, {1872, -3, 8, 16}// 64	65	66	
			, {1873, -3, 8, 21}, {1873, -3, 9, 16}, {1873, -3, 10, 12}// 67	68	69	
			, {1872, -3, 7, 6}, {1872, -3, 7, 11}, {1872, -3, 7, 16}// 70	71	72	
			, {1872, -3, 7, 21}, {3309, 2, 7, 7}, {3309, 3, 7, 9}// 73	74	75	
			, {3310, -2, 7, 14}, {11515, -1, 7, 11}, {1872, -4, 8, 6}// 76	77	79	
			, {1872, -4, 9, 6}, {1872, -4, 10, 7}, {1872, -4, 9, 11}// 80	81	82	
			, {1872, -4, 8, 11}, {1872, -4, 8, 16}, {1873, -4, 8, 21}// 83	84	85	
			, {1873, -4, 9, 16}, {1873, -4, 10, 12}, {1872, -4, 7, 6}// 86	87	88	
			, {1872, -4, 7, 11}, {1872, -4, 7, 16}, {1872, -4, 7, 21}// 89	90	91	
			, {1873, -4, 7, 26}, {1872, -5, 8, 6}, {1872, -5, 9, 6}// 92	93	94	
			, {1872, -5, 10, 7}, {1872, -5, 9, 11}, {1872, -5, 8, 11}// 95	96	97	
			, {1872, -5, 8, 16}, {1873, -5, 8, 21}, {1872, -6, 8, 6}// 98	99	101	
			, {1873, -5, 9, 16}, {1873, -5, 10, 12}, {1872, -5, 7, 6}// 102	103	104	
			, {1872, -5, 7, 11}, {1872, -5, 7, 16}, {1872, -5, 7, 21}// 105	106	107	
			, {1873, -5, 7, 26}, {41374, 0, 7, 7}, {3309, 4, 7, 7}// 108	109	110	
			, {1873, -6, 7, 26}, {1873, -6, 8, 21}, {1873, -6, 10, 12}// 112	113	114	
			, {1872, -6, 7, 11}, {1872, -6, 10, 7}, {1873, -6, 9, 16}// 115	116	117	
			, {1872, -6, 7, 16}, {1872, -6, 8, 11}, {1872, -6, 7, 21}// 118	119	120	
			, {1872, -6, 8, 16}, {1872, -6, 9, 6}, {41254, 0, 8, 6}// 121	122	123	
			, {1873, -3, 7, 26}, {41374, 1, 7, 4}, {1872, -6, 9, 11}// 124	125	126	
			, {1872, -6, 7, 6}, {1872, -6, -10, 27}, {1872, -6, -9, 27}// 127	135	136	
			, {1872, -6, -8, 27}, {1872, -6, -7, 27}, {1872, -5, -10, 27}// 137	138	139	
			, {1872, -5, -9, 27}, {1872, -5, -8, 27}, {1872, -5, -7, 27}// 140	141	142	
			, {1872, -4, -10, 27}, {1872, -4, -9, 27}, {1872, -4, -8, 27}// 143	144	145	
			, {1872, -4, -7, 27}, {1872, -3, -10, 27}, {1872, -3, -9, 27}// 146	147	148	
			, {1872, -3, -8, 27}, {1872, -3, -7, 27}, {1872, -2, -10, 27}// 149	150	151	
			, {1872, -2, -9, 27}, {1872, -2, -8, 27}, {1872, -2, -7, 27}// 152	153	154	
			, {1872, -1, -10, 27}, {1872, -1, -9, 27}, {1872, -1, -8, 27}// 155	156	157	
			, {1872, -1, -7, 27}, {1872, 0, -10, 27}, {1872, 0, -9, 27}// 158	159	160	
			, {1872, 0, -8, 27}, {1872, 0, -7, 27}, {1872, 1, -10, 27}// 161	162	163	
			, {1872, 1, -9, 27}, {1872, 1, -8, 27}, {1872, 1, -7, 27}// 164	165	166	
			, {1872, 2, -10, 27}, {1872, 2, -9, 27}, {1872, 2, -8, 27}// 167	168	169	
			, {1872, 2, -7, 27}, {1872, 3, -10, 27}, {1872, 3, -9, 27}// 170	171	172	
			, {1872, 3, -8, 27}, {1872, 3, -7, 27}, {28, 3, -10, 32}// 173	174	175	
			, {28, 2, -10, 32}, {28, 1, -10, 32}, {28, 0, -10, 32}// 176	177	178	
			, {28, -1, -10, 32}, {28, -2, -10, 32}, {27, -3, -9, 32}// 179	180	181	
			, {27, -3, -8, 32}, {43, -3, -7, 32}, {2762, -2, -8, 32}// 182	183	184	
			, {2765, -2, -7, 32}, {2766, -1, -8, 32}, {2766, 0, -8, 32}// 185	186	187	
			, {2766, 1, -8, 32}, {2766, 2, -8, 32}, {2760, -1, -7, 32}// 188	189	190	
			, {2760, 0, -7, 32}, {2760, 1, -7, 32}, {2760, 2, -7, 32}// 191	192	193	
			, {1431, -2, -7, 55}, {1431, -2, -8, 55}, {1431, -2, -9, 55}// 194	195	196	
			, {1431, -1, -7, 58}, {1431, -1, -8, 58}, {1431, -1, -9, 58}// 197	198	199	
			, {1431, 0, -9, 61}, {1431, 0, -8, 61}, {1431, -1, -7, 12}// 200	201	202	
			, {1431, 0, -7, 61}, {1431, 1, -7, 64}, {1431, 1, -8, 64}// 203	204	205	
			, {1431, 1, -9, 64}, {1430, 2, -7, 64}, {1430, 2, -8, 64}// 206	207	208	
			, {1430, 2, -9, 64}, {1430, 3, -7, 61}, {1430, 3, -8, 61}// 209	210	211	
			, {1430, 3, -9, 61}, {3215, -6, -10, 32}, {3215, -7, -8, 32}// 212	213	214	
			, {3215, -7, -9, 32}, {3215, -6, -9, 32}, {1872, -6, 1, 27}// 215	216	217	
			, {1872, -6, 2, 27}, {1872, -6, 3, 27}, {1872, -6, 4, 27}// 218	219	220	
			, {1872, -6, 5, 27}, {1872, -5, 1, 27}, {1872, -5, 2, 27}// 221	222	223	
			, {1872, -5, 3, 27}, {1872, -5, 4, 27}, {1872, -5, 5, 27}// 224	225	226	
			, {1872, -4, -6, 27}, {1872, -4, -5, 27}, {1872, -4, -4, 27}// 227	228	229	
			, {1872, -4, -3, 27}, {1872, -4, -2, 27}, {1872, -4, -1, 27}// 230	231	232	
			, {1872, -4, 0, 27}, {1872, -4, 1, 27}, {1872, -4, 2, 27}// 233	234	235	
			, {1872, -4, 3, 27}, {1872, -4, 4, 27}, {1872, -4, 5, 27}// 236	237	238	
			, {1872, -3, -6, 27}, {1872, -3, -5, 27}, {1872, -3, -4, 27}// 239	240	241	
			, {1872, -3, -3, 27}, {1872, -3, -2, 27}, {1872, -3, -1, 27}// 242	243	244	
			, {1872, -3, 0, 27}, {1872, -3, 1, 27}, {1872, -3, 2, 27}// 245	246	247	
			, {1872, -3, 3, 27}, {1872, -3, 4, 27}, {1872, -3, 5, 27}// 248	249	250	
			, {1872, -2, -6, 27}, {1872, -2, -5, 27}, {1872, -2, -4, 27}// 251	252	253	
			, {1872, -2, -3, 27}, {1872, -2, -2, 27}, {1872, -2, -1, 27}// 254	255	256	
			, {1872, -2, 0, 27}, {1872, -2, 1, 27}, {1872, -2, 2, 27}// 257	258	259	
			, {1872, -2, 3, 27}, {1872, -2, 4, 27}, {1872, -2, 5, 27}// 260	261	262	
			, {1872, -1, -6, 27}, {1872, -1, -5, 27}, {1872, -1, -4, 27}// 263	264	265	
			, {1872, -1, -3, 27}, {1872, -1, -2, 27}, {1872, -1, -1, 27}// 266	267	268	
			, {1872, -1, 0, 27}, {1872, -1, 1, 27}, {1872, -1, 2, 27}// 269	270	271	
			, {1872, -1, 3, 27}, {1872, -1, 4, 27}, {1872, -1, 5, 27}// 272	273	274	
			, {1872, 0, -6, 27}, {1872, 0, -5, 27}, {1872, 0, -4, 27}// 275	276	277	
			, {1872, 0, -3, 27}, {1872, 0, -2, 27}, {1872, 0, -1, 27}// 278	279	280	
			, {1872, 0, 0, 27}, {1872, 0, 1, 27}, {1872, 0, 2, 27}// 281	282	283	
			, {1872, 0, 3, 27}, {1872, 0, 4, 27}, {1872, 0, 5, 27}// 284	285	286	
			, {1872, 1, -6, 27}, {1872, 1, -5, 27}, {1872, 1, -4, 27}// 287	288	289	
			, {1872, 1, -3, 27}, {1872, 1, -2, 27}, {1872, 1, -1, 27}// 290	291	292	
			, {1872, 1, 0, 27}, {1872, 1, 1, 27}, {1872, 1, 2, 27}// 293	294	295	
			, {1872, 1, 3, 27}, {1872, 1, 4, 27}, {1872, 1, 5, 27}// 296	297	298	
			, {1872, 2, -6, 27}, {1872, 2, -5, 27}, {1872, 2, -4, 27}// 299	300	301	
			, {1872, 2, -3, 27}, {1872, 2, -2, 27}, {1872, 2, -1, 27}// 302	303	304	
			, {1872, 2, 0, 27}, {1872, 2, 1, 27}, {1872, 2, 2, 27}// 305	306	307	
			, {1872, 2, 3, 27}, {1872, 2, 4, 27}, {1872, 2, 5, 27}// 308	309	310	
			, {1872, 3, -6, 27}, {1872, 3, -5, 27}, {1872, 3, -4, 27}// 311	312	313	
			, {1872, 3, -3, 27}, {1872, 3, -2, 27}, {1872, 3, -1, 27}// 314	315	316	
			, {1872, 3, 0, 27}, {1872, 3, 1, 27}, {1872, 3, 2, 27}// 317	318	319	
			, {1872, 3, 3, 27}, {1872, 3, 4, 27}, {1872, 3, 5, 27}// 320	321	322	
			, {42, -3, -4, 32}, {43, -3, -3, 32}, {42, -3, 0, 32}// 323	324	325	
			, {27, -3, 1, 32}, {28, -2, 1, 32}, {28, -3, 1, 32}// 326	327	328	
			, {27, -4, 2, 32}, {27, -4, 3, 32}, {27, -4, 4, 32}// 329	330	331	
			, {7978, -3, 5, 32}, {7979, -3, 5, 40}, {2762, -2, 2, 32}// 332	333	334	
			, {2765, -2, 3, 32}, {2763, -2, 4, 32}, {2766, -1, 2, 32}// 335	336	337	
			, {2766, 0, 2, 32}, {2766, 1, 2, 32}, {2766, 2, 2, 32}// 338	339	340	
			, {2764, 3, 2, 32}, {2768, -1, 4, 32}, {2768, 0, 4, 32}// 341	342	343	
			, {2768, 1, 4, 32}, {2768, 2, 4, 32}, {2761, 3, 4, 32}// 344	345	346	
			, {2767, 3, 3, 32}, {2760, -1, 3, 32}, {2760, 2, 3, 32}// 347	348	349	
			, {2758, 0, 3, 32}, {2759, 1, 3, 32}, {2833, -2, -3, 32}// 350	351	352	
			, {2836, -2, -4, 32}, {2835, -2, -5, 32}, {2765, -2, -6, 32}// 353	354	355	
			, {2765, -2, -5, 32}, {2765, -2, -4, 32}, {2765, -2, -3, 32}// 356	357	358	
			, {2765, -2, -2, 32}, {2765, -2, -1, 32}, {2763, -2, 0, 32}// 359	360	361	
			, {2768, -1, 0, 32}, {2768, 0, 0, 32}, {2768, 1, 0, 32}// 362	363	364	
			, {2768, 2, 0, 32}, {2760, -1, -6, 32}, {2759, 1, -6, 32}// 365	366	367	
			, {2760, 0, -6, 32}, {2760, 2, -6, 32}, {2760, 1, -5, 32}// 368	369	370	
			, {2760, 2, -5, 32}, {2760, -1, -5, 32}, {2759, 0, -5, 32}// 371	372	373	
			, {2759, 1, -4, 32}, {2759, 0, -3, 32}, {2759, 1, -2, 32}// 374	375	376	
			, {2760, -1, -4, 32}, {2760, 0, -4, 32}, {2760, 2, -4, 32}// 377	378	379	
			, {2760, -1, -3, 32}, {2760, -1, -2, 32}, {2760, -1, -1, 32}// 380	381	382	
			, {2760, 0, -1, 32}, {2760, 0, -2, 32}, {2760, 1, -3, 32}// 383	384	385	
			, {2760, 2, -3, 32}, {2760, 2, -2, 32}, {2760, 1, -1, 32}// 386	387	388	
			, {2760, 2, -1, 32}, {1431, -3, 5, 55}, {1431, -3, 4, 55}// 389	390	391	
			, {1431, -3, 3, 55}, {1431, -3, 2, 55}, {1431, -2, 1, 55}// 392	393	394	
			, {1431, -2, 0, 55}, {1431, -2, -1, 55}, {1431, -2, -2, 55}// 395	396	397	
			, {1431, -2, -3, 55}, {1431, -2, -4, 55}, {1431, -2, -5, 55}// 398	399	400	
			, {1431, -2, -6, 55}, {1431, -2, 2, 58}, {1431, -2, 3, 58}// 401	402	403	
			, {1431, -2, 4, 58}, {1431, -2, 5, 58}, {1431, -1, 5, 61}// 404	405	406	
			, {1431, -1, 4, 61}, {1431, -1, 3, 61}, {1431, -1, 2, 61}// 407	408	409	
			, {1431, -1, 1, 58}, {1431, -1, 0, 58}, {1431, -1, -1, 58}// 410	411	412	
			, {1431, -1, -2, 58}, {1431, -1, -3, 58}, {1431, -1, -4, 58}// 413	414	415	
			, {1431, -1, -5, 58}, {1431, -1, -6, 58}, {1431, -1, -6, 12}// 416	417	418	
			, {1431, -1, -5, 12}, {1431, -1, -4, 12}, {1431, -1, -3, 12}// 419	420	421	
			, {1431, -1, -2, 12}, {1431, -1, -1, 12}, {1431, -1, 0, 12}// 422	423	424	
			, {1431, -1, 1, 12}, {1431, -1, 2, 12}, {1431, 0, -6, 61}// 425	426	427	
			, {1431, 0, -5, 61}, {1431, 0, -4, 61}, {1431, 0, -3, 61}// 428	429	430	
			, {1431, 0, -2, 61}, {1431, 0, -1, 61}, {1431, 0, 0, 61}// 431	432	433	
			, {1431, 0, 1, 61}, {1431, 0, 2, 64}, {1431, 0, 3, 64}// 434	435	436	
			, {1431, 0, 4, 64}, {1431, 0, 5, 64}, {1431, 1, 5, 67}// 437	438	439	
			, {1431, 1, 4, 67}, {1431, 1, 3, 67}, {1431, 1, 2, 67}// 440	441	442	
			, {1431, 1, 1, 64}, {1431, 1, 0, 64}, {1431, 1, -1, 64}// 443	444	445	
			, {1431, 1, -2, 64}, {1431, 1, -3, 64}, {1431, 1, -4, 64}// 446	447	448	
			, {1431, 1, -5, 64}, {1431, 1, -6, 64}, {1430, 2, 5, 67}// 449	450	451	
			, {1430, 2, 4, 67}, {1430, 2, 3, 67}, {1430, 2, 2, 67}// 452	453	454	
			, {1430, 2, 1, 64}, {1430, 2, 0, 64}, {1430, 2, -1, 64}// 455	456	457	
			, {1430, 2, -2, 64}, {1430, 2, -3, 64}, {1430, 2, -4, 64}// 458	459	460	
			, {1430, 2, -5, 64}, {1430, 2, -6, 64}, {1430, 3, 5, 64}// 461	462	463	
			, {1430, 3, 4, 64}, {1430, 3, 3, 64}, {1430, 3, 2, 64}// 464	465	466	
			, {1430, 3, 1, 61}, {1430, 3, 0, 61}, {1430, 3, -1, 61}// 467	468	469	
			, {1430, 3, -2, 61}, {1430, 3, -3, 61}, {1430, 3, -4, 61}// 470	471	472	
			, {1430, 3, -5, 61}, {1430, 3, -6, 61}, {3215, -7, 5, 32}// 473	474	475	
			, {3215, -7, 4, 32}, {3215, -7, 2, 32}, {3215, -7, 1, 32}// 476	477	478	
			, {3215, -7, 3, 32}, {3215, -7, 0, 32}, {2921, -1, -2, 32}// 479	480	481	
			, {2920, 0, -2, 32}, {2920, 3, -2, 32}, {2921, 2, -2, 32}// 482	483	484	
			, {2921, -1, -4, 32}, {2920, 0, -4, 32}, {2920, 3, -4, 32}// 485	486	487	
			, {2921, 2, -4, 32}, {2921, -1, -6, 32}, {2920, 0, -6, 32}// 488	489	490	
			, {2920, 3, -6, 32}, {2921, 2, -6, 32}, {2148, 6, -10, 11}// 491	492	493	
			, {2148, 6, -10, 17}, {2148, 6, -10, 23}, {1872, 6, -10, 27}// 494	495	496	
			, {1872, 6, -9, 27}, {1872, 6, -8, 27}, {1872, 6, -7, 27}// 497	498	499	
			, {1872, 4, -10, 27}, {1872, 4, -9, 27}, {1872, 4, -8, 27}// 500	501	502	
			, {1872, 5, -10, 27}, {1872, 5, -9, 27}, {1872, 5, -8, 27}// 503	504	505	
			, {1872, 5, -7, 27}, {2148, 6, -7, 11}, {2148, 6, -7, 17}// 506	507	508	
			, {2148, 6, -7, 23}, {2148, 6, -8, 11}, {2148, 6, -8, 17}// 509	510	511	
			, {2148, 6, -8, 23}, {2148, 6, -9, 11}, {2148, 6, -9, 17}// 512	513	514	
			, {2148, 6, -9, 23}, {1872, 4, -7, 27}, {27, 4, -9, 32}// 515	516	517	
			, {27, 4, -8, 32}, {28, 4, -10, 32}, {1430, 4, -7, 58}// 518	519	520	
			, {1430, 5, -7, 55}, {1430, 4, -8, 58}, {1430, 5, -8, 55}// 521	522	523	
			, {1430, 4, -9, 58}, {1430, 5, -9, 55}, {2148, 6, 5, 11}// 524	525	526	
			, {2148, 6, 4, 11}, {2148, 6, 3, 11}, {2148, 6, 2, 11}// 527	528	529	
			, {2148, 6, 1, 11}, {2148, 6, 0, 11}, {2148, 6, -1, 11}// 530	531	532	
			, {2148, 6, 4, 17}, {2148, 6, 5, 17}, {2148, 6, 5, 23}// 533	534	535	
			, {2148, 6, 4, 23}, {2148, 6, 3, 17}, {2148, 6, 3, 23}// 536	537	538	
			, {2148, 6, 2, 17}, {2148, 6, 2, 23}, {2148, 6, 1, 17}// 539	540	541	
			, {2148, 6, 1, 23}, {2148, 6, 0, 17}, {2148, 6, 0, 23}// 542	543	544	
			, {2148, 6, -1, 17}, {2148, 6, -1, 23}, {1872, 6, -6, 27}// 545	546	547	
			, {1872, 6, -5, 27}, {1872, 6, -4, 27}, {1872, 6, -3, 27}// 548	549	550	
			, {1872, 6, -2, 27}, {1872, 6, -1, 27}, {1872, 6, 0, 27}// 551	552	553	
			, {1872, 6, 1, 27}, {1872, 6, 2, 27}, {1872, 6, 3, 27}// 554	555	556	
			, {1872, 6, 4, 27}, {1872, 6, 5, 27}, {1872, 4, -6, 27}// 557	558	559	
			, {1872, 4, -5, 27}, {1872, 4, -4, 27}, {1872, 4, -3, 27}// 560	561	562	
			, {1872, 4, -2, 27}, {1872, 4, -1, 27}, {1872, 4, 0, 27}// 563	564	565	
			, {1872, 4, 1, 27}, {1872, 4, 2, 27}, {1872, 4, 3, 27}// 566	567	568	
			, {1872, 4, 4, 27}, {1872, 4, 5, 27}, {1872, 5, -6, 27}// 569	570	571	
			, {1872, 5, -5, 27}, {1872, 5, -4, 27}, {1872, 5, -3, 27}// 572	573	574	
			, {1872, 5, -2, 27}, {1872, 5, -1, 27}, {1872, 5, 0, 27}// 575	576	577	
			, {1872, 5, 1, 27}, {1872, 5, 2, 27}, {1872, 5, 3, 27}// 578	579	580	
			, {1872, 5, 4, 27}, {1872, 5, 5, 27}, {2148, 6, -2, 11}// 581	582	583	
			, {2148, 6, -2, 17}, {2148, 6, -2, 23}, {2148, 6, -3, 11}// 584	585	586	
			, {2148, 6, -3, 17}, {2148, 6, -3, 23}, {2148, 6, -4, 11}// 587	588	589	
			, {2148, 6, -4, 17}, {2148, 6, -4, 23}, {2148, 6, -5, 11}// 590	591	592	
			, {2148, 6, -5, 17}, {2148, 6, -5, 23}, {2148, 6, -6, 11}// 593	594	595	
			, {2148, 6, -6, 17}, {2148, 6, -6, 23}, {27, 5, 4, 32}// 596	597	598	
			, {27, 5, 3, 32}, {27, 5, 2, 32}, {28, 5, 1, 32}// 599	600	601	
			, {28, 4, 1, 32}, {27, 4, 1, 32}, {27, 4, 0, 32}// 602	603	604	
			, {27, 4, -1, 32}, {27, 4, -3, 32}, {27, 4, -4, 32}// 605	606	607	
			, {27, 4, -5, 32}, {27, 4, -6, 32}, {7978, 4, 5, 32}// 608	609	610	
			, {7979, 4, 5, 40}, {1430, 4, 5, 61}, {1430, 5, 5, 58}// 611	612	613	
			, {1430, 6, 5, 55}, {1430, 4, 4, 61}, {1430, 5, 4, 58}// 614	615	616	
			, {1430, 6, 4, 55}, {1430, 4, 3, 61}, {1430, 5, 3, 58}// 617	618	619	
			, {1430, 6, 3, 55}, {1430, 4, 2, 61}, {1430, 5, 2, 58}// 620	621	622	
			, {1430, 6, 2, 55}, {1430, 4, 1, 58}, {1430, 5, 1, 55}// 623	624	625	
			, {1430, 4, 0, 58}, {1430, 5, 0, 55}, {1430, 4, -1, 58}// 626	627	628	
			, {1430, 5, -1, 55}, {1430, 4, -2, 58}, {1430, 5, -2, 55}// 629	630	631	
			, {1430, 4, -3, 58}, {1430, 5, -3, 55}, {1430, 4, -4, 58}// 632	633	634	
			, {1430, 5, -4, 55}, {1430, 4, -5, 58}, {1430, 5, -5, 55}// 635	636	637	
			, {1430, 4, -6, 58}, {1430, 5, -6, 55}, {3314, 7, 5, 11}// 638	639	640	
			, {3314, 7, 3, 11}, {41668, 4, 3, 32}, {41728, -7, -3, 33}// 641	645	646	
			, {3245, -7, -1, 33}, {3247, -6, -1, 32}, {3260, -6, -4, 31}// 647	648	649	
			, {3260, -6, -3, 32}, {3260, -6, -2, 32}, {41668, -3, 3, 32}// 650	651	653	
			, {41197, -5, -8, 30}, {6021, -4, -3, 32}, {41375, 6, 0, 0}// 654	661	662	
			, {41375, 6, 3, 1}, {3314, 6, -7, 7}, {3245, -6, -7, 30}// 663	665	667	
			, {6021, -5, -7, 32}, {6021, -4, -2, 32}, {6021, -5, -7, 32}// 675	677	678	
			, {6021, -4, -4, 32}// 679	
		};

        [Constructable]
        public TheFellowshipHouse()
        {
            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent(new AddonComponent(m_AddOnSimpleComponents[i, 0]), m_AddOnSimpleComponents[i, 1], m_AddOnSimpleComponents[i, 2], m_AddOnSimpleComponents[i, 3]);
            
            AddComplexComponent((BaseAddon)this, 41185, -7, 6, 30, 22, -1, "", 1);// 78
            AddComplexComponent((BaseAddon)this, 41254, -1, 8, 8, 33, -1, "", 1);// 100
            AddComplexComponent((BaseAddon)this, 41248, 0, 7, 8, 22, -1, "", 1);// 111
            AddComplexComponent((BaseAddon)this, 10672, -3, 4, 32, 0, 26, "", 1);// 128
            AddComplexComponent((BaseAddon)this, 6571, -3, 5, 42, 0, 1, "", 1);// 129
            AddComplexComponent((BaseAddon)this, 2567, -4, 2, 34, 0, 8, "", 1);// 130
            AddComplexComponent((BaseAddon)this, 10673, 4, -7, 32, 0, 27, "", 1);// 131
            AddComplexComponent((BaseAddon)this, 10672, 5, 4, 32, 0, 26, "", 1);// 132
            AddComplexComponent((BaseAddon)this, 10673, 4, -2, 32, 0, 27, "", 1);// 133
            AddComplexComponent((BaseAddon)this, 6571, 4, 5, 42, 0, 1, "", 1);// 134
            AddComplexComponent((BaseAddon)this, 41185, -5, -10, 31, 33, -1, "", 1);// 642
            AddComplexComponent((BaseAddon)this, 41185, -5, -3, 29, 33, -1, "", 1);// 643
            AddComplexComponent((BaseAddon)this, 41185, -5, -2, 30, 22, -1, "", 1);// 644
            AddComplexComponent((BaseAddon)this, 41182, -5, -1, 30, 49, -1, "", 1);// 652
            AddComplexComponent((BaseAddon)this, 41185, -5, -9, 33, 49, -1, "", 1);// 655
            AddComplexComponent((BaseAddon)this, 41197, -5, -9, 32, 49, -1, "", 1);// 656
            AddComplexComponent((BaseAddon)this, 41252, 7, -5, 7, 22, -1, "", 1);// 657
            AddComplexComponent((BaseAddon)this, 41181, -6, 1, 32, 49, -1, "", 1);// 658
            AddComplexComponent((BaseAddon)this, 41181, -6, 2, 32, 49, -1, "", 1);// 659
            AddComplexComponent((BaseAddon)this, 41251, 7, -4, 7, 33, -1, "", 1);// 660
            AddComplexComponent((BaseAddon)this, 41253, 7, 2, 6, 22, -1, "", 1);// 664
            AddComplexComponent((BaseAddon)this, 41251, 7, -6, 10, 33, -1, "", 1);// 666
            AddComplexComponent((BaseAddon)this, 41185, -6, -8, 31, 22, -1, "", 1);// 668
            AddComplexComponent((BaseAddon)this, 41185, -6, 4, 32, 33, -1, "", 1);// 669
            AddComplexComponent((BaseAddon)this, 41187, -6, 3, 32, 22, -1, "", 1);// 670
            AddComplexComponent((BaseAddon)this, 41187, -6, 0, 30, 22, -1, "", 1);// 671
            AddComplexComponent((BaseAddon)this, 41187, -5, -6, 28, 22, -1, "", 1);// 672
            AddComplexComponent((BaseAddon)this, 41187, -5, -5, 29, 22, -1, "", 1);// 673
            AddComplexComponent((BaseAddon)this, 41182, -6, 5, 32, 49, -1, "", 1);// 674
            AddComplexComponent((BaseAddon)this, 41187, -5, -4, 29, 22, -1, "", 1);// 676
            AddComplexComponent((BaseAddon)this, 41197, -5, -8, 30, 49, -1, "", 1);// 680
        }

        public TheFellowshipHouse(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0); // Version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            if (Map == Map.Trammel)
            {
                InstanceTram = this;
            }

            if (Map == Map.Felucca)
            {
                InstanceFel = this;
            }
        }
    }
}
