/*
 * File:        Range.cs
 * Author:      Igor Spiridonov
 * Descrpition: This file contains definitions for utility classes ValueRange, FloatRange and IntRange
 * Created:     20.06.2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RotoChips.Utility
{

    // utility classes for ranged values
    public interface IRange<T>
    {
        T Range
        {
            get;
        }
        T Random
        {
            get;
        }
        T Median
        {
            get;
        }
        bool Contains(T value);
    }

    [System.Serializable]
    public class ValueRange<T>
    {
        public T min;
        public T max;
        public override string ToString()
        {
            return GetType().Name + "(min:" + min.ToString() + ", max:" + max.ToString() + ")";
        }
        public T this[int i]
        {
            get
            {
                return (i % 2 == 0) ? min : max;
            }
            set
            {
                if (i % 2 == 0)
                {
                    min = value;
                }
                else
                {
                    max = value;
                }
            }
        }
    }

    [System.Serializable]
    public class FloatRange : ValueRange<float>, IRange<float>
    {
        public float Range
        {
            get
            {
                return max - min;
            }
        }

        public float Random
        {
            get
            {
                return UnityEngine.Random.Range(Mathf.Min(min, max), Mathf.Max(min, max));
            }
        }

        public float Median
        {
            get
            {
                return (min + max) / 2;
            }
        }

        public bool Contains(float value)
        {
            return value >= min && value <= max;
        }

        public static FloatRange operator +(FloatRange range, float value)
        {
            return new FloatRange
            {
                min = range.min + value,
                max = range.max + value
            };
        }

        public static FloatRange operator -(FloatRange range, float value)
        {
            return new FloatRange
            {
                min = range.min - value,
                max = range.max - value
            };
        }

        public static FloatRange operator +(FloatRange range1, FloatRange range2)
        {
            return new FloatRange
            {
                min = range1.min + range2.min,
                max = range1.max + range2.max
            };
        }

        public static FloatRange operator -(FloatRange range1, FloatRange range2)
        {
            return new FloatRange
            {
                min = range1.min - range2.min,
                max = range1.max - range2.max
            };
        }

        public static FloatRange operator *(FloatRange range1, FloatRange range2)
        {
            return new FloatRange
            {
                min = range1.min * range2.min,
                max = range1.max * range2.max
            };
        }

        public static FloatRange operator *(FloatRange range1, float value)
        {
            return new FloatRange
            {
                min = range1.min * value,
                max = range1.max * value
            };
        }

        public static implicit operator FloatRange(float value)
        {
            return new FloatRange
            {
                min = value,
                max = value
            };
        }

    }

    [System.Serializable]
    public class IntRange : ValueRange<int>
    {
        public int Range
        {
            get
            {
                return max - min;
            }
        }

        public int Random
        {
            get
            {
                return UnityEngine.Random.Range(Mathf.Min(min, max), Mathf.Max(min, max));
            }
        }

        public float Median
        {
            get
            {
                return (min + max) / 2;
            }
        }

        public bool Contains(int value)
        {
            return value >= min && value < max;
        }

        public static IntRange operator +(IntRange range, int value)
        {
            return new IntRange
            {
                min = range.min + value,
                max = range.max + value
            };
        }

        public static IntRange operator -(IntRange range, int value)
        {
            return new IntRange
            {
                min = range.min - value,
                max = range.max - value
            };
        }

        public static implicit operator IntRange(int value)
        {
            return new IntRange
            {
                min = value,
                max = value + 1
            };
        }

    }

}
