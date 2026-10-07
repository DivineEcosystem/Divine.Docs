# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge"></a> Class CDOTAClientMsg\_BeginLastHitChallenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_BeginLastHitChallenge : IMessage<CDOTAClientMsg_BeginLastHitChallenge>, IEquatable<CDOTAClientMsg_BeginLastHitChallenge>, IDeepCloneable<CDOTAClientMsg_BeginLastHitChallenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_BeginLastHitChallenge](Divine.Protobufs.Dota2.CDOTAClientMsg\_BeginLastHitChallenge.md)

#### Implements

IMessage<CDOTAClientMsg\_BeginLastHitChallenge\>, 
[IEquatable<CDOTAClientMsg\_BeginLastHitChallenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_BeginLastHitChallenge\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_BeginLastHitChallenge\>\(CDOTAClientMsg\_BeginLastHitChallenge, params CDOTAClientMsg\_BeginLastHitChallenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge__ctor"></a> CDOTAClientMsg\_BeginLastHitChallenge\(\)

```csharp
public CDOTAClientMsg_BeginLastHitChallenge()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_"></a> CDOTAClientMsg\_BeginLastHitChallenge\(CDOTAClientMsg\_BeginLastHitChallenge\)

```csharp
public CDOTAClientMsg_BeginLastHitChallenge(CDOTAClientMsg_BeginLastHitChallenge other)
```

#### Parameters

`other` [CDOTAClientMsg\_BeginLastHitChallenge](Divine.Protobufs.Dota2.CDOTAClientMsg\_BeginLastHitChallenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_ChosenLaneFieldNumber"></a> ChosenLaneFieldNumber

```csharp
public const int ChosenLaneFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_HelperEnabledFieldNumber"></a> HelperEnabledFieldNumber

```csharp
public const int HelperEnabledFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_ChosenLane"></a> ChosenLane

```csharp
public uint ChosenLane { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_HasChosenLane"></a> HasChosenLane

```csharp
public bool HasChosenLane { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_HasHelperEnabled"></a> HasHelperEnabled

```csharp
public bool HasHelperEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_HelperEnabled"></a> HelperEnabled

```csharp
public bool HelperEnabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_BeginLastHitChallenge> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_BeginLastHitChallenge](Divine.Protobufs.Dota2.CDOTAClientMsg\_BeginLastHitChallenge.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_ClearChosenLane"></a> ClearChosenLane\(\)

```csharp
public void ClearChosenLane()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_ClearHelperEnabled"></a> ClearHelperEnabled\(\)

```csharp
public void ClearHelperEnabled()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_BeginLastHitChallenge Clone()
```

#### Returns

 [CDOTAClientMsg\_BeginLastHitChallenge](Divine.Protobufs.Dota2.CDOTAClientMsg\_BeginLastHitChallenge.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_"></a> Equals\(CDOTAClientMsg\_BeginLastHitChallenge\)

```csharp
public bool Equals(CDOTAClientMsg_BeginLastHitChallenge other)
```

#### Parameters

`other` [CDOTAClientMsg\_BeginLastHitChallenge](Divine.Protobufs.Dota2.CDOTAClientMsg\_BeginLastHitChallenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_"></a> MergeFrom\(CDOTAClientMsg\_BeginLastHitChallenge\)

```csharp
public void MergeFrom(CDOTAClientMsg_BeginLastHitChallenge other)
```

#### Parameters

`other` [CDOTAClientMsg\_BeginLastHitChallenge](Divine.Protobufs.Dota2.CDOTAClientMsg\_BeginLastHitChallenge.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BeginLastHitChallenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

