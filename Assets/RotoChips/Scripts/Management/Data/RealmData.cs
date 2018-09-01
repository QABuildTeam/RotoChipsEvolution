/*
 * File:        RealmData.cs
 * Author:      Igor Spiridonov
 * Descrpition: Class RealmData contains static data for game realms
 * Created:     24.08.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.Data
{
    // this class provides access to initial game realm data
    public class RealmData
    {
        // game realm (5 levels construct) description data
        public struct Init
        {
            public int id;
            public int mainLevelId;
            public int prevRealmId;
            public int nextRealmId;
            public Color connectorColor;
            public Color worldLightColor;
            public float worldLightIntensity;
            public int[] members;
        };

        public static readonly Init[] initializers = {
        new Init {
            id=0,
            mainLevelId=0,
            prevRealmId=-1,
            nextRealmId=1,
            connectorColor = new Color( 0.231373f, 0.360784f, 0.619608f, 1.000000f ),
            worldLightColor = new Color(0.909803922f, 0.498039216f, 0.976470588f, 1.000000f),
            worldLightIntensity = 1.19f,
            members=new int[] { 0, 1, 2, 3, 4 }
        },
        new Init {
            id=1,
            mainLevelId=5,
            prevRealmId=0,
            nextRealmId=2,
            connectorColor = new Color( 0.000000f, 0.686275f, 0.015686f, 1.000000f ),
            worldLightColor = new Color(0.564705882f, 0.878431373f, 0.588235294f, 1.000000f),
            worldLightIntensity = 1.03f,
            members=new int[] { 5, 6, 7, 8, 9 }
        },
        new Init {
            id=2,
            mainLevelId=10,
            prevRealmId=1,
            nextRealmId=3,
            connectorColor = new Color( 1.000000f, 0.207843f, 0.352941f, 1.000000f ),
            worldLightColor = new Color(1.000000f, 0.184313725f, 0.000000f, 1.000000f),
            worldLightIntensity = 1.26f,
            members=new int[] { 10, 11, 12, 13, 14 }
        },
        new Init {
            id=3,
            mainLevelId=15,
            prevRealmId=2,
            nextRealmId=4,
            connectorColor = new Color( 1.000000f, 0.921569f, 0.231373f, 1.000000f ),
            worldLightColor = new Color(0.901960784f, 0.600000f, 0.000000f, 1.000000f),
            worldLightIntensity = 1.11f,
            members=new int[] { 15, 16, 17, 18, 19 }
        },
        new Init {
            id=4,
            mainLevelId=20,
            prevRealmId=3,
            nextRealmId=5,
            connectorColor = new Color( 0.760784f, 0.407843f, 0.698039f, 1.000000f ),
            worldLightColor = new Color(0.454901961f, 0.788235294f, 0.800000f, 1.000000f),
            worldLightIntensity = 1.14f,
            members=new int[] { 20, 21, 22, 23, 24 }
        },
        new Init {
            id=5,
            mainLevelId=25,
            prevRealmId=4,
            nextRealmId=6,
            connectorColor = new Color( 1.000000f, 0.745098f, 0.564706f, 1.000000f ),
            worldLightColor = new Color(0.000000f, 1.000000f, 0.000000f, 1.000000f),
            worldLightIntensity = 0.84f,
            members=new int[] { 25, 26, 27, 28, 29 }
        },
        new Init {
            id=6,
            mainLevelId=30,
            prevRealmId=5,
            nextRealmId=-1,
            connectorColor = new Color( 1.000000f, 1.000000f, 1.000000f, 1.000000f ),
            worldLightColor = new Color( 1.000000f, 1.000000f, 1.000000f, 1.000000f ),
            worldLightIntensity = 1.02f,
            members=new int[] { 30, 31, 32, 33, 34 }
        }
    };

    }
}
