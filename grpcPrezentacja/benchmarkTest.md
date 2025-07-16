// Validating benchmarks:
// ***** BenchmarkRunner: Start   *****
// ***** Found 12 benchmark(s) in total *****
// ***** Building 1 exe(s) in Parallel: Start   *****
// command took 5.06 sec and exited with 0
// ***** Done, took 00:00:06 (6.18 sec)   *****
// Found 12 benchmarks:
//   Benchmark.JsonSerialization: DefaultJob [Size=10000]
//   Benchmark.ProtobufSerialization: DefaultJob [Size=10000]
//   Benchmark.JsonDeserialization: DefaultJob [Size=10000]
//   Benchmark.ProtobufDeserialization: DefaultJob [Size=10000]
//   Benchmark.JsonSerialization: DefaultJob [Size=100000]
//   Benchmark.ProtobufSerialization: DefaultJob [Size=100000]
//   Benchmark.JsonDeserialization: DefaultJob [Size=100000]
//   Benchmark.ProtobufDeserialization: DefaultJob [Size=100000]
//   Benchmark.JsonSerialization: DefaultJob [Size=1000000]
//   Benchmark.ProtobufSerialization: DefaultJob [Size=1000000]
//   Benchmark.JsonDeserialization: DefaultJob [Size=1000000]
//   Benchmark.ProtobufDeserialization: DefaultJob [Size=1000000]

Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Wysoka wydajność)
// **************************
// Benchmark: Benchmark.JsonSerialization: DefaultJob [Size=10000]
// ***Execute***
// Launch: 1 / 1
// Execute: dotnet gRPCVsJSON-DefaultJob-1.dll --anonymousPipes 1536 1528 --benchmarkName "gRPCVsJSON.Benchmark.JsonSerialization(Size: 10000)" --job Default --benchmarkId 0 in *
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 100600.00 ns, 100.6000 us/op
WorkloadJitting  1: 1 op, 6396100.00 ns, 6.3961 ms/op

OverheadJitting  2: 16 op, 236200.00 ns, 14.7625 us/op
WorkloadJitting  2: 16 op, 65940600.00 ns, 4.1213 ms/op

WorkloadPilot    1: 16 op, 61176800.00 ns, 3.8236 ms/op
WorkloadPilot    2: 32 op, 136139700.00 ns, 4.2544 ms/op
WorkloadPilot    3: 64 op, 255597200.00 ns, 3.9937 ms/op
WorkloadPilot    4: 128 op, 212289200.00 ns, 1.6585 ms/op
WorkloadPilot    5: 256 op, 426443000.00 ns, 1.6658 ms/op
WorkloadPilot    6: 512 op, 817665100.00 ns, 1.5970 ms/op

OverheadWarmup   1: 512 op, 4400.00 ns, 8.5938 ns/op
OverheadWarmup   2: 512 op, 3800.00 ns, 7.4219 ns/op
OverheadWarmup   3: 512 op, 2100.00 ns, 4.1016 ns/op
OverheadWarmup   4: 512 op, 2400.00 ns, 4.6875 ns/op
OverheadWarmup   5: 512 op, 2600.00 ns, 5.0781 ns/op
OverheadWarmup   6: 512 op, 3000.00 ns, 5.8594 ns/op
OverheadWarmup   7: 512 op, 3000.00 ns, 5.8594 ns/op
OverheadWarmup   8: 512 op, 3100.00 ns, 6.0547 ns/op
OverheadWarmup   9: 512 op, 2100.00 ns, 4.1016 ns/op

OverheadActual   1: 512 op, 3300.00 ns, 6.4453 ns/op
OverheadActual   2: 512 op, 3700.00 ns, 7.2266 ns/op
OverheadActual   3: 512 op, 2700.00 ns, 5.2734 ns/op
OverheadActual   4: 512 op, 2600.00 ns, 5.0781 ns/op
OverheadActual   5: 512 op, 2700.00 ns, 5.2734 ns/op
OverheadActual   6: 512 op, 2700.00 ns, 5.2734 ns/op
OverheadActual   7: 512 op, 3000.00 ns, 5.8594 ns/op
OverheadActual   8: 512 op, 2900.00 ns, 5.6641 ns/op
OverheadActual   9: 512 op, 3200.00 ns, 6.2500 ns/op
OverheadActual  10: 512 op, 3400.00 ns, 6.6406 ns/op
OverheadActual  11: 512 op, 2500.00 ns, 4.8828 ns/op
OverheadActual  12: 512 op, 4900.00 ns, 9.5703 ns/op
OverheadActual  13: 512 op, 2600.00 ns, 5.0781 ns/op
OverheadActual  14: 512 op, 3700.00 ns, 7.2266 ns/op
OverheadActual  15: 512 op, 2700.00 ns, 5.2734 ns/op
OverheadActual  16: 512 op, 2700.00 ns, 5.2734 ns/op
OverheadActual  17: 512 op, 2800.00 ns, 5.4688 ns/op
OverheadActual  18: 512 op, 4200.00 ns, 8.2031 ns/op
OverheadActual  19: 512 op, 3100.00 ns, 6.0547 ns/op
OverheadActual  20: 512 op, 3600.00 ns, 7.0313 ns/op

OverheadWarmup   1: 512 op, 2200.00 ns, 4.2969 ns/op
OverheadWarmup   2: 512 op, 2800.00 ns, 5.4688 ns/op
OverheadWarmup   3: 512 op, 2800.00 ns, 5.4688 ns/op
OverheadWarmup   4: 512 op, 2700.00 ns, 5.2734 ns/op
OverheadWarmup   5: 512 op, 2900.00 ns, 5.6641 ns/op
OverheadWarmup   6: 512 op, 2700.00 ns, 5.2734 ns/op

// BeforeActualRun
WorkloadActual   1: 512 op, 837464100.00 ns, 1.6357 ms/op
WorkloadActual   2: 512 op, 841747900.00 ns, 1.6440 ms/op
WorkloadActual   3: 512 op, 791895900.00 ns, 1.5467 ms/op
WorkloadActual   4: 512 op, 855781200.00 ns, 1.6714 ms/op
WorkloadActual   5: 512 op, 906054700.00 ns, 1.7696 ms/op
WorkloadActual   6: 512 op, 847570100.00 ns, 1.6554 ms/op
WorkloadActual   7: 512 op, 820564100.00 ns, 1.6027 ms/op
WorkloadActual   8: 512 op, 782139000.00 ns, 1.5276 ms/op
WorkloadActual   9: 512 op, 830031900.00 ns, 1.6212 ms/op
WorkloadActual  10: 512 op, 822529600.00 ns, 1.6065 ms/op
WorkloadActual  11: 512 op, 845466800.00 ns, 1.6513 ms/op
WorkloadActual  12: 512 op, 946089400.00 ns, 1.8478 ms/op
WorkloadActual  13: 512 op, 1184201800.00 ns, 2.3129 ms/op
WorkloadActual  14: 512 op, 1068670900.00 ns, 2.0872 ms/op
WorkloadActual  15: 512 op, 1092070200.00 ns, 2.1329 ms/op
WorkloadActual  16: 512 op, 1055396200.00 ns, 2.0613 ms/op
WorkloadActual  17: 512 op, 1026277700.00 ns, 2.0044 ms/op
WorkloadActual  18: 512 op, 892911100.00 ns, 1.7440 ms/op
WorkloadActual  19: 512 op, 992163900.00 ns, 1.9378 ms/op
WorkloadActual  20: 512 op, 1328827600.00 ns, 2.5954 ms/op
WorkloadActual  21: 512 op, 1051326400.00 ns, 2.0534 ms/op
WorkloadActual  22: 512 op, 880213500.00 ns, 1.7192 ms/op
WorkloadActual  23: 512 op, 910818400.00 ns, 1.7789 ms/op
WorkloadActual  24: 512 op, 894265700.00 ns, 1.7466 ms/op
WorkloadActual  25: 512 op, 1084823300.00 ns, 2.1188 ms/op
WorkloadActual  26: 512 op, 1017819700.00 ns, 1.9879 ms/op
WorkloadActual  27: 512 op, 938375200.00 ns, 1.8328 ms/op
WorkloadActual  28: 512 op, 1094755300.00 ns, 2.1382 ms/op
WorkloadActual  29: 512 op, 896693700.00 ns, 1.7514 ms/op
WorkloadActual  30: 512 op, 827437700.00 ns, 1.6161 ms/op
WorkloadActual  31: 512 op, 838299000.00 ns, 1.6373 ms/op
WorkloadActual  32: 512 op, 779644300.00 ns, 1.5227 ms/op
WorkloadActual  33: 512 op, 785428100.00 ns, 1.5340 ms/op
WorkloadActual  34: 512 op, 764995100.00 ns, 1.4941 ms/op
WorkloadActual  35: 512 op, 776323300.00 ns, 1.5163 ms/op
WorkloadActual  36: 512 op, 751226500.00 ns, 1.4672 ms/op
WorkloadActual  37: 512 op, 782601900.00 ns, 1.5285 ms/op
WorkloadActual  38: 512 op, 800852600.00 ns, 1.5642 ms/op
WorkloadActual  39: 512 op, 822263700.00 ns, 1.6060 ms/op
WorkloadActual  40: 512 op, 780678300.00 ns, 1.5248 ms/op
WorkloadActual  41: 512 op, 754689200.00 ns, 1.4740 ms/op
WorkloadActual  42: 512 op, 755478800.00 ns, 1.4755 ms/op
WorkloadActual  43: 512 op, 781556300.00 ns, 1.5265 ms/op
WorkloadActual  44: 512 op, 811112900.00 ns, 1.5842 ms/op
WorkloadActual  45: 512 op, 958818300.00 ns, 1.8727 ms/op
WorkloadActual  46: 512 op, 811491900.00 ns, 1.5849 ms/op
WorkloadActual  47: 512 op, 779910000.00 ns, 1.5233 ms/op
WorkloadActual  48: 512 op, 799445500.00 ns, 1.5614 ms/op
WorkloadActual  49: 512 op, 784727500.00 ns, 1.5327 ms/op
WorkloadActual  50: 512 op, 841502900.00 ns, 1.6436 ms/op
WorkloadActual  51: 512 op, 897205700.00 ns, 1.7524 ms/op
WorkloadActual  52: 512 op, 837847000.00 ns, 1.6364 ms/op
WorkloadActual  53: 512 op, 831940400.00 ns, 1.6249 ms/op
WorkloadActual  54: 512 op, 802078800.00 ns, 1.5666 ms/op
WorkloadActual  55: 512 op, 826861800.00 ns, 1.6150 ms/op
WorkloadActual  56: 512 op, 765105300.00 ns, 1.4943 ms/op
WorkloadActual  57: 512 op, 768298100.00 ns, 1.5006 ms/op
WorkloadActual  58: 512 op, 796771800.00 ns, 1.5562 ms/op
WorkloadActual  59: 512 op, 765536500.00 ns, 1.4952 ms/op
WorkloadActual  60: 512 op, 769285000.00 ns, 1.5025 ms/op
WorkloadActual  61: 512 op, 778077500.00 ns, 1.5197 ms/op
WorkloadActual  62: 512 op, 785482500.00 ns, 1.5341 ms/op
WorkloadActual  63: 512 op, 797290800.00 ns, 1.5572 ms/op
WorkloadActual  64: 512 op, 775667600.00 ns, 1.5150 ms/op
WorkloadActual  65: 512 op, 783086500.00 ns, 1.5295 ms/op
WorkloadActual  66: 512 op, 763217000.00 ns, 1.4907 ms/op
WorkloadActual  67: 512 op, 755765500.00 ns, 1.4761 ms/op
WorkloadActual  68: 512 op, 779131000.00 ns, 1.5217 ms/op
WorkloadActual  69: 512 op, 985830500.00 ns, 1.9255 ms/op
WorkloadActual  70: 512 op, 967997100.00 ns, 1.8906 ms/op
WorkloadActual  71: 512 op, 837955000.00 ns, 1.6366 ms/op
WorkloadActual  72: 512 op, 776172500.00 ns, 1.5160 ms/op
WorkloadActual  73: 512 op, 834500000.00 ns, 1.6299 ms/op
WorkloadActual  74: 512 op, 929303700.00 ns, 1.8150 ms/op
WorkloadActual  75: 512 op, 758726000.00 ns, 1.4819 ms/op
WorkloadActual  76: 512 op, 888437500.00 ns, 1.7352 ms/op
WorkloadActual  77: 512 op, 819472600.00 ns, 1.6005 ms/op
WorkloadActual  78: 512 op, 800007700.00 ns, 1.5625 ms/op
WorkloadActual  79: 512 op, 812865400.00 ns, 1.5876 ms/op
WorkloadActual  80: 512 op, 759632800.00 ns, 1.4837 ms/op
WorkloadActual  81: 512 op, 793843100.00 ns, 1.5505 ms/op
WorkloadActual  82: 512 op, 767878900.00 ns, 1.4998 ms/op
WorkloadActual  83: 512 op, 744213000.00 ns, 1.4535 ms/op
WorkloadActual  84: 512 op, 759151000.00 ns, 1.4827 ms/op
WorkloadActual  85: 512 op, 782107000.00 ns, 1.5276 ms/op
WorkloadActual  86: 512 op, 793192900.00 ns, 1.5492 ms/op
WorkloadActual  87: 512 op, 785294900.00 ns, 1.5338 ms/op
WorkloadActual  88: 512 op, 785548000.00 ns, 1.5343 ms/op
WorkloadActual  89: 512 op, 864489800.00 ns, 1.6885 ms/op
WorkloadActual  90: 512 op, 808767600.00 ns, 1.5796 ms/op
WorkloadActual  91: 512 op, 809129500.00 ns, 1.5803 ms/op
WorkloadActual  92: 512 op, 861166500.00 ns, 1.6820 ms/op
WorkloadActual  93: 512 op, 801699300.00 ns, 1.5658 ms/op
WorkloadActual  94: 512 op, 769694100.00 ns, 1.5033 ms/op
WorkloadActual  95: 512 op, 785694200.00 ns, 1.5346 ms/op
WorkloadActual  96: 512 op, 787712000.00 ns, 1.5385 ms/op
WorkloadActual  97: 512 op, 775017000.00 ns, 1.5137 ms/op
WorkloadActual  98: 512 op, 866318700.00 ns, 1.6920 ms/op
WorkloadActual  99: 512 op, 753415500.00 ns, 1.4715 ms/op
WorkloadActual  100: 512 op, 776989700.00 ns, 1.5176 ms/op

// AfterActualRun
WorkloadResult   1: 512 op, 837461150.00 ns, 1.6357 ms/op
WorkloadResult   2: 512 op, 841744950.00 ns, 1.6440 ms/op
WorkloadResult   3: 512 op, 791892950.00 ns, 1.5467 ms/op
WorkloadResult   4: 512 op, 855778250.00 ns, 1.6714 ms/op
WorkloadResult   5: 512 op, 906051750.00 ns, 1.7696 ms/op
WorkloadResult   6: 512 op, 847567150.00 ns, 1.6554 ms/op
WorkloadResult   7: 512 op, 820561150.00 ns, 1.6027 ms/op
WorkloadResult   8: 512 op, 782136050.00 ns, 1.5276 ms/op
WorkloadResult   9: 512 op, 830028950.00 ns, 1.6212 ms/op
WorkloadResult  10: 512 op, 822526650.00 ns, 1.6065 ms/op
WorkloadResult  11: 512 op, 845463850.00 ns, 1.6513 ms/op
WorkloadResult  12: 512 op, 946086450.00 ns, 1.8478 ms/op
WorkloadResult  13: 512 op, 892908150.00 ns, 1.7440 ms/op
WorkloadResult  14: 512 op, 992160950.00 ns, 1.9378 ms/op
WorkloadResult  15: 512 op, 880210550.00 ns, 1.7192 ms/op
WorkloadResult  16: 512 op, 910815450.00 ns, 1.7789 ms/op
WorkloadResult  17: 512 op, 894262750.00 ns, 1.7466 ms/op
WorkloadResult  18: 512 op, 938372250.00 ns, 1.8328 ms/op
WorkloadResult  19: 512 op, 896690750.00 ns, 1.7513 ms/op
WorkloadResult  20: 512 op, 827434750.00 ns, 1.6161 ms/op
WorkloadResult  21: 512 op, 838296050.00 ns, 1.6373 ms/op
WorkloadResult  22: 512 op, 779641350.00 ns, 1.5227 ms/op
WorkloadResult  23: 512 op, 785425150.00 ns, 1.5340 ms/op
WorkloadResult  24: 512 op, 764992150.00 ns, 1.4941 ms/op
WorkloadResult  25: 512 op, 776320350.00 ns, 1.5163 ms/op
WorkloadResult  26: 512 op, 751223550.00 ns, 1.4672 ms/op
WorkloadResult  27: 512 op, 782598950.00 ns, 1.5285 ms/op
WorkloadResult  28: 512 op, 800849650.00 ns, 1.5642 ms/op
WorkloadResult  29: 512 op, 822260750.00 ns, 1.6060 ms/op
WorkloadResult  30: 512 op, 780675350.00 ns, 1.5248 ms/op
WorkloadResult  31: 512 op, 754686250.00 ns, 1.4740 ms/op
WorkloadResult  32: 512 op, 755475850.00 ns, 1.4755 ms/op
WorkloadResult  33: 512 op, 781553350.00 ns, 1.5265 ms/op
WorkloadResult  34: 512 op, 811109950.00 ns, 1.5842 ms/op
WorkloadResult  35: 512 op, 958815350.00 ns, 1.8727 ms/op
WorkloadResult  36: 512 op, 811488950.00 ns, 1.5849 ms/op
WorkloadResult  37: 512 op, 779907050.00 ns, 1.5233 ms/op
WorkloadResult  38: 512 op, 799442550.00 ns, 1.5614 ms/op
WorkloadResult  39: 512 op, 784724550.00 ns, 1.5327 ms/op
WorkloadResult  40: 512 op, 841499950.00 ns, 1.6436 ms/op
WorkloadResult  41: 512 op, 897202750.00 ns, 1.7523 ms/op
WorkloadResult  42: 512 op, 837844050.00 ns, 1.6364 ms/op
WorkloadResult  43: 512 op, 831937450.00 ns, 1.6249 ms/op
WorkloadResult  44: 512 op, 802075850.00 ns, 1.5666 ms/op
WorkloadResult  45: 512 op, 826858850.00 ns, 1.6150 ms/op
WorkloadResult  46: 512 op, 765102350.00 ns, 1.4943 ms/op
WorkloadResult  47: 512 op, 768295150.00 ns, 1.5006 ms/op
WorkloadResult  48: 512 op, 796768850.00 ns, 1.5562 ms/op
WorkloadResult  49: 512 op, 765533550.00 ns, 1.4952 ms/op
WorkloadResult  50: 512 op, 769282050.00 ns, 1.5025 ms/op
WorkloadResult  51: 512 op, 778074550.00 ns, 1.5197 ms/op
WorkloadResult  52: 512 op, 785479550.00 ns, 1.5341 ms/op
WorkloadResult  53: 512 op, 797287850.00 ns, 1.5572 ms/op
WorkloadResult  54: 512 op, 775664650.00 ns, 1.5150 ms/op
WorkloadResult  55: 512 op, 783083550.00 ns, 1.5295 ms/op
WorkloadResult  56: 512 op, 763214050.00 ns, 1.4907 ms/op
WorkloadResult  57: 512 op, 755762550.00 ns, 1.4761 ms/op
WorkloadResult  58: 512 op, 779128050.00 ns, 1.5217 ms/op
WorkloadResult  59: 512 op, 985827550.00 ns, 1.9254 ms/op
WorkloadResult  60: 512 op, 967994150.00 ns, 1.8906 ms/op
WorkloadResult  61: 512 op, 837952050.00 ns, 1.6366 ms/op
WorkloadResult  62: 512 op, 776169550.00 ns, 1.5160 ms/op
WorkloadResult  63: 512 op, 834497050.00 ns, 1.6299 ms/op
WorkloadResult  64: 512 op, 929300750.00 ns, 1.8150 ms/op
WorkloadResult  65: 512 op, 758723050.00 ns, 1.4819 ms/op
WorkloadResult  66: 512 op, 888434550.00 ns, 1.7352 ms/op
WorkloadResult  67: 512 op, 819469650.00 ns, 1.6005 ms/op
WorkloadResult  68: 512 op, 800004750.00 ns, 1.5625 ms/op
WorkloadResult  69: 512 op, 812862450.00 ns, 1.5876 ms/op
WorkloadResult  70: 512 op, 759629850.00 ns, 1.4837 ms/op
WorkloadResult  71: 512 op, 793840150.00 ns, 1.5505 ms/op
WorkloadResult  72: 512 op, 767875950.00 ns, 1.4998 ms/op
WorkloadResult  73: 512 op, 744210050.00 ns, 1.4535 ms/op
WorkloadResult  74: 512 op, 759148050.00 ns, 1.4827 ms/op
WorkloadResult  75: 512 op, 782104050.00 ns, 1.5275 ms/op
WorkloadResult  76: 512 op, 793189950.00 ns, 1.5492 ms/op
WorkloadResult  77: 512 op, 785291950.00 ns, 1.5338 ms/op
WorkloadResult  78: 512 op, 785545050.00 ns, 1.5343 ms/op
WorkloadResult  79: 512 op, 864486850.00 ns, 1.6885 ms/op
WorkloadResult  80: 512 op, 808764650.00 ns, 1.5796 ms/op
WorkloadResult  81: 512 op, 809126550.00 ns, 1.5803 ms/op
WorkloadResult  82: 512 op, 861163550.00 ns, 1.6820 ms/op
WorkloadResult  83: 512 op, 801696350.00 ns, 1.5658 ms/op
WorkloadResult  84: 512 op, 769691150.00 ns, 1.5033 ms/op
WorkloadResult  85: 512 op, 785691250.00 ns, 1.5346 ms/op
WorkloadResult  86: 512 op, 787709050.00 ns, 1.5385 ms/op
WorkloadResult  87: 512 op, 775014050.00 ns, 1.5137 ms/op
WorkloadResult  88: 512 op, 866315750.00 ns, 1.6920 ms/op
WorkloadResult  89: 512 op, 753412550.00 ns, 1.4715 ms/op
WorkloadResult  90: 512 op, 776986750.00 ns, 1.5176 ms/op
// GC:  52 0 0 653049856 512
// Threading:  0 0 512

// AfterAll
// Benchmark Process 72884 has exited with code 0.

Mean = 1.598 ms, StdErr = 0.012 ms (0.75%), N = 90, StdDev = 0.113 ms
Min = 1.454 ms, Q1 = 1.520 ms, Median = 1.562 ms, Q3 = 1.642 ms, Max = 1.938 ms
IQR = 0.122 ms, LowerFence = 1.337 ms, UpperFence = 1.825 ms
ConfidenceInterval = [1.558 ms; 1.639 ms] (CI 99.9%), Margin = 0.041 ms (2.54% of Mean)
Skewness = 1.2, Kurtosis = 3.78, MValue = 2.12

// **Remained 11 (91,7%) benchmark(s) to run. Estimated finish 2025-07-16 21:58 (0h 16m from now)**
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Wysoka wydajność)
// **************************
// Benchmark: Benchmark.ProtobufSerialization: DefaultJob [Size=10000]
// ***Execute***
// Launch: 1 / 1
// Execute: dotnet gRPCVsJSON-DefaultJob-1.dll --anonymousPipes 1676 1692 --benchmarkName "gRPCVsJSON.Benchmark.ProtobufSerialization(Size: 10000)" --job Default --benchmarkId 1 in *
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 93500.00 ns, 93.5000 us/op
WorkloadJitting  1: 1 op, 2835600.00 ns, 2.8356 ms/op

OverheadJitting  2: 16 op, 208900.00 ns, 13.0563 us/op
WorkloadJitting  2: 16 op, 28051600.00 ns, 1.7532 ms/op

WorkloadPilot    1: 16 op, 22883600.00 ns, 1.4302 ms/op
WorkloadPilot    2: 32 op, 40772600.00 ns, 1.2741 ms/op
WorkloadPilot    3: 64 op, 86287800.00 ns, 1.3482 ms/op
WorkloadPilot    4: 128 op, 137456900.00 ns, 1.0739 ms/op
WorkloadPilot    5: 256 op, 124691100.00 ns, 487.0746 us/op
WorkloadPilot    6: 512 op, 236134200.00 ns, 461.1996 us/op
WorkloadPilot    7: 1024 op, 484933400.00 ns, 473.5678 us/op
WorkloadPilot    8: 2048 op, 988620500.00 ns, 482.7249 us/op

OverheadWarmup   1: 2048 op, 7200.00 ns, 3.5156 ns/op
OverheadWarmup   2: 2048 op, 4800.00 ns, 2.3438 ns/op
OverheadWarmup   3: 2048 op, 4700.00 ns, 2.2949 ns/op
OverheadWarmup   4: 2048 op, 4500.00 ns, 2.1973 ns/op
OverheadWarmup   5: 2048 op, 4300.00 ns, 2.0996 ns/op
OverheadWarmup   6: 2048 op, 4500.00 ns, 2.1973 ns/op
OverheadWarmup   7: 2048 op, 4800.00 ns, 2.3438 ns/op
OverheadWarmup   8: 2048 op, 4900.00 ns, 2.3926 ns/op
OverheadWarmup   9: 2048 op, 4900.00 ns, 2.3926 ns/op
OverheadWarmup  10: 2048 op, 4500.00 ns, 2.1973 ns/op

OverheadActual   1: 2048 op, 4300.00 ns, 2.0996 ns/op
OverheadActual   2: 2048 op, 4700.00 ns, 2.2949 ns/op
OverheadActual   3: 2048 op, 4900.00 ns, 2.3926 ns/op
OverheadActual   4: 2048 op, 4400.00 ns, 2.1484 ns/op
OverheadActual   5: 2048 op, 4700.00 ns, 2.2949 ns/op
OverheadActual   6: 2048 op, 4800.00 ns, 2.3438 ns/op
OverheadActual   7: 2048 op, 5000.00 ns, 2.4414 ns/op
OverheadActual   8: 2048 op, 4800.00 ns, 2.3438 ns/op
OverheadActual   9: 2048 op, 4300.00 ns, 2.0996 ns/op
OverheadActual  10: 2048 op, 4800.00 ns, 2.3438 ns/op
OverheadActual  11: 2048 op, 5000.00 ns, 2.4414 ns/op
OverheadActual  12: 2048 op, 4500.00 ns, 2.1973 ns/op
OverheadActual  13: 2048 op, 7700.00 ns, 3.7598 ns/op
OverheadActual  14: 2048 op, 5000.00 ns, 2.4414 ns/op
OverheadActual  15: 2048 op, 4800.00 ns, 2.3438 ns/op
OverheadActual  16: 2048 op, 5100.00 ns, 2.4902 ns/op
OverheadActual  17: 2048 op, 5000.00 ns, 2.4414 ns/op
OverheadActual  18: 2048 op, 4700.00 ns, 2.2949 ns/op
OverheadActual  19: 2048 op, 16100.00 ns, 7.8613 ns/op
OverheadActual  20: 2048 op, 5300.00 ns, 2.5879 ns/op

OverheadWarmup   1: 2048 op, 5000.00 ns, 2.4414 ns/op
OverheadWarmup   2: 2048 op, 5300.00 ns, 2.5879 ns/op
OverheadWarmup   3: 2048 op, 8200.00 ns, 4.0039 ns/op
OverheadWarmup   4: 2048 op, 5000.00 ns, 2.4414 ns/op
OverheadWarmup   5: 2048 op, 4800.00 ns, 2.3438 ns/op
OverheadWarmup   6: 2048 op, 5100.00 ns, 2.4902 ns/op
OverheadWarmup   7: 2048 op, 4300.00 ns, 2.0996 ns/op

// BeforeActualRun
WorkloadActual   1: 2048 op, 989509000.00 ns, 483.1587 us/op
WorkloadActual   2: 2048 op, 951062000.00 ns, 464.3857 us/op
WorkloadActual   3: 2048 op, 965451600.00 ns, 471.4119 us/op
WorkloadActual   4: 2048 op, 1036223400.00 ns, 505.9685 us/op
WorkloadActual   5: 2048 op, 979068300.00 ns, 478.0607 us/op
WorkloadActual   6: 2048 op, 999943600.00 ns, 488.2537 us/op
WorkloadActual   7: 2048 op, 1018502200.00 ns, 497.3155 us/op
WorkloadActual   8: 2048 op, 1041425000.00 ns, 508.5083 us/op
WorkloadActual   9: 2048 op, 1137805700.00 ns, 555.5692 us/op
WorkloadActual  10: 2048 op, 1056873700.00 ns, 516.0516 us/op
WorkloadActual  11: 2048 op, 1054863800.00 ns, 515.0702 us/op
WorkloadActual  12: 2048 op, 1138040000.00 ns, 555.6836 us/op
WorkloadActual  13: 2048 op, 1163322000.00 ns, 568.0283 us/op
WorkloadActual  14: 2048 op, 1136569400.00 ns, 554.9655 us/op
WorkloadActual  15: 2048 op, 981771400.00 ns, 479.3806 us/op
WorkloadActual  16: 2048 op, 945207800.00 ns, 461.5272 us/op
WorkloadActual  17: 2048 op, 1052050800.00 ns, 513.6967 us/op
WorkloadActual  18: 2048 op, 1166674400.00 ns, 569.6652 us/op
WorkloadActual  19: 2048 op, 1151907400.00 ns, 562.4548 us/op
WorkloadActual  20: 2048 op, 983950600.00 ns, 480.4446 us/op
WorkloadActual  21: 2048 op, 954376300.00 ns, 466.0041 us/op
WorkloadActual  22: 2048 op, 987780900.00 ns, 482.3149 us/op
WorkloadActual  23: 2048 op, 954732000.00 ns, 466.1777 us/op
WorkloadActual  24: 2048 op, 1075798100.00 ns, 525.2920 us/op
WorkloadActual  25: 2048 op, 983917500.00 ns, 480.4285 us/op
WorkloadActual  26: 2048 op, 1016980800.00 ns, 496.5727 us/op
WorkloadActual  27: 2048 op, 1000478300.00 ns, 488.5148 us/op
WorkloadActual  28: 2048 op, 973696200.00 ns, 475.4376 us/op
WorkloadActual  29: 2048 op, 1001971500.00 ns, 489.2439 us/op
WorkloadActual  30: 2048 op, 956369300.00 ns, 466.9772 us/op
WorkloadActual  31: 2048 op, 975269200.00 ns, 476.2057 us/op
WorkloadActual  32: 2048 op, 954446000.00 ns, 466.0381 us/op
WorkloadActual  33: 2048 op, 956763100.00 ns, 467.1695 us/op
WorkloadActual  34: 2048 op, 994440200.00 ns, 485.5665 us/op
WorkloadActual  35: 2048 op, 1036739600.00 ns, 506.2205 us/op
WorkloadActual  36: 2048 op, 981708200.00 ns, 479.3497 us/op
WorkloadActual  37: 2048 op, 1220765000.00 ns, 596.0767 us/op
WorkloadActual  38: 2048 op, 1054319400.00 ns, 514.8044 us/op
WorkloadActual  39: 2048 op, 1016624100.00 ns, 496.3985 us/op
WorkloadActual  40: 2048 op, 1000651300.00 ns, 488.5993 us/op
WorkloadActual  41: 2048 op, 1006251600.00 ns, 491.3338 us/op
WorkloadActual  42: 2048 op, 1041125500.00 ns, 508.3621 us/op
WorkloadActual  43: 2048 op, 963918300.00 ns, 470.6632 us/op
WorkloadActual  44: 2048 op, 974994900.00 ns, 476.0717 us/op
WorkloadActual  45: 2048 op, 968758900.00 ns, 473.0268 us/op
WorkloadActual  46: 2048 op, 1017636900.00 ns, 496.8930 us/op
WorkloadActual  47: 2048 op, 960941900.00 ns, 469.2099 us/op
WorkloadActual  48: 2048 op, 1036281200.00 ns, 505.9967 us/op
WorkloadActual  49: 2048 op, 977973500.00 ns, 477.5261 us/op
WorkloadActual  50: 2048 op, 986362400.00 ns, 481.6223 us/op
WorkloadActual  51: 2048 op, 946593400.00 ns, 462.2038 us/op
WorkloadActual  52: 2048 op, 975499300.00 ns, 476.3180 us/op
WorkloadActual  53: 2048 op, 957080200.00 ns, 467.3243 us/op
WorkloadActual  54: 2048 op, 965933100.00 ns, 471.6470 us/op
WorkloadActual  55: 2048 op, 966767200.00 ns, 472.0543 us/op
WorkloadActual  56: 2048 op, 1019018100.00 ns, 497.5674 us/op
WorkloadActual  57: 2048 op, 1011128800.00 ns, 493.7152 us/op
WorkloadActual  58: 2048 op, 961057700.00 ns, 469.2665 us/op
WorkloadActual  59: 2048 op, 949262700.00 ns, 463.5072 us/op
WorkloadActual  60: 2048 op, 1036824700.00 ns, 506.2621 us/op
WorkloadActual  61: 2048 op, 994851700.00 ns, 485.7674 us/op
WorkloadActual  62: 2048 op, 1031215400.00 ns, 503.5231 us/op
WorkloadActual  63: 2048 op, 989239600.00 ns, 483.0271 us/op
WorkloadActual  64: 2048 op, 1020034900.00 ns, 498.0639 us/op
WorkloadActual  65: 2048 op, 987934600.00 ns, 482.3899 us/op
WorkloadActual  66: 2048 op, 1056086600.00 ns, 515.6673 us/op

// AfterActualRun
WorkloadResult   1: 2048 op, 989504200.00 ns, 483.1563 us/op
WorkloadResult   2: 2048 op, 951057200.00 ns, 464.3834 us/op
WorkloadResult   3: 2048 op, 965446800.00 ns, 471.4096 us/op
WorkloadResult   4: 2048 op, 1036218600.00 ns, 505.9661 us/op
WorkloadResult   5: 2048 op, 979063500.00 ns, 478.0583 us/op
WorkloadResult   6: 2048 op, 999938800.00 ns, 488.2514 us/op
WorkloadResult   7: 2048 op, 1018497400.00 ns, 497.3132 us/op
WorkloadResult   8: 2048 op, 1041420200.00 ns, 508.5060 us/op
WorkloadResult   9: 2048 op, 1056868900.00 ns, 516.0493 us/op
WorkloadResult  10: 2048 op, 1054859000.00 ns, 515.0679 us/op
WorkloadResult  11: 2048 op, 1136564600.00 ns, 554.9632 us/op
WorkloadResult  12: 2048 op, 981766600.00 ns, 479.3782 us/op
WorkloadResult  13: 2048 op, 945203000.00 ns, 461.5249 us/op
WorkloadResult  14: 2048 op, 1052046000.00 ns, 513.6943 us/op
WorkloadResult  15: 2048 op, 983945800.00 ns, 480.4423 us/op
WorkloadResult  16: 2048 op, 954371500.00 ns, 466.0017 us/op
WorkloadResult  17: 2048 op, 987776100.00 ns, 482.3125 us/op
WorkloadResult  18: 2048 op, 954727200.00 ns, 466.1754 us/op
WorkloadResult  19: 2048 op, 1075793300.00 ns, 525.2897 us/op
WorkloadResult  20: 2048 op, 983912700.00 ns, 480.4261 us/op
WorkloadResult  21: 2048 op, 1016976000.00 ns, 496.5703 us/op
WorkloadResult  22: 2048 op, 1000473500.00 ns, 488.5125 us/op
WorkloadResult  23: 2048 op, 973691400.00 ns, 475.4353 us/op
WorkloadResult  24: 2048 op, 1001966700.00 ns, 489.2416 us/op
WorkloadResult  25: 2048 op, 956364500.00 ns, 466.9749 us/op
WorkloadResult  26: 2048 op, 975264400.00 ns, 476.2033 us/op
WorkloadResult  27: 2048 op, 954441200.00 ns, 466.0357 us/op
WorkloadResult  28: 2048 op, 956758300.00 ns, 467.1671 us/op
WorkloadResult  29: 2048 op, 994435400.00 ns, 485.5642 us/op
WorkloadResult  30: 2048 op, 1036734800.00 ns, 506.2182 us/op
WorkloadResult  31: 2048 op, 981703400.00 ns, 479.3474 us/op
WorkloadResult  32: 2048 op, 1054314600.00 ns, 514.8021 us/op
WorkloadResult  33: 2048 op, 1016619300.00 ns, 496.3961 us/op
WorkloadResult  34: 2048 op, 1000646500.00 ns, 488.5969 us/op
WorkloadResult  35: 2048 op, 1006246800.00 ns, 491.3314 us/op
WorkloadResult  36: 2048 op, 1041120700.00 ns, 508.3597 us/op
WorkloadResult  37: 2048 op, 963913500.00 ns, 470.6609 us/op
WorkloadResult  38: 2048 op, 974990100.00 ns, 476.0694 us/op
WorkloadResult  39: 2048 op, 968754100.00 ns, 473.0245 us/op
WorkloadResult  40: 2048 op, 1017632100.00 ns, 496.8907 us/op
WorkloadResult  41: 2048 op, 960937100.00 ns, 469.2076 us/op
WorkloadResult  42: 2048 op, 1036276400.00 ns, 505.9943 us/op
WorkloadResult  43: 2048 op, 977968700.00 ns, 477.5238 us/op
WorkloadResult  44: 2048 op, 986357600.00 ns, 481.6199 us/op
WorkloadResult  45: 2048 op, 946588600.00 ns, 462.2015 us/op
WorkloadResult  46: 2048 op, 975494500.00 ns, 476.3157 us/op
WorkloadResult  47: 2048 op, 957075400.00 ns, 467.3220 us/op
WorkloadResult  48: 2048 op, 965928300.00 ns, 471.6447 us/op
WorkloadResult  49: 2048 op, 966762400.00 ns, 472.0520 us/op
WorkloadResult  50: 2048 op, 1019013300.00 ns, 497.5651 us/op
WorkloadResult  51: 2048 op, 1011124000.00 ns, 493.7129 us/op
WorkloadResult  52: 2048 op, 961052900.00 ns, 469.2641 us/op
WorkloadResult  53: 2048 op, 949257900.00 ns, 463.5048 us/op
WorkloadResult  54: 2048 op, 1036819900.00 ns, 506.2597 us/op
WorkloadResult  55: 2048 op, 994846900.00 ns, 485.7651 us/op
WorkloadResult  56: 2048 op, 1031210600.00 ns, 503.5208 us/op
WorkloadResult  57: 2048 op, 989234800.00 ns, 483.0248 us/op
WorkloadResult  58: 2048 op, 1020030100.00 ns, 498.0616 us/op
WorkloadResult  59: 2048 op, 987929800.00 ns, 482.3876 us/op
WorkloadResult  60: 2048 op, 1056081800.00 ns, 515.6649 us/op
// GC:  182 0 0 2293727232 2048
// Threading:  0 0 2048

// AfterAll
// Benchmark Process 103028 has exited with code 0.

Mean = 487.240 us, StdErr = 2.433 us (0.50%), N = 60, StdDev = 18.843 us
Min = 461.525 us, Q1 = 471.950 us, Median = 482.706 us, Q3 = 497.689 us, Max = 554.963 us
IQR = 25.739 us, LowerFence = 433.342 us, UpperFence = 536.298 us
ConfidenceInterval = [478.815 us; 495.664 us] (CI 99.9%), Margin = 8.425 us (1.73% of Mean)
Skewness = 0.95, Kurtosis = 4, MValue = 2

// **Remained 10 (83,3%) benchmark(s) to run. Estimated finish 2025-07-16 21:56 (0h 13m from now)**
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Wysoka wydajność)
// **************************
// Benchmark: Benchmark.JsonDeserialization: DefaultJob [Size=10000]
// ***Execute***
// Launch: 1 / 1
// Execute: dotnet gRPCVsJSON-DefaultJob-1.dll --anonymousPipes 884 1440 --benchmarkName "gRPCVsJSON.Benchmark.JsonDeserialization(Size: 10000)" --job Default --benchmarkId 2 in *
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 99500.00 ns, 99.5000 us/op
WorkloadJitting  1: 1 op, 18426300.00 ns, 18.4263 ms/op

OverheadJitting  2: 16 op, 238500.00 ns, 14.9063 us/op
WorkloadJitting  2: 16 op, 215092800.00 ns, 13.4433 ms/op

WorkloadPilot    1: 16 op, 213547800.00 ns, 13.3467 ms/op
WorkloadPilot    2: 32 op, 232841500.00 ns, 7.2763 ms/op
WorkloadPilot    3: 64 op, 158865800.00 ns, 2.4823 ms/op
WorkloadPilot    4: 128 op, 305531500.00 ns, 2.3870 ms/op
WorkloadPilot    5: 256 op, 635779900.00 ns, 2.4835 ms/op

OverheadWarmup   1: 256 op, 4200.00 ns, 16.4063 ns/op
OverheadWarmup   2: 256 op, 1500.00 ns, 5.8594 ns/op
OverheadWarmup   3: 256 op, 1500.00 ns, 5.8594 ns/op
OverheadWarmup   4: 256 op, 2500.00 ns, 9.7656 ns/op
OverheadWarmup   5: 256 op, 2300.00 ns, 8.9844 ns/op
OverheadWarmup   6: 256 op, 2400.00 ns, 9.3750 ns/op

OverheadActual   1: 256 op, 1500.00 ns, 5.8594 ns/op
OverheadActual   2: 256 op, 2300.00 ns, 8.9844 ns/op
OverheadActual   3: 256 op, 2200.00 ns, 8.5938 ns/op
OverheadActual   4: 256 op, 1900.00 ns, 7.4219 ns/op
OverheadActual   5: 256 op, 3700.00 ns, 14.4531 ns/op
OverheadActual   6: 256 op, 2600.00 ns, 10.1563 ns/op
OverheadActual   7: 256 op, 2400.00 ns, 9.3750 ns/op
OverheadActual   8: 256 op, 1900.00 ns, 7.4219 ns/op
OverheadActual   9: 256 op, 2000.00 ns, 7.8125 ns/op
OverheadActual  10: 256 op, 2600.00 ns, 10.1563 ns/op
OverheadActual  11: 256 op, 3000.00 ns, 11.7188 ns/op
OverheadActual  12: 256 op, 2500.00 ns, 9.7656 ns/op
OverheadActual  13: 256 op, 2100.00 ns, 8.2031 ns/op
OverheadActual  14: 256 op, 2300.00 ns, 8.9844 ns/op
OverheadActual  15: 256 op, 2500.00 ns, 9.7656 ns/op
OverheadActual  16: 256 op, 1700.00 ns, 6.6406 ns/op
OverheadActual  17: 256 op, 2500.00 ns, 9.7656 ns/op
OverheadActual  18: 256 op, 2000.00 ns, 7.8125 ns/op
OverheadActual  19: 256 op, 1700.00 ns, 6.6406 ns/op
OverheadActual  20: 256 op, 1700.00 ns, 6.6406 ns/op

OverheadWarmup   1: 256 op, 1800.00 ns, 7.0313 ns/op
OverheadWarmup   2: 256 op, 1800.00 ns, 7.0313 ns/op
OverheadWarmup   3: 256 op, 1600.00 ns, 6.2500 ns/op
OverheadWarmup   4: 256 op, 2200.00 ns, 8.5938 ns/op
OverheadWarmup   5: 256 op, 2200.00 ns, 8.5938 ns/op
OverheadWarmup   6: 256 op, 2600.00 ns, 10.1563 ns/op

// BeforeActualRun
WorkloadActual   1: 256 op, 646189700.00 ns, 2.5242 ms/op
WorkloadActual   2: 256 op, 607045400.00 ns, 2.3713 ms/op
WorkloadActual   3: 256 op, 609541400.00 ns, 2.3810 ms/op
WorkloadActual   4: 256 op, 599926700.00 ns, 2.3435 ms/op
WorkloadActual   5: 256 op, 607000300.00 ns, 2.3711 ms/op
WorkloadActual   6: 256 op, 591740900.00 ns, 2.3115 ms/op
WorkloadActual   7: 256 op, 605724400.00 ns, 2.3661 ms/op
WorkloadActual   8: 256 op, 593274900.00 ns, 2.3175 ms/op
WorkloadActual   9: 256 op, 588252200.00 ns, 2.2979 ms/op
WorkloadActual  10: 256 op, 617920900.00 ns, 2.4138 ms/op
WorkloadActual  11: 256 op, 639626400.00 ns, 2.4985 ms/op
WorkloadActual  12: 256 op, 659890700.00 ns, 2.5777 ms/op
WorkloadActual  13: 256 op, 613426600.00 ns, 2.3962 ms/op
WorkloadActual  14: 256 op, 608923400.00 ns, 2.3786 ms/op
WorkloadActual  15: 256 op, 602712100.00 ns, 2.3543 ms/op

// AfterActualRun
WorkloadResult   1: 256 op, 607043150.00 ns, 2.3713 ms/op
WorkloadResult   2: 256 op, 609539150.00 ns, 2.3810 ms/op
WorkloadResult   3: 256 op, 599924450.00 ns, 2.3435 ms/op
WorkloadResult   4: 256 op, 606998050.00 ns, 2.3711 ms/op
WorkloadResult   5: 256 op, 591738650.00 ns, 2.3115 ms/op
WorkloadResult   6: 256 op, 605722150.00 ns, 2.3661 ms/op
WorkloadResult   7: 256 op, 593272650.00 ns, 2.3175 ms/op
WorkloadResult   8: 256 op, 588249950.00 ns, 2.2979 ms/op
WorkloadResult   9: 256 op, 617918650.00 ns, 2.4137 ms/op
WorkloadResult  10: 256 op, 613424350.00 ns, 2.3962 ms/op
WorkloadResult  11: 256 op, 608921150.00 ns, 2.3786 ms/op
WorkloadResult  12: 256 op, 602709850.00 ns, 2.3543 ms/op
// GC:  16 0 0 204800000 256
// Threading:  0 0 256

// AfterAll
// Benchmark Process 112592 has exited with code 0.

Mean = 2.359 ms, StdErr = 0.010 ms (0.43%), N = 12, StdDev = 0.035 ms
Min = 2.298 ms, Q1 = 2.337 ms, Median = 2.369 ms, Q3 = 2.379 ms, Max = 2.414 ms
IQR = 0.042 ms, LowerFence = 2.274 ms, UpperFence = 2.443 ms
ConfidenceInterval = [2.314 ms; 2.404 ms] (CI 99.9%), Margin = 0.045 ms (1.91% of Mean)
Skewness = -0.3, Kurtosis = 1.81, MValue = 2

// **Remained 9 (75,0%) benchmark(s) to run. Estimated finish 2025-07-16 21:51 (0h 8m from now)**
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Wysoka wydajność)
// **************************
// Benchmark: Benchmark.ProtobufDeserialization: DefaultJob [Size=10000]
// ***Execute***
// Launch: 1 / 1
// Execute: dotnet gRPCVsJSON-DefaultJob-1.dll --anonymousPipes 1756 1744 --benchmarkName "gRPCVsJSON.Benchmark.ProtobufDeserialization(Size: 10000)" --job Default --benchmarkId 3 in *
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 84400.00 ns, 84.4000 us/op
WorkloadJitting  1: 1 op, 5538100.00 ns, 5.5381 ms/op

OverheadJitting  2: 16 op, 196600.00 ns, 12.2875 us/op
WorkloadJitting  2: 16 op, 31944700.00 ns, 1.9965 ms/op

WorkloadPilot    1: 16 op, 28881100.00 ns, 1.8051 ms/op
WorkloadPilot    2: 32 op, 54629400.00 ns, 1.7072 ms/op
WorkloadPilot    3: 64 op, 141762200.00 ns, 2.2150 ms/op
WorkloadPilot    4: 128 op, 127398200.00 ns, 995.2984 us/op
WorkloadPilot    5: 256 op, 238484700.00 ns, 931.5809 us/op
WorkloadPilot    6: 512 op, 464537400.00 ns, 907.2996 us/op
WorkloadPilot    7: 1024 op, 955843500.00 ns, 933.4409 us/op

OverheadWarmup   1: 1024 op, 6600.00 ns, 6.4453 ns/op
OverheadWarmup   2: 1024 op, 3100.00 ns, 3.0273 ns/op
OverheadWarmup   3: 1024 op, 3700.00 ns, 3.6133 ns/op
OverheadWarmup   4: 1024 op, 3500.00 ns, 3.4180 ns/op
OverheadWarmup   5: 1024 op, 3300.00 ns, 3.2227 ns/op
OverheadWarmup   6: 1024 op, 4000.00 ns, 3.9063 ns/op
OverheadWarmup   7: 1024 op, 2900.00 ns, 2.8320 ns/op

OverheadActual   1: 1024 op, 4600.00 ns, 4.4922 ns/op
OverheadActual   2: 1024 op, 3300.00 ns, 3.2227 ns/op
OverheadActual   3: 1024 op, 2900.00 ns, 2.8320 ns/op
OverheadActual   4: 1024 op, 3400.00 ns, 3.3203 ns/op
OverheadActual   5: 1024 op, 3600.00 ns, 3.5156 ns/op
OverheadActual   6: 1024 op, 3100.00 ns, 3.0273 ns/op
OverheadActual   7: 1024 op, 2900.00 ns, 2.8320 ns/op
OverheadActual   8: 1024 op, 3900.00 ns, 3.8086 ns/op
OverheadActual   9: 1024 op, 5700.00 ns, 5.5664 ns/op
OverheadActual  10: 1024 op, 3700.00 ns, 3.6133 ns/op
OverheadActual  11: 1024 op, 3300.00 ns, 3.2227 ns/op
OverheadActual  12: 1024 op, 3700.00 ns, 3.6133 ns/op
OverheadActual  13: 1024 op, 5000.00 ns, 4.8828 ns/op
OverheadActual  14: 1024 op, 3800.00 ns, 3.7109 ns/op
OverheadActual  15: 1024 op, 3500.00 ns, 3.4180 ns/op
OverheadActual  16: 1024 op, 3100.00 ns, 3.0273 ns/op
OverheadActual  17: 1024 op, 4800.00 ns, 4.6875 ns/op
OverheadActual  18: 1024 op, 3200.00 ns, 3.1250 ns/op
OverheadActual  19: 1024 op, 4300.00 ns, 4.1992 ns/op
OverheadActual  20: 1024 op, 3700.00 ns, 3.6133 ns/op

OverheadWarmup   1: 1024 op, 4000.00 ns, 3.9063 ns/op
OverheadWarmup   2: 1024 op, 3500.00 ns, 3.4180 ns/op
OverheadWarmup   3: 1024 op, 4100.00 ns, 4.0039 ns/op
OverheadWarmup   4: 1024 op, 3300.00 ns, 3.2227 ns/op
OverheadWarmup   5: 1024 op, 3200.00 ns, 3.1250 ns/op
OverheadWarmup   6: 1024 op, 3200.00 ns, 3.1250 ns/op
OverheadWarmup   7: 1024 op, 2800.00 ns, 2.7344 ns/op

// BeforeActualRun
WorkloadActual   1: 1024 op, 938440900.00 ns, 916.4462 us/op
WorkloadActual   2: 1024 op, 939005500.00 ns, 916.9976 us/op
WorkloadActual   3: 1024 op, 939671000.00 ns, 917.6475 us/op
WorkloadActual   4: 1024 op, 925721100.00 ns, 904.0245 us/op
WorkloadActual   5: 1024 op, 924864300.00 ns, 903.1878 us/op
WorkloadActual   6: 1024 op, 906430800.00 ns, 885.1863 us/op
WorkloadActual   7: 1024 op, 935642000.00 ns, 913.7129 us/op
WorkloadActual   8: 1024 op, 929579000.00 ns, 907.7920 us/op
WorkloadActual   9: 1024 op, 958373000.00 ns, 935.9111 us/op
WorkloadActual  10: 1024 op, 934183500.00 ns, 912.2886 us/op
WorkloadActual  11: 1024 op, 911733700.00 ns, 890.3649 us/op
WorkloadActual  12: 1024 op, 1096462700.00 ns, 1.0708 ms/op
WorkloadActual  13: 1024 op, 1151765200.00 ns, 1.1248 ms/op
WorkloadActual  14: 1024 op, 1133160000.00 ns, 1.1066 ms/op
WorkloadActual  15: 1024 op, 1047579200.00 ns, 1.0230 ms/op
WorkloadActual  16: 1024 op, 1056930600.00 ns, 1.0322 ms/op
WorkloadActual  17: 1024 op, 957012900.00 ns, 934.5829 us/op
WorkloadActual  18: 1024 op, 1030797400.00 ns, 1.0066 ms/op
WorkloadActual  19: 1024 op, 911074200.00 ns, 889.7209 us/op
WorkloadActual  20: 1024 op, 950843600.00 ns, 928.5582 us/op
WorkloadActual  21: 1024 op, 911918500.00 ns, 890.5454 us/op
WorkloadActual  22: 1024 op, 933117400.00 ns, 911.2475 us/op
WorkloadActual  23: 1024 op, 1007163000.00 ns, 983.5576 us/op
WorkloadActual  24: 1024 op, 1008221000.00 ns, 984.5908 us/op
WorkloadActual  25: 1024 op, 908694700.00 ns, 887.3972 us/op
WorkloadActual  26: 1024 op, 896922200.00 ns, 875.9006 us/op
WorkloadActual  27: 1024 op, 886113900.00 ns, 865.3456 us/op
WorkloadActual  28: 1024 op, 913242300.00 ns, 891.8382 us/op
WorkloadActual  29: 1024 op, 896543600.00 ns, 875.5309 us/op
WorkloadActual  30: 1024 op, 893270300.00 ns, 872.3343 us/op
WorkloadActual  31: 1024 op, 926265100.00 ns, 904.5558 us/op
WorkloadActual  32: 1024 op, 910264800.00 ns, 888.9305 us/op
WorkloadActual  33: 1024 op, 922291000.00 ns, 900.6748 us/op
WorkloadActual  34: 1024 op, 921416800.00 ns, 899.8211 us/op
WorkloadActual  35: 1024 op, 895818100.00 ns, 874.8224 us/op
WorkloadActual  36: 1024 op, 1045776300.00 ns, 1.0213 ms/op
WorkloadActual  37: 1024 op, 982458900.00 ns, 959.4325 us/op
WorkloadActual  38: 1024 op, 916154200.00 ns, 894.6818 us/op
WorkloadActual  39: 1024 op, 913675300.00 ns, 892.2610 us/op
WorkloadActual  40: 1024 op, 889507900.00 ns, 868.6601 us/op
WorkloadActual  41: 1024 op, 920706600.00 ns, 899.1275 us/op

// AfterActualRun
WorkloadResult   1: 1024 op, 938437250.00 ns, 916.4426 us/op
WorkloadResult   2: 1024 op, 939001850.00 ns, 916.9940 us/op
WorkloadResult   3: 1024 op, 939667350.00 ns, 917.6439 us/op
WorkloadResult   4: 1024 op, 925717450.00 ns, 904.0209 us/op
WorkloadResult   5: 1024 op, 924860650.00 ns, 903.1842 us/op
WorkloadResult   6: 1024 op, 906427150.00 ns, 885.1828 us/op
WorkloadResult   7: 1024 op, 935638350.00 ns, 913.7093 us/op
WorkloadResult   8: 1024 op, 929575350.00 ns, 907.7884 us/op
WorkloadResult   9: 1024 op, 958369350.00 ns, 935.9076 us/op
WorkloadResult  10: 1024 op, 934179850.00 ns, 912.2850 us/op
WorkloadResult  11: 1024 op, 911730050.00 ns, 890.3614 us/op
WorkloadResult  12: 1024 op, 957009250.00 ns, 934.5793 us/op
WorkloadResult  13: 1024 op, 911070550.00 ns, 889.7173 us/op
WorkloadResult  14: 1024 op, 950839950.00 ns, 928.5546 us/op
WorkloadResult  15: 1024 op, 911914850.00 ns, 890.5418 us/op
WorkloadResult  16: 1024 op, 933113750.00 ns, 911.2439 us/op
WorkloadResult  17: 1024 op, 1007159350.00 ns, 983.5541 us/op
WorkloadResult  18: 1024 op, 1008217350.00 ns, 984.5873 us/op
WorkloadResult  19: 1024 op, 908691050.00 ns, 887.3936 us/op
WorkloadResult  20: 1024 op, 896918550.00 ns, 875.8970 us/op
WorkloadResult  21: 1024 op, 886110250.00 ns, 865.3420 us/op
WorkloadResult  22: 1024 op, 913238650.00 ns, 891.8346 us/op
WorkloadResult  23: 1024 op, 896539950.00 ns, 875.5273 us/op
WorkloadResult  24: 1024 op, 893266650.00 ns, 872.3307 us/op
WorkloadResult  25: 1024 op, 926261450.00 ns, 904.5522 us/op
WorkloadResult  26: 1024 op, 910261150.00 ns, 888.9269 us/op
WorkloadResult  27: 1024 op, 922287350.00 ns, 900.6712 us/op
WorkloadResult  28: 1024 op, 921413150.00 ns, 899.8175 us/op
WorkloadResult  29: 1024 op, 895814450.00 ns, 874.8188 us/op
WorkloadResult  30: 1024 op, 982455250.00 ns, 959.4290 us/op
WorkloadResult  31: 1024 op, 916150550.00 ns, 894.6783 us/op
WorkloadResult  32: 1024 op, 913671650.00 ns, 892.2575 us/op
WorkloadResult  33: 1024 op, 889504250.00 ns, 868.6565 us/op
WorkloadResult  34: 1024 op, 920702950.00 ns, 899.1240 us/op
// GC:  215 0 0 2703360000 1024
// Threading:  0 0 1024

// AfterAll
// Benchmark Process 93820 has exited with code 0.

Mean = 905.222 us, StdErr = 4.923 us (0.54%), N = 34, StdDev = 28.706 us
Min = 865.342 us, Q1 = 889.125 us, Median = 900.244 us, Q3 = 915.759 us, Max = 984.587 us
IQR = 26.635 us, LowerFence = 849.172 us, UpperFence = 955.711 us
ConfidenceInterval = [887.446 us; 922.999 us] (CI 99.9%), Margin = 17.777 us (1.96% of Mean)
Skewness = 1.18, Kurtosis = 4.17, MValue = 2

// **Remained 8 (66,7%) benchmark(s) to run. Estimated finish 2025-07-16 21:51 (0h 7m from now)**
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Wysoka wydajność)
// **************************
// Benchmark: Benchmark.JsonSerialization: DefaultJob [Size=100000]
// ***Execute***
// Launch: 1 / 1
// Execute: dotnet gRPCVsJSON-DefaultJob-1.dll --anonymousPipes 880 888 --benchmarkName "gRPCVsJSON.Benchmark.JsonSerialization(Size: 100000)" --job Default --benchmarkId 4 in *
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 102900.00 ns, 102.9000 us/op
WorkloadJitting  1: 1 op, 43644400.00 ns, 43.6444 ms/op

WorkloadPilot    1: 2 op, 76303200.00 ns, 38.1516 ms/op
WorkloadPilot    2: 3 op, 186856300.00 ns, 62.2854 ms/op
WorkloadPilot    3: 4 op, 110466700.00 ns, 27.6167 ms/op
WorkloadPilot    4: 5 op, 78335400.00 ns, 15.6671 ms/op
WorkloadPilot    5: 6 op, 92895600.00 ns, 15.4826 ms/op
WorkloadPilot    6: 7 op, 109684200.00 ns, 15.6692 ms/op
WorkloadPilot    7: 8 op, 125135300.00 ns, 15.6419 ms/op
WorkloadPilot    8: 9 op, 138358900.00 ns, 15.3732 ms/op
WorkloadPilot    9: 10 op, 153021300.00 ns, 15.3021 ms/op
WorkloadPilot   10: 11 op, 183312900.00 ns, 16.6648 ms/op
WorkloadPilot   11: 12 op, 201903900.00 ns, 16.8253 ms/op
WorkloadPilot   12: 13 op, 217135900.00 ns, 16.7028 ms/op
WorkloadPilot   13: 14 op, 219290700.00 ns, 15.6636 ms/op
WorkloadPilot   14: 15 op, 248886200.00 ns, 16.5924 ms/op
WorkloadPilot   15: 16 op, 263431700.00 ns, 16.4645 ms/op
WorkloadPilot   16: 32 op, 498955600.00 ns, 15.5924 ms/op
WorkloadPilot   17: 64 op, 983974100.00 ns, 15.3746 ms/op

OverheadWarmup   1: 64 op, 3900.00 ns, 60.9375 ns/op
OverheadWarmup   2: 64 op, 1700.00 ns, 26.5625 ns/op
OverheadWarmup   3: 64 op, 1300.00 ns, 20.3125 ns/op
OverheadWarmup   4: 64 op, 2800.00 ns, 43.7500 ns/op
OverheadWarmup   5: 64 op, 1500.00 ns, 23.4375 ns/op
OverheadWarmup   6: 64 op, 1000.00 ns, 15.6250 ns/op
OverheadWarmup   7: 64 op, 1200.00 ns, 18.7500 ns/op
OverheadWarmup   8: 64 op, 600.00 ns, 9.3750 ns/op

// BeforeActualRun
WorkloadActual   1: 64 op, 1013606500.00 ns, 15.8376 ms/op
WorkloadActual   2: 64 op, 987810100.00 ns, 15.4345 ms/op
WorkloadActual   3: 64 op, 1027942800.00 ns, 16.0616 ms/op
WorkloadActual   4: 64 op, 1171101800.00 ns, 18.2985 ms/op
WorkloadActual   5: 64 op, 1039916200.00 ns, 16.2487 ms/op
WorkloadActual   6: 64 op, 1039402500.00 ns, 16.2407 ms/op
WorkloadActual   7: 64 op, 992231000.00 ns, 15.5036 ms/op
WorkloadActual   8: 64 op, 997158400.00 ns, 15.5806 ms/op
WorkloadActual   9: 64 op, 1039374400.00 ns, 16.2402 ms/op
WorkloadActual  10: 64 op, 987944200.00 ns, 15.4366 ms/op
WorkloadActual  11: 64 op, 998399400.00 ns, 15.6000 ms/op
WorkloadActual  12: 64 op, 1017474200.00 ns, 15.8980 ms/op
WorkloadActual  13: 64 op, 979353600.00 ns, 15.3024 ms/op
WorkloadActual  14: 64 op, 985690400.00 ns, 15.4014 ms/op
WorkloadActual  15: 64 op, 1001664600.00 ns, 15.6510 ms/op
WorkloadActual  16: 64 op, 1026153200.00 ns, 16.0336 ms/op
WorkloadActual  17: 64 op, 1005075100.00 ns, 15.7043 ms/op
WorkloadActual  18: 64 op, 990459500.00 ns, 15.4759 ms/op

// AfterActualRun
WorkloadResult   1: 64 op, 1013606500.00 ns, 15.8376 ms/op
WorkloadResult   2: 64 op, 987810100.00 ns, 15.4345 ms/op
WorkloadResult   3: 64 op, 1027942800.00 ns, 16.0616 ms/op
WorkloadResult   4: 64 op, 1039916200.00 ns, 16.2487 ms/op
WorkloadResult   5: 64 op, 1039402500.00 ns, 16.2407 ms/op
WorkloadResult   6: 64 op, 992231000.00 ns, 15.5036 ms/op
WorkloadResult   7: 64 op, 997158400.00 ns, 15.5806 ms/op
WorkloadResult   8: 64 op, 1039374400.00 ns, 16.2402 ms/op
WorkloadResult   9: 64 op, 987944200.00 ns, 15.4366 ms/op
WorkloadResult  10: 64 op, 998399400.00 ns, 15.6000 ms/op
WorkloadResult  11: 64 op, 1017474200.00 ns, 15.8980 ms/op
WorkloadResult  12: 64 op, 979353600.00 ns, 15.3024 ms/op
WorkloadResult  13: 64 op, 985690400.00 ns, 15.4014 ms/op
WorkloadResult  14: 64 op, 1001664600.00 ns, 15.6510 ms/op
WorkloadResult  15: 64 op, 1026153200.00 ns, 16.0336 ms/op
WorkloadResult  16: 64 op, 1005075100.00 ns, 15.7043 ms/op
WorkloadResult  17: 64 op, 990459500.00 ns, 15.4759 ms/op
// GC:  63 0 0 791065088 64
// Threading:  0 0 64

// AfterAll
// Benchmark Process 119212 has exited with code 0.

Mean = 15.744 ms, StdErr = 0.078 ms (0.50%), N = 17, StdDev = 0.322 ms
Min = 15.302 ms, Q1 = 15.476 ms, Median = 15.651 ms, Q3 = 16.034 ms, Max = 16.249 ms
IQR = 0.558 ms, LowerFence = 14.639 ms, UpperFence = 16.870 ms
ConfidenceInterval = [15.431 ms; 16.057 ms] (CI 99.9%), Margin = 0.313 ms (1.99% of Mean)
Skewness = 0.37, Kurtosis = 1.56, MValue = 2

// **Remained 7 (58,3%) benchmark(s) to run. Estimated finish 2025-07-16 21:50 (0h 5m from now)**
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Wysoka wydajność)
// **************************
// Benchmark: Benchmark.ProtobufSerialization: DefaultJob [Size=100000]
// ***Execute***
// Launch: 1 / 1
// Execute: dotnet gRPCVsJSON-DefaultJob-1.dll --anonymousPipes 888 1456 --benchmarkName "gRPCVsJSON.Benchmark.ProtobufSerialization(Size: 100000)" --job Default --benchmarkId 5 in **
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 97900.00 ns, 97.9000 us/op
WorkloadJitting  1: 1 op, 21340500.00 ns, 21.3405 ms/op

OverheadJitting  2: 16 op, 271100.00 ns, 16.9438 us/op
WorkloadJitting  2: 16 op, 244861100.00 ns, 15.3038 ms/op

WorkloadPilot    1: 16 op, 104079100.00 ns, 6.5049 ms/op
WorkloadPilot    2: 32 op, 217817300.00 ns, 6.8068 ms/op
WorkloadPilot    3: 64 op, 452821500.00 ns, 7.0753 ms/op
WorkloadPilot    4: 128 op, 877211500.00 ns, 6.8532 ms/op

OverheadWarmup   1: 128 op, 4000.00 ns, 31.2500 ns/op
OverheadWarmup   2: 128 op, 1900.00 ns, 14.8438 ns/op
OverheadWarmup   3: 128 op, 2300.00 ns, 17.9688 ns/op
OverheadWarmup   4: 128 op, 1800.00 ns, 14.0625 ns/op
OverheadWarmup   5: 128 op, 1300.00 ns, 10.1563 ns/op
OverheadWarmup   6: 128 op, 2400.00 ns, 18.7500 ns/op
OverheadWarmup   7: 128 op, 2700.00 ns, 21.0938 ns/op
OverheadWarmup   8: 128 op, 1800.00 ns, 14.0625 ns/op

OverheadActual   1: 128 op, 7400.00 ns, 57.8125 ns/op
OverheadActual   2: 128 op, 1800.00 ns, 14.0625 ns/op
OverheadActual   3: 128 op, 2100.00 ns, 16.4063 ns/op
OverheadActual   4: 128 op, 2300.00 ns, 17.9688 ns/op
OverheadActual   5: 128 op, 2200.00 ns, 17.1875 ns/op
OverheadActual   6: 128 op, 1700.00 ns, 13.2813 ns/op
OverheadActual   7: 128 op, 1200.00 ns, 9.3750 ns/op
OverheadActual   8: 128 op, 1300.00 ns, 10.1563 ns/op
OverheadActual   9: 128 op, 1700.00 ns, 13.2813 ns/op
OverheadActual  10: 128 op, 1300.00 ns, 10.1563 ns/op
OverheadActual  11: 128 op, 1400.00 ns, 10.9375 ns/op
OverheadActual  12: 128 op, 1600.00 ns, 12.5000 ns/op
OverheadActual  13: 128 op, 1100.00 ns, 8.5938 ns/op
OverheadActual  14: 128 op, 1500.00 ns, 11.7188 ns/op
OverheadActual  15: 128 op, 1500.00 ns, 11.7188 ns/op
OverheadActual  16: 128 op, 1000.00 ns, 7.8125 ns/op
OverheadActual  17: 128 op, 1800.00 ns, 14.0625 ns/op
OverheadActual  18: 128 op, 1100.00 ns, 8.5938 ns/op
OverheadActual  19: 128 op, 1200.00 ns, 9.3750 ns/op
OverheadActual  20: 128 op, 1200.00 ns, 9.3750 ns/op

OverheadWarmup   1: 128 op, 1500.00 ns, 11.7188 ns/op
OverheadWarmup   2: 128 op, 1000.00 ns, 7.8125 ns/op
OverheadWarmup   3: 128 op, 1500.00 ns, 11.7188 ns/op
OverheadWarmup   4: 128 op, 1700.00 ns, 13.2813 ns/op
OverheadWarmup   5: 128 op, 1200.00 ns, 9.3750 ns/op
OverheadWarmup   6: 128 op, 1500.00 ns, 11.7188 ns/op
OverheadWarmup   7: 128 op, 1200.00 ns, 9.3750 ns/op

// BeforeActualRun
WorkloadActual   1: 128 op, 892744900.00 ns, 6.9746 ms/op
WorkloadActual   2: 128 op, 877020500.00 ns, 6.8517 ms/op
WorkloadActual   3: 128 op, 855903700.00 ns, 6.6867 ms/op
WorkloadActual   4: 128 op, 897600800.00 ns, 7.0125 ms/op
WorkloadActual   5: 128 op, 925066600.00 ns, 7.2271 ms/op
WorkloadActual   6: 128 op, 861188600.00 ns, 6.7280 ms/op
WorkloadActual   7: 128 op, 853071200.00 ns, 6.6646 ms/op
WorkloadActual   8: 128 op, 825663400.00 ns, 6.4505 ms/op
WorkloadActual   9: 128 op, 911655300.00 ns, 7.1223 ms/op
WorkloadActual  10: 128 op, 852364400.00 ns, 6.6591 ms/op
WorkloadActual  11: 128 op, 857349900.00 ns, 6.6980 ms/op
WorkloadActual  12: 128 op, 866441000.00 ns, 6.7691 ms/op
WorkloadActual  13: 128 op, 847875800.00 ns, 6.6240 ms/op
WorkloadActual  14: 128 op, 1039047300.00 ns, 8.1176 ms/op
WorkloadActual  15: 128 op, 935571200.00 ns, 7.3092 ms/op
WorkloadActual  16: 128 op, 1200695400.00 ns, 9.3804 ms/op
WorkloadActual  17: 128 op, 925451700.00 ns, 7.2301 ms/op
WorkloadActual  18: 128 op, 1028329700.00 ns, 8.0338 ms/op
WorkloadActual  19: 128 op, 945561200.00 ns, 7.3872 ms/op
WorkloadActual  20: 128 op, 932534100.00 ns, 7.2854 ms/op
WorkloadActual  21: 128 op, 946219800.00 ns, 7.3923 ms/op
WorkloadActual  22: 128 op, 1020298300.00 ns, 7.9711 ms/op
WorkloadActual  23: 128 op, 996784300.00 ns, 7.7874 ms/op
WorkloadActual  24: 128 op, 992335900.00 ns, 7.7526 ms/op
WorkloadActual  25: 128 op, 1031636600.00 ns, 8.0597 ms/op
WorkloadActual  26: 128 op, 1058843100.00 ns, 8.2722 ms/op
WorkloadActual  27: 128 op, 954615000.00 ns, 7.4579 ms/op
WorkloadActual  28: 128 op, 980313200.00 ns, 7.6587 ms/op
WorkloadActual  29: 128 op, 958487900.00 ns, 7.4882 ms/op
WorkloadActual  30: 128 op, 854654800.00 ns, 6.6770 ms/op
WorkloadActual  31: 128 op, 858844500.00 ns, 6.7097 ms/op
WorkloadActual  32: 128 op, 842927200.00 ns, 6.5854 ms/op
WorkloadActual  33: 128 op, 907117300.00 ns, 7.0869 ms/op
WorkloadActual  34: 128 op, 873950700.00 ns, 6.8277 ms/op
WorkloadActual  35: 128 op, 862115600.00 ns, 6.7353 ms/op
WorkloadActual  36: 128 op, 853489100.00 ns, 6.6679 ms/op
WorkloadActual  37: 128 op, 867062400.00 ns, 6.7739 ms/op
WorkloadActual  38: 128 op, 901370100.00 ns, 7.0420 ms/op
WorkloadActual  39: 128 op, 845739500.00 ns, 6.6073 ms/op
WorkloadActual  40: 128 op, 831570400.00 ns, 6.4966 ms/op
WorkloadActual  41: 128 op, 841099900.00 ns, 6.5711 ms/op
WorkloadActual  42: 128 op, 882459600.00 ns, 6.8942 ms/op
WorkloadActual  43: 128 op, 875914300.00 ns, 6.8431 ms/op
WorkloadActual  44: 128 op, 834993800.00 ns, 6.5234 ms/op
WorkloadActual  45: 128 op, 864369000.00 ns, 6.7529 ms/op
WorkloadActual  46: 128 op, 997310600.00 ns, 7.7915 ms/op
WorkloadActual  47: 128 op, 881702000.00 ns, 6.8883 ms/op
WorkloadActual  48: 128 op, 850774800.00 ns, 6.6467 ms/op
WorkloadActual  49: 128 op, 927742400.00 ns, 7.2480 ms/op
WorkloadActual  50: 128 op, 841077000.00 ns, 6.5709 ms/op
WorkloadActual  51: 128 op, 865186700.00 ns, 6.7593 ms/op
WorkloadActual  52: 128 op, 829280800.00 ns, 6.4788 ms/op
WorkloadActual  53: 128 op, 845540200.00 ns, 6.6058 ms/op
WorkloadActual  54: 128 op, 829947600.00 ns, 6.4840 ms/op
WorkloadActual  55: 128 op, 877692600.00 ns, 6.8570 ms/op
WorkloadActual  56: 128 op, 848388900.00 ns, 6.6280 ms/op
WorkloadActual  57: 128 op, 871547900.00 ns, 6.8090 ms/op
WorkloadActual  58: 128 op, 947590300.00 ns, 7.4030 ms/op
WorkloadActual  59: 128 op, 923369400.00 ns, 7.2138 ms/op
WorkloadActual  60: 128 op, 978649400.00 ns, 7.6457 ms/op
WorkloadActual  61: 128 op, 849361600.00 ns, 6.6356 ms/op
WorkloadActual  62: 128 op, 833357600.00 ns, 6.5106 ms/op
WorkloadActual  63: 128 op, 956198100.00 ns, 7.4703 ms/op
WorkloadActual  64: 128 op, 880642700.00 ns, 6.8800 ms/op
WorkloadActual  65: 128 op, 833522200.00 ns, 6.5119 ms/op
WorkloadActual  66: 128 op, 841265400.00 ns, 6.5724 ms/op
WorkloadActual  67: 128 op, 851496500.00 ns, 6.6523 ms/op
WorkloadActual  68: 128 op, 867786700.00 ns, 6.7796 ms/op
WorkloadActual  69: 128 op, 933815300.00 ns, 7.2954 ms/op
WorkloadActual  70: 128 op, 819446100.00 ns, 6.4019 ms/op
WorkloadActual  71: 128 op, 831033300.00 ns, 6.4924 ms/op
WorkloadActual  72: 128 op, 975905100.00 ns, 7.6243 ms/op
WorkloadActual  73: 128 op, 870086700.00 ns, 6.7976 ms/op
WorkloadActual  74: 128 op, 832726200.00 ns, 6.5057 ms/op
WorkloadActual  75: 128 op, 844947000.00 ns, 6.6011 ms/op
WorkloadActual  76: 128 op, 855759200.00 ns, 6.6856 ms/op
WorkloadActual  77: 128 op, 949440200.00 ns, 7.4175 ms/op
WorkloadActual  78: 128 op, 900660400.00 ns, 7.0364 ms/op
WorkloadActual  79: 128 op, 899875400.00 ns, 7.0303 ms/op
WorkloadActual  80: 128 op, 857373200.00 ns, 6.6982 ms/op
WorkloadActual  81: 128 op, 867049100.00 ns, 6.7738 ms/op
WorkloadActual  82: 128 op, 832302700.00 ns, 6.5024 ms/op
WorkloadActual  83: 128 op, 844258800.00 ns, 6.5958 ms/op
WorkloadActual  84: 128 op, 894286900.00 ns, 6.9866 ms/op
WorkloadActual  85: 128 op, 843008100.00 ns, 6.5860 ms/op
WorkloadActual  86: 128 op, 858919300.00 ns, 6.7103 ms/op
WorkloadActual  87: 128 op, 827341800.00 ns, 6.4636 ms/op
WorkloadActual  88: 128 op, 905209700.00 ns, 7.0720 ms/op
WorkloadActual  89: 128 op, 867390600.00 ns, 6.7765 ms/op
WorkloadActual  90: 128 op, 874912300.00 ns, 6.8353 ms/op
WorkloadActual  91: 128 op, 851527200.00 ns, 6.6526 ms/op
WorkloadActual  92: 128 op, 867382000.00 ns, 6.7764 ms/op
WorkloadActual  93: 128 op, 848113800.00 ns, 6.6259 ms/op
WorkloadActual  94: 128 op, 891451400.00 ns, 6.9645 ms/op
WorkloadActual  95: 128 op, 948249200.00 ns, 7.4082 ms/op
WorkloadActual  96: 128 op, 850532000.00 ns, 6.6448 ms/op
WorkloadActual  97: 128 op, 844184500.00 ns, 6.5952 ms/op
WorkloadActual  98: 128 op, 829406000.00 ns, 6.4797 ms/op
WorkloadActual  99: 128 op, 865645700.00 ns, 6.7629 ms/op
WorkloadActual  100: 128 op, 822127700.00 ns, 6.4229 ms/op

// AfterActualRun
WorkloadResult   1: 128 op, 892743400.00 ns, 6.9746 ms/op
WorkloadResult   2: 128 op, 877019000.00 ns, 6.8517 ms/op
WorkloadResult   3: 128 op, 855902200.00 ns, 6.6867 ms/op
WorkloadResult   4: 128 op, 897599300.00 ns, 7.0125 ms/op
WorkloadResult   5: 128 op, 925065100.00 ns, 7.2271 ms/op
WorkloadResult   6: 128 op, 861187100.00 ns, 6.7280 ms/op
WorkloadResult   7: 128 op, 853069700.00 ns, 6.6646 ms/op
WorkloadResult   8: 128 op, 825661900.00 ns, 6.4505 ms/op
WorkloadResult   9: 128 op, 911653800.00 ns, 7.1223 ms/op
WorkloadResult  10: 128 op, 852362900.00 ns, 6.6591 ms/op
WorkloadResult  11: 128 op, 857348400.00 ns, 6.6980 ms/op
WorkloadResult  12: 128 op, 866439500.00 ns, 6.7691 ms/op
WorkloadResult  13: 128 op, 847874300.00 ns, 6.6240 ms/op
WorkloadResult  14: 128 op, 1039045800.00 ns, 8.1175 ms/op
WorkloadResult  15: 128 op, 935569700.00 ns, 7.3091 ms/op
WorkloadResult  16: 128 op, 925450200.00 ns, 7.2301 ms/op
WorkloadResult  17: 128 op, 1028328200.00 ns, 8.0338 ms/op
WorkloadResult  18: 128 op, 945559700.00 ns, 7.3872 ms/op
WorkloadResult  19: 128 op, 932532600.00 ns, 7.2854 ms/op
WorkloadResult  20: 128 op, 946218300.00 ns, 7.3923 ms/op
WorkloadResult  21: 128 op, 1020296800.00 ns, 7.9711 ms/op
WorkloadResult  22: 128 op, 996782800.00 ns, 7.7874 ms/op
WorkloadResult  23: 128 op, 992334400.00 ns, 7.7526 ms/op
WorkloadResult  24: 128 op, 1031635100.00 ns, 8.0596 ms/op
WorkloadResult  25: 128 op, 954613500.00 ns, 7.4579 ms/op
WorkloadResult  26: 128 op, 980311700.00 ns, 7.6587 ms/op
WorkloadResult  27: 128 op, 958486400.00 ns, 7.4882 ms/op
WorkloadResult  28: 128 op, 854653300.00 ns, 6.6770 ms/op
WorkloadResult  29: 128 op, 858843000.00 ns, 6.7097 ms/op
WorkloadResult  30: 128 op, 842925700.00 ns, 6.5854 ms/op
WorkloadResult  31: 128 op, 907115800.00 ns, 7.0868 ms/op
WorkloadResult  32: 128 op, 873949200.00 ns, 6.8277 ms/op
WorkloadResult  33: 128 op, 862114100.00 ns, 6.7353 ms/op
WorkloadResult  34: 128 op, 853487600.00 ns, 6.6679 ms/op
WorkloadResult  35: 128 op, 867060900.00 ns, 6.7739 ms/op
WorkloadResult  36: 128 op, 901368600.00 ns, 7.0419 ms/op
WorkloadResult  37: 128 op, 845738000.00 ns, 6.6073 ms/op
WorkloadResult  38: 128 op, 831568900.00 ns, 6.4966 ms/op
WorkloadResult  39: 128 op, 841098400.00 ns, 6.5711 ms/op
WorkloadResult  40: 128 op, 882458100.00 ns, 6.8942 ms/op
WorkloadResult  41: 128 op, 875912800.00 ns, 6.8431 ms/op
WorkloadResult  42: 128 op, 834992300.00 ns, 6.5234 ms/op
WorkloadResult  43: 128 op, 864367500.00 ns, 6.7529 ms/op
WorkloadResult  44: 128 op, 997309100.00 ns, 7.7915 ms/op
WorkloadResult  45: 128 op, 881700500.00 ns, 6.8883 ms/op
WorkloadResult  46: 128 op, 850773300.00 ns, 6.6467 ms/op
WorkloadResult  47: 128 op, 927740900.00 ns, 7.2480 ms/op
WorkloadResult  48: 128 op, 841075500.00 ns, 6.5709 ms/op
WorkloadResult  49: 128 op, 865185200.00 ns, 6.7593 ms/op
WorkloadResult  50: 128 op, 829279300.00 ns, 6.4787 ms/op
WorkloadResult  51: 128 op, 845538700.00 ns, 6.6058 ms/op
WorkloadResult  52: 128 op, 829946100.00 ns, 6.4840 ms/op
WorkloadResult  53: 128 op, 877691100.00 ns, 6.8570 ms/op
WorkloadResult  54: 128 op, 848387400.00 ns, 6.6280 ms/op
WorkloadResult  55: 128 op, 871546400.00 ns, 6.8090 ms/op
WorkloadResult  56: 128 op, 947588800.00 ns, 7.4030 ms/op
WorkloadResult  57: 128 op, 923367900.00 ns, 7.2138 ms/op
WorkloadResult  58: 128 op, 978647900.00 ns, 7.6457 ms/op
WorkloadResult  59: 128 op, 849360100.00 ns, 6.6356 ms/op
WorkloadResult  60: 128 op, 833356100.00 ns, 6.5106 ms/op
WorkloadResult  61: 128 op, 956196600.00 ns, 7.4703 ms/op
WorkloadResult  62: 128 op, 880641200.00 ns, 6.8800 ms/op
WorkloadResult  63: 128 op, 833520700.00 ns, 6.5119 ms/op
WorkloadResult  64: 128 op, 841263900.00 ns, 6.5724 ms/op
WorkloadResult  65: 128 op, 851495000.00 ns, 6.6523 ms/op
WorkloadResult  66: 128 op, 867785200.00 ns, 6.7796 ms/op
WorkloadResult  67: 128 op, 933813800.00 ns, 7.2954 ms/op
WorkloadResult  68: 128 op, 819444600.00 ns, 6.4019 ms/op
WorkloadResult  69: 128 op, 831031800.00 ns, 6.4924 ms/op
WorkloadResult  70: 128 op, 975903600.00 ns, 7.6242 ms/op
WorkloadResult  71: 128 op, 870085200.00 ns, 6.7975 ms/op
WorkloadResult  72: 128 op, 832724700.00 ns, 6.5057 ms/op
WorkloadResult  73: 128 op, 844945500.00 ns, 6.6011 ms/op
WorkloadResult  74: 128 op, 855757700.00 ns, 6.6856 ms/op
WorkloadResult  75: 128 op, 949438700.00 ns, 7.4175 ms/op
WorkloadResult  76: 128 op, 900658900.00 ns, 7.0364 ms/op
WorkloadResult  77: 128 op, 899873900.00 ns, 7.0303 ms/op
WorkloadResult  78: 128 op, 857371700.00 ns, 6.6982 ms/op
WorkloadResult  79: 128 op, 867047600.00 ns, 6.7738 ms/op
WorkloadResult  80: 128 op, 832301200.00 ns, 6.5024 ms/op
WorkloadResult  81: 128 op, 844257300.00 ns, 6.5958 ms/op
WorkloadResult  82: 128 op, 894285400.00 ns, 6.9866 ms/op
WorkloadResult  83: 128 op, 843006600.00 ns, 6.5860 ms/op
WorkloadResult  84: 128 op, 858917800.00 ns, 6.7103 ms/op
WorkloadResult  85: 128 op, 827340300.00 ns, 6.4636 ms/op
WorkloadResult  86: 128 op, 905208200.00 ns, 7.0719 ms/op
WorkloadResult  87: 128 op, 867389100.00 ns, 6.7765 ms/op
WorkloadResult  88: 128 op, 874910800.00 ns, 6.8352 ms/op
WorkloadResult  89: 128 op, 851525700.00 ns, 6.6525 ms/op
WorkloadResult  90: 128 op, 867380500.00 ns, 6.7764 ms/op
WorkloadResult  91: 128 op, 848112300.00 ns, 6.6259 ms/op
WorkloadResult  92: 128 op, 891449900.00 ns, 6.9645 ms/op
WorkloadResult  93: 128 op, 948247700.00 ns, 7.4082 ms/op
WorkloadResult  94: 128 op, 850530500.00 ns, 6.6448 ms/op
WorkloadResult  95: 128 op, 844183000.00 ns, 6.5952 ms/op
WorkloadResult  96: 128 op, 829404500.00 ns, 6.4797 ms/op
WorkloadResult  97: 128 op, 865644200.00 ns, 6.7628 ms/op
WorkloadResult  98: 128 op, 822126200.00 ns, 6.4229 ms/op
// GC:  113 0 0 1425284096 128
// Threading:  0 0 128

// AfterAll
// Benchmark Process 116316 has exited with code 0.

Mean = 6.923 ms, StdErr = 0.043 ms (0.61%), N = 98, StdDev = 0.421 ms
Min = 6.402 ms, Q1 = 6.624 ms, Median = 6.774 ms, Q3 = 7.191 ms, Max = 8.118 ms
IQR = 0.566 ms, LowerFence = 5.775 ms, UpperFence = 8.041 ms
ConfidenceInterval = [6.779 ms; 7.068 ms] (CI 99.9%), Margin = 0.144 ms (2.09% of Mean)
Skewness = 1.1, Kurtosis = 3.32, MValue = 2.62

// **Remained 6 (50,0%) benchmark(s) to run. Estimated finish 2025-07-16 21:51 (0h 5m from now)**
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Wysoka wydajność)
// **************************
// Benchmark: Benchmark.JsonDeserialization: DefaultJob [Size=100000]
// ***Execute***
// Launch: 1 / 1
// Execute: dotnet gRPCVsJSON-DefaultJob-1.dll --anonymousPipes 1756 1744 --benchmarkName "gRPCVsJSON.Benchmark.JsonDeserialization(Size: 100000)" --job Default --benchmarkId 6 in **
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 99800.00 ns, 99.8000 us/op
WorkloadJitting  1: 1 op, 132173100.00 ns, 132.1731 ms/op

WorkloadPilot    1: 2 op, 262993500.00 ns, 131.4968 ms/op
WorkloadPilot    2: 3 op, 270362400.00 ns, 90.1208 ms/op
WorkloadPilot    3: 4 op, 94505500.00 ns, 23.6264 ms/op
WorkloadPilot    4: 5 op, 118548300.00 ns, 23.7097 ms/op
WorkloadPilot    5: 6 op, 150425800.00 ns, 25.0710 ms/op
WorkloadPilot    6: 7 op, 180970200.00 ns, 25.8529 ms/op
WorkloadPilot    7: 8 op, 192143300.00 ns, 24.0179 ms/op
WorkloadPilot    8: 9 op, 209009400.00 ns, 23.2233 ms/op
WorkloadPilot    9: 10 op, 243991700.00 ns, 24.3992 ms/op
WorkloadPilot   10: 11 op, 265827100.00 ns, 24.1661 ms/op
WorkloadPilot   11: 12 op, 271850900.00 ns, 22.6542 ms/op
WorkloadPilot   12: 13 op, 307838200.00 ns, 23.6799 ms/op
WorkloadPilot   13: 14 op, 381429200.00 ns, 27.2449 ms/op
WorkloadPilot   14: 15 op, 358458800.00 ns, 23.8973 ms/op
WorkloadPilot   15: 16 op, 377734500.00 ns, 23.6084 ms/op
WorkloadPilot   16: 32 op, 742981400.00 ns, 23.2182 ms/op

OverheadWarmup   1: 32 op, 4700.00 ns, 146.8750 ns/op
OverheadWarmup   2: 32 op, 1600.00 ns, 50.0000 ns/op
OverheadWarmup   3: 32 op, 1400.00 ns, 43.7500 ns/op
OverheadWarmup   4: 32 op, 1800.00 ns, 56.2500 ns/op
OverheadWarmup   5: 32 op, 1600.00 ns, 50.0000 ns/op
OverheadWarmup   6: 32 op, 1700.00 ns, 53.1250 ns/op
OverheadWarmup   7: 32 op, 1500.00 ns, 46.8750 ns/op

// BeforeActualRun
WorkloadActual   1: 32 op, 767500100.00 ns, 23.9844 ms/op
WorkloadActual   2: 32 op, 748618700.00 ns, 23.3943 ms/op
WorkloadActual   3: 32 op, 749777300.00 ns, 23.4305 ms/op
WorkloadActual   4: 32 op, 773850400.00 ns, 24.1828 ms/op
WorkloadActual   5: 32 op, 789746000.00 ns, 24.6796 ms/op
WorkloadActual   6: 32 op, 733625400.00 ns, 22.9258 ms/op
WorkloadActual   7: 32 op, 740127100.00 ns, 23.1290 ms/op
WorkloadActual   8: 32 op, 740270200.00 ns, 23.1334 ms/op
WorkloadActual   9: 32 op, 756946900.00 ns, 23.6546 ms/op
WorkloadActual  10: 32 op, 885675700.00 ns, 27.6774 ms/op
WorkloadActual  11: 32 op, 853038900.00 ns, 26.6575 ms/op
WorkloadActual  12: 32 op, 770797400.00 ns, 24.0874 ms/op
WorkloadActual  13: 32 op, 762153600.00 ns, 23.8173 ms/op
WorkloadActual  14: 32 op, 790070000.00 ns, 24.6897 ms/op
WorkloadActual  15: 32 op, 783811400.00 ns, 24.4941 ms/op
WorkloadActual  16: 32 op, 742622100.00 ns, 23.2069 ms/op
WorkloadActual  17: 32 op, 749737600.00 ns, 23.4293 ms/op
WorkloadActual  18: 32 op, 771773200.00 ns, 24.1179 ms/op
WorkloadActual  19: 32 op, 767268000.00 ns, 23.9771 ms/op
WorkloadActual  20: 32 op, 735701200.00 ns, 22.9907 ms/op
WorkloadActual  21: 32 op, 757196500.00 ns, 23.6624 ms/op
WorkloadActual  22: 32 op, 736264800.00 ns, 23.0083 ms/op
WorkloadActual  23: 32 op, 748539900.00 ns, 23.3919 ms/op

// AfterActualRun
WorkloadResult   1: 32 op, 767500100.00 ns, 23.9844 ms/op
WorkloadResult   2: 32 op, 748618700.00 ns, 23.3943 ms/op
WorkloadResult   3: 32 op, 749777300.00 ns, 23.4305 ms/op
WorkloadResult   4: 32 op, 773850400.00 ns, 24.1828 ms/op
WorkloadResult   5: 32 op, 789746000.00 ns, 24.6796 ms/op
WorkloadResult   6: 32 op, 733625400.00 ns, 22.9258 ms/op
WorkloadResult   7: 32 op, 740127100.00 ns, 23.1290 ms/op
WorkloadResult   8: 32 op, 740270200.00 ns, 23.1334 ms/op
WorkloadResult   9: 32 op, 756946900.00 ns, 23.6546 ms/op
WorkloadResult  10: 32 op, 770797400.00 ns, 24.0874 ms/op
WorkloadResult  11: 32 op, 762153600.00 ns, 23.8173 ms/op
WorkloadResult  12: 32 op, 790070000.00 ns, 24.6897 ms/op
WorkloadResult  13: 32 op, 783811400.00 ns, 24.4941 ms/op
WorkloadResult  14: 32 op, 742622100.00 ns, 23.2069 ms/op
WorkloadResult  15: 32 op, 749737600.00 ns, 23.4293 ms/op
WorkloadResult  16: 32 op, 771773200.00 ns, 24.1179 ms/op
WorkloadResult  17: 32 op, 767268000.00 ns, 23.9771 ms/op
WorkloadResult  18: 32 op, 735701200.00 ns, 22.9907 ms/op
WorkloadResult  19: 32 op, 757196500.00 ns, 23.6624 ms/op
WorkloadResult  20: 32 op, 736264800.00 ns, 23.0083 ms/op
WorkloadResult  21: 32 op, 748539900.00 ns, 23.3919 ms/op
// GC:  22 0 0 281600000 32
// Threading:  0 0 32

// AfterAll
// Benchmark Process 119656 has exited with code 0.

Mean = 23.685 ms, StdErr = 0.121 ms (0.51%), N = 21, StdDev = 0.552 ms
Min = 22.926 ms, Q1 = 23.207 ms, Median = 23.655 ms, Q3 = 24.087 ms, Max = 24.690 ms
IQR = 0.880 ms, LowerFence = 21.886 ms, UpperFence = 25.408 ms
ConfidenceInterval = [23.221 ms; 24.149 ms] (CI 99.9%), Margin = 0.464 ms (1.96% of Mean)
Skewness = 0.35, Kurtosis = 1.84, MValue = 2

// **Remained 5 (41,7%) benchmark(s) to run. Estimated finish 2025-07-16 21:50 (0h 4m from now)**
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Wysoka wydajność)
// **************************
// Benchmark: Benchmark.ProtobufDeserialization: DefaultJob [Size=100000]
// ***Execute***
// Launch: 1 / 1
// Execute: dotnet gRPCVsJSON-DefaultJob-1.dll --anonymousPipes 1536 612 --benchmarkName "gRPCVsJSON.Benchmark.ProtobufDeserialization(Size: 100000)" --job Default --benchmarkId 7 in **
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 91500.00 ns, 91.5000 us/op
WorkloadJitting  1: 1 op, 28966800.00 ns, 28.9668 ms/op

OverheadJitting  2: 16 op, 222800.00 ns, 13.9250 us/op
WorkloadJitting  2: 16 op, 287377200.00 ns, 17.9611 ms/op

WorkloadPilot    1: 16 op, 162196000.00 ns, 10.1373 ms/op
WorkloadPilot    2: 32 op, 338881400.00 ns, 10.5900 ms/op
WorkloadPilot    3: 64 op, 677899000.00 ns, 10.5922 ms/op

OverheadWarmup   1: 64 op, 4300.00 ns, 67.1875 ns/op
OverheadWarmup   2: 64 op, 1800.00 ns, 28.1250 ns/op
OverheadWarmup   3: 64 op, 1800.00 ns, 28.1250 ns/op
OverheadWarmup   4: 64 op, 1800.00 ns, 28.1250 ns/op
OverheadWarmup   5: 64 op, 1200.00 ns, 18.7500 ns/op
OverheadWarmup   6: 64 op, 1600.00 ns, 25.0000 ns/op

OverheadActual   1: 64 op, 1400.00 ns, 21.8750 ns/op
OverheadActual   2: 64 op, 2000.00 ns, 31.2500 ns/op
OverheadActual   3: 64 op, 1600.00 ns, 25.0000 ns/op
OverheadActual   4: 64 op, 1800.00 ns, 28.1250 ns/op
OverheadActual   5: 64 op, 1600.00 ns, 25.0000 ns/op
OverheadActual   6: 64 op, 1600.00 ns, 25.0000 ns/op
OverheadActual   7: 64 op, 2100.00 ns, 32.8125 ns/op
OverheadActual   8: 64 op, 1300.00 ns, 20.3125 ns/op
OverheadActual   9: 64 op, 4400.00 ns, 68.7500 ns/op
OverheadActual  10: 64 op, 1600.00 ns, 25.0000 ns/op
OverheadActual  11: 64 op, 1700.00 ns, 26.5625 ns/op
OverheadActual  12: 64 op, 1500.00 ns, 23.4375 ns/op
OverheadActual  13: 64 op, 1000.00 ns, 15.6250 ns/op
OverheadActual  14: 64 op, 1700.00 ns, 26.5625 ns/op
OverheadActual  15: 64 op, 1800.00 ns, 28.1250 ns/op
OverheadActual  16: 64 op, 1100.00 ns, 17.1875 ns/op
OverheadActual  17: 64 op, 1100.00 ns, 17.1875 ns/op
OverheadActual  18: 64 op, 1000.00 ns, 15.6250 ns/op
OverheadActual  19: 64 op, 1100.00 ns, 17.1875 ns/op
OverheadActual  20: 64 op, 1700.00 ns, 26.5625 ns/op

OverheadWarmup   1: 64 op, 1600.00 ns, 25.0000 ns/op
OverheadWarmup   2: 64 op, 1300.00 ns, 20.3125 ns/op
OverheadWarmup   3: 64 op, 1000.00 ns, 15.6250 ns/op
OverheadWarmup   4: 64 op, 1100.00 ns, 17.1875 ns/op
OverheadWarmup   5: 64 op, 1600.00 ns, 25.0000 ns/op
OverheadWarmup   6: 64 op, 1100.00 ns, 17.1875 ns/op
OverheadWarmup   7: 64 op, 1100.00 ns, 17.1875 ns/op
OverheadWarmup   8: 64 op, 1300.00 ns, 20.3125 ns/op

// BeforeActualRun
WorkloadActual   1: 64 op, 708874800.00 ns, 11.0762 ms/op
WorkloadActual   2: 64 op, 663128900.00 ns, 10.3614 ms/op
WorkloadActual   3: 64 op, 662645400.00 ns, 10.3538 ms/op
WorkloadActual   4: 64 op, 656654500.00 ns, 10.2602 ms/op
WorkloadActual   5: 64 op, 654539100.00 ns, 10.2272 ms/op
WorkloadActual   6: 64 op, 682396500.00 ns, 10.6624 ms/op
WorkloadActual   7: 64 op, 675430000.00 ns, 10.5536 ms/op
WorkloadActual   8: 64 op, 656151500.00 ns, 10.2524 ms/op
WorkloadActual   9: 64 op, 702560200.00 ns, 10.9775 ms/op
WorkloadActual  10: 64 op, 664468100.00 ns, 10.3823 ms/op
WorkloadActual  11: 64 op, 706939300.00 ns, 11.0459 ms/op
WorkloadActual  12: 64 op, 688963300.00 ns, 10.7651 ms/op
WorkloadActual  13: 64 op, 684117700.00 ns, 10.6893 ms/op
WorkloadActual  14: 64 op, 646317500.00 ns, 10.0987 ms/op
WorkloadActual  15: 64 op, 666957600.00 ns, 10.4212 ms/op
WorkloadActual  16: 64 op, 659465700.00 ns, 10.3042 ms/op
WorkloadActual  17: 64 op, 653011500.00 ns, 10.2033 ms/op
WorkloadActual  18: 64 op, 671457400.00 ns, 10.4915 ms/op
WorkloadActual  19: 64 op, 652181700.00 ns, 10.1903 ms/op
WorkloadActual  20: 64 op, 644081800.00 ns, 10.0638 ms/op
WorkloadActual  21: 64 op, 657448400.00 ns, 10.2726 ms/op
WorkloadActual  22: 64 op, 643296700.00 ns, 10.0515 ms/op
WorkloadActual  23: 64 op, 675588900.00 ns, 10.5561 ms/op
WorkloadActual  24: 64 op, 652689900.00 ns, 10.1983 ms/op
WorkloadActual  25: 64 op, 715894900.00 ns, 11.1859 ms/op
WorkloadActual  26: 64 op, 673370600.00 ns, 10.5214 ms/op
WorkloadActual  27: 64 op, 673581200.00 ns, 10.5247 ms/op
WorkloadActual  28: 64 op, 653426200.00 ns, 10.2098 ms/op
WorkloadActual  29: 64 op, 696834500.00 ns, 10.8880 ms/op
WorkloadActual  30: 64 op, 684096300.00 ns, 10.6890 ms/op
WorkloadActual  31: 64 op, 686351400.00 ns, 10.7242 ms/op

// AfterActualRun
WorkloadResult   1: 64 op, 708873200.00 ns, 11.0761 ms/op
WorkloadResult   2: 64 op, 663127300.00 ns, 10.3614 ms/op
WorkloadResult   3: 64 op, 662643800.00 ns, 10.3538 ms/op
WorkloadResult   4: 64 op, 656652900.00 ns, 10.2602 ms/op
WorkloadResult   5: 64 op, 654537500.00 ns, 10.2271 ms/op
WorkloadResult   6: 64 op, 682394900.00 ns, 10.6624 ms/op
WorkloadResult   7: 64 op, 675428400.00 ns, 10.5536 ms/op
WorkloadResult   8: 64 op, 656149900.00 ns, 10.2523 ms/op
WorkloadResult   9: 64 op, 702558600.00 ns, 10.9775 ms/op
WorkloadResult  10: 64 op, 664466500.00 ns, 10.3823 ms/op
WorkloadResult  11: 64 op, 706937700.00 ns, 11.0459 ms/op
WorkloadResult  12: 64 op, 688961700.00 ns, 10.7650 ms/op
WorkloadResult  13: 64 op, 684116100.00 ns, 10.6893 ms/op
WorkloadResult  14: 64 op, 646315900.00 ns, 10.0987 ms/op
WorkloadResult  15: 64 op, 666956000.00 ns, 10.4212 ms/op
WorkloadResult  16: 64 op, 659464100.00 ns, 10.3041 ms/op
WorkloadResult  17: 64 op, 653009900.00 ns, 10.2033 ms/op
WorkloadResult  18: 64 op, 671455800.00 ns, 10.4915 ms/op
WorkloadResult  19: 64 op, 652180100.00 ns, 10.1903 ms/op
WorkloadResult  20: 64 op, 644080200.00 ns, 10.0638 ms/op
WorkloadResult  21: 64 op, 657446800.00 ns, 10.2726 ms/op
WorkloadResult  22: 64 op, 643295100.00 ns, 10.0515 ms/op
WorkloadResult  23: 64 op, 675587300.00 ns, 10.5561 ms/op
WorkloadResult  24: 64 op, 652688300.00 ns, 10.1983 ms/op
WorkloadResult  25: 64 op, 715893300.00 ns, 11.1858 ms/op
WorkloadResult  26: 64 op, 673369000.00 ns, 10.5214 ms/op
WorkloadResult  27: 64 op, 673579600.00 ns, 10.5247 ms/op
WorkloadResult  28: 64 op, 653424600.00 ns, 10.2098 ms/op
WorkloadResult  29: 64 op, 696832900.00 ns, 10.8880 ms/op
WorkloadResult  30: 64 op, 684094700.00 ns, 10.6890 ms/op
WorkloadResult  31: 64 op, 686349800.00 ns, 10.7242 ms/op
// GC:  130 0 0 1638400000 64
// Threading:  0 0 64

// AfterAll
// Benchmark Process 111788 has exited with code 0.

Mean = 10.490 ms, StdErr = 0.056 ms (0.54%), N = 31, StdDev = 0.314 ms
Min = 10.051 ms, Q1 = 10.240 ms, Median = 10.421 ms, Q3 = 10.689 ms, Max = 11.186 ms
IQR = 0.449 ms, LowerFence = 9.566 ms, UpperFence = 11.363 ms
ConfidenceInterval = [10.285 ms; 10.696 ms] (CI 99.9%), Margin = 0.206 ms (1.96% of Mean)
Skewness = 0.58, Kurtosis = 2.25, MValue = 2

// **Remained 4 (33,3%) benchmark(s) to run. Estimated finish 2025-07-16 21:50 (0h 3m from now)**
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Wysoka wydajność)
// **************************
// Benchmark: Benchmark.JsonSerialization: DefaultJob [Size=1000000]
// ***Execute***
// Launch: 1 / 1
// Execute: dotnet gRPCVsJSON-DefaultJob-1.dll --anonymousPipes 832 1760 --benchmarkName "gRPCVsJSON.Benchmark.JsonSerialization(Size: 1000000)" --job Default --benchmarkId 8 in **
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 103100.00 ns, 103.1000 us/op
WorkloadJitting  1: 1 op, 168263100.00 ns, 168.2631 ms/op

WorkloadPilot    1: 2 op, 310284000.00 ns, 155.1420 ms/op
WorkloadPilot    2: 3 op, 459367900.00 ns, 153.1226 ms/op
WorkloadPilot    3: 4 op, 611211200.00 ns, 152.8028 ms/op

OverheadWarmup   1: 4 op, 1800.00 ns, 450.0000 ns/op
OverheadWarmup   2: 4 op, 1300.00 ns, 325.0000 ns/op
OverheadWarmup   3: 4 op, 1700.00 ns, 425.0000 ns/op
OverheadWarmup   4: 4 op, 1700.00 ns, 425.0000 ns/op
OverheadWarmup   5: 4 op, 1900.00 ns, 475.0000 ns/op
OverheadWarmup   6: 4 op, 1700.00 ns, 425.0000 ns/op

// BeforeActualRun
WorkloadActual   1: 4 op, 616043600.00 ns, 154.0109 ms/op
WorkloadActual   2: 4 op, 618005100.00 ns, 154.5013 ms/op
WorkloadActual   3: 4 op, 662740200.00 ns, 165.6851 ms/op
WorkloadActual   4: 4 op, 625790200.00 ns, 156.4476 ms/op
WorkloadActual   5: 4 op, 620799000.00 ns, 155.1998 ms/op
WorkloadActual   6: 4 op, 609987200.00 ns, 152.4968 ms/op
WorkloadActual   7: 4 op, 601331500.00 ns, 150.3329 ms/op
WorkloadActual   8: 4 op, 604479000.00 ns, 151.1198 ms/op
WorkloadActual   9: 4 op, 618427500.00 ns, 154.6069 ms/op
WorkloadActual  10: 4 op, 614971500.00 ns, 153.7429 ms/op
WorkloadActual  11: 4 op, 606882300.00 ns, 151.7206 ms/op
WorkloadActual  12: 4 op, 618186000.00 ns, 154.5465 ms/op
WorkloadActual  13: 4 op, 602017600.00 ns, 150.5044 ms/op
WorkloadActual  14: 4 op, 638669000.00 ns, 159.6673 ms/op
WorkloadActual  15: 4 op, 629452500.00 ns, 157.3631 ms/op

// AfterActualRun
WorkloadResult   1: 4 op, 616043600.00 ns, 154.0109 ms/op
WorkloadResult   2: 4 op, 618005100.00 ns, 154.5013 ms/op
WorkloadResult   3: 4 op, 625790200.00 ns, 156.4476 ms/op
WorkloadResult   4: 4 op, 620799000.00 ns, 155.1998 ms/op
WorkloadResult   5: 4 op, 609987200.00 ns, 152.4968 ms/op
WorkloadResult   6: 4 op, 601331500.00 ns, 150.3329 ms/op
WorkloadResult   7: 4 op, 604479000.00 ns, 151.1198 ms/op
WorkloadResult   8: 4 op, 618427500.00 ns, 154.6069 ms/op
WorkloadResult   9: 4 op, 614971500.00 ns, 153.7429 ms/op
WorkloadResult  10: 4 op, 606882300.00 ns, 151.7206 ms/op
WorkloadResult  11: 4 op, 618186000.00 ns, 154.5465 ms/op
WorkloadResult  12: 4 op, 602017600.00 ns, 150.5044 ms/op
WorkloadResult  13: 4 op, 638669000.00 ns, 159.6673 ms/op
WorkloadResult  14: 4 op, 629452500.00 ns, 157.3631 ms/op
// GC:  40 0 0 511824704 4
// Threading:  0 0 4

// AfterAll
// Benchmark Process 83128 has exited with code 0.

Mean = 154.019 ms, StdErr = 0.716 ms (0.46%), N = 14, StdDev = 2.678 ms
Min = 150.333 ms, Q1 = 151.915 ms, Median = 154.256 ms, Q3 = 155.052 ms, Max = 159.667 ms
IQR = 3.137 ms, LowerFence = 147.209 ms, UpperFence = 159.757 ms
ConfidenceInterval = [150.997 ms; 157.040 ms] (CI 99.9%), Margin = 3.021 ms (1.96% of Mean)
Skewness = 0.37, Kurtosis = 2.25, MValue = 2

// **Remained 3 (25,0%) benchmark(s) to run. Estimated finish 2025-07-16 21:49 (0h 2m from now)**
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Wysoka wydajność)
// **************************
// Benchmark: Benchmark.ProtobufSerialization: DefaultJob [Size=1000000]
// ***Execute***
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 100100.00 ns, 100.1000 us/op
WorkloadJitting  1: 1 op, 83936300.00 ns, 83.9363 ms/op

WorkloadPilot    1: 2 op, 119730900.00 ns, 59.8655 ms/op
WorkloadPilot    2: 3 op, 167742800.00 ns, 55.9143 ms/op
WorkloadPilot    3: 4 op, 222202200.00 ns, 55.5506 ms/op
WorkloadPilot    4: 5 op, 310057100.00 ns, 62.0114 ms/op
WorkloadPilot    5: 6 op, 353962200.00 ns, 58.9937 ms/op
WorkloadPilot    6: 7 op, 408371400.00 ns, 58.3388 ms/op
WorkloadPilot    7: 8 op, 471562700.00 ns, 58.9453 ms/op
WorkloadPilot    8: 9 op, 506722500.00 ns, 56.3025 ms/op

OverheadWarmup   1: 9 op, 1700.00 ns, 188.8889 ns/op
OverheadWarmup   2: 9 op, 2000.00 ns, 222.2222 ns/op
OverheadWarmup   3: 9 op, 2100.00 ns, 233.3333 ns/op
OverheadWarmup   4: 9 op, 3900.00 ns, 433.3333 ns/op
OverheadWarmup   5: 9 op, 1400.00 ns, 155.5556 ns/op
OverheadWarmup   6: 9 op, 1800.00 ns, 200.0000 ns/op
OverheadWarmup   7: 9 op, 2000.00 ns, 222.2222 ns/op
OverheadWarmup   8: 9 op, 2600.00 ns, 288.8889 ns/op
OverheadWarmup   9: 9 op, 5900.00 ns, 655.5556 ns/op
OverheadWarmup  10: 9 op, 2200.00 ns, 244.4444 ns/op

// BeforeActualRun
WorkloadActual   1: 9 op, 520829200.00 ns, 57.8699 ms/op
WorkloadActual   2: 9 op, 535935200.00 ns, 59.5484 ms/op
WorkloadActual   3: 9 op, 517913300.00 ns, 57.5459 ms/op
WorkloadActual   4: 9 op, 504731800.00 ns, 56.0813 ms/op
WorkloadActual   5: 9 op, 530055000.00 ns, 58.8950 ms/op
WorkloadActual   6: 9 op, 518207000.00 ns, 57.5786 ms/op
WorkloadActual   7: 9 op, 567981100.00 ns, 63.1090 ms/op
WorkloadActual   8: 9 op, 524421100.00 ns, 58.2690 ms/op
WorkloadActual   9: 9 op, 525023800.00 ns, 58.3360 ms/op
WorkloadActual  10: 9 op, 515728900.00 ns, 57.3032 ms/op
WorkloadActual  11: 9 op, 507273400.00 ns, 56.3637 ms/op
WorkloadActual  12: 9 op, 537116800.00 ns, 59.6796 ms/op
WorkloadActual  13: 9 op, 540164100.00 ns, 60.0182 ms/op
WorkloadActual  14: 9 op, 513438200.00 ns, 57.0487 ms/op
WorkloadActual  15: 9 op, 529965300.00 ns, 58.8850 ms/op
WorkloadActual  16: 9 op, 515245900.00 ns, 57.2495 ms/op
WorkloadActual  17: 9 op, 519973700.00 ns, 57.7749 ms/op
WorkloadActual  18: 9 op, 505929400.00 ns, 56.2144 ms/op
WorkloadActual  19: 9 op, 514739300.00 ns, 57.1933 ms/op

// AfterActualRun
WorkloadResult   1: 9 op, 520829200.00 ns, 57.8699 ms/op
WorkloadResult   2: 9 op, 535935200.00 ns, 59.5484 ms/op
WorkloadResult   3: 9 op, 517913300.00 ns, 57.5459 ms/op
WorkloadResult   4: 9 op, 504731800.00 ns, 56.0813 ms/op
WorkloadResult   5: 9 op, 530055000.00 ns, 58.8950 ms/op
WorkloadResult   6: 9 op, 518207000.00 ns, 57.5786 ms/op
WorkloadResult   7: 9 op, 524421100.00 ns, 58.2690 ms/op
WorkloadResult   8: 9 op, 525023800.00 ns, 58.3360 ms/op
WorkloadResult   9: 9 op, 515728900.00 ns, 57.3032 ms/op
WorkloadResult  10: 9 op, 507273400.00 ns, 56.3637 ms/op
WorkloadResult  11: 9 op, 537116800.00 ns, 59.6796 ms/op
WorkloadResult  12: 9 op, 540164100.00 ns, 60.0182 ms/op
WorkloadResult  13: 9 op, 513438200.00 ns, 57.0487 ms/op
WorkloadResult  14: 9 op, 529965300.00 ns, 58.8850 ms/op
WorkloadResult  15: 9 op, 515245900.00 ns, 57.2495 ms/op
WorkloadResult  16: 9 op, 519973700.00 ns, 57.7749 ms/op
WorkloadResult  17: 9 op, 505929400.00 ns, 56.2144 ms/op
WorkloadResult  18: 9 op, 514739300.00 ns, 57.1933 ms/op
// GC:  74 0 0 936000000 9
// Threading:  0 0 9

// AfterAll
// Benchmark Process 57088 has exited with code 0.

Mean = 57.881 ms, StdErr = 0.277 ms (0.48%), N = 18, StdDev = 1.173 ms
Min = 56.081 ms, Q1 = 57.207 ms, Median = 57.677 ms, Q3 = 58.748 ms, Max = 60.018 ms
IQR = 1.540 ms, LowerFence = 54.897 ms, UpperFence = 61.058 ms
ConfidenceInterval = [56.784 ms; 58.978 ms] (CI 99.9%), Margin = 1.097 ms (1.89% of Mean)
Skewness = 0.24, Kurtosis = 1.93, MValue = 2

// **Remained 2 (16,7%) benchmark(s) to run. Estimated finish 2025-07-16 21:49 (0h 1m from now)**
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Wysoka wydajność)
// **************************
// Benchmark: Benchmark.JsonDeserialization: DefaultJob [Size=1000000]
// ***Execute***
// Launch: 1 / 1
// Execute: dotnet gRPCVsJSON-DefaultJob-1.dll --anonymousPipes 1456 1512 --benchmarkName "gRPCVsJSON.Benchmark.JsonDeserialization(Size: 1000000)" --job Default --benchmarkId 10 in **
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 100200.00 ns, 100.2000 us/op
WorkloadJitting  1: 1 op, 545304000.00 ns, 545.3040 ms/op

OverheadJitting  2: 1 op, 1800.00 ns, 1.8000 us/op
WorkloadJitting  2: 1 op, 236912600.00 ns, 236.9126 ms/op

WorkloadPilot    1: 2 op, 489720000.00 ns, 244.8600 ms/op
WorkloadPilot    2: 3 op, 732122000.00 ns, 244.0407 ms/op

OverheadWarmup   1: 3 op, 1800.00 ns, 600.0000 ns/op
OverheadWarmup   2: 3 op, 1800.00 ns, 600.0000 ns/op
OverheadWarmup   3: 3 op, 1500.00 ns, 500.0000 ns/op
OverheadWarmup   4: 3 op, 1900.00 ns, 633.3333 ns/op
OverheadWarmup   5: 3 op, 2000.00 ns, 666.6667 ns/op
OverheadWarmup   6: 3 op, 1800.00 ns, 600.0000 ns/op

// BeforeActualRun
WorkloadActual   1: 3 op, 727611400.00 ns, 242.5371 ms/op
WorkloadActual   2: 3 op, 767326800.00 ns, 255.7756 ms/op
WorkloadActual   3: 3 op, 729682600.00 ns, 243.2275 ms/op
WorkloadActual   4: 3 op, 730503000.00 ns, 243.5010 ms/op
WorkloadActual   5: 3 op, 716045900.00 ns, 238.6820 ms/op
WorkloadActual   6: 3 op, 727837000.00 ns, 242.6123 ms/op
WorkloadActual   7: 3 op, 736245300.00 ns, 245.4151 ms/op
WorkloadActual   8: 3 op, 733714100.00 ns, 244.5714 ms/op
WorkloadActual   9: 3 op, 753440800.00 ns, 251.1469 ms/op
WorkloadActual  10: 3 op, 732402400.00 ns, 244.1341 ms/op
WorkloadActual  11: 3 op, 718445700.00 ns, 239.4819 ms/op
WorkloadActual  12: 3 op, 724174700.00 ns, 241.3916 ms/op
WorkloadActual  13: 3 op, 735838000.00 ns, 245.2793 ms/op
WorkloadActual  14: 3 op, 733393000.00 ns, 244.4643 ms/op
WorkloadActual  15: 3 op, 707916200.00 ns, 235.9721 ms/op

// AfterActualRun
WorkloadResult   1: 3 op, 727611400.00 ns, 242.5371 ms/op
WorkloadResult   2: 3 op, 729682600.00 ns, 243.2275 ms/op
WorkloadResult   3: 3 op, 730503000.00 ns, 243.5010 ms/op
WorkloadResult   4: 3 op, 716045900.00 ns, 238.6820 ms/op
WorkloadResult   5: 3 op, 727837000.00 ns, 242.6123 ms/op
WorkloadResult   6: 3 op, 736245300.00 ns, 245.4151 ms/op
WorkloadResult   7: 3 op, 733714100.00 ns, 244.5714 ms/op
WorkloadResult   8: 3 op, 732402400.00 ns, 244.1341 ms/op
WorkloadResult   9: 3 op, 718445700.00 ns, 239.4819 ms/op
WorkloadResult  10: 3 op, 724174700.00 ns, 241.3916 ms/op
WorkloadResult  11: 3 op, 735838000.00 ns, 245.2793 ms/op
WorkloadResult  12: 3 op, 733393000.00 ns, 244.4643 ms/op
WorkloadResult  13: 3 op, 707916200.00 ns, 235.9721 ms/op
// GC:  19 0 0 240000000 3
// Threading:  0 0 3

// AfterAll
// Benchmark Process 101872 has exited with code 0.

Mean = 242.405 ms, StdErr = 0.784 ms (0.32%), N = 13, StdDev = 2.828 ms
Min = 235.972 ms, Q1 = 241.392 ms, Median = 243.228 ms, Q3 = 244.464 ms, Max = 245.415 ms
IQR = 3.073 ms, LowerFence = 236.782 ms, UpperFence = 249.073 ms
ConfidenceInterval = [239.018 ms; 245.793 ms] (CI 99.9%), Margin = 3.387 ms (1.40% of Mean)
Skewness = -0.91, Kurtosis = 2.62, MValue = 2

// **Remained 1 (8,3%) benchmark(s) to run. Estimated finish 2025-07-16 21:49 (0h 0m from now)**
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Wysoka wydajność)
// **************************
// Benchmark: Benchmark.ProtobufDeserialization: DefaultJob [Size=1000000]
// ***Execute***
// Launch: 1 / 1
// Execute: dotnet gRPCVsJSON-DefaultJob-1.dll --anonymousPipes 1824 1860 --benchmarkName "gRPCVsJSON.Benchmark.ProtobufDeserialization(Size: 1000000)" --job Default --benchmarkId 11 in **
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT,AvxVnni,SERIALIZE VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 120200.00 ns, 120.2000 us/op
WorkloadJitting  1: 1 op, 202642700.00 ns, 202.6427 ms/op

WorkloadPilot    1: 2 op, 208566200.00 ns, 104.2831 ms/op
WorkloadPilot    2: 3 op, 323738700.00 ns, 107.9129 ms/op
WorkloadPilot    3: 4 op, 441800600.00 ns, 110.4502 ms/op
WorkloadPilot    4: 5 op, 519485600.00 ns, 103.8971 ms/op

OverheadWarmup   1: 5 op, 2800.00 ns, 560.0000 ns/op
OverheadWarmup   2: 5 op, 1600.00 ns, 320.0000 ns/op
OverheadWarmup   3: 5 op, 1900.00 ns, 380.0000 ns/op
OverheadWarmup   4: 5 op, 1600.00 ns, 320.0000 ns/op
OverheadWarmup   5: 5 op, 1800.00 ns, 360.0000 ns/op
OverheadWarmup   6: 5 op, 4300.00 ns, 860.0000 ns/op
OverheadWarmup   7: 5 op, 1200.00 ns, 240.0000 ns/op

// BeforeActualRun
WorkloadActual   1: 5 op, 519059800.00 ns, 103.8120 ms/op
WorkloadActual   2: 5 op, 518065200.00 ns, 103.6130 ms/op
WorkloadActual   3: 5 op, 512497200.00 ns, 102.4994 ms/op
WorkloadActual   4: 5 op, 523210400.00 ns, 104.6421 ms/op
WorkloadActual   5: 5 op, 525535700.00 ns, 105.1071 ms/op
WorkloadActual   6: 5 op, 526450600.00 ns, 105.2901 ms/op
WorkloadActual   7: 5 op, 508402400.00 ns, 101.6805 ms/op
WorkloadActual   8: 5 op, 516353000.00 ns, 103.2706 ms/op
WorkloadActual   9: 5 op, 516432700.00 ns, 103.2865 ms/op
WorkloadActual  10: 5 op, 519544400.00 ns, 103.9089 ms/op
WorkloadActual  11: 5 op, 502907000.00 ns, 100.5814 ms/op
WorkloadActual  12: 5 op, 500970100.00 ns, 100.1940 ms/op
WorkloadActual  13: 5 op, 505947200.00 ns, 101.1894 ms/op
WorkloadActual  14: 5 op, 506859200.00 ns, 101.3718 ms/op
WorkloadActual  15: 5 op, 499422300.00 ns, 99.8845 ms/op

// AfterActualRun
WorkloadResult   1: 5 op, 519059800.00 ns, 103.8120 ms/op
WorkloadResult   2: 5 op, 518065200.00 ns, 103.6130 ms/op
WorkloadResult   3: 5 op, 512497200.00 ns, 102.4994 ms/op
WorkloadResult   4: 5 op, 523210400.00 ns, 104.6421 ms/op
WorkloadResult   5: 5 op, 525535700.00 ns, 105.1071 ms/op
WorkloadResult   6: 5 op, 526450600.00 ns, 105.2901 ms/op
WorkloadResult   7: 5 op, 508402400.00 ns, 101.6805 ms/op
WorkloadResult   8: 5 op, 516353000.00 ns, 103.2706 ms/op
WorkloadResult   9: 5 op, 516432700.00 ns, 103.2865 ms/op
WorkloadResult  10: 5 op, 519544400.00 ns, 103.9089 ms/op
WorkloadResult  11: 5 op, 502907000.00 ns, 100.5814 ms/op
WorkloadResult  12: 5 op, 500970100.00 ns, 100.1940 ms/op
WorkloadResult  13: 5 op, 505947200.00 ns, 101.1894 ms/op
WorkloadResult  14: 5 op, 506859200.00 ns, 101.3718 ms/op
WorkloadResult  15: 5 op, 499422300.00 ns, 99.8845 ms/op
// GC:  105 0 0 1320000000 5
// Threading:  0 0 5

// AfterAll
// Benchmark Process 103160 has exited with code 0.

Mean = 102.689 ms, StdErr = 0.459 ms (0.45%), N = 15, StdDev = 1.779 ms
Min = 99.884 ms, Q1 = 101.281 ms, Median = 103.271 ms, Q3 = 103.860 ms, Max = 105.290 ms
IQR = 2.580 ms, LowerFence = 97.411 ms, UpperFence = 107.730 ms
ConfidenceInterval = [100.787 ms; 104.590 ms] (CI 99.9%), Margin = 1.902 ms (1.85% of Mean)
Skewness = -0.12, Kurtosis = 1.52, MValue = 2

// **Remained 0 (0,0%) benchmark(s) to run. Estimated finish 2025-07-16 21:48 (0h 0m from now)**
Successfully reverted power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: Wysoka wydajność)
// ***** BenchmarkRunner: Finish  *****

// *Export*
  BenchmarkDotNet.Artifacts\results\gRPCVsJSON.Benchmark-report.csv
  BenchmarkDotNet.Artifacts\results\gRPCVsJSON.Benchmark-report-github.md
  BenchmarkDotNet.Artifacts\results\gRPCVsJSON.Benchmark-report.html

// *Detailed results*
Benchmark.JsonSerialization: DefaultJob [Size=10000]
Runtime = .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 1.598 ms, StdErr = 0.012 ms (0.75%), N = 90, StdDev = 0.113 ms
Min = 1.454 ms, Q1 = 1.520 ms, Median = 1.562 ms, Q3 = 1.642 ms, Max = 1.938 ms
IQR = 0.122 ms, LowerFence = 1.337 ms, UpperFence = 1.825 ms
ConfidenceInterval = [1.558 ms; 1.639 ms] (CI 99.9%), Margin = 0.041 ms (2.54% of Mean)
Skewness = 1.2, Kurtosis = 3.78, MValue = 2.12
-------------------- Histogram --------------------
[1.420 ms ; 1.470 ms) | @@
[1.470 ms ; 1.536 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[1.536 ms ; 1.579 ms) | @@@@@@@@@@@
[1.579 ms ; 1.645 ms) | @@@@@@@@@@@@@@@@@@@@
[1.645 ms ; 1.716 ms) | @@@@@@
[1.716 ms ; 1.782 ms) | @@@@@@@@
[1.782 ms ; 1.877 ms) | @@@@
[1.877 ms ; 1.947 ms) | @@@
---------------------------------------------------

Benchmark.ProtobufSerialization: DefaultJob [Size=10000]
Runtime = .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 487.240 us, StdErr = 2.433 us (0.50%), N = 60, StdDev = 18.843 us
Min = 461.525 us, Q1 = 471.950 us, Median = 482.706 us, Q3 = 497.689 us, Max = 554.963 us
IQR = 25.739 us, LowerFence = 433.342 us, UpperFence = 536.298 us
ConfidenceInterval = [478.815 us; 495.664 us] (CI 99.9%), Margin = 8.425 us (1.73% of Mean)
Skewness = 0.95, Kurtosis = 4, MValue = 2
-------------------- Histogram --------------------
[459.077 us ; 470.591 us) | @@@@@@@@@@@@
[470.591 us ; 483.226 us) | @@@@@@@@@@@@@@@@@@@@
[483.226 us ; 498.130 us) | @@@@@@@@@@@@@@
[498.130 us ; 516.102 us) | @@@@@@@@@@@@
[516.102 us ; 531.607 us) | @
[531.607 us ; 548.646 us) |
[548.646 us ; 561.280 us) | @
---------------------------------------------------

Benchmark.JsonDeserialization: DefaultJob [Size=10000]
Runtime = .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 2.359 ms, StdErr = 0.010 ms (0.43%), N = 12, StdDev = 0.035 ms
Min = 2.298 ms, Q1 = 2.337 ms, Median = 2.369 ms, Q3 = 2.379 ms, Max = 2.414 ms
IQR = 0.042 ms, LowerFence = 2.274 ms, UpperFence = 2.443 ms
ConfidenceInterval = [2.314 ms; 2.404 ms] (CI 99.9%), Margin = 0.045 ms (1.91% of Mean)
Skewness = -0.3, Kurtosis = 1.81, MValue = 2
-------------------- Histogram --------------------
[2.285 ms ; 2.339 ms) | @@@
[2.339 ms ; 2.434 ms) | @@@@@@@@@
---------------------------------------------------

Benchmark.ProtobufDeserialization: DefaultJob [Size=10000]
Runtime = .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 905.222 us, StdErr = 4.923 us (0.54%), N = 34, StdDev = 28.706 us
Min = 865.342 us, Q1 = 889.125 us, Median = 900.244 us, Q3 = 915.759 us, Max = 984.587 us
IQR = 26.635 us, LowerFence = 849.172 us, UpperFence = 955.711 us
ConfidenceInterval = [887.446 us; 922.999 us] (CI 99.9%), Margin = 17.777 us (1.96% of Mean)
Skewness = 1.18, Kurtosis = 4.17, MValue = 2
-------------------- Histogram --------------------
[858.990 us ; 884.856 us) | @@@@@@
[884.856 us ; 908.116 us) | @@@@@@@@@@@@@@@@
[908.116 us ; 946.873 us) | @@@@@@@@@
[946.873 us ; 972.441 us) | @
[972.441 us ; 996.217 us) | @@
---------------------------------------------------

Benchmark.JsonSerialization: DefaultJob [Size=100000]
Runtime = .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 15.744 ms, StdErr = 0.078 ms (0.50%), N = 17, StdDev = 0.322 ms
Min = 15.302 ms, Q1 = 15.476 ms, Median = 15.651 ms, Q3 = 16.034 ms, Max = 16.249 ms
IQR = 0.558 ms, LowerFence = 14.639 ms, UpperFence = 16.870 ms
ConfidenceInterval = [15.431 ms; 16.057 ms] (CI 99.9%), Margin = 0.313 ms (1.99% of Mean)
Skewness = 0.37, Kurtosis = 1.56, MValue = 2
-------------------- Histogram --------------------
[15.138 ms ; 15.717 ms) | @@@@@@@@@@
[15.717 ms ; 16.305 ms) | @@@@@@@
---------------------------------------------------

Benchmark.ProtobufSerialization: DefaultJob [Size=100000]
Runtime = .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 6.923 ms, StdErr = 0.043 ms (0.61%), N = 98, StdDev = 0.421 ms
Min = 6.402 ms, Q1 = 6.624 ms, Median = 6.774 ms, Q3 = 7.191 ms, Max = 8.118 ms
IQR = 0.566 ms, LowerFence = 5.775 ms, UpperFence = 8.041 ms
ConfidenceInterval = [6.779 ms; 7.068 ms] (CI 99.9%), Margin = 0.144 ms (2.09% of Mean)
Skewness = 1.1, Kurtosis = 3.32, MValue = 2.62
-------------------- Histogram --------------------
[6.343 ms ; 6.570 ms) | @@@@@@@@@@@@@@
[6.570 ms ; 6.810 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[6.810 ms ; 7.055 ms) | @@@@@@@@@@@@@@@
[7.055 ms ; 7.436 ms) | @@@@@@@@@@@@@@@
[7.436 ms ; 7.588 ms) | @@@
[7.588 ms ; 7.828 ms) | @@@@@@
[7.828 ms ; 8.164 ms) | @@@@
---------------------------------------------------

Benchmark.JsonDeserialization: DefaultJob [Size=100000]
Runtime = .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 23.685 ms, StdErr = 0.121 ms (0.51%), N = 21, StdDev = 0.552 ms
Min = 22.926 ms, Q1 = 23.207 ms, Median = 23.655 ms, Q3 = 24.087 ms, Max = 24.690 ms
IQR = 0.880 ms, LowerFence = 21.886 ms, UpperFence = 25.408 ms
ConfidenceInterval = [23.221 ms; 24.149 ms] (CI 99.9%), Margin = 0.464 ms (1.96% of Mean)
Skewness = 0.35, Kurtosis = 1.84, MValue = 2
-------------------- Histogram --------------------
[22.915 ms ; 23.441 ms) | @@@@@@@@@@
[23.441 ms ; 24.149 ms) | @@@@@@@
[24.149 ms ; 24.699 ms) | @@@@
---------------------------------------------------

Benchmark.ProtobufDeserialization: DefaultJob [Size=100000]
Runtime = .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 10.490 ms, StdErr = 0.056 ms (0.54%), N = 31, StdDev = 0.314 ms
Min = 10.051 ms, Q1 = 10.240 ms, Median = 10.421 ms, Q3 = 10.689 ms, Max = 11.186 ms
IQR = 0.449 ms, LowerFence = 9.566 ms, UpperFence = 11.363 ms
ConfidenceInterval = [10.285 ms; 10.696 ms] (CI 99.9%), Margin = 0.206 ms (1.96% of Mean)
Skewness = 0.58, Kurtosis = 2.25, MValue = 2
-------------------- Histogram --------------------
[ 9.920 ms ; 10.175 ms) | @@@
[10.175 ms ; 10.437 ms) | @@@@@@@@@@@@@
[10.437 ms ; 10.739 ms) | @@@@@@@@@
[10.739 ms ; 11.317 ms) | @@@@@@
---------------------------------------------------

Benchmark.JsonSerialization: DefaultJob [Size=1000000]
Runtime = .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 154.019 ms, StdErr = 0.716 ms (0.46%), N = 14, StdDev = 2.678 ms
Min = 150.333 ms, Q1 = 151.915 ms, Median = 154.256 ms, Q3 = 155.052 ms, Max = 159.667 ms
IQR = 3.137 ms, LowerFence = 147.209 ms, UpperFence = 159.757 ms
ConfidenceInterval = [150.997 ms; 157.040 ms] (CI 99.9%), Margin = 3.021 ms (1.96% of Mean)
Skewness = 0.37, Kurtosis = 2.25, MValue = 2
-------------------- Histogram --------------------
[148.874 ms ; 152.310 ms) | @@@@
[152.310 ms ; 161.126 ms) | @@@@@@@@@@
---------------------------------------------------

Benchmark.ProtobufSerialization: DefaultJob [Size=1000000]
Runtime = .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 57.881 ms, StdErr = 0.277 ms (0.48%), N = 18, StdDev = 1.173 ms
Min = 56.081 ms, Q1 = 57.207 ms, Median = 57.677 ms, Q3 = 58.748 ms, Max = 60.018 ms
IQR = 1.540 ms, LowerFence = 54.897 ms, UpperFence = 61.058 ms
ConfidenceInterval = [56.784 ms; 58.978 ms] (CI 99.9%), Margin = 1.097 ms (1.89% of Mean)
Skewness = 0.24, Kurtosis = 1.93, MValue = 2
-------------------- Histogram --------------------
[55.977 ms ; 57.177 ms) | @@@@
[57.177 ms ; 60.046 ms) | @@@@@@@@@@@@@@
---------------------------------------------------

Benchmark.JsonDeserialization: DefaultJob [Size=1000000]
Runtime = .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 242.405 ms, StdErr = 0.784 ms (0.32%), N = 13, StdDev = 2.828 ms
Min = 235.972 ms, Q1 = 241.392 ms, Median = 243.228 ms, Q3 = 244.464 ms, Max = 245.415 ms
IQR = 3.073 ms, LowerFence = 236.782 ms, UpperFence = 249.073 ms
ConfidenceInterval = [239.018 ms; 245.793 ms] (CI 99.9%), Margin = 3.387 ms (1.40% of Mean)
Skewness = -0.91, Kurtosis = 2.62, MValue = 2
-------------------- Histogram --------------------
[234.393 ms ; 246.416 ms) | @@@@@@@@@@@@@
---------------------------------------------------

Benchmark.ProtobufDeserialization: DefaultJob [Size=1000000]
Runtime = .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 102.689 ms, StdErr = 0.459 ms (0.45%), N = 15, StdDev = 1.779 ms
Min = 99.884 ms, Q1 = 101.281 ms, Median = 103.271 ms, Q3 = 103.860 ms, Max = 105.290 ms
IQR = 2.580 ms, LowerFence = 97.411 ms, UpperFence = 107.730 ms
ConfidenceInterval = [100.787 ms; 104.590 ms] (CI 99.9%), Margin = 1.902 ms (1.85% of Mean)
Skewness = -0.12, Kurtosis = 1.52, MValue = 2
-------------------- Histogram --------------------
[ 99.775 ms ; 103.147 ms) | @@@@@@@
[103.147 ms ; 106.237 ms) | @@@@@@@@
---------------------------------------------------

// *Summary*

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
12th Gen Intel Core i7-12700H 2.70GHz, 1 CPU, 20 logical and 14 physical cores
.NET SDK 9.0.201
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

| Method                  | Size    | Mean         | Error       | StdDev      | Median       | Allocated   |
|------------------------ |-------- |-------------:|------------:|------------:|-------------:|------------:|
| JsonSerialization       | 10000   |   1,598.1 us |    40.53 us |   112.99 us |   1,562.0 us |  1245.59 KB |
| ProtobufSerialization   | 10000   |     487.2 us |     8.42 us |    18.84 us |     482.7 us |  1093.73 KB |
| JsonDeserialization     | 10000   |   2,358.5 us |    45.00 us |    35.13 us |   2,368.6 us |   781.25 KB |
| ProtobufDeserialization | 10000   |     905.2 us |    17.78 us |    28.71 us |     900.2 us |  2578.13 KB |
| JsonSerialization       | 100000  |  15,744.2 us |   313.17 us |   321.60 us |  15,651.0 us |  12070.7 KB |
| ProtobufSerialization   | 100000  |   6,923.0 us |   144.48 us |   421.44 us |   6,773.9 us | 10874.05 KB |
| JsonDeserialization     | 100000  |  23,685.1 us |   464.05 us |   552.41 us |  23,654.6 us |  8593.75 KB |
| ProtobufDeserialization | 100000  |  10,490.4 us |   205.60 us |   313.97 us |  10,421.2 us |    25000 KB |
| JsonSerialization       | 1000000 | 154,018.6 us | 3,021.35 us | 2,678.35 us | 154,256.1 us | 124957.2 KB |
| ProtobufSerialization   | 1000000 |  57,880.8 us | 1,096.70 us | 1,173.45 us |  57,676.7 us | 101562.5 KB |
| JsonDeserialization     | 1000000 | 242,405.4 us | 3,387.15 us | 2,828.42 us | 243,227.5 us |    78125 KB |
| ProtobufDeserialization | 1000000 | 102,688.8 us | 1,901.59 us | 1,778.74 us | 103,270.6 us | 257812.5 KB |

// *Hints*
Outliers
  Benchmark.JsonSerialization: Default       -> 10 outliers were removed (1.99 ms..2.60 ms)
  Benchmark.ProtobufSerialization: Default   -> 6 outliers were removed (555.57 us..596.08 us)
  Benchmark.JsonDeserialization: Default     -> 3 outliers were removed (2.50 ms..2.58 ms)
  Benchmark.ProtobufDeserialization: Default -> 7 outliers were removed (1.01 ms..1.12 ms)
  Benchmark.JsonSerialization: Default       -> 1 outlier  was  removed (18.30 ms)
  Benchmark.ProtobufSerialization: Default   -> 2 outliers were removed (8.27 ms, 9.38 ms)
  Benchmark.JsonDeserialization: Default     -> 2 outliers were removed (26.66 ms, 27.68 ms)
  Benchmark.JsonSerialization: Default       -> 1 outlier  was  removed (165.69 ms)
  Benchmark.ProtobufSerialization: Default   -> 1 outlier  was  removed (63.11 ms)
  Benchmark.JsonDeserialization: Default     -> 2 outliers were removed, 3 outliers were detected (235.97 ms, 251.15 ms, 255.78 ms)

// *Legends*
  Size      : Value of the 'Size' parameter
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Median    : Value separating the higher half of all measurements (50th percentile)
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 us      : 1 Microsecond (0.000001 sec)

// *Diagnostic Output - MemoryDiagnoser*

// ***** BenchmarkRunner: End *****
Run time: 00:08:32 (512.14 sec), executed benchmarks: 12

Global total time: 00:08:38 (518.72 sec), executed benchmarks: 12
// *Artifacts cleanup*
Artifacts cleanup is finished

Process finished with exit code 0.
