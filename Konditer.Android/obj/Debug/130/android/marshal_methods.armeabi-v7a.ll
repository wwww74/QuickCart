; ModuleID = 'obj\Debug\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [226 x i32] [
	i32 28873261, ; 0: Npgsql.dll => 0x1b8922d => 14
	i32 32687329, ; 1: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 63
	i32 34715100, ; 2: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 95
	i32 39109920, ; 3: Newtonsoft.Json.dll => 0x254c520 => 13
	i32 53195887, ; 4: Plugin.Toast.Abstractions => 0x32bb46f => 17
	i32 57263871, ; 5: Xamarin.Forms.Core.dll => 0x369c6ff => 88
	i32 88799905, ; 6: Acr.UserDialogs => 0x54afaa1 => 4
	i32 101534019, ; 7: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 77
	i32 120558881, ; 8: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 77
	i32 122350210, ; 9: System.Threading.Channels.dll => 0x74aea82 => 31
	i32 165246403, ; 10: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 44
	i32 182336117, ; 11: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 78
	i32 209399409, ; 12: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 42
	i32 212497893, ; 13: Xamarin.Forms.Maps.Android => 0xcaa75e5 => 89
	i32 230216969, ; 14: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 58
	i32 232815796, ; 15: System.Web.Services => 0xde07cb4 => 107
	i32 261689757, ; 16: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 47
	i32 278686392, ; 17: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 62
	i32 280482487, ; 18: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 56
	i32 318968648, ; 19: Xamarin.AndroidX.Activity.dll => 0x13031348 => 34
	i32 319314094, ; 20: Xamarin.Forms.Maps => 0x130858ae => 90
	i32 321597661, ; 21: System.Numerics => 0x132b30dd => 25
	i32 342366114, ; 22: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 60
	i32 385762202, ; 23: System.Memory.dll => 0x16fe439a => 24
	i32 441335492, ; 24: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 46
	i32 442521989, ; 25: Xamarin.Essentials => 0x1a605985 => 87
	i32 450948140, ; 26: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 55
	i32 465846621, ; 27: mscorlib => 0x1bc4415d => 12
	i32 469710990, ; 28: System.dll => 0x1bff388e => 23
	i32 476646585, ; 29: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 56
	i32 486930444, ; 30: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 67
	i32 526420162, ; 31: System.Transactions.dll => 0x1f6088c2 => 101
	i32 548916678, ; 32: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 8
	i32 558169043, ; 33: Konditer => 0x2144fbd3 => 7
	i32 605376203, ; 34: System.IO.Compression.FileSystem => 0x24154ecb => 105
	i32 627609679, ; 35: Xamarin.AndroidX.CustomView => 0x2568904f => 51
	i32 662205335, ; 36: System.Text.Encodings.Web.dll => 0x27787397 => 29
	i32 663517072, ; 37: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 83
	i32 666292255, ; 38: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 39
	i32 679820142, ; 39: Plugin.Connectivity.Abstractions => 0x28853b6e => 15
	i32 690569205, ; 40: System.Xml.Linq.dll => 0x29293ff5 => 33
	i32 691439157, ; 41: Acr.UserDialogs.dll => 0x29368635 => 4
	i32 775507847, ; 42: System.IO.Compression => 0x2e394f87 => 104
	i32 809851609, ; 43: System.Drawing.Common.dll => 0x30455ad9 => 103
	i32 843511501, ; 44: Xamarin.AndroidX.Print => 0x3246f6cd => 74
	i32 928116545, ; 45: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 95
	i32 955402788, ; 46: Newtonsoft.Json => 0x38f24a24 => 13
	i32 967690846, ; 47: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 60
	i32 974778368, ; 48: FormsViewGroup.dll => 0x3a19f000 => 5
	i32 1012816738, ; 49: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 76
	i32 1028951442, ; 50: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 9
	i32 1035644815, ; 51: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 38
	i32 1036786681, ; 52: Plugin.Toast => 0x3dcc1bf9 => 18
	i32 1042160112, ; 53: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 92
	i32 1052210849, ; 54: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 64
	i32 1098259244, ; 55: System => 0x41761b2c => 23
	i32 1175144683, ; 56: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 81
	i32 1178241025, ; 57: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 71
	i32 1204270330, ; 58: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 39
	i32 1267360935, ; 59: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 82
	i32 1293217323, ; 60: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 53
	i32 1365406463, ; 61: System.ServiceModel.Internals.dll => 0x516272ff => 108
	i32 1376866003, ; 62: Xamarin.AndroidX.SavedState => 0x52114ed3 => 76
	i32 1395857551, ; 63: Xamarin.AndroidX.Media.dll => 0x5333188f => 68
	i32 1406073936, ; 64: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 48
	i32 1411638395, ; 65: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 27
	i32 1426028455, ; 66: Plugin.Toast.dll => 0x54ff77a7 => 18
	i32 1460219004, ; 67: Xamarin.Forms.Xaml => 0x57092c7c => 93
	i32 1461234159, ; 68: System.Collections.Immutable.dll => 0x5718a9ef => 20
	i32 1462112819, ; 69: System.IO.Compression.dll => 0x57261233 => 104
	i32 1469204771, ; 70: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 37
	i32 1479771757, ; 71: System.Collections.Immutable => 0x5833866d => 20
	i32 1530663695, ; 72: Xamarin.Forms.Maps.dll => 0x5b3c130f => 90
	i32 1582372066, ; 73: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 52
	i32 1592978981, ; 74: System.Runtime.Serialization.dll => 0x5ef2ee25 => 3
	i32 1622152042, ; 75: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 66
	i32 1624863272, ; 76: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 85
	i32 1636350590, ; 77: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 50
	i32 1639515021, ; 78: System.Net.Http.dll => 0x61b9038d => 2
	i32 1657153582, ; 79: System.Runtime => 0x62c6282e => 28
	i32 1658241508, ; 80: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 79
	i32 1658251792, ; 81: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 94
	i32 1670060433, ; 82: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 47
	i32 1729485958, ; 83: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 43
	i32 1766324549, ; 84: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 78
	i32 1776026572, ; 85: System.Core.dll => 0x69dc03cc => 21
	i32 1788241197, ; 86: Xamarin.AndroidX.Fragment => 0x6a96652d => 55
	i32 1796167890, ; 87: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 8
	i32 1808609942, ; 88: Xamarin.AndroidX.Loader => 0x6bcd3296 => 66
	i32 1813201214, ; 89: Xamarin.Google.Android.Material => 0x6c13413e => 94
	i32 1818569960, ; 90: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 72
	i32 1828688058, ; 91: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 10
	i32 1867746548, ; 92: Xamarin.Essentials.dll => 0x6f538cf4 => 87
	i32 1878053835, ; 93: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 93
	i32 1881862856, ; 94: Xamarin.Forms.Maps.Android.dll => 0x702af2c8 => 89
	i32 1885316902, ; 95: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 40
	i32 1908813208, ; 96: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 97
	i32 1919157823, ; 97: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 69
	i32 2011961780, ; 98: System.Buffers.dll => 0x77ec19b4 => 19
	i32 2019465201, ; 99: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 64
	i32 2055257422, ; 100: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 61
	i32 2079903147, ; 101: System.Runtime.dll => 0x7bf8cdab => 28
	i32 2090596640, ; 102: System.Numerics.Vectors => 0x7c9bf920 => 26
	i32 2097448633, ; 103: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 57
	i32 2126786730, ; 104: Xamarin.Forms.Platform.Android => 0x7ec430aa => 91
	i32 2129483829, ; 105: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 96
	i32 2192057212, ; 106: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 10
	i32 2201231467, ; 107: System.Net.Http => 0x8334206b => 2
	i32 2217644978, ; 108: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 81
	i32 2244775296, ; 109: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 67
	i32 2256548716, ; 110: Xamarin.AndroidX.MultiDex => 0x8680336c => 69
	i32 2261435625, ; 111: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 59
	i32 2279755925, ; 112: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 75
	i32 2294913272, ; 113: Npgsql => 0x88c998f8 => 14
	i32 2315684594, ; 114: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 35
	i32 2409053734, ; 115: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 73
	i32 2416375347, ; 116: Konditer.Android => 0x9006f633 => 0
	i32 2465532216, ; 117: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 46
	i32 2471841756, ; 118: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 119: Java.Interop.dll => 0x93918882 => 6
	i32 2501346920, ; 120: System.Data.DataSetExtensions => 0x95178668 => 102
	i32 2505896520, ; 121: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 63
	i32 2570120770, ; 122: System.Text.Encodings.Web => 0x9930ee42 => 29
	i32 2581819634, ; 123: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 82
	i32 2620871830, ; 124: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 50
	i32 2624644809, ; 125: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 54
	i32 2633051222, ; 126: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 62
	i32 2701096212, ; 127: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 79
	i32 2715334215, ; 128: System.Threading.Tasks.dll => 0xa1d8b647 => 110
	i32 2732626843, ; 129: Xamarin.AndroidX.Activity => 0xa2e0939b => 34
	i32 2735172069, ; 130: System.Threading.Channels => 0xa30769e5 => 31
	i32 2737747696, ; 131: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 37
	i32 2766581644, ; 132: Xamarin.Forms.Core => 0xa4e6af8c => 88
	i32 2778768386, ; 133: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 84
	i32 2810250172, ; 134: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 48
	i32 2819470561, ; 135: System.Xml.dll => 0xa80db4e1 => 32
	i32 2847418871, ; 136: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 96
	i32 2853208004, ; 137: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 84
	i32 2855708567, ; 138: Xamarin.AndroidX.Transition => 0xaa36a797 => 80
	i32 2867931758, ; 139: Plugin.Toast.Abstractions.dll => 0xaaf12a6e => 17
	i32 2903344695, ; 140: System.ComponentModel.Composition => 0xad0d8637 => 106
	i32 2905242038, ; 141: mscorlib.dll => 0xad2a79b6 => 12
	i32 2916838712, ; 142: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 85
	i32 2919462931, ; 143: System.Numerics.Vectors.dll => 0xae037813 => 26
	i32 2921128767, ; 144: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 36
	i32 2978675010, ; 145: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 53
	i32 3017076677, ; 146: Xamarin.GooglePlayServices.Maps => 0xb3d4efc5 => 98
	i32 3024354802, ; 147: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 58
	i32 3044182254, ; 148: FormsViewGroup => 0xb57288ee => 5
	i32 3057625584, ; 149: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 70
	i32 3058099980, ; 150: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 99
	i32 3075834255, ; 151: System.Threading.Tasks => 0xb755818f => 110
	i32 3111772706, ; 152: System.Runtime.Serialization => 0xb979e222 => 3
	i32 3124832203, ; 153: System.Threading.Tasks.Extensions => 0xba4127cb => 109
	i32 3204380047, ; 154: System.Data.dll => 0xbefef58f => 100
	i32 3211777861, ; 155: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 52
	i32 3220365878, ; 156: System.Threading => 0xbff2e236 => 111
	i32 3230466174, ; 157: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 97
	i32 3247949154, ; 158: Mono.Security => 0xc197c562 => 112
	i32 3258312781, ; 159: Xamarin.AndroidX.CardView => 0xc235e84d => 43
	i32 3265893370, ; 160: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 109
	i32 3267021929, ; 161: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 41
	i32 3317135071, ; 162: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 51
	i32 3317144872, ; 163: System.Data => 0xc5b79d28 => 100
	i32 3340431453, ; 164: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 40
	i32 3342024700, ; 165: Plugin.Connectivity.Abstractions.dll => 0xc7333ffc => 15
	i32 3346324047, ; 166: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 71
	i32 3353484488, ; 167: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 57
	i32 3353544232, ; 168: Xamarin.CommunityToolkit.dll => 0xc7e30628 => 86
	i32 3358260929, ; 169: System.Text.Json => 0xc82afec1 => 30
	i32 3362522851, ; 170: Xamarin.AndroidX.Core => 0xc86c06e3 => 49
	i32 3366046733, ; 171: Plugin.Connectivity.dll => 0xc8a1cc0d => 16
	i32 3366347497, ; 172: Java.Interop => 0xc8a662e9 => 6
	i32 3374999561, ; 173: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 75
	i32 3395150330, ; 174: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 27
	i32 3404865022, ; 175: System.ServiceModel.Internals => 0xcaf21dfe => 108
	i32 3407215217, ; 176: Xamarin.CommunityToolkit => 0xcb15fa71 => 86
	i32 3429136800, ; 177: System.Xml => 0xcc6479a0 => 32
	i32 3430777524, ; 178: netstandard => 0xcc7d82b4 => 1
	i32 3441283291, ; 179: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 54
	i32 3476120550, ; 180: Mono.Android => 0xcf3163e6 => 11
	i32 3485117614, ; 181: System.Text.Json.dll => 0xcfbaacae => 30
	i32 3486566296, ; 182: System.Transactions => 0xcfd0c798 => 101
	i32 3493954962, ; 183: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 45
	i32 3501239056, ; 184: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 41
	i32 3503418941, ; 185: Konditer.Android.dll => 0xd0d1ee3d => 0
	i32 3509114376, ; 186: System.Xml.Linq => 0xd128d608 => 33
	i32 3536029504, ; 187: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 91
	i32 3567349600, ; 188: System.ComponentModel.Composition.dll => 0xd4a16f60 => 106
	i32 3618140916, ; 189: Xamarin.AndroidX.Preference => 0xd7a872f4 => 73
	i32 3627220390, ; 190: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 74
	i32 3632359727, ; 191: Xamarin.Forms.Platform => 0xd881692f => 92
	i32 3633644679, ; 192: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 36
	i32 3641597786, ; 193: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 61
	i32 3672681054, ; 194: Mono.Android.dll => 0xdae8aa5e => 11
	i32 3676310014, ; 195: System.Web.Services.dll => 0xdb2009fe => 107
	i32 3682565725, ; 196: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 42
	i32 3684561358, ; 197: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 45
	i32 3689375977, ; 198: System.Drawing.Common => 0xdbe768e9 => 103
	i32 3718780102, ; 199: Xamarin.AndroidX.Annotation => 0xdda814c6 => 35
	i32 3724971120, ; 200: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 70
	i32 3748608112, ; 201: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 22
	i32 3758932259, ; 202: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 59
	i32 3786282454, ; 203: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 44
	i32 3822602673, ; 204: Xamarin.AndroidX.Media => 0xe3d849b1 => 68
	i32 3829621856, ; 205: System.Numerics.dll => 0xe4436460 => 25
	i32 3829627230, ; 206: Konditer.dll => 0xe443795e => 7
	i32 3841636137, ; 207: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 9
	i32 3885922214, ; 208: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 80
	i32 3896760992, ; 209: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 49
	i32 3914259587, ; 210: Plugin.Connectivity => 0xe94edc83 => 16
	i32 3920810846, ; 211: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 105
	i32 3921031405, ; 212: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 83
	i32 3931092270, ; 213: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 72
	i32 3945713374, ; 214: System.Data.DataSetExtensions.dll => 0xeb2ecede => 102
	i32 3955647286, ; 215: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 38
	i32 3970018735, ; 216: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 99
	i32 4025784931, ; 217: System.Memory => 0xeff49a63 => 24
	i32 4073602200, ; 218: System.Threading.dll => 0xf2ce3c98 => 111
	i32 4105002889, ; 219: Mono.Security.dll => 0xf4ad5f89 => 112
	i32 4151237749, ; 220: System.Core => 0xf76edc75 => 21
	i32 4182413190, ; 221: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 65
	i32 4213026141, ; 222: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 22
	i32 4260525087, ; 223: System.Buffers => 0xfdf2741f => 19
	i32 4278134329, ; 224: Xamarin.GooglePlayServices.Maps.dll => 0xfeff2639 => 98
	i32 4292120959 ; 225: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 65
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [226 x i32] [
	i32 14, i32 63, i32 95, i32 13, i32 17, i32 88, i32 4, i32 77, ; 0..7
	i32 77, i32 31, i32 44, i32 78, i32 42, i32 89, i32 58, i32 107, ; 8..15
	i32 47, i32 62, i32 56, i32 34, i32 90, i32 25, i32 60, i32 24, ; 16..23
	i32 46, i32 87, i32 55, i32 12, i32 23, i32 56, i32 67, i32 101, ; 24..31
	i32 8, i32 7, i32 105, i32 51, i32 29, i32 83, i32 39, i32 15, ; 32..39
	i32 33, i32 4, i32 104, i32 103, i32 74, i32 95, i32 13, i32 60, ; 40..47
	i32 5, i32 76, i32 9, i32 38, i32 18, i32 92, i32 64, i32 23, ; 48..55
	i32 81, i32 71, i32 39, i32 82, i32 53, i32 108, i32 76, i32 68, ; 56..63
	i32 48, i32 27, i32 18, i32 93, i32 20, i32 104, i32 37, i32 20, ; 64..71
	i32 90, i32 52, i32 3, i32 66, i32 85, i32 50, i32 2, i32 28, ; 72..79
	i32 79, i32 94, i32 47, i32 43, i32 78, i32 21, i32 55, i32 8, ; 80..87
	i32 66, i32 94, i32 72, i32 10, i32 87, i32 93, i32 89, i32 40, ; 88..95
	i32 97, i32 69, i32 19, i32 64, i32 61, i32 28, i32 26, i32 57, ; 96..103
	i32 91, i32 96, i32 10, i32 2, i32 81, i32 67, i32 69, i32 59, ; 104..111
	i32 75, i32 14, i32 35, i32 73, i32 0, i32 46, i32 1, i32 6, ; 112..119
	i32 102, i32 63, i32 29, i32 82, i32 50, i32 54, i32 62, i32 79, ; 120..127
	i32 110, i32 34, i32 31, i32 37, i32 88, i32 84, i32 48, i32 32, ; 128..135
	i32 96, i32 84, i32 80, i32 17, i32 106, i32 12, i32 85, i32 26, ; 136..143
	i32 36, i32 53, i32 98, i32 58, i32 5, i32 70, i32 99, i32 110, ; 144..151
	i32 3, i32 109, i32 100, i32 52, i32 111, i32 97, i32 112, i32 43, ; 152..159
	i32 109, i32 41, i32 51, i32 100, i32 40, i32 15, i32 71, i32 57, ; 160..167
	i32 86, i32 30, i32 49, i32 16, i32 6, i32 75, i32 27, i32 108, ; 168..175
	i32 86, i32 32, i32 1, i32 54, i32 11, i32 30, i32 101, i32 45, ; 176..183
	i32 41, i32 0, i32 33, i32 91, i32 106, i32 73, i32 74, i32 92, ; 184..191
	i32 36, i32 61, i32 11, i32 107, i32 42, i32 45, i32 103, i32 35, ; 192..199
	i32 70, i32 22, i32 59, i32 44, i32 68, i32 25, i32 7, i32 9, ; 200..207
	i32 80, i32 49, i32 16, i32 105, i32 83, i32 72, i32 102, i32 38, ; 208..215
	i32 99, i32 24, i32 111, i32 112, i32 21, i32 65, i32 22, i32 19, ; 216..223
	i32 98, i32 65 ; 224..225
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
