using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.Data
{
    // this class provides access to initial and current game level data
    public class LevelData
    {

        public class Init                       // this is a structure of read-only data used for puzzle level initialization
        {
            public int id;
            public int realmId;
            public int height;
            public int width;
            public float srcXYScale;            // x/y ratio for 'source' image
            public float finalXYScale;          // x/y ratio for 'final' image
            public float eulerX;                // world euler rotation angle by X-axis for level 'select' button
            public float eulerY;                // world euler rotation angle by Y-axis for level 'select' button
            public float eulerZ;                // world euler rotation angle by Z-axis for level 'select' button
            public float selectHeight;          // height of level 'select' button
        };

        public static readonly Init[] initializers =
        {
            new Init { id=0, realmId=0, height=3, width=3, srcXYScale=1f, finalXYScale=1.88679245283019f, eulerX=30f, eulerY=195f, eulerZ=0f, selectHeight=1f },
            new Init { id=1, realmId=0, height=3, width=3, srcXYScale=1f, finalXYScale=1.53846153846154f, eulerX=30f, eulerY=187f, eulerZ=0f, selectHeight=0f },
            new Init { id=2, realmId=0, height=3, width=3, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=30f, eulerY=203f, eulerZ=0f, selectHeight=0f },
            new Init { id=3, realmId=0, height=3, width=3, srcXYScale=1f, finalXYScale=1.94647201946472f, eulerX=38f, eulerY=195f, eulerZ=0f, selectHeight=0f },
            new Init { id=4, realmId=0, height=4, width=3, srcXYScale=0.75f, finalXYScale=0.666666666666667f, eulerX=22f, eulerY=195f, eulerZ=0f, selectHeight=0f },
            new Init { id=5, realmId=1, height=3, width=3, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=-8f, eulerY=235f, eulerZ=-27f, selectHeight=1f },
            new Init { id=6, realmId=1, height=3, width=5, srcXYScale=1.66666666666667f, finalXYScale=2.83687943262411f, eulerX=-8f, eulerY=243f, eulerZ=-27f, selectHeight=0f },
            new Init { id=7, realmId=1, height=3, width=4, srcXYScale=1.33333333333333f, finalXYScale=1.50093808630394f, eulerX=-8f, eulerY=228f, eulerZ=-27f, selectHeight=0f },
            new Init { id=8, realmId=1, height=3, width=4, srcXYScale=1.33333333333333f, finalXYScale=1.50093808630394f, eulerX=-2f, eulerY=234.5f, eulerZ=-22f, selectHeight=0f },
            new Init { id=9, realmId=1, height=4, width=4, srcXYScale=1f, finalXYScale=1.49906191369606f, eulerX=-11f, eulerY=236f, eulerZ=-33.5f, selectHeight=0f },
            new Init { id=10, realmId=2, height=4, width=4, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=-70f, eulerY=-18f, eulerZ=10f, selectHeight=1f },
            new Init { id=11, realmId=2, height=4, width=4, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=-70f, eulerY=-10f, eulerZ=9f, selectHeight=0f },
            new Init { id=12, realmId=2, height=4, width=3, srcXYScale=0.75f, finalXYScale=1.50093808630394f, eulerX=-70f, eulerY=-25f, eulerZ=10f, selectHeight=0f },
            new Init { id=13, realmId=2, height=4, width=4, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=-76.5f, eulerY=-24.7f, eulerZ=17f, selectHeight=0f },
            new Init { id=14, realmId=2, height=4, width=5, srcXYScale=1.25f, finalXYScale=1.50093808630394f, eulerX=-63.5f, eulerY=-14.5f, eulerZ=6f, selectHeight=0f },
            new Init { id=15, realmId=3, height=4, width=4, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=-5f, eulerY=113f, eulerZ=19f, selectHeight=1f },
            new Init { id=16, realmId=3, height=3, width=5, srcXYScale=1.66666666666667f, finalXYScale=2.03562340966921f, eulerX=-5f, eulerY=106f, eulerZ=19f, selectHeight=0f },
            new Init { id=17, realmId=3, height=5, width=3, srcXYScale=0.6f, finalXYScale=1f, eulerX=-5f, eulerY=120f, eulerZ=19f, selectHeight=0f },
            new Init { id=18, realmId=3, height=4, width=5, srcXYScale=1.25f, finalXYScale=1.68161434977578f, eulerX=-1.5f, eulerY=113.2f, eulerZ=13.5f, selectHeight=0f },
            new Init { id=19, realmId=3, height=5, width=4, srcXYScale=0.8f, finalXYScale=1f, eulerX=-6.3f, eulerY=112.5f, eulerZ=26f, selectHeight=0f },
            new Init { id=20, realmId=4, height=2, width=4, srcXYScale=2f, finalXYScale=2.25352112676056f, eulerX=16.2f, eulerY=115f, eulerZ=-83.6f, selectHeight=1f },
            new Init { id=21, realmId=4, height=3, width=5, srcXYScale=1.66666666666667f, finalXYScale=1.50093808630394f, eulerX=17f, eulerY=108.5f, eulerZ=-83f, selectHeight=0f },
            new Init { id=22, realmId=4, height=4, width=5, srcXYScale=1.25f, finalXYScale=1.50093808630394f, eulerX=17.7f, eulerY=122f, eulerZ=-82.7f, selectHeight=0f },
            new Init { id=23, realmId=4, height=5, width=5, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=18f, eulerY=113f, eulerZ=-90f, selectHeight=0f },
            new Init { id=24, realmId=4, height=4, width=6, srcXYScale=1.5f, finalXYScale=1.58415841584158f, eulerX=13.8f, eulerY=116.6f, eulerZ=-77.5f, selectHeight=0f },
            new Init { id=25, realmId=5, height=5, width=5, srcXYScale=1f, finalXYScale=1f, eulerX=42f, eulerY=27f, eulerZ=16.8f, selectHeight=1f },
            new Init { id=26, realmId=5, height=5, width=5, srcXYScale=1f, finalXYScale=2.16049382716049f, eulerX=42f, eulerY=20f, eulerZ=16.4f, selectHeight=0f },
            new Init { id=27, realmId=5, height=4, width=5, srcXYScale=1.25f, finalXYScale=1.52749490835031f, eulerX=42.2f, eulerY=33.3f, eulerZ=16.3f, selectHeight=0f },
            new Init { id=28, realmId=5, height=5, width=5, srcXYScale=1f, finalXYScale=1.98863636363636f, eulerX=36f, eulerY=25.3f, eulerZ=14f, selectHeight=0f },
            new Init { id=29, realmId=5, height=6, width=6, srcXYScale=1f, finalXYScale=1.04017857142857f, eulerX=47.8f, eulerY=29.6f, eulerZ=20.4f, selectHeight=0f },
            new Init { id=30, realmId=6, height=2, width=6, srcXYScale=3f, finalXYScale=1.76767676767677f, eulerX=-3.6f, eulerY=288f, eulerZ=11.3f, selectHeight=1f },
            new Init { id=31, realmId=6, height=6, width=4, srcXYScale=0.666666666666667f, finalXYScale=0.66625f, eulerX=-2.2f, eulerY=281f, eulerZ=11.6f, selectHeight=0f },
            new Init { id=32, realmId=6, height=4, width=6, srcXYScale=1.5f, finalXYScale=1.79372197309417f, eulerX=-4.9f, eulerY=294.6f, eulerZ=10.76f, selectHeight=0f },
            new Init { id=33, realmId=6, height=6, width=5, srcXYScale=0.833333333333333f, finalXYScale=0.665f, eulerX=-5.7f, eulerY=287.3f, eulerZ=17.4f, selectHeight=0f },
            new Init { id=34, realmId=6, height=6, width=6, srcXYScale=1f, finalXYScale=1.50093808630394f, eulerX=-2.2f, eulerY=288.3f, eulerZ=5.1f, selectHeight=0f }
        };

    }
}
