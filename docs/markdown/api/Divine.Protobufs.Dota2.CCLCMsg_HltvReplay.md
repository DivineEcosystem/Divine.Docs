# <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay"></a> Class CCLCMsg\_HltvReplay

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CCLCMsg_HltvReplay : IMessage<CCLCMsg_HltvReplay>, IEquatable<CCLCMsg_HltvReplay>, IDeepCloneable<CCLCMsg_HltvReplay>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CCLCMsg\_HltvReplay](Divine.Protobufs.Dota2.CCLCMsg\_HltvReplay.md)

#### Implements

IMessage<CCLCMsg\_HltvReplay\>, 
[IEquatable<CCLCMsg\_HltvReplay\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CCLCMsg\_HltvReplay\>, 
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
[EnumerableExtensions.In<CCLCMsg\_HltvReplay\>\(CCLCMsg\_HltvReplay, params CCLCMsg\_HltvReplay\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay__ctor"></a> CCLCMsg\_HltvReplay\(\)

```csharp
public CCLCMsg_HltvReplay()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay__ctor_Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_"></a> CCLCMsg\_HltvReplay\(CCLCMsg\_HltvReplay\)

```csharp
public CCLCMsg_HltvReplay(CCLCMsg_HltvReplay other)
```

#### Parameters

`other` [CCLCMsg\_HltvReplay](Divine.Protobufs.Dota2.CCLCMsg\_HltvReplay.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_EventTimeFieldNumber"></a> EventTimeFieldNumber

```csharp
public const int EventTimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_PrimaryTargetFieldNumber"></a> PrimaryTargetFieldNumber

```csharp
public const int PrimaryTargetFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_RequestFieldNumber"></a> RequestFieldNumber

```csharp
public const int RequestFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_SlowdownLengthFieldNumber"></a> SlowdownLengthFieldNumber

```csharp
public const int SlowdownLengthFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_SlowdownRateFieldNumber"></a> SlowdownRateFieldNumber

```csharp
public const int SlowdownRateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_EventTime"></a> EventTime

```csharp
public float EventTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_HasEventTime"></a> HasEventTime

```csharp
public bool HasEventTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_HasPrimaryTarget"></a> HasPrimaryTarget

```csharp
public bool HasPrimaryTarget { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_HasRequest"></a> HasRequest

```csharp
public bool HasRequest { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_HasSlowdownLength"></a> HasSlowdownLength

```csharp
public bool HasSlowdownLength { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_HasSlowdownRate"></a> HasSlowdownRate

```csharp
public bool HasSlowdownRate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_Parser"></a> Parser

```csharp
public static MessageParser<CCLCMsg_HltvReplay> Parser { get; }
```

#### Property Value

 MessageParser<[CCLCMsg\_HltvReplay](Divine.Protobufs.Dota2.CCLCMsg\_HltvReplay.md)\>

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_PrimaryTarget"></a> PrimaryTarget

```csharp
public int PrimaryTarget { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_Request"></a> Request

```csharp
public int Request { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_SlowdownLength"></a> SlowdownLength

```csharp
public float SlowdownLength { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_SlowdownRate"></a> SlowdownRate

```csharp
public float SlowdownRate { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_ClearEventTime"></a> ClearEventTime\(\)

```csharp
public void ClearEventTime()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_ClearPrimaryTarget"></a> ClearPrimaryTarget\(\)

```csharp
public void ClearPrimaryTarget()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_ClearRequest"></a> ClearRequest\(\)

```csharp
public void ClearRequest()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_ClearSlowdownLength"></a> ClearSlowdownLength\(\)

```csharp
public void ClearSlowdownLength()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_ClearSlowdownRate"></a> ClearSlowdownRate\(\)

```csharp
public void ClearSlowdownRate()
```

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_Clone"></a> Clone\(\)

```csharp
public CCLCMsg_HltvReplay Clone()
```

#### Returns

 [CCLCMsg\_HltvReplay](Divine.Protobufs.Dota2.CCLCMsg\_HltvReplay.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_Equals_Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_"></a> Equals\(CCLCMsg\_HltvReplay\)

```csharp
public bool Equals(CCLCMsg_HltvReplay other)
```

#### Parameters

`other` [CCLCMsg\_HltvReplay](Divine.Protobufs.Dota2.CCLCMsg\_HltvReplay.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_MergeFrom_Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_"></a> MergeFrom\(CCLCMsg\_HltvReplay\)

```csharp
public void MergeFrom(CCLCMsg_HltvReplay other)
```

#### Parameters

`other` [CCLCMsg\_HltvReplay](Divine.Protobufs.Dota2.CCLCMsg\_HltvReplay.md)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CCLCMsg_HltvReplay_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

