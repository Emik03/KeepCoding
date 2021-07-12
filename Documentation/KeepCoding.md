<a name='assembly'></a>
# KeepCoding

## Contents

- [ArrayHelper](#T-KeepCoding-ArrayHelper 'KeepCoding.ArrayHelper')
  - [AsReadOnly\`\`1(array)](#M-KeepCoding-ArrayHelper-AsReadOnly``1-``0[]- 'KeepCoding.ArrayHelper.AsReadOnly``1(``0[])')
  - [BinarySearch(array,value)](#M-KeepCoding-ArrayHelper-BinarySearch-System-Array,System-Object- 'KeepCoding.ArrayHelper.BinarySearch(System.Array,System.Object)')
  - [BinarySearch(array,value,comparer)](#M-KeepCoding-ArrayHelper-BinarySearch-System-Array,System-Object,System-Collections-IComparer- 'KeepCoding.ArrayHelper.BinarySearch(System.Array,System.Object,System.Collections.IComparer)')
  - [BinarySearch(array,index,length,value)](#M-KeepCoding-ArrayHelper-BinarySearch-System-Array,System-Int32,System-Int32,System-Object- 'KeepCoding.ArrayHelper.BinarySearch(System.Array,System.Int32,System.Int32,System.Object)')
  - [BinarySearch(array,index,length,value,comparer)](#M-KeepCoding-ArrayHelper-BinarySearch-System-Array,System-Int32,System-Int32,System-Object,System-Collections-IComparer- 'KeepCoding.ArrayHelper.BinarySearch(System.Array,System.Int32,System.Int32,System.Object,System.Collections.IComparer)')
  - [BinarySearch\`\`1(array,value)](#M-KeepCoding-ArrayHelper-BinarySearch``1-``0[],``0- 'KeepCoding.ArrayHelper.BinarySearch``1(``0[],``0)')
  - [BinarySearch\`\`1(array,value,comparer)](#M-KeepCoding-ArrayHelper-BinarySearch``1-``0[],``0,System-Collections-Generic-IComparer{``0}- 'KeepCoding.ArrayHelper.BinarySearch``1(``0[],``0,System.Collections.Generic.IComparer{``0})')
  - [BinarySearch\`\`1(array,index,length,value)](#M-KeepCoding-ArrayHelper-BinarySearch``1-``0[],System-Int32,System-Int32,``0- 'KeepCoding.ArrayHelper.BinarySearch``1(``0[],System.Int32,System.Int32,``0)')
  - [BinarySearch\`\`1(array,index,length,value,comparer)](#M-KeepCoding-ArrayHelper-BinarySearch``1-``0[],System-Int32,System-Int32,``0,System-Collections-Generic-IComparer{``0}- 'KeepCoding.ArrayHelper.BinarySearch``1(``0[],System.Int32,System.Int32,``0,System.Collections.Generic.IComparer{``0})')
  - [Clear(array,index,length)](#M-KeepCoding-ArrayHelper-Clear-System-Array,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.Clear(System.Array,System.Int32,System.Int32)')
  - [Clone(this)](#M-KeepCoding-ArrayHelper-Clone-System-Array- 'KeepCoding.ArrayHelper.Clone(System.Array)')
  - [ConstrainedCopy(sourceArray,sourceIndex,destinationArray,destinationIndex,length)](#M-KeepCoding-ArrayHelper-ConstrainedCopy-System-Array,System-Int32,System-Array,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.ConstrainedCopy(System.Array,System.Int32,System.Array,System.Int32,System.Int32)')
  - [ConvertAll\`\`2(array,converter)](#M-KeepCoding-ArrayHelper-ConvertAll``2-``0[],System-Converter{``0,``1}- 'KeepCoding.ArrayHelper.ConvertAll``2(``0[],System.Converter{``0,``1})')
  - [Copy(sourceArray,sourceIndex,destinationArray,destinationIndex,length)](#M-KeepCoding-ArrayHelper-Copy-System-Array,System-Int64,System-Array,System-Int64,System-Int64- 'KeepCoding.ArrayHelper.Copy(System.Array,System.Int64,System.Array,System.Int64,System.Int64)')
  - [Copy(sourceArray,sourceIndex,destinationArray,destinationIndex,length)](#M-KeepCoding-ArrayHelper-Copy-System-Array,System-Int32,System-Array,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.Copy(System.Array,System.Int32,System.Array,System.Int32,System.Int32)')
  - [Copy(sourceArray,destinationArray,length)](#M-KeepCoding-ArrayHelper-Copy-System-Array,System-Array,System-Int64- 'KeepCoding.ArrayHelper.Copy(System.Array,System.Array,System.Int64)')
  - [Copy(sourceArray,destinationArray,length)](#M-KeepCoding-ArrayHelper-Copy-System-Array,System-Array,System-Int32- 'KeepCoding.ArrayHelper.Copy(System.Array,System.Array,System.Int32)')
  - [CopyTo(this,array,index)](#M-KeepCoding-ArrayHelper-CopyTo-System-Array,System-Array,System-Int32- 'KeepCoding.ArrayHelper.CopyTo(System.Array,System.Array,System.Int32)')
  - [CopyTo(this,array,index)](#M-KeepCoding-ArrayHelper-CopyTo-System-Array,System-Array,System-Int64- 'KeepCoding.ArrayHelper.CopyTo(System.Array,System.Array,System.Int64)')
  - [CreateInstance(elementType,length)](#M-KeepCoding-ArrayHelper-CreateInstance-System-Type,System-Int32- 'KeepCoding.ArrayHelper.CreateInstance(System.Type,System.Int32)')
  - [CreateInstance(elementType,lengths)](#M-KeepCoding-ArrayHelper-CreateInstance-System-Type,System-Int32[]- 'KeepCoding.ArrayHelper.CreateInstance(System.Type,System.Int32[])')
  - [CreateInstance(elementType,lengths)](#M-KeepCoding-ArrayHelper-CreateInstance-System-Type,System-Int64[]- 'KeepCoding.ArrayHelper.CreateInstance(System.Type,System.Int64[])')
  - [CreateInstance(elementType,length1,length2)](#M-KeepCoding-ArrayHelper-CreateInstance-System-Type,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.CreateInstance(System.Type,System.Int32,System.Int32)')
  - [CreateInstance(elementType,lengths,lowerBounds)](#M-KeepCoding-ArrayHelper-CreateInstance-System-Type,System-Int32[],System-Int32[]- 'KeepCoding.ArrayHelper.CreateInstance(System.Type,System.Int32[],System.Int32[])')
  - [CreateInstance(elementType,length1,length2,length3)](#M-KeepCoding-ArrayHelper-CreateInstance-System-Type,System-Int32,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.CreateInstance(System.Type,System.Int32,System.Int32,System.Int32)')
  - [Exists\`\`1(array,match)](#M-KeepCoding-ArrayHelper-Exists``1-``0[],System-Predicate{``0}- 'KeepCoding.ArrayHelper.Exists``1(``0[],System.Predicate{``0})')
  - [FindAll\`\`1(array,match)](#M-KeepCoding-ArrayHelper-FindAll``1-``0[],System-Predicate{``0}- 'KeepCoding.ArrayHelper.FindAll``1(``0[],System.Predicate{``0})')
  - [FindIndex\`\`1(array,match)](#M-KeepCoding-ArrayHelper-FindIndex``1-``0[],System-Predicate{``0}- 'KeepCoding.ArrayHelper.FindIndex``1(``0[],System.Predicate{``0})')
  - [FindIndex\`\`1(array,startIndex,match)](#M-KeepCoding-ArrayHelper-FindIndex``1-``0[],System-Int32,System-Predicate{``0}- 'KeepCoding.ArrayHelper.FindIndex``1(``0[],System.Int32,System.Predicate{``0})')
  - [FindIndex\`\`1(array,startIndex,count,match)](#M-KeepCoding-ArrayHelper-FindIndex``1-``0[],System-Int32,System-Int32,System-Predicate{``0}- 'KeepCoding.ArrayHelper.FindIndex``1(``0[],System.Int32,System.Int32,System.Predicate{``0})')
  - [FindLastIndex\`\`1(array,match)](#M-KeepCoding-ArrayHelper-FindLastIndex``1-``0[],System-Predicate{``0}- 'KeepCoding.ArrayHelper.FindLastIndex``1(``0[],System.Predicate{``0})')
  - [FindLastIndex\`\`1(array,startIndex,match)](#M-KeepCoding-ArrayHelper-FindLastIndex``1-``0[],System-Int32,System-Predicate{``0}- 'KeepCoding.ArrayHelper.FindLastIndex``1(``0[],System.Int32,System.Predicate{``0})')
  - [FindLastIndex\`\`1(array,startIndex,count,match)](#M-KeepCoding-ArrayHelper-FindLastIndex``1-``0[],System-Int32,System-Int32,System-Predicate{``0}- 'KeepCoding.ArrayHelper.FindLastIndex``1(``0[],System.Int32,System.Int32,System.Predicate{``0})')
  - [FindLast\`\`1(array,match)](#M-KeepCoding-ArrayHelper-FindLast``1-``0[],System-Predicate{``0}- 'KeepCoding.ArrayHelper.FindLast``1(``0[],System.Predicate{``0})')
  - [Find\`\`1(array,match)](#M-KeepCoding-ArrayHelper-Find``1-``0[],System-Predicate{``0}- 'KeepCoding.ArrayHelper.Find``1(``0[],System.Predicate{``0})')
  - [ForEach\`\`1(array,action)](#M-KeepCoding-ArrayHelper-ForEach``1-``0[],System-Action{``0}- 'KeepCoding.ArrayHelper.ForEach``1(``0[],System.Action{``0})')
  - [Get(this,index1,index2,index3)](#M-KeepCoding-ArrayHelper-Get-System-Array,System-Int64,System-Int64,System-Int64- 'KeepCoding.ArrayHelper.Get(System.Array,System.Int64,System.Int64,System.Int64)')
  - [Get(this,index1,index2,index3)](#M-KeepCoding-ArrayHelper-Get-System-Array,System-Int32,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.Get(System.Array,System.Int32,System.Int32,System.Int32)')
  - [Get(this,index1,index2)](#M-KeepCoding-ArrayHelper-Get-System-Array,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.Get(System.Array,System.Int32,System.Int32)')
  - [Get(this,index)](#M-KeepCoding-ArrayHelper-Get-System-Array,System-Int32- 'KeepCoding.ArrayHelper.Get(System.Array,System.Int32)')
  - [Get(this,index)](#M-KeepCoding-ArrayHelper-Get-System-Array,System-Int64- 'KeepCoding.ArrayHelper.Get(System.Array,System.Int64)')
  - [Get(this,indices)](#M-KeepCoding-ArrayHelper-Get-System-Array,System-Int32[]- 'KeepCoding.ArrayHelper.Get(System.Array,System.Int32[])')
  - [Get(this,indices)](#M-KeepCoding-ArrayHelper-Get-System-Array,System-Int64[]- 'KeepCoding.ArrayHelper.Get(System.Array,System.Int64[])')
  - [GetEnumerator(this)](#M-KeepCoding-ArrayHelper-GetEnumerator-System-Array- 'KeepCoding.ArrayHelper.GetEnumerator(System.Array)')
  - [GetLength(this,dimension)](#M-KeepCoding-ArrayHelper-GetLength-System-Array,System-Int32- 'KeepCoding.ArrayHelper.GetLength(System.Array,System.Int32)')
  - [GetLongLength(this,dimension)](#M-KeepCoding-ArrayHelper-GetLongLength-System-Array,System-Int32- 'KeepCoding.ArrayHelper.GetLongLength(System.Array,System.Int32)')
  - [GetLowerBound(this,dimension)](#M-KeepCoding-ArrayHelper-GetLowerBound-System-Array,System-Int32- 'KeepCoding.ArrayHelper.GetLowerBound(System.Array,System.Int32)')
  - [GetUpperBound(this,dimension)](#M-KeepCoding-ArrayHelper-GetUpperBound-System-Array,System-Int32- 'KeepCoding.ArrayHelper.GetUpperBound(System.Array,System.Int32)')
  - [GetValue(this,index1,index2)](#M-KeepCoding-ArrayHelper-GetValue-System-Array,System-Int64,System-Int64- 'KeepCoding.ArrayHelper.GetValue(System.Array,System.Int64,System.Int64)')
  - [IndexOf(array,value)](#M-KeepCoding-ArrayHelper-IndexOf-System-Array,System-Object- 'KeepCoding.ArrayHelper.IndexOf(System.Array,System.Object)')
  - [IndexOf(array,value,startIndex)](#M-KeepCoding-ArrayHelper-IndexOf-System-Array,System-Object,System-Int32- 'KeepCoding.ArrayHelper.IndexOf(System.Array,System.Object,System.Int32)')
  - [IndexOf(array,value,startIndex,count)](#M-KeepCoding-ArrayHelper-IndexOf-System-Array,System-Object,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.IndexOf(System.Array,System.Object,System.Int32,System.Int32)')
  - [IndexOf\`\`1(array,value,startIndex,count)](#M-KeepCoding-ArrayHelper-IndexOf``1-``0[],``0,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.IndexOf``1(``0[],``0,System.Int32,System.Int32)')
  - [IndexOf\`\`1(array,value)](#M-KeepCoding-ArrayHelper-IndexOf``1-``0[],``0- 'KeepCoding.ArrayHelper.IndexOf``1(``0[],``0)')
  - [IndexOf\`\`1(array,value,startIndex)](#M-KeepCoding-ArrayHelper-IndexOf``1-``0[],``0,System-Int32- 'KeepCoding.ArrayHelper.IndexOf``1(``0[],``0,System.Int32)')
  - [Initialize(this)](#M-KeepCoding-ArrayHelper-Initialize-System-Array- 'KeepCoding.ArrayHelper.Initialize(System.Array)')
  - [LastIndexOf(array,value)](#M-KeepCoding-ArrayHelper-LastIndexOf-System-Array,System-Object- 'KeepCoding.ArrayHelper.LastIndexOf(System.Array,System.Object)')
  - [LastIndexOf(array,value,startIndex)](#M-KeepCoding-ArrayHelper-LastIndexOf-System-Array,System-Object,System-Int32- 'KeepCoding.ArrayHelper.LastIndexOf(System.Array,System.Object,System.Int32)')
  - [LastIndexOf(array,value,startIndex,count)](#M-KeepCoding-ArrayHelper-LastIndexOf-System-Array,System-Object,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.LastIndexOf(System.Array,System.Object,System.Int32,System.Int32)')
  - [LastIndexOf\`\`1(array,value,startIndex,count)](#M-KeepCoding-ArrayHelper-LastIndexOf``1-``0[],``0,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.LastIndexOf``1(``0[],``0,System.Int32,System.Int32)')
  - [LastIndexOf\`\`1(array,value)](#M-KeepCoding-ArrayHelper-LastIndexOf``1-``0[],``0- 'KeepCoding.ArrayHelper.LastIndexOf``1(``0[],``0)')
  - [LastIndexOf\`\`1(array,value,startIndex)](#M-KeepCoding-ArrayHelper-LastIndexOf``1-``0[],``0,System-Int32- 'KeepCoding.ArrayHelper.LastIndexOf``1(``0[],``0,System.Int32)')
  - [Resize\`\`1(array,newSize)](#M-KeepCoding-ArrayHelper-Resize``1-``0[],System-Int32- 'KeepCoding.ArrayHelper.Resize``1(``0[],System.Int32)')
  - [Reverse(array,index,length)](#M-KeepCoding-ArrayHelper-Reverse-System-Array,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.Reverse(System.Array,System.Int32,System.Int32)')
  - [Reverse(array)](#M-KeepCoding-ArrayHelper-Reverse-System-Array- 'KeepCoding.ArrayHelper.Reverse(System.Array)')
  - [Reverse\`\`1(array)](#M-KeepCoding-ArrayHelper-Reverse``1-``0[]- 'KeepCoding.ArrayHelper.Reverse``1(``0[])')
  - [Reverse\`\`1(array,index,length)](#M-KeepCoding-ArrayHelper-Reverse``1-``0[],System-Int32,System-Int32- 'KeepCoding.ArrayHelper.Reverse``1(``0[],System.Int32,System.Int32)')
  - [Set(this,value,index)](#M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int32- 'KeepCoding.ArrayHelper.Set(System.Array,System.Object,System.Int32)')
  - [Set(this,value,indices)](#M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int32[]- 'KeepCoding.ArrayHelper.Set(System.Array,System.Object,System.Int32[])')
  - [Set(this,value,index)](#M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int64- 'KeepCoding.ArrayHelper.Set(System.Array,System.Object,System.Int64)')
  - [Set(this,value,indices)](#M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int64[]- 'KeepCoding.ArrayHelper.Set(System.Array,System.Object,System.Int64[])')
  - [Set(this,value,index1,index2)](#M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.Set(System.Array,System.Object,System.Int32,System.Int32)')
  - [Set(this,value,index1,index2)](#M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int64,System-Int64- 'KeepCoding.ArrayHelper.Set(System.Array,System.Object,System.Int64,System.Int64)')
  - [Set(this,value,index1,index2,index3)](#M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int32,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.Set(System.Array,System.Object,System.Int32,System.Int32,System.Int32)')
  - [Set(this,value,index1,index2,index3)](#M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int64,System-Int64,System-Int64- 'KeepCoding.ArrayHelper.Set(System.Array,System.Object,System.Int64,System.Int64,System.Int64)')
  - [Sort(array,index,length,comparer)](#M-KeepCoding-ArrayHelper-Sort-System-Array,System-Int32,System-Int32,System-Collections-IComparer- 'KeepCoding.ArrayHelper.Sort(System.Array,System.Int32,System.Int32,System.Collections.IComparer)')
  - [Sort(keys,items,index,length,comparer)](#M-KeepCoding-ArrayHelper-Sort-System-Array,System-Array,System-Int32,System-Int32,System-Collections-IComparer- 'KeepCoding.ArrayHelper.Sort(System.Array,System.Array,System.Int32,System.Int32,System.Collections.IComparer)')
  - [Sort(array,index,length)](#M-KeepCoding-ArrayHelper-Sort-System-Array,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.Sort(System.Array,System.Int32,System.Int32)')
  - [Sort(keys,items,index,length)](#M-KeepCoding-ArrayHelper-Sort-System-Array,System-Array,System-Int32,System-Int32- 'KeepCoding.ArrayHelper.Sort(System.Array,System.Array,System.Int32,System.Int32)')
  - [Sort(array,comparer)](#M-KeepCoding-ArrayHelper-Sort-System-Array,System-Collections-IComparer- 'KeepCoding.ArrayHelper.Sort(System.Array,System.Collections.IComparer)')
  - [Sort(keys,items,comparer)](#M-KeepCoding-ArrayHelper-Sort-System-Array,System-Array,System-Collections-IComparer- 'KeepCoding.ArrayHelper.Sort(System.Array,System.Array,System.Collections.IComparer)')
  - [Sort(keys,items)](#M-KeepCoding-ArrayHelper-Sort-System-Array,System-Array- 'KeepCoding.ArrayHelper.Sort(System.Array,System.Array)')
  - [Sort(array)](#M-KeepCoding-ArrayHelper-Sort-System-Array- 'KeepCoding.ArrayHelper.Sort(System.Array)')
  - [Sort\`\`1(array)](#M-KeepCoding-ArrayHelper-Sort``1-``0[]- 'KeepCoding.ArrayHelper.Sort``1(``0[])')
  - [Sort\`\`1(array,comparer)](#M-KeepCoding-ArrayHelper-Sort``1-``0[],System-Collections-Generic-IComparer{``0}- 'KeepCoding.ArrayHelper.Sort``1(``0[],System.Collections.Generic.IComparer{``0})')
  - [Sort\`\`1(array,comparison)](#M-KeepCoding-ArrayHelper-Sort``1-``0[],System-Comparison{``0}- 'KeepCoding.ArrayHelper.Sort``1(``0[],System.Comparison{``0})')
  - [Sort\`\`1(array,index,length)](#M-KeepCoding-ArrayHelper-Sort``1-``0[],System-Int32,System-Int32- 'KeepCoding.ArrayHelper.Sort``1(``0[],System.Int32,System.Int32)')
  - [Sort\`\`1(array,index,length,comparer)](#M-KeepCoding-ArrayHelper-Sort``1-``0[],System-Int32,System-Int32,System-Collections-Generic-IComparer{``0}- 'KeepCoding.ArrayHelper.Sort``1(``0[],System.Int32,System.Int32,System.Collections.Generic.IComparer{``0})')
  - [Sort\`\`2(keys,items)](#M-KeepCoding-ArrayHelper-Sort``2-``0[],``1[]- 'KeepCoding.ArrayHelper.Sort``2(``0[],``1[])')
  - [Sort\`\`2(keys,items,comparer)](#M-KeepCoding-ArrayHelper-Sort``2-``0[],``1[],System-Collections-Generic-IComparer{``0}- 'KeepCoding.ArrayHelper.Sort``2(``0[],``1[],System.Collections.Generic.IComparer{``0})')
  - [Sort\`\`2(keys,items,index,length)](#M-KeepCoding-ArrayHelper-Sort``2-``0[],``1[],System-Int32,System-Int32- 'KeepCoding.ArrayHelper.Sort``2(``0[],``1[],System.Int32,System.Int32)')
  - [Sort\`\`2(keys,items,index,length,comparer)](#M-KeepCoding-ArrayHelper-Sort``2-``0[],``1[],System-Int32,System-Int32,System-Collections-Generic-IComparer{``0}- 'KeepCoding.ArrayHelper.Sort``2(``0[],``1[],System.Int32,System.Int32,System.Collections.Generic.IComparer{``0})')
  - [TrueForAll\`\`1(array,match)](#M-KeepCoding-ArrayHelper-TrueForAll``1-``0[],System-Predicate{``0}- 'KeepCoding.ArrayHelper.TrueForAll``1(``0[],System.Predicate{``0})')
- [AudioScript](#T-KeepCoding-AudioScript 'KeepCoding.AudioScript')
  - [_audioClips](#F-KeepCoding-AudioScript-_audioClips 'KeepCoding.AudioScript._audioClips')
  - [_audioSource](#F-KeepCoding-AudioScript-_audioSource 'KeepCoding.AudioScript._audioSource')
  - [_isSFX](#F-KeepCoding-AudioScript-_isSFX 'KeepCoding.AudioScript._isSFX')
  - [AudioClips](#P-KeepCoding-AudioScript-AudioClips 'KeepCoding.AudioScript.AudioClips')
  - [AudioSource](#P-KeepCoding-AudioScript-AudioSource 'KeepCoding.AudioScript.AudioSource')
  - [Game](#P-KeepCoding-AudioScript-Game 'KeepCoding.AudioScript.Game')
  - [IsMuted](#P-KeepCoding-AudioScript-IsMuted 'KeepCoding.AudioScript.IsMuted')
  - [IsPlaying](#P-KeepCoding-AudioScript-IsPlaying 'KeepCoding.AudioScript.IsPlaying')
  - [Relative](#P-KeepCoding-AudioScript-Relative 'KeepCoding.AudioScript.Relative')
  - [Volume](#P-KeepCoding-AudioScript-Volume 'KeepCoding.AudioScript.Volume')
  - [Fade(volume,time)](#M-KeepCoding-AudioScript-Fade-System-Single,System-Single- 'KeepCoding.AudioScript.Fade(System.Single,System.Single)')
  - [Pause()](#M-KeepCoding-AudioScript-Pause 'KeepCoding.AudioScript.Pause')
  - [Play(clip,volume,loop,priority,delay,time,pitch)](#M-KeepCoding-AudioScript-Play-UnityEngine-AudioClip,System-Boolean,System-Byte,System-Single,System-Single,System-Single,System-Single- 'KeepCoding.AudioScript.Play(UnityEngine.AudioClip,System.Boolean,System.Byte,System.Single,System.Single,System.Single,System.Single)')
  - [Play(name,volume,loop,priority,delay,time,pitch)](#M-KeepCoding-AudioScript-Play-System-String,System-Boolean,System-Byte,System-Single,System-Single,System-Single,System-Single- 'KeepCoding.AudioScript.Play(System.String,System.Boolean,System.Byte,System.Single,System.Single,System.Single,System.Single)')
  - [PlayStackable(clip,volume,loop,priority,delay,time,pitch)](#M-KeepCoding-AudioScript-PlayStackable-UnityEngine-AudioClip,System-Boolean,System-Byte,System-Single,System-Single,System-Single,System-Single- 'KeepCoding.AudioScript.PlayStackable(UnityEngine.AudioClip,System.Boolean,System.Byte,System.Single,System.Single,System.Single,System.Single)')
  - [PlayStackable(name,volume,loop,priority,delay,time,pitch)](#M-KeepCoding-AudioScript-PlayStackable-System-String,System-Boolean,System-Byte,System-Single,System-Single,System-Single,System-Single- 'KeepCoding.AudioScript.PlayStackable(System.String,System.Boolean,System.Byte,System.Single,System.Single,System.Single,System.Single)')
  - [Stop()](#M-KeepCoding-AudioScript-Stop 'KeepCoding.AudioScript.Stop')
  - [Unpause()](#M-KeepCoding-AudioScript-Unpause 'KeepCoding.AudioScript.Unpause')
  - [op_Explicit(dynamicAudio)](#M-KeepCoding-AudioScript-op_Explicit-KeepCoding-AudioScript-~UnityEngine-AudioSource 'KeepCoding.AudioScript.op_Explicit(KeepCoding.AudioScript)~UnityEngine.AudioSource')
- [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger')
  - [#ctor(value)](#M-KeepCoding-BigInteger-#ctor-System-Object- 'KeepCoding.BigInteger.#ctor(System.Object)')
  - [#ctor()](#M-KeepCoding-BigInteger-#ctor 'KeepCoding.BigInteger.#ctor')
  - [GetLowerBound](#P-KeepCoding-BigInteger-GetLowerBound 'KeepCoding.BigInteger.GetLowerBound')
  - [GetUpperBound](#P-KeepCoding-BigInteger-GetUpperBound 'KeepCoding.BigInteger.GetUpperBound')
  - [IsNegative](#P-KeepCoding-BigInteger-IsNegative 'KeepCoding.BigInteger.IsNegative')
  - [Item](#P-KeepCoding-BigInteger-Item-System-Int32,System-Boolean- 'KeepCoding.BigInteger.Item(System.Int32,System.Boolean)')
  - [Length](#P-KeepCoding-BigInteger-Length 'KeepCoding.BigInteger.Length')
  - [One](#P-KeepCoding-BigInteger-One 'KeepCoding.BigInteger.One')
  - [Value](#P-KeepCoding-BigInteger-Value 'KeepCoding.BigInteger.Value')
  - [Zero](#P-KeepCoding-BigInteger-Zero 'KeepCoding.BigInteger.Zero')
  - [Clone()](#M-KeepCoding-BigInteger-Clone 'KeepCoding.BigInteger.Clone')
  - [Clone(bigInteger)](#M-KeepCoding-BigInteger-Clone-KeepCoding-BigInteger- 'KeepCoding.BigInteger.Clone(KeepCoding.BigInteger)')
  - [Equals(obj)](#M-KeepCoding-BigInteger-Equals-System-Object- 'KeepCoding.BigInteger.Equals(System.Object)')
  - [Equals(other)](#M-KeepCoding-BigInteger-Equals-KeepCoding-BigInteger- 'KeepCoding.BigInteger.Equals(KeepCoding.BigInteger)')
  - [GetEnumerator()](#M-KeepCoding-BigInteger-GetEnumerator 'KeepCoding.BigInteger.GetEnumerator')
  - [GetHashCode()](#M-KeepCoding-BigInteger-GetHashCode 'KeepCoding.BigInteger.GetHashCode')
  - [IsBetween(min,max)](#M-KeepCoding-BigInteger-IsBetween-KeepCoding-BigInteger,KeepCoding-BigInteger- 'KeepCoding.BigInteger.IsBetween(KeepCoding.BigInteger,KeepCoding.BigInteger)')
  - [IsBetween\`\`1(min,max)](#M-KeepCoding-BigInteger-IsBetween``1-``0,``0- 'KeepCoding.BigInteger.IsBetween``1(``0,``0)')
  - [Modulo(bigInteger)](#M-KeepCoding-BigInteger-Modulo-KeepCoding-BigInteger- 'KeepCoding.BigInteger.Modulo(KeepCoding.BigInteger)')
  - [Modulo\`\`1(obj)](#M-KeepCoding-BigInteger-Modulo``1-``0- 'KeepCoding.BigInteger.Modulo``1(``0)')
  - [ToNumber()](#M-KeepCoding-BigInteger-ToNumber 'KeepCoding.BigInteger.ToNumber')
  - [ToString()](#M-KeepCoding-BigInteger-ToString 'KeepCoding.BigInteger.ToString')
  - [op_Addition(bigIntegerA,bigIntegerB)](#M-KeepCoding-BigInteger-op_Addition-KeepCoding-BigInteger,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Addition(KeepCoding.BigInteger,KeepCoding.BigInteger)')
  - [op_Addition(bigInteger,value)](#M-KeepCoding-BigInteger-op_Addition-KeepCoding-BigInteger,System-Object- 'KeepCoding.BigInteger.op_Addition(KeepCoding.BigInteger,System.Object)')
  - [op_Addition(value,bigInteger)](#M-KeepCoding-BigInteger-op_Addition-System-Object,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Addition(System.Object,KeepCoding.BigInteger)')
  - [op_Decrement(bigInteger)](#M-KeepCoding-BigInteger-op_Decrement-KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Decrement(KeepCoding.BigInteger)')
  - [op_Division(bigIntegerA,bigIntegerB)](#M-KeepCoding-BigInteger-op_Division-KeepCoding-BigInteger,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Division(KeepCoding.BigInteger,KeepCoding.BigInteger)')
  - [op_Division(bigInteger,value)](#M-KeepCoding-BigInteger-op_Division-KeepCoding-BigInteger,System-Object- 'KeepCoding.BigInteger.op_Division(KeepCoding.BigInteger,System.Object)')
  - [op_Division(value,bigInteger)](#M-KeepCoding-BigInteger-op_Division-System-Object,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Division(System.Object,KeepCoding.BigInteger)')
  - [op_Equality(bigIntegerA,bigIntegerB)](#M-KeepCoding-BigInteger-op_Equality-KeepCoding-BigInteger,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Equality(KeepCoding.BigInteger,KeepCoding.BigInteger)')
  - [op_Equality(bigInteger,value)](#M-KeepCoding-BigInteger-op_Equality-KeepCoding-BigInteger,System-Object- 'KeepCoding.BigInteger.op_Equality(KeepCoding.BigInteger,System.Object)')
  - [op_Equality(value,bigInteger)](#M-KeepCoding-BigInteger-op_Equality-System-Object,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Equality(System.Object,KeepCoding.BigInteger)')
  - [op_Explicit(bigInteger)](#M-KeepCoding-BigInteger-op_Explicit-KeepCoding-BigInteger-~KeepCoding-Number 'KeepCoding.BigInteger.op_Explicit(KeepCoding.BigInteger)~KeepCoding.Number')
  - [op_GreaterThan(bigIntegerA,bigIntegerB)](#M-KeepCoding-BigInteger-op_GreaterThan-KeepCoding-BigInteger,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_GreaterThan(KeepCoding.BigInteger,KeepCoding.BigInteger)')
  - [op_GreaterThan(bigInteger,value)](#M-KeepCoding-BigInteger-op_GreaterThan-KeepCoding-BigInteger,System-Object- 'KeepCoding.BigInteger.op_GreaterThan(KeepCoding.BigInteger,System.Object)')
  - [op_GreaterThan(value,bigInteger)](#M-KeepCoding-BigInteger-op_GreaterThan-System-Object,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_GreaterThan(System.Object,KeepCoding.BigInteger)')
  - [op_GreaterThanOrEqual(bigIntegerA,bigIntegerB)](#M-KeepCoding-BigInteger-op_GreaterThanOrEqual-KeepCoding-BigInteger,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_GreaterThanOrEqual(KeepCoding.BigInteger,KeepCoding.BigInteger)')
  - [op_GreaterThanOrEqual(bigInteger,value)](#M-KeepCoding-BigInteger-op_GreaterThanOrEqual-KeepCoding-BigInteger,System-Object- 'KeepCoding.BigInteger.op_GreaterThanOrEqual(KeepCoding.BigInteger,System.Object)')
  - [op_GreaterThanOrEqual(value,bigInteger)](#M-KeepCoding-BigInteger-op_GreaterThanOrEqual-System-Object,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_GreaterThanOrEqual(System.Object,KeepCoding.BigInteger)')
  - [op_Implicit(value)](#M-KeepCoding-BigInteger-op_Implicit-KeepCoding-Number-~KeepCoding-BigInteger 'KeepCoding.BigInteger.op_Implicit(KeepCoding.Number)~KeepCoding.BigInteger')
  - [op_Increment(bigInteger)](#M-KeepCoding-BigInteger-op_Increment-KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Increment(KeepCoding.BigInteger)')
  - [op_Inequality(bigIntegerA,bigIntegerB)](#M-KeepCoding-BigInteger-op_Inequality-KeepCoding-BigInteger,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Inequality(KeepCoding.BigInteger,KeepCoding.BigInteger)')
  - [op_Inequality(bigInteger,value)](#M-KeepCoding-BigInteger-op_Inequality-KeepCoding-BigInteger,System-Object- 'KeepCoding.BigInteger.op_Inequality(KeepCoding.BigInteger,System.Object)')
  - [op_Inequality(value,bigInteger)](#M-KeepCoding-BigInteger-op_Inequality-System-Object,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Inequality(System.Object,KeepCoding.BigInteger)')
  - [op_LessThan(bigIntegerA,bigIntegerB)](#M-KeepCoding-BigInteger-op_LessThan-KeepCoding-BigInteger,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_LessThan(KeepCoding.BigInteger,KeepCoding.BigInteger)')
  - [op_LessThan(bigInteger,value)](#M-KeepCoding-BigInteger-op_LessThan-KeepCoding-BigInteger,System-Object- 'KeepCoding.BigInteger.op_LessThan(KeepCoding.BigInteger,System.Object)')
  - [op_LessThan(value,bigInteger)](#M-KeepCoding-BigInteger-op_LessThan-System-Object,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_LessThan(System.Object,KeepCoding.BigInteger)')
  - [op_LessThanOrEqual(bigIntegerA,bigIntegerB)](#M-KeepCoding-BigInteger-op_LessThanOrEqual-KeepCoding-BigInteger,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_LessThanOrEqual(KeepCoding.BigInteger,KeepCoding.BigInteger)')
  - [op_LessThanOrEqual(bigInteger,value)](#M-KeepCoding-BigInteger-op_LessThanOrEqual-KeepCoding-BigInteger,System-Object- 'KeepCoding.BigInteger.op_LessThanOrEqual(KeepCoding.BigInteger,System.Object)')
  - [op_LessThanOrEqual(value,bigInteger)](#M-KeepCoding-BigInteger-op_LessThanOrEqual-System-Object,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_LessThanOrEqual(System.Object,KeepCoding.BigInteger)')
  - [op_Modulus(bigIntegerA,bigIntegerB)](#M-KeepCoding-BigInteger-op_Modulus-KeepCoding-BigInteger,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Modulus(KeepCoding.BigInteger,KeepCoding.BigInteger)')
  - [op_Modulus(bigInteger,value)](#M-KeepCoding-BigInteger-op_Modulus-KeepCoding-BigInteger,System-Object- 'KeepCoding.BigInteger.op_Modulus(KeepCoding.BigInteger,System.Object)')
  - [op_Modulus(value,bigInteger)](#M-KeepCoding-BigInteger-op_Modulus-System-Object,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Modulus(System.Object,KeepCoding.BigInteger)')
  - [op_Multiply(bigIntegerA,bigIntegerB)](#M-KeepCoding-BigInteger-op_Multiply-KeepCoding-BigInteger,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Multiply(KeepCoding.BigInteger,KeepCoding.BigInteger)')
  - [op_Multiply(bigInteger,value)](#M-KeepCoding-BigInteger-op_Multiply-KeepCoding-BigInteger,System-Object- 'KeepCoding.BigInteger.op_Multiply(KeepCoding.BigInteger,System.Object)')
  - [op_Multiply(value,bigInteger)](#M-KeepCoding-BigInteger-op_Multiply-System-Object,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Multiply(System.Object,KeepCoding.BigInteger)')
  - [op_Subtraction(bigIntegerA,bigIntegerB)](#M-KeepCoding-BigInteger-op_Subtraction-KeepCoding-BigInteger,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Subtraction(KeepCoding.BigInteger,KeepCoding.BigInteger)')
  - [op_Subtraction(bigInteger,value)](#M-KeepCoding-BigInteger-op_Subtraction-KeepCoding-BigInteger,System-Object- 'KeepCoding.BigInteger.op_Subtraction(KeepCoding.BigInteger,System.Object)')
  - [op_Subtraction(value,bigInteger)](#M-KeepCoding-BigInteger-op_Subtraction-System-Object,KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_Subtraction(System.Object,KeepCoding.BigInteger)')
  - [op_UnaryNegation(bigInteger)](#M-KeepCoding-BigInteger-op_UnaryNegation-KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_UnaryNegation(KeepCoding.BigInteger)')
  - [op_UnaryPlus(bigInteger)](#M-KeepCoding-BigInteger-op_UnaryPlus-KeepCoding-BigInteger- 'KeepCoding.BigInteger.op_UnaryPlus(KeepCoding.BigInteger)')
- [CacheableBehaviour](#T-KeepCoding-CacheableBehaviour 'KeepCoding.CacheableBehaviour')
  - [Cache\`\`1(func,allowNull)](#M-KeepCoding-CacheableBehaviour-Cache``1-System-Func{``0[]},System-Boolean- 'KeepCoding.CacheableBehaviour.Cache``1(System.Func{``0[]},System.Boolean)')
  - [Cache\`\`1(func,parameter,allowNull)](#M-KeepCoding-CacheableBehaviour-Cache``1-System-Func{System-Boolean,``0[]},System-Boolean,System-Boolean- 'KeepCoding.CacheableBehaviour.Cache``1(System.Func{System.Boolean,``0[]},System.Boolean,System.Boolean)')
  - [FindAll\`\`1(allowNull)](#M-KeepCoding-CacheableBehaviour-FindAll``1-System-Boolean- 'KeepCoding.CacheableBehaviour.FindAll``1(System.Boolean)')
  - [Find\`\`1(allowNull)](#M-KeepCoding-CacheableBehaviour-Find``1-System-Boolean- 'KeepCoding.CacheableBehaviour.Find``1(System.Boolean)')
  - [GetChild\`\`1(includeInactive,allowNull)](#M-KeepCoding-CacheableBehaviour-GetChild``1-System-Boolean,System-Boolean- 'KeepCoding.CacheableBehaviour.GetChild``1(System.Boolean,System.Boolean)')
  - [GetChildren\`\`1(includeInactive,allowNull)](#M-KeepCoding-CacheableBehaviour-GetChildren``1-System-Boolean,System-Boolean- 'KeepCoding.CacheableBehaviour.GetChildren``1(System.Boolean,System.Boolean)')
  - [GetParent\`\`1(includeInactive,allowNull)](#M-KeepCoding-CacheableBehaviour-GetParent``1-System-Boolean,System-Boolean- 'KeepCoding.CacheableBehaviour.GetParent``1(System.Boolean,System.Boolean)')
  - [GetParents\`\`1(includeInactive,allowNull)](#M-KeepCoding-CacheableBehaviour-GetParents``1-System-Boolean,System-Boolean- 'KeepCoding.CacheableBehaviour.GetParents``1(System.Boolean,System.Boolean)')
  - [Get\`\`1(allowNull)](#M-KeepCoding-CacheableBehaviour-Get``1-System-Boolean- 'KeepCoding.CacheableBehaviour.Get``1(System.Boolean)')
  - [Gets\`\`1(allowNull)](#M-KeepCoding-CacheableBehaviour-Gets``1-System-Boolean- 'KeepCoding.CacheableBehaviour.Gets``1(System.Boolean)')
- [ComponentPool](#T-KeepCoding-ComponentPool 'KeepCoding.ComponentPool')
  - [#ctor(count,allowedSources,specialComponentType,modTypes,componentTypes)](#M-KeepCoding-ComponentPool-#ctor-System-Int32,KeepCoding-ComponentPool-ComponentSource,KeepCoding-ComponentPool-SpecialComponentTypeEnum,System-Collections-Generic-List{System-String},System-Collections-Generic-List{KeepCoding-ComponentPool-ComponentTypeEnum}- 'KeepCoding.ComponentPool.#ctor(System.Int32,KeepCoding.ComponentPool.ComponentSource,KeepCoding.ComponentPool.SpecialComponentTypeEnum,System.Collections.Generic.List{System.String},System.Collections.Generic.List{KeepCoding.ComponentPool.ComponentTypeEnum})')
  - [AllowedSources](#P-KeepCoding-ComponentPool-AllowedSources 'KeepCoding.ComponentPool.AllowedSources')
  - [ComponentTypes](#P-KeepCoding-ComponentPool-ComponentTypes 'KeepCoding.ComponentPool.ComponentTypes')
  - [Count](#P-KeepCoding-ComponentPool-Count 'KeepCoding.ComponentPool.Count')
  - [ModTypes](#P-KeepCoding-ComponentPool-ModTypes 'KeepCoding.ComponentPool.ModTypes')
  - [SpecialComponentType](#P-KeepCoding-ComponentPool-SpecialComponentType 'KeepCoding.ComponentPool.SpecialComponentType')
  - [ToString()](#M-KeepCoding-ComponentPool-ToString 'KeepCoding.ComponentPool.ToString')
- [ComponentSource](#T-KeepCoding-ComponentPool-ComponentSource 'KeepCoding.ComponentPool.ComponentSource')
  - [Base](#F-KeepCoding-ComponentPool-ComponentSource-Base 'KeepCoding.ComponentPool.ComponentSource.Base')
  - [Mods](#F-KeepCoding-ComponentPool-ComponentSource-Mods 'KeepCoding.ComponentPool.ComponentSource.Mods')
- [ComponentTypeEnum](#T-KeepCoding-ComponentPool-ComponentTypeEnum 'KeepCoding.ComponentPool.ComponentTypeEnum')
  - [BigButton](#F-KeepCoding-ComponentPool-ComponentTypeEnum-BigButton 'KeepCoding.ComponentPool.ComponentTypeEnum.BigButton')
  - [Empty](#F-KeepCoding-ComponentPool-ComponentTypeEnum-Empty 'KeepCoding.ComponentPool.ComponentTypeEnum.Empty')
  - [Keypad](#F-KeepCoding-ComponentPool-ComponentTypeEnum-Keypad 'KeepCoding.ComponentPool.ComponentTypeEnum.Keypad')
  - [Maze](#F-KeepCoding-ComponentPool-ComponentTypeEnum-Maze 'KeepCoding.ComponentPool.ComponentTypeEnum.Maze')
  - [Memory](#F-KeepCoding-ComponentPool-ComponentTypeEnum-Memory 'KeepCoding.ComponentPool.ComponentTypeEnum.Memory')
  - [Mod](#F-KeepCoding-ComponentPool-ComponentTypeEnum-Mod 'KeepCoding.ComponentPool.ComponentTypeEnum.Mod')
  - [Morse](#F-KeepCoding-ComponentPool-ComponentTypeEnum-Morse 'KeepCoding.ComponentPool.ComponentTypeEnum.Morse')
  - [NeedyCapacitor](#F-KeepCoding-ComponentPool-ComponentTypeEnum-NeedyCapacitor 'KeepCoding.ComponentPool.ComponentTypeEnum.NeedyCapacitor')
  - [NeedyKnob](#F-KeepCoding-ComponentPool-ComponentTypeEnum-NeedyKnob 'KeepCoding.ComponentPool.ComponentTypeEnum.NeedyKnob')
  - [NeedyMod](#F-KeepCoding-ComponentPool-ComponentTypeEnum-NeedyMod 'KeepCoding.ComponentPool.ComponentTypeEnum.NeedyMod')
  - [NeedyVentGas](#F-KeepCoding-ComponentPool-ComponentTypeEnum-NeedyVentGas 'KeepCoding.ComponentPool.ComponentTypeEnum.NeedyVentGas')
  - [Password](#F-KeepCoding-ComponentPool-ComponentTypeEnum-Password 'KeepCoding.ComponentPool.ComponentTypeEnum.Password')
  - [Simon](#F-KeepCoding-ComponentPool-ComponentTypeEnum-Simon 'KeepCoding.ComponentPool.ComponentTypeEnum.Simon')
  - [Timer](#F-KeepCoding-ComponentPool-ComponentTypeEnum-Timer 'KeepCoding.ComponentPool.ComponentTypeEnum.Timer')
  - [Venn](#F-KeepCoding-ComponentPool-ComponentTypeEnum-Venn 'KeepCoding.ComponentPool.ComponentTypeEnum.Venn')
  - [WhosOnFirst](#F-KeepCoding-ComponentPool-ComponentTypeEnum-WhosOnFirst 'KeepCoding.ComponentPool.ComponentTypeEnum.WhosOnFirst')
  - [WireSequence](#F-KeepCoding-ComponentPool-ComponentTypeEnum-WireSequence 'KeepCoding.ComponentPool.ComponentTypeEnum.WireSequence')
  - [Wires](#F-KeepCoding-ComponentPool-ComponentTypeEnum-Wires 'KeepCoding.ComponentPool.ComponentTypeEnum.Wires')
- [ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException')
  - [#ctor()](#M-KeepCoding-ConstructorArgumentException-#ctor 'KeepCoding.ConstructorArgumentException.#ctor')
  - [#ctor(message)](#M-KeepCoding-ConstructorArgumentException-#ctor-System-String- 'KeepCoding.ConstructorArgumentException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-KeepCoding-ConstructorArgumentException-#ctor-System-String,System-Exception- 'KeepCoding.ConstructorArgumentException.#ctor(System.String,System.Exception)')
- [ControlType](#T-KeepCoding-Game-ControlType 'KeepCoding.Game.ControlType')
  - [Gamepad](#F-KeepCoding-Game-ControlType-Gamepad 'KeepCoding.Game.ControlType.Gamepad')
  - [Gaze](#F-KeepCoding-Game-ControlType-Gaze 'KeepCoding.Game.ControlType.Gaze')
  - [Motion](#F-KeepCoding-Game-ControlType-Motion 'KeepCoding.Game.ControlType.Motion')
  - [Mouse](#F-KeepCoding-Game-ControlType-Mouse 'KeepCoding.Game.ControlType.Mouse')
  - [ThreeDOF](#F-KeepCoding-Game-ControlType-ThreeDOF 'KeepCoding.Game.ControlType.ThreeDOF')
  - [Touch](#F-KeepCoding-Game-ControlType-Touch 'KeepCoding.Game.ControlType.Touch')
- [EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException')
  - [#ctor()](#M-KeepCoding-EmptyIteratorException-#ctor 'KeepCoding.EmptyIteratorException.#ctor')
  - [#ctor(message)](#M-KeepCoding-EmptyIteratorException-#ctor-System-String- 'KeepCoding.EmptyIteratorException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-KeepCoding-EmptyIteratorException-#ctor-System-String,System-Exception- 'KeepCoding.EmptyIteratorException.#ctor(System.String,System.Exception)')
- [EventHelper](#T-KeepCoding-EventHelper 'KeepCoding.EventHelper')
  - [Assign(bombInfo,onBombExploded,onBombSolved)](#M-KeepCoding-EventHelper-Assign-KMBombInfo,System-Action,System-Action- 'KeepCoding.EventHelper.Assign(KMBombInfo,System.Action,System.Action)')
  - [Assign(bombModule,onActivate,onPass,onStrike)](#M-KeepCoding-EventHelper-Assign-KMBombModule,System-Action,System-Action,System-Action- 'KeepCoding.EventHelper.Assign(KMBombModule,System.Action,System.Action,System.Action)')
  - [Assign(gameInfo,onStateChange,onAlarmClockChange,onLightsChange)](#M-KeepCoding-EventHelper-Assign-KMGameInfo,System-Action{KMGameInfo-State},System-Action{System-Boolean},System-Action{System-Boolean}- 'KeepCoding.EventHelper.Assign(KMGameInfo,System.Action{KMGameInfo.State},System.Action{System.Boolean},System.Action{System.Boolean})')
  - [Assign(needyModule,onActivate,onNeedyActivation,onNeedyDeactivation,onPass,onStrike,onTimerExpired)](#M-KeepCoding-EventHelper-Assign-KMNeedyModule,System-Action,System-Action,System-Action,System-Action,System-Action,System-Action- 'KeepCoding.EventHelper.Assign(KMNeedyModule,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action)')
  - [Assign(selectable,overrideReturn,onCancel,onDefocus,onDeselect,onFocus,onHighlight,onHighlightEnded,onInteract,onInteractEnded,onInteractionPunch,onLeft,onRight,onSelect,onUpdateChildren)](#M-KeepCoding-EventHelper-Assign-KMSelectable,System-Nullable{System-Boolean},System-Action,System-Action,System-Action,System-Action,System-Action,System-Action,System-Action,System-Action,System-Action{System-Single},System-Action,System-Action,System-Action,System-Action{KMSelectable}- 'KeepCoding.EventHelper.Assign(KMSelectable,System.Nullable{System.Boolean},System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action,System.Action{System.Single},System.Action,System.Action,System.Action,System.Action{KMSelectable})')
  - [Assign(selectable,overrideReturn,onCancel,onDefocus,onDeselect,onFocus,onHighlight,onHighlightEnded,onInteract,onInteractEnded,onInteractionPunch,onLeft,onRight,onSelect,onUpdateChildren)](#M-KeepCoding-EventHelper-Assign-KMSelectable[],System-Nullable{System-Boolean},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32,System-Single},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32,KMSelectable}- 'KeepCoding.EventHelper.Assign(KMSelectable[],System.Nullable{System.Boolean},System.Action{System.Int32},System.Action{System.Int32},System.Action{System.Int32},System.Action{System.Int32},System.Action{System.Int32},System.Action{System.Int32},System.Action{System.Int32},System.Action{System.Int32},System.Action{System.Int32,System.Single},System.Action{System.Int32},System.Action{System.Int32},System.Action{System.Int32},System.Action{System.Int32,KMSelectable})')
  - [Assign(selectable,overrideReturn,onCancel,onDefocus,onDeselect,onFocus,onHighlight,onHighlightEnded,onInteract,onInteractEnded,onInteractionPunch,onLeft,onRight,onSelect,onUpdateChildren)](#M-KeepCoding-EventHelper-Assign-KMSelectable[],System-Nullable{System-Boolean},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable,System-Single},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable,KMSelectable}- 'KeepCoding.EventHelper.Assign(KMSelectable[],System.Nullable{System.Boolean},System.Action{KMSelectable},System.Action{KMSelectable},System.Action{KMSelectable},System.Action{KMSelectable},System.Action{KMSelectable},System.Action{KMSelectable},System.Action{KMSelectable},System.Action{KMSelectable},System.Action{KMSelectable,System.Single},System.Action{KMSelectable},System.Action{KMSelectable},System.Action{KMSelectable},System.Action{KMSelectable,KMSelectable})')
  - [Cast\`\`1(dele)](#M-KeepCoding-EventHelper-Cast``1-System-Delegate- 'KeepCoding.EventHelper.Cast``1(System.Delegate)')
  - [Combine(self,others)](#M-KeepCoding-EventHelper-Combine-System-Action,System-Action[]- 'KeepCoding.EventHelper.Combine(System.Action,System.Action[])')
  - [Combine\`\`1(self,others)](#M-KeepCoding-EventHelper-Combine``1-System-Action{``0},System-Action{``0}[]- 'KeepCoding.EventHelper.Combine``1(System.Action{``0},System.Action{``0}[])')
  - [Combine\`\`1(self,others)](#M-KeepCoding-EventHelper-Combine``1-System-Func{``0},System-Func{``0}[]- 'KeepCoding.EventHelper.Combine``1(System.Func{``0},System.Func{``0}[])')
  - [Combine\`\`2(self,others)](#M-KeepCoding-EventHelper-Combine``2-System-Action{``0,``1},System-Action{``0,``1}[]- 'KeepCoding.EventHelper.Combine``2(System.Action{``0,``1},System.Action{``0,``1}[])')
  - [Combine\`\`2(self,others)](#M-KeepCoding-EventHelper-Combine``2-System-Func{``0,``1},System-Func{``0,``1}[]- 'KeepCoding.EventHelper.Combine``2(System.Func{``0,``1},System.Func{``0,``1}[])')
  - [Combine\`\`3(self,others)](#M-KeepCoding-EventHelper-Combine``3-System-Action{``0,``1,``2},System-Action{``0,``1,``2}[]- 'KeepCoding.EventHelper.Combine``3(System.Action{``0,``1,``2},System.Action{``0,``1,``2}[])')
  - [Combine\`\`3(self,others)](#M-KeepCoding-EventHelper-Combine``3-System-Func{``0,``1,``2},System-Func{``0,``1,``2}[]- 'KeepCoding.EventHelper.Combine``3(System.Func{``0,``1,``2},System.Func{``0,``1,``2}[])')
  - [Combine\`\`4(self,others)](#M-KeepCoding-EventHelper-Combine``4-System-Action{``0,``1,``2,``3},System-Action{``0,``1,``2,``3}[]- 'KeepCoding.EventHelper.Combine``4(System.Action{``0,``1,``2,``3},System.Action{``0,``1,``2,``3}[])')
  - [Combine\`\`4(self,others)](#M-KeepCoding-EventHelper-Combine``4-System-Func{``0,``1,``2,``3},System-Func{``0,``1,``2,``3}[]- 'KeepCoding.EventHelper.Combine``4(System.Func{``0,``1,``2,``3},System.Func{``0,``1,``2,``3}[])')
  - [Combine\`\`5(self,others)](#M-KeepCoding-EventHelper-Combine``5-System-Func{``0,``1,``2,``3,``4},System-Func{``0,``1,``2,``3,``4}[]- 'KeepCoding.EventHelper.Combine``5(System.Func{``0,``1,``2,``3,``4},System.Func{``0,``1,``2,``3,``4}[])')
  - [CreateDelegate\`\`1(dele)](#M-KeepCoding-EventHelper-CreateDelegate``1-System-Delegate- 'KeepCoding.EventHelper.CreateDelegate``1(System.Delegate)')
  - [Set\`\`1(dele,mutator)](#M-KeepCoding-EventHelper-Set``1-System-Delegate,``0@- 'KeepCoding.EventHelper.Set``1(System.Delegate,``0@)')
  - [StopSound(audioRefs)](#M-KeepCoding-EventHelper-StopSound-KMAudio-KMAudioRef[]- 'KeepCoding.EventHelper.StopSound(KMAudio.KMAudioRef[])')
  - [StopSound(sounds)](#M-KeepCoding-EventHelper-StopSound-KeepCoding-Sound[]- 'KeepCoding.EventHelper.StopSound(KeepCoding.Sound[])')
- [Game](#T-KeepCoding-Game 'KeepCoding.Game')
  - [AddStrikes](#P-KeepCoding-Game-AddStrikes 'KeepCoding.Game.AddStrikes')
  - [Bomb](#P-KeepCoding-Game-Bomb 'KeepCoding.Game.Bomb')
  - [SetStrikes](#P-KeepCoding-Game-SetStrikes 'KeepCoding.Game.SetStrikes')
  - [Timer](#P-KeepCoding-Game-Timer 'KeepCoding.Game.Timer')
  - [Vanillas](#P-KeepCoding-Game-Vanillas 'KeepCoding.Game.Vanillas')
- [GeneratorSetting](#T-KeepCoding-GeneratorSetting 'KeepCoding.GeneratorSetting')
  - [#ctor(frontFaceOnly,optionalWidgetCount,numStrikes,timeBeforeNeedyActivation,timeLimit,componentPools)](#M-KeepCoding-GeneratorSetting-#ctor-System-Boolean,System-Int32,System-Int32,System-Int32,System-Single,System-Collections-Generic-List{KeepCoding-ComponentPool}- 'KeepCoding.GeneratorSetting.#ctor(System.Boolean,System.Int32,System.Int32,System.Int32,System.Single,System.Collections.Generic.List{KeepCoding.ComponentPool})')
  - [#ctor()](#M-KeepCoding-GeneratorSetting-#ctor 'KeepCoding.GeneratorSetting.#ctor')
  - [ComponentPools](#P-KeepCoding-GeneratorSetting-ComponentPools 'KeepCoding.GeneratorSetting.ComponentPools')
  - [FrontFaceOnly](#P-KeepCoding-GeneratorSetting-FrontFaceOnly 'KeepCoding.GeneratorSetting.FrontFaceOnly')
  - [NumStrikes](#P-KeepCoding-GeneratorSetting-NumStrikes 'KeepCoding.GeneratorSetting.NumStrikes')
  - [OptionalWidgetCount](#P-KeepCoding-GeneratorSetting-OptionalWidgetCount 'KeepCoding.GeneratorSetting.OptionalWidgetCount')
  - [TimeBeforeNeedyActivation](#P-KeepCoding-GeneratorSetting-TimeBeforeNeedyActivation 'KeepCoding.GeneratorSetting.TimeBeforeNeedyActivation')
  - [TimeLimit](#P-KeepCoding-GeneratorSetting-TimeLimit 'KeepCoding.GeneratorSetting.TimeLimit')
  - [GetComponentCount()](#M-KeepCoding-GeneratorSetting-GetComponentCount 'KeepCoding.GeneratorSetting.GetComponentCount')
  - [ToString()](#M-KeepCoding-GeneratorSetting-ToString 'KeepCoding.GeneratorSetting.ToString')
- [Helper](#T-KeepCoding-Helper 'KeepCoding.Helper')
  - [Alphanumeric](#F-KeepCoding-Helper-Alphanumeric 'KeepCoding.Helper.Alphanumeric')
  - [Binary](#F-KeepCoding-Helper-Binary 'KeepCoding.Helper.Binary')
  - [Decimal](#F-KeepCoding-Helper-Decimal 'KeepCoding.Helper.Decimal')
  - [Flags](#F-KeepCoding-Helper-Flags 'KeepCoding.Helper.Flags')
  - [Append\`\`1(source,item)](#M-KeepCoding-Helper-Append``1-System-Collections-Generic-IEnumerable{``0},``0- 'KeepCoding.Helper.Append``1(System.Collections.Generic.IEnumerable{``0},``0)')
  - [Append\`\`1(array,item)](#M-KeepCoding-Helper-Append``1-``0[],``0- 'KeepCoding.Helper.Append``1(``0[],``0)')
  - [Apply\`\`2(item,func)](#M-KeepCoding-Helper-Apply``2-``0,System-Func{``0,``1}- 'KeepCoding.Helper.Apply``2(``0,System.Func{``0,``1})')
  - [Apply\`\`2(items,func)](#M-KeepCoding-Helper-Apply``2-``0[],System-Func{``0,System-Int32,``1}- 'KeepCoding.Helper.Apply``2(``0[],System.Func{``0,System.Int32,``1})')
  - [AsEnumerable(source)](#M-KeepCoding-Helper-AsEnumerable-System-Collections-IEnumerator- 'KeepCoding.Helper.AsEnumerable(System.Collections.IEnumerator)')
  - [AsEnumerable\`\`1(source)](#M-KeepCoding-Helper-AsEnumerable``1-System-Collections-Generic-IEnumerator{``0}- 'KeepCoding.Helper.AsEnumerable``1(System.Collections.Generic.IEnumerator{``0})')
  - [Assert\`\`1(obj,message)](#M-KeepCoding-Helper-Assert``1-``0,System-String- 'KeepCoding.Helper.Assert``1(``0,System.String)')
  - [Base(value,fromBaseChars,toBaseChars)](#M-KeepCoding-Helper-Base-System-String,System-String,System-String- 'KeepCoding.Helper.Base(System.String,System.String,System.String)')
  - [Base(value,fromBaseNumber,toBaseNumber)](#M-KeepCoding-Helper-Base-System-String,System-Int32,System-Int32- 'KeepCoding.Helper.Base(System.String,System.Int32,System.Int32)')
  - [BaseToLong(value,baseNumber)](#M-KeepCoding-Helper-BaseToLong-System-String,System-Int32- 'KeepCoding.Helper.BaseToLong(System.String,System.Int32)')
  - [BaseToLong(value,baseChars)](#M-KeepCoding-Helper-BaseToLong-System-String,System-String- 'KeepCoding.Helper.BaseToLong(System.String,System.String)')
  - [Call\`\`1(item,action)](#M-KeepCoding-Helper-Call``1-``0,System-Action{``0}- 'KeepCoding.Helper.Call``1(``0,System.Action{``0})')
  - [Call\`\`1(item,logType)](#M-KeepCoding-Helper-Call``1-``0,UnityEngine-LogType- 'KeepCoding.Helper.Call``1(``0,UnityEngine.LogType)')
  - [Call\`\`1(source,action)](#M-KeepCoding-Helper-Call``1-``0[],System-Action{``0,System-Int32}- 'KeepCoding.Helper.Call``1(``0[],System.Action{``0,System.Int32})')
  - [DigitalRoot(number)](#M-KeepCoding-Helper-DigitalRoot-System-Int32- 'KeepCoding.Helper.DigitalRoot(System.Int32)')
  - [ElementAtWrap\`\`1(source,index)](#M-KeepCoding-Helper-ElementAtWrap``1-System-Collections-Generic-IEnumerable{``0},System-Int32- 'KeepCoding.Helper.ElementAtWrap``1(System.Collections.Generic.IEnumerable{``0},System.Int32)')
  - [Exclude\`\`1(source,indices)](#M-KeepCoding-Helper-Exclude``1-System-Collections-Generic-IEnumerable{``0},System-Int32[]- 'KeepCoding.Helper.Exclude``1(System.Collections.Generic.IEnumerable{``0},System.Int32[])')
  - [Find(directories,file)](#M-KeepCoding-Helper-Find-System-Collections-Generic-List{System-String},System-String- 'KeepCoding.Helper.Find(System.Collections.Generic.List{System.String},System.String)')
  - [FirstValue\`\`1(source,func)](#M-KeepCoding-Helper-FirstValue``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0}- 'KeepCoding.Helper.FirstValue``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``0})')
  - [Flatten(source,unwrap)](#M-KeepCoding-Helper-Flatten-System-Collections-IEnumerator,System-Predicate{System-Object}- 'KeepCoding.Helper.Flatten(System.Collections.IEnumerator,System.Predicate{System.Object})')
  - [Form(str,args)](#M-KeepCoding-Helper-Form-System-String,System-Object[]- 'KeepCoding.Helper.Form(System.String,System.Object[])')
  - [GetMethodInfo\`\`1(expression)](#M-KeepCoding-Helper-GetMethodInfo``1-System-Linq-Expressions-Expression{System-Action{``0}}- 'KeepCoding.Helper.GetMethodInfo``1(System.Linq.Expressions.Expression{System.Action{``0}})')
  - [GetNullException\`\`1(item)](#M-KeepCoding-Helper-GetNullException``1-``0- 'KeepCoding.Helper.GetNullException``1(``0)')
  - [GetUnsolvedModuleIDs(bombInfo)](#M-KeepCoding-Helper-GetUnsolvedModuleIDs-KMBombInfo- 'KeepCoding.Helper.GetUnsolvedModuleIDs(KMBombInfo)')
  - [GetUnsolvedModuleNames(bombInfo)](#M-KeepCoding-Helper-GetUnsolvedModuleNames-KMBombInfo- 'KeepCoding.Helper.GetUnsolvedModuleNames(KMBombInfo)')
  - [GetUpperBound(str)](#M-KeepCoding-Helper-GetUpperBound-System-String- 'KeepCoding.Helper.GetUpperBound(System.String)')
  - [GetUpperBound\`\`1(source)](#M-KeepCoding-Helper-GetUpperBound``1-System-Collections-Generic-IEnumerable{``0}- 'KeepCoding.Helper.GetUpperBound``1(System.Collections.Generic.IEnumerable{``0})')
  - [GetValues\`\`1()](#M-KeepCoding-Helper-GetValues``1 'KeepCoding.Helper.GetValues``1')
  - [GetValues\`\`1(_)](#M-KeepCoding-Helper-GetValues``1-``0- 'KeepCoding.Helper.GetValues``1(``0)')
  - [HasComponent\`\`1(obj,component)](#M-KeepCoding-Helper-HasComponent``1-UnityEngine-GameObject,``0@- 'KeepCoding.Helper.HasComponent``1(UnityEngine.GameObject,``0@)')
  - [Include\`\`1(source,indices)](#M-KeepCoding-Helper-Include``1-System-Collections-Generic-IEnumerable{``0},System-Int32[]- 'KeepCoding.Helper.Include``1(System.Collections.Generic.IEnumerable{``0},System.Int32[])')
  - [Indistinct\`\`1(source)](#M-KeepCoding-Helper-Indistinct``1-System-Collections-Generic-IEnumerable{``0}- 'KeepCoding.Helper.Indistinct``1(System.Collections.Generic.IEnumerable{``0})')
  - [InsertNewlines(condition,maxLineLength)](#M-KeepCoding-Helper-InsertNewlines-System-String,System-UInt16- 'KeepCoding.Helper.InsertNewlines(System.String,System.UInt16)')
  - [IsBetween(comparison,min,max)](#M-KeepCoding-Helper-IsBetween-System-Int32,System-Int32,System-Int32- 'KeepCoding.Helper.IsBetween(System.Int32,System.Int32,System.Int32)')
  - [IsBetween(comparison,min,max)](#M-KeepCoding-Helper-IsBetween-System-Single,System-Single,System-Single- 'KeepCoding.Helper.IsBetween(System.Single,System.Single,System.Single)')
  - [IsIndexNull\`\`1(source,index)](#M-KeepCoding-Helper-IsIndexNull``1-System-Collections-Generic-IEnumerable{``0},System-Int32- 'KeepCoding.Helper.IsIndexNull``1(System.Collections.Generic.IEnumerable{``0},System.Int32)')
  - [IsIterator\`\`1(item)](#M-KeepCoding-Helper-IsIterator``1-``0- 'KeepCoding.Helper.IsIterator``1(``0)')
  - [IsNullOrEmpty(str)](#M-KeepCoding-Helper-IsNullOrEmpty-System-String- 'KeepCoding.Helper.IsNullOrEmpty(System.String)')
  - [IsNullOrEmpty\`\`1(source)](#M-KeepCoding-Helper-IsNullOrEmpty``1-System-Collections-Generic-IEnumerable{``0}- 'KeepCoding.Helper.IsNullOrEmpty``1(System.Collections.Generic.IEnumerable{``0})')
  - [IsNullOrEmpty\`\`1(source)](#M-KeepCoding-Helper-IsNullOrEmpty``1-System-Collections-Generic-IEnumerator{``0}- 'KeepCoding.Helper.IsNullOrEmpty``1(System.Collections.Generic.IEnumerator{``0})')
  - [IsParent(kmSelectable)](#M-KeepCoding-Helper-IsParent-KMSelectable- 'KeepCoding.Helper.IsParent(KMSelectable)')
  - [LastValue\`\`1(source,func)](#M-KeepCoding-Helper-LastValue``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0}- 'KeepCoding.Helper.LastValue``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``0})')
  - [LengthOrDefault\`\`1(source)](#M-KeepCoding-Helper-LengthOrDefault``1-System-Collections-Generic-IEnumerable{``0}- 'KeepCoding.Helper.LengthOrDefault``1(System.Collections.Generic.IEnumerable{``0})')
  - [LongToBase(value,baseChars)](#M-KeepCoding-Helper-LongToBase-System-Int64,System-String- 'KeepCoding.Helper.LongToBase(System.Int64,System.String)')
  - [LongToBase(value,baseNumber)](#M-KeepCoding-Helper-LongToBase-System-Int64,System-Int32- 'KeepCoding.Helper.LongToBase(System.Int64,System.Int32)')
  - [MemberCount\`\`1()](#M-KeepCoding-Helper-MemberCount``1 'KeepCoding.Helper.MemberCount``1')
  - [Method(logType)](#M-KeepCoding-Helper-Method-UnityEngine-LogType- 'KeepCoding.Helper.Method(UnityEngine.LogType)')
  - [Modulo(number,modulo)](#M-KeepCoding-Helper-Modulo-System-Int32,System-Int32- 'KeepCoding.Helper.Modulo(System.Int32,System.Int32)')
  - [Modulo(number,modulo)](#M-KeepCoding-Helper-Modulo-System-Single,System-Single- 'KeepCoding.Helper.Modulo(System.Single,System.Single)')
  - [Modulo(item,bigInteger)](#M-KeepCoding-Helper-Modulo-System-Object,KeepCoding-BigInteger- 'KeepCoding.Helper.Modulo(System.Object,KeepCoding.BigInteger)')
  - [NullCheck\`\`1(item,message)](#M-KeepCoding-Helper-NullCheck``1-``0,System-String- 'KeepCoding.Helper.NullCheck``1(``0,System.String)')
  - [NullOrEmptyCheck(source,message)](#M-KeepCoding-Helper-NullOrEmptyCheck-System-String,System-String- 'KeepCoding.Helper.NullOrEmptyCheck(System.String,System.String)')
  - [NullOrEmptyCheck\`\`1(source,message)](#M-KeepCoding-Helper-NullOrEmptyCheck``1-System-Collections-Generic-IEnumerable{``0},System-String- 'KeepCoding.Helper.NullOrEmptyCheck``1(System.Collections.Generic.IEnumerable{``0},System.String)')
  - [NullOrEmptyCheck\`\`1(source,message)](#M-KeepCoding-Helper-NullOrEmptyCheck``1-System-Collections-Generic-IEnumerator{``0},System-String- 'KeepCoding.Helper.NullOrEmptyCheck``1(System.Collections.Generic.IEnumerator{``0},System.String)')
  - [Prepend\`\`1(source,item)](#M-KeepCoding-Helper-Prepend``1-System-Collections-Generic-IEnumerable{``0},``0- 'KeepCoding.Helper.Prepend``1(System.Collections.Generic.IEnumerable{``0},``0)')
  - [Prepend\`\`1(array,item)](#M-KeepCoding-Helper-Prepend``1-``0[],``0- 'KeepCoding.Helper.Prepend``1(``0[],``0)')
  - [RandomBoolean(weighting)](#M-KeepCoding-Helper-RandomBoolean-System-Single- 'KeepCoding.Helper.RandomBoolean(System.Single)')
  - [RandomBooleans(length,weighting)](#M-KeepCoding-Helper-RandomBooleans-System-Int32,System-Single- 'KeepCoding.Helper.RandomBooleans(System.Int32,System.Single)')
  - [Ranges(length,min,max)](#M-KeepCoding-Helper-Ranges-System-Int32,System-Int32,System-Int32- 'KeepCoding.Helper.Ranges(System.Int32,System.Int32,System.Int32)')
  - [Ranges(length,min,max)](#M-KeepCoding-Helper-Ranges-System-Int32,System-Single,System-Single- 'KeepCoding.Helper.Ranges(System.Int32,System.Single,System.Single)')
  - [ReflectAll\`\`1(source)](#M-KeepCoding-Helper-ReflectAll``1-``0- 'KeepCoding.Helper.ReflectAll``1(``0)')
  - [Replace\`\`1(source,index,value)](#M-KeepCoding-Helper-Replace``1-System-Collections-Generic-IEnumerable{``0},System-Int32,``0- 'KeepCoding.Helper.Replace``1(System.Collections.Generic.IEnumerable{``0},System.Int32,``0)')
  - [Rev\`\`1(source)](#M-KeepCoding-Helper-Rev``1-System-Collections-Generic-List{``0}- 'KeepCoding.Helper.Rev``1(System.Collections.Generic.List{``0})')
  - [Reverse(source)](#M-KeepCoding-Helper-Reverse-System-String- 'KeepCoding.Helper.Reverse(System.String)')
  - [SetOrReplace\`\`1(source,key,func)](#M-KeepCoding-Helper-SetOrReplace``1-System-Collections-Generic-IDictionary{``0,System-Int32},``0,System-Func{System-Int32,System-Int32}- 'KeepCoding.Helper.SetOrReplace``1(System.Collections.Generic.IDictionary{``0,System.Int32},``0,System.Func{System.Int32,System.Int32})')
  - [Slice\`\`1(source,start,count)](#M-KeepCoding-Helper-Slice``1-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Int32- 'KeepCoding.Helper.Slice``1(System.Collections.Generic.IEnumerable{``0},System.Int32,System.Int32)')
  - [Split(source,separator)](#M-KeepCoding-Helper-Split-System-String,System-String- 'KeepCoding.Helper.Split(System.String,System.String)')
  - [SplitBy\`\`1(source,predicate)](#M-KeepCoding-Helper-SplitBy``1-System-Collections-Generic-IEnumerable{``0},System-Predicate{``0}- 'KeepCoding.Helper.SplitBy``1(System.Collections.Generic.IEnumerable{``0},System.Predicate{``0})')
  - [SplitEvery\`\`1(source,length)](#M-KeepCoding-Helper-SplitEvery``1-System-Collections-Generic-IEnumerable{``0},System-Int32- 'KeepCoding.Helper.SplitEvery``1(System.Collections.Generic.IEnumerable{``0},System.Int32)')
  - [Stop(monoBehaviour,coroutines)](#M-KeepCoding-Helper-Stop-UnityEngine-MonoBehaviour,UnityEngine-Coroutine[]- 'KeepCoding.Helper.Stop(UnityEngine.MonoBehaviour,UnityEngine.Coroutine[])')
  - [ToLower(source)](#M-KeepCoding-Helper-ToLower-System-Char- 'KeepCoding.Helper.ToLower(System.Char)')
  - [ToNumber(source)](#M-KeepCoding-Helper-ToNumber-System-Char- 'KeepCoding.Helper.ToNumber(System.Char)')
  - [ToNumbers\`\`1(ts,min,max,minLength,maxLength)](#M-KeepCoding-Helper-ToNumbers``1-``0[],System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Int32}- 'KeepCoding.Helper.ToNumbers``1(``0[],System.Nullable{System.Int32},System.Nullable{System.Int32},System.Nullable{System.Int32},System.Nullable{System.Int32})')
  - [ToOrdinal(i)](#M-KeepCoding-Helper-ToOrdinal-System-Int32- 'KeepCoding.Helper.ToOrdinal(System.Int32)')
  - [ToUpper(source)](#M-KeepCoding-Helper-ToUpper-System-Char- 'KeepCoding.Helper.ToUpper(System.Char)')
  - [Unwrap(source,isRecursive)](#M-KeepCoding-Helper-Unwrap-System-Collections-IEnumerable,System-Boolean- 'KeepCoding.Helper.Unwrap(System.Collections.IEnumerable,System.Boolean)')
  - [UnwrapToString\`\`1(item,getVariables,delimiter)](#M-KeepCoding-Helper-UnwrapToString``1-``0,System-Boolean,System-String- 'KeepCoding.Helper.UnwrapToString``1(``0,System.Boolean,System.String)')
  - [Unwrap\`\`1(source,isRecursive)](#M-KeepCoding-Helper-Unwrap``1-``0,System-Boolean- 'KeepCoding.Helper.Unwrap``1(``0,System.Boolean)')
- [IDump](#T-KeepCoding-IDump 'KeepCoding.IDump')
  - [Dump(getVariables,logs)](#M-KeepCoding-IDump-Dump-System-Boolean,System-Linq-Expressions-Expression{System-Func{System-Object}}[]- 'KeepCoding.IDump.Dump(System.Boolean,System.Linq.Expressions.Expression{System.Func{System.Object}}[])')
  - [Dump(logs)](#M-KeepCoding-IDump-Dump-System-Linq-Expressions-Expression{System-Func{System-Object}}[]- 'KeepCoding.IDump.Dump(System.Linq.Expressions.Expression{System.Func{System.Object}}[])')
- [ILog](#T-KeepCoding-ILog 'KeepCoding.ILog')
  - [LogMultiple(logs)](#M-KeepCoding-ILog-LogMultiple-System-String[]- 'KeepCoding.ILog.LogMultiple(System.String[])')
  - [Log\`\`1(message,logType)](#M-KeepCoding-ILog-Log``1-``0,UnityEngine-LogType- 'KeepCoding.ILog.Log``1(``0,UnityEngine.LogType)')
  - [Log\`\`1(message,args)](#M-KeepCoding-ILog-Log``1-``0,System-Object[]- 'KeepCoding.ILog.Log``1(``0,System.Object[])')
- [ITP](#T-KeepCoding-ITP 'KeepCoding.ITP')
  - [Abandons](#P-KeepCoding-ITP-Abandons 'KeepCoding.ITP.Abandons')
  - [Help](#P-KeepCoding-ITP-Help 'KeepCoding.ITP.Help')
  - [IsCancelCommand](#P-KeepCoding-ITP-IsCancelCommand 'KeepCoding.ITP.IsCancelCommand')
  - [IsTP](#P-KeepCoding-ITP-IsTP 'KeepCoding.ITP.IsTP')
  - [IsTime](#P-KeepCoding-ITP-IsTime 'KeepCoding.ITP.IsTime')
  - [IsTimeSkippable](#P-KeepCoding-ITP-IsTimeSkippable 'KeepCoding.ITP.IsTimeSkippable')
  - [IsZen](#P-KeepCoding-ITP-IsZen 'KeepCoding.ITP.IsZen')
  - [Manual](#P-KeepCoding-ITP-Manual 'KeepCoding.ITP.Manual')
  - [ForceSolve()](#M-KeepCoding-ITP-ForceSolve 'KeepCoding.ITP.ForceSolve')
  - [Process(command)](#M-KeepCoding-ITP-Process-System-String- 'KeepCoding.ITP.Process(System.String)')
- [ITuple](#T-KeepCoding-ITuple 'KeepCoding.ITuple')
  - [IsEmpty](#P-KeepCoding-ITuple-IsEmpty 'KeepCoding.ITuple.IsEmpty')
  - [Item](#P-KeepCoding-ITuple-Item-System-Byte- 'KeepCoding.ITuple.Item(System.Byte)')
  - [Length](#P-KeepCoding-ITuple-Length 'KeepCoding.ITuple.Length')
  - [ToArray](#P-KeepCoding-ITuple-ToArray 'KeepCoding.ITuple.ToArray')
  - [UpperBound](#P-KeepCoding-ITuple-UpperBound 'KeepCoding.ITuple.UpperBound')
- [KTInputManager](#T-KeepCoding-Game-KTInputManager 'KeepCoding.Game.KTInputManager')
  - [CurrentControlType](#P-KeepCoding-Game-KTInputManager-CurrentControlType 'KeepCoding.Game.KTInputManager.CurrentControlType')
  - [IsCurrentControlTypeVR](#P-KeepCoding-Game-KTInputManager-IsCurrentControlTypeVR 'KeepCoding.Game.KTInputManager.IsCurrentControlTypeVR')
- [KeyHelper](#T-KeepCoding-KeyHelper 'KeepCoding.KeyHelper')
  - [As\`\`1(obj)](#M-KeepCoding-KeyHelper-As``1-System-Object- 'KeepCoding.KeyHelper.As``1(System.Object)')
  - [Catch(action,caught,final,exceptions)](#M-KeepCoding-KeyHelper-Catch-System-Action,System-Action{System-Exception},System-Action,System-Type[]- 'KeepCoding.KeyHelper.Catch(System.Action,System.Action{System.Exception},System.Action,System.Type[])')
  - [Catch\`\`1(action,caught,final)](#M-KeepCoding-KeyHelper-Catch``1-System-Action,System-Action{System-Exception},System-Action- 'KeepCoding.KeyHelper.Catch``1(System.Action,System.Action{System.Exception},System.Action)')
  - [Catch\`\`1(action,caught,exceptions)](#M-KeepCoding-KeyHelper-Catch``1-System-Func{``0},System-Func{System-Exception,``0},System-Type[]- 'KeepCoding.KeyHelper.Catch``1(System.Func{``0},System.Func{System.Exception,``0},System.Type[])')
  - [Catch\`\`2(action,caught,final)](#M-KeepCoding-KeyHelper-Catch``2-System-Action,System-Action{System-Exception},System-Action- 'KeepCoding.KeyHelper.Catch``2(System.Action,System.Action{System.Exception},System.Action)')
  - [Catch\`\`2(action,caught)](#M-KeepCoding-KeyHelper-Catch``2-System-Func{``1},System-Func{System-Exception,``1}- 'KeepCoding.KeyHelper.Catch``2(System.Func{``1},System.Func{System.Exception,``1})')
  - [Catch\`\`3(action,caught,final)](#M-KeepCoding-KeyHelper-Catch``3-System-Action,System-Action{System-Exception},System-Action- 'KeepCoding.KeyHelper.Catch``3(System.Action,System.Action{System.Exception},System.Action)')
  - [Catch\`\`3(action,caught)](#M-KeepCoding-KeyHelper-Catch``3-System-Func{``2},System-Func{System-Exception,``2}- 'KeepCoding.KeyHelper.Catch``3(System.Func{``2},System.Func{System.Exception,``2})')
  - [Catch\`\`4(action,caught,final)](#M-KeepCoding-KeyHelper-Catch``4-System-Action,System-Action{System-Exception},System-Action- 'KeepCoding.KeyHelper.Catch``4(System.Action,System.Action{System.Exception},System.Action)')
  - [Catch\`\`4(action,caught)](#M-KeepCoding-KeyHelper-Catch``4-System-Func{``3},System-Func{System-Exception,``3}- 'KeepCoding.KeyHelper.Catch``4(System.Func{``3},System.Func{System.Exception,``3})')
  - [Catch\`\`5(action,caught)](#M-KeepCoding-KeyHelper-Catch``5-System-Func{``4},System-Func{System-Exception,``4}- 'KeepCoding.KeyHelper.Catch``5(System.Func{``4},System.Func{System.Exception,``4})')
  - [Checked(action)](#M-KeepCoding-KeyHelper-Checked-System-Action- 'KeepCoding.KeyHelper.Checked(System.Action)')
  - [Checked\`\`1(func)](#M-KeepCoding-KeyHelper-Checked``1-System-Func{``0}- 'KeepCoding.KeyHelper.Checked``1(System.Func{``0})')
  - [DoWhile(action,condition)](#M-KeepCoding-KeyHelper-DoWhile-System-Action,System-Func{System-Boolean}- 'KeepCoding.KeyHelper.DoWhile(System.Action,System.Func{System.Boolean})')
  - [DoWhile\`\`1(func,condition)](#M-KeepCoding-KeyHelper-DoWhile``1-System-Func{``0},System-Func{System-Boolean}- 'KeepCoding.KeyHelper.DoWhile``1(System.Func{``0},System.Func{System.Boolean})')
  - [ForEach(iterator,action)](#M-KeepCoding-KeyHelper-ForEach-System-Collections-IEnumerable,System-Action{System-Object}- 'KeepCoding.KeyHelper.ForEach(System.Collections.IEnumerable,System.Action{System.Object})')
  - [ForEach(iterator,action)](#M-KeepCoding-KeyHelper-ForEach-System-Collections-IEnumerator,System-Action{System-Object}- 'KeepCoding.KeyHelper.ForEach(System.Collections.IEnumerator,System.Action{System.Object})')
  - [ForEach\`\`1(iterator,action)](#M-KeepCoding-KeyHelper-ForEach``1-System-Collections-Generic-IEnumerable{``0},System-Action{``0}- 'KeepCoding.KeyHelper.ForEach``1(System.Collections.Generic.IEnumerable{``0},System.Action{``0})')
  - [ForEach\`\`1(iterator,action)](#M-KeepCoding-KeyHelper-ForEach``1-System-Collections-Generic-IEnumerator{``0},System-Action{``0}- 'KeepCoding.KeyHelper.ForEach``1(System.Collections.Generic.IEnumerator{``0},System.Action{``0})')
  - [For\`\`1(item,action,condition,loop)](#M-KeepCoding-KeyHelper-For``1-``0,System-Action{``0},System-Predicate{``0},System-Func{``0,``0}- 'KeepCoding.KeyHelper.For``1(``0,System.Action{``0},System.Predicate{``0},System.Func{``0,``0})')
  - [For\`\`1(item,func,condition,loop)](#M-KeepCoding-KeyHelper-For``1-``0,System-Func{``0,``0},System-Predicate{``0},System-Func{``0,``0}- 'KeepCoding.KeyHelper.For``1(``0,System.Func{``0,``0},System.Predicate{``0},System.Func{``0,``0})')
  - [If(condition,action,otherwise)](#M-KeepCoding-KeyHelper-If-System-Boolean,System-Action,System-Action- 'KeepCoding.KeyHelper.If(System.Boolean,System.Action,System.Action)')
  - [If\`\`1(condition,action,otherwise)](#M-KeepCoding-KeyHelper-If``1-System-Boolean,System-Func{``0},System-Func{``0}- 'KeepCoding.KeyHelper.If``1(System.Boolean,System.Func{``0},System.Func{``0})')
  - [Is\`\`1(obj)](#M-KeepCoding-KeyHelper-Is``1-System-Object- 'KeepCoding.KeyHelper.Is``1(System.Object)')
  - [Is\`\`1(obj,item)](#M-KeepCoding-KeyHelper-Is``1-System-Object,``0@- 'KeepCoding.KeyHelper.Is``1(System.Object,``0@)')
  - [Lock\`\`1(item,action)](#M-KeepCoding-KeyHelper-Lock``1-``0,System-Action{``0}- 'KeepCoding.KeyHelper.Lock``1(``0,System.Action{``0})')
  - [Lock\`\`1(item,func)](#M-KeepCoding-KeyHelper-Lock``1-``0,System-Func{``0,``0}- 'KeepCoding.KeyHelper.Lock``1(``0,System.Func{``0,``0})')
  - [NameOf\`\`1(expression)](#M-KeepCoding-KeyHelper-NameOf``1-System-Linq-Expressions-Expression{System-Func{``0}}- 'KeepCoding.KeyHelper.NameOf``1(System.Linq.Expressions.Expression{System.Func{``0}})')
  - [Unchecked(action)](#M-KeepCoding-KeyHelper-Unchecked-System-Action- 'KeepCoding.KeyHelper.Unchecked(System.Action)')
  - [Unchecked\`\`1(func)](#M-KeepCoding-KeyHelper-Unchecked``1-System-Func{``0}- 'KeepCoding.KeyHelper.Unchecked``1(System.Func{``0})')
  - [Using\`\`1(item,action)](#M-KeepCoding-KeyHelper-Using``1-``0,System-Action{``0}- 'KeepCoding.KeyHelper.Using``1(``0,System.Action{``0})')
  - [Using\`\`1(item,func)](#M-KeepCoding-KeyHelper-Using``1-``0,System-Func{``0,``0}- 'KeepCoding.KeyHelper.Using``1(``0,System.Func{``0,``0})')
  - [While(action,condition)](#M-KeepCoding-KeyHelper-While-System-Action,System-Func{System-Boolean}- 'KeepCoding.KeyHelper.While(System.Action,System.Func{System.Boolean})')
  - [While\`\`1(func,condition)](#M-KeepCoding-KeyHelper-While``1-System-Func{``0},System-Func{System-Boolean}- 'KeepCoding.KeyHelper.While``1(System.Func{``0},System.Func{System.Boolean})')
- [Logger](#T-KeepCoding-Logger 'KeepCoding.Logger')
  - [#ctor(name,showId,showInLfa)](#M-KeepCoding-Logger-#ctor-System-String,System-Boolean,System-Boolean- 'KeepCoding.Logger.#ctor(System.String,System.Boolean,System.Boolean)')
  - [#ctor(type,showId)](#M-KeepCoding-Logger-#ctor-System-Type,System-Boolean- 'KeepCoding.Logger.#ctor(System.Type,System.Boolean)')
  - [Id](#P-KeepCoding-Logger-Id 'KeepCoding.Logger.Id')
  - [Name](#P-KeepCoding-Logger-Name 'KeepCoding.Logger.Name')
  - [Dump(obj,getVariables)](#M-KeepCoding-Logger-Dump-System-Object,System-Boolean- 'KeepCoding.Logger.Dump(System.Object,System.Boolean)')
  - [Dump(getVariables,logs)](#M-KeepCoding-Logger-Dump-System-Boolean,System-Linq-Expressions-Expression{System-Func{System-Object}}[]- 'KeepCoding.Logger.Dump(System.Boolean,System.Linq.Expressions.Expression{System.Func{System.Object}}[])')
  - [Dump(logs)](#M-KeepCoding-Logger-Dump-System-Linq-Expressions-Expression{System-Func{System-Object}}[]- 'KeepCoding.Logger.Dump(System.Linq.Expressions.Expression{System.Func{System.Object}}[])')
  - [Equals(obj)](#M-KeepCoding-Logger-Equals-System-Object- 'KeepCoding.Logger.Equals(System.Object)')
  - [GetHashCode()](#M-KeepCoding-Logger-GetHashCode 'KeepCoding.Logger.GetHashCode')
  - [LogMultiple(logs)](#M-KeepCoding-Logger-LogMultiple-System-String[]- 'KeepCoding.Logger.LogMultiple(System.String[])')
  - [Log\`\`1(message,logType)](#M-KeepCoding-Logger-Log``1-``0,UnityEngine-LogType- 'KeepCoding.Logger.Log``1(``0,UnityEngine.LogType)')
  - [Log\`\`1(message,args)](#M-KeepCoding-Logger-Log``1-``0,System-Object[]- 'KeepCoding.Logger.Log``1(``0,System.Object[])')
- [MasterAudio](#T-KeepCoding-Game-MasterAudio 'KeepCoding.Game.MasterAudio')
  - [GroupInfo](#P-KeepCoding-Game-MasterAudio-GroupInfo 'KeepCoding.Game.MasterAudio.GroupInfo')
  - [IsGroupInfo](#P-KeepCoding-Game-MasterAudio-IsGroupInfo 'KeepCoding.Game.MasterAudio.IsGroupInfo')
- [Mission](#T-KeepCoding-Game-Mission 'KeepCoding.Game.Mission')
  - [Description](#P-KeepCoding-Game-Mission-Description 'KeepCoding.Game.Mission.Description')
  - [DisplayName](#P-KeepCoding-Game-Mission-DisplayName 'KeepCoding.Game.Mission.DisplayName')
  - [GeneratorSetting](#P-KeepCoding-Game-Mission-GeneratorSetting 'KeepCoding.Game.Mission.GeneratorSetting')
  - [ID](#P-KeepCoding-Game-Mission-ID 'KeepCoding.Game.Mission.ID')
  - [IsPacingEvents](#P-KeepCoding-Game-Mission-IsPacingEvents 'KeepCoding.Game.Mission.IsPacingEvents')
- [ModInfo](#T-KeepCoding-ModInfo 'KeepCoding.ModInfo')
  - [Author](#P-KeepCoding-ModInfo-Author 'KeepCoding.ModInfo.Author')
  - [Description](#P-KeepCoding-ModInfo-Description 'KeepCoding.ModInfo.Description')
  - [Id](#P-KeepCoding-ModInfo-Id 'KeepCoding.ModInfo.Id')
  - [Title](#P-KeepCoding-ModInfo-Title 'KeepCoding.ModInfo.Title')
  - [UnityVersion](#P-KeepCoding-ModInfo-UnityVersion 'KeepCoding.ModInfo.UnityVersion')
  - [Values](#P-KeepCoding-ModInfo-Values 'KeepCoding.ModInfo.Values')
  - [Version](#P-KeepCoding-ModInfo-Version 'KeepCoding.ModInfo.Version')
  - [Deserialize(path)](#M-KeepCoding-ModInfo-Deserialize-System-String- 'KeepCoding.ModInfo.Deserialize(System.String)')
  - [Equals(obj)](#M-KeepCoding-ModInfo-Equals-System-Object- 'KeepCoding.ModInfo.Equals(System.Object)')
  - [GetHashCode()](#M-KeepCoding-ModInfo-GetHashCode 'KeepCoding.ModInfo.GetHashCode')
  - [ToString()](#M-KeepCoding-ModInfo-ToString 'KeepCoding.ModInfo.ToString')
- [ModManager](#T-KeepCoding-Game-ModManager 'KeepCoding.Game.ModManager')
  - [GetAllModPathsFromSource](#P-KeepCoding-Game-ModManager-GetAllModPathsFromSource 'KeepCoding.Game.ModManager.GetAllModPathsFromSource')
  - [GetDisabledModPaths](#P-KeepCoding-Game-ModManager-GetDisabledModPaths 'KeepCoding.Game.ModManager.GetDisabledModPaths')
  - [GetEnabledModPaths](#P-KeepCoding-Game-ModManager-GetEnabledModPaths 'KeepCoding.Game.ModManager.GetEnabledModPaths')
- [ModSourceEnum](#T-KeepCoding-Game-ModSourceEnum 'KeepCoding.Game.ModSourceEnum')
  - [Invalid](#F-KeepCoding-Game-ModSourceEnum-Invalid 'KeepCoding.Game.ModSourceEnum.Invalid')
  - [Local](#F-KeepCoding-Game-ModSourceEnum-Local 'KeepCoding.Game.ModSourceEnum.Local')
  - [SteamWorkshop](#F-KeepCoding-Game-ModSourceEnum-SteamWorkshop 'KeepCoding.Game.ModSourceEnum.SteamWorkshop')
- [ModuleContainer](#T-KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer')
  - [#ctor(solvable,needy)](#M-KeepCoding-ModuleContainer-#ctor-KMBombModule,KMNeedyModule- 'KeepCoding.ModuleContainer.#ctor(KMBombModule,KMNeedyModule)')
  - [#ctor(behaviour)](#M-KeepCoding-ModuleContainer-#ctor-KeepCoding-CacheableBehaviour- 'KeepCoding.ModuleContainer.#ctor(KeepCoding.CacheableBehaviour)')
  - [#ctor(component)](#M-KeepCoding-ModuleContainer-#ctor-UnityEngine-Component- 'KeepCoding.ModuleContainer.#ctor(UnityEngine.Component)')
  - [#ctor(solvable)](#M-KeepCoding-ModuleContainer-#ctor-KMBombModule- 'KeepCoding.ModuleContainer.#ctor(KMBombModule)')
  - [#ctor(needy)](#M-KeepCoding-ModuleContainer-#ctor-KMNeedyModule- 'KeepCoding.ModuleContainer.#ctor(KMNeedyModule)')
  - [Id](#P-KeepCoding-ModuleContainer-Id 'KeepCoding.ModuleContainer.Id')
  - [Module](#P-KeepCoding-ModuleContainer-Module 'KeepCoding.ModuleContainer.Module')
  - [Name](#P-KeepCoding-ModuleContainer-Name 'KeepCoding.ModuleContainer.Name')
  - [Needy](#P-KeepCoding-ModuleContainer-Needy 'KeepCoding.ModuleContainer.Needy')
  - [RequiresTimerVisibility](#P-KeepCoding-ModuleContainer-RequiresTimerVisibility 'KeepCoding.ModuleContainer.RequiresTimerVisibility')
  - [RuleGeneration](#P-KeepCoding-ModuleContainer-RuleGeneration 'KeepCoding.ModuleContainer.RuleGeneration')
  - [Solvable](#P-KeepCoding-ModuleContainer-Solvable 'KeepCoding.ModuleContainer.Solvable')
  - [Solve](#P-KeepCoding-ModuleContainer-Solve 'KeepCoding.ModuleContainer.Solve')
  - [Strike](#P-KeepCoding-ModuleContainer-Strike 'KeepCoding.ModuleContainer.Strike')
  - [Assign(onActivate,onNeedyActivation,onNeedyDeactivation,onPass,onStrike,onTimerExpired)](#M-KeepCoding-ModuleContainer-Assign-System-Action,System-Action,System-Action,System-Action,System-Action,System-Action- 'KeepCoding.ModuleContainer.Assign(System.Action,System.Action,System.Action,System.Action,System.Action,System.Action)')
  - [Equals(obj)](#M-KeepCoding-ModuleContainer-Equals-System-Object- 'KeepCoding.ModuleContainer.Equals(System.Object)')
  - [Equals(other)](#M-KeepCoding-ModuleContainer-Equals-KeepCoding-ModuleContainer- 'KeepCoding.ModuleContainer.Equals(KeepCoding.ModuleContainer)')
  - [GetHashCode()](#M-KeepCoding-ModuleContainer-GetHashCode 'KeepCoding.ModuleContainer.GetHashCode')
  - [OnActivate(action)](#M-KeepCoding-ModuleContainer-OnActivate-System-Action- 'KeepCoding.ModuleContainer.OnActivate(System.Action)')
  - [op_Explicit(container)](#M-KeepCoding-ModuleContainer-op_Explicit-KeepCoding-ModuleContainer-~KMBombModule 'KeepCoding.ModuleContainer.op_Explicit(KeepCoding.ModuleContainer)~KMBombModule')
  - [op_Explicit(container)](#M-KeepCoding-ModuleContainer-op_Explicit-KeepCoding-ModuleContainer-~KMNeedyModule 'KeepCoding.ModuleContainer.op_Explicit(KeepCoding.ModuleContainer)~KMNeedyModule')
  - [op_Implicit(solvable)](#M-KeepCoding-ModuleContainer-op_Implicit-KMBombModule-~KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer.op_Implicit(KMBombModule)~KeepCoding.ModuleContainer')
  - [op_Implicit(needy)](#M-KeepCoding-ModuleContainer-op_Implicit-KMNeedyModule-~KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer.op_Implicit(KMNeedyModule)~KeepCoding.ModuleContainer')
- [ModuleScript](#T-KeepCoding-ModuleScript 'KeepCoding.ModuleScript')
  - [Bomb](#P-KeepCoding-ModuleScript-Bomb 'KeepCoding.ModuleScript.Bomb')
  - [HasStruck](#P-KeepCoding-ModuleScript-HasStruck 'KeepCoding.ModuleScript.HasStruck')
  - [Id](#P-KeepCoding-ModuleScript-Id 'KeepCoding.ModuleScript.Id')
  - [IsActive](#P-KeepCoding-ModuleScript-IsActive 'KeepCoding.ModuleScript.IsActive')
  - [IsEditor](#P-KeepCoding-ModuleScript-IsEditor 'KeepCoding.ModuleScript.IsEditor')
  - [IsLastInstantiated](#P-KeepCoding-ModuleScript-IsLastInstantiated 'KeepCoding.ModuleScript.IsLastInstantiated')
  - [IsNeedyActive](#P-KeepCoding-ModuleScript-IsNeedyActive 'KeepCoding.ModuleScript.IsNeedyActive')
  - [IsSolved](#P-KeepCoding-ModuleScript-IsSolved 'KeepCoding.ModuleScript.IsSolved')
  - [IsVR](#P-KeepCoding-ModuleScript-IsVR 'KeepCoding.ModuleScript.IsVR')
  - [LastId](#P-KeepCoding-ModuleScript-LastId 'KeepCoding.ModuleScript.LastId')
  - [Module](#P-KeepCoding-ModuleScript-Module 'KeepCoding.ModuleScript.Module')
  - [Modules](#P-KeepCoding-ModuleScript-Modules 'KeepCoding.ModuleScript.Modules')
  - [Sounds](#P-KeepCoding-ModuleScript-Sounds 'KeepCoding.ModuleScript.Sounds')
  - [TP](#P-KeepCoding-ModuleScript-TP 'KeepCoding.ModuleScript.TP')
  - [TimeLeft](#P-KeepCoding-ModuleScript-TimeLeft 'KeepCoding.ModuleScript.TimeLeft')
  - [Version](#P-KeepCoding-ModuleScript-Version 'KeepCoding.ModuleScript.Version')
  - [Assign(onActivate,onNeedyActivation,onNeedyDeactivation,onPass,onStrike,onTimerExpired)](#M-KeepCoding-ModuleScript-Assign-System-Action,System-Action,System-Action,System-Action,System-Action,System-Action- 'KeepCoding.ModuleScript.Assign(System.Action,System.Action,System.Action,System.Action,System.Action,System.Action)')
  - [Awake()](#M-KeepCoding-ModuleScript-Awake 'KeepCoding.ModuleScript.Awake')
  - [ButtonEffect(selectable,intensityModifier,sounds)](#M-KeepCoding-ModuleScript-ButtonEffect-KMSelectable,System-Single,KeepCoding-Sound[]- 'KeepCoding.ModuleScript.ButtonEffect(KMSelectable,System.Single,KeepCoding.Sound[])')
  - [Dump(getVariables,logs)](#M-KeepCoding-ModuleScript-Dump-System-Boolean,System-Linq-Expressions-Expression{System-Func{System-Object}}[]- 'KeepCoding.ModuleScript.Dump(System.Boolean,System.Linq.Expressions.Expression{System.Func{System.Object}}[])')
  - [Dump(logs)](#M-KeepCoding-ModuleScript-Dump-System-Linq-Expressions-Expression{System-Func{System-Object}}[]- 'KeepCoding.ModuleScript.Dump(System.Linq.Expressions.Expression{System.Func{System.Object}}[])')
  - [LogMultiple(logs)](#M-KeepCoding-ModuleScript-LogMultiple-System-String[]- 'KeepCoding.ModuleScript.LogMultiple(System.String[])')
  - [Log\`\`1(message,logType)](#M-KeepCoding-ModuleScript-Log``1-``0,UnityEngine-LogType- 'KeepCoding.ModuleScript.Log``1(``0,UnityEngine.LogType)')
  - [Log\`\`1(message,args)](#M-KeepCoding-ModuleScript-Log``1-``0,System-Object[]- 'KeepCoding.ModuleScript.Log``1(``0,System.Object[])')
  - [OnActivate()](#M-KeepCoding-ModuleScript-OnActivate 'KeepCoding.ModuleScript.OnActivate')
  - [OnDestroy()](#M-KeepCoding-ModuleScript-OnDestroy 'KeepCoding.ModuleScript.OnDestroy')
  - [OnModuleStrike(moduleName)](#M-KeepCoding-ModuleScript-OnModuleStrike-System-String- 'KeepCoding.ModuleScript.OnModuleStrike(System.String)')
  - [OnNeedySolved(moduleName)](#M-KeepCoding-ModuleScript-OnNeedySolved-System-String- 'KeepCoding.ModuleScript.OnNeedySolved(System.String)')
  - [OnSolvableSolved(moduleName)](#M-KeepCoding-ModuleScript-OnSolvableSolved-System-String- 'KeepCoding.ModuleScript.OnSolvableSolved(System.String)')
  - [OnTimerTick()](#M-KeepCoding-ModuleScript-OnTimerTick 'KeepCoding.ModuleScript.OnTimerTick')
  - [PlaySound(transform,loop,sounds)](#M-KeepCoding-ModuleScript-PlaySound-UnityEngine-Transform,System-Boolean,KeepCoding-Sound[]- 'KeepCoding.ModuleScript.PlaySound(UnityEngine.Transform,System.Boolean,KeepCoding.Sound[])')
  - [PlaySound(transform,sounds)](#M-KeepCoding-ModuleScript-PlaySound-UnityEngine-Transform,KeepCoding-Sound[]- 'KeepCoding.ModuleScript.PlaySound(UnityEngine.Transform,KeepCoding.Sound[])')
  - [PlaySound(loop,sounds)](#M-KeepCoding-ModuleScript-PlaySound-System-Boolean,KeepCoding-Sound[]- 'KeepCoding.ModuleScript.PlaySound(System.Boolean,KeepCoding.Sound[])')
  - [PlaySound(sounds)](#M-KeepCoding-ModuleScript-PlaySound-KeepCoding-Sound[]- 'KeepCoding.ModuleScript.PlaySound(KeepCoding.Sound[])')
  - [Read\`\`1(module,key,allowDefault)](#M-KeepCoding-ModuleScript-Read``1-System-String,System-String,System-Boolean- 'KeepCoding.ModuleScript.Read``1(System.String,System.String,System.Boolean)')
  - [Solve(logs)](#M-KeepCoding-ModuleScript-Solve-System-String[]- 'KeepCoding.ModuleScript.Solve(System.String[])')
  - [Strike(logs)](#M-KeepCoding-ModuleScript-Strike-System-String[]- 'KeepCoding.ModuleScript.Strike(System.String[])')
  - [Write\`\`1(key,value)](#M-KeepCoding-ModuleScript-Write``1-System-String,``0- 'KeepCoding.ModuleScript.Write``1(System.String,``0)')
- [NegativeNumberException](#T-KeepCoding-NegativeNumberException 'KeepCoding.NegativeNumberException')
  - [#ctor()](#M-KeepCoding-NegativeNumberException-#ctor 'KeepCoding.NegativeNumberException.#ctor')
  - [#ctor(message)](#M-KeepCoding-NegativeNumberException-#ctor-System-String- 'KeepCoding.NegativeNumberException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-KeepCoding-NegativeNumberException-#ctor-System-String,System-Exception- 'KeepCoding.NegativeNumberException.#ctor(System.String,System.Exception)')
- [NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException')
  - [#ctor()](#M-KeepCoding-NullIteratorException-#ctor 'KeepCoding.NullIteratorException.#ctor')
  - [#ctor(message)](#M-KeepCoding-NullIteratorException-#ctor-System-String- 'KeepCoding.NullIteratorException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-KeepCoding-NullIteratorException-#ctor-System-String,System-Exception- 'KeepCoding.NullIteratorException.#ctor(System.String,System.Exception)')
- [Number](#T-KeepCoding-Number 'KeepCoding.Number')
  - [#ctor(value)](#M-KeepCoding-Number-#ctor-System-SByte- 'KeepCoding.Number.#ctor(System.SByte)')
  - [#ctor(value)](#M-KeepCoding-Number-#ctor-System-Byte- 'KeepCoding.Number.#ctor(System.Byte)')
  - [#ctor(value)](#M-KeepCoding-Number-#ctor-System-Int16- 'KeepCoding.Number.#ctor(System.Int16)')
  - [#ctor(value)](#M-KeepCoding-Number-#ctor-System-UInt16- 'KeepCoding.Number.#ctor(System.UInt16)')
  - [#ctor(value)](#M-KeepCoding-Number-#ctor-System-Int32- 'KeepCoding.Number.#ctor(System.Int32)')
  - [#ctor(value)](#M-KeepCoding-Number-#ctor-System-UInt32- 'KeepCoding.Number.#ctor(System.UInt32)')
  - [#ctor(value)](#M-KeepCoding-Number-#ctor-System-Int64- 'KeepCoding.Number.#ctor(System.Int64)')
  - [#ctor(value)](#M-KeepCoding-Number-#ctor-System-UInt64- 'KeepCoding.Number.#ctor(System.UInt64)')
  - [#ctor(value)](#M-KeepCoding-Number-#ctor-System-Single- 'KeepCoding.Number.#ctor(System.Single)')
  - [#ctor(value)](#M-KeepCoding-Number-#ctor-System-Double- 'KeepCoding.Number.#ctor(System.Double)')
  - [#ctor(value)](#M-KeepCoding-Number-#ctor-System-Decimal- 'KeepCoding.Number.#ctor(System.Decimal)')
  - [Epsilon](#P-KeepCoding-Number-Epsilon 'KeepCoding.Number.Epsilon')
  - [MaxValue](#P-KeepCoding-Number-MaxValue 'KeepCoding.Number.MaxValue')
  - [MinValue](#P-KeepCoding-Number-MinValue 'KeepCoding.Number.MinValue')
  - [NaN](#P-KeepCoding-Number-NaN 'KeepCoding.Number.NaN')
  - [NegativeInfinity](#P-KeepCoding-Number-NegativeInfinity 'KeepCoding.Number.NegativeInfinity')
  - [PositiveInfinity](#P-KeepCoding-Number-PositiveInfinity 'KeepCoding.Number.PositiveInfinity')
  - [Cast\`\`1()](#M-KeepCoding-Number-Cast``1 'KeepCoding.Number.Cast``1')
  - [CompareTo(obj)](#M-KeepCoding-Number-CompareTo-System-Object- 'KeepCoding.Number.CompareTo(System.Object)')
  - [CompareTo(other)](#M-KeepCoding-Number-CompareTo-KeepCoding-Number- 'KeepCoding.Number.CompareTo(KeepCoding.Number)')
  - [CompareTo(other)](#M-KeepCoding-Number-CompareTo-System-ValueType- 'KeepCoding.Number.CompareTo(System.ValueType)')
  - [Equals(obj)](#M-KeepCoding-Number-Equals-System-Object- 'KeepCoding.Number.Equals(System.Object)')
  - [Equals(other)](#M-KeepCoding-Number-Equals-KeepCoding-Number- 'KeepCoding.Number.Equals(KeepCoding.Number)')
  - [Equals(other)](#M-KeepCoding-Number-Equals-System-ValueType- 'KeepCoding.Number.Equals(System.ValueType)')
  - [GetHashCode()](#M-KeepCoding-Number-GetHashCode 'KeepCoding.Number.GetHashCode')
  - [GetTypeCode()](#M-KeepCoding-Number-GetTypeCode 'KeepCoding.Number.GetTypeCode')
  - [IsNaN()](#M-KeepCoding-Number-IsNaN 'KeepCoding.Number.IsNaN')
  - [Modulo(other)](#M-KeepCoding-Number-Modulo-KeepCoding-Number- 'KeepCoding.Number.Modulo(KeepCoding.Number)')
  - [New\`\`1()](#M-KeepCoding-Number-New``1-``0- 'KeepCoding.Number.New``1(``0)')
  - [Parse(s)](#M-KeepCoding-Number-Parse-System-String- 'KeepCoding.Number.Parse(System.String)')
  - [Parse(s,style)](#M-KeepCoding-Number-Parse-System-String,System-Globalization-NumberStyles- 'KeepCoding.Number.Parse(System.String,System.Globalization.NumberStyles)')
  - [Parse(s,provider)](#M-KeepCoding-Number-Parse-System-String,System-IFormatProvider- 'KeepCoding.Number.Parse(System.String,System.IFormatProvider)')
  - [Parse(s,style,provider)](#M-KeepCoding-Number-Parse-System-String,System-Globalization-NumberStyles,System-IFormatProvider- 'KeepCoding.Number.Parse(System.String,System.Globalization.NumberStyles,System.IFormatProvider)')
  - [Parse(s,style,info)](#M-KeepCoding-Number-Parse-System-String,System-Globalization-NumberStyles,System-Globalization-NumberFormatInfo- 'KeepCoding.Number.Parse(System.String,System.Globalization.NumberStyles,System.Globalization.NumberFormatInfo)')
  - [ToString()](#M-KeepCoding-Number-ToString 'KeepCoding.Number.ToString')
  - [ToString(format)](#M-KeepCoding-Number-ToString-System-String- 'KeepCoding.Number.ToString(System.String)')
  - [ToString(provider)](#M-KeepCoding-Number-ToString-System-IFormatProvider- 'KeepCoding.Number.ToString(System.IFormatProvider)')
  - [ToString(format,provider)](#M-KeepCoding-Number-ToString-System-String,System-IFormatProvider- 'KeepCoding.Number.ToString(System.String,System.IFormatProvider)')
  - [ToString(format,info)](#M-KeepCoding-Number-ToString-System-String,System-Globalization-NumberFormatInfo- 'KeepCoding.Number.ToString(System.String,System.Globalization.NumberFormatInfo)')
  - [TryParse(s,number)](#M-KeepCoding-Number-TryParse-System-String,KeepCoding-Number@- 'KeepCoding.Number.TryParse(System.String,KeepCoding.Number@)')
  - [TryParse(s,style,provider,number)](#M-KeepCoding-Number-TryParse-System-String,System-Globalization-NumberStyles,System-IFormatProvider,KeepCoding-Number@- 'KeepCoding.Number.TryParse(System.String,System.Globalization.NumberStyles,System.IFormatProvider,KeepCoding.Number@)')
  - [TryParse(s,style,info,number)](#M-KeepCoding-Number-TryParse-System-String,System-Globalization-NumberStyles,System-Globalization-NumberFormatInfo,KeepCoding-Number@- 'KeepCoding.Number.TryParse(System.String,System.Globalization.NumberStyles,System.Globalization.NumberFormatInfo,KeepCoding.Number@)')
  - [op_Addition(number,other)](#M-KeepCoding-Number-op_Addition-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_Addition(KeepCoding.Number,KeepCoding.Number)')
  - [op_BitwiseAnd(number,other)](#M-KeepCoding-Number-op_BitwiseAnd-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_BitwiseAnd(KeepCoding.Number,KeepCoding.Number)')
  - [op_BitwiseOr(number,other)](#M-KeepCoding-Number-op_BitwiseOr-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_BitwiseOr(KeepCoding.Number,KeepCoding.Number)')
  - [op_Decrement(number)](#M-KeepCoding-Number-op_Decrement-KeepCoding-Number- 'KeepCoding.Number.op_Decrement(KeepCoding.Number)')
  - [op_Division(number,other)](#M-KeepCoding-Number-op_Division-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_Division(KeepCoding.Number,KeepCoding.Number)')
  - [op_Equality(number,other)](#M-KeepCoding-Number-op_Equality-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_Equality(KeepCoding.Number,KeepCoding.Number)')
  - [op_Equality(number,other)](#M-KeepCoding-Number-op_Equality-KeepCoding-Number,System-ValueType- 'KeepCoding.Number.op_Equality(KeepCoding.Number,System.ValueType)')
  - [op_ExclusiveOr(number,other)](#M-KeepCoding-Number-op_ExclusiveOr-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_ExclusiveOr(KeepCoding.Number,KeepCoding.Number)')
  - [op_False(number)](#M-KeepCoding-Number-op_False-KeepCoding-Number- 'KeepCoding.Number.op_False(KeepCoding.Number)')
  - [op_GreaterThan(number,other)](#M-KeepCoding-Number-op_GreaterThan-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_GreaterThan(KeepCoding.Number,KeepCoding.Number)')
  - [op_GreaterThan(number,other)](#M-KeepCoding-Number-op_GreaterThan-KeepCoding-Number,System-ValueType- 'KeepCoding.Number.op_GreaterThan(KeepCoding.Number,System.ValueType)')
  - [op_GreaterThanOrEqual(number,other)](#M-KeepCoding-Number-op_GreaterThanOrEqual-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_GreaterThanOrEqual(KeepCoding.Number,KeepCoding.Number)')
  - [op_GreaterThanOrEqual(number,other)](#M-KeepCoding-Number-op_GreaterThanOrEqual-KeepCoding-Number,System-ValueType- 'KeepCoding.Number.op_GreaterThanOrEqual(KeepCoding.Number,System.ValueType)')
  - [op_Implicit(number)](#M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Boolean 'KeepCoding.Number.op_Implicit(KeepCoding.Number)~System.Boolean')
  - [op_Implicit(number)](#M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-SByte 'KeepCoding.Number.op_Implicit(KeepCoding.Number)~System.SByte')
  - [op_Implicit(number)](#M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Byte 'KeepCoding.Number.op_Implicit(KeepCoding.Number)~System.Byte')
  - [op_Implicit(number)](#M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Int16 'KeepCoding.Number.op_Implicit(KeepCoding.Number)~System.Int16')
  - [op_Implicit(number)](#M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-UInt16 'KeepCoding.Number.op_Implicit(KeepCoding.Number)~System.UInt16')
  - [op_Implicit(number)](#M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Int32 'KeepCoding.Number.op_Implicit(KeepCoding.Number)~System.Int32')
  - [op_Implicit(number)](#M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-UInt32 'KeepCoding.Number.op_Implicit(KeepCoding.Number)~System.UInt32')
  - [op_Implicit(number)](#M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Int64 'KeepCoding.Number.op_Implicit(KeepCoding.Number)~System.Int64')
  - [op_Implicit(number)](#M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-UInt64 'KeepCoding.Number.op_Implicit(KeepCoding.Number)~System.UInt64')
  - [op_Implicit(number)](#M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Single 'KeepCoding.Number.op_Implicit(KeepCoding.Number)~System.Single')
  - [op_Implicit(number)](#M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Double 'KeepCoding.Number.op_Implicit(KeepCoding.Number)~System.Double')
  - [op_Implicit(number)](#M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Decimal 'KeepCoding.Number.op_Implicit(KeepCoding.Number)~System.Decimal')
  - [op_Implicit(number)](#M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-ValueType 'KeepCoding.Number.op_Implicit(KeepCoding.Number)~System.ValueType')
  - [op_Implicit(value)](#M-KeepCoding-Number-op_Implicit-System-SByte-~KeepCoding-Number 'KeepCoding.Number.op_Implicit(System.SByte)~KeepCoding.Number')
  - [op_Implicit(value)](#M-KeepCoding-Number-op_Implicit-System-Byte-~KeepCoding-Number 'KeepCoding.Number.op_Implicit(System.Byte)~KeepCoding.Number')
  - [op_Implicit(value)](#M-KeepCoding-Number-op_Implicit-System-Int16-~KeepCoding-Number 'KeepCoding.Number.op_Implicit(System.Int16)~KeepCoding.Number')
  - [op_Implicit(value)](#M-KeepCoding-Number-op_Implicit-System-UInt16-~KeepCoding-Number 'KeepCoding.Number.op_Implicit(System.UInt16)~KeepCoding.Number')
  - [op_Implicit(value)](#M-KeepCoding-Number-op_Implicit-System-Int32-~KeepCoding-Number 'KeepCoding.Number.op_Implicit(System.Int32)~KeepCoding.Number')
  - [op_Implicit(value)](#M-KeepCoding-Number-op_Implicit-System-UInt32-~KeepCoding-Number 'KeepCoding.Number.op_Implicit(System.UInt32)~KeepCoding.Number')
  - [op_Implicit(value)](#M-KeepCoding-Number-op_Implicit-System-Int64-~KeepCoding-Number 'KeepCoding.Number.op_Implicit(System.Int64)~KeepCoding.Number')
  - [op_Implicit(value)](#M-KeepCoding-Number-op_Implicit-System-UInt64-~KeepCoding-Number 'KeepCoding.Number.op_Implicit(System.UInt64)~KeepCoding.Number')
  - [op_Implicit(value)](#M-KeepCoding-Number-op_Implicit-System-Single-~KeepCoding-Number 'KeepCoding.Number.op_Implicit(System.Single)~KeepCoding.Number')
  - [op_Implicit(value)](#M-KeepCoding-Number-op_Implicit-System-Double-~KeepCoding-Number 'KeepCoding.Number.op_Implicit(System.Double)~KeepCoding.Number')
  - [op_Implicit(value)](#M-KeepCoding-Number-op_Implicit-System-Decimal-~KeepCoding-Number 'KeepCoding.Number.op_Implicit(System.Decimal)~KeepCoding.Number')
  - [op_Increment(number)](#M-KeepCoding-Number-op_Increment-KeepCoding-Number- 'KeepCoding.Number.op_Increment(KeepCoding.Number)')
  - [op_Inequality(number,other)](#M-KeepCoding-Number-op_Inequality-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_Inequality(KeepCoding.Number,KeepCoding.Number)')
  - [op_Inequality(number,other)](#M-KeepCoding-Number-op_Inequality-KeepCoding-Number,System-ValueType- 'KeepCoding.Number.op_Inequality(KeepCoding.Number,System.ValueType)')
  - [op_LeftShift(number,other)](#M-KeepCoding-Number-op_LeftShift-KeepCoding-Number,System-Int32- 'KeepCoding.Number.op_LeftShift(KeepCoding.Number,System.Int32)')
  - [op_LessThan(number,other)](#M-KeepCoding-Number-op_LessThan-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_LessThan(KeepCoding.Number,KeepCoding.Number)')
  - [op_LessThan(number,other)](#M-KeepCoding-Number-op_LessThan-KeepCoding-Number,System-ValueType- 'KeepCoding.Number.op_LessThan(KeepCoding.Number,System.ValueType)')
  - [op_LessThanOrEqual(number,other)](#M-KeepCoding-Number-op_LessThanOrEqual-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_LessThanOrEqual(KeepCoding.Number,KeepCoding.Number)')
  - [op_LessThanOrEqual(number,other)](#M-KeepCoding-Number-op_LessThanOrEqual-KeepCoding-Number,System-ValueType- 'KeepCoding.Number.op_LessThanOrEqual(KeepCoding.Number,System.ValueType)')
  - [op_Modulus(number,other)](#M-KeepCoding-Number-op_Modulus-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_Modulus(KeepCoding.Number,KeepCoding.Number)')
  - [op_Multiply(number,other)](#M-KeepCoding-Number-op_Multiply-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_Multiply(KeepCoding.Number,KeepCoding.Number)')
  - [op_OnesComplement(number)](#M-KeepCoding-Number-op_OnesComplement-KeepCoding-Number- 'KeepCoding.Number.op_OnesComplement(KeepCoding.Number)')
  - [op_RightShift(number,other)](#M-KeepCoding-Number-op_RightShift-KeepCoding-Number,System-Int32- 'KeepCoding.Number.op_RightShift(KeepCoding.Number,System.Int32)')
  - [op_Subtraction(number,other)](#M-KeepCoding-Number-op_Subtraction-KeepCoding-Number,KeepCoding-Number- 'KeepCoding.Number.op_Subtraction(KeepCoding.Number,KeepCoding.Number)')
  - [op_True(number)](#M-KeepCoding-Number-op_True-KeepCoding-Number- 'KeepCoding.Number.op_True(KeepCoding.Number)')
  - [op_UnaryNegation(number)](#M-KeepCoding-Number-op_UnaryNegation-KeepCoding-Number- 'KeepCoding.Number.op_UnaryNegation(KeepCoding.Number)')
  - [op_UnaryPlus(number)](#M-KeepCoding-Number-op_UnaryPlus-KeepCoding-Number- 'KeepCoding.Number.op_UnaryPlus(KeepCoding.Number)')
- [PathManager](#T-KeepCoding-PathManager 'KeepCoding.PathManager')
  - [AssemblyName](#P-KeepCoding-PathManager-AssemblyName 'KeepCoding.PathManager.AssemblyName')
  - [Version](#P-KeepCoding-PathManager-Version 'KeepCoding.PathManager.Version')
  - [CombineMultiple(paths)](#M-KeepCoding-PathManager-CombineMultiple-System-String[]- 'KeepCoding.PathManager.CombineMultiple(System.String[])')
  - [GetAssets\`\`1(bundleFileName,bundleAssetFileName)](#M-KeepCoding-PathManager-GetAssets``1-System-String,System-String- 'KeepCoding.PathManager.GetAssets``1(System.String,System.String)')
  - [GetAssets\`\`1(type,bundleVideoFileName)](#M-KeepCoding-PathManager-GetAssets``1-System-Type,System-String- 'KeepCoding.PathManager.GetAssets``1(System.Type,System.String)')
  - [GetAssets\`\`2(_,bundleVideoFileName)](#M-KeepCoding-PathManager-GetAssets``2-``0,System-String- 'KeepCoding.PathManager.GetAssets``2(``0,System.String)')
  - [GetModInfo(bundleFileName)](#M-KeepCoding-PathManager-GetModInfo-System-String- 'KeepCoding.PathManager.GetModInfo(System.String)')
  - [GetModInfo(type)](#M-KeepCoding-PathManager-GetModInfo-System-Type- 'KeepCoding.PathManager.GetModInfo(System.Type)')
  - [GetModInfo\`\`1(_)](#M-KeepCoding-PathManager-GetModInfo``1-``0- 'KeepCoding.PathManager.GetModInfo``1(``0)')
  - [GetPath(search)](#M-KeepCoding-PathManager-GetPath-System-String- 'KeepCoding.PathManager.GetPath(System.String)')
  - [GetPath(type)](#M-KeepCoding-PathManager-GetPath-System-Type- 'KeepCoding.PathManager.GetPath(System.Type)')
  - [GetPath\`\`1(_)](#M-KeepCoding-PathManager-GetPath``1-``0- 'KeepCoding.PathManager.GetPath``1(``0)')
  - [LoadLibrary(bundleFileName,libraryFileName)](#M-KeepCoding-PathManager-LoadLibrary-System-String,System-String- 'KeepCoding.PathManager.LoadLibrary(System.String,System.String)')
  - [LoadLibrary(type,libraryFileName)](#M-KeepCoding-PathManager-LoadLibrary-System-Type,System-String- 'KeepCoding.PathManager.LoadLibrary(System.Type,System.String)')
  - [LoadLibrary\`\`1(_,libraryFileName)](#M-KeepCoding-PathManager-LoadLibrary``1-``0,System-String- 'KeepCoding.PathManager.LoadLibrary``1(``0,System.String)')
  - [NameOfAssembly(type)](#M-KeepCoding-PathManager-NameOfAssembly-System-Type- 'KeepCoding.PathManager.NameOfAssembly(System.Type)')
  - [NameOfAssembly\`\`1()](#M-KeepCoding-PathManager-NameOfAssembly``1 'KeepCoding.PathManager.NameOfAssembly``1')
  - [PrintHierarchy(indentation)](#M-KeepCoding-PathManager-PrintHierarchy-System-UInt16- 'KeepCoding.PathManager.PrintHierarchy(System.UInt16)')
  - [PrintHierarchy(obj,indentation,depth)](#M-KeepCoding-PathManager-PrintHierarchy-UnityEngine-GameObject,System-UInt16,System-UInt16- 'KeepCoding.PathManager.PrintHierarchy(UnityEngine.GameObject,System.UInt16,System.UInt16)')
- [PlayerSettings](#T-KeepCoding-Game-PlayerSettings 'KeepCoding.Game.PlayerSettings')
  - [AntiAliasing](#P-KeepCoding-Game-PlayerSettings-AntiAliasing 'KeepCoding.Game.PlayerSettings.AntiAliasing')
  - [InvertTiltControls](#P-KeepCoding-Game-PlayerSettings-InvertTiltControls 'KeepCoding.Game.PlayerSettings.InvertTiltControls')
  - [LanguageCode](#P-KeepCoding-Game-PlayerSettings-LanguageCode 'KeepCoding.Game.PlayerSettings.LanguageCode')
  - [LockMouseToWindow](#P-KeepCoding-Game-PlayerSettings-LockMouseToWindow 'KeepCoding.Game.PlayerSettings.LockMouseToWindow')
  - [MusicVolume](#P-KeepCoding-Game-PlayerSettings-MusicVolume 'KeepCoding.Game.PlayerSettings.MusicVolume')
  - [RumbleEnabled](#P-KeepCoding-Game-PlayerSettings-RumbleEnabled 'KeepCoding.Game.PlayerSettings.RumbleEnabled')
  - [SFXVolume](#P-KeepCoding-Game-PlayerSettings-SFXVolume 'KeepCoding.Game.PlayerSettings.SFXVolume')
  - [ShowLeaderBoards](#P-KeepCoding-Game-PlayerSettings-ShowLeaderBoards 'KeepCoding.Game.PlayerSettings.ShowLeaderBoards')
  - [ShowRotationUI](#P-KeepCoding-Game-PlayerSettings-ShowRotationUI 'KeepCoding.Game.PlayerSettings.ShowRotationUI')
  - [ShowScanline](#P-KeepCoding-Game-PlayerSettings-ShowScanline 'KeepCoding.Game.PlayerSettings.ShowScanline')
  - [SkipTitleScreen](#P-KeepCoding-Game-PlayerSettings-SkipTitleScreen 'KeepCoding.Game.PlayerSettings.SkipTitleScreen')
  - [TouchpadInvert](#P-KeepCoding-Game-PlayerSettings-TouchpadInvert 'KeepCoding.Game.PlayerSettings.TouchpadInvert')
  - [UseModsAlways](#P-KeepCoding-Game-PlayerSettings-UseModsAlways 'KeepCoding.Game.PlayerSettings.UseModsAlways')
  - [UseParallelModLoading](#P-KeepCoding-Game-PlayerSettings-UseParallelModLoading 'KeepCoding.Game.PlayerSettings.UseParallelModLoading')
  - [VRModeRequested](#P-KeepCoding-Game-PlayerSettings-VRModeRequested 'KeepCoding.Game.PlayerSettings.VRModeRequested')
  - [VSync](#P-KeepCoding-Game-PlayerSettings-VSync 'KeepCoding.Game.PlayerSettings.VSync')
- [Routine](#T-KeepCoding-Routine 'KeepCoding.Routine')
  - [#ctor(enumerator,monoBehaviour)](#M-KeepCoding-Routine-#ctor-System-Func{System-Collections-IEnumerator},UnityEngine-MonoBehaviour- 'KeepCoding.Routine.#ctor(System.Func{System.Collections.IEnumerator},UnityEngine.MonoBehaviour)')
  - [Restart(oneByOne)](#M-KeepCoding-Routine-Restart-System-Boolean- 'KeepCoding.Routine.Restart(System.Boolean)')
  - [RestartAll(oneByOne)](#M-KeepCoding-Routine-RestartAll-System-Boolean- 'KeepCoding.Routine.RestartAll(System.Boolean)')
  - [Start(allowMultiple,oneByOne)](#M-KeepCoding-Routine-Start-System-Boolean,System-Boolean- 'KeepCoding.Routine.Start(System.Boolean,System.Boolean)')
  - [StartOrRestart(allowMultiple,oneByOne)](#M-KeepCoding-Routine-StartOrRestart-System-Boolean,System-Boolean- 'KeepCoding.Routine.StartOrRestart(System.Boolean,System.Boolean)')
- [RoutineBase](#T-KeepCoding-RoutineBase 'KeepCoding.RoutineBase')
  - [#ctor(monoBehaviour)](#M-KeepCoding-RoutineBase-#ctor-UnityEngine-MonoBehaviour- 'KeepCoding.RoutineBase.#ctor(UnityEngine.MonoBehaviour)')
  - [Coroutines](#P-KeepCoding-RoutineBase-Coroutines 'KeepCoding.RoutineBase.Coroutines')
  - [Count](#P-KeepCoding-RoutineBase-Count 'KeepCoding.RoutineBase.Count')
  - [IsRunning](#P-KeepCoding-RoutineBase-IsRunning 'KeepCoding.RoutineBase.IsRunning')
  - [Item](#P-KeepCoding-RoutineBase-Item-System-Int32- 'KeepCoding.RoutineBase.Item(System.Int32)')
  - [GetEnumerator()](#M-KeepCoding-RoutineBase-GetEnumerator 'KeepCoding.RoutineBase.GetEnumerator')
  - [Stop()](#M-KeepCoding-RoutineBase-Stop 'KeepCoding.RoutineBase.Stop')
  - [StopAll()](#M-KeepCoding-RoutineBase-StopAll 'KeepCoding.RoutineBase.StopAll')
- [Routine\`1](#T-KeepCoding-Routine`1 'KeepCoding.Routine`1')
  - [#ctor(enumerator,monoBehaviour)](#M-KeepCoding-Routine`1-#ctor-System-Func{`0,System-Collections-IEnumerator},UnityEngine-MonoBehaviour- 'KeepCoding.Routine`1.#ctor(System.Func{`0,System.Collections.IEnumerator},UnityEngine.MonoBehaviour)')
  - [Restart(t,oneByOne)](#M-KeepCoding-Routine`1-Restart-`0,System-Boolean- 'KeepCoding.Routine`1.Restart(`0,System.Boolean)')
  - [RestartAll(t,oneByOne)](#M-KeepCoding-Routine`1-RestartAll-`0,System-Boolean- 'KeepCoding.Routine`1.RestartAll(`0,System.Boolean)')
  - [Start(t,allowMultiple,oneByOne)](#M-KeepCoding-Routine`1-Start-`0,System-Boolean,System-Boolean- 'KeepCoding.Routine`1.Start(`0,System.Boolean,System.Boolean)')
  - [StartOrRestart(t,allowMultiple,oneByOne)](#M-KeepCoding-Routine`1-StartOrRestart-`0,System-Boolean,System-Boolean- 'KeepCoding.Routine`1.StartOrRestart(`0,System.Boolean,System.Boolean)')
- [Routine\`2](#T-KeepCoding-Routine`2 'KeepCoding.Routine`2')
  - [#ctor(enumerator,monoBehaviour)](#M-KeepCoding-Routine`2-#ctor-System-Func{`0,`1,System-Collections-IEnumerator},UnityEngine-MonoBehaviour- 'KeepCoding.Routine`2.#ctor(System.Func{`0,`1,System.Collections.IEnumerator},UnityEngine.MonoBehaviour)')
  - [Restart(t1,t2,oneByOne)](#M-KeepCoding-Routine`2-Restart-`0,`1,System-Boolean- 'KeepCoding.Routine`2.Restart(`0,`1,System.Boolean)')
  - [RestartAll(t1,t2,oneByOne)](#M-KeepCoding-Routine`2-RestartAll-`0,`1,System-Boolean- 'KeepCoding.Routine`2.RestartAll(`0,`1,System.Boolean)')
  - [Start(t1,t2,allowMultiple,oneByOne)](#M-KeepCoding-Routine`2-Start-`0,`1,System-Boolean,System-Boolean- 'KeepCoding.Routine`2.Start(`0,`1,System.Boolean,System.Boolean)')
  - [StartOrRestart(t1,t2,allowMultiple,oneByOne)](#M-KeepCoding-Routine`2-StartOrRestart-`0,`1,System-Boolean,System-Boolean- 'KeepCoding.Routine`2.StartOrRestart(`0,`1,System.Boolean,System.Boolean)')
- [Routine\`3](#T-KeepCoding-Routine`3 'KeepCoding.Routine`3')
  - [#ctor(enumerator,monoBehaviour)](#M-KeepCoding-Routine`3-#ctor-System-Func{`0,`1,`2,System-Collections-IEnumerator},UnityEngine-MonoBehaviour- 'KeepCoding.Routine`3.#ctor(System.Func{`0,`1,`2,System.Collections.IEnumerator},UnityEngine.MonoBehaviour)')
  - [Restart(t1,t2,t3,oneByOne)](#M-KeepCoding-Routine`3-Restart-`0,`1,`2,System-Boolean- 'KeepCoding.Routine`3.Restart(`0,`1,`2,System.Boolean)')
  - [RestartAll(t1,t2,t3,oneByOne)](#M-KeepCoding-Routine`3-RestartAll-`0,`1,`2,System-Boolean- 'KeepCoding.Routine`3.RestartAll(`0,`1,`2,System.Boolean)')
  - [Start(t1,t2,t3,allowMultiple,oneByOne)](#M-KeepCoding-Routine`3-Start-`0,`1,`2,System-Boolean,System-Boolean- 'KeepCoding.Routine`3.Start(`0,`1,`2,System.Boolean,System.Boolean)')
  - [StartOrRestart(t1,t2,t3,allowMultiple,oneByOne)](#M-KeepCoding-Routine`3-StartOrRestart-`0,`1,`2,System-Boolean,System-Boolean- 'KeepCoding.Routine`3.StartOrRestart(`0,`1,`2,System.Boolean,System.Boolean)')
- [Routine\`4](#T-KeepCoding-Routine`4 'KeepCoding.Routine`4')
  - [#ctor(enumerator,monoBehaviour)](#M-KeepCoding-Routine`4-#ctor-System-Func{`0,`1,`2,`3,System-Collections-IEnumerator},UnityEngine-MonoBehaviour- 'KeepCoding.Routine`4.#ctor(System.Func{`0,`1,`2,`3,System.Collections.IEnumerator},UnityEngine.MonoBehaviour)')
  - [Restart(t1,t2,t3,t4,oneByOne)](#M-KeepCoding-Routine`4-Restart-`0,`1,`2,`3,System-Boolean- 'KeepCoding.Routine`4.Restart(`0,`1,`2,`3,System.Boolean)')
  - [RestartAll(t1,t2,t3,t4,oneByOne)](#M-KeepCoding-Routine`4-RestartAll-`0,`1,`2,`3,System-Boolean- 'KeepCoding.Routine`4.RestartAll(`0,`1,`2,`3,System.Boolean)')
  - [Start(t1,t2,t3,t4,allowMultiple,oneByOne)](#M-KeepCoding-Routine`4-Start-`0,`1,`2,`3,System-Boolean,System-Boolean- 'KeepCoding.Routine`4.Start(`0,`1,`2,`3,System.Boolean,System.Boolean)')
  - [StartOrRestart(t1,t2,t3,t4,allowMultiple,oneByOne)](#M-KeepCoding-Routine`4-StartOrRestart-`0,`1,`2,`3,System-Boolean,System-Boolean- 'KeepCoding.Routine`4.StartOrRestart(`0,`1,`2,`3,System.Boolean,System.Boolean)')
- [Sound](#T-KeepCoding-Sound 'KeepCoding.Sound')
  - [#ctor(sound)](#M-KeepCoding-Sound-#ctor-System-String- 'KeepCoding.Sound.#ctor(System.String)')
  - [#ctor(sound)](#M-KeepCoding-Sound-#ctor-KMSoundOverride-SoundEffect- 'KeepCoding.Sound.#ctor(KMSoundOverride.SoundEffect)')
  - [#ctor(sound)](#M-KeepCoding-Sound-#ctor-UnityEngine-AudioClip- 'KeepCoding.Sound.#ctor(UnityEngine.AudioClip)')
  - [AlarmClockBeep](#P-KeepCoding-Sound-AlarmClockBeep 'KeepCoding.Sound.AlarmClockBeep')
  - [AlarmClockSnooze](#P-KeepCoding-Sound-AlarmClockSnooze 'KeepCoding.Sound.AlarmClockSnooze')
  - [BigButtonPress](#P-KeepCoding-Sound-BigButtonPress 'KeepCoding.Sound.BigButtonPress')
  - [BigButtonRelease](#P-KeepCoding-Sound-BigButtonRelease 'KeepCoding.Sound.BigButtonRelease')
  - [BinderDrop](#P-KeepCoding-Sound-BinderDrop 'KeepCoding.Sound.BinderDrop')
  - [BombDefused](#P-KeepCoding-Sound-BombDefused 'KeepCoding.Sound.BombDefused')
  - [BombDrop](#P-KeepCoding-Sound-BombDrop 'KeepCoding.Sound.BombDrop')
  - [BombExplode](#P-KeepCoding-Sound-BombExplode 'KeepCoding.Sound.BombExplode')
  - [BriefcaseClose](#P-KeepCoding-Sound-BriefcaseClose 'KeepCoding.Sound.BriefcaseClose')
  - [BriefcaseOpen](#P-KeepCoding-Sound-BriefcaseOpen 'KeepCoding.Sound.BriefcaseOpen')
  - [ButtonPress](#P-KeepCoding-Sound-ButtonPress 'KeepCoding.Sound.ButtonPress')
  - [ButtonRelease](#P-KeepCoding-Sound-ButtonRelease 'KeepCoding.Sound.ButtonRelease')
  - [CapacitorPop](#P-KeepCoding-Sound-CapacitorPop 'KeepCoding.Sound.CapacitorPop')
  - [CorrectChime](#P-KeepCoding-Sound-CorrectChime 'KeepCoding.Sound.CorrectChime')
  - [Custom](#P-KeepCoding-Sound-Custom 'KeepCoding.Sound.Custom')
  - [DossierOptionPressed](#P-KeepCoding-Sound-DossierOptionPressed 'KeepCoding.Sound.DossierOptionPressed')
  - [EmergencyAlarm](#P-KeepCoding-Sound-EmergencyAlarm 'KeepCoding.Sound.EmergencyAlarm')
  - [FastTimerBeep](#P-KeepCoding-Sound-FastTimerBeep 'KeepCoding.Sound.FastTimerBeep')
  - [FastestTimerBeep](#P-KeepCoding-Sound-FastestTimerBeep 'KeepCoding.Sound.FastestTimerBeep')
  - [FreeplayDeviceDrop](#P-KeepCoding-Sound-FreeplayDeviceDrop 'KeepCoding.Sound.FreeplayDeviceDrop')
  - [Game](#P-KeepCoding-Sound-Game 'KeepCoding.Sound.Game')
  - [GameOverFanfare](#P-KeepCoding-Sound-GameOverFanfare 'KeepCoding.Sound.GameOverFanfare')
  - [LightBuzz](#P-KeepCoding-Sound-LightBuzz 'KeepCoding.Sound.LightBuzz')
  - [LightBuzzShort](#P-KeepCoding-Sound-LightBuzzShort 'KeepCoding.Sound.LightBuzzShort')
  - [MenuButtonPressed](#P-KeepCoding-Sound-MenuButtonPressed 'KeepCoding.Sound.MenuButtonPressed')
  - [MenuDrop](#P-KeepCoding-Sound-MenuDrop 'KeepCoding.Sound.MenuDrop')
  - [NeedyActivated](#P-KeepCoding-Sound-NeedyActivated 'KeepCoding.Sound.NeedyActivated')
  - [NeedyWarning](#P-KeepCoding-Sound-NeedyWarning 'KeepCoding.Sound.NeedyWarning')
  - [NormalTimerBeep](#P-KeepCoding-Sound-NormalTimerBeep 'KeepCoding.Sound.NormalTimerBeep')
  - [PageTurn](#P-KeepCoding-Sound-PageTurn 'KeepCoding.Sound.PageTurn')
  - [Reference](#P-KeepCoding-Sound-Reference 'KeepCoding.Sound.Reference')
  - [SelectionTick](#P-KeepCoding-Sound-SelectionTick 'KeepCoding.Sound.SelectionTick')
  - [Stamp](#P-KeepCoding-Sound-Stamp 'KeepCoding.Sound.Stamp')
  - [Strike](#P-KeepCoding-Sound-Strike 'KeepCoding.Sound.Strike')
  - [Switch](#P-KeepCoding-Sound-Switch 'KeepCoding.Sound.Switch')
  - [TitleMenuPressed](#P-KeepCoding-Sound-TitleMenuPressed 'KeepCoding.Sound.TitleMenuPressed')
  - [TypewriterKey](#P-KeepCoding-Sound-TypewriterKey 'KeepCoding.Sound.TypewriterKey')
  - [WireSequenceMechanism](#P-KeepCoding-Sound-WireSequenceMechanism 'KeepCoding.Sound.WireSequenceMechanism')
  - [WireSnip](#P-KeepCoding-Sound-WireSnip 'KeepCoding.Sound.WireSnip')
  - [Equals(obj)](#M-KeepCoding-Sound-Equals-System-Object- 'KeepCoding.Sound.Equals(System.Object)')
  - [Equals(other)](#M-KeepCoding-Sound-Equals-KeepCoding-Sound- 'KeepCoding.Sound.Equals(KeepCoding.Sound)')
  - [GetHashCode()](#M-KeepCoding-Sound-GetHashCode 'KeepCoding.Sound.GetHashCode')
  - [Method(audio)](#M-KeepCoding-Sound-Method-KMAudio- 'KeepCoding.Sound.Method(KMAudio)')
  - [StopSound()](#M-KeepCoding-Sound-StopSound 'KeepCoding.Sound.StopSound')
  - [ToString()](#M-KeepCoding-Sound-ToString 'KeepCoding.Sound.ToString')
  - [op_Explicit(sound)](#M-KeepCoding-Sound-op_Explicit-KeepCoding-Sound-~System-String 'KeepCoding.Sound.op_Explicit(KeepCoding.Sound)~System.String')
  - [op_Explicit(sound)](#M-KeepCoding-Sound-op_Explicit-KeepCoding-Sound-~System-Nullable{KMSoundOverride-SoundEffect} 'KeepCoding.Sound.op_Explicit(KeepCoding.Sound)~System.Nullable{KMSoundOverride.SoundEffect}')
  - [op_Explicit(sound)](#M-KeepCoding-Sound-op_Explicit-KeepCoding-Sound-~KMSoundOverride-SoundEffect 'KeepCoding.Sound.op_Explicit(KeepCoding.Sound)~KMSoundOverride.SoundEffect')
  - [op_Implicit(sound)](#M-KeepCoding-Sound-op_Implicit-System-String-~KeepCoding-Sound 'KeepCoding.Sound.op_Implicit(System.String)~KeepCoding.Sound')
  - [op_Implicit(sound)](#M-KeepCoding-Sound-op_Implicit-UnityEngine-AudioClip-~KeepCoding-Sound 'KeepCoding.Sound.op_Implicit(UnityEngine.AudioClip)~KeepCoding.Sound')
  - [op_Implicit(sound)](#M-KeepCoding-Sound-op_Implicit-KMSoundOverride-SoundEffect-~KeepCoding-Sound 'KeepCoding.Sound.op_Implicit(KMSoundOverride.SoundEffect)~KeepCoding.Sound')
- [SpecialComponentTypeEnum](#T-KeepCoding-ComponentPool-SpecialComponentTypeEnum 'KeepCoding.ComponentPool.SpecialComponentTypeEnum')
  - [ALL_NEEDY](#F-KeepCoding-ComponentPool-SpecialComponentTypeEnum-ALL_NEEDY 'KeepCoding.ComponentPool.SpecialComponentTypeEnum.ALL_NEEDY')
  - [ALL_SOLVABLE](#F-KeepCoding-ComponentPool-SpecialComponentTypeEnum-ALL_SOLVABLE 'KeepCoding.ComponentPool.SpecialComponentTypeEnum.ALL_SOLVABLE')
  - [None](#F-KeepCoding-ComponentPool-SpecialComponentTypeEnum-None 'KeepCoding.ComponentPool.SpecialComponentTypeEnum.None')
- [TPScriptEditor](#T-KeepCoding-TPScriptEditor 'KeepCoding.TPScriptEditor')
  - [OnInspectorGUI()](#M-KeepCoding-TPScriptEditor-OnInspectorGUI 'KeepCoding.TPScriptEditor.OnInspectorGUI')
- [TPScript\`1](#T-KeepCoding-TPScript`1 'KeepCoding.TPScript`1')
  - [AutoSolve](#F-KeepCoding-TPScript`1-AutoSolve 'KeepCoding.TPScript`1.AutoSolve')
  - [CancelDetonate](#F-KeepCoding-TPScript`1-CancelDetonate 'KeepCoding.TPScript`1.CancelDetonate')
  - [Cancelled](#F-KeepCoding-TPScript`1-Cancelled 'KeepCoding.TPScript`1.Cancelled')
  - [EndMultipleStrikes](#F-KeepCoding-TPScript`1-EndMultipleStrikes 'KeepCoding.TPScript`1.EndMultipleStrikes')
  - [EndWaitingMusic](#F-KeepCoding-TPScript`1-EndWaitingMusic 'KeepCoding.TPScript`1.EndWaitingMusic')
  - [HideCamera](#F-KeepCoding-TPScript`1-HideCamera 'KeepCoding.TPScript`1.HideCamera')
  - [MultipleStrikes](#F-KeepCoding-TPScript`1-MultipleStrikes 'KeepCoding.TPScript`1.MultipleStrikes')
  - [Solve](#F-KeepCoding-TPScript`1-Solve 'KeepCoding.TPScript`1.Solve')
  - [Strike](#F-KeepCoding-TPScript`1-Strike 'KeepCoding.TPScript`1.Strike')
  - [ToggleWaitingMusic](#F-KeepCoding-TPScript`1-ToggleWaitingMusic 'KeepCoding.TPScript`1.ToggleWaitingMusic')
  - [TryCancelSequence](#F-KeepCoding-TPScript`1-TryCancelSequence 'KeepCoding.TPScript`1.TryCancelSequence')
  - [UnsubmittablePenalty](#F-KeepCoding-TPScript`1-UnsubmittablePenalty 'KeepCoding.TPScript`1.UnsubmittablePenalty')
  - [WaitingMusic](#F-KeepCoding-TPScript`1-WaitingMusic 'KeepCoding.TPScript`1.WaitingMusic')
  - [Abandons](#P-KeepCoding-TPScript`1-Abandons 'KeepCoding.TPScript`1.Abandons')
  - [Help](#P-KeepCoding-TPScript`1-Help 'KeepCoding.TPScript`1.Help')
  - [IsCancelCommand](#P-KeepCoding-TPScript`1-IsCancelCommand 'KeepCoding.TPScript`1.IsCancelCommand')
  - [IsTP](#P-KeepCoding-TPScript`1-IsTP 'KeepCoding.TPScript`1.IsTP')
  - [IsTime](#P-KeepCoding-TPScript`1-IsTime 'KeepCoding.TPScript`1.IsTime')
  - [IsTimeSkippable](#P-KeepCoding-TPScript`1-IsTimeSkippable 'KeepCoding.TPScript`1.IsTimeSkippable')
  - [IsZen](#P-KeepCoding-TPScript`1-IsZen 'KeepCoding.TPScript`1.IsZen')
  - [Manual](#P-KeepCoding-TPScript`1-Manual 'KeepCoding.TPScript`1.Manual')
  - [Module](#P-KeepCoding-TPScript`1-Module 'KeepCoding.TPScript`1.Module')
  - [AwardPoints(points)](#M-KeepCoding-TPScript`1-AwardPoints-System-Int32- 'KeepCoding.TPScript`1.AwardPoints(System.Int32)')
  - [AwardPointsOnSolve(points)](#M-KeepCoding-TPScript`1-AwardPointsOnSolve-System-Int32- 'KeepCoding.TPScript`1.AwardPointsOnSolve(System.Int32)')
  - [Detonate(time,message)](#M-KeepCoding-TPScript`1-Detonate-System-Nullable{System-Single},System-String- 'KeepCoding.TPScript`1.Detonate(System.Nullable{System.Single},System.String)')
  - [Evaluate\`\`1(condition,then,otherwise)](#M-KeepCoding-TPScript`1-Evaluate``1-System-Boolean,``0,System-Object- 'KeepCoding.TPScript`1.Evaluate``1(System.Boolean,``0,System.Object)')
  - [ForceSolve()](#M-KeepCoding-TPScript`1-ForceSolve 'KeepCoding.TPScript`1.ForceSolve')
  - [IsMatch(input,pattern,lenient,options)](#M-KeepCoding-TPScript`1-IsMatch-System-String,System-String,System-Boolean,System-Text-RegularExpressions-RegexOptions- 'KeepCoding.TPScript`1.IsMatch(System.String,System.String,System.Boolean,System.Text.RegularExpressions.RegexOptions)')
  - [OnInteractSequence(selectables,indices,wait)](#M-KeepCoding-TPScript`1-OnInteractSequence-KMSelectable[],System-Single,System-Int32[]- 'KeepCoding.TPScript`1.OnInteractSequence(KMSelectable[],System.Single,System.Int32[])')
  - [Process(command)](#M-KeepCoding-TPScript`1-Process-System-String- 'KeepCoding.TPScript`1.Process(System.String)')
  - [SendDelayedMessage(time,message)](#M-KeepCoding-TPScript`1-SendDelayedMessage-System-Single,System-String- 'KeepCoding.TPScript`1.SendDelayedMessage(System.Single,System.String)')
  - [SendToChat(message)](#M-KeepCoding-TPScript`1-SendToChat-System-String- 'KeepCoding.TPScript`1.SendToChat(System.String)')
  - [SendToChatError(message)](#M-KeepCoding-TPScript`1-SendToChatError-System-String- 'KeepCoding.TPScript`1.SendToChatError(System.String)')
  - [SkipTime(seconds)](#M-KeepCoding-TPScript`1-SkipTime-System-String- 'KeepCoding.TPScript`1.SkipTime(System.String)')
  - [StrikeMessage(message)](#M-KeepCoding-TPScript`1-StrikeMessage-System-String- 'KeepCoding.TPScript`1.StrikeMessage(System.String)')
  - [TryCancel(message)](#M-KeepCoding-TPScript`1-TryCancel-System-String- 'KeepCoding.TPScript`1.TryCancel(System.String)')
  - [TryWaitCancel(time,message)](#M-KeepCoding-TPScript`1-TryWaitCancel-System-Single,System-String- 'KeepCoding.TPScript`1.TryWaitCancel(System.Single,System.String)')
  - [YieldUntil\`\`1(item,condition)](#M-KeepCoding-TPScript`1-YieldUntil``1-``0,System-Func{System-Boolean}- 'KeepCoding.TPScript`1.YieldUntil``1(``0,System.Func{System.Boolean})')
  - [YieldWhile\`\`1(item,condition)](#M-KeepCoding-TPScript`1-YieldWhile``1-``0,System-Func{System-Boolean}- 'KeepCoding.TPScript`1.YieldWhile``1(``0,System.Func{System.Boolean})')
- [TupleBase](#T-KeepCoding-TupleBase 'KeepCoding.TupleBase')
  - [IsEmpty](#P-KeepCoding-TupleBase-IsEmpty 'KeepCoding.TupleBase.IsEmpty')
  - [Item](#P-KeepCoding-TupleBase-Item-System-Byte- 'KeepCoding.TupleBase.Item(System.Byte)')
  - [Length](#P-KeepCoding-TupleBase-Length 'KeepCoding.TupleBase.Length')
  - [ToArray](#P-KeepCoding-TupleBase-ToArray 'KeepCoding.TupleBase.ToArray')
  - [UpperBound](#P-KeepCoding-TupleBase-UpperBound 'KeepCoding.TupleBase.UpperBound')
  - [GetEnumerator()](#M-KeepCoding-TupleBase-GetEnumerator 'KeepCoding.TupleBase.GetEnumerator')
- [Tuple\`1](#T-KeepCoding-Tuple`1 'KeepCoding.Tuple`1')
  - [#ctor(item1)](#M-KeepCoding-Tuple`1-#ctor-`0- 'KeepCoding.Tuple`1.#ctor(`0)')
  - [#ctor()](#M-KeepCoding-Tuple`1-#ctor 'KeepCoding.Tuple`1.#ctor')
  - [Item](#P-KeepCoding-Tuple`1-Item-System-Byte- 'KeepCoding.Tuple`1.Item(System.Byte)')
  - [Item1](#P-KeepCoding-Tuple`1-Item1 'KeepCoding.Tuple`1.Item1')
  - [ToArray](#P-KeepCoding-Tuple`1-ToArray 'KeepCoding.Tuple`1.ToArray')
  - [Destruct(item)](#M-KeepCoding-Tuple`1-Destruct-`0@- 'KeepCoding.Tuple`1.Destruct(`0@)')
  - [Equals(obj)](#M-KeepCoding-Tuple`1-Equals-System-Object- 'KeepCoding.Tuple`1.Equals(System.Object)')
  - [Equals(other)](#M-KeepCoding-Tuple`1-Equals-KeepCoding-Tuple{`0}- 'KeepCoding.Tuple`1.Equals(KeepCoding.Tuple{`0})')
  - [GetHashCode()](#M-KeepCoding-Tuple`1-GetHashCode 'KeepCoding.Tuple`1.GetHashCode')
  - [ToString()](#M-KeepCoding-Tuple`1-ToString 'KeepCoding.Tuple`1.ToString')
  - [op_Equality(tupleA,tupleB)](#M-KeepCoding-Tuple`1-op_Equality-KeepCoding-Tuple{`0},KeepCoding-Tuple{`0}- 'KeepCoding.Tuple`1.op_Equality(KeepCoding.Tuple{`0},KeepCoding.Tuple{`0})')
  - [op_Inequality(tupleA,tupleB)](#M-KeepCoding-Tuple`1-op_Inequality-KeepCoding-Tuple{`0},KeepCoding-Tuple{`0}- 'KeepCoding.Tuple`1.op_Inequality(KeepCoding.Tuple{`0},KeepCoding.Tuple{`0})')
- [Tuple\`2](#T-KeepCoding-Tuple`2 'KeepCoding.Tuple`2')
  - [#ctor(item1,item2)](#M-KeepCoding-Tuple`2-#ctor-`0,`1- 'KeepCoding.Tuple`2.#ctor(`0,`1)')
  - [#ctor()](#M-KeepCoding-Tuple`2-#ctor 'KeepCoding.Tuple`2.#ctor')
  - [Item](#P-KeepCoding-Tuple`2-Item-System-Byte- 'KeepCoding.Tuple`2.Item(System.Byte)')
  - [Item2](#P-KeepCoding-Tuple`2-Item2 'KeepCoding.Tuple`2.Item2')
  - [ToArray](#P-KeepCoding-Tuple`2-ToArray 'KeepCoding.Tuple`2.ToArray')
  - [Destruct(item1,item2)](#M-KeepCoding-Tuple`2-Destruct-`0@,`1@- 'KeepCoding.Tuple`2.Destruct(`0@,`1@)')
  - [Equals(obj)](#M-KeepCoding-Tuple`2-Equals-System-Object- 'KeepCoding.Tuple`2.Equals(System.Object)')
  - [Equals(other)](#M-KeepCoding-Tuple`2-Equals-KeepCoding-Tuple{`0,`1}- 'KeepCoding.Tuple`2.Equals(KeepCoding.Tuple{`0,`1})')
  - [GetHashCode()](#M-KeepCoding-Tuple`2-GetHashCode 'KeepCoding.Tuple`2.GetHashCode')
  - [ToString()](#M-KeepCoding-Tuple`2-ToString 'KeepCoding.Tuple`2.ToString')
  - [op_Equality(tupleA,tupleB)](#M-KeepCoding-Tuple`2-op_Equality-KeepCoding-Tuple{`0,`1},KeepCoding-Tuple{`0,`1}- 'KeepCoding.Tuple`2.op_Equality(KeepCoding.Tuple{`0,`1},KeepCoding.Tuple{`0,`1})')
  - [op_Inequality(tupleA,tupleB)](#M-KeepCoding-Tuple`2-op_Inequality-KeepCoding-Tuple{`0,`1},KeepCoding-Tuple{`0,`1}- 'KeepCoding.Tuple`2.op_Inequality(KeepCoding.Tuple{`0,`1},KeepCoding.Tuple{`0,`1})')
- [Tuple\`3](#T-KeepCoding-Tuple`3 'KeepCoding.Tuple`3')
  - [#ctor(item1,item2,item3)](#M-KeepCoding-Tuple`3-#ctor-`0,`1,`2- 'KeepCoding.Tuple`3.#ctor(`0,`1,`2)')
  - [#ctor()](#M-KeepCoding-Tuple`3-#ctor 'KeepCoding.Tuple`3.#ctor')
  - [Item](#P-KeepCoding-Tuple`3-Item-System-Byte- 'KeepCoding.Tuple`3.Item(System.Byte)')
  - [Item3](#P-KeepCoding-Tuple`3-Item3 'KeepCoding.Tuple`3.Item3')
  - [ToArray](#P-KeepCoding-Tuple`3-ToArray 'KeepCoding.Tuple`3.ToArray')
  - [Destruct(item1,item2,item3)](#M-KeepCoding-Tuple`3-Destruct-`0@,`1@,`2@- 'KeepCoding.Tuple`3.Destruct(`0@,`1@,`2@)')
  - [Equals(obj)](#M-KeepCoding-Tuple`3-Equals-System-Object- 'KeepCoding.Tuple`3.Equals(System.Object)')
  - [Equals(other)](#M-KeepCoding-Tuple`3-Equals-KeepCoding-Tuple{`0,`1,`2}- 'KeepCoding.Tuple`3.Equals(KeepCoding.Tuple{`0,`1,`2})')
  - [GetHashCode()](#M-KeepCoding-Tuple`3-GetHashCode 'KeepCoding.Tuple`3.GetHashCode')
  - [ToString()](#M-KeepCoding-Tuple`3-ToString 'KeepCoding.Tuple`3.ToString')
  - [op_Equality(tupleA,tupleB)](#M-KeepCoding-Tuple`3-op_Equality-KeepCoding-Tuple{`0,`1,`2},KeepCoding-Tuple{`0,`1,`2}- 'KeepCoding.Tuple`3.op_Equality(KeepCoding.Tuple{`0,`1,`2},KeepCoding.Tuple{`0,`1,`2})')
  - [op_Inequality(tupleA,tupleB)](#M-KeepCoding-Tuple`3-op_Inequality-KeepCoding-Tuple{`0,`1,`2},KeepCoding-Tuple{`0,`1,`2}- 'KeepCoding.Tuple`3.op_Inequality(KeepCoding.Tuple{`0,`1,`2},KeepCoding.Tuple{`0,`1,`2})')
- [Tuple\`4](#T-KeepCoding-Tuple`4 'KeepCoding.Tuple`4')
  - [#ctor(item1,item2,item3,item4)](#M-KeepCoding-Tuple`4-#ctor-`0,`1,`2,`3- 'KeepCoding.Tuple`4.#ctor(`0,`1,`2,`3)')
  - [#ctor()](#M-KeepCoding-Tuple`4-#ctor 'KeepCoding.Tuple`4.#ctor')
  - [Item](#P-KeepCoding-Tuple`4-Item-System-Byte- 'KeepCoding.Tuple`4.Item(System.Byte)')
  - [Item4](#P-KeepCoding-Tuple`4-Item4 'KeepCoding.Tuple`4.Item4')
  - [ToArray](#P-KeepCoding-Tuple`4-ToArray 'KeepCoding.Tuple`4.ToArray')
  - [Destruct(item1,item2,item3,item4)](#M-KeepCoding-Tuple`4-Destruct-`0@,`1@,`2@,`3@- 'KeepCoding.Tuple`4.Destruct(`0@,`1@,`2@,`3@)')
  - [Equals(obj)](#M-KeepCoding-Tuple`4-Equals-System-Object- 'KeepCoding.Tuple`4.Equals(System.Object)')
  - [Equals(other)](#M-KeepCoding-Tuple`4-Equals-KeepCoding-Tuple{`0,`1,`2,`3}- 'KeepCoding.Tuple`4.Equals(KeepCoding.Tuple{`0,`1,`2,`3})')
  - [GetHashCode()](#M-KeepCoding-Tuple`4-GetHashCode 'KeepCoding.Tuple`4.GetHashCode')
  - [ToString()](#M-KeepCoding-Tuple`4-ToString 'KeepCoding.Tuple`4.ToString')
  - [op_Equality(tupleA,tupleB)](#M-KeepCoding-Tuple`4-op_Equality-KeepCoding-Tuple{`0,`1,`2,`3},KeepCoding-Tuple{`0,`1,`2,`3}- 'KeepCoding.Tuple`4.op_Equality(KeepCoding.Tuple{`0,`1,`2,`3},KeepCoding.Tuple{`0,`1,`2,`3})')
  - [op_Inequality(tupleA,tupleB)](#M-KeepCoding-Tuple`4-op_Inequality-KeepCoding-Tuple{`0,`1,`2,`3},KeepCoding-Tuple{`0,`1,`2,`3}- 'KeepCoding.Tuple`4.op_Inequality(KeepCoding.Tuple{`0,`1,`2,`3},KeepCoding.Tuple{`0,`1,`2,`3})')
- [TypeHelper](#T-KeepCoding-TypeHelper 'KeepCoding.TypeHelper')
  - [Add(color,r,g,b,a)](#M-KeepCoding-TypeHelper-Add-UnityEngine-Color,System-Single,System-Single,System-Single,System-Single- 'KeepCoding.TypeHelper.Add(UnityEngine.Color,System.Single,System.Single,System.Single,System.Single)')
  - [Add(color,r,g,b,a)](#M-KeepCoding-TypeHelper-Add-UnityEngine-Color,System-Byte,System-Byte,System-Byte,System-Byte- 'KeepCoding.TypeHelper.Add(UnityEngine.Color,System.Byte,System.Byte,System.Byte,System.Byte)')
  - [Add(color,r,g,b,a)](#M-KeepCoding-TypeHelper-Add-UnityEngine-Color32,System-Single,System-Single,System-Single,System-Single- 'KeepCoding.TypeHelper.Add(UnityEngine.Color32,System.Single,System.Single,System.Single,System.Single)')
  - [Add(color,r,g,b,a)](#M-KeepCoding-TypeHelper-Add-UnityEngine-Color32,System-Byte,System-Byte,System-Byte,System-Byte- 'KeepCoding.TypeHelper.Add(UnityEngine.Color32,System.Byte,System.Byte,System.Byte,System.Byte)')
  - [Add(vector,x,y)](#M-KeepCoding-TypeHelper-Add-UnityEngine-Vector2@,System-Single,System-Single- 'KeepCoding.TypeHelper.Add(UnityEngine.Vector2@,System.Single,System.Single)')
  - [Add(vector,x,y)](#M-KeepCoding-TypeHelper-Add-UnityEngine-Vector2,System-Single,System-Single- 'KeepCoding.TypeHelper.Add(UnityEngine.Vector2,System.Single,System.Single)')
  - [Add(vector,x,y,z)](#M-KeepCoding-TypeHelper-Add-UnityEngine-Vector3@,System-Single,System-Single,System-Single- 'KeepCoding.TypeHelper.Add(UnityEngine.Vector3@,System.Single,System.Single,System.Single)')
  - [Add(vector,x,y,z)](#M-KeepCoding-TypeHelper-Add-UnityEngine-Vector3,System-Single,System-Single,System-Single- 'KeepCoding.TypeHelper.Add(UnityEngine.Vector3,System.Single,System.Single,System.Single)')
  - [Add(vector,x,y,z,w)](#M-KeepCoding-TypeHelper-Add-UnityEngine-Vector4@,System-Single,System-Single,System-Single,System-Single- 'KeepCoding.TypeHelper.Add(UnityEngine.Vector4@,System.Single,System.Single,System.Single,System.Single)')
  - [Add(vector,x,y,z,w)](#M-KeepCoding-TypeHelper-Add-UnityEngine-Vector4,System-Single,System-Single,System-Single,System-Single- 'KeepCoding.TypeHelper.Add(UnityEngine.Vector4,System.Single,System.Single,System.Single,System.Single)')
  - [HexToColor(hex)](#M-KeepCoding-TypeHelper-HexToColor-System-String- 'KeepCoding.TypeHelper.HexToColor(System.String)')
  - [IntertwineColor(colorA,colorB,concentrationOfB)](#M-KeepCoding-TypeHelper-IntertwineColor-UnityEngine-Color,UnityEngine-Color,System-Single- 'KeepCoding.TypeHelper.IntertwineColor(UnityEngine.Color,UnityEngine.Color,System.Single)')
  - [IntertwineColor(renderer,colorA,colorB,concentrationOfB)](#M-KeepCoding-TypeHelper-IntertwineColor-UnityEngine-Renderer,UnityEngine-Color,UnityEngine-Color,System-Single- 'KeepCoding.TypeHelper.IntertwineColor(UnityEngine.Renderer,UnityEngine.Color,UnityEngine.Color,System.Single)')
  - [IntertwineColor(colorA,colorB,concentrationOfB)](#M-KeepCoding-TypeHelper-IntertwineColor-UnityEngine-Color32,UnityEngine-Color32,System-Single- 'KeepCoding.TypeHelper.IntertwineColor(UnityEngine.Color32,UnityEngine.Color32,System.Single)')
  - [IntertwineColor(renderer,colorA,colorB,concentrationOfB)](#M-KeepCoding-TypeHelper-IntertwineColor-UnityEngine-Renderer,UnityEngine-Color32,UnityEngine-Color32,System-Single- 'KeepCoding.TypeHelper.IntertwineColor(UnityEngine.Renderer,UnityEngine.Color32,UnityEngine.Color32,System.Single)')
  - [IsAnyEqual(colors,color)](#M-KeepCoding-TypeHelper-IsAnyEqual-UnityEngine-Color32[],UnityEngine-Color32- 'KeepCoding.TypeHelper.IsAnyEqual(UnityEngine.Color32[],UnityEngine.Color32)')
  - [IsAnyEqual(colors,color)](#M-KeepCoding-TypeHelper-IsAnyEqual-UnityEngine-Color[],UnityEngine-Color- 'KeepCoding.TypeHelper.IsAnyEqual(UnityEngine.Color[],UnityEngine.Color)')
  - [IsEqual(colorA,colorB)](#M-KeepCoding-TypeHelper-IsEqual-UnityEngine-Color32,UnityEngine-Color32- 'KeepCoding.TypeHelper.IsEqual(UnityEngine.Color32,UnityEngine.Color32)')
  - [IsEqual(colorA,colorB)](#M-KeepCoding-TypeHelper-IsEqual-UnityEngine-Color,UnityEngine-Color- 'KeepCoding.TypeHelper.IsEqual(UnityEngine.Color,UnityEngine.Color)')
  - [Set(color,r,g,b,a)](#M-KeepCoding-TypeHelper-Set-UnityEngine-Color,System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single}- 'KeepCoding.TypeHelper.Set(UnityEngine.Color,System.Nullable{System.Single},System.Nullable{System.Single},System.Nullable{System.Single},System.Nullable{System.Single})')
  - [Set(color,r,g,b,a)](#M-KeepCoding-TypeHelper-Set-UnityEngine-Color,System-Nullable{System-Byte},System-Nullable{System-Byte},System-Nullable{System-Byte},System-Nullable{System-Byte}- 'KeepCoding.TypeHelper.Set(UnityEngine.Color,System.Nullable{System.Byte},System.Nullable{System.Byte},System.Nullable{System.Byte},System.Nullable{System.Byte})')
  - [Set(color,r,g,b,a)](#M-KeepCoding-TypeHelper-Set-UnityEngine-Color32,System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single}- 'KeepCoding.TypeHelper.Set(UnityEngine.Color32,System.Nullable{System.Single},System.Nullable{System.Single},System.Nullable{System.Single},System.Nullable{System.Single})')
  - [Set(color,r,g,b,a)](#M-KeepCoding-TypeHelper-Set-UnityEngine-Color32,System-Nullable{System-Byte},System-Nullable{System-Byte},System-Nullable{System-Byte},System-Nullable{System-Byte}- 'KeepCoding.TypeHelper.Set(UnityEngine.Color32,System.Nullable{System.Byte},System.Nullable{System.Byte},System.Nullable{System.Byte},System.Nullable{System.Byte})')
  - [Set(vector,x,y)](#M-KeepCoding-TypeHelper-Set-UnityEngine-Vector2@,System-Nullable{System-Single},System-Nullable{System-Single}- 'KeepCoding.TypeHelper.Set(UnityEngine.Vector2@,System.Nullable{System.Single},System.Nullable{System.Single})')
  - [Set(vector,x,y)](#M-KeepCoding-TypeHelper-Set-UnityEngine-Vector2,System-Nullable{System-Single},System-Nullable{System-Single}- 'KeepCoding.TypeHelper.Set(UnityEngine.Vector2,System.Nullable{System.Single},System.Nullable{System.Single})')
  - [Set(vector,x,y,z)](#M-KeepCoding-TypeHelper-Set-UnityEngine-Vector3@,System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single}- 'KeepCoding.TypeHelper.Set(UnityEngine.Vector3@,System.Nullable{System.Single},System.Nullable{System.Single},System.Nullable{System.Single})')
  - [Set(vector,x,y,z)](#M-KeepCoding-TypeHelper-Set-UnityEngine-Vector3,System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single}- 'KeepCoding.TypeHelper.Set(UnityEngine.Vector3,System.Nullable{System.Single},System.Nullable{System.Single},System.Nullable{System.Single})')
  - [Set(vector,x,y,z,w)](#M-KeepCoding-TypeHelper-Set-UnityEngine-Vector4@,System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single}- 'KeepCoding.TypeHelper.Set(UnityEngine.Vector4@,System.Nullable{System.Single},System.Nullable{System.Single},System.Nullable{System.Single},System.Nullable{System.Single})')
  - [Set(vector,x,y,z,w)](#M-KeepCoding-TypeHelper-Set-UnityEngine-Vector4,System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single}- 'KeepCoding.TypeHelper.Set(UnityEngine.Vector4,System.Nullable{System.Single},System.Nullable{System.Single},System.Nullable{System.Single},System.Nullable{System.Single})')
  - [ToLogger\`\`1(_,name,showId)](#M-KeepCoding-TypeHelper-ToLogger``1-``0,System-String,System-Boolean- 'KeepCoding.TypeHelper.ToLogger``1(``0,System.String,System.Boolean)')
  - [ToRoutine(func,monoBehaviour)](#M-KeepCoding-TypeHelper-ToRoutine-UnityEngine-MonoBehaviour,System-Func{System-Collections-IEnumerator}- 'KeepCoding.TypeHelper.ToRoutine(UnityEngine.MonoBehaviour,System.Func{System.Collections.IEnumerator})')
  - [ToRoutine\`\`1(func,monoBehaviour)](#M-KeepCoding-TypeHelper-ToRoutine``1-UnityEngine-MonoBehaviour,System-Func{``0,System-Collections-IEnumerator}- 'KeepCoding.TypeHelper.ToRoutine``1(UnityEngine.MonoBehaviour,System.Func{``0,System.Collections.IEnumerator})')
  - [ToRoutine\`\`2(func,monoBehaviour)](#M-KeepCoding-TypeHelper-ToRoutine``2-UnityEngine-MonoBehaviour,System-Func{``0,``1,System-Collections-IEnumerator}- 'KeepCoding.TypeHelper.ToRoutine``2(UnityEngine.MonoBehaviour,System.Func{``0,``1,System.Collections.IEnumerator})')
  - [ToRoutine\`\`3(func,monoBehaviour)](#M-KeepCoding-TypeHelper-ToRoutine``3-UnityEngine-MonoBehaviour,System-Func{``0,``1,``2,System-Collections-IEnumerator}- 'KeepCoding.TypeHelper.ToRoutine``3(UnityEngine.MonoBehaviour,System.Func{``0,``1,``2,System.Collections.IEnumerator})')
  - [ToRoutine\`\`4(func,monoBehaviour)](#M-KeepCoding-TypeHelper-ToRoutine``4-UnityEngine-MonoBehaviour,System-Func{``0,``1,``2,``3,System-Collections-IEnumerator}- 'KeepCoding.TypeHelper.ToRoutine``4(UnityEngine.MonoBehaviour,System.Func{``0,``1,``2,``3,System.Collections.IEnumerator})')
  - [ToTuple\`\`1(item)](#M-KeepCoding-TypeHelper-ToTuple``1-``0- 'KeepCoding.TypeHelper.ToTuple``1(``0)')
  - [ToTuple\`\`2(item1,item2)](#M-KeepCoding-TypeHelper-ToTuple``2-``0,``1- 'KeepCoding.TypeHelper.ToTuple``2(``0,``1)')
  - [ToTuple\`\`3(item1,item2,item3)](#M-KeepCoding-TypeHelper-ToTuple``3-``0,``1,``2- 'KeepCoding.TypeHelper.ToTuple``3(``0,``1,``2)')
  - [ToTuple\`\`4(item1,item2,item3,item4)](#M-KeepCoding-TypeHelper-ToTuple``4-``0,``1,``2,``3- 'KeepCoding.TypeHelper.ToTuple``4(``0,``1,``2,``3)')
  - [ToVersion(s)](#M-KeepCoding-TypeHelper-ToVersion-System-String- 'KeepCoding.TypeHelper.ToVersion(System.String)')
  - [ToWork(action,allowSimultaneousActive,maximumThreadsActive)](#M-KeepCoding-TypeHelper-ToWork-System-UInt32,System-Action,System-Boolean- 'KeepCoding.TypeHelper.ToWork(System.UInt32,System.Action,System.Boolean)')
  - [ToWork\`\`1(func,allowSimultaneousActive,maximumThreadsActive)](#M-KeepCoding-TypeHelper-ToWork``1-System-UInt32,System-Func{``0},System-Boolean- 'KeepCoding.TypeHelper.ToWork``1(System.UInt32,System.Func{``0},System.Boolean)')
  - [ToWork\`\`2(func,allowSimultaneousActive,maximumThreadsActive)](#M-KeepCoding-TypeHelper-ToWork``2-System-UInt32,System-Func{``0,``1},System-Boolean- 'KeepCoding.TypeHelper.ToWork``2(System.UInt32,System.Func{``0,``1},System.Boolean)')
  - [ToWork\`\`3(func,allowSimultaneousActive,maximumThreadsActive)](#M-KeepCoding-TypeHelper-ToWork``3-System-UInt32,System-Func{``0,``1,``2},System-Boolean- 'KeepCoding.TypeHelper.ToWork``3(System.UInt32,System.Func{``0,``1,``2},System.Boolean)')
  - [ToWork\`\`4(func,allowSimultaneousActive,maximumThreadsActive)](#M-KeepCoding-TypeHelper-ToWork``4-System-UInt32,System-Func{``0,``1,``2,``3},System-Boolean- 'KeepCoding.TypeHelper.ToWork``4(System.UInt32,System.Func{``0,``1,``2,``3},System.Boolean)')
  - [ToWork\`\`5(func,allowSimultaneousActive,maximumThreadsActive)](#M-KeepCoding-TypeHelper-ToWork``5-System-UInt32,System-Func{``0,``1,``2,``3,``4},System-Boolean- 'KeepCoding.TypeHelper.ToWork``5(System.UInt32,System.Func{``0,``1,``2,``3,``4},System.Boolean)')
- [UnrecognizedTypeException](#T-KeepCoding-UnrecognizedTypeException 'KeepCoding.UnrecognizedTypeException')
  - [#ctor()](#M-KeepCoding-UnrecognizedTypeException-#ctor 'KeepCoding.UnrecognizedTypeException.#ctor')
  - [#ctor(message)](#M-KeepCoding-UnrecognizedTypeException-#ctor-System-String- 'KeepCoding.UnrecognizedTypeException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-KeepCoding-UnrecognizedTypeException-#ctor-System-String,System-Exception- 'KeepCoding.UnrecognizedTypeException.#ctor(System.String,System.Exception)')
- [UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException')
  - [#ctor()](#M-KeepCoding-UnrecognizedValueException-#ctor 'KeepCoding.UnrecognizedValueException.#ctor')
  - [#ctor(message)](#M-KeepCoding-UnrecognizedValueException-#ctor-System-String- 'KeepCoding.UnrecognizedValueException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-KeepCoding-UnrecognizedValueException-#ctor-System-String,System-Exception- 'KeepCoding.UnrecognizedValueException.#ctor(System.String,System.Exception)')
- [Work](#T-KeepCoding-Work 'KeepCoding.Work')
  - [#ctor(work,allowSimultaneousActive,maximumThreadsActive)](#M-KeepCoding-Work-#ctor-System-Action,System-Boolean,System-UInt32- 'KeepCoding.Work.#ctor(System.Action,System.Boolean,System.UInt32)')
  - [Start()](#M-KeepCoding-Work-Start 'KeepCoding.Work.Start')
- [WorkBase](#T-KeepCoding-WorkBase 'KeepCoding.WorkBase')
  - [AllowSimultaneousActive](#P-KeepCoding-WorkBase-AllowSimultaneousActive 'KeepCoding.WorkBase.AllowSimultaneousActive')
  - [IsRunning](#P-KeepCoding-WorkBase-IsRunning 'KeepCoding.WorkBase.IsRunning')
  - [Thread](#P-KeepCoding-WorkBase-Thread 'KeepCoding.WorkBase.Thread')
  - [ThreadsActive](#P-KeepCoding-WorkBase-ThreadsActive 'KeepCoding.WorkBase.ThreadsActive')
  - [Stop()](#M-KeepCoding-WorkBase-Stop 'KeepCoding.WorkBase.Stop')
  - [WaitForOtherThreads()](#M-KeepCoding-WorkBase-WaitForOtherThreads 'KeepCoding.WorkBase.WaitForOtherThreads')
  - [WaitForOwnThread()](#M-KeepCoding-WorkBase-WaitForOwnThread 'KeepCoding.WorkBase.WaitForOwnThread')
- [Work\`1](#T-KeepCoding-Work`1 'KeepCoding.Work`1')
  - [#ctor(work,allowSimultaneousActive,maximumThreadsActive)](#M-KeepCoding-Work`1-#ctor-System-Func{`0},System-Boolean,System-UInt32- 'KeepCoding.Work`1.#ctor(System.Func{`0},System.Boolean,System.UInt32)')
  - [Result](#P-KeepCoding-Work`1-Result 'KeepCoding.Work`1.Result')
  - [Start()](#M-KeepCoding-Work`1-Start 'KeepCoding.Work`1.Start')
- [Work\`2](#T-KeepCoding-Work`2 'KeepCoding.Work`2')
  - [#ctor(work,allowSimultaneousActive,maximumThreadsActive)](#M-KeepCoding-Work`2-#ctor-System-Func{`0,`1},System-Boolean,System-UInt32- 'KeepCoding.Work`2.#ctor(System.Func{`0,`1},System.Boolean,System.UInt32)')
  - [Result](#P-KeepCoding-Work`2-Result 'KeepCoding.Work`2.Result')
  - [Start()](#M-KeepCoding-Work`2-Start-`0- 'KeepCoding.Work`2.Start(`0)')
- [Work\`3](#T-KeepCoding-Work`3 'KeepCoding.Work`3')
  - [#ctor(work,allowSimultaneousActive,maximumThreadsActive)](#M-KeepCoding-Work`3-#ctor-System-Func{`0,`1,`2},System-Boolean,System-UInt32- 'KeepCoding.Work`3.#ctor(System.Func{`0,`1,`2},System.Boolean,System.UInt32)')
  - [Result](#P-KeepCoding-Work`3-Result 'KeepCoding.Work`3.Result')
  - [Start()](#M-KeepCoding-Work`3-Start-`0,`1- 'KeepCoding.Work`3.Start(`0,`1)')
- [Work\`4](#T-KeepCoding-Work`4 'KeepCoding.Work`4')
  - [#ctor(work,allowSimultaneousActive,maximumThreadsActive)](#M-KeepCoding-Work`4-#ctor-System-Func{`0,`1,`2,`3},System-Boolean,System-UInt32- 'KeepCoding.Work`4.#ctor(System.Func{`0,`1,`2,`3},System.Boolean,System.UInt32)')
  - [Result](#P-KeepCoding-Work`4-Result 'KeepCoding.Work`4.Result')
  - [Start()](#M-KeepCoding-Work`4-Start-`0,`1,`2- 'KeepCoding.Work`4.Start(`0,`1,`2)')
- [Work\`5](#T-KeepCoding-Work`5 'KeepCoding.Work`5')
  - [#ctor(work,allowSimultaneousActive,maximumThreadsActive)](#M-KeepCoding-Work`5-#ctor-System-Func{`0,`1,`2,`3,`4},System-Boolean,System-UInt32- 'KeepCoding.Work`5.#ctor(System.Func{`0,`1,`2,`3,`4},System.Boolean,System.UInt32)')
  - [Result](#P-KeepCoding-Work`5-Result 'KeepCoding.Work`5.Result')
  - [Start()](#M-KeepCoding-Work`5-Start-`0,`1,`2,`3- 'KeepCoding.Work`5.Start(`0,`1,`2,`3)')
- [WrongDatatypeException](#T-KeepCoding-WrongDatatypeException 'KeepCoding.WrongDatatypeException')
  - [#ctor()](#M-KeepCoding-WrongDatatypeException-#ctor 'KeepCoding.WrongDatatypeException.#ctor')
  - [#ctor(message)](#M-KeepCoding-WrongDatatypeException-#ctor-System-String- 'KeepCoding.WrongDatatypeException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-KeepCoding-WrongDatatypeException-#ctor-System-String,System-Exception- 'KeepCoding.WrongDatatypeException.#ctor(System.String,System.Exception)')

<a name='T-KeepCoding-ArrayHelper'></a>
## ArrayHelper `type`

##### Namespace

KeepCoding

##### Summary

Extension methods surrounding [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') static methods to make code a bit shorter. Written by Emik.

<a name='M-KeepCoding-ArrayHelper-AsReadOnly``1-``0[]-'></a>
### AsReadOnly\`\`1(array) `method`

##### Summary

Returns a read-only wrapper for the specified array.

##### Returns

A read-only [ReadOnlyCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ReadOnlyCollection`1 'System.Collections.ObjectModel.ReadOnlyCollection`1') wrapper for the specified array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based array to wrap in a read-only [ReadOnlyCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ReadOnlyCollection`1 'System.Collections.ObjectModel.ReadOnlyCollection`1') wrapper. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-BinarySearch-System-Array,System-Object-'></a>
### BinarySearch(array,value) `method`

##### Summary

Searches an entire one-dimensional sorted array for a specific element, using the [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') interface implemented by each element of the array and by the specified object.

##### Returns

The index of the specified `value` in the specified `array`, if `value` is found; otherwise, a negative number. If `value` is not found and `value` is less than one or more elements in `array`, the negative number returned is the bitwise complement of the index of the first element that is larger than `value`. If `value` is not found and `value` is greater than all elements in `array`, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted `array`, the return `value` can be incorrect and a negative number could be returned, even if `value` is present in `array`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The sorted one-dimensional Array to search. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-BinarySearch-System-Array,System-Object,System-Collections-IComparer-'></a>
### BinarySearch(array,value,comparer) `method`

##### Summary

Searches an entire one-dimensional sorted array for a value using the specified [IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer') interface.

##### Returns

The index of the specified `value` in the specified `array`, if `value` is found; otherwise, a negative number. If `value` is not found and `value` is less than one or more elements in `array`, the negative number returned is the bitwise complement of the index of the first element that is larger than `value`. If `value` is not found and `value` is greater than all elements in `array`, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted `array`, the return `value` can be incorrect and a negative number could be returned, even if `value` is present in `array`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The sorted one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to search for. |
| comparer | [System.Collections.IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer') | The [IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer') implementation to use when comparing elements. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-BinarySearch-System-Array,System-Int32,System-Int32,System-Object-'></a>
### BinarySearch(array,index,length,value) `method`

##### Summary

Searches a range of elements in a one-dimensional sorted array for a value, using the [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') interface implemented by each element of the array and by the specified value.

##### Returns

The index of the specified `value` in the specified `array`, if `value` is found; otherwise, a negative number. If `value` is not found and `value` is less than one or more elements in `array`, the negative number returned is the bitwise complement of the index of the first element that is larger than `value`. If `value` is not found and `value` is greater than all elements in `array`, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted `array`, the return `value` can be incorrect and a negative number could be returned, even if `value` is present in `array`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The sorted one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range to search. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the range to search. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-BinarySearch-System-Array,System-Int32,System-Int32,System-Object,System-Collections-IComparer-'></a>
### BinarySearch(array,index,length,value,comparer) `method`

##### Summary

Searches a range of elements in a one-dimensional sorted array for a value, using the specified [IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer') interface.

##### Returns

The index of the specified `value` in the specified `array`, if `value` is found; otherwise, a negative number. If `value` is not found and `value` is less than one or more elements in `array`, the negative number returned is the bitwise complement of the index of the first element that is larger than `value`. If `value` is not found and `value` is greater than all elements in `array`, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted `array`, the return `value` can be incorrect and a negative number could be returned, even if `value` is present in `array`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The sorted one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range to search. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the range to search. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to search for. |
| comparer | [System.Collections.IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer') | The [IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer') implementation to use when comparing elements or `null` to use the [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') implementation of each element.. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-BinarySearch``1-``0[],``0-'></a>
### BinarySearch\`\`1(array,value) `method`

##### Summary

Searches an entire one-dimensional sorted array for a specific element, using the [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') generic interface implemented by each element of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') and by the specified object.

##### Returns

The index of the specified `value` in the specified `array`, if `value` is found; otherwise, a negative number. If `value` is not found and `value` is less than one or more elements in `array`, the negative number returned is the bitwise complement of the index of the first element that is larger than `value`. If `value` is not found and `value` is greater than all elements in `array`, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted `array`, the return `value` can be incorrect and a negative number could be returned, even if `value` is present in `array`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The sorted one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| value | [\`\`0](#T-``0 '``0') | The object to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-BinarySearch``1-``0[],``0,System-Collections-Generic-IComparer{``0}-'></a>
### BinarySearch\`\`1(array,value,comparer) `method`

##### Summary

Searches an entire one-dimensional sorted array for a value using the specified [IComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer`1 'System.Collections.Generic.IComparer`1') generic interface.

##### Returns

The index of the specified `value` in the specified `array`, if `value` is found; otherwise, a negative number. If `value` is not found and `value` is less than one or more elements in `array`, the negative number returned is the bitwise complement of the index of the first element that is larger than `value`. If `value` is not found and `value` is greater than all elements in `array`, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted `array`, the return `value` can be incorrect and a negative number could be returned, even if `value` is present in `array`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The sorted one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| value | [\`\`0](#T-``0 '``0') | The object to search for. |
| comparer | [System.Collections.Generic.IComparer{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer 'System.Collections.Generic.IComparer{``0}') | The [IComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer`1 'System.Collections.Generic.IComparer`1') implementation to use when comparing elements or `null` to use the [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') implementation of each element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-BinarySearch``1-``0[],System-Int32,System-Int32,``0-'></a>
### BinarySearch\`\`1(array,index,length,value) `method`

##### Summary

Searches a range of elements in a one-dimensional sorted array for a value, using the [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') generic interface implemented by each element of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') and by the specified value.

##### Returns

The index of the specified `value` in the specified `array`, if `value` is found; otherwise, a negative number. If `value` is not found and `value` is less than one or more elements in `array`, the negative number returned is the bitwise complement of the index of the first element that is larger than `value`. If `value` is not found and `value` is greater than all elements in `array`, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted `array`, the return `value` can be incorrect and a negative number could be returned, even if `value` is present in `array`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The sorted one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range to search. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the range to search. |
| value | [\`\`0](#T-``0 '``0') | The object to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-BinarySearch``1-``0[],System-Int32,System-Int32,``0,System-Collections-Generic-IComparer{``0}-'></a>
### BinarySearch\`\`1(array,index,length,value,comparer) `method`

##### Summary

Searches a range of elements in a one-dimensional sorted array for a value, using the specified [IComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer`1 'System.Collections.Generic.IComparer`1') generic interface.

##### Returns

The index of the specified `value` in the specified `array`, if `value` is found; otherwise, a negative number. If `value` is not found and `value` is less than one or more elements in `array`, the negative number returned is the bitwise complement of the index of the first element that is larger than `value`. If `value` is not found and `value` is greater than all elements in `array`, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted `array`, the return `value` can be incorrect and a negative number could be returned, even if `value` is present in `array`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The sorted one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range to search. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the range to search. |
| value | [\`\`0](#T-``0 '``0') | The object to search for. |
| comparer | [System.Collections.Generic.IComparer{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer 'System.Collections.Generic.IComparer{``0}') | The [IComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer`1 'System.Collections.Generic.IComparer`1') implementation to use when comparing elements or `null` to use the [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') implementation of each element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Clear-System-Array,System-Int32,System-Int32-'></a>
### Clear(array,index,length) `method`

##### Summary

Sets a range of elements in an array to the default value of each element type.

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The array whose elements need to be cleared. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range of elements to clear. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements to clear. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Clone-System-Array-'></a>
### Clone(this) `method`

##### Summary

Creates a shallow copy of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array')

##### Returns

A shallow copy of the `this`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-ConstrainedCopy-System-Array,System-Int32,System-Array,System-Int32,System-Int32-'></a>
### ConstrainedCopy(sourceArray,sourceIndex,destinationArray,destinationIndex,length) `method`

##### Summary

Copies a range of elements from an [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') starting at the specified source index and pastes them to another [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') starting at the specified destination index. Guarantees that all changes are undone if the copy does not succeed completely.

##### Returns

`destinationArray`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceArray | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the data to copy. |
| sourceIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the index in the `sourceArray` at which copying begins. |
| destinationArray | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that receives the data. |
| destinationIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the index in the `destinationArray` at which storing begins. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the number of elements to copy. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArrayTypeMismatchException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArrayTypeMismatchException 'System.ArrayTypeMismatchException') |  |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-ConvertAll``2-``0[],System-Converter{``0,``1}-'></a>
### ConvertAll\`\`2(array,converter) `method`

##### Summary

Converts an array of one type to an array of another type.

##### Returns

An array of the target type containing the converted elements from the source array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to convert to a target type. |
| converter | [System.Converter{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Converter 'System.Converter{``0,``1}') | A [Converter\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Converter`2 'System.Converter`2') that converts each element from one type to another type. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TInput | The type of the elements of the source array. |
| TOutput | The type of the elements of the target array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Copy-System-Array,System-Int64,System-Array,System-Int64,System-Int64-'></a>
### Copy(sourceArray,sourceIndex,destinationArray,destinationIndex,length) `method`

##### Summary

Copies a range of elements from an [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') starting at the specified source index and pastes them to another [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') starting at the specified destination index. The length and the indexes are specified as 64-bit integers.

##### Returns

`destinationArray`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceArray | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the data to copy. |
| sourceIndex | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the index in the `sourceArray` at which copying begins. |
| destinationArray | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that receives the data. |
| destinationIndex | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the index in the `destinationIndex` at which storing begins. |
| length | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the number of elements to copy. The integer must be between zero and [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32.MaxValue 'System.Int32.MaxValue'), inclusive. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArrayTypeMismatchException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArrayTypeMismatchException 'System.ArrayTypeMismatchException') |  |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Copy-System-Array,System-Int32,System-Array,System-Int32,System-Int32-'></a>
### Copy(sourceArray,sourceIndex,destinationArray,destinationIndex,length) `method`

##### Summary

Copies a range of elements from an [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') starting at the specified source index and pastes them to another [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') starting at the specified destination index. The length and the indexes are specified as 32-bit integers.

##### Returns

`destinationArray`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceArray | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the data to copy. |
| sourceIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the index in the `sourceArray` at which copying begins. |
| destinationArray | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that receives the data. |
| destinationIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the index in the `destinationIndex` at which storing begins. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the number of elements to copy. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArrayTypeMismatchException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArrayTypeMismatchException 'System.ArrayTypeMismatchException') |  |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Copy-System-Array,System-Array,System-Int64-'></a>
### Copy(sourceArray,destinationArray,length) `method`

##### Summary

Copies a range of elements from an Array starting at the first element and pastes them into another Array starting at the first element. The length is specified as a 64-bit integer.

##### Returns

`destinationArray`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceArray | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the data to copy. |
| destinationArray | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that receives the data. |
| length | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the number of elements to copy. The integer must be between zero and [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32.MaxValue 'System.Int32.MaxValue'), inclusive. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArrayTypeMismatchException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArrayTypeMismatchException 'System.ArrayTypeMismatchException') |  |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Copy-System-Array,System-Array,System-Int32-'></a>
### Copy(sourceArray,destinationArray,length) `method`

##### Summary

Copies a range of elements from an [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') starting at the first element and pastes them into another [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') starting at the first element. The length is specified as a 32-bit integer.

##### Returns

`destinationArray`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceArray | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the data to copy. |
| destinationArray | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that receives the data. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the number of elements to copy. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArrayTypeMismatchException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArrayTypeMismatchException 'System.ArrayTypeMismatchException') |  |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-CopyTo-System-Array,System-Array,System-Int32-'></a>
### CopyTo(this,array,index) `method`

##### Summary

Copies all the elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index. The index is specified as a 64-bit integer.

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional array that is the destination of the elements copied from the current array. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the index in `array` at which copying begins. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-CopyTo-System-Array,System-Array,System-Int64-'></a>
### CopyTo(this,array,index) `method`

##### Summary

Copies all the elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index. The index is specified as a 64-bit integer.

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional array that is the destination of the elements copied from the current array. |
| index | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the index in `array` at which copying begins. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-CreateInstance-System-Type,System-Int32-'></a>
### CreateInstance(elementType,length) `method`

##### Summary

Creates a one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of the specified [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') and length, with zero-based indexing.

##### Returns

A new one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of the specified [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') with the specified length, using zero-based indexing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elementType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.NotSupportedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotSupportedException 'System.NotSupportedException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-CreateInstance-System-Type,System-Int32[]-'></a>
### CreateInstance(elementType,lengths) `method`

##### Summary

Creates a multidimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of the specified [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') and dimension lengths, with zero-based indexing. The dimension lengths are specified in an array of 32-bit integers.

##### Returns

A new multidimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of the specified [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') with the specified length for each dimension, using zero-based indexing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elementType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |
| lengths | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | An array of 32-bit integers that represent the size of each dimension of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |

<a name='M-KeepCoding-ArrayHelper-CreateInstance-System-Type,System-Int64[]-'></a>
### CreateInstance(elementType,lengths) `method`

##### Summary

Creates a multidimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of the specified [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') and dimension lengths, with zero-based indexing. The dimension lengths are specified in an array of 64-bit integers.

##### Returns

A new multidimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of the specified [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') with the specified length for each dimension, using zero-based indexing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elementType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |
| lengths | [System.Int64[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64[] 'System.Int64[]') | An array of 64-bit integers that represent the size of each dimension of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. Each integer in the array must be between zero and [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32.MaxValue 'System.Int32.MaxValue'), inclusive. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.NotSupportedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotSupportedException 'System.NotSupportedException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-CreateInstance-System-Type,System-Int32,System-Int32-'></a>
### CreateInstance(elementType,length1,length2) `method`

##### Summary

Creates a two-dimensional Array of the specified Type and dimension lengths, with zero-based indexing.

##### Returns

A new two-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of the specified [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') with the specified length for each dimension, using zero-based indexing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elementType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |
| length1 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the first dimension of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |
| length2 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the second dimension of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.NotSupportedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotSupportedException 'System.NotSupportedException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-CreateInstance-System-Type,System-Int32[],System-Int32[]-'></a>
### CreateInstance(elementType,lengths,lowerBounds) `method`

##### Summary

Creates a multidimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of the specified [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') and dimension lengths, with the specified lower bounds.

##### Returns

A new multidimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of the specified [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') with the specified length and lower bound for each dimension.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elementType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |
| lengths | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | A one-dimensional array that contains the size of each dimension of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |
| lowerBounds | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | A one-dimensional array that contains the lower bound (starting index) of each dimension of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.NotSupportedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotSupportedException 'System.NotSupportedException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-CreateInstance-System-Type,System-Int32,System-Int32,System-Int32-'></a>
### CreateInstance(elementType,length1,length2,length3) `method`

##### Summary

Creates a three-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of the specified [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') and dimension lengths, with zero-based indexing.

##### Returns

A new three-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of the specified [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') with the specified length for each dimension, using zero-based indexing.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elementType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |
| length1 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the first dimension of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |
| length2 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the second dimension of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |
| length3 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the third dimension of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to create. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.NotSupportedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotSupportedException 'System.NotSupportedException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Exists``1-``0[],System-Predicate{``0}-'></a>
### Exists\`\`1(array,match) `method`

##### Summary

Determines whether the specified array contains elements that match the conditions defined by the specified predicate.

##### Returns

`true` if `array` contains one or more elements that match the conditions defined by the specified predicate; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| match | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The [Predicate\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate`1 'System.Predicate`1') that defines the conditions of the elements to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-FindAll``1-``0[],System-Predicate{``0}-'></a>
### FindAll\`\`1(array,match) `method`

##### Summary

Retrieves all the elements that match the conditions defined by the specified predicate.

##### Returns

An [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') containing all the elements that match the conditions defined by the specified predicate, if found; otherwise, an empty [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| match | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The [Predicate\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate`1 'System.Predicate`1') that defines the conditions of the elements to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-FindIndex``1-``0[],System-Predicate{``0}-'></a>
### FindIndex\`\`1(array,match) `method`

##### Summary

Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the entire [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

The zero-based index of the first occurrence of an element that matches the conditions defined by `match`, if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| match | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The [Predicate\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate`1 'System.Predicate`1') that defines the conditions of the element to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

<a name='M-KeepCoding-ArrayHelper-FindIndex``1-``0[],System-Int32,System-Predicate{``0}-'></a>
### FindIndex\`\`1(array,startIndex,match) `method`

##### Summary

Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the range of elements in the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that extends from the specified index to the last element.

##### Returns

The zero-based index of the first occurrence of an element that matches the conditions defined by `match`, if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based starting index of the search. |
| match | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The [Predicate\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate`1 'System.Predicate`1') that defines the conditions of the element to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-FindIndex``1-``0[],System-Int32,System-Int32,System-Predicate{``0}-'></a>
### FindIndex\`\`1(array,startIndex,count,match) `method`

##### Summary

Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the range of elements in the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that starts at the specified index and contains the specified number of elements.

##### Returns

The zero-based index of the first occurrence of an element that matches the conditions defined by [Predicate\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate`1 'System.Predicate`1'), if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based starting index of the search. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the section to search. |
| match | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The [Predicate\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate`1 'System.Predicate`1') that defines the conditions of the element to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks

https://docs.microsoft.com/en-us/dotnet/api/system.array.findindex?view=net-5.0#System_Array_FindIndex__1___0___System_Int32_System_Int32_System_Predicate___0__

<a name='M-KeepCoding-ArrayHelper-FindLastIndex``1-``0[],System-Predicate{``0}-'></a>
### FindLastIndex\`\`1(array,match) `method`

##### Summary

Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the entire [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

The zero-based index of the last occurrence of an element that matches the conditions defined by `match`, if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| match | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The [Predicate\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate`1 'System.Predicate`1') that defines the conditions of the element to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-FindLastIndex``1-``0[],System-Int32,System-Predicate{``0}-'></a>
### FindLastIndex\`\`1(array,startIndex,match) `method`

##### Summary

Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the range of elements in the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that extends from the specified index to the last element.

##### Returns

The zero-based index of the last occurrence of an element that matches the conditions defined by `match`, if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based starting index of the search. |
| match | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The [Predicate\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate`1 'System.Predicate`1') that defines the conditions of the element to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-FindLastIndex``1-``0[],System-Int32,System-Int32,System-Predicate{``0}-'></a>
### FindLastIndex\`\`1(array,startIndex,count,match) `method`

##### Summary

Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the range of elements in the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that starts at the specified index and contains the specified number of elements.

##### Returns

The zero-based index of the last occurrence of an element that matches the conditions defined by [Predicate\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate`1 'System.Predicate`1'), if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based starting index of the search. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the section to search. |
| match | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The [Predicate\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate`1 'System.Predicate`1') that defines the conditions of the element to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks

https://docs.microsoft.com/en-us/dotnet/api/system.array.findlastindex?view=net-5.0#System_Array_FindLastIndex__1___0___System_Int32_System_Int32_System_Predicate___0__

<a name='M-KeepCoding-ArrayHelper-FindLast``1-``0[],System-Predicate{``0}-'></a>
### FindLast\`\`1(array,match) `method`

##### Summary

Searches for an element that matches the conditions defined by the specified predicate, and returns the last occurrence within the entire [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

The last element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to search. |
| match | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The [Predicate\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate`1 'System.Predicate`1') that defines the conditions of the element to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Find``1-``0[],System-Predicate{``0}-'></a>
### Find\`\`1(array,match) `method`

##### Summary

Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

The first element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based array to search. |
| match | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The predicate that defines the conditions of the element to search for. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-ForEach``1-``0[],System-Action{``0}-'></a>
### ForEach\`\`1(array,action) `method`

##### Summary

Performs the specified action on each element of the specified array.

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') on whose elements the action is to be performed. |
| action | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | The [Action\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action`1 'System.Action`1') to perform on each element of `array`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Get-System-Array,System-Int64,System-Int64,System-Int64-'></a>
### Get(this,index1,index2,index3) `method`

##### Summary

Gets the value at the specified position in the three-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'). The indexes are specified as 64-bit integers.

##### Returns

The value at the specified position in the three-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| index1 | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the first-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to get. |
| index2 | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the second-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to get. |
| index3 | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the third-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to get. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Get-System-Array,System-Int32,System-Int32,System-Int32-'></a>
### Get(this,index1,index2,index3) `method`

##### Summary

Gets the value at the specified position in the three-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'). The indexes are specified as 32-bit integers.

##### Returns

The value at the specified position in the three-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| index1 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the first-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to get. |
| index2 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the second-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to get. |
| index3 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the third-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to get. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Get-System-Array,System-Int32,System-Int32-'></a>
### Get(this,index1,index2) `method`

##### Summary

Gets the value at the specified position in the two-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'). The indexes are specified as 32-bit integers.

##### Returns

The value at the specified position in the two-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| index1 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the first-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to get. |
| index2 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the second-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to get. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Get-System-Array,System-Int32-'></a>
### Get(this,index) `method`

##### Summary

Gets the value at the specified position in the one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'). The indexes are specified as 32-bit integers.

##### Returns

The value at the specified position in the one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the first-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to get. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Get-System-Array,System-Int64-'></a>
### Get(this,index) `method`

##### Summary

Gets the value at the specified position in the one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'). The indexes are specified as 64-bit integers.

##### Returns

The value at the specified position in the one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| index | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the first-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to get. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Get-System-Array,System-Int32[]-'></a>
### Get(this,indices) `method`

##### Summary

Gets the value at the specified position in the multidimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'). The indexes are specified as an array of 32-bit integers.

##### Returns

The value at the specified position in the multidimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| indices | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | A one-dimensional array of 32-bit integers that represent the indexes specifying the position of the Array element to get. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Get-System-Array,System-Int64[]-'></a>
### Get(this,indices) `method`

##### Summary

Gets the value at the specified position in the multidimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'). The indexes are specified as an array of 64-bit integers.

##### Returns

The value at the specified position in the multidimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| indices | [System.Int64[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64[] 'System.Int64[]') | A one-dimensional array of 64-bit integers that represent the indexes specifying the position of the Array element to get. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-GetEnumerator-System-Array-'></a>
### GetEnumerator(this) `method`

##### Summary

Returns an [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') for the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

An [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') for the Array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-GetLength-System-Array,System-Int32-'></a>
### GetLength(this,dimension) `method`

##### Summary

Gets a 32-bit integer that represents the number of elements in the specified dimension of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

A 32-bit integer that represents the number of elements in the specified dimension.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| dimension | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A zero-based dimension of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') whose length needs to be determined. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-GetLongLength-System-Array,System-Int32-'></a>
### GetLongLength(this,dimension) `method`

##### Summary

Gets a 64-bit integer that represents the number of elements in the specified dimension of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

A 64-bit integer that represents the number of elements in the specified dimension.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| dimension | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A zero-based dimension of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') whose length needs to be determined. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-GetLowerBound-System-Array,System-Int32-'></a>
### GetLowerBound(this,dimension) `method`

##### Summary

Gets the index of the first element of the specified dimension in the array.

##### Returns

The index of the first element of the specified dimension in the array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| dimension | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A zero-based dimension of the array whose starting index needs to be determined. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-GetUpperBound-System-Array,System-Int32-'></a>
### GetUpperBound(this,dimension) `method`

##### Summary

Gets the index of the last element of the specified dimension in the array.

##### Returns

The index of the first element of the specified dimension in the array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| dimension | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A zero-based dimension of the array whose starting index needs to be determined. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-GetValue-System-Array,System-Int64,System-Int64-'></a>
### GetValue(this,index1,index2) `method`

##### Summary

Gets the value at the specified position in the two-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'). The indexes are specified as 64-bit integers.

##### Returns

The value at the specified position in the two-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| index1 | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the first-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to get. |
| index2 | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the second-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to get. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-IndexOf-System-Array,System-Object-'></a>
### IndexOf(array,value) `method`

##### Summary

Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.

##### Returns

The index of the first occurrence of `value` in `array`, if found; otherwise, the lower bound of the array minus 1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional array to search. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to locate in `array`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-IndexOf-System-Array,System-Object,System-Int32-'></a>
### IndexOf(array,value,startIndex) `method`

##### Summary

Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its first occurrence. The range extends from a specified index to the end of the array.

##### Returns

The index of the first occurrence of `value`, if it's found, within the range of elements in `array` that extends from `startIndex` to the last element; otherwise, the lower bound of the array minus 1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional array to search. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to locate in `array`. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the search. 0 (zero) is valid in an empty array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-IndexOf-System-Array,System-Object,System-Int32,System-Int32-'></a>
### IndexOf(array,value,startIndex,count) `method`

##### Summary

Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of ifs first occurrence. The range extends from a specified index for a specified number of elements.

##### Returns

The index of the first occurrence of `value`, if it's found in the `array` from index `startIndex` to `startIndex` + `count` - 1; otherwise, the lower bound of the array minus 1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional array to search. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to locate in `array`. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the search. 0 (zero) is valid in an empty array. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements to search. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-IndexOf``1-``0[],``0,System-Int32,System-Int32-'></a>
### IndexOf\`\`1(array,value,startIndex,count) `method`

##### Summary

Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its first occurrence. The range extends from a specified index for a specified number of elements.

##### Returns

The zero-based index of the first occurrence of `value` within the range of elements in `array` that starts at `startIndex` and contains the number of elements specified in `count`, if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based array to search. |
| value | [\`\`0](#T-``0 '``0') | The object to locate in `array`. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based starting index of the search. 0 (zero) is valid in an empty array. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the section to search. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-IndexOf``1-``0[],``0-'></a>
### IndexOf\`\`1(array,value) `method`

##### Summary

Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.

##### Returns

The zero-based index of the first occurrence of `value` in the entire `array`, if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based array to search. |
| value | [\`\`0](#T-``0 '``0') | The object to locate in `array`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-IndexOf``1-``0[],``0,System-Int32-'></a>
### IndexOf\`\`1(array,value,startIndex) `method`

##### Summary

Searches for the specified object in a range of elements of a one dimensional array, and returns the index of its first occurrence. The range extends from a specified index to the end of the array.

##### Returns

The zero-based index of the first occurrence of `value` within the range of elements in `array` that extends from `startIndex` to the last element, if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based array to search. |
| value | [\`\`0](#T-``0 '``0') | The object to locate in `array`. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based starting index of the search. 0 (zero) is valid in an empty array. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Initialize-System-Array-'></a>
### Initialize(this) `method`

##### Summary

Initializes every element of the value-type [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') by calling the parameterless constructor of the value type.

##### Returns

`this`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-LastIndexOf-System-Array,System-Object-'></a>
### LastIndexOf(array,value) `method`

##### Summary

Searches for the specified object and returns the index of its last occurrence in a one-dimensional array.

##### Returns

The index of the last occurrence of `value` in `array`, if found; otherwise, the lower bound of the array minus 1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional array to search. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to locate in `array`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-LastIndexOf-System-Array,System-Object,System-Int32-'></a>
### LastIndexOf(array,value,startIndex) `method`

##### Summary

Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its last occurrence. The range extends from a specified index to the end of the array.

##### Returns

The index of the last occurrence of `value`, if it's found, within the range of elements in `array` that extends from `startIndex` to the last element; otherwise, the lower bound of the array minus 1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional array to search. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to locate in `array`. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the search. 0 (zero) is valid in an empty array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-LastIndexOf-System-Array,System-Object,System-Int32,System-Int32-'></a>
### LastIndexOf(array,value,startIndex,count) `method`

##### Summary

Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of ifs last occurrence. The range extends from a specified index for a specified number of elements.

##### Returns

The index of the last occurrence of `value`, if it's found in the `array` from index `startIndex` to `startIndex` + `count` - 1; otherwise, the lower bound of the array minus 1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional array to search. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to locate in `array`. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the search. 0 (zero) is valid in an empty array. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements to search. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-LastIndexOf``1-``0[],``0,System-Int32,System-Int32-'></a>
### LastIndexOf\`\`1(array,value,startIndex,count) `method`

##### Summary

Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its last occurrence. The range extends from a specified index for a specified number of elements.

##### Returns

The zero-based index of the last occurrence of `value` within the range of elements in `array` that starts at `startIndex` and contains the number of elements specified in `count`, if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based array to search. |
| value | [\`\`0](#T-``0 '``0') | The object to locate in `array`. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based starting index of the search. 0 (zero) is valid in an empty array. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the section to search. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-LastIndexOf``1-``0[],``0-'></a>
### LastIndexOf\`\`1(array,value) `method`

##### Summary

Searches for the specified object and returns the index of its last occurrence in a one-dimensional array.

##### Returns

The zero-based index of the last occurrence of `value` in the entire `array`, if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based array to search. |
| value | [\`\`0](#T-``0 '``0') | The object to locate in `array`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-LastIndexOf``1-``0[],``0,System-Int32-'></a>
### LastIndexOf\`\`1(array,value,startIndex) `method`

##### Summary

Searches for the specified object in a range of elements of a one dimensional array, and returns the index of its last occurrence. The range extends from a specified index to the end of the array.

##### Returns

The zero-based index of the last occurrence of `value` within the range of elements in `array` that extends from `startIndex` to the last element, if found; otherwise, -1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based array to search. |
| value | [\`\`0](#T-``0 '``0') | The object to locate in `array`. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based starting index of the search. 0 (zero) is valid in an empty array. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Resize``1-``0[],System-Int32-'></a>
### Resize\`\`1(array,newSize) `method`

##### Summary

Changes the number of elements of a one-dimensional array to the specified new size.

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based array to resize, or `null` to create a new array with the specified size. |
| newSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the new array. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Reverse-System-Array,System-Int32,System-Int32-'></a>
### Reverse(array,index,length) `method`

##### Summary

Reverses the sequence of a subset of the elements in the one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to reverse. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the section to reverse. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the section to reverse. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

##### Remarks

https://docs.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-5.0#System_Array_Reverse_System_Array_System_Int32_System_Int32_

<a name='M-KeepCoding-ArrayHelper-Reverse-System-Array-'></a>
### Reverse(array) `method`

##### Summary

Reverses the sequence of the elements in the entire one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to reverse. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Reverse``1-``0[]-'></a>
### Reverse\`\`1(array) `method`

##### Summary

Reverses the sequence of the elements in the one-dimensional generic array.

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional array of elements to reverse. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements in `array`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Reverse``1-``0[],System-Int32,System-Int32-'></a>
### Reverse\`\`1(array,index,length) `method`

##### Summary

Reverses the sequence of a subset of the elements in the one-dimensional generic array.

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional array of elements to reverse. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the section to reverse. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the section to reverse. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements in `array`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int32-'></a>
### Set(this,value,index) `method`

##### Summary

Sets a value to the element at the specified position in the one-dimensional Array. The index is specified as a 32-bit integer.

##### Returns

`this`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The new value for the specified element. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the position of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to set. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int32[]-'></a>
### Set(this,value,indices) `method`

##### Summary

Sets a value to the element at the specified position in the multi-dimensional Array. The index is specified as a 32-bit integer.

##### Returns

`this`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The new value for the specified element. |
| indices | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | A one-dimensional array of 32-bit integers that represent the indexes specifying the position of the element to set. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int64-'></a>
### Set(this,value,index) `method`

##### Summary

Sets a value to the element at the specified position in the one-dimensional Array. The index is specified as a 64-bit integer.

##### Returns

`this`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The new value for the specified element. |
| index | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the position of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to set. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int64[]-'></a>
### Set(this,value,indices) `method`

##### Summary

Sets a value to the element at the specified position in the multi-dimensional Array. The index is specified as a 64-bit integer.

##### Returns

`this`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The new value for the specified element. |
| indices | [System.Int64[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64[] 'System.Int64[]') | A one-dimensional array of 64-bit integers that represent the indexes specifying the position of the element to set. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int32,System-Int32-'></a>
### Set(this,value,index1,index2) `method`

##### Summary

Sets a value to the element at the specified position in the two-dimensional Array. The index is specified as a 32-bit integer.

##### Returns

`this`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The new value for the specified element. |
| index1 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the first-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to set. |
| index2 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the second-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to set. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int64,System-Int64-'></a>
### Set(this,value,index1,index2) `method`

##### Summary

Sets a value to the element at the specified position in the two-dimensional Array. The index is specified as a 64-bit integer.

##### Returns

`this`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The new value for the specified element. |
| index1 | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the first-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to set. |
| index2 | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the second-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to set. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int32,System-Int32,System-Int32-'></a>
### Set(this,value,index1,index2,index3) `method`

##### Summary

Sets a value to the element at the specified position in the three-dimensional Array. The index is specified as a 32-bit integer.

##### Returns

`this`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The new value for the specified element. |
| index1 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the first-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to set. |
| index2 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the second-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to set. |
| index3 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A 32-bit integer that represents the third-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to set. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Set-System-Array,System-Object,System-Int64,System-Int64,System-Int64-'></a>
### Set(this,value,index1,index2,index3) `method`

##### Summary

Sets a value to the element at the specified position in the three-dimensional Array. The index is specified as a 64-bit integer.

##### Returns

`this`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | `this` |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The new value for the specified element. |
| index1 | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the first-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to set. |
| index2 | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the second-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to set. |
| index3 | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | A 64-bit integer that represents the third-dimension index of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') element to set. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort-System-Array,System-Int32,System-Int32,System-Collections-IComparer-'></a>
### Sort(array,index,length,comparer) `method`

##### Summary

Sorts the elements in a range of elements in a one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the specified [IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer').

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to sort. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range to sort. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the range to sort |
| comparer | [System.Collections.IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer') | The [IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer') implementation to use when comparing elements. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort-System-Array,System-Array,System-Int32,System-Int32,System-Collections-IComparer-'></a>
### Sort(keys,items,index,length,comparer) `method`

##### Summary

Sorts a range of elements in a pair of one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the specified [IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer').

##### Returns

`keys` and `items`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keys | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the keys to sort. |
| items | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the items that correspond to each of the keys in the `keys`[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') or `null` to sort only the `keys`[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'). |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range to sort. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the range to sort. |
| comparer | [System.Collections.IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer') | The [IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer') implementation to use when comparing elements or `null` to use the [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') implementation of each element. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort-System-Array,System-Int32,System-Int32-'></a>
### Sort(array,index,length) `method`

##### Summary

Sorts the elements in a range of elements in a one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') implementation of each element of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to sort. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range to sort. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the range to sort. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort-System-Array,System-Array,System-Int32,System-Int32-'></a>
### Sort(keys,items,index,length) `method`

##### Summary

Sorts a range of elements in a pair of one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') implementation of each key.

##### Returns

`keys` and `items`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keys | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the keys to sort. |
| items | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the items that correspond to each of the keys in the `keys`[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') or `null` to sort only the `keys`[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'). |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range to sort. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the range to sort. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks

https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0#System_Array_Sort_System_Array_System_Array_System_Int32_System_Int32_

<a name='M-KeepCoding-ArrayHelper-Sort-System-Array,System-Collections-IComparer-'></a>
### Sort(array,comparer) `method`

##### Summary

Sorts the elements in a one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the specified [IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer').

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional array to sort. |
| comparer | [System.Collections.IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer') | The implementation to use when comparing elements or `null` to use the [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') implementation of each element. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort-System-Array,System-Array,System-Collections-IComparer-'></a>
### Sort(keys,items,comparer) `method`

##### Summary

Sorts a pair of one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the specified [IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer').

##### Returns

`keys` and `items`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keys | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the keys to sort. |
| items | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the items that correspond to each of the keys in the `keys`[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') or `null` to sort only the `keys`[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'). |
| comparer | [System.Collections.IComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IComparer 'System.Collections.IComparer') | The implementation to use when comparing elements or `null` to use the [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') implementation of each element. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort-System-Array,System-Array-'></a>
### Sort(keys,items) `method`

##### Summary

Sorts a pair of one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') implementation of each key.

##### Returns

`keys` and `items`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keys | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the keys to sort. |
| items | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the items that correspond to each of the keys in the `keys`[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') or `null` to sort only the `keys`[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort-System-Array-'></a>
### Sort(array) `method`

##### Summary

Sorts the elements in an entire one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') implementation of each element of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The one-dimensional [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to sort. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort``1-``0[]-'></a>
### Sort\`\`1(array) `method`

##### Summary

Sorts the elements in an entire [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') generic interface implementation of each element of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based Array to sort. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort``1-``0[],System-Collections-Generic-IComparer{``0}-'></a>
### Sort\`\`1(array,comparer) `method`

##### Summary

Sorts the elements in an [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the specified [IComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer`1 'System.Collections.Generic.IComparer`1') generic interface.

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-base [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to sort. |
| comparer | [System.Collections.Generic.IComparer{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer 'System.Collections.Generic.IComparer{``0}') | The [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') generic interface implementation to use when comparing elements, or `null` to use the [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') generic interface implementation of each element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort``1-``0[],System-Comparison{``0}-'></a>
### Sort\`\`1(array,comparison) `method`

##### Summary

Sorts the elements in an [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the specified [Comparison\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Comparison`1 'System.Comparison`1').

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to sort. |
| comparison | [System.Comparison{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Comparison 'System.Comparison{``0}') | The [Comparison\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Comparison`1 'System.Comparison`1') to use when comparing elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort``1-``0[],System-Int32,System-Int32-'></a>
### Sort\`\`1(array,index,length) `method`

##### Summary

Sorts the elements in a range of elements in an [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') generic interface implementation of each element of the [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to sort. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range to sort. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the range to sort. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort``1-``0[],System-Int32,System-Int32,System-Collections-Generic-IComparer{``0}-'></a>
### Sort\`\`1(array,index,length,comparer) `method`

##### Summary

Sorts the elements in a range of elements in an [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the specified [IComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer`1 'System.Collections.Generic.IComparer`1') generic interface.

##### Returns

`array`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to sort. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range to sort. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the range to sort. |
| comparer | [System.Collections.Generic.IComparer{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer 'System.Collections.Generic.IComparer{``0}') | The implementation to use when comparing elements or `null` to use the [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') implementation of each element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort``2-``0[],``1[]-'></a>
### Sort\`\`2(keys,items) `method`

##### Summary

Sorts a pair of [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') generic interface implementation of each key.

##### Returns

`keys` and `items`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keys | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the keys to sort. |
| items | [\`\`1[]](#T-``1[] '``1[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the items that correspond to the keys in `keys`, or `null` to sort only `keys`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type of the elements of the key array. |
| TValue | The type of the elements of the items array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort``2-``0[],``1[],System-Collections-Generic-IComparer{``0}-'></a>
### Sort\`\`2(keys,items,comparer) `method`

##### Summary

Sorts a pair of [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the specified [IComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer`1 'System.Collections.Generic.IComparer`1') generic interface.

##### Returns

`keys` and `items`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keys | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the keys to sort. |
| items | [\`\`1[]](#T-``1[] '``1[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the items that correspond to the keys in `keys`, or `null` to sort only `keys`. |
| comparer | [System.Collections.Generic.IComparer{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer 'System.Collections.Generic.IComparer{``0}') | The [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') generic interface implementation to use when comparing elements, or `null` to use the [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') generic interface implementation of each element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type of the elements of the key array. |
| TValue | The type of the elements of the items array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort``2-``0[],``1[],System-Int32,System-Int32-'></a>
### Sort\`\`2(keys,items,index,length) `method`

##### Summary

Sorts a range of elements in a pair of [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the [IComparable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable`1 'System.IComparable`1') generic interface implementation of each key.

##### Returns

`keys` and `items`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keys | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the keys to sort. |
| items | [\`\`1[]](#T-``1[] '``1[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the items that correspond to the keys in `keys`, or `null` to sort only `keys`. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range to sort. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the range to sort. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type of the elements of the key array. |
| TValue | The type of the elements of the items array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-Sort``2-``0[],``1[],System-Int32,System-Int32,System-Collections-Generic-IComparer{``0}-'></a>
### Sort\`\`2(keys,items,index,length,comparer) `method`

##### Summary

Sorts a range of elements in a pair of [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') objects (one contains the keys and the other contains the corresponding items) based on the keys in the first [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') using the specified [IComparer\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer`1 'System.Collections.Generic.IComparer`1') generic interface.

##### Returns

`keys` and `items`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keys | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the keys to sort. |
| items | [\`\`1[]](#T-``1[] '``1[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') that contains the items that correspond to the keys in `keys`, or `null` to sort only `keys`. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the range to sort. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of elements in the range to sort. |
| comparer | [System.Collections.Generic.IComparer{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer 'System.Collections.Generic.IComparer{``0}') | The implementation to use when comparing elements or `null` to use the [IComparable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IComparable 'System.IComparable') implementation of each element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type of the elements of the key array. |
| TValue | The type of the elements of the items array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.RankException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.RankException 'System.RankException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

##### Remarks



<a name='M-KeepCoding-ArrayHelper-TrueForAll``1-``0[],System-Predicate{``0}-'></a>
### TrueForAll\`\`1(array,match) `method`

##### Summary

Determines whether every element in the array matches the conditions defined by the specified predicate.

##### Returns

`true` if every element in `array` matches the conditions defined by the specified predicate; otherwise, `false`. If there are no elements in the array, the return value is `true`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to check against the conditions. |
| match | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The predicate that defines the conditions to check against the elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks



<a name='T-KeepCoding-AudioScript'></a>
## AudioScript `type`

##### Namespace

KeepCoding

##### Summary

Advanced audio handler. Written by Emik.

<a name='F-KeepCoding-AudioScript-_audioClips'></a>
### _audioClips `constants`

##### Summary

The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of clips it can play from.

<a name='F-KeepCoding-AudioScript-_audioSource'></a>
### _audioSource `constants`

##### Summary

The audio source field.

<a name='F-KeepCoding-AudioScript-_isSFX'></a>
### _isSFX `constants`

##### Summary

Setting this value to true will make the volume relative to [MusicVolume](#P-KeepCoding-Game-PlayerSettings-MusicVolume 'KeepCoding.Game.PlayerSettings.MusicVolume'), and [SFXVolume](#P-KeepCoding-Game-PlayerSettings-SFXVolume 'KeepCoding.Game.PlayerSettings.SFXVolume') otherwise.

<a name='P-KeepCoding-AudioScript-AudioClips'></a>
### AudioClips `property`

<a name='P-KeepCoding-AudioScript-AudioSource'></a>
### AudioSource `property`

<a name='P-KeepCoding-AudioScript-Game'></a>
### Game `property`

<a name='P-KeepCoding-AudioScript-IsMuted'></a>
### IsMuted `property`

<a name='P-KeepCoding-AudioScript-IsPlaying'></a>
### IsPlaying `property`

<a name='P-KeepCoding-AudioScript-Relative'></a>
### Relative `property`

<a name='P-KeepCoding-AudioScript-Volume'></a>
### Volume `property`

<a name='M-KeepCoding-AudioScript-Fade-System-Single,System-Single-'></a>
### Fade(volume,time) `method`

##### Summary

Fades the audio source to a specific volume from a specified duration of time linearly.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| volume | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The volume to get to. |
| time | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount of time it takes to get to `volume`. |

<a name='M-KeepCoding-AudioScript-Pause'></a>
### Pause() `method`

##### Summary

Pauses playing the clip.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-AudioScript-Play-UnityEngine-AudioClip,System-Boolean,System-Byte,System-Single,System-Single,System-Single,System-Single-'></a>
### Play(clip,volume,loop,priority,delay,time,pitch) `method`

##### Summary

Plays a sound, with optional parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clip | [UnityEngine.AudioClip](#T-UnityEngine-AudioClip 'UnityEngine.AudioClip') | The sound clip to play. |
| volume | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The volume of the sound clip relative to the game sound. |
| loop | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | If the sound should be looped. |
| priority | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The priority of the sound. |
| delay | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount of delay before the sound starts. |
| time | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The time in the audio it should start playing at. |
| pitch | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The pitch of the sound. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

##### Remarks

The sound can be cancelled with this method, but multiple sounds cannot play simultaneously.

<a name='M-KeepCoding-AudioScript-Play-System-String,System-Boolean,System-Byte,System-Single,System-Single,System-Single,System-Single-'></a>
### Play(name,volume,loop,priority,delay,time,pitch) `method`

##### Summary

Plays a sound, with optional parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the sound clip to play. |
| volume | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The volume of the sound clip relative to the game sound. |
| loop | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | If the sound should be looped. |
| priority | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The priority of the sound. |
| delay | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount of delay before the sound starts. |
| time | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The time in the audio it should start playing at. |
| pitch | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The pitch of the sound. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [UnityEngine.MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') |  |

##### Remarks

The sound can be cancelled with this method, but multiple sounds cannot play simultaneously.

<a name='M-KeepCoding-AudioScript-PlayStackable-UnityEngine-AudioClip,System-Boolean,System-Byte,System-Single,System-Single,System-Single,System-Single-'></a>
### PlayStackable(clip,volume,loop,priority,delay,time,pitch) `method`

##### Summary

Plays a sound, with optional parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clip | [UnityEngine.AudioClip](#T-UnityEngine-AudioClip 'UnityEngine.AudioClip') | The sound clip to play. |
| volume | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The volume of the sound clip relative to the game sound. |
| loop | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | If the sound should be looped. |
| priority | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The priority of the sound. |
| delay | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount of delay before the sound starts. |
| time | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The time in the audio it should start playing at. |
| pitch | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The pitch of the sound. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

##### Remarks

Multiple sounds can be played simultaneously with this method, however they cannot be cancelled.

<a name='M-KeepCoding-AudioScript-PlayStackable-System-String,System-Boolean,System-Byte,System-Single,System-Single,System-Single,System-Single-'></a>
### PlayStackable(name,volume,loop,priority,delay,time,pitch) `method`

##### Summary

Plays a sound, with optional parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the sound clip to play. |
| volume | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The volume of the sound clip relative to the game sound. |
| loop | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | If the sound should be looped. |
| priority | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The priority of the sound. |
| delay | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount of delay before the sound starts. |
| time | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The time in the audio it should start playing at. |
| pitch | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The pitch of the sound. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [UnityEngine.MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') |  |

##### Remarks

Multiple sounds can be played simultaneously with this method, however they cannot be cancelled.

<a name='M-KeepCoding-AudioScript-Stop'></a>
### Stop() `method`

##### Summary

Stops playing the clip.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-AudioScript-Unpause'></a>
### Unpause() `method`

##### Summary

Unpauses the paused playback of this [AudioSource](#P-KeepCoding-AudioScript-AudioSource 'KeepCoding.AudioScript.AudioSource').

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-AudioScript-op_Explicit-KeepCoding-AudioScript-~UnityEngine-AudioSource'></a>
### op_Explicit(dynamicAudio) `method`

##### Summary

Returns the [AudioSource](#P-KeepCoding-AudioScript-AudioSource 'KeepCoding.AudioScript.AudioSource').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dynamicAudio | [KeepCoding.AudioScript)~UnityEngine.AudioSource](#T-KeepCoding-AudioScript-~UnityEngine-AudioSource 'KeepCoding.AudioScript)~UnityEngine.AudioSource') | The instance of [AudioScript](#T-KeepCoding-AudioScript 'KeepCoding.AudioScript') to retrieve [AudioSource](#P-KeepCoding-AudioScript-AudioSource 'KeepCoding.AudioScript.AudioSource') from. |

<a name='T-KeepCoding-BigInteger'></a>
## BigInteger `type`

##### Namespace

KeepCoding

##### Summary

Stores an arbitrarily large number. Written by Emik.

<a name='M-KeepCoding-BigInteger-#ctor-System-Object-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a big integer containing the number specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value to store. [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array'), [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), and any number-type are compatible. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a big integer with the default value. (0)

##### Parameters

This constructor has no parameters.

<a name='P-KeepCoding-BigInteger-GetLowerBound'></a>
### GetLowerBound `property`

<a name='P-KeepCoding-BigInteger-GetUpperBound'></a>
### GetUpperBound `property`

<a name='P-KeepCoding-BigInteger-IsNegative'></a>
### IsNegative `property`

<a name='P-KeepCoding-BigInteger-Item-System-Int32,System-Boolean-'></a>
### Item `property`

##### Summary

Indexable number. Allows you to treat the value as an array.

##### Returns

The current value's `index`th digit.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The `index`th digit to look from. |
| isLeftToRight | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines if the index goes from left-to-right (`true`), or right-to-left (`false`). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') |  |

<a name='P-KeepCoding-BigInteger-Length'></a>
### Length `property`

<a name='P-KeepCoding-BigInteger-One'></a>
### One `property`

<a name='P-KeepCoding-BigInteger-Value'></a>
### Value `property`

##### Summary

The number itself. The instance is duplicated so that the original BigInteger's value may not be modified directly.

<a name='P-KeepCoding-BigInteger-Zero'></a>
### Zero `property`

<a name='M-KeepCoding-BigInteger-Clone'></a>
### Clone() `method`

##### Summary

Makes a new instance/deep clone of [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') with the same value.

##### Returns

A deep clone of itself.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-BigInteger-Clone-KeepCoding-BigInteger-'></a>
### Clone(bigInteger) `method`

##### Summary

Makes a new instance/deep clone of [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') with the same value.

##### Returns

A deep clone of itself.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') to clone. |

<a name='M-KeepCoding-BigInteger-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Determins if both values are equal.

##### Returns

True if both values are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The comparison. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-Equals-KeepCoding-BigInteger-'></a>
### Equals(other) `method`

##### Summary

Determins if both values are equal.

##### Returns

True if both values are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The comparison. |

<a name='M-KeepCoding-BigInteger-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Gets the enumerator of the [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger'), using [Value](#P-KeepCoding-BigInteger-Value 'KeepCoding.BigInteger.Value').

##### Returns

The current number of this [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger').

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-BigInteger-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Gets the hash code of the current values.

##### Returns

The hash code.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-BigInteger-IsBetween-KeepCoding-BigInteger,KeepCoding-BigInteger-'></a>
### IsBetween(min,max) `method`

##### Summary

Determines if it is between 2 other [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') variables. Equality will count as true.

##### Returns

True if `min` is smaller or equal itself and `max` is greater or equal itself.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The minimum value accepted. |
| max | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The maximum value accepted. |

<a name='M-KeepCoding-BigInteger-IsBetween``1-``0,``0-'></a>
### IsBetween\`\`1(min,max) `method`

##### Summary

Determines if it is between 2 other variables. Equality will count as true.

##### Returns

True if `min` is smaller or equal itself and `max` is greater or equal itself.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [\`\`0](#T-``0 '``0') | The minimum value accepted. |
| max | [\`\`0](#T-``0 '``0') | The maximum value accepted. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-Modulo-KeepCoding-BigInteger-'></a>
### Modulo(bigInteger) `method`

##### Summary

Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.

##### Returns

Itself mod `bigInteger`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator. |

<a name='M-KeepCoding-BigInteger-Modulo``1-``0-'></a>
### Modulo\`\`1(obj) `method`

##### Summary

Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.

##### Returns

Itself mod `obj`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`\`0](#T-``0 '``0') | The right-hand side operator. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.DivideByZeroException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DivideByZeroException 'System.DivideByZeroException') |  |
| [KeepCoding.NegativeNumberException](#T-KeepCoding-NegativeNumberException 'KeepCoding.NegativeNumberException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-ToNumber'></a>
### ToNumber() `method`

##### Summary

Converts the BigInteger to a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Returns

Itself as [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |

<a name='M-KeepCoding-BigInteger-ToString'></a>
### ToString() `method`

##### Summary

Converts the current array it stores as a string.

##### Returns

The value of itself.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-BigInteger-op_Addition-KeepCoding-BigInteger,KeepCoding-BigInteger-'></a>
### op_Addition(bigIntegerA,bigIntegerB) `method`

##### Summary

Add operator; gets the sum of 2 numbers.

##### Returns

The sum of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigIntegerA | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| bigIntegerB | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

<a name='M-KeepCoding-BigInteger-op_Addition-KeepCoding-BigInteger,System-Object-'></a>
### op_Addition(bigInteger,value) `method`

##### Summary

Add operator; gets the sum of 2 numbers.

##### Returns

The sum of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Addition-System-Object,KeepCoding-BigInteger-'></a>
### op_Addition(value,bigInteger) `method`

##### Summary

Addition operator; gets the sum of 2 numbers.

##### Returns

The sum of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The left-hand side operator. |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Decrement-KeepCoding-BigInteger-'></a>
### op_Decrement(bigInteger) `method`

##### Summary

Subtraction operator; subtracts 1.

##### Returns

The number - 1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The number. |

<a name='M-KeepCoding-BigInteger-op_Division-KeepCoding-BigInteger,KeepCoding-BigInteger-'></a>
### op_Division(bigIntegerA,bigIntegerB) `method`

##### Summary

Division operator; gets the quotient of 2 numbers.

##### Returns

The quotient of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigIntegerA | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| bigIntegerB | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

<a name='M-KeepCoding-BigInteger-op_Division-KeepCoding-BigInteger,System-Object-'></a>
### op_Division(bigInteger,value) `method`

##### Summary

Division operator; gets the quotient of 2 numbers.

##### Returns

The quotient of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Division-System-Object,KeepCoding-BigInteger-'></a>
### op_Division(value,bigInteger) `method`

##### Summary

Division operator; gets the quotient of 2 numbers.

##### Returns

The quotient of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The left-hand side operator. |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Equality-KeepCoding-BigInteger,KeepCoding-BigInteger-'></a>
### op_Equality(bigIntegerA,bigIntegerB) `method`

##### Summary

Equals operator; determines if both integers contain the same value.

##### Returns

True if both are the same number.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigIntegerA | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator |
| bigIntegerB | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator. |

<a name='M-KeepCoding-BigInteger-op_Equality-KeepCoding-BigInteger,System-Object-'></a>
### op_Equality(bigInteger,value) `method`

##### Summary

Equals operator; determines if both integers contain the same value. The [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') is casted as a [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger').

##### Returns

True if both are the same number.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The right-hand side operator. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Equality-System-Object,KeepCoding-BigInteger-'></a>
### op_Equality(value,bigInteger) `method`

##### Summary

Equals operator; determines if both integers contain the same value. The [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') is casted as a [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger').

##### Returns

True if both are the same number.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The left-hand side operator. |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Explicit-KeepCoding-BigInteger-~KeepCoding-Number'></a>
### op_Explicit(bigInteger) `method`

##### Summary

Converts the [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') to a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Returns

Itself as [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger)~KeepCoding.Number](#T-KeepCoding-BigInteger-~KeepCoding-Number 'KeepCoding.BigInteger)~KeepCoding.Number') | The instance of [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') to convert. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') |  |

<a name='M-KeepCoding-BigInteger-op_GreaterThan-KeepCoding-BigInteger,KeepCoding-BigInteger-'></a>
### op_GreaterThan(bigIntegerA,bigIntegerB) `method`

##### Summary

More than operator; determines if left-hand side has a greater value than right-hand side.

##### Returns

True if `bigIntegerA` is more than `bigIntegerB`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigIntegerA | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| bigIntegerB | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

<a name='M-KeepCoding-BigInteger-op_GreaterThan-KeepCoding-BigInteger,System-Object-'></a>
### op_GreaterThan(bigInteger,value) `method`

##### Summary

More than operator; determines if left-hand side has a greater value than right-hand side.

##### Returns

True if `bigInteger` is more than `value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_GreaterThan-System-Object,KeepCoding-BigInteger-'></a>
### op_GreaterThan(value,bigInteger) `method`

##### Summary

More than operator; determines if left-hand side has a greater value than right-hand side.

##### Returns

True if `value` is more than `bigInteger`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The left-hand side operator. |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_GreaterThanOrEqual-KeepCoding-BigInteger,KeepCoding-BigInteger-'></a>
### op_GreaterThanOrEqual(bigIntegerA,bigIntegerB) `method`

##### Summary

More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.

##### Returns

True if `bigIntegerA` is more than or equal `bigIntegerB`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigIntegerA | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| bigIntegerB | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

<a name='M-KeepCoding-BigInteger-op_GreaterThanOrEqual-KeepCoding-BigInteger,System-Object-'></a>
### op_GreaterThanOrEqual(bigInteger,value) `method`

##### Summary

More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.

##### Returns

True if `bigInteger` is more than or equal `value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_GreaterThanOrEqual-System-Object,KeepCoding-BigInteger-'></a>
### op_GreaterThanOrEqual(value,bigInteger) `method`

##### Summary

More than or equals operator; determines if left-hand side has a greater value or is equal to the right-hand side.

##### Returns

True if `value` is more than or equal `bigInteger`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The left-hand side operator. |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Implicit-KeepCoding-Number-~KeepCoding-BigInteger'></a>
### op_Implicit(value) `method`

##### Summary

Converts the [Number](#T-KeepCoding-Number 'KeepCoding.Number') to a [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger').

##### Returns

[BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') with value `value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [KeepCoding.Number)~KeepCoding.BigInteger](#T-KeepCoding-Number-~KeepCoding-BigInteger 'KeepCoding.Number)~KeepCoding.BigInteger') | The value to convert into [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger'). |

<a name='M-KeepCoding-BigInteger-op_Increment-KeepCoding-BigInteger-'></a>
### op_Increment(bigInteger) `method`

##### Summary

Addition operator; adds 1.

##### Returns

The number + 1.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The number. |

<a name='M-KeepCoding-BigInteger-op_Inequality-KeepCoding-BigInteger,KeepCoding-BigInteger-'></a>
### op_Inequality(bigIntegerA,bigIntegerB) `method`

##### Summary

Not equals operator; determines if both integers do not contain the same value.

##### Returns

True if both are not the same number.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigIntegerA | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator |
| bigIntegerB | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator. |

<a name='M-KeepCoding-BigInteger-op_Inequality-KeepCoding-BigInteger,System-Object-'></a>
### op_Inequality(bigInteger,value) `method`

##### Summary

Not equals operator; determines if both integers do not contain the same value. The [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') is casted as a [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger').

##### Returns

True if both are not the same number.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The right-hand side operator. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Inequality-System-Object,KeepCoding-BigInteger-'></a>
### op_Inequality(value,bigInteger) `method`

##### Summary

Not equals operator; determines if both integers do not contain the same value. The [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') is casted as a [BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger').

##### Returns

True if both are not the same number.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The left-hand side operator |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_LessThan-KeepCoding-BigInteger,KeepCoding-BigInteger-'></a>
### op_LessThan(bigIntegerA,bigIntegerB) `method`

##### Summary

Less than operator; determines if left-hand side has a lesser value than right-hand side.

##### Returns

True if `bigIntegerA` is less than `bigIntegerB`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigIntegerA | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| bigIntegerB | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

<a name='M-KeepCoding-BigInteger-op_LessThan-KeepCoding-BigInteger,System-Object-'></a>
### op_LessThan(bigInteger,value) `method`

##### Summary

Less than operator; determines if left-hand side has a lesser value than right-hand side.

##### Returns

True if `bigInteger` is less than `value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_LessThan-System-Object,KeepCoding-BigInteger-'></a>
### op_LessThan(value,bigInteger) `method`

##### Summary

Less than operator; determines if left-hand side has a lesser value than right-hand side.

##### Returns

True if `value` is less than `bigInteger`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The left-hand side operator. |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_LessThanOrEqual-KeepCoding-BigInteger,KeepCoding-BigInteger-'></a>
### op_LessThanOrEqual(bigIntegerA,bigIntegerB) `method`

##### Summary

Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.

##### Returns

True if `bigIntegerA` is less than or equal `bigIntegerB`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigIntegerA | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| bigIntegerB | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

<a name='M-KeepCoding-BigInteger-op_LessThanOrEqual-KeepCoding-BigInteger,System-Object-'></a>
### op_LessThanOrEqual(bigInteger,value) `method`

##### Summary

Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.

##### Returns

True if `bigInteger` is less than or equal `value`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_LessThanOrEqual-System-Object,KeepCoding-BigInteger-'></a>
### op_LessThanOrEqual(value,bigInteger) `method`

##### Summary

Less than or equals operator; determines if left-hand side has a lesser value or is equal to the right-hand side.

##### Returns

True if `value` is less than or equal `bigInteger`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The left-hand side operator. |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Modulus-KeepCoding-BigInteger,KeepCoding-BigInteger-'></a>
### op_Modulus(bigIntegerA,bigIntegerB) `method`

##### Summary

Modulo operator; gets the modulo of 2 numbers.

##### Returns

The modulo of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigIntegerA | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| bigIntegerB | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

<a name='M-KeepCoding-BigInteger-op_Modulus-KeepCoding-BigInteger,System-Object-'></a>
### op_Modulus(bigInteger,value) `method`

##### Summary

Modulo operator; gets the modulo of 2 numbers.

##### Returns

The modulo of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Modulus-System-Object,KeepCoding-BigInteger-'></a>
### op_Modulus(value,bigInteger) `method`

##### Summary

Modulo operator; gets the modulo of 2 numbers.

##### Returns

The modulo of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The left-hand side operator. |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Multiply-KeepCoding-BigInteger,KeepCoding-BigInteger-'></a>
### op_Multiply(bigIntegerA,bigIntegerB) `method`

##### Summary

Multiplication operator; gets the product of 2 numbers.

##### Returns

The product of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigIntegerA | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| bigIntegerB | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

<a name='M-KeepCoding-BigInteger-op_Multiply-KeepCoding-BigInteger,System-Object-'></a>
### op_Multiply(bigInteger,value) `method`

##### Summary

Multiplication operator; gets the product of 2 numbers.

##### Returns

The product of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Multiply-System-Object,KeepCoding-BigInteger-'></a>
### op_Multiply(value,bigInteger) `method`

##### Summary

Multiplication operator; gets the product of 2 numbers.

##### Returns

The product of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The left-hand side operator. |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Subtraction-KeepCoding-BigInteger,KeepCoding-BigInteger-'></a>
### op_Subtraction(bigIntegerA,bigIntegerB) `method`

##### Summary

Subtraction operator; gets the difference of 2 numbers.

##### Returns

The difference of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigIntegerA | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| bigIntegerB | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

<a name='M-KeepCoding-BigInteger-op_Subtraction-KeepCoding-BigInteger,System-Object-'></a>
### op_Subtraction(bigInteger,value) `method`

##### Summary

Subtraction operator; gets the difference of 2 numbers.

##### Returns

The difference of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The left-hand side operator. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_Subtraction-System-Object,KeepCoding-BigInteger-'></a>
### op_Subtraction(value,bigInteger) `method`

##### Summary

Subtraction operator; gets the difference of 2 numbers.

##### Returns

The difference of both sides.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The left-hand side operator. |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-BigInteger-op_UnaryNegation-KeepCoding-BigInteger-'></a>
### op_UnaryNegation(bigInteger) `method`

##### Summary

Negative operator; inverts [IsNegative](#P-KeepCoding-BigInteger-IsNegative 'KeepCoding.BigInteger.IsNegative').

##### Returns

The number, inverting [IsNegative](#P-KeepCoding-BigInteger-IsNegative 'KeepCoding.BigInteger.IsNegative').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The number. |

<a name='M-KeepCoding-BigInteger-op_UnaryPlus-KeepCoding-BigInteger-'></a>
### op_UnaryPlus(bigInteger) `method`

##### Summary

Positive operator; returns itself.

##### Returns

The number.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The number. |

<a name='T-KeepCoding-CacheableBehaviour'></a>
## CacheableBehaviour `type`

##### Namespace

KeepCoding

##### Summary

A [MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') with additional caching capabilities. Written by Emik.

<a name='M-KeepCoding-CacheableBehaviour-Cache``1-System-Func{``0[]},System-Boolean-'></a>
### Cache\`\`1(func,allowNull) `method`

##### Summary

Caches the result of a function call that returns a component array in a dictionary, and will return the cached result if called again. Use this to alleviate expensive function calls.

##### Returns

The components specified by `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.Func{\`\`0[]}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0[]}') | The expensive function to call, only if it hasn't ever been called by this method on the current instance before. |
| allowNull | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should throw an exception if it sees `null`, if not it will return the default value. (Likely `null`) |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of component to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') |  |

<a name='M-KeepCoding-CacheableBehaviour-Cache``1-System-Func{System-Boolean,``0[]},System-Boolean,System-Boolean-'></a>
### Cache\`\`1(func,parameter,allowNull) `method`

##### Summary

Caches the result of a function call that returns a component array in a dictionary, and will return the cached result if called again. Use this to alleviate expensive function calls.

##### Returns

The components specified by `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.Func{System.Boolean,\`\`0[]}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Boolean,``0[]}') | The expensive function to call, only if it hasn't ever been called by this method on the current instance before. |
| parameter | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The argument to put in the expensive method call. |
| allowNull | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should throw an exception if it sees `null`, if not it will return the default value. (Likely `null`) |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of component to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') |  |

<a name='M-KeepCoding-CacheableBehaviour-FindAll``1-System-Boolean-'></a>
### FindAll\`\`1(allowNull) `method`

##### Summary

Similar to [FindObjectsOfType\`\`1](#M-UnityEngine-Object-FindObjectsOfType``1 'UnityEngine.Object.FindObjectsOfType``1'), however it caches the result in a dictionary, and will return the cached result if called again.

##### Returns

The component specified by `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| allowNull | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should throw an exception if it sees `null`, if not it will return the default value. (Likely `null`) |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of component to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') |  |

<a name='M-KeepCoding-CacheableBehaviour-Find``1-System-Boolean-'></a>
### Find\`\`1(allowNull) `method`

##### Summary

Similar to [FindObjectsOfType\`\`1](#M-UnityEngine-Object-FindObjectsOfType``1 'UnityEngine.Object.FindObjectsOfType``1'), however it caches the result in a dictionary, and will return the cached result if called again.

##### Returns

The component specified by `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| allowNull | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should throw an exception if it sees `null`, if not it will return the default value. (Likely `null`) |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of component to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') |  |

<a name='M-KeepCoding-CacheableBehaviour-GetChild``1-System-Boolean,System-Boolean-'></a>
### GetChild\`\`1(includeInactive,allowNull) `method`

##### Summary

Similar to [GetComponentInChildren\`\`1](#M-UnityEngine-Component-GetComponentInChildren``1 'UnityEngine.Component.GetComponentInChildren``1'), however it caches the result in a dictionary, and will return the cached result if called again.

##### Returns

The component specified by `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| includeInactive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should include inactive components. |
| allowNull | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should throw an exception if it sees `null`, if not it will return the default value. (Likely `null`) |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of component to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') |  |

<a name='M-KeepCoding-CacheableBehaviour-GetChildren``1-System-Boolean,System-Boolean-'></a>
### GetChildren\`\`1(includeInactive,allowNull) `method`

##### Summary

Similar to [GetComponentsInChildren\`\`1](#M-UnityEngine-GameObject-GetComponentsInChildren``1 'UnityEngine.GameObject.GetComponentsInChildren``1'), however it caches the result in a dictionary, and will return the cached result if called again.

##### Returns

The component specified by `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| includeInactive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should include inactive components. |
| allowNull | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should throw an exception if it sees `null`, if not it will return the default value. (Likely `null`) |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of component to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') |  |

<a name='M-KeepCoding-CacheableBehaviour-GetParent``1-System-Boolean,System-Boolean-'></a>
### GetParent\`\`1(includeInactive,allowNull) `method`

##### Summary

Similar to [GetComponentInChildren\`\`1](#M-UnityEngine-Component-GetComponentInChildren``1 'UnityEngine.Component.GetComponentInChildren``1'), however it caches the result in a dictionary, and will return the cached result if called again.

##### Returns

The component specified by `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| includeInactive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should include inactive components. |
| allowNull | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should throw an exception if it sees `null`, if not it will return the default value. (Likely `null`) |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of component to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') |  |

<a name='M-KeepCoding-CacheableBehaviour-GetParents``1-System-Boolean,System-Boolean-'></a>
### GetParents\`\`1(includeInactive,allowNull) `method`

##### Summary

Similar to [GetComponentsInParent\`\`1](#M-UnityEngine-GameObject-GetComponentsInParent``1 'UnityEngine.GameObject.GetComponentsInParent``1'), however it caches the result in a dictionary, and will return the cached result if called again.

##### Returns

The component specified by `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| includeInactive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should include inactive components. |
| allowNull | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should throw an exception if it sees `null`, if not it will return the default value. (Likely `null`) |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of component to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') |  |

<a name='M-KeepCoding-CacheableBehaviour-Get``1-System-Boolean-'></a>
### Get\`\`1(allowNull) `method`

##### Summary

Similar to [GetComponent\`\`1](#M-UnityEngine-Component-GetComponent``1 'UnityEngine.Component.GetComponent``1'), however it caches the result in a dictionary, and will return the cached result if called again.

##### Returns

The component specified by `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| allowNull | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should throw an exception if it sees `null`, if not it will return the default value. (Likely `null`) |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of component to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') |  |

<a name='M-KeepCoding-CacheableBehaviour-Gets``1-System-Boolean-'></a>
### Gets\`\`1(allowNull) `method`

##### Summary

Similar to [GetComponents\`\`1](#M-UnityEngine-GameObject-GetComponents``1 'UnityEngine.GameObject.GetComponents``1'), however it caches the result in a dictionary, and will return the cached result if called again.

##### Returns

The component specified by `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| allowNull | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should throw an exception if it sees `null`, if not it will return the default value. (Likely `null`) |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of component to search for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') |  |

<a name='T-KeepCoding-ComponentPool'></a>
## ComponentPool `type`

##### Namespace

KeepCoding

##### Summary

A ComponentPool is a collection of Module Types. The generator will pick Count times from this list and instantiate a component of the chosen type. Written by Emik.

<a name='M-KeepCoding-ComponentPool-#ctor-System-Int32,KeepCoding-ComponentPool-ComponentSource,KeepCoding-ComponentPool-SpecialComponentTypeEnum,System-Collections-Generic-List{System-String},System-Collections-Generic-List{KeepCoding-ComponentPool-ComponentTypeEnum}-'></a>
### #ctor(count,allowedSources,specialComponentType,modTypes,componentTypes) `constructor`

##### Summary

Creates a Component pool.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | How many components from this pool should be selected. |
| allowedSources | [KeepCoding.ComponentPool.ComponentSource](#T-KeepCoding-ComponentPool-ComponentSource 'KeepCoding.ComponentPool.ComponentSource') | Controls where components can come from (either the base game, mods, or both). |
| specialComponentType | [KeepCoding.ComponentPool.SpecialComponentTypeEnum](#T-KeepCoding-ComponentPool-SpecialComponentTypeEnum 'KeepCoding.ComponentPool.SpecialComponentTypeEnum') | Special types which are calculated at runtime, such as [ALL_SOLVABLE](#F-KeepCoding-ComponentPool-SpecialComponentTypeEnum-ALL_SOLVABLE 'KeepCoding.ComponentPool.SpecialComponentTypeEnum.ALL_SOLVABLE'). |
| modTypes | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | A list of mod types to be included in the pool, if they exist. |
| componentTypes | [System.Collections.Generic.List{KeepCoding.ComponentPool.ComponentTypeEnum}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{KeepCoding.ComponentPool.ComponentTypeEnum}') | The list of component types, not including any calculated at runtime special types, like ALL_SOLVABLE. Use GetComponentTypes to get the calculated list. |

<a name='P-KeepCoding-ComponentPool-AllowedSources'></a>
### AllowedSources `property`

<a name='P-KeepCoding-ComponentPool-ComponentTypes'></a>
### ComponentTypes `property`

<a name='P-KeepCoding-ComponentPool-Count'></a>
### Count `property`

<a name='P-KeepCoding-ComponentPool-ModTypes'></a>
### ModTypes `property`

<a name='P-KeepCoding-ComponentPool-SpecialComponentType'></a>
### SpecialComponentType `property`

<a name='M-KeepCoding-ComponentPool-ToString'></a>
### ToString() `method`

##### Summary

Converts itself to a string.

##### Returns

The list of mod types with a count at the end.

##### Parameters

This method has no parameters.

<a name='T-KeepCoding-ComponentPool-ComponentSource'></a>
## ComponentSource `type`

##### Namespace

KeepCoding.ComponentPool

##### Summary

Controls where this pool will draw from (e.g. the base game modules, modules from mods, or both).

<a name='F-KeepCoding-ComponentPool-ComponentSource-Base'></a>
### Base `constants`

<a name='F-KeepCoding-ComponentPool-ComponentSource-Mods'></a>
### Mods `constants`

<a name='T-KeepCoding-ComponentPool-ComponentTypeEnum'></a>
## ComponentTypeEnum `type`

##### Namespace

KeepCoding.ComponentPool

##### Summary

The module types in the base game.

<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-BigButton'></a>
### BigButton `constants`

##### Remarks



<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-Empty'></a>
### Empty `constants`

<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-Keypad'></a>
### Keypad `constants`

##### Remarks



<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-Maze'></a>
### Maze `constants`

##### Remarks



<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-Memory'></a>
### Memory `constants`

##### Remarks



<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-Mod'></a>
### Mod `constants`

<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-Morse'></a>
### Morse `constants`

##### Remarks



<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-NeedyCapacitor'></a>
### NeedyCapacitor `constants`

##### Remarks



<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-NeedyKnob'></a>
### NeedyKnob `constants`

##### Remarks



<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-NeedyMod'></a>
### NeedyMod `constants`

<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-NeedyVentGas'></a>
### NeedyVentGas `constants`

##### Remarks



<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-Password'></a>
### Password `constants`

##### Remarks



<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-Simon'></a>
### Simon `constants`

##### Remarks



<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-Timer'></a>
### Timer `constants`

<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-Venn'></a>
### Venn `constants`

##### Remarks



<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-WhosOnFirst'></a>
### WhosOnFirst `constants`

##### Remarks



<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-WireSequence'></a>
### WireSequence `constants`

##### Remarks



<a name='F-KeepCoding-ComponentPool-ComponentTypeEnum-Wires'></a>
### Wires `constants`

##### Remarks



<a name='T-KeepCoding-ConstructorArgumentException'></a>
## ConstructorArgumentException `type`

##### Namespace

KeepCoding

##### Summary

An exception thrown when the constructor throws an exception due to a bad argument. Written by Emik.

<a name='M-KeepCoding-ConstructorArgumentException-#ctor'></a>
### #ctor() `constructor`

##### Summary

An exception thrown when the constructor throws an exception due to a bad argument.

##### Parameters

This constructor has no parameters.

<a name='M-KeepCoding-ConstructorArgumentException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

An exception thrown when the constructor throws an exception due to a bad argument.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |

<a name='M-KeepCoding-ConstructorArgumentException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

An exception thrown when the constructor throws an exception due to a bad argument.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | An [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') within this exception. |

<a name='T-KeepCoding-Game-ControlType'></a>
## ControlType `type`

##### Namespace

KeepCoding.Game

##### Summary

Determines how the game is controlled.

<a name='F-KeepCoding-Game-ControlType-Gamepad'></a>
### Gamepad `constants`

<a name='F-KeepCoding-Game-ControlType-Gaze'></a>
### Gaze `constants`

<a name='F-KeepCoding-Game-ControlType-Motion'></a>
### Motion `constants`

<a name='F-KeepCoding-Game-ControlType-Mouse'></a>
### Mouse `constants`

<a name='F-KeepCoding-Game-ControlType-ThreeDOF'></a>
### ThreeDOF `constants`

<a name='F-KeepCoding-Game-ControlType-Touch'></a>
### Touch `constants`

<a name='T-KeepCoding-EmptyIteratorException'></a>
## EmptyIteratorException `type`

##### Namespace

KeepCoding

##### Summary

An exception thrown when the iterator is empty. Written by Emik.

<a name='M-KeepCoding-EmptyIteratorException-#ctor'></a>
### #ctor() `constructor`

##### Summary

An exception thrown when the iterator is empty.

##### Parameters

This constructor has no parameters.

<a name='M-KeepCoding-EmptyIteratorException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

An exception thrown when the iterator is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |

<a name='M-KeepCoding-EmptyIteratorException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

An exception thrown when the iterator is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | An [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') within this exception. |

<a name='T-KeepCoding-EventHelper'></a>
## EventHelper `type`

##### Namespace

KeepCoding

##### Summary

KMFramework extension methods that makes it easier to assign multiple events to a variable in one statement. Written by Emik.

<a name='M-KeepCoding-EventHelper-Assign-KMBombInfo,System-Action,System-Action-'></a>
### Assign(bombInfo,onBombExploded,onBombSolved) `method`

##### Summary

Assigns events specified into `bombInfo`. Reassigning them will replace their values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bombInfo | [KMBombInfo](#T-KMBombInfo 'KMBombInfo') | The bomb info instance to assign events to. |
| onBombExploded | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the bomb explodes. |
| onBombSolved | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the bomb is defused. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.UnassignedReferenceException](#T-UnityEngine-UnassignedReferenceException 'UnityEngine.UnassignedReferenceException') |  |

##### Remarks

An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions or Functions.

<a name='M-KeepCoding-EventHelper-Assign-KMBombModule,System-Action,System-Action,System-Action-'></a>
### Assign(bombModule,onActivate,onPass,onStrike) `method`

##### Summary

Assigns events specified into `bombModule`. Reassigning them will replace their values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bombModule | [KMBombModule](#T-KMBombModule 'KMBombModule') | The bomb instance to assign events to. |
| onActivate | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the lights turn on. |
| onPass | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the module is solved. |
| onStrike | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the module strikes. |

##### Remarks

An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions or Functions.

<a name='M-KeepCoding-EventHelper-Assign-KMGameInfo,System-Action{KMGameInfo-State},System-Action{System-Boolean},System-Action{System-Boolean}-'></a>
### Assign(gameInfo,onStateChange,onAlarmClockChange,onLightsChange) `method`

##### Summary

Assigns events specified into `gameInfo`. Reassigning them will replace their values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameInfo | [KMGameInfo](#T-KMGameInfo 'KMGameInfo') | The game info instance to assign events to. |
| onStateChange | [System.Action{KMGameInfo.State}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMGameInfo.State}') | Called when the state of the game changes. |
| onAlarmClockChange | [System.Action{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Boolean}') | Called when the alarm clock changes state, and passes in whether it's on or off. |
| onLightsChange | [System.Action{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Boolean}') | Called when the lights change state, and passes in whether it's on or off. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.UnassignedReferenceException](#T-UnityEngine-UnassignedReferenceException 'UnityEngine.UnassignedReferenceException') |  |

##### Remarks

An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions.

<a name='M-KeepCoding-EventHelper-Assign-KMNeedyModule,System-Action,System-Action,System-Action,System-Action,System-Action,System-Action-'></a>
### Assign(needyModule,onActivate,onNeedyActivation,onNeedyDeactivation,onPass,onStrike,onTimerExpired) `method`

##### Summary

Assigns events specified into `needyModule`. Reassigning them will replace their values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| needyModule | [KMNeedyModule](#T-KMNeedyModule 'KMNeedyModule') | The needy instance to assign events to. |
| onActivate | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the lights turn on. |
| onNeedyActivation | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the needy activates. |
| onNeedyDeactivation | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the needy deactivates. |
| onPass | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the needy is solved. |
| onStrike | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the needy strikes. |
| onTimerExpired | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the timer runs out of time. |

##### Remarks

An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions or Functions.

<a name='M-KeepCoding-EventHelper-Assign-KMSelectable,System-Nullable{System-Boolean},System-Action,System-Action,System-Action,System-Action,System-Action,System-Action,System-Action,System-Action,System-Action{System-Single},System-Action,System-Action,System-Action,System-Action{KMSelectable}-'></a>
### Assign(selectable,overrideReturn,onCancel,onDefocus,onDeselect,onFocus,onHighlight,onHighlightEnded,onInteract,onInteractEnded,onInteractionPunch,onLeft,onRight,onSelect,onUpdateChildren) `method`

##### Summary

Assigns events specified into `selectable`. Reassigning them will replace their values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| selectable | [KMSelectable](#T-KMSelectable 'KMSelectable') | The KMSelectable array to add events to. |
| overrideReturn | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | True will make it act as a module/submodule, and false as a button. Null (default) will set it to true or false based on [IsParent](#M-KeepCoding-Helper-IsParent-KMSelectable- 'KeepCoding.Helper.IsParent(KMSelectable)'). Note that in VR, [OnHighlight](#F-KMSelectable-OnHighlight 'KMSelectable.OnHighlight') and [OnHighlightEnded](#F-KMSelectable-OnHighlightEnded 'KMSelectable.OnHighlightEnded') are skipped out on. |
| onCancel | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when player backs out of this selectable. Return true will make it act as a module/submodule, and false as a button. |
| onDefocus | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when a different selectable becomes the focus, or the module has been backed out of. |
| onDeselect | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the selectable stops being the current selectable. |
| onFocus | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when a module is focused, this is when it is interacted with from the bomb face level and its children can be selected. |
| onHighlight | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the highlight is turned on. |
| onHighlightEnded | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the highlight is turned off. |
| onInteract | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when player interacts with the selctable. Return true will make it act as a module/submodule, and false as a button. |
| onInteractEnded | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when a player interacting with the selectable releases the mouse or controller button. |
| onInteractionPunch | [System.Action{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Single}') | Called when the interaction punch method is called. |
| onLeft | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the left controller stick is pulled while selected. |
| onRight | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the right controller stick is pulled while selected. |
| onSelect | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called whenever the selectable becomes the current selectable. |
| onUpdateChildren | [System.Action{KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable}') | Called when the selectable updates its children. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.UnassignedReferenceException](#T-UnityEngine-UnassignedReferenceException 'UnityEngine.UnassignedReferenceException') |  |

##### Remarks

An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions.

<a name='M-KeepCoding-EventHelper-Assign-KMSelectable[],System-Nullable{System-Boolean},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32,System-Single},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32},System-Action{System-Int32,KMSelectable}-'></a>
### Assign(selectable,overrideReturn,onCancel,onDefocus,onDeselect,onFocus,onHighlight,onHighlightEnded,onInteract,onInteractEnded,onInteractionPunch,onLeft,onRight,onSelect,onUpdateChildren) `method`

##### Summary

Assigns events specified into `selectable`. Reassigning them will replace their values. The number passed into each method represents the index that came from the array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| selectable | [KMSelectable[]](#T-KMSelectable[] 'KMSelectable[]') | The [KMSelectable](#T-KMSelectable 'KMSelectable') array to add events to. |
| overrideReturn | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | True will make it act as a module/submodule, and false as a button. Null (default) will set it to true or false based on [IsParent](#M-KeepCoding-Helper-IsParent-KMSelectable- 'KeepCoding.Helper.IsParent(KMSelectable)'). Note that in VR, [OnHighlight](#F-KMSelectable-OnHighlight 'KMSelectable.OnHighlight') and [OnHighlightEnded](#F-KMSelectable-OnHighlightEnded 'KMSelectable.OnHighlightEnded') are skipped out on. |
| onCancel | [System.Action{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32}') | Called when player backs out of this selectable. |
| onDefocus | [System.Action{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32}') | Called when a different selectable becomes the focus, or the module has been backed out of. |
| onDeselect | [System.Action{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32}') | Called when the selectable stops being the current selectable. |
| onFocus | [System.Action{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32}') | Called when a module is focused, this is when it is interacted with from the bomb face level and its children can be selected. |
| onHighlight | [System.Action{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32}') | Called when the highlight is turned on. |
| onHighlightEnded | [System.Action{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32}') | Called when the highlight is turned off. |
| onInteract | [System.Action{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32}') | Called when player interacts with the selctable. |
| onInteractEnded | [System.Action{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32}') | Called when a player interacting with the selectable releases the mouse or controller button. |
| onInteractionPunch | [System.Action{System.Int32,System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32,System.Single}') | Called when the interaction punch method is called. |
| onLeft | [System.Action{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32}') | Called when the left controller stick is pulled while selected. |
| onRight | [System.Action{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32}') | Called when the right controller stick is pulled while selected. |
| onSelect | [System.Action{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32}') | Called whenever the selectable becomes the current selectable. |
| onUpdateChildren | [System.Action{System.Int32,KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Int32,KMSelectable}') | Called when the selectable updates its children. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |
| [UnityEngine.UnassignedReferenceException](#T-UnityEngine-UnassignedReferenceException 'UnityEngine.UnassignedReferenceException') |  |

##### Remarks

An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions.

<a name='M-KeepCoding-EventHelper-Assign-KMSelectable[],System-Nullable{System-Boolean},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable,System-Single},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable},System-Action{KMSelectable,KMSelectable}-'></a>
### Assign(selectable,overrideReturn,onCancel,onDefocus,onDeselect,onFocus,onHighlight,onHighlightEnded,onInteract,onInteractEnded,onInteractionPunch,onLeft,onRight,onSelect,onUpdateChildren) `method`

##### Summary

Assigns events specified into `selectable`. Reassigning them will replace their values. The number passed into each method represents the index that came from the array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| selectable | [KMSelectable[]](#T-KMSelectable[] 'KMSelectable[]') | The [KMSelectable](#T-KMSelectable 'KMSelectable') array to add events to. |
| overrideReturn | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | True will make it act as a module/submodule, and false as a button. Null (default) will set it to true or false based on [IsParent](#M-KeepCoding-Helper-IsParent-KMSelectable- 'KeepCoding.Helper.IsParent(KMSelectable)'). Note that in VR, [OnHighlight](#F-KMSelectable-OnHighlight 'KMSelectable.OnHighlight') and [OnHighlightEnded](#F-KMSelectable-OnHighlightEnded 'KMSelectable.OnHighlightEnded') are skipped out on. |
| onCancel | [System.Action{KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable}') | Called when player backs out of this selectable. |
| onDefocus | [System.Action{KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable}') | Called when a different selectable becomes the focus, or the module has been backed out of. |
| onDeselect | [System.Action{KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable}') | Called when the selectable stops being the current selectable. |
| onFocus | [System.Action{KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable}') | Called when a module is focused, this is when it is interacted with from the bomb face level and its children can be selected. |
| onHighlight | [System.Action{KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable}') | Called when the highlight is turned on. |
| onHighlightEnded | [System.Action{KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable}') | Called when the highlight is turned off. |
| onInteract | [System.Action{KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable}') | Called when player interacts with the selctable. |
| onInteractEnded | [System.Action{KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable}') | Called when a player interacting with the selectable releases the mouse or controller button. |
| onInteractionPunch | [System.Action{KMSelectable,System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable,System.Single}') | Called when the interaction punch method is called. |
| onLeft | [System.Action{KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable}') | Called when the left controller stick is pulled while selected. |
| onRight | [System.Action{KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable}') | Called when the right controller stick is pulled while selected. |
| onSelect | [System.Action{KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable}') | Called whenever the selectable becomes the current selectable. |
| onUpdateChildren | [System.Action{KMSelectable,KMSelectable}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{KMSelectable,KMSelectable}') | Called when the selectable updates its children. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |
| [UnityEngine.UnassignedReferenceException](#T-UnityEngine-UnassignedReferenceException 'UnityEngine.UnassignedReferenceException') |  |

##### Remarks

An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions.

<a name='M-KeepCoding-EventHelper-Cast``1-System-Delegate-'></a>
### Cast\`\`1(dele) `method`

##### Summary

Casts a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') onto the type `T`.

##### Returns

`dele` as `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dele | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | The delegate to cast. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to cast the delegate into. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks

Both types must have the same parameter and return types, and the `dele` argument cannot have its [Target](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate.Target 'System.Delegate.Target') or [Method](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate.Method 'System.Delegate.Method') be null.

<a name='M-KeepCoding-EventHelper-Combine-System-Action,System-Action[]-'></a>
### Combine(self,others) `method`

##### Summary

Combines actions together, only if these actions are not `null`.

##### Returns

`self` with `others` appended.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to modify. |
| others | [System.Action[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action[] 'System.Action[]') | The actions to combine with `self`. |

<a name='M-KeepCoding-EventHelper-Combine``1-System-Action{``0},System-Action{``0}[]-'></a>
### Combine\`\`1(self,others) `method`

##### Summary

Combines actions together, only if these actions are not `null`.

##### Returns

`self` with `others` appended.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | The action to modify. |
| others | [System.Action{\`\`0}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}[]') | The actions to combine with `self`. |

<a name='M-KeepCoding-EventHelper-Combine``1-System-Func{``0},System-Func{``0}[]-'></a>
### Combine\`\`1(self,others) `method`

##### Summary

Combines actions together, only if these functions are not `null`.

##### Returns

`self` with `others` appended.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | The function to modify. |
| others | [System.Func{\`\`0}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}[]') | The functions to combine with `self`. |

<a name='M-KeepCoding-EventHelper-Combine``2-System-Action{``0,``1},System-Action{``0,``1}[]-'></a>
### Combine\`\`2(self,others) `method`

##### Summary

Combines actions together, only if these actions are not `null`.

##### Returns

`self` with `others` appended.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Action{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0,``1}') | The action to modify. |
| others | [System.Action{\`\`0,\`\`1}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0,``1}[]') | The actions to combine with `self`. |

<a name='M-KeepCoding-EventHelper-Combine``2-System-Func{``0,``1},System-Func{``0,``1}[]-'></a>
### Combine\`\`2(self,others) `method`

##### Summary

Combines actions together, only if these functions are not `null`.

##### Returns

`self` with `others` appended.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | The function to modify. |
| others | [System.Func{\`\`0,\`\`1}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}[]') | The functions to combine with `self`. |

<a name='M-KeepCoding-EventHelper-Combine``3-System-Action{``0,``1,``2},System-Action{``0,``1,``2}[]-'></a>
### Combine\`\`3(self,others) `method`

##### Summary

Combines actions together, only if these actions are not `null`.

##### Returns

`self` with `others` appended.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Action{\`\`0,\`\`1,\`\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0,``1,``2}') | The action to modify. |
| others | [System.Action{\`\`0,\`\`1,\`\`2}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0,``1,``2}[]') | The actions to combine with `self`. |

<a name='M-KeepCoding-EventHelper-Combine``3-System-Func{``0,``1,``2},System-Func{``0,``1,``2}[]-'></a>
### Combine\`\`3(self,others) `method`

##### Summary

Combines actions together, only if these functions are not `null`.

##### Returns

`self` with `others` appended.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Func{\`\`0,\`\`1,\`\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1,``2}') | The function to modify. |
| others | [System.Func{\`\`0,\`\`1,\`\`2}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1,``2}[]') | The functions to combine with `self`. |

<a name='M-KeepCoding-EventHelper-Combine``4-System-Action{``0,``1,``2,``3},System-Action{``0,``1,``2,``3}[]-'></a>
### Combine\`\`4(self,others) `method`

##### Summary

Combines actions together, only if these actions are not `null`.

##### Returns

`self` with `others` appended.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Action{\`\`0,\`\`1,\`\`2,\`\`3}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0,``1,``2,``3}') | The action to modify. |
| others | [System.Action{\`\`0,\`\`1,\`\`2,\`\`3}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0,``1,``2,``3}[]') | The actions to combine with `self`. |

<a name='M-KeepCoding-EventHelper-Combine``4-System-Func{``0,``1,``2,``3},System-Func{``0,``1,``2,``3}[]-'></a>
### Combine\`\`4(self,others) `method`

##### Summary

Combines actions together, only if these functions are not `null`.

##### Returns

`self` with `others` appended.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Func{\`\`0,\`\`1,\`\`2,\`\`3}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1,``2,``3}') | The function to modify. |
| others | [System.Func{\`\`0,\`\`1,\`\`2,\`\`3}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1,``2,``3}[]') | The functions to combine with `self`. |

<a name='M-KeepCoding-EventHelper-Combine``5-System-Func{``0,``1,``2,``3,``4},System-Func{``0,``1,``2,``3,``4}[]-'></a>
### Combine\`\`5(self,others) `method`

##### Summary

Combines actions together, only if these functions are not `null`.

##### Returns

`self` with `others` appended.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Func{\`\`0,\`\`1,\`\`2,\`\`3,\`\`4}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1,``2,``3,``4}') | The function to modify. |
| others | [System.Func{\`\`0,\`\`1,\`\`2,\`\`3,\`\`4}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1,``2,``3,``4}[]') | The functions to combine with `self`. |

<a name='M-KeepCoding-EventHelper-CreateDelegate``1-System-Delegate-'></a>
### CreateDelegate\`\`1(dele) `method`

##### Summary

Creates a delegate of the specified type.

##### Returns

A delegate of type `T` using `dele`'s target and method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dele | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | The delegate to reference from. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of delegate to create. |

<a name='M-KeepCoding-EventHelper-Set``1-System-Delegate,``0@-'></a>
### Set\`\`1(dele,mutator) `method`

##### Summary

Adds a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') onto the referenced variable.

##### Returns

`mutator` with the value `dele`, or itself if `dele` is null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dele | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | The [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') to add. |
| mutator | [\`\`0@](#T-``0@ '``0@') | The variable that transmutates and adds `dele` onto itself. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the `mutator` and [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') casting. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

<a name='M-KeepCoding-EventHelper-StopSound-KMAudio-KMAudioRef[]-'></a>
### StopSound(audioRefs) `method`

##### Summary

Stops all sounds for the entire [KMAudioRef](#T-KMAudio-KMAudioRef 'KMAudio.KMAudioRef')[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| audioRefs | [KMAudio.KMAudioRef[]](#T-KMAudio-KMAudioRef[] 'KMAudio.KMAudioRef[]') | The [KMAudioRef](#T-KMAudio-KMAudioRef 'KMAudio.KMAudioRef')[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to mute all sounds from, using [StopSound](#F-KMAudio-KMAudioRef-StopSound 'KMAudio.KMAudioRef.StopSound'). |

<a name='M-KeepCoding-EventHelper-StopSound-KeepCoding-Sound[]-'></a>
### StopSound(sounds) `method`

##### Summary

Stops all sounds for the entire [Sound](#T-KeepCoding-Sound 'KeepCoding.Sound')[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sounds | [KeepCoding.Sound[]](#T-KeepCoding-Sound[] 'KeepCoding.Sound[]') | The [Sound](#T-KeepCoding-Sound 'KeepCoding.Sound')[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to mute all sounds from, using [StopSound](#F-KMAudio-KMAudioRef-StopSound 'KMAudio.KMAudioRef.StopSound'). |

<a name='T-KeepCoding-Game'></a>
## Game `type`

##### Namespace

KeepCoding

##### Summary

Allows access into the game's internal code. Written by Emik.

##### Remarks

On the Editor, these properties will return default values. Check the XML documentation to see the value it returns.

<a name='P-KeepCoding-Game-AddStrikes'></a>
### AddStrikes `property`

##### Remarks

Default: Internal Logger method call.

<a name='P-KeepCoding-Game-Bomb'></a>
### Bomb `property`

##### Remarks

Default: `null`.

<a name='P-KeepCoding-Game-SetStrikes'></a>
### SetStrikes `property`

##### Remarks

Default: Internal Logger method call.

<a name='P-KeepCoding-Game-Timer'></a>
### Timer `property`

##### Remarks

Default: `null`.

<a name='P-KeepCoding-Game-Vanillas'></a>
### Vanillas `property`

##### Remarks

Default: An empty [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object')[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

<a name='T-KeepCoding-GeneratorSetting'></a>
## GeneratorSetting `type`

##### Namespace

KeepCoding

##### Summary

Everything needed to generate a single bomb. Written by Emik.

<a name='M-KeepCoding-GeneratorSetting-#ctor-System-Boolean,System-Int32,System-Int32,System-Int32,System-Single,System-Collections-Generic-List{KeepCoding-ComponentPool}-'></a>
### #ctor(frontFaceOnly,optionalWidgetCount,numStrikes,timeBeforeNeedyActivation,timeLimit,componentPools) `constructor`

##### Summary

Creates a generator setting based on the provided parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| frontFaceOnly | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Force modules to be placed only on the front face. By default this will limit the module count to 5 (+1 for the timer). Useful in rare circumstances where you wish to generate a bomb with a few modules and guarantee that they will all be visibile simultaneously. |
| optionalWidgetCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Set how many optional widgets (widgets other than serial number) that should be placed on the bomb. |
| numStrikes | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of strikes at which the bomb explodes. Hardcore is 1. More forgiving is 3. |
| timeBeforeNeedyActivation | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Time, in seconds, which must elapse before any unactivated Needy modules are automatically activated. |
| timeLimit | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | Initial value for the timer when the bomb is activated, in seconds. |
| componentPools | [System.Collections.Generic.List{KeepCoding.ComponentPool}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{KeepCoding.ComponentPool}') | The pools of modules that will be used when generating a bomb. |

<a name='M-KeepCoding-GeneratorSetting-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a generator setting with the default parameters.

##### Parameters

This constructor has no parameters.

<a name='P-KeepCoding-GeneratorSetting-ComponentPools'></a>
### ComponentPools `property`

<a name='P-KeepCoding-GeneratorSetting-FrontFaceOnly'></a>
### FrontFaceOnly `property`

<a name='P-KeepCoding-GeneratorSetting-NumStrikes'></a>
### NumStrikes `property`

<a name='P-KeepCoding-GeneratorSetting-OptionalWidgetCount'></a>
### OptionalWidgetCount `property`

<a name='P-KeepCoding-GeneratorSetting-TimeBeforeNeedyActivation'></a>
### TimeBeforeNeedyActivation `property`

<a name='P-KeepCoding-GeneratorSetting-TimeLimit'></a>
### TimeLimit `property`

<a name='M-KeepCoding-GeneratorSetting-GetComponentCount'></a>
### GetComponentCount() `method`

##### Summary

The total count of modules that will be added according to the component pools.

##### Returns

The amount of components.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-GeneratorSetting-ToString'></a>
### ToString() `method`

##### Summary

Converts itself to a string.

##### Returns

Time, number of strikes, and the pools converted to a string.

##### Parameters

This method has no parameters.

<a name='T-KeepCoding-Helper'></a>
## Helper `type`

##### Namespace

KeepCoding

##### Summary

General extension class covering both KMFramework and native datatypes. Written by Emik.

<a name='F-KeepCoding-Helper-Alphanumeric'></a>
### Alphanumeric `constants`

##### Summary

The entire alphanumeric series, also known as base-62. From 0-9, A-Z, a-z.

<a name='F-KeepCoding-Helper-Binary'></a>
### Binary `constants`

##### Summary

The entire binary series, also known as base-2. From 0-1.

<a name='F-KeepCoding-Helper-Decimal'></a>
### Decimal `constants`

##### Summary

The entire decimal series, also known as base-10. From 0-9.

<a name='F-KeepCoding-Helper-Flags'></a>
### Flags `constants`

##### Summary

Contains the most commonly used flags, use this as a "catch-all" expression.

<a name='M-KeepCoding-Helper-Append``1-System-Collections-Generic-IEnumerable{``0},``0-'></a>
### Append\`\`1(source,item) `method`

##### Summary

Appends the element provided to the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1').

##### Returns

`source`, but with an added `item` as the last index.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to be modified. |
| item | [\`\`0](#T-``0 '``0') | The element to append to the `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The datatype of both the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') and element. |

<a name='M-KeepCoding-Helper-Append``1-``0[],``0-'></a>
### Append\`\`1(array,item) `method`

##### Summary

Appends the element provided to the array.

##### Returns

`array`, but with an added `item` as the last index.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The array to be appended with. |
| item | [\`\`0](#T-``0 '``0') | The element to append to the `array`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The datatype of both the array and element. |

<a name='M-KeepCoding-Helper-Apply``2-``0,System-Func{``0,``1}-'></a>
### Apply\`\`2(item,func) `method`

##### Summary

Invokes a method of `TInput` to `TOutput` and then returns the argument provided.

##### Returns

The item `item` after `func`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The item to use as reference and modify. |
| func | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | The function to apply `item` to. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TInput | The type of `item`. |
| TOutput | The type to return. |

##### Remarks

This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.

<a name='M-KeepCoding-Helper-Apply``2-``0[],System-Func{``0,System-Int32,``1}-'></a>
### Apply\`\`2(items,func) `method`

##### Summary

Invokes a method of `TInput` to `TOutput` and then returns the argument provided.

##### Returns

The item `items` after `func`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [\`\`0[]](#T-``0[] '``0[]') | The item to use as reference and modify. |
| func | [System.Func{\`\`0,System.Int32,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Int32,``1}') | The function to apply `items` to. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TInput | The type of `items`. |
| TOutput | The type to return. |

##### Remarks

This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.

<a name='M-KeepCoding-Helper-AsEnumerable-System-Collections-IEnumerator-'></a>
### AsEnumerable(source) `method`

##### Summary

Converts an [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') to an [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable').

##### Returns

`source` as an [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') | The [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') to convert. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

<a name='M-KeepCoding-Helper-AsEnumerable``1-System-Collections-Generic-IEnumerator{``0}-'></a>
### AsEnumerable\`\`1(source) `method`

##### Summary

Converts an [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') to an [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable').

##### Returns

`source` as an [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerator{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerator 'System.Collections.Generic.IEnumerator{``0}') | The [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') to convert. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The parameter and return type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

<a name='M-KeepCoding-Helper-Assert``1-``0,System-String-'></a>
### Assert\`\`1(obj,message) `method`

##### Summary

Throws a [MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') if the [Object](#T-UnityEngine-Object 'UnityEngine.Object') given is `null`, then returning the [Object](#T-UnityEngine-Object 'UnityEngine.Object')`obj`.

##### Returns

The component `obj`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`\`0](#T-``0 '``0') | The [Object](#T-UnityEngine-Object 'UnityEngine.Object') to do a null check on. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of [Object](#T-UnityEngine-Object 'UnityEngine.Object'). |

<a name='M-KeepCoding-Helper-Base-System-String,System-String,System-String-'></a>
### Base(value,fromBaseChars,toBaseChars) `method`

##### Summary

Converts any base number to any base.

##### Returns

`value`, but in the base specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value to convert. |
| fromBaseChars | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | All of the base characters for the conversion from the base number, use [Alphanumeric](#F-KeepCoding-Helper-Alphanumeric 'KeepCoding.Helper.Alphanumeric') for Base-62, use [Decimal](#F-KeepCoding-Helper-Decimal 'KeepCoding.Helper.Decimal') for Base-10, use [Binary](#F-KeepCoding-Helper-Binary 'KeepCoding.Helper.Binary') for Base-2. The length of the array is the base number. |
| toBaseChars | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | All of the base characters for the conversion to the base number, use [Alphanumeric](#F-KeepCoding-Helper-Alphanumeric 'KeepCoding.Helper.Alphanumeric') for Base-62, use [Decimal](#F-KeepCoding-Helper-Decimal 'KeepCoding.Helper.Decimal') for Base-10, use [Binary](#F-KeepCoding-Helper-Binary 'KeepCoding.Helper.Binary') for Base-2. The length of the array is the base number. |

<a name='M-KeepCoding-Helper-Base-System-String,System-Int32,System-Int32-'></a>
### Base(value,fromBaseNumber,toBaseNumber) `method`

##### Summary

Converts any base number to any base.

##### Returns

The integer, but in the base specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value to convert. |
| fromBaseNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Which base it currently is. |
| toBaseNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Which base to convert it to. |

<a name='M-KeepCoding-Helper-BaseToLong-System-String,System-Int32-'></a>
### BaseToLong(value,baseNumber) `method`

##### Summary

Converts any base number to any base-10.

##### Returns

The integer, but in the base specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value to convert. |
| baseNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Which base it currently is. |

<a name='M-KeepCoding-Helper-BaseToLong-System-String,System-String-'></a>
### BaseToLong(value,baseChars) `method`

##### Summary

Converts any base number to base-10.

##### Returns

`value`, but in the base specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value to convert. |
| baseChars | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | All of the base characters for the conversion from the base number, use [Alphanumeric](#F-KeepCoding-Helper-Alphanumeric 'KeepCoding.Helper.Alphanumeric') for Base-62, use [Decimal](#F-KeepCoding-Helper-Decimal 'KeepCoding.Helper.Decimal') for Base-10, use [Binary](#F-KeepCoding-Helper-Binary 'KeepCoding.Helper.Binary') for Base-2. The length of the array is the base number. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.FormatException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.FormatException 'System.FormatException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

<a name='M-KeepCoding-Helper-Call``1-``0,System-Action{``0}-'></a>
### Call\`\`1(item,action) `method`

##### Summary

Invokes a method of `T` and then returns the argument provided.

##### Returns

The item `item`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The item to use as reference and modify. |
| action | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | The action to apply `item` to. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of `item` and `action`. |

##### Remarks

This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.

<a name='M-KeepCoding-Helper-Call``1-``0,UnityEngine-LogType-'></a>
### Call\`\`1(item,logType) `method`

##### Summary

Invokes a logging method and then returns the argument provided.

##### Returns

The item `item`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The item to log |
| logType | [UnityEngine.LogType](#T-UnityEngine-LogType 'UnityEngine.LogType') | The type of logging. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of logging. |

<a name='M-KeepCoding-Helper-Call``1-``0[],System-Action{``0,System-Int32}-'></a>
### Call\`\`1(source,action) `method`

##### Summary

Invokes a method of `T` and then returns the argument provided.

##### Returns

The item `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`\`0[]](#T-``0[] '``0[]') | The item to use as reference and modify. |
| action | [System.Action{\`\`0,System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0,System.Int32}') | The action to apply `source` to. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of `source` and `action`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

##### Remarks

This can be used to intercept current variables or calculations by for example, printing the value as it is being passed as an argument.

<a name='M-KeepCoding-Helper-DigitalRoot-System-Int32-'></a>
### DigitalRoot(number) `method`

##### Summary

Gets the digital root of the number, which is obtained by repeatedly getting the sum of all digits until 1 digit remains.

##### Returns

The digital root of `number`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number to get the digital root of. |

<a name='M-KeepCoding-Helper-ElementAtWrap``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### ElementAtWrap\`\`1(source,index) `method`

##### Summary

Returns the element of an array, pretending that the array wraps around or is circular.

##### Returns

The element in `source` using `index` with rem-euclid modulo.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The array itself. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index, which will wrap around if it's larger than the array. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the array. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Helper-Exclude``1-System-Collections-Generic-IEnumerable{``0},System-Int32[]-'></a>
### Exclude\`\`1(source,indices) `method`

##### Summary

Removes the elements whose index matches any of the indices.

##### Returns

`source`, but without the element indexing `indices`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to be modified. |
| indices | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The indices to exclude from `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The datatype of both the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'). |

<a name='M-KeepCoding-Helper-Find-System-Collections-Generic-List{System-String},System-String-'></a>
### Find(directories,file) `method`

##### Summary

Finds a file name within a list of directories, or `null` if none is found.

##### Returns

The directory containing the path to the file searched for, or `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| directories | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | The list of directories. |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file to search for. |

<a name='M-KeepCoding-Helper-FirstValue``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0}-'></a>
### FirstValue\`\`1(source,func) `method`

##### Summary

Returns the first element which doesn't return null, or null if all of them return null.

##### Returns

The first value from `source` where `func` doesn't return null, or null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The array to iterate on. |
| func | [System.Func{\`\`0,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``0}') | The method which returns |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of array, and method. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

<a name='M-KeepCoding-Helper-Flatten-System-Collections-IEnumerator,System-Predicate{System-Object}-'></a>
### Flatten(source,unwrap) `method`

##### Summary

Flattens an [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') such that nested [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') calls get replaced with the output of those calls.

##### Returns

`source` where `yield``return`[IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator')s gets replaced with the output of those calls.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') | The [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') to flatten. |
| unwrap | [System.Predicate{System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.Object}') | Determines if it should call [Unwrap\`\`1](#M-KeepCoding-Helper-Unwrap``1-``0,System-Boolean- 'KeepCoding.Helper.Unwrap``1(``0,System.Boolean)') for the item. |

<a name='M-KeepCoding-Helper-Form-System-String,System-Object[]-'></a>
### Form(str,args) `method`

##### Summary

Formats the string. Shorthand for [Format](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Format 'System.String.Format(System.String,System.Object[])').

##### Returns

The formatted [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to format. Typically with placeholders involving {0}, {1}, {2}... |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | All of the arguments to put into `str`. |

<a name='M-KeepCoding-Helper-GetMethodInfo``1-System-Linq-Expressions-Expression{System-Action{``0}}-'></a>
### GetMethodInfo\`\`1(expression) `method`

##### Summary

Gets the method info from an expression.

##### Returns

The method info of the function.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.Linq.Expressions.Expression{System.Action{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Action{``0}}') | The expression that retrieves the method. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the action. |

<a name='M-KeepCoding-Helper-GetNullException``1-``0-'></a>
### GetNullException\`\`1(item) `method`

##### Summary

Gets the appropriate [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') based on the data type.

##### Returns

[NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') if `item` is an iterator, evaluated with [IsIterator\`\`1](#M-KeepCoding-Helper-IsIterator``1-``0- 'KeepCoding.Helper.IsIterator``1(``0)'), otherwise [NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The item to check the type for. |

<a name='M-KeepCoding-Helper-GetUnsolvedModuleIDs-KMBombInfo-'></a>
### GetUnsolvedModuleIDs(bombInfo) `method`

##### Summary

Gives list of module names that are unsolved.

##### Returns

A list of unsolved module names.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bombInfo | [KMBombInfo](#T-KMBombInfo 'KMBombInfo') | The instance of [KMBombInfo](#T-KMBombInfo 'KMBombInfo') needed to get the modules. |

<a name='M-KeepCoding-Helper-GetUnsolvedModuleNames-KMBombInfo-'></a>
### GetUnsolvedModuleNames(bombInfo) `method`

##### Summary

Gives list of module names that are unsolved.

##### Returns

A list of unsolved modules.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bombInfo | [KMBombInfo](#T-KMBombInfo 'KMBombInfo') | The instance of [KMBombInfo](#T-KMBombInfo 'KMBombInfo') needed to get the modules. |

<a name='M-KeepCoding-Helper-GetUpperBound-System-String-'></a>
### GetUpperBound(str) `method`

##### Summary

Returns the last index of the string.

##### Returns

[Length](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Length 'System.String.Length') - 1

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to check length for. |

<a name='M-KeepCoding-Helper-GetUpperBound``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### GetUpperBound\`\`1(source) `method`

##### Summary

Returns the last index of the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1').

##### Returns

`source`.Count() - 1

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to check length for. |

<a name='M-KeepCoding-Helper-GetValues``1'></a>
### GetValues\`\`1() `method`

##### Summary

Gets all the values of an [Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum 'System.Enum') as an [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

An [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of `T` containing all the values of that enum.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of [Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum 'System.Enum'). |

<a name='M-KeepCoding-Helper-GetValues``1-``0-'></a>
### GetValues\`\`1(_) `method`

##### Summary

Gets all the values of an [Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum 'System.Enum') as an [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Returns

An [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of `T` containing all the values of that enum.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| _ | [\`\`0](#T-``0 '``0') | A discard value, which can implicitly let the method know the type. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of [Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum 'System.Enum'). |

<a name='M-KeepCoding-Helper-HasComponent``1-UnityEngine-GameObject,``0@-'></a>
### HasComponent\`\`1(obj,component) `method`

##### Summary

Determines if the current game object has a component of a specific type.

##### Returns

True if a component has been found of type `T` from `obj`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The game object to search with. |
| component | [\`\`0@](#T-``0@ '``0@') | The variable to store the component in. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of component to find. |

##### Remarks

This uses [GetComponent\`\`1](#M-UnityEngine-GameObject-GetComponent``1 'UnityEngine.GameObject.GetComponent``1'), meaning that the component must be part of the same game object for this to return true.

<a name='M-KeepCoding-Helper-Include``1-System-Collections-Generic-IEnumerable{``0},System-Int32[]-'></a>
### Include\`\`1(source,indices) `method`

##### Summary

Removes the elements whose index does not match any of the indices.

##### Returns

`source`, but without the element indexing `indices`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to be modified. |
| indices | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The indices to include in `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The datatype of both the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'). |

<a name='M-KeepCoding-Helper-Indistinct``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### Indistinct\`\`1(source) `method`

##### Summary

Filters an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'), only allowing duplicated items.

##### Returns

A new instance of `source` that only includes elements which are repeated in the array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to filter through. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'). |

<a name='M-KeepCoding-Helper-InsertNewlines-System-String,System-UInt16-'></a>
### InsertNewlines(condition,maxLineLength) `method`

##### Summary

Replaces whitespace characters with line breaks based on the line length.

##### Returns

`condition` with a line break every `maxLineLength` or less characters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to insert line breaks with. |
| maxLineLength | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The maximum number of characters in one line. |

##### Remarks

This can be useful to prevent a [TextMesh](#T-UnityEngine-TextMesh 'UnityEngine.TextMesh') from going outside its boundaries. A monospaced font is recommended in this case.

<a name='M-KeepCoding-Helper-IsBetween-System-Int32,System-Int32,System-Int32-'></a>
### IsBetween(comparison,min,max) `method`

##### Summary

Determines whether the number is equal or in-between 2 values.

##### Returns

True if `comparison` is more than or equal `min` and less than or equal `max`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| comparison | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number to use as comparison. |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum value required to return true. |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum value required to return true. |

<a name='M-KeepCoding-Helper-IsBetween-System-Single,System-Single,System-Single-'></a>
### IsBetween(comparison,min,max) `method`

##### Summary

Determines whether the number is equal or in-between 2 values.

##### Returns

True if `comparison` is more than or equal `min` and less than or equal `max`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| comparison | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The number to use as comparison. |
| min | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The minimum value required to return true. |
| max | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The maximum value required to return true. |

<a name='M-KeepCoding-Helper-IsIndexNull``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### IsIndexNull\`\`1(source,index) `method`

##### Summary

Determines if the index is pointing to null in any way.

##### Returns

True if `source` is null, if `index` is out of range, or if the element is null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The array to index with. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index. |

<a name='M-KeepCoding-Helper-IsIterator``1-``0-'></a>
### IsIterator\`\`1(item) `method`

##### Summary

Determines if the item is an iterator type.

##### Returns

`item` is either [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable'), or [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The item to check the type for. |

<a name='M-KeepCoding-Helper-IsNullOrEmpty-System-String-'></a>
### IsNullOrEmpty(str) `method`

##### Summary

Determines if the string is null or empty.

##### Returns

True if `str` is equal to null, or empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to check for. |

<a name='M-KeepCoding-Helper-IsNullOrEmpty``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### IsNullOrEmpty\`\`1(source) `method`

##### Summary

Determines if the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') is null or empty.

##### Returns

True if `source` is equal to null, or empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to check for. |

<a name='M-KeepCoding-Helper-IsNullOrEmpty``1-System-Collections-Generic-IEnumerator{``0}-'></a>
### IsNullOrEmpty\`\`1(source) `method`

##### Summary

Determines if the [IEnumerator\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerator`1 'System.Collections.Generic.IEnumerator`1') is null or empty.

##### Returns

True if `source` is equal to null, or empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerator{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerator 'System.Collections.Generic.IEnumerator{``0}') | The [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to check for. |

<a name='M-KeepCoding-Helper-IsParent-KMSelectable-'></a>
### IsParent(kmSelectable) `method`

##### Summary

Determines if the [KMSelectable](#T-KMSelectable 'KMSelectable') is a parent of another [KMSelectable](#T-KMSelectable 'KMSelectable').

##### Returns

True if [Children](#F-KMSelectable-Children 'KMSelectable.Children') is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| kmSelectable | [KMSelectable](#T-KMSelectable 'KMSelectable') | This is required to check the children field. |

<a name='M-KeepCoding-Helper-LastValue``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0}-'></a>
### LastValue\`\`1(source,func) `method`

##### Summary

Returns the last element which doesn't return null, or null if all of them return null.

##### Returns

The last value from `source` where `func` doesn't return null, or null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The array to iterate on. |
| func | [System.Func{\`\`0,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``0}') | The method which returns |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of array, and method. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

<a name='M-KeepCoding-Helper-LengthOrDefault``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### LengthOrDefault\`\`1(source) `method`

##### Summary

Returns the length of the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'), or if null, the default value 0.

##### Returns

`source`'s length, or 0.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to check its length. |

<a name='M-KeepCoding-Helper-LongToBase-System-Int64,System-String-'></a>
### LongToBase(value,baseChars) `method`

##### Summary

Converts any base-10 number to any base.

##### Returns

`value`, but in the base specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The value to convert. |
| baseChars | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | All of the base characters for the conversion to the base number, use [Alphanumeric](#F-KeepCoding-Helper-Alphanumeric 'KeepCoding.Helper.Alphanumeric') for Base-62, use [Decimal](#F-KeepCoding-Helper-Decimal 'KeepCoding.Helper.Decimal') for Base-10, use [Binary](#F-KeepCoding-Helper-Binary 'KeepCoding.Helper.Binary') for Base-2. The length of the array is the base number. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

<a name='M-KeepCoding-Helper-LongToBase-System-Int64,System-Int32-'></a>
### LongToBase(value,baseNumber) `method`

##### Summary

Converts any base-10 number to any base.

##### Returns

The integer, but in the base specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The value to convert. |
| baseNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Which base to convert it to. |

<a name='M-KeepCoding-Helper-MemberCount``1'></a>
### MemberCount\`\`1() `method`

##### Summary

Counts the number of members in an enum.

##### Returns

The number of members in `T`.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The enum to check the length for. |

<a name='M-KeepCoding-Helper-Method-UnityEngine-LogType-'></a>
### Method(logType) `method`

##### Summary

Gets the appropriate log method depending on the type of [LogType](#T-UnityEngine-LogType 'UnityEngine.LogType').

##### Returns

The log method representing the enum `logType`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logType | [UnityEngine.LogType](#T-UnityEngine-LogType 'UnityEngine.LogType') | The type of method to get. |

<a name='M-KeepCoding-Helper-Modulo-System-Int32,System-Int32-'></a>
### Modulo(number,modulo) `method`

##### Summary

Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.

##### Returns

`number` mod `modulo`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The left-hand side operator |
| modulo | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The right-hand side operator. |

<a name='M-KeepCoding-Helper-Modulo-System-Single,System-Single-'></a>
### Modulo(number,modulo) `method`

##### Summary

Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.

##### Returns

`number` mod `modulo`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The left-hand side operator |
| modulo | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The right-hand side operator. |

<a name='M-KeepCoding-Helper-Modulo-System-Object,KeepCoding-BigInteger-'></a>
### Modulo(item,bigInteger) `method`

##### Summary

Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.

##### Returns

Itself mod `bigInteger`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The left-hand side operator. |
| bigInteger | [KeepCoding.BigInteger](#T-KeepCoding-BigInteger 'KeepCoding.BigInteger') | The right-hand side operator. |

<a name='M-KeepCoding-Helper-NullCheck``1-``0,System-String-'></a>
### NullCheck\`\`1(item,message) `method`

##### Summary

Throws a [NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') or [NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') if the parameter provided is null.

##### Returns

`item`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The parameter to check null for. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The optional message to throw if null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

<a name='M-KeepCoding-Helper-NullOrEmptyCheck-System-String,System-String-'></a>
### NullOrEmptyCheck(source,message) `method`

##### Summary

Throws an exception if the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') is null or empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to check for null and empty. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The optional message to throw if null or empty. Leaving it default will throw a default message. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Helper-NullOrEmptyCheck``1-System-Collections-Generic-IEnumerable{``0},System-String-'></a>
### NullOrEmptyCheck\`\`1(source,message) `method`

##### Summary

Throws an exception if the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') is null or empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') to check for null and empty. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The optional message to throw if null or empty. Leaving it default will throw a default message. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Helper-NullOrEmptyCheck``1-System-Collections-Generic-IEnumerator{``0},System-String-'></a>
### NullOrEmptyCheck\`\`1(source,message) `method`

##### Summary

Throws an exception if the [IEnumerator\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerator`1 'System.Collections.Generic.IEnumerator`1') is null or empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerator{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerator 'System.Collections.Generic.IEnumerator{``0}') | The string to check for null and empty. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The optional message to throw if null or empty. Leaving it default will throw a default message. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Helper-Prepend``1-System-Collections-Generic-IEnumerable{``0},``0-'></a>
### Prepend\`\`1(source,item) `method`

##### Summary

Prepends the element provided to the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1').

##### Returns

`source`, but with an added `item` as the first index.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to be modified. |
| item | [\`\`0](#T-``0 '``0') | The element to append to the `source`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The datatype of both the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'). |

<a name='M-KeepCoding-Helper-Prepend``1-``0[],``0-'></a>
### Prepend\`\`1(array,item) `method`

##### Summary

Prepends the element provided to the array.

##### Returns

`array`, but with an added `item` as the first index.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The array to be appended with. |
| item | [\`\`0](#T-``0 '``0') | The element to append to the `array`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The datatype of both the array and element. |

<a name='M-KeepCoding-Helper-RandomBoolean-System-Single-'></a>
### RandomBoolean(weighting) `method`

##### Summary

Generates a random boolean.

##### Returns

A random boolean, with probability based off of `weighting`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| weighting | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The odds of the boolean being true. |

##### Remarks

As this uses [Random](#T-UnityEngine-Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.

<a name='M-KeepCoding-Helper-RandomBooleans-System-Int32,System-Single-'></a>
### RandomBooleans(length,weighting) `method`

##### Summary

Creates an [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of random boolean values.

##### Returns

An array of random booleans of length `length`, with probability based off of `weighting`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the array. |
| weighting | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The odds of the boolean being true. |

##### Remarks

As this uses [Random](#T-UnityEngine-Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.

<a name='M-KeepCoding-Helper-Ranges-System-Int32,System-Int32,System-Int32-'></a>
### Ranges(length,min,max) `method`

##### Summary

Generates a random set of integers.

##### Returns

Random integer array of length `length` between `min` and `max`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the array. |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum value for each index. (inclusive) |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum value for each index. (exclusive) |

##### Remarks

As this uses [Random](#T-UnityEngine-Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.

<a name='M-KeepCoding-Helper-Ranges-System-Int32,System-Single,System-Single-'></a>
### Ranges(length,min,max) `method`

##### Summary

Generates a random set of floats.

##### Returns

Random float array of length `length` between `min` and `max`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the array. |
| min | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The minimum value for each index. (inclusive) |
| max | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The maximum value for each index. (inclusive) |

##### Remarks

As this uses [Random](#T-UnityEngine-Random 'UnityEngine.Random'), you may not use this in a constructor. Use it in `Awake()` or `Start()` in that case.

<a name='M-KeepCoding-Helper-ReflectAll``1-``0-'></a>
### ReflectAll\`\`1(source) `method`

##### Summary

Gets all fields and properties of the item using reflection.

##### Returns

All fields and properties of `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`\`0](#T-``0 '``0') | The item to get all fields and properties. |

<a name='M-KeepCoding-Helper-Replace``1-System-Collections-Generic-IEnumerable{``0},System-Int32,``0-'></a>
### Replace\`\`1(source,index,value) `method`

##### Summary

Replaces an index in the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') and returns the new one.

##### Returns

`source` but the `index` element is `value` instead.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The initial source. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index to change. |
| value | [\`\`0](#T-``0 '``0') | The value to replace at `source`'s `index` element. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

<a name='M-KeepCoding-Helper-Rev``1-System-Collections-Generic-List{``0}-'></a>
### Rev\`\`1(source) `method`

##### Summary

Reverses a list and returns the new list.

##### Returns

`source` with the elements reversed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.List{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{``0}') | The list to reverse. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the list. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

<a name='M-KeepCoding-Helper-Reverse-System-String-'></a>
### Reverse(source) `method`

##### Summary

Reverses a string.

##### Returns

`source` where contents are oredered backwards.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to reverse. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

<a name='M-KeepCoding-Helper-SetOrReplace``1-System-Collections-Generic-IDictionary{``0,System-Int32},``0,System-Func{System-Int32,System-Int32}-'></a>
### SetOrReplace\`\`1(source,key,func) `method`

##### Summary

Sets or replaces the value of a dictionary with a given function.

##### Returns

The new value at the specified key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IDictionary{\`\`0,System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{``0,System.Int32}') | Dictionary to operate on. |
| key | [\`\`0](#T-``0 '``0') | Key at which the list is located in the dictionary. |
| func | [System.Func{System.Int32,System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Int32,System.Int32}') | The function that returns the new value. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the key of the dictionary. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

<a name='M-KeepCoding-Helper-Slice``1-System-Collections-Generic-IEnumerable{``0},System-Int32,System-Int32-'></a>
### Slice\`\`1(source,start,count) `method`

##### Summary

Returns a slice of an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1').

##### Returns

A slice of `source` based on `start` and `count`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to take a slice of. |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting index of the slice. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The amount of items to take. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the `source` and return type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

<a name='M-KeepCoding-Helper-Split-System-String,System-String-'></a>
### Split(source,separator) `method`

##### Summary

Splits the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') based on the separator.

##### Returns

An [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') where each index is where `separator` was found in `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') of characters to split by. |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The separator to split `source` by. |

<a name='M-KeepCoding-Helper-SplitBy``1-System-Collections-Generic-IEnumerable{``0},System-Predicate{``0}-'></a>
### SplitBy\`\`1(source,predicate) `method`

##### Summary

Splits an [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable') in two based on a method provided.

##### Returns

A [Tuple\`2](#T-KeepCoding-Tuple`2 'KeepCoding.Tuple`2') consisting of items from `source` where [Item1](#P-KeepCoding-Tuple`1-Item1 'KeepCoding.Tuple`1.Item1') contains items that returned true in `predicate`, and [Item2](#P-KeepCoding-Tuple`2-Item2 'KeepCoding.Tuple`2.Item2') otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The collection to split. |
| predicate | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The method that decides where the item ends up. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the collection. |

<a name='M-KeepCoding-Helper-SplitEvery``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### SplitEvery\`\`1(source,length) `method`

##### Summary

Chops the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') into multiple [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1')s, based on the length provided.

##### Returns

An [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1')s, where each [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') is as long as `length`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to split. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of each [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') within the containing [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of `source`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

<a name='M-KeepCoding-Helper-Stop-UnityEngine-MonoBehaviour,UnityEngine-Coroutine[]-'></a>
### Stop(monoBehaviour,coroutines) `method`

##### Summary

Stops the coroutines only if they aren't `null`.

##### Returns

The array of [Coroutine](#T-UnityEngine-Coroutine 'UnityEngine.Coroutine')s given.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| monoBehaviour | [UnityEngine.MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') | The [MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') instance needed to stop coroutines. |
| coroutines | [UnityEngine.Coroutine[]](#T-UnityEngine-Coroutine[] 'UnityEngine.Coroutine[]') | The [Coroutine](#T-UnityEngine-Coroutine 'UnityEngine.Coroutine')s to stop. |

<a name='M-KeepCoding-Helper-ToLower-System-Char-'></a>
### ToLower(source) `method`

##### Summary

Converts a character to lowercase.

##### Returns

`source` as lowercase.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The character to convert. |

<a name='M-KeepCoding-Helper-ToNumber-System-Char-'></a>
### ToNumber(source) `method`

##### Summary

Converts a character to a number.

##### Returns

`source` as [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The character to convert. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-Helper-ToNumbers``1-``0[],System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Int32}-'></a>
### ToNumbers\`\`1(ts,min,max,minLength,maxLength) `method`

##### Summary

Parses each element of an array into a number. If it succeeds it returns the integer array, if it fails then it returns null.

##### Returns

The array as integers, or null if it fails.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ts | [\`\`0[]](#T-``0[] '``0[]') | The array to convert to an integer. |
| min | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The minimum acceptable value of any given index. (inclusive) |
| max | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum acceptable value of any given index. (inclusive) |
| minLength | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The minimum acceptable length of the array. (inclusive) |
| maxLength | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The maximum acceptable length of the array. (inclusive) |

<a name='M-KeepCoding-Helper-ToOrdinal-System-Int32-'></a>
### ToOrdinal(i) `method`

##### Summary

Converts a number to the ordinal as [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Returns

`i` as an ordinal. ([String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'))

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| i | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number to convert to an ordinal. |

<a name='M-KeepCoding-Helper-ToUpper-System-Char-'></a>
### ToUpper(source) `method`

##### Summary

Converts a character to uppercase.

##### Returns

`source` as uppercase.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The character to convert. |

<a name='M-KeepCoding-Helper-Unwrap-System-Collections-IEnumerable,System-Boolean-'></a>
### Unwrap(source,isRecursive) `method`

##### Summary

Unwraps any [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable') of type [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object'), which ends up flattening it as a [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of type [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object').

##### Returns

An [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object')[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of all elements within `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable') | The object to unwrap. |
| isRecursive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should search inside the variable and yield return the elements inside `source`. |

<a name='M-KeepCoding-Helper-UnwrapToString``1-``0,System-Boolean,System-String-'></a>
### UnwrapToString\`\`1(item,getVariables,delimiter) `method`

##### Summary

Unwraps any object, whether it be a class, list, tuple, or any other data and concatenates it into a string.

##### Returns

A string consisting of all values from `item`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The object to unwrap. |
| getVariables | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should search recursively inside the variable and yield return the elements inside `item`. |
| delimiter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The characters in-between each element. |

<a name='M-KeepCoding-Helper-Unwrap``1-``0,System-Boolean-'></a>
### Unwrap\`\`1(source,isRecursive) `method`

##### Summary

Unwraps any object, whether it be a class, list, tuple, or any other data.

##### Returns

An [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object')[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of all elements within `source`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [\`\`0](#T-``0 '``0') | The object to unwrap. |
| isRecursive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should search inside the variable and yield return the elements inside `source`. |

<a name='T-KeepCoding-IDump'></a>
## IDump `type`

##### Namespace

KeepCoding

##### Summary

An interface to implement dump methods. Make each method return the same method in your [Logger](#T-KeepCoding-Logger 'KeepCoding.Logger') instance. Written by Emik.

<a name='M-KeepCoding-IDump-Dump-System-Boolean,System-Linq-Expressions-Expression{System-Func{System-Object}}[]-'></a>
### Dump(getVariables,logs) `method`

##### Summary

Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| getVariables | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should search recursively for the elements within the elements. |
| logs | [System.Linq.Expressions.Expression{System.Func{System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{System.Object}}[]') | All of the variables to throughly log. |

<a name='M-KeepCoding-IDump-Dump-System-Linq-Expressions-Expression{System-Func{System-Object}}[]-'></a>
### Dump(logs) `method`

##### Summary

Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logs | [System.Linq.Expressions.Expression{System.Func{System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{System.Object}}[]') | All of the variables to throughly log. |

<a name='T-KeepCoding-ILog'></a>
## ILog `type`

##### Namespace

KeepCoding

##### Summary

An interface to implement log methods. Make each method return the same method in your [Logger](#T-KeepCoding-Logger 'KeepCoding.Logger') instance.  Written by Emik.

<a name='M-KeepCoding-ILog-LogMultiple-System-String[]-'></a>
### LogMultiple(logs) `method`

##### Summary

Logs multiple entries to the console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logs | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The array of logs to individual output into the console. |

<a name='M-KeepCoding-ILog-Log``1-``0,UnityEngine-LogType-'></a>
### Log\`\`1(message,logType) `method`

##### Summary

Logs message, but formats it to be compliant with the Logfile Analyzer.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [\`\`0](#T-``0 '``0') | The message to log. |
| logType | [UnityEngine.LogType](#T-UnityEngine-LogType 'UnityEngine.LogType') | The type of logging. Different logging types have different icons within the editor. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-ILog-Log``1-``0,System-Object[]-'></a>
### Log\`\`1(message,args) `method`

##### Summary

Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [\`\`0](#T-``0 '``0') | The message to log. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | All of the arguments to embed into `message`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='T-KeepCoding-ITP'></a>
## ITP `type`

##### Namespace

KeepCoding

##### Summary

Interface for Twitch Plays support. Written by Emik.

<a name='P-KeepCoding-ITP-Abandons'></a>
### Abandons `property`

##### Remarks

These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [OnActivate](#F-KMBombModule-OnActivate 'KMBombModule.OnActivate') or [OnActivate](#F-KMNeedyModule-OnActivate 'KMNeedyModule.OnActivate') or later.

<a name='P-KeepCoding-ITP-Help'></a>
### Help `property`

<a name='P-KeepCoding-ITP-IsCancelCommand'></a>
### IsCancelCommand `property`

##### Remarks

These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [OnActivate](#F-KMBombModule-OnActivate 'KMBombModule.OnActivate') or [OnActivate](#F-KMNeedyModule-OnActivate 'KMNeedyModule.OnActivate') or later.

<a name='P-KeepCoding-ITP-IsTP'></a>
### IsTP `property`

##### Remarks

These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [OnActivate](#F-KMBombModule-OnActivate 'KMBombModule.OnActivate') or [OnActivate](#F-KMNeedyModule-OnActivate 'KMNeedyModule.OnActivate') or later.

<a name='P-KeepCoding-ITP-IsTime'></a>
### IsTime `property`

##### Remarks

These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [OnActivate](#F-KMBombModule-OnActivate 'KMBombModule.OnActivate') or [OnActivate](#F-KMNeedyModule-OnActivate 'KMNeedyModule.OnActivate') or later.

<a name='P-KeepCoding-ITP-IsTimeSkippable'></a>
### IsTimeSkippable `property`

##### Remarks

These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [OnActivate](#F-KMBombModule-OnActivate 'KMBombModule.OnActivate') or [OnActivate](#F-KMNeedyModule-OnActivate 'KMNeedyModule.OnActivate') or later.

<a name='P-KeepCoding-ITP-IsZen'></a>
### IsZen `property`

##### Remarks

These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [OnActivate](#F-KMBombModule-OnActivate 'KMBombModule.OnActivate') or [OnActivate](#F-KMNeedyModule-OnActivate 'KMNeedyModule.OnActivate') or later.

<a name='P-KeepCoding-ITP-Manual'></a>
### Manual `property`

<a name='M-KeepCoding-ITP-ForceSolve'></a>
### ForceSolve() `method`

##### Summary

When the module runs into an exception or the module is forced to be solved, it calls this method.

##### Returns

A series of instructions for the Twitch Plays mod to handle in order to guarantee a solve.

##### Parameters

This method has no parameters.

##### Remarks

Make sure that the module is solved before this method closes, otherwise it causes a forced-solve.

<a name='M-KeepCoding-ITP-Process-System-String-'></a>
### Process(command) `method`

##### Summary

When a command is typed into Twitch Plays with the Id of this module, it calls this method and passes in the exact command typed.

##### Returns

A series of instructions for the Twitch Plays mod to handle as requested by the user.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The user's command. |

##### Remarks

Anything that gets yield returned will be processed by Twitch Plays. This includes other [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable') methods, [KMSelectable](#T-KMSelectable 'KMSelectable'), an [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of [KMSelectable](#T-KMSelectable 'KMSelectable'), [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), `true`, or `null`.

<a name='T-KeepCoding-ITuple'></a>
## ITuple `type`

##### Namespace

KeepCoding

##### Summary

Interface for tuple type. Written by Emik.

<a name='P-KeepCoding-ITuple-IsEmpty'></a>
### IsEmpty `property`

<a name='P-KeepCoding-ITuple-Item-System-Byte-'></a>
### Item `property`

##### Summary

Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.

##### Returns

The item indexed into.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The index to use. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |
| [KeepCoding.WrongDatatypeException](#T-KeepCoding-WrongDatatypeException 'KeepCoding.WrongDatatypeException') |  |

<a name='P-KeepCoding-ITuple-Length'></a>
### Length `property`

<a name='P-KeepCoding-ITuple-ToArray'></a>
### ToArray `property`

<a name='P-KeepCoding-ITuple-UpperBound'></a>
### UpperBound `property`

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

<a name='T-KeepCoding-Game-KTInputManager'></a>
## KTInputManager `type`

##### Namespace

KeepCoding.Game

##### Summary

Allows access relating to how the game is being interacted with.

<a name='P-KeepCoding-Game-KTInputManager-CurrentControlType'></a>
### CurrentControlType `property`

##### Remarks

Default: [Mouse](#F-KeepCoding-Game-ControlType-Mouse 'KeepCoding.Game.ControlType.Mouse').

<a name='P-KeepCoding-Game-KTInputManager-IsCurrentControlTypeVR'></a>
### IsCurrentControlTypeVR `property`

##### Remarks

Default: `false`.

<a name='T-KeepCoding-KeyHelper'></a>
## KeyHelper `type`

##### Namespace

KeepCoding

##### Summary

Inline methods for when typically key words are used. Written by Emik.

<a name='M-KeepCoding-KeyHelper-As``1-System-Object-'></a>
### As\`\`1(obj) `method`

##### Summary

The `as` operator explicitly converts the result of an expression to a given reference or nullable value type. If the conversion is not possible, the `as` operator returns `null`. Unlike a cast expression, the `as` operator never throws an exception.

##### Returns

`obj``as``T`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to cast into. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to cast the object into. |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Catch-System-Action,System-Action{System-Exception},System-Action,System-Type[]-'></a>
### Catch(action,caught,final,exceptions) `method`

##### Summary

The try-catch statement consists of a `try` block followed by one or more `catch` clauses, which specify handlers for different exceptions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to try. |
| caught | [System.Action{System.Exception}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Exception}') | The action to run when an exception is caught. |
| final | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to run on either clause. |
| exceptions | [System.Type[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type[] 'System.Type[]') | The types of exceptions to catch. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Catch``1-System-Action,System-Action{System-Exception},System-Action-'></a>
### Catch\`\`1(action,caught,final) `method`

##### Summary

The try-catch statement consists of a `try` block followed by one or more `catch` clauses, which specify handlers for different exceptions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to try. |
| caught | [System.Action{System.Exception}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Exception}') | The action to run when an exception is caught. |
| final | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to run on either clause. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to catch. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Catch``1-System-Func{``0},System-Func{System-Exception,``0},System-Type[]-'></a>
### Catch\`\`1(action,caught,exceptions) `method`

##### Summary

The try-catch statement consists of a `try` block followed by one or more `catch` clauses, which specify handlers for different exceptions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | The action to try. |
| caught | [System.Func{System.Exception,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Exception,``0}') | The action to run when an exception is caught. |
| exceptions | [System.Type[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type[] 'System.Type[]') | The types of exceptions to catch. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The return type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Catch``2-System-Action,System-Action{System-Exception},System-Action-'></a>
### Catch\`\`2(action,caught,final) `method`

##### Summary

The try-catch statement consists of a `try` block followed by one or more `catch` clauses, which specify handlers for different exceptions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to try. |
| caught | [System.Action{System.Exception}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Exception}') | The action to run when an exception is caught. |
| final | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to run on either clause. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T1 | The first type to catch. |
| T2 | The second type to catch. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Catch``2-System-Func{``1},System-Func{System-Exception,``1}-'></a>
### Catch\`\`2(action,caught) `method`

##### Summary

The try-catch statement consists of a `try` block followed by one or more `catch` clauses, which specify handlers for different exceptions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Func{\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``1}') | The action to try. |
| caught | [System.Func{System.Exception,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Exception,``1}') | The action to run when an exception is caught. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to catch. |
| TResult | The return type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Catch``3-System-Action,System-Action{System-Exception},System-Action-'></a>
### Catch\`\`3(action,caught,final) `method`

##### Summary

The try-catch statement consists of a `try` block followed by one or more `catch` clauses, which specify handlers for different exceptions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to try. |
| caught | [System.Action{System.Exception}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Exception}') | The action to run when an exception is caught. |
| final | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to run on either clause. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T1 | The first type to catch. |
| T2 | The second type to catch. |
| T3 | The third type to catch. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Catch``3-System-Func{``2},System-Func{System-Exception,``2}-'></a>
### Catch\`\`3(action,caught) `method`

##### Summary

The try-catch statement consists of a `try` block followed by one or more `catch` clauses, which specify handlers for different exceptions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Func{\`\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``2}') | The action to try. |
| caught | [System.Func{System.Exception,\`\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Exception,``2}') | The action to run when an exception is caught. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T1 | The first type to catch. |
| T2 | The second type to catch. |
| TResult | The return type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Catch``4-System-Action,System-Action{System-Exception},System-Action-'></a>
### Catch\`\`4(action,caught,final) `method`

##### Summary

The try-catch statement consists of a `try` block followed by one or more `catch` clauses, which specify handlers for different exceptions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to try. |
| caught | [System.Action{System.Exception}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Exception}') | The action to run when an exception is caught. |
| final | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to run on either clause. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T1 | The first type to catch. |
| T2 | The second type to catch. |
| T3 | The third type to catch. |
| T4 | The fourth type to catch. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Catch``4-System-Func{``3},System-Func{System-Exception,``3}-'></a>
### Catch\`\`4(action,caught) `method`

##### Summary

The try-catch statement consists of a `try` block followed by one or more `catch` clauses, which specify handlers for different exceptions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Func{\`\`3}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``3}') | The action to try. |
| caught | [System.Func{System.Exception,\`\`3}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Exception,``3}') | The action to run when an exception is caught. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T1 | The first type to catch. |
| T2 | The second type to catch. |
| T3 | The third type to catch. |
| TResult | The return type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Catch``5-System-Func{``4},System-Func{System-Exception,``4}-'></a>
### Catch\`\`5(action,caught) `method`

##### Summary

The try-catch statement consists of a `try` block followed by one or more `catch` clauses, which specify handlers for different exceptions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Func{\`\`4}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``4}') | The action to try. |
| caught | [System.Func{System.Exception,\`\`4}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Exception,``4}') | The action to run when an exception is caught. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T1 | The first type to catch. |
| T2 | The second type to catch. |
| T3 | The third type to catch. |
| T4 | The fourth type to catch. |
| TResult | The return type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Checked-System-Action-'></a>
### Checked(action) `method`

##### Summary

The `checked` keyword is used to explicitly enable overflow checking for integral-type arithmetic operations and conversions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to run inside a `checked` block. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Checked``1-System-Func{``0}-'></a>
### Checked\`\`1(func) `method`

##### Summary

The `checked` keyword is used to explicitly enable overflow checking for integral-type arithmetic operations and conversions.

##### Returns

The output of `func`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | The function to run inside a `checked` block. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-DoWhile-System-Action,System-Func{System-Boolean}-'></a>
### DoWhile(action,condition) `method`

##### Summary

The `do` statement executes a statement or a block of statements while a specified Boolean expression evaluates to `true`. Because that expression is evaluated after each execution of the loop, a `do` loop executes one or more times. This differs from a `while` loop, which executes zero or more times.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to run in the loop. |
| condition | [System.Func{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Boolean}') | The condition to determine whether the loop should keep going. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-DoWhile``1-System-Func{``0},System-Func{System-Boolean}-'></a>
### DoWhile\`\`1(func,condition) `method`

##### Summary

The `do` statement executes a statement or a block of statements while a specified Boolean expression evaluates to `true`. Because that expression is evaluated after each execution of the loop, a `do` loop executes one or more times. This differs from a `while` loop, which executes zero or more times.

##### Returns

All instances that `func` used in an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | The function to run in the loop. |
| condition | [System.Func{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Boolean}') | The condition to determine whether the loop should keep going. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-ForEach-System-Collections-IEnumerable,System-Action{System-Object}-'></a>
### ForEach(iterator,action) `method`

##### Summary

The `foreach` statement executes a statement or a block of statements for each element in an instance of the type that implements the [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable') or [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') interface.

##### Returns

`iterator`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| iterator | [System.Collections.IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable') | The collection of items to go through one-by-one. |
| action | [System.Action{System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Object}') | The action to do on each item in `iterator`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-ForEach-System-Collections-IEnumerator,System-Action{System-Object}-'></a>
### ForEach(iterator,action) `method`

##### Summary

The `foreach` statement executes a statement or a block of statements for each element in an instance of the type that implements the [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable') or [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') interface.

##### Returns

`iterator`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| iterator | [System.Collections.IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') | The collection of items to go through one-by-one. |
| action | [System.Action{System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Object}') | The action to do on each item in `iterator`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-ForEach``1-System-Collections-Generic-IEnumerable{``0},System-Action{``0}-'></a>
### ForEach\`\`1(iterator,action) `method`

##### Summary

The `foreach` statement executes a statement or a block of statements for each element in an instance of the type that implements the [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable') or [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') interface.

##### Returns

`iterator`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| iterator | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The collection of items to go through one-by-one. |
| action | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | The action to do on each item in `iterator`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of iterator. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-ForEach``1-System-Collections-Generic-IEnumerator{``0},System-Action{``0}-'></a>
### ForEach\`\`1(iterator,action) `method`

##### Summary

The `foreach` statement executes a statement or a block of statements for each element in an instance of the type that implements the [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable') or [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') interface.

##### Returns

`iterator`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| iterator | [System.Collections.Generic.IEnumerator{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerator 'System.Collections.Generic.IEnumerator{``0}') | The collection of items to go through one-by-one. |
| action | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | The action to do on each item in `iterator`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of iterator. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-For``1-``0,System-Action{``0},System-Predicate{``0},System-Func{``0,``0}-'></a>
### For\`\`1(item,action,condition,loop) `method`

##### Summary

The `for` statement executes a statement or a block of statements while a specified Boolean expression evaluates to `true`.

##### Returns

`item`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The item to read and write on. |
| action | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | The action for each loop. |
| condition | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The condition for whether the loop should continue. |
| loop | [System.Func{\`\`0,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``0}') | The action to run after `action`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the declaring variable. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-For``1-``0,System-Func{``0,``0},System-Predicate{``0},System-Func{``0,``0}-'></a>
### For\`\`1(item,func,condition,loop) `method`

##### Summary

The `for` statement executes a statement or a block of statements while a specified Boolean expression evaluates to `true`.

##### Returns

All instances that `func` used in an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The item to read and write on. |
| func | [System.Func{\`\`0,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``0}') | The function for each loop. |
| condition | [System.Predicate{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{``0}') | The condition for whether the loop should continue. |
| loop | [System.Func{\`\`0,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``0}') | The action to run after `func`. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the declaring variable. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-If-System-Boolean,System-Action,System-Action-'></a>
### If(condition,action,otherwise) `method`

##### Summary

An `if` statement identifies which statement to run based on the value of a Boolean expression.

##### Returns

`condition`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The condition to check. |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to run when `condition` is `true`. |
| otherwise | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to run when `condition` is `false`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-If``1-System-Boolean,System-Func{``0},System-Func{``0}-'></a>
### If\`\`1(condition,action,otherwise) `method`

##### Summary

An `if` statement identifies which statement to run based on the value of a Boolean expression.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The condition to check. |
| action | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | The action to run when `condition` is `true`. |
| otherwise | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | The action to run when `condition` is `false`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Is``1-System-Object-'></a>
### Is\`\`1(obj) `method`

##### Summary

The `is` operator checks if the result of an expression is compatible with a given type.

##### Returns

`obj``is``T`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to cast. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to cast into. |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Is``1-System-Object,``0@-'></a>
### Is\`\`1(obj,item) `method`

##### Summary

The `is` operator checks if the result of an expression is compatible with a given type.

##### Returns

`obj``is``T``item`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to cast. |
| item | [\`\`0@](#T-``0@ '``0@') | The object casted into the type. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to cast into. |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Lock``1-``0,System-Action{``0}-'></a>
### Lock\`\`1(item,action) `method`

##### Summary

The `lock` statement acquires the mutual-exclusion lock for a given object, executes a statement block, and then releases the lock. While a lock is held, the thread that holds the lock can again acquire and release the lock. Any other thread is blocked from acquiring the lock and waits until the lock is released.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The item to lock. |
| action | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | The action to run while the item is locked. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of item to lock. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Lock``1-``0,System-Func{``0,``0}-'></a>
### Lock\`\`1(item,func) `method`

##### Summary

The `lock` statement acquires the mutual-exclusion lock for a given object, executes a statement block, and then releases the lock. While a lock is held, the thread that holds the lock can again acquire and release the lock. Any other thread is blocked from acquiring the lock and waits until the lock is released.

##### Returns

The output of `func`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The item to lock. |
| func | [System.Func{\`\`0,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``0}') | The function to run while the item is locked. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of item to lock. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-NameOf``1-System-Linq-Expressions-Expression{System-Func{``0}}-'></a>
### NameOf\`\`1(expression) `method`

##### Summary

A `nameof` expression produces the name of a variable, type, or member as the string constant.

##### Returns

The name of the expression.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.Linq.Expressions.Expression{System.Func{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0}}') | The expression to get the name from. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of item. |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Unchecked-System-Action-'></a>
### Unchecked(action) `method`

##### Summary

The `unchecked` keyword is used to suppress overflow-checking for integral-type arithmetic operations and conversions.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to ignore overflow-checking. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Unchecked``1-System-Func{``0}-'></a>
### Unchecked\`\`1(func) `method`

##### Summary

The `unchecked` keyword is used to suppress overflow-checking for integral-type arithmetic operations and conversions.

##### Returns

The output of `func`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | The function to ignore overflow-checking. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Using``1-``0,System-Action{``0}-'></a>
### Using\`\`1(item,action) `method`

##### Summary

Provides a convenient syntax that ensures the correct use of [IDisposable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IDisposable 'System.IDisposable') objects.

##### Returns

`item`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The item to use. |
| action | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | The action to use `item` on. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of [IDisposable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IDisposable 'System.IDisposable'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-Using``1-``0,System-Func{``0,``0}-'></a>
### Using\`\`1(item,func) `method`

##### Summary

Provides a convenient syntax that ensures the correct use of [IDisposable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IDisposable 'System.IDisposable') objects.

##### Returns

The output of `func`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The item to use. |
| func | [System.Func{\`\`0,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``0}') | The function to use `item` on. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of [IDisposable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IDisposable 'System.IDisposable'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-While-System-Action,System-Func{System-Boolean}-'></a>
### While(action,condition) `method`

##### Summary

The `while` statement executes a statement or a block of statements while a specified Boolean expression evaluates to `true`. Because that expression is evaluated before each execution of the loop, a `while` loop executes zero or more times. This differs from a `do` loop, which executes one or more times.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The action to run in the loop. |
| condition | [System.Func{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Boolean}') | The condition to determine whether the loop should keep going. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='M-KeepCoding-KeyHelper-While``1-System-Func{``0},System-Func{System-Boolean}-'></a>
### While\`\`1(func,condition) `method`

##### Summary

The `while` statement executes a statement or a block of statements while a specified Boolean expression evaluates to `true`. Because that expression is evaluated before each execution of the loop, a `while` loop executes zero or more times. This differs from a `do` loop, which executes one or more times.

##### Returns

All instances that `func` used in an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | The function to run in the loop. |
| condition | [System.Func{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Boolean}') | The condition to determine whether the loop should keep going. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

##### Remarks



<a name='T-KeepCoding-Logger'></a>
## Logger `type`

##### Namespace

KeepCoding

##### Summary

A class to allow logging with a specific format. Written by Emik.

<a name='M-KeepCoding-Logger-#ctor-System-String,System-Boolean,System-Boolean-'></a>
### #ctor(name,showId,showInLfa) `constructor`

##### Summary

The string constructor. The string determines the name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the value. |
| showId | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether to show the unique identifier when logging. |
| showInLfa | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether to format such that the Logfile Analyzer would use. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.FormatException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.FormatException 'System.FormatException') |  |

<a name='M-KeepCoding-Logger-#ctor-System-Type,System-Boolean-'></a>
### #ctor(type,showId) `constructor`

##### Summary

The type constructor. The type's name determines the name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The name of the value, using [Name](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.MemberInfo.Name 'System.Reflection.MemberInfo.Name'). |
| showId | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether to show the unique identifier when logging. |

<a name='P-KeepCoding-Logger-Id'></a>
### Id `property`

<a name='P-KeepCoding-Logger-Name'></a>
### Name `property`

<a name='M-KeepCoding-Logger-Dump-System-Object,System-Boolean-'></a>
### Dump(obj,getVariables) `method`

##### Summary

Dumps all information that it can find of the type using reflection. This should only be used to debug.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to reflect on. |
| getVariables | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should search recursively for the elements within the elements. |

<a name='M-KeepCoding-Logger-Dump-System-Boolean,System-Linq-Expressions-Expression{System-Func{System-Object}}[]-'></a>
### Dump(getVariables,logs) `method`

##### Summary

Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| getVariables | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should search recursively for the elements within the elements. |
| logs | [System.Linq.Expressions.Expression{System.Func{System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{System.Object}}[]') | All of the variables to throughly log. |

<a name='M-KeepCoding-Logger-Dump-System-Linq-Expressions-Expression{System-Func{System-Object}}[]-'></a>
### Dump(logs) `method`

##### Summary

Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logs | [System.Linq.Expressions.Expression{System.Func{System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{System.Object}}[]') | All of the variables to throughly log. |

<a name='M-KeepCoding-Logger-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Determines if both objects are equal.

##### Returns

Whether both objects are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The comparison. |

<a name='M-KeepCoding-Logger-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Gets the hash code of the object.

##### Returns

The hash code.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Logger-LogMultiple-System-String[]-'></a>
### LogMultiple(logs) `method`

##### Summary

Logs multiple entries to the console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logs | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The array of logs to individual output into the console. |

<a name='M-KeepCoding-Logger-Log``1-``0,UnityEngine-LogType-'></a>
### Log\`\`1(message,logType) `method`

##### Summary

Logs message, but formats it to be compliant with the Logfile Analyzer.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [\`\`0](#T-``0 '``0') | The message to log. |
| logType | [UnityEngine.LogType](#T-UnityEngine-LogType 'UnityEngine.LogType') | The type of logging. Different logging types have different icons within the editor. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-Logger-Log``1-``0,System-Object[]-'></a>
### Log\`\`1(message,args) `method`

##### Summary

Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [\`\`0](#T-``0 '``0') | The message to log. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | All of the arguments to embed into `message`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='T-KeepCoding-Game-MasterAudio'></a>
## MasterAudio `type`

##### Namespace

KeepCoding.Game

##### Summary

Allows access relating to the game's main master channel for audio.

<a name='P-KeepCoding-Game-MasterAudio-GroupInfo'></a>
### GroupInfo `property`

##### Remarks

Default: `null`.

<a name='P-KeepCoding-Game-MasterAudio-IsGroupInfo'></a>
### IsGroupInfo `property`

##### Remarks

Default: `true`.

<a name='T-KeepCoding-Game-Mission'></a>
## Mission `type`

##### Namespace

KeepCoding.Game

##### Summary

Allows access relating to the current mission.

<a name='P-KeepCoding-Game-Mission-Description'></a>
### Description `property`

##### Remarks

Default: "Everybody has to start somewhere. Let's just hope it doesn't end here too.\n\nMake sure your experts have the manual and are ready to help.".

<a name='P-KeepCoding-Game-Mission-DisplayName'></a>
### DisplayName `property`

##### Remarks

Default: "The First Bomb"

<a name='P-KeepCoding-Game-Mission-GeneratorSetting'></a>
### GeneratorSetting `property`

##### Remarks

New instance of [GeneratorSetting](#P-KeepCoding-Game-Mission-GeneratorSetting 'KeepCoding.Game.Mission.GeneratorSetting'), default constructor.

<a name='P-KeepCoding-Game-Mission-ID'></a>
### ID `property`

##### Remarks

Default: "firsttime"

<a name='P-KeepCoding-Game-Mission-IsPacingEvents'></a>
### IsPacingEvents `property`

##### Remarks

Default: `false`.

<a name='T-KeepCoding-ModInfo'></a>
## ModInfo `type`

##### Namespace

KeepCoding

##### Summary

Contains information about the mod's info, this class can be used to deserialize every mod's "modInfo.json".

<a name='P-KeepCoding-ModInfo-Author'></a>
### Author `property`

<a name='P-KeepCoding-ModInfo-Description'></a>
### Description `property`

<a name='P-KeepCoding-ModInfo-Id'></a>
### Id `property`

<a name='P-KeepCoding-ModInfo-Title'></a>
### Title `property`

<a name='P-KeepCoding-ModInfo-UnityVersion'></a>
### UnityVersion `property`

##### Summary

Contains the current unity version of the mod.

<a name='P-KeepCoding-ModInfo-Values'></a>
### Values `property`

<a name='P-KeepCoding-ModInfo-Version'></a>
### Version `property`

<a name='M-KeepCoding-ModInfo-Deserialize-System-String-'></a>
### Deserialize(path) `method`

##### Summary

Deserializes a modInfo.json file.

##### Returns

`path` deserialized as [ModInfo](#T-KeepCoding-ModInfo 'KeepCoding.ModInfo').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The path of the file to deserialize. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.IO.PathTooLongException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.PathTooLongException 'System.IO.PathTooLongException') |  |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') |  |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') |  |
| [System.UnauthorizedAccessException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UnauthorizedAccessException 'System.UnauthorizedAccessException') |  |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') |  |
| [System.NotSupportedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotSupportedException 'System.NotSupportedException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |
| [System.Security.SecurityException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.SecurityException 'System.Security.SecurityException') |  |

<a name='M-KeepCoding-ModInfo-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Determines if both objects are equal.

##### Returns

True if both of them are [ModInfo](#T-KeepCoding-ModInfo 'KeepCoding.ModInfo') and contain the same [Values](#P-KeepCoding-ModInfo-Values 'KeepCoding.ModInfo.Values').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The comparison. |

<a name='M-KeepCoding-ModInfo-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Gets the hash code.

##### Returns

The hash code.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-ModInfo-ToString'></a>
### ToString() `method`

##### Summary

Converts the object to a string.

##### Returns

[Values](#P-KeepCoding-ModInfo-Values 'KeepCoding.ModInfo.Values') unwrapped with [UnwrapToString\`\`1](#M-KeepCoding-Helper-UnwrapToString``1-``0,System-Boolean,System-String- 'KeepCoding.Helper.UnwrapToString``1(``0,System.Boolean,System.String)').

##### Parameters

This method has no parameters.

<a name='T-KeepCoding-Game-ModManager'></a>
## ModManager `type`

##### Namespace

KeepCoding.Game

##### Summary

Allows access to methods relating mod paths.

<a name='P-KeepCoding-Game-ModManager-GetAllModPathsFromSource'></a>
### GetAllModPathsFromSource `property`

##### Remarks

New instance of [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1'), with no elements.

<a name='P-KeepCoding-Game-ModManager-GetDisabledModPaths'></a>
### GetDisabledModPaths `property`

##### Remarks

New instance of [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1'), with no elements.

<a name='P-KeepCoding-Game-ModManager-GetEnabledModPaths'></a>
### GetEnabledModPaths `property`

##### Remarks

New instance of [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1'), with no elements.

<a name='T-KeepCoding-Game-ModSourceEnum'></a>
## ModSourceEnum `type`

##### Namespace

KeepCoding.Game

##### Summary

Determines how the mod is stored.

<a name='F-KeepCoding-Game-ModSourceEnum-Invalid'></a>
### Invalid `constants`

<a name='F-KeepCoding-Game-ModSourceEnum-Local'></a>
### Local `constants`

<a name='F-KeepCoding-Game-ModSourceEnum-SteamWorkshop'></a>
### SteamWorkshop `constants`

<a name='T-KeepCoding-ModuleContainer'></a>
## ModuleContainer `type`

##### Namespace

KeepCoding

##### Summary

Container for both solvable and needy modules. Written by Emik.

<a name='M-KeepCoding-ModuleContainer-#ctor-KMBombModule,KMNeedyModule-'></a>
### #ctor(solvable,needy) `constructor`

##### Summary

Encapsulates either a solvable or needy module.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| solvable | [KMBombModule](#T-KMBombModule 'KMBombModule') | The instance of a normal module. |
| needy | [KMNeedyModule](#T-KMNeedyModule 'KMNeedyModule') | The instance of a needy module. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.ConstructorArgumentException](#T-KeepCoding-ConstructorArgumentException 'KeepCoding.ConstructorArgumentException') |  |

<a name='M-KeepCoding-ModuleContainer-#ctor-KeepCoding-CacheableBehaviour-'></a>
### #ctor(behaviour) `constructor`

##### Summary

Encapsulates either a solvable or needy module. Uses [Get\`\`1](#M-KeepCoding-CacheableBehaviour-Get``1-System-Boolean- 'KeepCoding.CacheableBehaviour.Get``1(System.Boolean)').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| behaviour | [KeepCoding.CacheableBehaviour](#T-KeepCoding-CacheableBehaviour 'KeepCoding.CacheableBehaviour') | The component to get the modules from. |

<a name='M-KeepCoding-ModuleContainer-#ctor-UnityEngine-Component-'></a>
### #ctor(component) `constructor`

##### Summary

Encapsulates either a solvable or needy module. Uses [GetComponent\`\`1](#M-UnityEngine-Component-GetComponent``1 'UnityEngine.Component.GetComponent``1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| component | [UnityEngine.Component](#T-UnityEngine-Component 'UnityEngine.Component') | The component to get the modules from. |

<a name='M-KeepCoding-ModuleContainer-#ctor-KMBombModule-'></a>
### #ctor(solvable) `constructor`

##### Summary

Encapsulates either a solvable module.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| solvable | [KMBombModule](#T-KMBombModule 'KMBombModule') | The instance of a normal module. |

<a name='M-KeepCoding-ModuleContainer-#ctor-KMNeedyModule-'></a>
### #ctor(needy) `constructor`

##### Summary

Encapsulates either a solvable module.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| needy | [KMNeedyModule](#T-KMNeedyModule 'KMNeedyModule') | The instance of a needy module. |

<a name='P-KeepCoding-ModuleContainer-Id'></a>
### Id `property`

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedTypeException](#T-KeepCoding-UnrecognizedTypeException 'KeepCoding.UnrecognizedTypeException') |  |

<a name='P-KeepCoding-ModuleContainer-Module'></a>
### Module `property`

<a name='P-KeepCoding-ModuleContainer-Name'></a>
### Name `property`

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedTypeException](#T-KeepCoding-UnrecognizedTypeException 'KeepCoding.UnrecognizedTypeException') |  |

<a name='P-KeepCoding-ModuleContainer-Needy'></a>
### Needy `property`

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

<a name='P-KeepCoding-ModuleContainer-RequiresTimerVisibility'></a>
### RequiresTimerVisibility `property`

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedTypeException](#T-KeepCoding-UnrecognizedTypeException 'KeepCoding.UnrecognizedTypeException') |  |

<a name='P-KeepCoding-ModuleContainer-RuleGeneration'></a>
### RuleGeneration `property`

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedTypeException](#T-KeepCoding-UnrecognizedTypeException 'KeepCoding.UnrecognizedTypeException') |  |

<a name='P-KeepCoding-ModuleContainer-Solvable'></a>
### Solvable `property`

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') |  |

<a name='P-KeepCoding-ModuleContainer-Solve'></a>
### Solve `property`

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedTypeException](#T-KeepCoding-UnrecognizedTypeException 'KeepCoding.UnrecognizedTypeException') |  |

<a name='P-KeepCoding-ModuleContainer-Strike'></a>
### Strike `property`

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedTypeException](#T-KeepCoding-UnrecognizedTypeException 'KeepCoding.UnrecognizedTypeException') |  |

<a name='M-KeepCoding-ModuleContainer-Assign-System-Action,System-Action,System-Action,System-Action,System-Action,System-Action-'></a>
### Assign(onActivate,onNeedyActivation,onNeedyDeactivation,onPass,onStrike,onTimerExpired) `method`

##### Summary

Assigns events to a module container, replacing their values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| onActivate | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the lights turn on. |
| onNeedyActivation | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the needy activates. |
| onNeedyDeactivation | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the needy deactivates. |
| onPass | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the needy is solved. |
| onStrike | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the needy strikes. |
| onTimerExpired | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the timer runs out of time. |

<a name='M-KeepCoding-ModuleContainer-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Determines if both [ModuleContainer](#T-KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer') variables are equal.

##### Returns

True if both contain the same instance of [KMBombModule](#T-KMBombModule 'KMBombModule'), `null`, [KMNeedyModule](#T-KMNeedyModule 'KMNeedyModule')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The comparison. |

<a name='M-KeepCoding-ModuleContainer-Equals-KeepCoding-ModuleContainer-'></a>
### Equals(other) `method`

##### Summary

Determines if both [ModuleContainer](#T-KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer') variables are equal.

##### Returns

True if both contain the same instance of [KMBombModule](#T-KMBombModule 'KMBombModule'), `null`, [KMNeedyModule](#T-KMNeedyModule 'KMNeedyModule')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [KeepCoding.ModuleContainer](#T-KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer') | The comparison. |

<a name='M-KeepCoding-ModuleContainer-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Gets the current hash code.

##### Returns

The [Module](#P-KeepCoding-ModuleContainer-Module 'KeepCoding.ModuleContainer.Module')'s hash code.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-ModuleContainer-OnActivate-System-Action-'></a>
### OnActivate(action) `method`

##### Summary

Sets the action of OnActivate.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The delegate to set. |

<a name='M-KeepCoding-ModuleContainer-op_Explicit-KeepCoding-ModuleContainer-~KMBombModule'></a>
### op_Explicit(container) `method`

##### Summary

Returns the instance of [KMBombModule](#T-KMBombModule 'KMBombModule') from [Solvable](#P-KeepCoding-ModuleContainer-Solvable 'KeepCoding.ModuleContainer.Solvable').

##### Returns

A [KMBombModule](#T-KMBombModule 'KMBombModule') from [Solvable](#P-KeepCoding-ModuleContainer-Solvable 'KeepCoding.ModuleContainer.Solvable').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [KeepCoding.ModuleContainer)~KMBombModule](#T-KeepCoding-ModuleContainer-~KMBombModule 'KeepCoding.ModuleContainer)~KMBombModule') | The [ModuleContainer](#T-KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer') to get the [KMBombModule](#T-KMBombModule 'KMBombModule') from. |

<a name='M-KeepCoding-ModuleContainer-op_Explicit-KeepCoding-ModuleContainer-~KMNeedyModule'></a>
### op_Explicit(container) `method`

##### Summary

Returns the instance of [KMNeedyModule](#T-KMNeedyModule 'KMNeedyModule') from [Needy](#P-KeepCoding-ModuleContainer-Needy 'KeepCoding.ModuleContainer.Needy').

##### Returns

A [KMBombModule](#T-KMBombModule 'KMBombModule') from [Needy](#P-KeepCoding-ModuleContainer-Needy 'KeepCoding.ModuleContainer.Needy').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [KeepCoding.ModuleContainer)~KMNeedyModule](#T-KeepCoding-ModuleContainer-~KMNeedyModule 'KeepCoding.ModuleContainer)~KMNeedyModule') | The [ModuleContainer](#T-KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer') to get the [KMNeedyModule](#T-KMNeedyModule 'KMNeedyModule') from. |

<a name='M-KeepCoding-ModuleContainer-op_Implicit-KMBombModule-~KeepCoding-ModuleContainer'></a>
### op_Implicit(solvable) `method`

##### Summary

Creates a new instance of [ModuleContainer](#T-KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer') where [Solvable](#P-KeepCoding-ModuleContainer-Solvable 'KeepCoding.ModuleContainer.Solvable') is defined.

##### Returns

A [ModuleContainer](#T-KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer') with parameter `solvable`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| solvable | [KMBombModule)~KeepCoding.ModuleContainer](#T-KMBombModule-~KeepCoding-ModuleContainer 'KMBombModule)~KeepCoding.ModuleContainer') | The solvable module to create a new [ModuleContainer](#T-KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer') of. |

<a name='M-KeepCoding-ModuleContainer-op_Implicit-KMNeedyModule-~KeepCoding-ModuleContainer'></a>
### op_Implicit(needy) `method`

##### Summary

Creates a new instance of [ModuleContainer](#T-KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer') where [Needy](#P-KeepCoding-ModuleContainer-Needy 'KeepCoding.ModuleContainer.Needy') is defined.

##### Returns

A [ModuleContainer](#T-KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer') with parameter `needy`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| needy | [KMNeedyModule)~KeepCoding.ModuleContainer](#T-KMNeedyModule-~KeepCoding-ModuleContainer 'KMNeedyModule)~KeepCoding.ModuleContainer') | The needy module to create a new [ModuleContainer](#T-KeepCoding-ModuleContainer 'KeepCoding.ModuleContainer') of. |

<a name='T-KeepCoding-ModuleScript'></a>
## ModuleScript `type`

##### Namespace

KeepCoding

##### Summary

Base class for solvable and needy modded modules in Keep Talking and Nobody Explodes. Written by Emik.

<a name='P-KeepCoding-ModuleScript-Bomb'></a>
### Bomb `property`

<a name='P-KeepCoding-ModuleScript-HasStruck'></a>
### HasStruck `property`

<a name='P-KeepCoding-ModuleScript-Id'></a>
### Id `property`

<a name='P-KeepCoding-ModuleScript-IsActive'></a>
### IsActive `property`

<a name='P-KeepCoding-ModuleScript-IsEditor'></a>
### IsEditor `property`

<a name='P-KeepCoding-ModuleScript-IsLastInstantiated'></a>
### IsLastInstantiated `property`

<a name='P-KeepCoding-ModuleScript-IsNeedyActive'></a>
### IsNeedyActive `property`

<a name='P-KeepCoding-ModuleScript-IsSolved'></a>
### IsSolved `property`

<a name='P-KeepCoding-ModuleScript-IsVR'></a>
### IsVR `property`

<a name='P-KeepCoding-ModuleScript-LastId'></a>
### LastId `property`

##### Summary

The last Id instantiation for the module of this type.

<a name='P-KeepCoding-ModuleScript-Module'></a>
### Module `property`

<a name='P-KeepCoding-ModuleScript-Modules'></a>
### Modules `property`

##### Summary

Contains every modded module in [Bomb](#P-KeepCoding-ModuleScript-Bomb 'KeepCoding.ModuleScript.Bomb'), separated by type.

<a name='P-KeepCoding-ModuleScript-Sounds'></a>
### Sounds `property`

<a name='P-KeepCoding-ModuleScript-TP'></a>
### TP `property`

##### Remarks

Due to type ambiguity, a non-generic interface is returned.

<a name='P-KeepCoding-ModuleScript-TimeLeft'></a>
### TimeLeft `property`

<a name='P-KeepCoding-ModuleScript-Version'></a>
### Version `property`

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.OperationCanceledException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.OperationCanceledException 'System.OperationCanceledException') |  |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') |  |

<a name='M-KeepCoding-ModuleScript-Assign-System-Action,System-Action,System-Action,System-Action,System-Action,System-Action-'></a>
### Assign(onActivate,onNeedyActivation,onNeedyDeactivation,onPass,onStrike,onTimerExpired) `method`

##### Summary

Assigns events specified into [Module](#P-KeepCoding-ModuleScript-Module 'KeepCoding.ModuleScript.Module'). Reassigning them will replace their values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| onActivate | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the lights turn on. |
| onNeedyActivation | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the needy activates. |
| onNeedyDeactivation | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the needy deactivates. |
| onPass | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the needy is solved. |
| onStrike | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the needy strikes. |
| onTimerExpired | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Called when the timer runs out of time. |

##### Remarks

An event that is null will be skipped. This extension method simplifies all of the KMFramework events into Actions or Functions.

<a name='M-KeepCoding-ModuleScript-Awake'></a>
### Awake() `method`

##### Summary

This initalizes the module. If you have an Awake method, be sure to call `base.Awake()` as the first statement.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.FormatException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.FormatException 'System.FormatException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

<a name='M-KeepCoding-ModuleScript-ButtonEffect-KMSelectable,System-Single,KeepCoding-Sound[]-'></a>
### ButtonEffect(selectable,intensityModifier,sounds) `method`

##### Summary

Handles typical button [OnInteract](#F-KMSelectable-OnInteract 'KMSelectable.OnInteract') behaviour.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| selectable | [KMSelectable](#T-KMSelectable 'KMSelectable') | The selectable, which is used as a source for sound and bomb shake. |
| intensityModifier | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The intensity of the bomb shaking. |
| sounds | [KeepCoding.Sound[]](#T-KeepCoding-Sound[] 'KeepCoding.Sound[]') | The sounds, these can either be [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), [AudioClip](#T-UnityEngine-AudioClip 'UnityEngine.AudioClip'), or [SoundEffect](#T-KMSoundOverride-SoundEffect 'KMSoundOverride.SoundEffect'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [UnityEngine.UnassignedReferenceException](#T-UnityEngine-UnassignedReferenceException 'UnityEngine.UnassignedReferenceException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-ModuleScript-Dump-System-Boolean,System-Linq-Expressions-Expression{System-Func{System-Object}}[]-'></a>
### Dump(getVariables,logs) `method`

##### Summary

Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| getVariables | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should search recursively for the elements within the elements. |
| logs | [System.Linq.Expressions.Expression{System.Func{System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{System.Object}}[]') | All of the variables to throughly log. |

<a name='M-KeepCoding-ModuleScript-Dump-System-Linq-Expressions-Expression{System-Func{System-Object}}[]-'></a>
### Dump(logs) `method`

##### Summary

Dumps all information about the variables specified. Each element uses the syntax () => varName. This should only be used to debug.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logs | [System.Linq.Expressions.Expression{System.Func{System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{System.Object}}[]') | All of the variables to throughly log. |

<a name='M-KeepCoding-ModuleScript-LogMultiple-System-String[]-'></a>
### LogMultiple(logs) `method`

##### Summary

Logs multiple entries to the console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logs | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The array of logs to individual output into the console. |

<a name='M-KeepCoding-ModuleScript-Log``1-``0,UnityEngine-LogType-'></a>
### Log\`\`1(message,logType) `method`

##### Summary

Logs message, but formats it to be compliant with the Logfile Analyzer.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [\`\`0](#T-``0 '``0') | The message to log. |
| logType | [UnityEngine.LogType](#T-UnityEngine-LogType 'UnityEngine.LogType') | The type of logging. Different logging types have different icons within the editor. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-ModuleScript-Log``1-``0,System-Object[]-'></a>
### Log\`\`1(message,args) `method`

##### Summary

Logs multiple entries, but formats it to be compliant with the Logfile Analyzer.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [\`\`0](#T-``0 '``0') | The message to log. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | All of the arguments to embed into `message`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-ModuleScript-OnActivate'></a>
### OnActivate() `method`

##### Summary

Called when the lights turn on.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-ModuleScript-OnDestroy'></a>
### OnDestroy() `method`

##### Summary

This removed the exception catcher. If you have an OnDestroy method, be sure to call `base.OnDestroy()` as the first statement.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-ModuleScript-OnModuleStrike-System-String-'></a>
### OnModuleStrike(moduleName) `method`

##### Summary

Called when any module on the current bomb has issued a strike.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moduleName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The sender's module name, which caused a strike. |

##### Remarks

Vanilla modules are an exception, they will not invoke this method.

<a name='M-KeepCoding-ModuleScript-OnNeedySolved-System-String-'></a>
### OnNeedySolved(moduleName) `method`

##### Summary

Called when any [KMNeedyModule](#T-KMNeedyModule 'KMNeedyModule') on the current bomb has been solved.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moduleName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The sender's module name, which was solved. |

##### Remarks

Vanilla modules are an exception, they will not invoke this method.

<a name='M-KeepCoding-ModuleScript-OnSolvableSolved-System-String-'></a>
### OnSolvableSolved(moduleName) `method`

##### Summary

Called when any [KMBombModule](#T-KMBombModule 'KMBombModule') on the current bomb has been solved.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| moduleName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The sender's module name, which was solved. |

##### Remarks

Vanilla modules are an exception, they will not invoke this method.

<a name='M-KeepCoding-ModuleScript-OnTimerTick'></a>
### OnTimerTick() `method`

##### Summary

Called when the timer's seconds-digit changes.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-ModuleScript-PlaySound-UnityEngine-Transform,System-Boolean,KeepCoding-Sound[]-'></a>
### PlaySound(transform,loop,sounds) `method`

##### Summary

Plays a sound. Requires [KMAudio](#T-KMAudio 'KMAudio') to be assigned.

##### Returns

A [KMAudioRef](#T-KMAudio-KMAudioRef 'KMAudio.KMAudioRef') for each argument you provide.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| transform | [UnityEngine.Transform](#T-UnityEngine-Transform 'UnityEngine.Transform') | The location or sound source of the sound. |
| loop | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether all sounds listed should loop or not. |
| sounds | [KeepCoding.Sound[]](#T-KeepCoding-Sound[] 'KeepCoding.Sound[]') | The sounds, these can either be [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), [AudioClip](#T-UnityEngine-AudioClip 'UnityEngine.AudioClip'), or [SoundEffect](#T-KMSoundOverride-SoundEffect 'KMSoundOverride.SoundEffect'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |
| [UnityEngine.MissingComponentException](#T-UnityEngine-MissingComponentException 'UnityEngine.MissingComponentException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-ModuleScript-PlaySound-UnityEngine-Transform,KeepCoding-Sound[]-'></a>
### PlaySound(transform,sounds) `method`

##### Summary

Plays a sound. Requires [KMAudio](#T-KMAudio 'KMAudio') to be assigned.

##### Returns

A [KMAudioRef](#T-KMAudio-KMAudioRef 'KMAudio.KMAudioRef') for each argument you provide.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| transform | [UnityEngine.Transform](#T-UnityEngine-Transform 'UnityEngine.Transform') | The location or sound source of the sound. |
| sounds | [KeepCoding.Sound[]](#T-KeepCoding-Sound[] 'KeepCoding.Sound[]') | The sounds, these can either be [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), [AudioClip](#T-UnityEngine-AudioClip 'UnityEngine.AudioClip'), or [SoundEffect](#T-KMSoundOverride-SoundEffect 'KMSoundOverride.SoundEffect'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-ModuleScript-PlaySound-System-Boolean,KeepCoding-Sound[]-'></a>
### PlaySound(loop,sounds) `method`

##### Summary

Plays a sound, the sound source is the game object it is attached to. Requires [KMAudio](#T-KMAudio 'KMAudio') to be assigned.

##### Returns

A [KMAudioRef](#T-KMAudio-KMAudioRef 'KMAudio.KMAudioRef') for each argument you provide.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loop | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether all sounds listed should loop or not. |
| sounds | [KeepCoding.Sound[]](#T-KeepCoding-Sound[] 'KeepCoding.Sound[]') | The sounds, these can either be [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), [AudioClip](#T-UnityEngine-AudioClip 'UnityEngine.AudioClip'), or [SoundEffect](#T-KMSoundOverride-SoundEffect 'KMSoundOverride.SoundEffect'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-ModuleScript-PlaySound-KeepCoding-Sound[]-'></a>
### PlaySound(sounds) `method`

##### Summary

Plays a sound, the sound source is the game object it is attached to. Requires [KMAudio](#T-KMAudio 'KMAudio') to be assigned.

##### Returns

A [KMAudioRef](#T-KMAudio-KMAudioRef 'KMAudio.KMAudioRef') for each argument you provide.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sounds | [KeepCoding.Sound[]](#T-KeepCoding-Sound[] 'KeepCoding.Sound[]') | The sounds, these can either be [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), [AudioClip](#T-UnityEngine-AudioClip 'UnityEngine.AudioClip'), or [SoundEffect](#T-KMSoundOverride-SoundEffect 'KMSoundOverride.SoundEffect'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedValueException](#T-KeepCoding-UnrecognizedValueException 'KeepCoding.UnrecognizedValueException') |  |

<a name='M-KeepCoding-ModuleScript-Read``1-System-String,System-String,System-Boolean-'></a>
### Read\`\`1(module,key,allowDefault) `method`

##### Summary

Allows you to read a module's data that uses [Write\`\`1](#M-KeepCoding-ModuleScript-Write``1-System-String,``0- 'KeepCoding.ModuleScript.Write``1(System.String,``0)'), even from a different assembly.

##### Returns

Every instance of the value from the every instance of the module specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| module | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The module to look into. |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The key of the variable, a lot like a variable name. |
| allowDefault | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should throw an exception if no value is found, or provide the default value instead. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the expected output. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Collections.Generic.KeyNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException') |  |
| [KeepCoding.WrongDatatypeException](#T-KeepCoding-WrongDatatypeException 'KeepCoding.WrongDatatypeException') |  |

##### Remarks

To ensure that this method works correctly, make sure that both modules have the same version of KeepCoding.

<a name='M-KeepCoding-ModuleScript-Solve-System-String[]-'></a>
### Solve(logs) `method`

##### Summary

Solves the module, and logs all of the parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logs | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | All of the entries to log. |

<a name='M-KeepCoding-ModuleScript-Strike-System-String[]-'></a>
### Strike(logs) `method`

##### Summary

Strikes the module, and logs all of the parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logs | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | All of the entries to log. |

<a name='M-KeepCoding-ModuleScript-Write``1-System-String,``0-'></a>
### Write\`\`1(key,value) `method`

##### Summary

Sends information to a static variable such that other modules can access it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The key of the variable, a lot like a variable name. |
| value | [\`\`0](#T-``0 '``0') | The value to store in the key. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the expected input. |

##### Remarks

To ensure that this method works correctly, make sure that both modules have the same version of KeepCoding.

<a name='T-KeepCoding-NegativeNumberException'></a>
## NegativeNumberException `type`

##### Namespace

KeepCoding

##### Summary

An exception thrown when the number is unexpectedly negative. Written by Emik.

<a name='M-KeepCoding-NegativeNumberException-#ctor'></a>
### #ctor() `constructor`

##### Summary

An exception thrown when the number is unexpectedly negative.

##### Parameters

This constructor has no parameters.

<a name='M-KeepCoding-NegativeNumberException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

An exception thrown when the number is unexpectedly negative.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |

<a name='M-KeepCoding-NegativeNumberException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

An exception thrown when the number is unexpectedly negative.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | An [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') within this exception. |

<a name='T-KeepCoding-NullIteratorException'></a>
## NullIteratorException `type`

##### Namespace

KeepCoding

##### Summary

An exception thrown when the iterator is null. Written by Emik.

<a name='M-KeepCoding-NullIteratorException-#ctor'></a>
### #ctor() `constructor`

##### Summary

An exception thrown when the iterator is null.

##### Parameters

This constructor has no parameters.

<a name='M-KeepCoding-NullIteratorException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

An exception thrown when the iterator is null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |

<a name='M-KeepCoding-NullIteratorException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

An exception thrown when the iterator is null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | An [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') within this exception. |

<a name='T-KeepCoding-Number'></a>
## Number `type`

##### Namespace

KeepCoding

##### Summary

Class meant to encapsulate a primitive numeric value. Written by Emik.

<a name='M-KeepCoding-Number-#ctor-System-SByte-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a [Number](#T-KeepCoding-Number 'KeepCoding.Number') with the inner type [SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte') | The inner value stored. |

<a name='M-KeepCoding-Number-#ctor-System-Byte-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a [Number](#T-KeepCoding-Number 'KeepCoding.Number') with the inner type [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The inner value stored. |

<a name='M-KeepCoding-Number-#ctor-System-Int16-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a [Number](#T-KeepCoding-Number 'KeepCoding.Number') with the inner type [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | The inner value stored. |

<a name='M-KeepCoding-Number-#ctor-System-UInt16-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a [Number](#T-KeepCoding-Number 'KeepCoding.Number') with the inner type [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The inner value stored. |

<a name='M-KeepCoding-Number-#ctor-System-Int32-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a [Number](#T-KeepCoding-Number 'KeepCoding.Number') with the inner type [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The inner value stored. |

<a name='M-KeepCoding-Number-#ctor-System-UInt32-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a [Number](#T-KeepCoding-Number 'KeepCoding.Number') with the inner type [UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The inner value stored. |

<a name='M-KeepCoding-Number-#ctor-System-Int64-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a [Number](#T-KeepCoding-Number 'KeepCoding.Number') with the inner type [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The inner value stored. |

<a name='M-KeepCoding-Number-#ctor-System-UInt64-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a [Number](#T-KeepCoding-Number 'KeepCoding.Number') with the inner type [UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The inner value stored. |

<a name='M-KeepCoding-Number-#ctor-System-Single-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a [Number](#T-KeepCoding-Number 'KeepCoding.Number') with the inner type [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The inner value stored. |

<a name='M-KeepCoding-Number-#ctor-System-Double-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a [Number](#T-KeepCoding-Number 'KeepCoding.Number') with the inner type [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | The inner value stored. |

<a name='M-KeepCoding-Number-#ctor-System-Decimal-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a [Number](#T-KeepCoding-Number 'KeepCoding.Number') with the inner type [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | The inner value stored. |

<a name='P-KeepCoding-Number-Epsilon'></a>
### Epsilon `property`

##### Remarks

Calling this will assume that the value is either [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single'), [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'), or [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal'). An exception is thrown otherwise.

<a name='P-KeepCoding-Number-MaxValue'></a>
### MaxValue `property`

<a name='P-KeepCoding-Number-MinValue'></a>
### MinValue `property`

<a name='P-KeepCoding-Number-NaN'></a>
### NaN `property`

##### Remarks

Calling this will assume that the value is either [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') or [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'). An exception is thrown otherwise.

<a name='P-KeepCoding-Number-NegativeInfinity'></a>
### NegativeInfinity `property`

##### Remarks

Calling this will assume that the value is either [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') or [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'). An exception is thrown otherwise.

<a name='P-KeepCoding-Number-PositiveInfinity'></a>
### PositiveInfinity `property`

##### Remarks

Calling this will assume that the value is either [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') or [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'). An exception is thrown otherwise.

<a name='M-KeepCoding-Number-Cast``1'></a>
### Cast\`\`1() `method`

##### Summary

Casts the [Number](#T-KeepCoding-Number 'KeepCoding.Number') into the numeric type. Unlike implicit casting, the value will trim the bytes that cannot occupy the new datatype, such as a number being too large or decimals.

##### Returns

Itself as `T`.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Number-CompareTo-System-Object-'></a>
### CompareTo(obj) `method`

##### Summary

Compares and determines the difference between both items.

##### Returns

The difference between both items.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The comparison. |

<a name='M-KeepCoding-Number-CompareTo-KeepCoding-Number-'></a>
### CompareTo(other) `method`

##### Summary

Compares and determines the difference between both items.

##### Returns

The difference between both items.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The comparison. |

<a name='M-KeepCoding-Number-CompareTo-System-ValueType-'></a>
### CompareTo(other) `method`

##### Summary

Compares and determines the difference between both items.

##### Returns

The difference between both items.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [System.ValueType](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueType 'System.ValueType') | The comparison. |

<a name='M-KeepCoding-Number-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Determines if both items are equal in value.

##### Returns

True if both items share the same value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The comparison. |

<a name='M-KeepCoding-Number-Equals-KeepCoding-Number-'></a>
### Equals(other) `method`

##### Summary

Determines if both items are equal in value.

##### Returns

True if both items share the same value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The comparison. |

<a name='M-KeepCoding-Number-Equals-System-ValueType-'></a>
### Equals(other) `method`

##### Summary

Determines if both items are equal in value.

##### Returns

True if both items share the same value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [System.ValueType](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueType 'System.ValueType') | The comparison. |

<a name='M-KeepCoding-Number-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Determines the hash code of the item, based on the value.

##### Returns

The hash code.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Number-GetTypeCode'></a>
### GetTypeCode() `method`

##### Summary

Determines the type of value it currently is within the [TypeCode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TypeCode 'System.TypeCode') enum.

##### Returns

The current type.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Number-IsNaN'></a>
### IsNaN() `method`

##### Summary

Determines if the value is not a number.

##### Returns

True if the value is not a number.

##### Parameters

This method has no parameters.

##### Remarks

Calling this will assume that the value is either [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') or [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'). An exception is thrown otherwise.

<a name='M-KeepCoding-Number-Modulo-KeepCoding-Number-'></a>
### Modulo(other) `method`

##### Summary

Calculates the rem-euclid modulo, which allows negative numbers to be properly calculated.

##### Returns

Itself mod `other`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side operator. |

<a name='M-KeepCoding-Number-New``1-``0-'></a>
### New\`\`1() `method`

##### Summary

Creates a new [Number](#T-KeepCoding-Number 'KeepCoding.Number') with the inner type being the type specified.

##### Returns

A [Number](#T-KeepCoding-Number 'KeepCoding.Number') with inner `T`.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The inner type of the [Number](#T-KeepCoding-Number 'KeepCoding.Number'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.UnrecognizedTypeException](#T-KeepCoding-UnrecognizedTypeException 'KeepCoding.UnrecognizedTypeException') |  |

##### Remarks

Calling this will assume that the value is [SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16'), [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'), [UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32'), [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64'), [UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64'), [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single'), [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'), or [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal'). An exception is thrown outherwise.

<a name='M-KeepCoding-Number-Parse-System-String-'></a>
### Parse(s) `method`

##### Summary

Parses a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') as [Number](#T-KeepCoding-Number 'KeepCoding.Number'). An exception is thrown if it fails.

##### Returns

The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') as [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to parse. |

##### Remarks

The smallest possible type is used. The order of types from first-to-last are: [SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16'), [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'), [UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32'), [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64'), [UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64'), [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single'), [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'), [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal').

<a name='M-KeepCoding-Number-Parse-System-String,System-Globalization-NumberStyles-'></a>
### Parse(s,style) `method`

##### Summary

Parses a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') as [Number](#T-KeepCoding-Number 'KeepCoding.Number'). An exception is thrown if it fails.

##### Returns

The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') as [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to parse. |
| style | [System.Globalization.NumberStyles](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberStyles 'System.Globalization.NumberStyles') | The [NumberStyles](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberStyles 'System.Globalization.NumberStyles') used for parsing. |

<a name='M-KeepCoding-Number-Parse-System-String,System-IFormatProvider-'></a>
### Parse(s,provider) `method`

##### Summary

Parses a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') as [Number](#T-KeepCoding-Number 'KeepCoding.Number'). An exception is thrown if it fails.

##### Returns

The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') as [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to parse. |
| provider | [System.IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') | The [IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') used for parsing. |

<a name='M-KeepCoding-Number-Parse-System-String,System-Globalization-NumberStyles,System-IFormatProvider-'></a>
### Parse(s,style,provider) `method`

##### Summary

Parses a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') as [Number](#T-KeepCoding-Number 'KeepCoding.Number'). An exception is thrown if it fails.

##### Returns

The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') as [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to parse. |
| style | [System.Globalization.NumberStyles](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberStyles 'System.Globalization.NumberStyles') | The [NumberStyles](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberStyles 'System.Globalization.NumberStyles') used for parsing. |
| provider | [System.IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') | The [IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') used for parsing. |

<a name='M-KeepCoding-Number-Parse-System-String,System-Globalization-NumberStyles,System-Globalization-NumberFormatInfo-'></a>
### Parse(s,style,info) `method`

##### Summary

Parses a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') as [Number](#T-KeepCoding-Number 'KeepCoding.Number'). An exception is thrown if it fails.

##### Returns

The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') as [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to parse. |
| style | [System.Globalization.NumberStyles](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberStyles 'System.Globalization.NumberStyles') | The [NumberStyles](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberStyles 'System.Globalization.NumberStyles') used for parsing. |
| info | [System.Globalization.NumberFormatInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberFormatInfo 'System.Globalization.NumberFormatInfo') | The [NumberFormatInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberFormatInfo 'System.Globalization.NumberFormatInfo') used for parsing. |

<a name='M-KeepCoding-Number-ToString'></a>
### ToString() `method`

##### Summary

Converts the value to a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Returns

The value as [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Number-ToString-System-String-'></a>
### ToString(format) `method`

##### Summary

Converts the value to a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Returns

The value as [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') format of the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'). |

<a name='M-KeepCoding-Number-ToString-System-IFormatProvider-'></a>
### ToString(provider) `method`

##### Summary

Converts the value to a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Returns

The value as [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| provider | [System.IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') | The [IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') format of the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'). |

<a name='M-KeepCoding-Number-ToString-System-String,System-IFormatProvider-'></a>
### ToString(format,provider) `method`

##### Summary

Converts the value to a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Returns

The value as [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') format of the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'). |
| provider | [System.IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') | The [IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') format of the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'). |

<a name='M-KeepCoding-Number-ToString-System-String,System-Globalization-NumberFormatInfo-'></a>
### ToString(format,info) `method`

##### Summary

Converts the value to a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Returns

The value as [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') format of the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'). |
| info | [System.Globalization.NumberFormatInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberFormatInfo 'System.Globalization.NumberFormatInfo') | The [NumberFormatInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberFormatInfo 'System.Globalization.NumberFormatInfo') format of the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'). |

<a name='M-KeepCoding-Number-TryParse-System-String,KeepCoding-Number@-'></a>
### TryParse(s,number) `method`

##### Summary

Attempts to parse a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') as [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Returns

True if it was able to successfully parse the string as a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to parse. |
| number | [KeepCoding.Number@](#T-KeepCoding-Number@ 'KeepCoding.Number@') | The number to store the result in. An instance is returned if it is able to be casted successfully, and `null` otherwise. |

##### Remarks

The smallest possible type is used. The order of types from first-to-last are: [SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16'), [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'), [UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32'), [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64'), [UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64'), [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single'), [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'), [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal').

<a name='M-KeepCoding-Number-TryParse-System-String,System-Globalization-NumberStyles,System-IFormatProvider,KeepCoding-Number@-'></a>
### TryParse(s,style,provider,number) `method`

##### Summary

Attempts to parse a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') as [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Returns

True if it was able to successfully parse the string as a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to parse. |
| style | [System.Globalization.NumberStyles](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberStyles 'System.Globalization.NumberStyles') | The [NumberStyles](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberStyles 'System.Globalization.NumberStyles') used for parsing. |
| provider | [System.IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') | The [IFormatProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IFormatProvider 'System.IFormatProvider') used for parsing. |
| number | [KeepCoding.Number@](#T-KeepCoding-Number@ 'KeepCoding.Number@') | The number to store the result in. An instance is returned if it is able to be casted successfully, and `null` otherwise. |

##### Remarks

The smallest possible type is used. The order of types from first-to-last are: [SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16'), [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'), [UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32'), [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64'), [UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64'), [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single'), [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'), [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal').

<a name='M-KeepCoding-Number-TryParse-System-String,System-Globalization-NumberStyles,System-Globalization-NumberFormatInfo,KeepCoding-Number@-'></a>
### TryParse(s,style,info,number) `method`

##### Summary

Attempts to parse a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') as [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Returns

True if it was able to successfully parse the string as a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to parse. |
| style | [System.Globalization.NumberStyles](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberStyles 'System.Globalization.NumberStyles') | The [NumberStyles](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberStyles 'System.Globalization.NumberStyles') used for parsing. |
| info | [System.Globalization.NumberFormatInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberFormatInfo 'System.Globalization.NumberFormatInfo') | The [NumberFormatInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Globalization.NumberFormatInfo 'System.Globalization.NumberFormatInfo') used for parsing. |
| number | [KeepCoding.Number@](#T-KeepCoding-Number@ 'KeepCoding.Number@') | The number to store the result in. An instance is returned if it is able to be casted successfully, and `null` otherwise. |

##### Remarks

The smallest possible type is used. The order of types from first-to-last are: [SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16'), [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'), [UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32'), [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64'), [UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64'), [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single'), [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'), [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal').

<a name='M-KeepCoding-Number-op_Addition-KeepCoding-Number,KeepCoding-Number-'></a>
### op_Addition(number,other) `method`

##### Summary

Add operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

##### Remarks

[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') implicitly converts to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32').

<a name='M-KeepCoding-Number-op_BitwiseAnd-KeepCoding-Number,KeepCoding-Number-'></a>
### op_BitwiseAnd(number,other) `method`

##### Summary

And operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

##### Remarks

[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') implicitly converts to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'). Calling this will assume that the value is not [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single'), [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'), or [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal'). An exception is thrown otherwise.

<a name='M-KeepCoding-Number-op_BitwiseOr-KeepCoding-Number,KeepCoding-Number-'></a>
### op_BitwiseOr(number,other) `method`

##### Summary

Or operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

##### Remarks

[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') implicitly converts to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'). Calling this will assume that the value is not [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single'), [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'), or [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal'). An exception is thrown otherwise.

<a name='M-KeepCoding-Number-op_Decrement-KeepCoding-Number-'></a>
### op_Decrement(number) `method`

##### Summary

Decrement operator.

##### Returns

The number with the operator applied to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The number to apply the operator to. |

<a name='M-KeepCoding-Number-op_Division-KeepCoding-Number,KeepCoding-Number-'></a>
### op_Division(number,other) `method`

##### Summary

Divide operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

##### Remarks

[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') implicitly converts to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32').

<a name='M-KeepCoding-Number-op_Equality-KeepCoding-Number,KeepCoding-Number-'></a>
### op_Equality(number,other) `method`

##### Summary

Equals operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

<a name='M-KeepCoding-Number-op_Equality-KeepCoding-Number,System-ValueType-'></a>
### op_Equality(number,other) `method`

##### Summary

Equals operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [System.ValueType](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueType 'System.ValueType') | The right-hand side of the operator. |

<a name='M-KeepCoding-Number-op_ExclusiveOr-KeepCoding-Number,KeepCoding-Number-'></a>
### op_ExclusiveOr(number,other) `method`

##### Summary

Xor operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

##### Remarks

[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') implicitly converts to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'). Calling this will assume that the value is not [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single'), [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'), or [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal'). An exception is thrown otherwise.

<a name='M-KeepCoding-Number-op_False-KeepCoding-Number-'></a>
### op_False(number) `method`

##### Summary

False operator.

##### Returns

The number with the operator applied to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The number to apply the operator to. |

##### Remarks

False if the operator is zero or less.

<a name='M-KeepCoding-Number-op_GreaterThan-KeepCoding-Number,KeepCoding-Number-'></a>
### op_GreaterThan(number,other) `method`

##### Summary

More than operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

<a name='M-KeepCoding-Number-op_GreaterThan-KeepCoding-Number,System-ValueType-'></a>
### op_GreaterThan(number,other) `method`

##### Summary

More than operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [System.ValueType](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueType 'System.ValueType') | The right-hand side of the operator. |

<a name='M-KeepCoding-Number-op_GreaterThanOrEqual-KeepCoding-Number,KeepCoding-Number-'></a>
### op_GreaterThanOrEqual(number,other) `method`

##### Summary

More than or equal operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

<a name='M-KeepCoding-Number-op_GreaterThanOrEqual-KeepCoding-Number,System-ValueType-'></a>
### op_GreaterThanOrEqual(number,other) `method`

##### Summary

More than or equals operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [System.ValueType](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueType 'System.ValueType') | The right-hand side of the operator. |

<a name='M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Boolean'></a>
### op_Implicit(number) `method`

##### Summary

Bool operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number)~System.Boolean](#T-KeepCoding-Number-~System-Boolean 'KeepCoding.Number)~System.Boolean') |  |

##### Remarks

True if the number is strictly larger than zero, otherwise false.

<a name='M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-SByte'></a>
### op_Implicit(number) `method`

##### Summary

Implicitly converts the value to a [SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number)~System.SByte](#T-KeepCoding-Number-~System-SByte 'KeepCoding.Number)~System.SByte') | The number to cast. |

##### Remarks

Calling this will assume that the value is in inclusively between [MinValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte.MinValue 'System.SByte.MinValue') and [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte.MaxValue 'System.SByte.MaxValue').

<a name='M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Byte'></a>
### op_Implicit(number) `method`

##### Summary

Implicitly converts the value to a [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number)~System.Byte](#T-KeepCoding-Number-~System-Byte 'KeepCoding.Number)~System.Byte') | The number to cast. |

##### Remarks

Calling this will assume that the value is in inclusively between [MinValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte.MinValue 'System.Byte.MinValue') and [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte.MaxValue 'System.Byte.MaxValue').

<a name='M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Int16'></a>
### op_Implicit(number) `method`

##### Summary

Implicitly converts the value to a [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number)~System.Int16](#T-KeepCoding-Number-~System-Int16 'KeepCoding.Number)~System.Int16') | The number to cast. |

##### Remarks

Calling this will assume that the value is in inclusively between [MinValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16.MinValue 'System.Int16.MinValue') and [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16.MaxValue 'System.Int16.MaxValue').

<a name='M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-UInt16'></a>
### op_Implicit(number) `method`

##### Summary

Implicitly converts the value to a [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number)~System.UInt16](#T-KeepCoding-Number-~System-UInt16 'KeepCoding.Number)~System.UInt16') | The number to cast. |

##### Remarks

Calling this will assume that the value is in inclusively between [MinValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16.MinValue 'System.UInt16.MinValue') and [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16.MaxValue 'System.UInt16.MaxValue').

<a name='M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Int32'></a>
### op_Implicit(number) `method`

##### Summary

Implicitly converts the value to a [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number)~System.Int32](#T-KeepCoding-Number-~System-Int32 'KeepCoding.Number)~System.Int32') | The number to cast. |

##### Remarks

Calling this will assume that the value is in inclusively between [MinValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32.MinValue 'System.Int32.MinValue') and [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32.MaxValue 'System.Int32.MaxValue').

<a name='M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-UInt32'></a>
### op_Implicit(number) `method`

##### Summary

Implicitly converts the value to a [UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number)~System.UInt32](#T-KeepCoding-Number-~System-UInt32 'KeepCoding.Number)~System.UInt32') | The number to cast. |

##### Remarks

Calling this will assume that the value is in inclusively between [MinValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32.MinValue 'System.UInt32.MinValue') and [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32.MaxValue 'System.UInt32.MaxValue').

<a name='M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Int64'></a>
### op_Implicit(number) `method`

##### Summary

Implicitly converts the value to a [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number)~System.Int64](#T-KeepCoding-Number-~System-Int64 'KeepCoding.Number)~System.Int64') | The number to cast. |

##### Remarks

Calling this will assume that the value is in inclusively between [MinValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64.MinValue 'System.Int64.MinValue') and [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64.MaxValue 'System.Int64.MaxValue').

<a name='M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-UInt64'></a>
### op_Implicit(number) `method`

##### Summary

Implicitly converts the value to a [UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number)~System.UInt64](#T-KeepCoding-Number-~System-UInt64 'KeepCoding.Number)~System.UInt64') | The number to cast. |

##### Remarks

Calling this will assume that the value is in inclusively between [MinValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64.MinValue 'System.UInt64.MinValue') and [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64.MaxValue 'System.UInt64.MaxValue').

<a name='M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Single'></a>
### op_Implicit(number) `method`

##### Summary

Implicitly converts the value to a [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number)~System.Single](#T-KeepCoding-Number-~System-Single 'KeepCoding.Number)~System.Single') | The number to cast. |

<a name='M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Double'></a>
### op_Implicit(number) `method`

##### Summary

Implicitly converts the value to a [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number)~System.Double](#T-KeepCoding-Number-~System-Double 'KeepCoding.Number)~System.Double') | The number to cast. |

<a name='M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-Decimal'></a>
### op_Implicit(number) `method`

##### Summary

Implicitly converts the value to a [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number)~System.Decimal](#T-KeepCoding-Number-~System-Decimal 'KeepCoding.Number)~System.Decimal') | The number to cast. |

<a name='M-KeepCoding-Number-op_Implicit-KeepCoding-Number-~System-ValueType'></a>
### op_Implicit(number) `method`

##### Summary

Implicitly converts the value to a [ValueType](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueType 'System.ValueType').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number)~System.ValueType](#T-KeepCoding-Number-~System-ValueType 'KeepCoding.Number)~System.ValueType') | The number to cast. |

<a name='M-KeepCoding-Number-op_Implicit-System-SByte-~KeepCoding-Number'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts the value to a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.SByte)~KeepCoding.Number](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte)~KeepCoding.Number 'System.SByte)~KeepCoding.Number') | The value to use in the constructor. |

<a name='M-KeepCoding-Number-op_Implicit-System-Byte-~KeepCoding-Number'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts the value to a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Byte)~KeepCoding.Number](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte)~KeepCoding.Number 'System.Byte)~KeepCoding.Number') | The value to use in the constructor. |

<a name='M-KeepCoding-Number-op_Implicit-System-Int16-~KeepCoding-Number'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts the value to a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int16)~KeepCoding.Number](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16)~KeepCoding.Number 'System.Int16)~KeepCoding.Number') | The value to use in the constructor. |

<a name='M-KeepCoding-Number-op_Implicit-System-UInt16-~KeepCoding-Number'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts the value to a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt16)~KeepCoding.Number](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16)~KeepCoding.Number 'System.UInt16)~KeepCoding.Number') | The value to use in the constructor. |

<a name='M-KeepCoding-Number-op_Implicit-System-Int32-~KeepCoding-Number'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts the value to a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32)~KeepCoding.Number](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32)~KeepCoding.Number 'System.Int32)~KeepCoding.Number') | The value to use in the constructor. |

<a name='M-KeepCoding-Number-op_Implicit-System-UInt32-~KeepCoding-Number'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts the value to a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt32)~KeepCoding.Number](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32)~KeepCoding.Number 'System.UInt32)~KeepCoding.Number') | The value to use in the constructor. |

<a name='M-KeepCoding-Number-op_Implicit-System-Int64-~KeepCoding-Number'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts the value to a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64)~KeepCoding.Number](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64)~KeepCoding.Number 'System.Int64)~KeepCoding.Number') | The value to use in the constructor. |

<a name='M-KeepCoding-Number-op_Implicit-System-UInt64-~KeepCoding-Number'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts the value to a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt64)~KeepCoding.Number](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64)~KeepCoding.Number 'System.UInt64)~KeepCoding.Number') | The value to use in the constructor. |

<a name='M-KeepCoding-Number-op_Implicit-System-Single-~KeepCoding-Number'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts the value to a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Single)~KeepCoding.Number](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single)~KeepCoding.Number 'System.Single)~KeepCoding.Number') | The value to use in the constructor. |

<a name='M-KeepCoding-Number-op_Implicit-System-Double-~KeepCoding-Number'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts the value to a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double)~KeepCoding.Number](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double)~KeepCoding.Number 'System.Double)~KeepCoding.Number') | The value to use in the constructor. |

<a name='M-KeepCoding-Number-op_Implicit-System-Decimal-~KeepCoding-Number'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts the value to a [Number](#T-KeepCoding-Number 'KeepCoding.Number').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Decimal)~KeepCoding.Number](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal)~KeepCoding.Number 'System.Decimal)~KeepCoding.Number') | The value to use in the constructor. |

<a name='M-KeepCoding-Number-op_Increment-KeepCoding-Number-'></a>
### op_Increment(number) `method`

##### Summary

Increment operator.

##### Returns

The number with the operator applied to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The number to apply the operator to. |

<a name='M-KeepCoding-Number-op_Inequality-KeepCoding-Number,KeepCoding-Number-'></a>
### op_Inequality(number,other) `method`

##### Summary

Equals operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

<a name='M-KeepCoding-Number-op_Inequality-KeepCoding-Number,System-ValueType-'></a>
### op_Inequality(number,other) `method`

##### Summary

Equals operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [System.ValueType](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueType 'System.ValueType') | The right-hand side of the operator. |

<a name='M-KeepCoding-Number-op_LeftShift-KeepCoding-Number,System-Int32-'></a>
### op_LeftShift(number,other) `method`

##### Summary

Left shift operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The right-hand side of the operator. |

##### Remarks

[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') implicitly converts to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'). Calling this will assume that the value is [SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16'), or [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'). An exception is thrown otherwise.

<a name='M-KeepCoding-Number-op_LessThan-KeepCoding-Number,KeepCoding-Number-'></a>
### op_LessThan(number,other) `method`

##### Summary

Less than operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

<a name='M-KeepCoding-Number-op_LessThan-KeepCoding-Number,System-ValueType-'></a>
### op_LessThan(number,other) `method`

##### Summary

Less than operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [System.ValueType](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueType 'System.ValueType') | The right-hand side of the operator. |

<a name='M-KeepCoding-Number-op_LessThanOrEqual-KeepCoding-Number,KeepCoding-Number-'></a>
### op_LessThanOrEqual(number,other) `method`

##### Summary

Less than or equal operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

<a name='M-KeepCoding-Number-op_LessThanOrEqual-KeepCoding-Number,System-ValueType-'></a>
### op_LessThanOrEqual(number,other) `method`

##### Summary

Less than or equal operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [System.ValueType](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueType 'System.ValueType') | The right-hand side of the operator. |

<a name='M-KeepCoding-Number-op_Modulus-KeepCoding-Number,KeepCoding-Number-'></a>
### op_Modulus(number,other) `method`

##### Summary

Modulo operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

##### Remarks

[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') implicitly converts to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32').

<a name='M-KeepCoding-Number-op_Multiply-KeepCoding-Number,KeepCoding-Number-'></a>
### op_Multiply(number,other) `method`

##### Summary

Multiply operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

##### Remarks

[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') implicitly converts to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32').

<a name='M-KeepCoding-Number-op_OnesComplement-KeepCoding-Number-'></a>
### op_OnesComplement(number) `method`

##### Summary

Tilde operator.

##### Returns

The number with the operator applied to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The number to apply the operator to. |

##### Remarks

[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') implicitly converts to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'). [UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') implicitly converts to [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64'). Calling this will assume that the value is not [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single'), [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double'), or [Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal'). An exception is thrown otherwise.

<a name='M-KeepCoding-Number-op_RightShift-KeepCoding-Number,System-Int32-'></a>
### op_RightShift(number,other) `method`

##### Summary

Right shift operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The right-hand side of the operator. |

##### Remarks

[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') implicitly converts to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'). Calling this will assume that the value is [SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16'), or [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'). An exception is thrown otherwise.

<a name='M-KeepCoding-Number-op_Subtraction-KeepCoding-Number,KeepCoding-Number-'></a>
### op_Subtraction(number,other) `method`

##### Summary

Subtract operator.

##### Returns

A number representing the result of the two numbers applied with the operator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The left-hand side of the operator. |
| other | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The right-hand side of the operator. |

##### Remarks

[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') implicitly converts to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32').

<a name='M-KeepCoding-Number-op_True-KeepCoding-Number-'></a>
### op_True(number) `method`

##### Summary

True operator.

##### Returns

The number with the operator applied to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The number to apply the operator to. |

##### Remarks

True if the number is strictly larger than zero.

<a name='M-KeepCoding-Number-op_UnaryNegation-KeepCoding-Number-'></a>
### op_UnaryNegation(number) `method`

##### Summary

Minus operator.

##### Returns

The number with the operator applied to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The number to apply the operator to. |

##### Remarks

[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') implicitly converts to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32'). [UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') implicitly converts to [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64'). Calling this will assume that the value is not [UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64'). An exception is thrown otherwise.

<a name='M-KeepCoding-Number-op_UnaryPlus-KeepCoding-Number-'></a>
### op_UnaryPlus(number) `method`

##### Summary

Plus operator.

##### Returns

The number with the operator applied to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [KeepCoding.Number](#T-KeepCoding-Number 'KeepCoding.Number') | The number to apply the operator to. |

##### Remarks

[SByte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.SByte 'System.SByte'), [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte'), [Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16'), and [UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') implicitly converts to [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32').

<a name='T-KeepCoding-PathManager'></a>
## PathManager `type`

##### Namespace

KeepCoding

##### Summary

Allows loading external information stored on the module. Written by Emik.

<a name='P-KeepCoding-PathManager-AssemblyName'></a>
### AssemblyName `property`

<a name='P-KeepCoding-PathManager-Version'></a>
### Version `property`

##### Remarks

If you want the version number of your modules, refer to [Version](#P-KeepCoding-ModuleScript-Version 'KeepCoding.ModuleScript.Version') instead, or [GetModInfo\`\`1](#M-KeepCoding-PathManager-GetModInfo``1-``0- 'KeepCoding.PathManager.GetModInfo``1(``0)').

<a name='M-KeepCoding-PathManager-CombineMultiple-System-String[]-'></a>
### CombineMultiple(paths) `method`

##### Summary

Combines multiple paths together.

##### Returns

A single path consisting of the combined path of the array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paths | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The paths to combine with. |

<a name='M-KeepCoding-PathManager-GetAssets``1-System-String,System-String-'></a>
### GetAssets\`\`1(bundleFileName,bundleAssetFileName) `method`

##### Summary

Retrieves assets of a specific type from a different bundle file.

##### Returns

The assets retrieved from the file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bundleFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the bundle file. |
| bundleAssetFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the bundle file to grab the assets from. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TAsset | The type of asset to retrieve. |

<a name='M-KeepCoding-PathManager-GetAssets``1-System-Type,System-String-'></a>
### GetAssets\`\`1(type,bundleVideoFileName) `method`

##### Summary

Retrieves assets of a specific type from a different bundle file.

##### Returns

The [AssetBundleCreateRequest](#T-UnityEngine-AssetBundleCreateRequest 'UnityEngine.AssetBundleCreateRequest') needed to load the files, followed by the [VideoClip](#T-UnityEngine-Video-VideoClip 'UnityEngine.Video.VideoClip')[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Any data from the assembly, which is used to get the name. |
| bundleVideoFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the bundle that contains videos. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

<a name='M-KeepCoding-PathManager-GetAssets``2-``0,System-String-'></a>
### GetAssets\`\`2(_,bundleVideoFileName) `method`

##### Summary

Retrieves assets of a specific type from a different bundle file.

##### Returns

The [AssetBundleCreateRequest](#T-UnityEngine-AssetBundleCreateRequest 'UnityEngine.AssetBundleCreateRequest') needed to load the files, followed by the [VideoClip](#T-UnityEngine-Video-VideoClip 'UnityEngine.Video.VideoClip')[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| _ | [\`\`0](#T-``0 '``0') | Any data from the assembly, which is used to get the name. |
| bundleVideoFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the bundle that contains videos. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to get the assembly from, which is used to get the name. |
| TAsset | The type of asset to return. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

<a name='M-KeepCoding-PathManager-GetModInfo-System-String-'></a>
### GetModInfo(bundleFileName) `method`

##### Summary

Gets the path and deserializes the modInfo.json located at every mod's root folder.

##### Returns

A [ModInfo](#T-KeepCoding-ModInfo 'KeepCoding.ModInfo') of the mod info json file located in the mod.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bundleFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the bundle assembly. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') |  |

<a name='M-KeepCoding-PathManager-GetModInfo-System-Type-'></a>
### GetModInfo(type) `method`

##### Summary

Gets the path and deserializes the modInfo.json located at every mod's root folder.

##### Returns

A [ModInfo](#T-KeepCoding-ModInfo 'KeepCoding.ModInfo') of the mod info json file located in the mod.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Any data from the assembly, which is used to get the name. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') |  |

<a name='M-KeepCoding-PathManager-GetModInfo``1-``0-'></a>
### GetModInfo\`\`1(_) `method`

##### Summary

Gets the path and deserializes the modInfo.json located at every mod's root folder.

##### Returns

A [ModInfo](#T-KeepCoding-ModInfo 'KeepCoding.ModInfo') of the mod info json file located in the mod.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| _ | [\`\`0](#T-``0 '``0') | Any data from the assembly, which is used to get the name. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to get the assembly from, which is used to get the name. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') |  |

<a name='M-KeepCoding-PathManager-GetPath-System-String-'></a>
### GetPath(search) `method`

##### Summary

Finds the path of a given file within each mod.

##### Returns

The path to `search`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| search | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file to search for. Make sure to include extensions! |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

##### Remarks

You need to specify the extensions of the file too, otherwise the file cannot be found.

<a name='M-KeepCoding-PathManager-GetPath-System-Type-'></a>
### GetPath(type) `method`

##### Summary

Finds the path of the mod.

##### Returns

The path to the mod.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Any data from the assembly, which is used to get the name. |

<a name='M-KeepCoding-PathManager-GetPath``1-``0-'></a>
### GetPath\`\`1(_) `method`

##### Summary

Finds the path of the mod.

##### Returns

The path to the mod.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| _ | [\`\`0](#T-``0 '``0') | Any data from the assembly, which is used to get the name. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to get the assembly from, which is used to get the name. |

<a name='M-KeepCoding-PathManager-LoadLibrary-System-String,System-String-'></a>
### LoadLibrary(bundleFileName,libraryFileName) `method`

##### Summary

Loads a library by searching for the bundle. Do not run this on the Editor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bundleFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the bundle file. |
| libraryFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The library's name, excluding the extension. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

##### Remarks

If the library has already been loaded, then this method will prematurely halt.

<a name='M-KeepCoding-PathManager-LoadLibrary-System-Type,System-String-'></a>
### LoadLibrary(type,libraryFileName) `method`

##### Summary

Loads a library by searching for the bundle. Do not run this on the Editor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Any data from the assembly, which is used to get the name. |
| libraryFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The library's name, excluding the extension. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

##### Remarks

If the library has already been loaded, then this method will prematurely halt.

<a name='M-KeepCoding-PathManager-LoadLibrary``1-``0,System-String-'></a>
### LoadLibrary\`\`1(_,libraryFileName) `method`

##### Summary

Loads a library by searching for the bundle. Do not run this on the Editor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| _ | [\`\`0](#T-``0 '``0') | Any data from the assembly, which is used to get the name. |
| libraryFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The library's name, excluding the extension. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to get the assembly from, which is used to get the name. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') |  |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

##### Remarks

If the library has already been loaded, then this method will prematurely halt.

<a name='M-KeepCoding-PathManager-NameOfAssembly-System-Type-'></a>
### NameOfAssembly(type) `method`

##### Summary

Gets the assembly's directory where the type `type` exists.

##### Returns

The path to the directory of the assembly where the type `type` comes from.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type to get the assembly directory of. |

<a name='M-KeepCoding-PathManager-NameOfAssembly``1'></a>
### NameOfAssembly\`\`1() `method`

##### Summary

Gets the assembly's directory where the type `T` exists.

##### Returns

The path to the directory of the assembly where the type `T` comes from.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type to get the assembly directory of. |

<a name='M-KeepCoding-PathManager-PrintHierarchy-System-UInt16-'></a>
### PrintHierarchy(indentation) `method`

##### Summary

Prints a hierarchy of all game objects.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| indentation | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The amount of spaces used for indenting children of game objects. |

<a name='M-KeepCoding-PathManager-PrintHierarchy-UnityEngine-GameObject,System-UInt16,System-UInt16-'></a>
### PrintHierarchy(obj,indentation,depth) `method`

##### Summary

Prints the hierarchy from the game object specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [UnityEngine.GameObject](#T-UnityEngine-GameObject 'UnityEngine.GameObject') | The game object to search the hierarchy. |
| indentation | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The amount of spaces used for indenting children of game objects. |
| depth | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The level of depth which determines level of indentation. Leave this variable as 0. |

<a name='T-KeepCoding-Game-PlayerSettings'></a>
## PlayerSettings `type`

##### Namespace

KeepCoding.Game

##### Summary

Allows access into the player settings from the game. Do not use this class in the unity editor. Written by Emik.

<a name='P-KeepCoding-Game-PlayerSettings-AntiAliasing'></a>
### AntiAliasing `property`

##### Remarks

Default: 8.

<a name='P-KeepCoding-Game-PlayerSettings-InvertTiltControls'></a>
### InvertTiltControls `property`

##### Remarks

Default: `false`.

<a name='P-KeepCoding-Game-PlayerSettings-LanguageCode'></a>
### LanguageCode `property`

##### Remarks

Default: "en".

<a name='P-KeepCoding-Game-PlayerSettings-LockMouseToWindow'></a>
### LockMouseToWindow `property`

##### Remarks

Default: `false`.

<a name='P-KeepCoding-Game-PlayerSettings-MusicVolume'></a>
### MusicVolume `property`

##### Remarks

Default: 100.

<a name='P-KeepCoding-Game-PlayerSettings-RumbleEnabled'></a>
### RumbleEnabled `property`

##### Remarks

Default: `true`.

<a name='P-KeepCoding-Game-PlayerSettings-SFXVolume'></a>
### SFXVolume `property`

##### Remarks

Default: 100.

<a name='P-KeepCoding-Game-PlayerSettings-ShowLeaderBoards'></a>
### ShowLeaderBoards `property`

##### Remarks

Default: `true`.

<a name='P-KeepCoding-Game-PlayerSettings-ShowRotationUI'></a>
### ShowRotationUI `property`

##### Remarks

Default: `true`.

<a name='P-KeepCoding-Game-PlayerSettings-ShowScanline'></a>
### ShowScanline `property`

##### Remarks

Default: `true`.

<a name='P-KeepCoding-Game-PlayerSettings-SkipTitleScreen'></a>
### SkipTitleScreen `property`

##### Remarks

Default: `false`.

<a name='P-KeepCoding-Game-PlayerSettings-TouchpadInvert'></a>
### TouchpadInvert `property`

##### Remarks

Default: `false`.

<a name='P-KeepCoding-Game-PlayerSettings-UseModsAlways'></a>
### UseModsAlways `property`

##### Remarks

Default: `false`.

<a name='P-KeepCoding-Game-PlayerSettings-UseParallelModLoading'></a>
### UseParallelModLoading `property`

##### Remarks

Default: `false`.

<a name='P-KeepCoding-Game-PlayerSettings-VRModeRequested'></a>
### VRModeRequested `property`

<a name='P-KeepCoding-Game-PlayerSettings-VSync'></a>
### VSync `property`

##### Remarks

Default: 1.

<a name='T-KeepCoding-Routine'></a>
## Routine `type`

##### Namespace

KeepCoding

##### Summary

Advanced coroutine handler. Written by Emik.

<a name='M-KeepCoding-Routine-#ctor-System-Func{System-Collections-IEnumerator},UnityEngine-MonoBehaviour-'></a>
### #ctor(enumerator,monoBehaviour) `constructor`

##### Summary

Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerator | [System.Func{System.Collections.IEnumerator}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Collections.IEnumerator}') | The enumerator to call when initiated. |
| monoBehaviour | [UnityEngine.MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') | The MonoBehaviour to reference when calling the method. |

<a name='M-KeepCoding-Routine-Restart-System-Boolean-'></a>
### Restart(oneByOne) `method`

##### Summary

Stops and restarts the first coroutine that was run.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Routine-RestartAll-System-Boolean-'></a>
### RestartAll(oneByOne) `method`

##### Summary

Restarts all coroutines currently running.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Routine-Start-System-Boolean,System-Boolean-'></a>
### Start(allowMultiple,oneByOne) `method`

##### Summary

Starts the coroutine. Unless specified by `allowMultiple`, it will not be called if this class is in the middle of running the coroutine.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| allowMultiple | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether it should be allowed to create another instance of the coroutine even if it's running another one. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

<a name='M-KeepCoding-Routine-StartOrRestart-System-Boolean,System-Boolean-'></a>
### StartOrRestart(allowMultiple,oneByOne) `method`

##### Summary

Starts a coroutine if no coroutines are running, otherwise restarts.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| allowMultiple | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether it should be allowed to create another instance of the coroutine even if it's running another one. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

<a name='T-KeepCoding-RoutineBase'></a>
## RoutineBase `type`

##### Namespace

KeepCoding

##### Summary

Abstract class for the [Routine](#T-KeepCoding-Routine 'KeepCoding.Routine') datatype, since the different overloads are similar to each other. Written by Emik.

<a name='M-KeepCoding-RoutineBase-#ctor-UnityEngine-MonoBehaviour-'></a>
### #ctor(monoBehaviour) `constructor`

##### Summary

Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| monoBehaviour | [UnityEngine.MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') | The MonoBehaviour to reference when calling the method. |

<a name='P-KeepCoding-RoutineBase-Coroutines'></a>
### Coroutines `property`

<a name='P-KeepCoding-RoutineBase-Count'></a>
### Count `property`

<a name='P-KeepCoding-RoutineBase-IsRunning'></a>
### IsRunning `property`

<a name='P-KeepCoding-RoutineBase-Item-System-Int32-'></a>
### Item `property`

##### Summary

Indexes into [Coroutines](#P-KeepCoding-RoutineBase-Coroutines 'KeepCoding.RoutineBase.Coroutines').

##### Returns

The [Coroutine](#T-UnityEngine-Coroutine 'UnityEngine.Coroutine') from [Coroutines](#P-KeepCoding-RoutineBase-Coroutines 'KeepCoding.RoutineBase.Coroutines').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index to index into [Coroutines](#P-KeepCoding-RoutineBase-Coroutines 'KeepCoding.RoutineBase.Coroutines'). |

<a name='M-KeepCoding-RoutineBase-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Gets the enumerator of the [Routine](#T-KeepCoding-Routine 'KeepCoding.Routine'), using [Coroutines](#P-KeepCoding-RoutineBase-Coroutines 'KeepCoding.RoutineBase.Coroutines').

##### Returns

The list of [Coroutines](#P-KeepCoding-RoutineBase-Coroutines 'KeepCoding.RoutineBase.Coroutines') in this [Routine](#T-KeepCoding-Routine 'KeepCoding.Routine').

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-RoutineBase-Stop'></a>
### Stop() `method`

##### Summary

Stops the first coroutine that was called, and removes it from the list of coroutines.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-RoutineBase-StopAll'></a>
### StopAll() `method`

##### Summary

Stops all instances of the coroutine, and clears the list of coroutines.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='T-KeepCoding-Routine`1'></a>
## Routine\`1 `type`

##### Namespace

KeepCoding

##### Summary

Advanced coroutine handler. Written by Emik.

<a name='M-KeepCoding-Routine`1-#ctor-System-Func{`0,System-Collections-IEnumerator},UnityEngine-MonoBehaviour-'></a>
### #ctor(enumerator,monoBehaviour) `constructor`

##### Summary

Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerator | [System.Func{\`0,System.Collections.IEnumerator}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,System.Collections.IEnumerator}') | The enumerator to call when initiated. |
| monoBehaviour | [UnityEngine.MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') | The MonoBehaviour to reference when calling the method. |

<a name='M-KeepCoding-Routine`1-Restart-`0,System-Boolean-'></a>
### Restart(t,oneByOne) `method`

##### Summary

Stops and restarts the first coroutine that was run.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Routine`1-RestartAll-`0,System-Boolean-'></a>
### RestartAll(t,oneByOne) `method`

##### Summary

Restarts all coroutines currently running.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Routine`1-Start-`0,System-Boolean,System-Boolean-'></a>
### Start(t,allowMultiple,oneByOne) `method`

##### Summary

Starts the coroutine. Unless specified by `allowMultiple`, it will not be called if this class is in the middle of running the coroutine.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| allowMultiple | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether it should be allowed to create another instance of the coroutine even if it's running another one. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

<a name='M-KeepCoding-Routine`1-StartOrRestart-`0,System-Boolean,System-Boolean-'></a>
### StartOrRestart(t,allowMultiple,oneByOne) `method`

##### Summary

Starts a coroutine if no coroutines are running, otherwise restarts.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| allowMultiple | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether it should be allowed to create another instance of the coroutine even if it's running another one. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

<a name='T-KeepCoding-Routine`2'></a>
## Routine\`2 `type`

##### Namespace

KeepCoding

##### Summary

Advanced coroutine handler. Written by Emik.

<a name='M-KeepCoding-Routine`2-#ctor-System-Func{`0,`1,System-Collections-IEnumerator},UnityEngine-MonoBehaviour-'></a>
### #ctor(enumerator,monoBehaviour) `constructor`

##### Summary

Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerator | [System.Func{\`0,\`1,System.Collections.IEnumerator}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,System.Collections.IEnumerator}') | The enumerator to call when initiated. |
| monoBehaviour | [UnityEngine.MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') | The MonoBehaviour to reference when calling the method. |

<a name='M-KeepCoding-Routine`2-Restart-`0,`1,System-Boolean-'></a>
### Restart(t1,t2,oneByOne) `method`

##### Summary

Stops and restarts the first coroutine that was run.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t1 | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| t2 | [\`1](#T-`1 '`1') | The second argument to pass into the coroutine. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Routine`2-RestartAll-`0,`1,System-Boolean-'></a>
### RestartAll(t1,t2,oneByOne) `method`

##### Summary

Restarts all coroutines currently running.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t1 | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| t2 | [\`1](#T-`1 '`1') | The second argument to pass into the coroutine. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Routine`2-Start-`0,`1,System-Boolean,System-Boolean-'></a>
### Start(t1,t2,allowMultiple,oneByOne) `method`

##### Summary

Starts the coroutine. Unless specified by `allowMultiple`, it will not be called if this class is in the middle of running the coroutine.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t1 | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| t2 | [\`1](#T-`1 '`1') | The second argument to pass into the coroutine. |
| allowMultiple | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether it should be allowed to create another instance of the coroutine even if it's running another one. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

<a name='M-KeepCoding-Routine`2-StartOrRestart-`0,`1,System-Boolean,System-Boolean-'></a>
### StartOrRestart(t1,t2,allowMultiple,oneByOne) `method`

##### Summary

Starts a coroutine if no coroutines are running, otherwise restarts.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t1 | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| t2 | [\`1](#T-`1 '`1') | The second argument to pass into the coroutine. |
| allowMultiple | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether it should be allowed to create another instance of the coroutine even if it's running another one. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

<a name='T-KeepCoding-Routine`3'></a>
## Routine\`3 `type`

##### Namespace

KeepCoding

##### Summary

Advanced coroutine handler. Written by Emik.

<a name='M-KeepCoding-Routine`3-#ctor-System-Func{`0,`1,`2,System-Collections-IEnumerator},UnityEngine-MonoBehaviour-'></a>
### #ctor(enumerator,monoBehaviour) `constructor`

##### Summary

Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerator | [System.Func{\`0,\`1,\`2,System.Collections.IEnumerator}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,`2,System.Collections.IEnumerator}') | The enumerator to call when initiated. |
| monoBehaviour | [UnityEngine.MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') | The MonoBehaviour to reference when calling the method. |

<a name='M-KeepCoding-Routine`3-Restart-`0,`1,`2,System-Boolean-'></a>
### Restart(t1,t2,t3,oneByOne) `method`

##### Summary

Stops and restarts the first coroutine that was run.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t1 | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| t2 | [\`1](#T-`1 '`1') | The second argument to pass into the coroutine. |
| t3 | [\`2](#T-`2 '`2') | The third argument to pass into the coroutine. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Routine`3-RestartAll-`0,`1,`2,System-Boolean-'></a>
### RestartAll(t1,t2,t3,oneByOne) `method`

##### Summary

Restarts all coroutines currently running.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t1 | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| t2 | [\`1](#T-`1 '`1') | The second argument to pass into the coroutine. |
| t3 | [\`2](#T-`2 '`2') | The third argument to pass into the coroutine. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Routine`3-Start-`0,`1,`2,System-Boolean,System-Boolean-'></a>
### Start(t1,t2,t3,allowMultiple,oneByOne) `method`

##### Summary

Starts the coroutine. Unless specified by `allowMultiple`, it will not be called if this class is in the middle of running the coroutine.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t1 | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| t2 | [\`1](#T-`1 '`1') | The second argument to pass into the coroutine. |
| t3 | [\`2](#T-`2 '`2') | The third argument to pass into the coroutine. |
| allowMultiple | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether it should be allowed to create another instance of the coroutine even if it's running another one. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

<a name='M-KeepCoding-Routine`3-StartOrRestart-`0,`1,`2,System-Boolean,System-Boolean-'></a>
### StartOrRestart(t1,t2,t3,allowMultiple,oneByOne) `method`

##### Summary

Starts a coroutine if no coroutines are running, otherwise restarts.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t1 | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| t2 | [\`1](#T-`1 '`1') | The second argument to pass into the coroutine. |
| t3 | [\`2](#T-`2 '`2') | The third argument to pass into the coroutine. |
| allowMultiple | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether it should be allowed to create another instance of the coroutine even if it's running another one. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

<a name='T-KeepCoding-Routine`4'></a>
## Routine\`4 `type`

##### Namespace

KeepCoding

##### Summary

Advanced coroutine handler. Written by Emik.

<a name='M-KeepCoding-Routine`4-#ctor-System-Func{`0,`1,`2,`3,System-Collections-IEnumerator},UnityEngine-MonoBehaviour-'></a>
### #ctor(enumerator,monoBehaviour) `constructor`

##### Summary

Creates a list of coroutines so that you can start, restart, or stop any coroutine running inside this class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerator | [System.Func{\`0,\`1,\`2,\`3,System.Collections.IEnumerator}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,`2,`3,System.Collections.IEnumerator}') | The enumerator to call when initiated. |
| monoBehaviour | [UnityEngine.MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') | The MonoBehaviour to reference when calling the method. |

<a name='M-KeepCoding-Routine`4-Restart-`0,`1,`2,`3,System-Boolean-'></a>
### Restart(t1,t2,t3,t4,oneByOne) `method`

##### Summary

Stops and restarts the first coroutine that was run.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t1 | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| t2 | [\`1](#T-`1 '`1') | The second argument to pass into the coroutine. |
| t3 | [\`2](#T-`2 '`2') | The third argument to pass into the coroutine. |
| t4 | [\`3](#T-`3 '`3') | The fourth argument to pass into the coroutine. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Routine`4-RestartAll-`0,`1,`2,`3,System-Boolean-'></a>
### RestartAll(t1,t2,t3,t4,oneByOne) `method`

##### Summary

Restarts all coroutines currently running.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t1 | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| t2 | [\`1](#T-`1 '`1') | The second argument to pass into the coroutine. |
| t3 | [\`2](#T-`2 '`2') | The third argument to pass into the coroutine. |
| t4 | [\`3](#T-`3 '`3') | The fourth argument to pass into the coroutine. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.EmptyIteratorException](#T-KeepCoding-EmptyIteratorException 'KeepCoding.EmptyIteratorException') |  |

<a name='M-KeepCoding-Routine`4-Start-`0,`1,`2,`3,System-Boolean,System-Boolean-'></a>
### Start(t1,t2,t3,t4,allowMultiple,oneByOne) `method`

##### Summary

Starts the coroutine. Unless specified by `allowMultiple`, it will not be called if this class is in the middle of running the coroutine.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t1 | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| t2 | [\`1](#T-`1 '`1') | The second argument to pass into the coroutine. |
| t3 | [\`2](#T-`2 '`2') | The third argument to pass into the coroutine. |
| t4 | [\`3](#T-`3 '`3') | The fourth argument to pass into the coroutine. |
| allowMultiple | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether it should be allowed to create another instance of the coroutine even if it's running another one. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

<a name='M-KeepCoding-Routine`4-StartOrRestart-`0,`1,`2,`3,System-Boolean,System-Boolean-'></a>
### StartOrRestart(t1,t2,t3,t4,allowMultiple,oneByOne) `method`

##### Summary

Starts a coroutine if no coroutines are running, otherwise restarts.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t1 | [\`0](#T-`0 '`0') | The first argument to pass into the coroutine. |
| t2 | [\`1](#T-`1 '`1') | The second argument to pass into the coroutine. |
| t3 | [\`2](#T-`2 '`2') | The third argument to pass into the coroutine. |
| t4 | [\`3](#T-`3 '`3') | The fourth argument to pass into the coroutine. |
| allowMultiple | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether it should be allowed to create another instance of the coroutine even if it's running another one. |
| oneByOne | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If called multiple times, waits until the others are finished. |

<a name='T-KeepCoding-Sound'></a>
## Sound `type`

##### Namespace

KeepCoding

##### Summary

Class meant to encapsulate all types of sound effects [KMAudio](#T-KMAudio 'KMAudio') uses. Currently used in [ModuleScript](#T-KeepCoding-ModuleScript 'KeepCoding.ModuleScript'). Written by Emik.

<a name='M-KeepCoding-Sound-#ctor-System-String-'></a>
### #ctor(sound) `constructor`

##### Summary

An instance of Sound where [Custom](#P-KeepCoding-Sound-Custom 'KeepCoding.Sound.Custom') is defined.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sound | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The sound to insert. |

<a name='M-KeepCoding-Sound-#ctor-KMSoundOverride-SoundEffect-'></a>
### #ctor(sound) `constructor`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sound | [KMSoundOverride.SoundEffect](#T-KMSoundOverride-SoundEffect 'KMSoundOverride.SoundEffect') | The sound to insert. |

<a name='M-KeepCoding-Sound-#ctor-UnityEngine-AudioClip-'></a>
### #ctor(sound) `constructor`

##### Summary

An instance of Sound where [Custom](#P-KeepCoding-Sound-Custom 'KeepCoding.Sound.Custom') is defined.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sound | [UnityEngine.AudioClip](#T-UnityEngine-AudioClip 'UnityEngine.AudioClip') | The sound to insert. |

<a name='P-KeepCoding-Sound-AlarmClockBeep'></a>
### AlarmClockBeep `property`

<a name='P-KeepCoding-Sound-AlarmClockSnooze'></a>
### AlarmClockSnooze `property`

<a name='P-KeepCoding-Sound-BigButtonPress'></a>
### BigButtonPress `property`

<a name='P-KeepCoding-Sound-BigButtonRelease'></a>
### BigButtonRelease `property`

<a name='P-KeepCoding-Sound-BinderDrop'></a>
### BinderDrop `property`

<a name='P-KeepCoding-Sound-BombDefused'></a>
### BombDefused `property`

<a name='P-KeepCoding-Sound-BombDrop'></a>
### BombDrop `property`

<a name='P-KeepCoding-Sound-BombExplode'></a>
### BombExplode `property`

<a name='P-KeepCoding-Sound-BriefcaseClose'></a>
### BriefcaseClose `property`

<a name='P-KeepCoding-Sound-BriefcaseOpen'></a>
### BriefcaseOpen `property`

<a name='P-KeepCoding-Sound-ButtonPress'></a>
### ButtonPress `property`

<a name='P-KeepCoding-Sound-ButtonRelease'></a>
### ButtonRelease `property`

<a name='P-KeepCoding-Sound-CapacitorPop'></a>
### CapacitorPop `property`

<a name='P-KeepCoding-Sound-CorrectChime'></a>
### CorrectChime `property`

<a name='P-KeepCoding-Sound-Custom'></a>
### Custom `property`

<a name='P-KeepCoding-Sound-DossierOptionPressed'></a>
### DossierOptionPressed `property`

<a name='P-KeepCoding-Sound-EmergencyAlarm'></a>
### EmergencyAlarm `property`

<a name='P-KeepCoding-Sound-FastTimerBeep'></a>
### FastTimerBeep `property`

<a name='P-KeepCoding-Sound-FastestTimerBeep'></a>
### FastestTimerBeep `property`

<a name='P-KeepCoding-Sound-FreeplayDeviceDrop'></a>
### FreeplayDeviceDrop `property`

<a name='P-KeepCoding-Sound-Game'></a>
### Game `property`

<a name='P-KeepCoding-Sound-GameOverFanfare'></a>
### GameOverFanfare `property`

<a name='P-KeepCoding-Sound-LightBuzz'></a>
### LightBuzz `property`

<a name='P-KeepCoding-Sound-LightBuzzShort'></a>
### LightBuzzShort `property`

<a name='P-KeepCoding-Sound-MenuButtonPressed'></a>
### MenuButtonPressed `property`

<a name='P-KeepCoding-Sound-MenuDrop'></a>
### MenuDrop `property`

<a name='P-KeepCoding-Sound-NeedyActivated'></a>
### NeedyActivated `property`

<a name='P-KeepCoding-Sound-NeedyWarning'></a>
### NeedyWarning `property`

<a name='P-KeepCoding-Sound-NormalTimerBeep'></a>
### NormalTimerBeep `property`

<a name='P-KeepCoding-Sound-PageTurn'></a>
### PageTurn `property`

<a name='P-KeepCoding-Sound-Reference'></a>
### Reference `property`

<a name='P-KeepCoding-Sound-SelectionTick'></a>
### SelectionTick `property`

<a name='P-KeepCoding-Sound-Stamp'></a>
### Stamp `property`

<a name='P-KeepCoding-Sound-Strike'></a>
### Strike `property`

<a name='P-KeepCoding-Sound-Switch'></a>
### Switch `property`

<a name='P-KeepCoding-Sound-TitleMenuPressed'></a>
### TitleMenuPressed `property`

<a name='P-KeepCoding-Sound-TypewriterKey'></a>
### TypewriterKey `property`

<a name='P-KeepCoding-Sound-WireSequenceMechanism'></a>
### WireSequenceMechanism `property`

<a name='P-KeepCoding-Sound-WireSnip'></a>
### WireSnip `property`

<a name='M-KeepCoding-Sound-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Determines if both [Sound](#T-KeepCoding-Sound 'KeepCoding.Sound') variables are equal.

##### Returns

True if [Custom](#P-KeepCoding-Sound-Custom 'KeepCoding.Sound.Custom'), [Reference](#P-KeepCoding-Sound-Reference 'KeepCoding.Sound.Reference'), and [Game](#P-KeepCoding-Sound-Game 'KeepCoding.Sound.Game') are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The comparison. |

<a name='M-KeepCoding-Sound-Equals-KeepCoding-Sound-'></a>
### Equals(other) `method`

##### Summary

Determines if both [Sound](#T-KeepCoding-Sound 'KeepCoding.Sound') variables are equal.

##### Returns

True if [Custom](#P-KeepCoding-Sound-Custom 'KeepCoding.Sound.Custom'), [Reference](#P-KeepCoding-Sound-Reference 'KeepCoding.Sound.Reference'), and [Game](#P-KeepCoding-Sound-Game 'KeepCoding.Sound.Game') are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [KeepCoding.Sound](#T-KeepCoding-Sound 'KeepCoding.Sound') | The comparison. |

<a name='M-KeepCoding-Sound-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Gets the current hash code.

##### Returns

The hash code of [Custom](#P-KeepCoding-Sound-Custom 'KeepCoding.Sound.Custom'), [Reference](#P-KeepCoding-Sound-Reference 'KeepCoding.Sound.Reference'), and [Game](#P-KeepCoding-Sound-Game 'KeepCoding.Sound.Game').

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Sound-Method-KMAudio-'></a>
### Method(audio) `method`

##### Summary

Gets the corresponding sound method matching the arguments of this instance of [Sound](#T-KeepCoding-Sound 'KeepCoding.Sound').

##### Returns

A method that when called, will play the sound and return the [KMAudioRef](#T-KMAudio-KMAudioRef 'KMAudio.KMAudioRef') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| audio | [KMAudio](#T-KMAudio 'KMAudio') | The instance of [KMAudio](#T-KMAudio 'KMAudio') to play from. |

<a name='M-KeepCoding-Sound-StopSound'></a>
### StopSound() `method`

##### Summary

Stops the [Reference](#P-KeepCoding-Sound-Reference 'KeepCoding.Sound.Reference')'s sound.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Sound-ToString'></a>
### ToString() `method`

##### Summary

Converts the current sound to a string, returning the current sound.

##### Returns

[Game](#P-KeepCoding-Sound-Game 'KeepCoding.Sound.Game'), or if null, [Custom](#P-KeepCoding-Sound-Custom 'KeepCoding.Sound.Custom').

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Sound-op_Explicit-KeepCoding-Sound-~System-String'></a>
### op_Explicit(sound) `method`

##### Summary

Returns [Custom](#P-KeepCoding-Sound-Custom 'KeepCoding.Sound.Custom') for the current variable.

##### Returns

`sound`'s [Custom](#P-KeepCoding-Sound-Custom 'KeepCoding.Sound.Custom').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sound | [KeepCoding.Sound)~System.String](#T-KeepCoding-Sound-~System-String 'KeepCoding.Sound)~System.String') | The variable to grab the property from. |

<a name='M-KeepCoding-Sound-op_Explicit-KeepCoding-Sound-~System-Nullable{KMSoundOverride-SoundEffect}'></a>
### op_Explicit(sound) `method`

##### Summary

Returns [Game](#P-KeepCoding-Sound-Game 'KeepCoding.Sound.Game') for the current variable.

##### Returns

`sound`'s [Game](#P-KeepCoding-Sound-Game 'KeepCoding.Sound.Game').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sound | [KeepCoding.Sound)~System.Nullable{KMSoundOverride.SoundEffect}](#T-KeepCoding-Sound-~System-Nullable{KMSoundOverride-SoundEffect} 'KeepCoding.Sound)~System.Nullable{KMSoundOverride.SoundEffect}') | The variable to grab the property from. |

<a name='M-KeepCoding-Sound-op_Explicit-KeepCoding-Sound-~KMSoundOverride-SoundEffect'></a>
### op_Explicit(sound) `method`

##### Summary

Returns [Game](#P-KeepCoding-Sound-Game 'KeepCoding.Sound.Game') for the current variable.

##### Returns

`sound`'s [Game](#P-KeepCoding-Sound-Game 'KeepCoding.Sound.Game').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sound | [KeepCoding.Sound)~KMSoundOverride.SoundEffect](#T-KeepCoding-Sound-~KMSoundOverride-SoundEffect 'KeepCoding.Sound)~KMSoundOverride.SoundEffect') | The variable to grab the property from. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

<a name='M-KeepCoding-Sound-op_Implicit-System-String-~KeepCoding-Sound'></a>
### op_Implicit(sound) `method`

##### Summary

An instance of Sound where [Custom](#P-KeepCoding-Sound-Custom 'KeepCoding.Sound.Custom') is defined.

##### Returns

[Sound](#T-KeepCoding-Sound 'KeepCoding.Sound') with argument `sound`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sound | [System.String)~KeepCoding.Sound](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String)~KeepCoding.Sound 'System.String)~KeepCoding.Sound') | The sound to insert. |

<a name='M-KeepCoding-Sound-op_Implicit-UnityEngine-AudioClip-~KeepCoding-Sound'></a>
### op_Implicit(sound) `method`

##### Summary

An instance of Sound where [Custom](#P-KeepCoding-Sound-Custom 'KeepCoding.Sound.Custom') is defined.

##### Returns

[Sound](#T-KeepCoding-Sound 'KeepCoding.Sound') with argument `sound`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sound | [UnityEngine.AudioClip)~KeepCoding.Sound](#T-UnityEngine-AudioClip-~KeepCoding-Sound 'UnityEngine.AudioClip)~KeepCoding.Sound') | The sound to insert. |

<a name='M-KeepCoding-Sound-op_Implicit-KMSoundOverride-SoundEffect-~KeepCoding-Sound'></a>
### op_Implicit(sound) `method`

##### Summary

An instance of Sound where [Game](#P-KeepCoding-Sound-Game 'KeepCoding.Sound.Game') is defined.

##### Returns

[Sound](#T-KeepCoding-Sound 'KeepCoding.Sound') with argument `sound`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sound | [KMSoundOverride.SoundEffect)~KeepCoding.Sound](#T-KMSoundOverride-SoundEffect-~KeepCoding-Sound 'KMSoundOverride.SoundEffect)~KeepCoding.Sound') | The sound to insert. |

<a name='T-KeepCoding-ComponentPool-SpecialComponentTypeEnum'></a>
## SpecialComponentTypeEnum `type`

##### Namespace

KeepCoding.ComponentPool

##### Summary

Controls whether the modules will be chosen dynamically at runtime from whatever modules are loaded (based on the ComponentSource). Set to "None" to select specific module types.

<a name='F-KeepCoding-ComponentPool-SpecialComponentTypeEnum-ALL_NEEDY'></a>
### ALL_NEEDY `constants`

<a name='F-KeepCoding-ComponentPool-SpecialComponentTypeEnum-ALL_SOLVABLE'></a>
### ALL_SOLVABLE `constants`

<a name='F-KeepCoding-ComponentPool-SpecialComponentTypeEnum-None'></a>
### None `constants`

<a name='T-KeepCoding-TPScriptEditor'></a>
## TPScriptEditor `type`

##### Namespace

KeepCoding

##### Summary

Custom inspector for [TPScript\`1](#T-KeepCoding-TPScript`1 'KeepCoding.TPScript`1'). Written by Emik.

<a name='M-KeepCoding-TPScriptEditor-OnInspectorGUI'></a>
### OnInspectorGUI() `method`

##### Summary

Creates the force solve buttons.

##### Parameters

This method has no parameters.

<a name='T-KeepCoding-TPScript`1'></a>
## TPScript\`1 `type`

##### Namespace

KeepCoding

##### Summary

Base class for TwitchPlays support for solvable and needy modded modules in Keep Talking and Nobody Explodes. Written by Emik.

<a name='F-KeepCoding-TPScript`1-AutoSolve'></a>
### AutoSolve `constants`

<a name='F-KeepCoding-TPScript`1-CancelDetonate'></a>
### CancelDetonate `constants`

<a name='F-KeepCoding-TPScript`1-Cancelled'></a>
### Cancelled `constants`

<a name='F-KeepCoding-TPScript`1-EndMultipleStrikes'></a>
### EndMultipleStrikes `constants`

<a name='F-KeepCoding-TPScript`1-EndWaitingMusic'></a>
### EndWaitingMusic `constants`

<a name='F-KeepCoding-TPScript`1-HideCamera'></a>
### HideCamera `constants`

<a name='F-KeepCoding-TPScript`1-MultipleStrikes'></a>
### MultipleStrikes `constants`

<a name='F-KeepCoding-TPScript`1-Solve'></a>
### Solve `constants`

<a name='F-KeepCoding-TPScript`1-Strike'></a>
### Strike `constants`

<a name='F-KeepCoding-TPScript`1-ToggleWaitingMusic'></a>
### ToggleWaitingMusic `constants`

<a name='F-KeepCoding-TPScript`1-TryCancelSequence'></a>
### TryCancelSequence `constants`

<a name='F-KeepCoding-TPScript`1-UnsubmittablePenalty'></a>
### UnsubmittablePenalty `constants`

<a name='F-KeepCoding-TPScript`1-WaitingMusic'></a>
### WaitingMusic `constants`

<a name='P-KeepCoding-TPScript`1-Abandons'></a>
### Abandons `property`

##### Remarks

These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [OnActivate](#F-KMBombModule-OnActivate 'KMBombModule.OnActivate') or [OnActivate](#F-KMNeedyModule-OnActivate 'KMNeedyModule.OnActivate') or later.

<a name='P-KeepCoding-TPScript`1-Help'></a>
### Help `property`

<a name='P-KeepCoding-TPScript`1-IsCancelCommand'></a>
### IsCancelCommand `property`

##### Remarks

These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [OnActivate](#F-KMBombModule-OnActivate 'KMBombModule.OnActivate') or [OnActivate](#F-KMNeedyModule-OnActivate 'KMNeedyModule.OnActivate') or later.

<a name='P-KeepCoding-TPScript`1-IsTP'></a>
### IsTP `property`

##### Remarks

These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [OnActivate](#F-KMBombModule-OnActivate 'KMBombModule.OnActivate') or [OnActivate](#F-KMNeedyModule-OnActivate 'KMNeedyModule.OnActivate') or later.

<a name='P-KeepCoding-TPScript`1-IsTime'></a>
### IsTime `property`

##### Remarks

These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [OnActivate](#F-KMBombModule-OnActivate 'KMBombModule.OnActivate') or [OnActivate](#F-KMNeedyModule-OnActivate 'KMNeedyModule.OnActivate') or later.

<a name='P-KeepCoding-TPScript`1-IsTimeSkippable'></a>
### IsTimeSkippable `property`

##### Remarks

These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [OnActivate](#F-KMBombModule-OnActivate 'KMBombModule.OnActivate') or [OnActivate](#F-KMNeedyModule-OnActivate 'KMNeedyModule.OnActivate') or later.

<a name='P-KeepCoding-TPScript`1-IsZen'></a>
### IsZen `property`

##### Remarks

These values are set by the Twitch Plays mod using reflection. This field is set in `Start()`, therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in [OnActivate](#F-KMBombModule-OnActivate 'KMBombModule.OnActivate') or [OnActivate](#F-KMNeedyModule-OnActivate 'KMNeedyModule.OnActivate') or later.

<a name='P-KeepCoding-TPScript`1-Manual'></a>
### Manual `property`

<a name='P-KeepCoding-TPScript`1-Module'></a>
### Module `property`

<a name='M-KeepCoding-TPScript`1-AwardPoints-System-Int32-'></a>
### AwardPoints(points) `method`

##### Summary

Yield return this to award the user that sent the command points directly, this is currently used for mods like Souvenir to give points to users that answered the questions equally.

##### Returns

A formatted string for Twitch Plays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| points | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The amount of points to award. Negatives supported. |

<a name='M-KeepCoding-TPScript`1-AwardPointsOnSolve-System-Int32-'></a>
### AwardPointsOnSolve(points) `method`

##### Summary

Yield return this to award the last user that sent the command points when the module is solved. The module must prevent any user from sending commands afterward in order for Twitch Plays to award points to the correct user. This is currently used by the Twin module when extra points must be given but the module is not solved immediately.

##### Returns

A formatted string for Twitch Plays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| points | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The amount of points to award. Negatives supported. |

<a name='M-KeepCoding-TPScript`1-Detonate-System-Nullable{System-Single},System-String-'></a>
### Detonate(time,message) `method`

##### Summary

Yield return this to explode the bomb instantly. `time` is specified in number of seconds before the bomb explodes. (Note, sending another detonate command will auto-cancel the previous one on the same module if it hasn't happened already.). `message` is the message to send to chat upon detonation. Both of the parameters are optional.

##### Returns

A formatted string for Twitch Plays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The amount of time before the bomb blows up. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message to send. |

<a name='M-KeepCoding-TPScript`1-Evaluate``1-System-Boolean,``0,System-Object-'></a>
### Evaluate\`\`1(condition,then,otherwise) `method`

##### Summary

Works as a ternary operator. Returns `then` if `condition` is true, otherwise `otherwise`.

##### Returns

`then` or `otherwise`, depending on `condition`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The boolean to check. |
| then | [\`\`0](#T-``0 '``0') | The output to return if `condition` is true. |
| otherwise | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The output to return if `condition` is false. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of then condition. |

##### Remarks

You can `yield``return` different types with this method, such as ambiguity between a [KMSelectable](#T-KMSelectable 'KMSelectable')[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') and a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

<a name='M-KeepCoding-TPScript`1-ForceSolve'></a>
### ForceSolve() `method`

##### Summary

When the module runs into an exception or the module is forced to be solved, it calls this method.

##### Returns

A series of instructions for the Twitch Plays mod to handle in order to guarantee a solve.

##### Parameters

This method has no parameters.

##### Remarks

Make sure that the module is solved before this method closes, otherwise it causes a forced-solve.

<a name='M-KeepCoding-TPScript`1-IsMatch-System-String,System-String,System-Boolean,System-Text-RegularExpressions-RegexOptions-'></a>
### IsMatch(input,pattern,lenient,options) `method`

##### Summary

Determines whether the input string matches the regex of the pattern.

##### Returns

True if `input` passes the test of the `pattern`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The test string. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The regular expression. |
| lenient | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should add the default `^\s* PATTERN \s*$` embeded into most regex usages for Twitch Plays. |
| options | [System.Text.RegularExpressions.RegexOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.RegexOptions 'System.Text.RegularExpressions.RegexOptions') | Any additional options for regular expressions. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

<a name='M-KeepCoding-TPScript`1-OnInteractSequence-KMSelectable[],System-Single,System-Int32[]-'></a>
### OnInteractSequence(selectables,indices,wait) `method`

##### Summary

Presses a sequence of buttons according to `indices` within `selectables`, waiting `wait` seconds in-between each, and interrupting as soon as [HasStruck](#P-KeepCoding-ModuleScript-HasStruck 'KeepCoding.ModuleScript.HasStruck') is true.

##### Returns

A sequence of button presses for Twitch Plays to process.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| selectables | [KMSelectable[]](#T-KMSelectable[] 'KMSelectable[]') | The array of selectables to interact with. |
| indices | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The indices to press within the array. |
| wait | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The delay between each button press in seconds. |

<a name='M-KeepCoding-TPScript`1-Process-System-String-'></a>
### Process(command) `method`

##### Summary

When a command is typed into Twitch Plays with the Id of this module, it calls this method and passes in the exact command typed.

##### Returns

A series of instructions for the Twitch Plays mod to handle as requested by the user.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The user's command. |

##### Remarks

Anything that gets yield returned will be processed by Twitch Plays. This includes other [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable') methods, [KMSelectable](#T-KMSelectable 'KMSelectable'), an [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') of [KMSelectable](#T-KMSelectable 'KMSelectable'), [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), `true`, or `null`.

<a name='M-KeepCoding-TPScript`1-SendDelayedMessage-System-Single,System-String-'></a>
### SendDelayedMessage(time,message) `method`

##### Summary

Yield return this to send a message to chat after `time` seconds.

##### Returns

A formatted string for Twitch Plays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount of time to wait before the message gets sent. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message to send. |

<a name='M-KeepCoding-TPScript`1-SendToChat-System-String-'></a>
### SendToChat(message) `method`

##### Summary

Yield return this to send a chat directly to twitch chat.

##### Returns

A formatted string for Twitch Plays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message to send. |

<a name='M-KeepCoding-TPScript`1-SendToChatError-System-String-'></a>
### SendToChatError(message) `method`

##### Summary

Yield return this to send a message to the chat about why a users' command was invalid.

##### Returns

A formatted string for Twitch Plays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message to send. |

<a name='M-KeepCoding-TPScript`1-SkipTime-System-String-'></a>
### SkipTime(seconds) `method`

##### Summary

Yield return this to try advancing the clock to the specified time. You must put the full time you wish to skip to, and this time either needs to be less than the current time, if in normal/time mode, or greater than the current time, if in zen mode. Example, if you wanted to set the clock to 5:24, then you do "skiptime 324" or "skiptime 5:24". You can target partway through the seconds, such as "skiptime 45.28", which would then set the clock to 45.28, provided that time has NOT gone by already. You must also set [IsTimeSkippable](#P-KeepCoding-TPScript`1-IsTimeSkippable 'KeepCoding.TPScript`1.IsTimeSkippable') to true, for this function to work.

##### Returns

A formatted string for Twitch Plays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| seconds | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The time to skip to in seconds. |

<a name='M-KeepCoding-TPScript`1-StrikeMessage-System-String-'></a>
### StrikeMessage(message) `method`

##### Summary

Yield return this to allow you to tell the user why they got a strike if it isn't clear.

##### Returns

A formatted string for Twitch Plays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message to send. |

<a name='M-KeepCoding-TPScript`1-TryCancel-System-String-'></a>
### TryCancel(message) `method`

##### Summary

Yield return this to indicate that this command is allowed to be cancelled at the given time of the yield. Just know that you won't be able to clean up if you do your cancel this way, and there is a pending !cancel or !stop.

##### Returns

A formatted string for Twitch Plays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message to send. |

<a name='M-KeepCoding-TPScript`1-TryWaitCancel-System-Single,System-String-'></a>
### TryWaitCancel(time,message) `method`

##### Summary

Yield return this to cause Twitch Plays to wait for the given time, and any time during the entire duration, the command may cancel. Like "trycancel", you won't be able to clean up if you cancel this way. Also like "trycancel", `message` is optional.

##### Returns

A formatted string for Twitch Plays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| time | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The amount of time to wait. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message to send. |

<a name='M-KeepCoding-TPScript`1-YieldUntil``1-``0,System-Func{System-Boolean}-'></a>
### YieldUntil\`\`1(item,condition) `method`

##### Summary

You can yield return this to repeatedly yield return an item until a condition is met.

##### Returns

`item` continously until `condition` is `true`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The item to yield repeatedly. |
| condition | [System.Func{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Boolean}') | The condition to repeatedly check until it returns `false`. |

<a name='M-KeepCoding-TPScript`1-YieldWhile``1-``0,System-Func{System-Boolean}-'></a>
### YieldWhile\`\`1(item,condition) `method`

##### Summary

You can yield return this to repeatedly yield return an item until a condition is no longer met.

##### Returns

`item` continously until `condition` is `false`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The item to yield repeatedly. |
| condition | [System.Func{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Boolean}') | The condition to repeatedly check until it returns `false`. |

<a name='T-KeepCoding-TupleBase'></a>
## TupleBase `type`

##### Namespace

KeepCoding

##### Summary

An abstract type meant for the tuple data type for C# 4. Written by Emik.

<a name='P-KeepCoding-TupleBase-IsEmpty'></a>
### IsEmpty `property`

<a name='P-KeepCoding-TupleBase-Item-System-Byte-'></a>
### Item `property`

##### Summary

Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.

##### Returns

The item indexed into.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The index to use. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |
| [KeepCoding.WrongDatatypeException](#T-KeepCoding-WrongDatatypeException 'KeepCoding.WrongDatatypeException') |  |

<a name='P-KeepCoding-TupleBase-Length'></a>
### Length `property`

<a name='P-KeepCoding-TupleBase-ToArray'></a>
### ToArray `property`

<a name='P-KeepCoding-TupleBase-UpperBound'></a>
### UpperBound `property`

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') |  |

<a name='M-KeepCoding-TupleBase-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Gets the enumerator of the tuple, using [ToArray](#P-KeepCoding-TupleBase-ToArray 'KeepCoding.TupleBase.ToArray').

##### Returns

All of the items in tuple.

##### Parameters

This method has no parameters.

<a name='T-KeepCoding-Tuple`1'></a>
## Tuple\`1 `type`

##### Namespace

KeepCoding

##### Summary

A basic tuple data type for C# 4. Written by Emik.

<a name='M-KeepCoding-Tuple`1-#ctor-`0-'></a>
### #ctor(item1) `constructor`

##### Summary

Creates a singleton tuple.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item1 | [\`0](#T-`0 '`0') | The item to pass into the first property. |

<a name='M-KeepCoding-Tuple`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a singleton tuple of default values.

##### Parameters

This constructor has no parameters.

<a name='P-KeepCoding-Tuple`1-Item-System-Byte-'></a>
### Item `property`

##### Summary

Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.

##### Returns

The item indexed into.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| i | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The index to use. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |
| [KeepCoding.WrongDatatypeException](#T-KeepCoding-WrongDatatypeException 'KeepCoding.WrongDatatypeException') |  |

<a name='P-KeepCoding-Tuple`1-Item1'></a>
### Item1 `property`

<a name='P-KeepCoding-Tuple`1-ToArray'></a>
### ToArray `property`

<a name='M-KeepCoding-Tuple`1-Destruct-`0@-'></a>
### Destruct(item) `method`

##### Summary

Destructs the tuple.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`0@](#T-`0@ '`0@') | The variable to assign the first element of the tuple. |

<a name='M-KeepCoding-Tuple`1-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Determines whether the tuple is equal.

##### Returns

True if itself and the parameter are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The [Tuple\`1](#T-KeepCoding-Tuple`1 'KeepCoding.Tuple`1') as [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object'). |

<a name='M-KeepCoding-Tuple`1-Equals-KeepCoding-Tuple{`0}-'></a>
### Equals(other) `method`

##### Summary

Determines whether the tuple is equal.

##### Returns

True if itself and the parameter are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [KeepCoding.Tuple{\`0}](#T-KeepCoding-Tuple{`0} 'KeepCoding.Tuple{`0}') | The [Tuple\`1](#T-KeepCoding-Tuple`1 'KeepCoding.Tuple`1') to compare to. |

<a name='M-KeepCoding-Tuple`1-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Gets the hash code of [Item1](#P-KeepCoding-Tuple`1-Item1 'KeepCoding.Tuple`1.Item1').

##### Returns

The hash code of [Item1](#P-KeepCoding-Tuple`1-Item1 'KeepCoding.Tuple`1.Item1').

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Tuple`1-ToString'></a>
### ToString() `method`

##### Summary

Gets the item, and returns it as a string.

##### Returns

[Item1](#P-KeepCoding-Tuple`1-Item1 'KeepCoding.Tuple`1.Item1') as [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Tuple`1-op_Equality-KeepCoding-Tuple{`0},KeepCoding-Tuple{`0}-'></a>
### op_Equality(tupleA,tupleB) `method`

##### Summary

Evaluates whether the item in the tuple is the same.

##### Returns

True if `tupleA.Item1.Item1` and `tupleB.Item1.Item1` are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tupleA | [KeepCoding.Tuple{\`0}](#T-KeepCoding-Tuple{`0} 'KeepCoding.Tuple{`0}') | The left-hand side comparison. |
| tupleB | [KeepCoding.Tuple{\`0}](#T-KeepCoding-Tuple{`0} 'KeepCoding.Tuple{`0}') | The right-hand side comparison. |

<a name='M-KeepCoding-Tuple`1-op_Inequality-KeepCoding-Tuple{`0},KeepCoding-Tuple{`0}-'></a>
### op_Inequality(tupleA,tupleB) `method`

##### Summary

Evaluates whether the item in the tuple is not the same.

##### Returns

True if `tupleA.Item1.Item1` and `tupleB.Item1.Item1` are not equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tupleA | [KeepCoding.Tuple{\`0}](#T-KeepCoding-Tuple{`0} 'KeepCoding.Tuple{`0}') | The left-hand side comparison. |
| tupleB | [KeepCoding.Tuple{\`0}](#T-KeepCoding-Tuple{`0} 'KeepCoding.Tuple{`0}') | The right-hand side comparison. |

<a name='T-KeepCoding-Tuple`2'></a>
## Tuple\`2 `type`

##### Namespace

KeepCoding

##### Summary

A basic tuple data type for C# 4. Written by Emik.

<a name='M-KeepCoding-Tuple`2-#ctor-`0,`1-'></a>
### #ctor(item1,item2) `constructor`

##### Summary

Creates a tuple of size 2.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item1 | [\`0](#T-`0 '`0') | The item to pass into the first property. |
| item2 | [\`1](#T-`1 '`1') | The item to pass into the second property. |

<a name='M-KeepCoding-Tuple`2-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a singleton tuple of default values.

##### Parameters

This constructor has no parameters.

<a name='P-KeepCoding-Tuple`2-Item-System-Byte-'></a>
### Item `property`

##### Summary

Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.

##### Returns

The item indexed into.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| i | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The index to use. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |
| [KeepCoding.WrongDatatypeException](#T-KeepCoding-WrongDatatypeException 'KeepCoding.WrongDatatypeException') |  |

<a name='P-KeepCoding-Tuple`2-Item2'></a>
### Item2 `property`

<a name='P-KeepCoding-Tuple`2-ToArray'></a>
### ToArray `property`

<a name='M-KeepCoding-Tuple`2-Destruct-`0@,`1@-'></a>
### Destruct(item1,item2) `method`

##### Summary

Destructs the tuple.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item1 | [\`0@](#T-`0@ '`0@') | The variable to assign the first element of the tuple. |
| item2 | [\`1@](#T-`1@ '`1@') | The variable to assign the second element of the tuple. |

<a name='M-KeepCoding-Tuple`2-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Determines whether the tuple is equal.

##### Returns

True if itself and the parameter are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The [Tuple\`2](#T-KeepCoding-Tuple`2 'KeepCoding.Tuple`2') as [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object'). |

<a name='M-KeepCoding-Tuple`2-Equals-KeepCoding-Tuple{`0,`1}-'></a>
### Equals(other) `method`

##### Summary

Determines whether the tuple is equal.

##### Returns

True if itself and the parameter are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [KeepCoding.Tuple{\`0,\`1}](#T-KeepCoding-Tuple{`0,`1} 'KeepCoding.Tuple{`0,`1}') | The [Tuple\`2](#T-KeepCoding-Tuple`2 'KeepCoding.Tuple`2') to compare to. |

<a name='M-KeepCoding-Tuple`2-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Gets the hash code of all items.

##### Returns

The hash code.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Tuple`2-ToString'></a>
### ToString() `method`

##### Summary

Gets all items as an array, and returns it as a string.

##### Returns

All tuples as [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Tuple`2-op_Equality-KeepCoding-Tuple{`0,`1},KeepCoding-Tuple{`0,`1}-'></a>
### op_Equality(tupleA,tupleB) `method`

##### Summary

Evaluates whether the item in the tuple is the same.

##### Returns

True if `tupleA.ToArray.ToArray` and all of `tupleB.ToArray.ToArray` are equal in sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tupleA | [KeepCoding.Tuple{\`0,\`1}](#T-KeepCoding-Tuple{`0,`1} 'KeepCoding.Tuple{`0,`1}') | The left-hand side comparison. |
| tupleB | [KeepCoding.Tuple{\`0,\`1}](#T-KeepCoding-Tuple{`0,`1} 'KeepCoding.Tuple{`0,`1}') | The right-hand side comparison. |

<a name='M-KeepCoding-Tuple`2-op_Inequality-KeepCoding-Tuple{`0,`1},KeepCoding-Tuple{`0,`1}-'></a>
### op_Inequality(tupleA,tupleB) `method`

##### Summary

Evaluates whether the item in the tuple is not the same.

##### Returns

True if `tupleA.ToArray.ToArray` and all of `tupleB.ToArray.ToArray` are not equal in sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tupleA | [KeepCoding.Tuple{\`0,\`1}](#T-KeepCoding-Tuple{`0,`1} 'KeepCoding.Tuple{`0,`1}') | The left-hand side comparison. |
| tupleB | [KeepCoding.Tuple{\`0,\`1}](#T-KeepCoding-Tuple{`0,`1} 'KeepCoding.Tuple{`0,`1}') | The right-hand side comparison. |

<a name='T-KeepCoding-Tuple`3'></a>
## Tuple\`3 `type`

##### Namespace

KeepCoding

##### Summary

A basic tuple data type for C# 4. Written by Emik.

<a name='M-KeepCoding-Tuple`3-#ctor-`0,`1,`2-'></a>
### #ctor(item1,item2,item3) `constructor`

##### Summary

Creates a tuple of size 3.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item1 | [\`0](#T-`0 '`0') | The item to pass into the first property. |
| item2 | [\`1](#T-`1 '`1') | The item to pass into the second property. |
| item3 | [\`2](#T-`2 '`2') | The item to pass into the third property. |

<a name='M-KeepCoding-Tuple`3-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a singleton tuple of default values.

##### Parameters

This constructor has no parameters.

<a name='P-KeepCoding-Tuple`3-Item-System-Byte-'></a>
### Item `property`

##### Summary

Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.

##### Returns

The item indexed into.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| i | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The index to use. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |
| [KeepCoding.WrongDatatypeException](#T-KeepCoding-WrongDatatypeException 'KeepCoding.WrongDatatypeException') |  |

<a name='P-KeepCoding-Tuple`3-Item3'></a>
### Item3 `property`

<a name='P-KeepCoding-Tuple`3-ToArray'></a>
### ToArray `property`

<a name='M-KeepCoding-Tuple`3-Destruct-`0@,`1@,`2@-'></a>
### Destruct(item1,item2,item3) `method`

##### Summary

Destructs the tuple.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item1 | [\`0@](#T-`0@ '`0@') | The variable to assign the first element of the tuple. |
| item2 | [\`1@](#T-`1@ '`1@') | The variable to assign the second element of the tuple. |
| item3 | [\`2@](#T-`2@ '`2@') | The variable to assign the third element of the tuple. |

<a name='M-KeepCoding-Tuple`3-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Determines whether the tuple is equal.

##### Returns

True if itself and the parameter are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The [Tuple\`3](#T-KeepCoding-Tuple`3 'KeepCoding.Tuple`3') as [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object'). |

<a name='M-KeepCoding-Tuple`3-Equals-KeepCoding-Tuple{`0,`1,`2}-'></a>
### Equals(other) `method`

##### Summary

Determines whether the tuple is equal.

##### Returns

True if itself and the parameter are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [KeepCoding.Tuple{\`0,\`1,\`2}](#T-KeepCoding-Tuple{`0,`1,`2} 'KeepCoding.Tuple{`0,`1,`2}') | The [Tuple\`3](#T-KeepCoding-Tuple`3 'KeepCoding.Tuple`3') to compare to. |

<a name='M-KeepCoding-Tuple`3-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Gets the hash code of all items.

##### Returns

The hash code.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Tuple`3-ToString'></a>
### ToString() `method`

##### Summary

Gets all items as an array, and returns it as a string.

##### Returns

All tuples as [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Tuple`3-op_Equality-KeepCoding-Tuple{`0,`1,`2},KeepCoding-Tuple{`0,`1,`2}-'></a>
### op_Equality(tupleA,tupleB) `method`

##### Summary

Evaluates whether the item in the tuple is the same.

##### Returns

True if `tupleA.ToArray.ToArray` and all of `tupleB.ToArray.ToArray` are equal in sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tupleA | [KeepCoding.Tuple{\`0,\`1,\`2}](#T-KeepCoding-Tuple{`0,`1,`2} 'KeepCoding.Tuple{`0,`1,`2}') | The left-hand side comparison. |
| tupleB | [KeepCoding.Tuple{\`0,\`1,\`2}](#T-KeepCoding-Tuple{`0,`1,`2} 'KeepCoding.Tuple{`0,`1,`2}') | The right-hand side comparison. |

<a name='M-KeepCoding-Tuple`3-op_Inequality-KeepCoding-Tuple{`0,`1,`2},KeepCoding-Tuple{`0,`1,`2}-'></a>
### op_Inequality(tupleA,tupleB) `method`

##### Summary

Evaluates whether the item in the tuple is not the same.

##### Returns

True if `tupleA.ToArray.ToArray` and all of `tupleB.ToArray.ToArray` are not equal in sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tupleA | [KeepCoding.Tuple{\`0,\`1,\`2}](#T-KeepCoding-Tuple{`0,`1,`2} 'KeepCoding.Tuple{`0,`1,`2}') | The left-hand side comparison. |
| tupleB | [KeepCoding.Tuple{\`0,\`1,\`2}](#T-KeepCoding-Tuple{`0,`1,`2} 'KeepCoding.Tuple{`0,`1,`2}') | The right-hand side comparison. |

<a name='T-KeepCoding-Tuple`4'></a>
## Tuple\`4 `type`

##### Namespace

KeepCoding

##### Summary

A basic tuple data type for C# 4. Written by Emik.

<a name='M-KeepCoding-Tuple`4-#ctor-`0,`1,`2,`3-'></a>
### #ctor(item1,item2,item3,item4) `constructor`

##### Summary

Creates a tuple of size 4.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item1 | [\`0](#T-`0 '`0') | The item to pass into the first property. |
| item2 | [\`1](#T-`1 '`1') | The item to pass into the second property. |
| item3 | [\`2](#T-`2 '`2') | The item to pass into the third property. |
| item4 | [\`3](#T-`3 '`3') | The item to pass into the fourth property. |

<a name='M-KeepCoding-Tuple`4-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a singleton tuple of default values.

##### Parameters

This constructor has no parameters.

<a name='P-KeepCoding-Tuple`4-Item-System-Byte-'></a>
### Item `property`

##### Summary

Indexable tuple. Be careful when using this as the compiler will not notice if you are using the wrong type.

##### Returns

The item indexed into.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| i | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The index to use. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IndexOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IndexOutOfRangeException 'System.IndexOutOfRangeException') |  |
| [KeepCoding.WrongDatatypeException](#T-KeepCoding-WrongDatatypeException 'KeepCoding.WrongDatatypeException') |  |

<a name='P-KeepCoding-Tuple`4-Item4'></a>
### Item4 `property`

<a name='P-KeepCoding-Tuple`4-ToArray'></a>
### ToArray `property`

<a name='M-KeepCoding-Tuple`4-Destruct-`0@,`1@,`2@,`3@-'></a>
### Destruct(item1,item2,item3,item4) `method`

##### Summary

Destructs the tuple.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item1 | [\`0@](#T-`0@ '`0@') | The variable to assign the first element of the tuple. |
| item2 | [\`1@](#T-`1@ '`1@') | The variable to assign the second element of the tuple. |
| item3 | [\`2@](#T-`2@ '`2@') | The variable to assign the third element of the tuple. |
| item4 | [\`3@](#T-`3@ '`3@') | The variable to assign the fourth element of the tuple. |

<a name='M-KeepCoding-Tuple`4-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Determines whether the tuple is equal.

##### Returns

True if itself and the parameter are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The [Tuple\`4](#T-KeepCoding-Tuple`4 'KeepCoding.Tuple`4') as [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object'). |

<a name='M-KeepCoding-Tuple`4-Equals-KeepCoding-Tuple{`0,`1,`2,`3}-'></a>
### Equals(other) `method`

##### Summary

Determines whether the tuple is equal.

##### Returns

True if itself and the parameter are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [KeepCoding.Tuple{\`0,\`1,\`2,\`3}](#T-KeepCoding-Tuple{`0,`1,`2,`3} 'KeepCoding.Tuple{`0,`1,`2,`3}') | The [Tuple\`4](#T-KeepCoding-Tuple`4 'KeepCoding.Tuple`4') to compare to. |

<a name='M-KeepCoding-Tuple`4-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Gets the hash code of all items.

##### Returns

The hash code.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Tuple`4-ToString'></a>
### ToString() `method`

##### Summary

Gets all items as an array, and returns it as a string.

##### Returns

All tuples as [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-Tuple`4-op_Equality-KeepCoding-Tuple{`0,`1,`2,`3},KeepCoding-Tuple{`0,`1,`2,`3}-'></a>
### op_Equality(tupleA,tupleB) `method`

##### Summary

Evaluates whether the item in the tuple is the same.

##### Returns

True if `tupleA.ToArray.ToArray` and all of `tupleB.ToArray.ToArray` are equal in sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tupleA | [KeepCoding.Tuple{\`0,\`1,\`2,\`3}](#T-KeepCoding-Tuple{`0,`1,`2,`3} 'KeepCoding.Tuple{`0,`1,`2,`3}') | The left-hand side comparison. |
| tupleB | [KeepCoding.Tuple{\`0,\`1,\`2,\`3}](#T-KeepCoding-Tuple{`0,`1,`2,`3} 'KeepCoding.Tuple{`0,`1,`2,`3}') | The right-hand side comparison. |

<a name='M-KeepCoding-Tuple`4-op_Inequality-KeepCoding-Tuple{`0,`1,`2,`3},KeepCoding-Tuple{`0,`1,`2,`3}-'></a>
### op_Inequality(tupleA,tupleB) `method`

##### Summary

Evaluates whether the item in the tuple is not the same.

##### Returns

True if `tupleA.ToArray.ToArray` and all of `tupleB.ToArray.ToArray` are not equal in sequence.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tupleA | [KeepCoding.Tuple{\`0,\`1,\`2,\`3}](#T-KeepCoding-Tuple{`0,`1,`2,`3} 'KeepCoding.Tuple{`0,`1,`2,`3}') | The left-hand side comparison. |
| tupleB | [KeepCoding.Tuple{\`0,\`1,\`2,\`3}](#T-KeepCoding-Tuple{`0,`1,`2,`3} 'KeepCoding.Tuple{`0,`1,`2,`3}') | The right-hand side comparison. |

<a name='T-KeepCoding-TypeHelper'></a>
## TypeHelper `type`

##### Namespace

KeepCoding

##### Summary

Extension methods to help you create data types easier. Written by Emik.

<a name='M-KeepCoding-TypeHelper-Add-UnityEngine-Color,System-Single,System-Single,System-Single,System-Single-'></a>
### Add(color,r,g,b,a) `method`

##### Summary

Duplicates the color, and adds the RGBA components only if they are specified.

##### Returns

A new instance of the `color`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [UnityEngine.Color](#T-UnityEngine-Color 'UnityEngine.Color') | The color to duplicate and modify. |
| r | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The red component. |
| g | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The blue component. |
| b | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The green component. |
| a | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The alpha component; opacity. |

##### Remarks

You can also use negative numbers to subtract.

<a name='M-KeepCoding-TypeHelper-Add-UnityEngine-Color,System-Byte,System-Byte,System-Byte,System-Byte-'></a>
### Add(color,r,g,b,a) `method`

##### Summary

Duplicates the color, and adds the RGBA components only if they are specified.

##### Returns

A new instance of the `color`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [UnityEngine.Color](#T-UnityEngine-Color 'UnityEngine.Color') | The [Color](#T-UnityEngine-Color 'UnityEngine.Color') to duplicate and modify. |
| r | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The red component. |
| g | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The blue component. |
| b | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The green component. |
| a | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The alpha component; opacity. |

##### Remarks

You can also use negative numbers to subtract.

<a name='M-KeepCoding-TypeHelper-Add-UnityEngine-Color32,System-Single,System-Single,System-Single,System-Single-'></a>
### Add(color,r,g,b,a) `method`

##### Summary

Duplicates the color, and adds the RGBA components only if they are specified.

##### Returns

A new instance of the `color`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [UnityEngine.Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') | The [Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') to duplicate and modify. |
| r | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The red component. |
| g | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The blue component. |
| b | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The green component. |
| a | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The alpha component; opacity. |

##### Remarks

You can also use negative numbers to subtract. As this is [Color32](#T-UnityEngine-Color32 'UnityEngine.Color32'), be careful of byte underflows/overflows.

<a name='M-KeepCoding-TypeHelper-Add-UnityEngine-Color32,System-Byte,System-Byte,System-Byte,System-Byte-'></a>
### Add(color,r,g,b,a) `method`

##### Summary

Duplicates the color, and adds the RGBA components only if they are specified.

##### Returns

A new instance of the `color`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [UnityEngine.Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') | The [Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') to duplicate and modify. |
| r | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The red component. |
| g | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The blue component. |
| b | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The green component. |
| a | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The alpha component; opacity. |

##### Remarks

You can also use negative numbers to subtract. As this is [Color32](#T-UnityEngine-Color32 'UnityEngine.Color32'), be careful of byte underflows/overflows.

<a name='M-KeepCoding-TypeHelper-Add-UnityEngine-Vector2@,System-Single,System-Single-'></a>
### Add(vector,x,y) `method`

##### Summary

Duplicates the vector, and sets the x and y components only if they are specified.

##### Returns

A new instance of `vector`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vector | [UnityEngine.Vector2@](#T-UnityEngine-Vector2@ 'UnityEngine.Vector2@') | The [Vector2](#T-UnityEngine-Vector2 'UnityEngine.Vector2') to duplicate and modify. |
| x | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The x value. |
| y | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The y value. |

<a name='M-KeepCoding-TypeHelper-Add-UnityEngine-Vector2,System-Single,System-Single-'></a>
### Add(vector,x,y) `method`

##### Summary

Takes the vector, and sets the x and y components only if they are specified.

##### Returns

A new instance of `vector`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vector | [UnityEngine.Vector2](#T-UnityEngine-Vector2 'UnityEngine.Vector2') | The [Vector2](#T-UnityEngine-Vector2 'UnityEngine.Vector2') to duplicate and modify. |
| x | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The x value. |
| y | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The y value. |

<a name='M-KeepCoding-TypeHelper-Add-UnityEngine-Vector3@,System-Single,System-Single,System-Single-'></a>
### Add(vector,x,y,z) `method`

##### Summary

Duplicates the vector, and sets the x, y, and z components only if they are specified.

##### Returns

A new instance of `vector`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vector | [UnityEngine.Vector3@](#T-UnityEngine-Vector3@ 'UnityEngine.Vector3@') | The [Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') to duplicate and modify. |
| x | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The x value. |
| y | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The y value. |
| z | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The z value. |

<a name='M-KeepCoding-TypeHelper-Add-UnityEngine-Vector3,System-Single,System-Single,System-Single-'></a>
### Add(vector,x,y,z) `method`

##### Summary

Takes the vector, and sets the x, y, and z components only if they are specified.

##### Returns

A new instance of `vector`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vector | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') | The [Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') to duplicate and modify. |
| x | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The x value. |
| y | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The y value. |
| z | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The z value. |

<a name='M-KeepCoding-TypeHelper-Add-UnityEngine-Vector4@,System-Single,System-Single,System-Single,System-Single-'></a>
### Add(vector,x,y,z,w) `method`

##### Summary

Duplicates the vector, and sets the x, y, z, and w components only if they are specified.

##### Returns

A new instance of `vector`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vector | [UnityEngine.Vector4@](#T-UnityEngine-Vector4@ 'UnityEngine.Vector4@') | The [Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') to duplicate and modify. |
| x | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The x value. |
| y | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The y value. |
| z | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The z value. |
| w | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The w value. |

<a name='M-KeepCoding-TypeHelper-Add-UnityEngine-Vector4,System-Single,System-Single,System-Single,System-Single-'></a>
### Add(vector,x,y,z,w) `method`

##### Summary

Takes the vector, and sets the x, y, z, and w components only if they are specified.

##### Returns

A new instance of `vector`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vector | [UnityEngine.Vector4](#T-UnityEngine-Vector4 'UnityEngine.Vector4') | The [Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') to duplicate and modify. |
| x | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The x value. |
| y | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The y value. |
| z | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The z value. |
| w | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The w value. |

<a name='M-KeepCoding-TypeHelper-HexToColor-System-String-'></a>
### HexToColor(hex) `method`

##### Summary

Converts a hexadecimal string into colors.

##### Returns

[Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') converted from hexadecimal string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hex | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A string of hexadecimal, which can be formatted as "FFFFFF", "#FFFFFF", or "0xFFFFFF" |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.FormatException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.FormatException 'System.FormatException') |  |

<a name='M-KeepCoding-TypeHelper-IntertwineColor-UnityEngine-Color,UnityEngine-Color,System-Single-'></a>
### IntertwineColor(colorA,colorB,concentrationOfB) `method`

##### Summary

Creates an in-between color between 2 different colors.

##### Returns

A blended color of the 2 provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| colorA | [UnityEngine.Color](#T-UnityEngine-Color 'UnityEngine.Color') | The first color, with 0 `concentrationOfB` being biased towards this color. |
| colorB | [UnityEngine.Color](#T-UnityEngine-Color 'UnityEngine.Color') | The second color, with 1 `concentrationOfB` being biased towards this color. |
| concentrationOfB | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The bias towards either color, between 0-1. 0.5 blends both colors equally. |

<a name='M-KeepCoding-TypeHelper-IntertwineColor-UnityEngine-Renderer,UnityEngine-Color,UnityEngine-Color,System-Single-'></a>
### IntertwineColor(renderer,colorA,colorB,concentrationOfB) `method`

##### Summary

Sets the [material](#P-UnityEngine-Renderer-material 'UnityEngine.Renderer.material')'s color to be a mix of 2 colors.

##### Returns

The resulting color that the `renderer` becomes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| renderer | [UnityEngine.Renderer](#T-UnityEngine-Renderer 'UnityEngine.Renderer') | The renderer to change the color of. |
| colorA | [UnityEngine.Color](#T-UnityEngine-Color 'UnityEngine.Color') | The first color, with 0 `concentrationOfB` being biased towards this color. |
| colorB | [UnityEngine.Color](#T-UnityEngine-Color 'UnityEngine.Color') | The second color, with 1 `concentrationOfB` being biased towards this color. |
| concentrationOfB | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The bias towards either color, between 0-1. 0.5 blends both colors equally. |

<a name='M-KeepCoding-TypeHelper-IntertwineColor-UnityEngine-Color32,UnityEngine-Color32,System-Single-'></a>
### IntertwineColor(colorA,colorB,concentrationOfB) `method`

##### Summary

Creates an in-between color between 2 different colors.

##### Returns

A blended color of the 2 provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| colorA | [UnityEngine.Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') | The first color, with 0 `concentrationOfB` being biased towards this color. |
| colorB | [UnityEngine.Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') | The second color, with 1 `concentrationOfB` being biased towards this color. |
| concentrationOfB | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The bias towards either color, between 0-1. 0.5 blends both colors equally. |

<a name='M-KeepCoding-TypeHelper-IntertwineColor-UnityEngine-Renderer,UnityEngine-Color32,UnityEngine-Color32,System-Single-'></a>
### IntertwineColor(renderer,colorA,colorB,concentrationOfB) `method`

##### Summary

Sets the [material](#P-UnityEngine-Renderer-material 'UnityEngine.Renderer.material')'s color to be a mix of 2 colors.

##### Returns

The resulting color that the `renderer` becomes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| renderer | [UnityEngine.Renderer](#T-UnityEngine-Renderer 'UnityEngine.Renderer') | The renderer to change the color of. |
| colorA | [UnityEngine.Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') | The first color, with 0 `concentrationOfB` being biased towards this color. |
| colorB | [UnityEngine.Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') | The second color, with 1 `concentrationOfB` being biased towards this color. |
| concentrationOfB | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The bias towards either color, between 0-1. 0.5 blends both colors equally. |

<a name='M-KeepCoding-TypeHelper-IsAnyEqual-UnityEngine-Color32[],UnityEngine-Color32-'></a>
### IsAnyEqual(colors,color) `method`

##### Summary

Checks if any elements in the array `colors` are equal to `color`.

##### Returns

Boolean, true only if any color in `colors` is the exact same as `color`'s R, G, B, and A values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| colors | [UnityEngine.Color32[]](#T-UnityEngine-Color32[] 'UnityEngine.Color32[]') | The array of colors to compare to `color`. |
| color | [UnityEngine.Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') | The color to compare it to. |

<a name='M-KeepCoding-TypeHelper-IsAnyEqual-UnityEngine-Color[],UnityEngine-Color-'></a>
### IsAnyEqual(colors,color) `method`

##### Summary

Checks if any elements in the array `colors` are equal to `color`.

##### Returns

Boolean, true only if any color in `colors` is the exact same as `color`'s R, G, B, and A values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| colors | [UnityEngine.Color[]](#T-UnityEngine-Color[] 'UnityEngine.Color[]') | The array of colors to compare to `color`. |
| color | [UnityEngine.Color](#T-UnityEngine-Color 'UnityEngine.Color') | The color to compare it to. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [KeepCoding.NullIteratorException](#T-KeepCoding-NullIteratorException 'KeepCoding.NullIteratorException') |  |

<a name='M-KeepCoding-TypeHelper-IsEqual-UnityEngine-Color32,UnityEngine-Color32-'></a>
### IsEqual(colorA,colorB) `method`

##### Summary

Checks if both colors have the same RGBA values.

##### Returns

Boolean, true only if both colors have the same R, G, B, and A values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| colorA | [UnityEngine.Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') | The first color. |
| colorB | [UnityEngine.Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') | The second color. |

<a name='M-KeepCoding-TypeHelper-IsEqual-UnityEngine-Color,UnityEngine-Color-'></a>
### IsEqual(colorA,colorB) `method`

##### Summary

Checks if both colors have the same RGBA values.

##### Returns

Boolean, true only if both colors have the same R, G, B, and A values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| colorA | [UnityEngine.Color](#T-UnityEngine-Color 'UnityEngine.Color') | The first color. |
| colorB | [UnityEngine.Color](#T-UnityEngine-Color 'UnityEngine.Color') | The second color. |

<a name='M-KeepCoding-TypeHelper-Set-UnityEngine-Color,System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single}-'></a>
### Set(color,r,g,b,a) `method`

##### Summary

Duplicates the color, and sets the RGBA components only if they are specified.

##### Returns

A new instance of the `color`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [UnityEngine.Color](#T-UnityEngine-Color 'UnityEngine.Color') | The [Color](#T-UnityEngine-Color 'UnityEngine.Color') to duplicate and modify. |
| r | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The red component. |
| g | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The blue component. |
| b | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The green component. |
| a | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The alpha component; opacity. |

<a name='M-KeepCoding-TypeHelper-Set-UnityEngine-Color,System-Nullable{System-Byte},System-Nullable{System-Byte},System-Nullable{System-Byte},System-Nullable{System-Byte}-'></a>
### Set(color,r,g,b,a) `method`

##### Summary

Duplicates the color, and sets the RGBA components only if they are specified.

##### Returns

A new instance of the `color`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [UnityEngine.Color](#T-UnityEngine-Color 'UnityEngine.Color') | The [Color](#T-UnityEngine-Color 'UnityEngine.Color') to duplicate and modify. |
| r | [System.Nullable{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Byte}') | The red component. |
| g | [System.Nullable{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Byte}') | The blue component. |
| b | [System.Nullable{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Byte}') | The green component. |
| a | [System.Nullable{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Byte}') | The alpha component; opacity. |

<a name='M-KeepCoding-TypeHelper-Set-UnityEngine-Color32,System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single}-'></a>
### Set(color,r,g,b,a) `method`

##### Summary

Duplicates the color, and sets the RGBA components only if they are specified.

##### Returns

A new instance of the `color`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [UnityEngine.Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') | The [Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') to duplicate and modify. |
| r | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The red component. |
| g | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The blue component. |
| b | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The green component. |
| a | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The alpha component; opacity. |

<a name='M-KeepCoding-TypeHelper-Set-UnityEngine-Color32,System-Nullable{System-Byte},System-Nullable{System-Byte},System-Nullable{System-Byte},System-Nullable{System-Byte}-'></a>
### Set(color,r,g,b,a) `method`

##### Summary

Duplicates the color, and sets the RGBA components only if they are specified.

##### Returns

A new instance of the `color`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [UnityEngine.Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') | The [Color32](#T-UnityEngine-Color32 'UnityEngine.Color32') to duplicate and modify. |
| r | [System.Nullable{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Byte}') | The red component. |
| g | [System.Nullable{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Byte}') | The blue component. |
| b | [System.Nullable{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Byte}') | The green component. |
| a | [System.Nullable{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Byte}') | The alpha component; opacity. |

<a name='M-KeepCoding-TypeHelper-Set-UnityEngine-Vector2@,System-Nullable{System-Single},System-Nullable{System-Single}-'></a>
### Set(vector,x,y) `method`

##### Summary

Takes the vector, and sets the x and y components only if they are specified.

##### Returns

A new instance of `vector`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vector | [UnityEngine.Vector2@](#T-UnityEngine-Vector2@ 'UnityEngine.Vector2@') | The [Vector2](#T-UnityEngine-Vector2 'UnityEngine.Vector2') to duplicate and modify. |
| x | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The x value. |
| y | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The y value. |

<a name='M-KeepCoding-TypeHelper-Set-UnityEngine-Vector2,System-Nullable{System-Single},System-Nullable{System-Single}-'></a>
### Set(vector,x,y) `method`

##### Summary

Duplicates the vector, and sets the x and y components only if they are specified.

##### Returns

A new instance of `vector`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vector | [UnityEngine.Vector2](#T-UnityEngine-Vector2 'UnityEngine.Vector2') | The [Vector2](#T-UnityEngine-Vector2 'UnityEngine.Vector2') to duplicate and modify. |
| x | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The x value. |
| y | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The y value. |

<a name='M-KeepCoding-TypeHelper-Set-UnityEngine-Vector3@,System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single}-'></a>
### Set(vector,x,y,z) `method`

##### Summary

Takes the vector, and sets the x, y, and z components only if they are specified.

##### Returns

A new instance of `vector`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vector | [UnityEngine.Vector3@](#T-UnityEngine-Vector3@ 'UnityEngine.Vector3@') | The [Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') to duplicate and modify. |
| x | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The x value. |
| y | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The y value. |
| z | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The z value. |

<a name='M-KeepCoding-TypeHelper-Set-UnityEngine-Vector3,System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single}-'></a>
### Set(vector,x,y,z) `method`

##### Summary

Duplicates the vector, and sets the x, y, and z components only if they are specified.

##### Returns

A new instance of `vector`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vector | [UnityEngine.Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') | The [Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') to duplicate and modify. |
| x | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The x value. |
| y | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The y value. |
| z | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The z value. |

<a name='M-KeepCoding-TypeHelper-Set-UnityEngine-Vector4@,System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single}-'></a>
### Set(vector,x,y,z,w) `method`

##### Summary

Takes the vector, and sets the x, y, z, and w components only if they are specified.

##### Returns

A new instance of `vector`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vector | [UnityEngine.Vector4@](#T-UnityEngine-Vector4@ 'UnityEngine.Vector4@') | The [Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') to duplicate and modify. |
| x | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The x value. |
| y | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The y value. |
| z | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The z value. |
| w | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The w value. |

<a name='M-KeepCoding-TypeHelper-Set-UnityEngine-Vector4,System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single},System-Nullable{System-Single}-'></a>
### Set(vector,x,y,z,w) `method`

##### Summary

Duplicates the vector, and sets the x, y, z, and w components only if they are specified.

##### Returns

A new instance of `vector`, with the arguments replacing the values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vector | [UnityEngine.Vector4](#T-UnityEngine-Vector4 'UnityEngine.Vector4') | The [Vector3](#T-UnityEngine-Vector3 'UnityEngine.Vector3') to duplicate and modify. |
| x | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The x value. |
| y | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The y value. |
| z | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The z value. |
| w | [System.Nullable{System.Single}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Single}') | The w value. |

<a name='M-KeepCoding-TypeHelper-ToLogger``1-``0,System-String,System-Boolean-'></a>
### ToLogger\`\`1(_,name,showId) `method`

##### Summary

Converts arguments to a new [Logger](#T-KeepCoding-Logger 'KeepCoding.Logger').

##### Returns

A new [Logger](#T-KeepCoding-Logger 'KeepCoding.Logger') containing the arguments specified.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| _ | [\`\`0](#T-``0 '``0') | The discard which is only needed for the type. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the value. |
| showId | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Determines whether to show the unique identifier when logging. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the argument, which is used as the name if `name` is `null`. |

<a name='M-KeepCoding-TypeHelper-ToRoutine-UnityEngine-MonoBehaviour,System-Func{System-Collections-IEnumerator}-'></a>
### ToRoutine(func,monoBehaviour) `method`

##### Summary

Converts arguments to a new [Routine](#T-KeepCoding-Routine 'KeepCoding.Routine').

##### Returns

A new [Routine](#T-KeepCoding-Routine 'KeepCoding.Routine') containing the arguments provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [UnityEngine.MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') | The function to call when the [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') is called. |
| monoBehaviour | [System.Func{System.Collections.IEnumerator}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Collections.IEnumerator}') | The instance of the [MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') to start the [Coroutine](#T-UnityEngine-Coroutine 'UnityEngine.Coroutine') from. |

<a name='M-KeepCoding-TypeHelper-ToRoutine``1-UnityEngine-MonoBehaviour,System-Func{``0,System-Collections-IEnumerator}-'></a>
### ToRoutine\`\`1(func,monoBehaviour) `method`

##### Summary

Converts arguments to a new [Routine\`1](#T-KeepCoding-Routine`1 'KeepCoding.Routine`1').

##### Returns

A new [Routine\`1](#T-KeepCoding-Routine`1 'KeepCoding.Routine`1') containing the arguments provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [UnityEngine.MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') | The function to call when the [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') is called. |
| monoBehaviour | [System.Func{\`\`0,System.Collections.IEnumerator}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Collections.IEnumerator}') | The instance of the [MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') to start the [Coroutine](#T-UnityEngine-Coroutine 'UnityEngine.Coroutine') from. |

<a name='M-KeepCoding-TypeHelper-ToRoutine``2-UnityEngine-MonoBehaviour,System-Func{``0,``1,System-Collections-IEnumerator}-'></a>
### ToRoutine\`\`2(func,monoBehaviour) `method`

##### Summary

Converts arguments to a new [Routine\`2](#T-KeepCoding-Routine`2 'KeepCoding.Routine`2').

##### Returns

A new [Routine\`2](#T-KeepCoding-Routine`2 'KeepCoding.Routine`2') containing the arguments provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [UnityEngine.MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') | The function to call when the [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') is called. |
| monoBehaviour | [System.Func{\`\`0,\`\`1,System.Collections.IEnumerator}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1,System.Collections.IEnumerator}') | The instance of the [MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') to start the [Coroutine](#T-UnityEngine-Coroutine 'UnityEngine.Coroutine') from. |

<a name='M-KeepCoding-TypeHelper-ToRoutine``3-UnityEngine-MonoBehaviour,System-Func{``0,``1,``2,System-Collections-IEnumerator}-'></a>
### ToRoutine\`\`3(func,monoBehaviour) `method`

##### Summary

Converts arguments to a new [Routine\`3](#T-KeepCoding-Routine`3 'KeepCoding.Routine`3').

##### Returns

A new [Routine\`3](#T-KeepCoding-Routine`3 'KeepCoding.Routine`3') containing the arguments provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [UnityEngine.MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') | The function to call when the [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') is called. |
| monoBehaviour | [System.Func{\`\`0,\`\`1,\`\`2,System.Collections.IEnumerator}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1,``2,System.Collections.IEnumerator}') | The instance of the [MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') to start the [Coroutine](#T-UnityEngine-Coroutine 'UnityEngine.Coroutine') from. |

<a name='M-KeepCoding-TypeHelper-ToRoutine``4-UnityEngine-MonoBehaviour,System-Func{``0,``1,``2,``3,System-Collections-IEnumerator}-'></a>
### ToRoutine\`\`4(func,monoBehaviour) `method`

##### Summary

Converts arguments to a new [Routine\`4](#T-KeepCoding-Routine`4 'KeepCoding.Routine`4').

##### Returns

A new [Routine\`4](#T-KeepCoding-Routine`4 'KeepCoding.Routine`4') containing the arguments provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [UnityEngine.MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') | The function to call when the [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') is called. |
| monoBehaviour | [System.Func{\`\`0,\`\`1,\`\`2,\`\`3,System.Collections.IEnumerator}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1,``2,``3,System.Collections.IEnumerator}') | The instance of the [MonoBehaviour](#T-UnityEngine-MonoBehaviour 'UnityEngine.MonoBehaviour') to start the [Coroutine](#T-UnityEngine-Coroutine 'UnityEngine.Coroutine') from. |

<a name='M-KeepCoding-TypeHelper-ToTuple``1-``0-'></a>
### ToTuple\`\`1(item) `method`

##### Summary

Converts arguments to a new [Tuple\`1](#T-KeepCoding-Tuple`1 'KeepCoding.Tuple`1').

##### Returns

A new [Tuple\`1](#T-KeepCoding-Tuple`1 'KeepCoding.Tuple`1') containing `item`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [\`\`0](#T-``0 '``0') | The argument to pass into the tuple. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of tuple. |

<a name='M-KeepCoding-TypeHelper-ToTuple``2-``0,``1-'></a>
### ToTuple\`\`2(item1,item2) `method`

##### Summary

Converts arguments to a new [Tuple\`2](#T-KeepCoding-Tuple`2 'KeepCoding.Tuple`2').

##### Returns

A new containing `item1` and `item2`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item1 | [\`\`0](#T-``0 '``0') | The first argument to pass into the tuple. |
| item2 | [\`\`1](#T-``1 '``1') | The second argument to pass into the tuple. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T1 | The first type of the tuple. |
| T2 | The second type of the tuple. |

<a name='M-KeepCoding-TypeHelper-ToTuple``3-``0,``1,``2-'></a>
### ToTuple\`\`3(item1,item2,item3) `method`

##### Summary

Converts arguments to a new [Tuple\`3](#T-KeepCoding-Tuple`3 'KeepCoding.Tuple`3').

##### Returns

A new containing `item1`, `item2`, and `item3`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item1 | [\`\`0](#T-``0 '``0') | The first argument to pass into the tuple. |
| item2 | [\`\`1](#T-``1 '``1') | The second argument to pass into the tuple. |
| item3 | [\`\`2](#T-``2 '``2') | The third argument to pass into the tuple. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T1 | The first type of the tuple. |
| T2 | The second type of the tuple. |
| T3 | The third type of the tuple. |

<a name='M-KeepCoding-TypeHelper-ToTuple``4-``0,``1,``2,``3-'></a>
### ToTuple\`\`4(item1,item2,item3,item4) `method`

##### Summary

Converts arguments to a new [Tuple\`4](#T-KeepCoding-Tuple`4 'KeepCoding.Tuple`4').

##### Returns

A new containing `item1`, `item2`, `item3`, and `item4`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item1 | [\`\`0](#T-``0 '``0') | The first argument to pass into the tuple. |
| item2 | [\`\`1](#T-``1 '``1') | The second argument to pass into the tuple. |
| item3 | [\`\`2](#T-``2 '``2') | The third argument to pass into the tuple. |
| item4 | [\`\`3](#T-``3 '``3') | The fourth argument to pass into the tuple. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T1 | The first type of the tuple. |
| T2 | The second type of the tuple. |
| T3 | The third type of the tuple. |
| T4 | The fourth type of the tuple. |

<a name='M-KeepCoding-TypeHelper-ToVersion-System-String-'></a>
### ToVersion(s) `method`

##### Summary

Converts argument to a new [Version](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Version 'System.Version'). Major-only versions are compatible.

##### Returns

A new [Version](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Version 'System.Version') representing the input `s`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to convert to a version. |

<a name='M-KeepCoding-TypeHelper-ToWork-System-UInt32,System-Action,System-Boolean-'></a>
### ToWork(action,allowSimultaneousActive,maximumThreadsActive) `method`

##### Summary

Converts argument to a new [Work](#T-KeepCoding-Work 'KeepCoding.Work')

##### Returns

A new [Work](#T-KeepCoding-Work 'KeepCoding.Work') consisting of the arguments provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The action to run when the thread is active. |
| allowSimultaneousActive | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | Whether it should allow multiple of itself to be running at once. |
| maximumThreadsActive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The amount of threads this class, and all of its overloads can run at once. |

<a name='M-KeepCoding-TypeHelper-ToWork``1-System-UInt32,System-Func{``0},System-Boolean-'></a>
### ToWork\`\`1(func,allowSimultaneousActive,maximumThreadsActive) `method`

##### Summary

Converts argument to a new [Work\`1](#T-KeepCoding-Work`1 'KeepCoding.Work`1')

##### Returns

A new [Work\`1](#T-KeepCoding-Work`1 'KeepCoding.Work`1') consisting of the arguments provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The action to run when the thread is active. |
| allowSimultaneousActive | [System.Func{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0}') | Whether it should allow multiple of itself to be running at once. |
| maximumThreadsActive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The amount of threads this class, and all of its overloads can run at once. |

<a name='M-KeepCoding-TypeHelper-ToWork``2-System-UInt32,System-Func{``0,``1},System-Boolean-'></a>
### ToWork\`\`2(func,allowSimultaneousActive,maximumThreadsActive) `method`

##### Summary

Converts argument to a new [Work\`2](#T-KeepCoding-Work`2 'KeepCoding.Work`2')

##### Returns

A new [Work\`2](#T-KeepCoding-Work`2 'KeepCoding.Work`2') consisting of the arguments provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The action to run when the thread is active. |
| allowSimultaneousActive | [System.Func{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1}') | Whether it should allow multiple of itself to be running at once. |
| maximumThreadsActive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The amount of threads this class, and all of its overloads can run at once. |

<a name='M-KeepCoding-TypeHelper-ToWork``3-System-UInt32,System-Func{``0,``1,``2},System-Boolean-'></a>
### ToWork\`\`3(func,allowSimultaneousActive,maximumThreadsActive) `method`

##### Summary

Converts argument to a new [Work\`3](#T-KeepCoding-Work`3 'KeepCoding.Work`3')

##### Returns

A new [Work\`3](#T-KeepCoding-Work`3 'KeepCoding.Work`3') consisting of the arguments provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The action to run when the thread is active. |
| allowSimultaneousActive | [System.Func{\`\`0,\`\`1,\`\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1,``2}') | Whether it should allow multiple of itself to be running at once. |
| maximumThreadsActive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The amount of threads this class, and all of its overloads can run at once. |

<a name='M-KeepCoding-TypeHelper-ToWork``4-System-UInt32,System-Func{``0,``1,``2,``3},System-Boolean-'></a>
### ToWork\`\`4(func,allowSimultaneousActive,maximumThreadsActive) `method`

##### Summary

Converts argument to a new [Work\`4](#T-KeepCoding-Work`4 'KeepCoding.Work`4')

##### Returns

A new [Work\`4](#T-KeepCoding-Work`4 'KeepCoding.Work`4') consisting of the arguments provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The action to run when the thread is active. |
| allowSimultaneousActive | [System.Func{\`\`0,\`\`1,\`\`2,\`\`3}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1,``2,``3}') | Whether it should allow multiple of itself to be running at once. |
| maximumThreadsActive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The amount of threads this class, and all of its overloads can run at once. |

<a name='M-KeepCoding-TypeHelper-ToWork``5-System-UInt32,System-Func{``0,``1,``2,``3,``4},System-Boolean-'></a>
### ToWork\`\`5(func,allowSimultaneousActive,maximumThreadsActive) `method`

##### Summary

Converts argument to a new [Work\`5](#T-KeepCoding-Work`5 'KeepCoding.Work`5')

##### Returns

A new [Work\`5](#T-KeepCoding-Work`5 'KeepCoding.Work`5') consisting of the arguments provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The action to run when the thread is active. |
| allowSimultaneousActive | [System.Func{\`\`0,\`\`1,\`\`2,\`\`3,\`\`4}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,``1,``2,``3,``4}') | Whether it should allow multiple of itself to be running at once. |
| maximumThreadsActive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The amount of threads this class, and all of its overloads can run at once. |

<a name='T-KeepCoding-UnrecognizedTypeException'></a>
## UnrecognizedTypeException `type`

##### Namespace

KeepCoding

##### Summary

An exception thrown for when the type isn't handled. Written by Emik.

<a name='M-KeepCoding-UnrecognizedTypeException-#ctor'></a>
### #ctor() `constructor`

##### Summary

An exception thrown for when the type isn't handled.

##### Parameters

This constructor has no parameters.

<a name='M-KeepCoding-UnrecognizedTypeException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

An exception thrown for when the type isn't handled.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |

<a name='M-KeepCoding-UnrecognizedTypeException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

An exception thrown for when the type isn't handled.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | An [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') within this exception. |

<a name='T-KeepCoding-UnrecognizedValueException'></a>
## UnrecognizedValueException `type`

##### Namespace

KeepCoding

##### Summary

An exception thrown for when the value isn't handled. Written by Emik.

<a name='M-KeepCoding-UnrecognizedValueException-#ctor'></a>
### #ctor() `constructor`

##### Summary

An exception thrown for when the type isn't handled.

##### Parameters

This constructor has no parameters.

<a name='M-KeepCoding-UnrecognizedValueException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

An exception thrown for when the value isn't handled.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |

<a name='M-KeepCoding-UnrecognizedValueException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

An exception thrown for when the value isn't handled.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | An [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') within this exception. |

<a name='T-KeepCoding-Work'></a>
## Work `type`

##### Namespace

KeepCoding

##### Summary

Advanced multi-threading handler. Written by Emik.

<a name='M-KeepCoding-Work-#ctor-System-Action,System-Boolean,System-UInt32-'></a>
### #ctor(work,allowSimultaneousActive,maximumThreadsActive) `constructor`

##### Summary

Stores the method so that it can later be called when a new thread starts.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| work | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The method to call when thread starts. |
| allowSimultaneousActive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should allow multiple of itself to be running at once. |
| maximumThreadsActive | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The amount of threads this class, and all of its overloads can run at once. |

<a name='M-KeepCoding-Work-Start'></a>
### Start() `method`

##### Summary

Starts a new thread, and waits until it is finished before halting.

##### Returns

[WaitWhile](#T-UnityEngine-WaitWhile 'UnityEngine.WaitWhile') in various places until the thread has been finished.

##### Parameters

This method has no parameters.

<a name='T-KeepCoding-WorkBase'></a>
## WorkBase `type`

##### Namespace

KeepCoding

##### Summary

Abstract class for the [Work](#T-KeepCoding-Work 'KeepCoding.Work') datatype, since the different overloads are similar to each other. Written by Emik.

<a name='P-KeepCoding-WorkBase-AllowSimultaneousActive'></a>
### AllowSimultaneousActive `property`

<a name='P-KeepCoding-WorkBase-IsRunning'></a>
### IsRunning `property`

<a name='P-KeepCoding-WorkBase-Thread'></a>
### Thread `property`

<a name='P-KeepCoding-WorkBase-ThreadsActive'></a>
### ThreadsActive `property`

<a name='M-KeepCoding-WorkBase-Stop'></a>
### Stop() `method`

##### Summary

Interrupts the thread.

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-WorkBase-WaitForOtherThreads'></a>
### WaitForOtherThreads() `method`

##### Summary

Waits until it is allowed to run a thread.

##### Returns

[WaitWhile](#T-UnityEngine-WaitWhile 'UnityEngine.WaitWhile') until [ThreadsActive](#P-KeepCoding-WorkBase-ThreadsActive 'KeepCoding.WorkBase.ThreadsActive') is strictly less than [_maximumThreadsActive](#F-KeepCoding-WorkBase-_maximumThreadsActive 'KeepCoding.WorkBase._maximumThreadsActive').

##### Parameters

This method has no parameters.

<a name='M-KeepCoding-WorkBase-WaitForOwnThread'></a>
### WaitForOwnThread() `method`

##### Summary

Waits until its own thread is no longer running..

##### Returns

[WaitWhile](#T-UnityEngine-WaitWhile 'UnityEngine.WaitWhile') until [IsRunning](#P-KeepCoding-WorkBase-IsRunning 'KeepCoding.WorkBase.IsRunning') is no longer true.

##### Parameters

This method has no parameters.

<a name='T-KeepCoding-Work`1'></a>
## Work\`1 `type`

##### Namespace

KeepCoding

##### Summary

Advanced multi-threading handler. Written by Emik.

<a name='M-KeepCoding-Work`1-#ctor-System-Func{`0},System-Boolean,System-UInt32-'></a>
### #ctor(work,allowSimultaneousActive,maximumThreadsActive) `constructor`

##### Summary

Stores the method so that it can later be called when a new thread starts.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| work | [System.Func{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0}') | The method to call when thread starts. |
| allowSimultaneousActive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should allow multiple of itself to be running at once. |
| maximumThreadsActive | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The amount of threads this class, and all of its overloads can run at once. |

<a name='P-KeepCoding-Work`1-Result'></a>
### Result `property`

<a name='M-KeepCoding-Work`1-Start'></a>
### Start() `method`

##### Summary

Starts a new thread, and waits until it is finished before halting.

##### Returns

[WaitWhile](#T-UnityEngine-WaitWhile 'UnityEngine.WaitWhile') in various places until the thread has been finished.

##### Parameters

This method has no parameters.

<a name='T-KeepCoding-Work`2'></a>
## Work\`2 `type`

##### Namespace

KeepCoding

##### Summary

Advanced multi-threading handler. Written by Emik.

<a name='M-KeepCoding-Work`2-#ctor-System-Func{`0,`1},System-Boolean,System-UInt32-'></a>
### #ctor(work,allowSimultaneousActive,maximumThreadsActive) `constructor`

##### Summary

Stores the method so that it can later be called when a new thread starts.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| work | [System.Func{\`0,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1}') | The method to call when thread starts. |
| allowSimultaneousActive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should allow multiple of itself to be running at once. |
| maximumThreadsActive | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The amount of threads this class, and all of its overloads can run at once. |

<a name='P-KeepCoding-Work`2-Result'></a>
### Result `property`

<a name='M-KeepCoding-Work`2-Start-`0-'></a>
### Start() `method`

##### Summary

Starts a new thread, and waits until it is finished before halting.

##### Returns

[WaitWhile](#T-UnityEngine-WaitWhile 'UnityEngine.WaitWhile') in various places until the thread has been finished.

##### Parameters

This method has no parameters.

<a name='T-KeepCoding-Work`3'></a>
## Work\`3 `type`

##### Namespace

KeepCoding

##### Summary

Advanced multi-threading handler. Written by Emik.

<a name='M-KeepCoding-Work`3-#ctor-System-Func{`0,`1,`2},System-Boolean,System-UInt32-'></a>
### #ctor(work,allowSimultaneousActive,maximumThreadsActive) `constructor`

##### Summary

Stores the method so that it can later be called when a new thread starts.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| work | [System.Func{\`0,\`1,\`2}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,`2}') | The method to call when thread starts. |
| allowSimultaneousActive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should allow multiple of itself to be running at once. |
| maximumThreadsActive | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The amount of threads this class, and all of its overloads can run at once. |

<a name='P-KeepCoding-Work`3-Result'></a>
### Result `property`

<a name='M-KeepCoding-Work`3-Start-`0,`1-'></a>
### Start() `method`

##### Summary

Starts a new thread, and waits until it is finished before halting.

##### Returns

[WaitWhile](#T-UnityEngine-WaitWhile 'UnityEngine.WaitWhile') in various places until the thread has been finished.

##### Parameters

This method has no parameters.

<a name='T-KeepCoding-Work`4'></a>
## Work\`4 `type`

##### Namespace

KeepCoding

##### Summary

Advanced multi-threading handler. Written by Emik.

<a name='M-KeepCoding-Work`4-#ctor-System-Func{`0,`1,`2,`3},System-Boolean,System-UInt32-'></a>
### #ctor(work,allowSimultaneousActive,maximumThreadsActive) `constructor`

##### Summary

Stores the method so that it can later be called when a new thread starts.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| work | [System.Func{\`0,\`1,\`2,\`3}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,`2,`3}') | The method to call when thread starts. |
| allowSimultaneousActive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should allow multiple of itself to be running at once. |
| maximumThreadsActive | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The amount of threads this class, and all of its overloads can run at once. |

<a name='P-KeepCoding-Work`4-Result'></a>
### Result `property`

<a name='M-KeepCoding-Work`4-Start-`0,`1,`2-'></a>
### Start() `method`

##### Summary

Starts a new thread, and waits until it is finished before halting.

##### Returns

[WaitWhile](#T-UnityEngine-WaitWhile 'UnityEngine.WaitWhile') in various places until the thread has been finished.

##### Parameters

This method has no parameters.

<a name='T-KeepCoding-Work`5'></a>
## Work\`5 `type`

##### Namespace

KeepCoding

##### Summary

Advanced multi-threading handler. Written by Emik.

<a name='M-KeepCoding-Work`5-#ctor-System-Func{`0,`1,`2,`3,`4},System-Boolean,System-UInt32-'></a>
### #ctor(work,allowSimultaneousActive,maximumThreadsActive) `constructor`

##### Summary

Stores the method so that it can later be called when a new thread starts.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| work | [System.Func{\`0,\`1,\`2,\`3,\`4}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,`1,`2,`3,`4}') | The method to call when thread starts. |
| allowSimultaneousActive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether it should allow multiple of itself to be running at once. |
| maximumThreadsActive | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The amount of threads this class, and all of its overloads can run at once. |

<a name='P-KeepCoding-Work`5-Result'></a>
### Result `property`

<a name='M-KeepCoding-Work`5-Start-`0,`1,`2,`3-'></a>
### Start() `method`

##### Summary

Starts a new thread, and waits until it is finished before halting.

##### Returns

[WaitWhile](#T-UnityEngine-WaitWhile 'UnityEngine.WaitWhile') in various places until the thread has been finished.

##### Parameters

This method has no parameters.

<a name='T-KeepCoding-WrongDatatypeException'></a>
## WrongDatatypeException `type`

##### Namespace

KeepCoding

##### Summary

An exception thrown for when the wrong datatype is used. Written by Emik.

<a name='M-KeepCoding-WrongDatatypeException-#ctor'></a>
### #ctor() `constructor`

##### Summary

An exception thrown for when the wrong datatype is used.

##### Parameters

This constructor has no parameters.

<a name='M-KeepCoding-WrongDatatypeException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

An exception thrown for when the wrong datatype is used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |

<a name='M-KeepCoding-WrongDatatypeException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

An exception thrown for when the wrong datatype is used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message of the exception. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | An [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') within this exception. |
