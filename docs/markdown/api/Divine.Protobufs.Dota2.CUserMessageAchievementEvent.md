# <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent"></a> Class CUserMessageAchievementEvent

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageAchievementEvent : IMessage<CUserMessageAchievementEvent>, IEquatable<CUserMessageAchievementEvent>, IDeepCloneable<CUserMessageAchievementEvent>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageAchievementEvent](Divine.Protobufs.Dota2.CUserMessageAchievementEvent.md)

#### Implements

IMessage<CUserMessageAchievementEvent\>, 
[IEquatable<CUserMessageAchievementEvent\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageAchievementEvent\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CUserMessageAchievementEvent\>\(CUserMessageAchievementEvent, params CUserMessageAchievementEvent\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent__ctor"></a> CUserMessageAchievementEvent\(\)

```csharp
public CUserMessageAchievementEvent()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent__ctor_Divine_Protobufs_Dota2_CUserMessageAchievementEvent_"></a> CUserMessageAchievementEvent\(CUserMessageAchievementEvent\)

```csharp
public CUserMessageAchievementEvent(CUserMessageAchievementEvent other)
```

#### Parameters

`other` [CUserMessageAchievementEvent](Divine.Protobufs.Dota2.CUserMessageAchievementEvent.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_AchievementFieldNumber"></a> AchievementFieldNumber

```csharp
public const int AchievementFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_CountFieldNumber"></a> CountFieldNumber

```csharp
public const int CountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_Achievement"></a> Achievement

```csharp
public uint Achievement { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_Count"></a> Count

```csharp
public int Count { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_HasAchievement"></a> HasAchievement

```csharp
public bool HasAchievement { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_HasCount"></a> HasCount

```csharp
public bool HasCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageAchievementEvent> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageAchievementEvent](Divine.Protobufs.Dota2.CUserMessageAchievementEvent.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_ClearAchievement"></a> ClearAchievement\(\)

```csharp
public void ClearAchievement()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_ClearCount"></a> ClearCount\(\)

```csharp
public void ClearCount()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_Clone"></a> Clone\(\)

```csharp
public CUserMessageAchievementEvent Clone()
```

#### Returns

 [CUserMessageAchievementEvent](Divine.Protobufs.Dota2.CUserMessageAchievementEvent.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_Equals_Divine_Protobufs_Dota2_CUserMessageAchievementEvent_"></a> Equals\(CUserMessageAchievementEvent\)

```csharp
public bool Equals(CUserMessageAchievementEvent other)
```

#### Parameters

`other` [CUserMessageAchievementEvent](Divine.Protobufs.Dota2.CUserMessageAchievementEvent.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_MergeFrom_Divine_Protobufs_Dota2_CUserMessageAchievementEvent_"></a> MergeFrom\(CUserMessageAchievementEvent\)

```csharp
public void MergeFrom(CUserMessageAchievementEvent other)
```

#### Parameters

`other` [CUserMessageAchievementEvent](Divine.Protobufs.Dota2.CUserMessageAchievementEvent.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageAchievementEvent_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

