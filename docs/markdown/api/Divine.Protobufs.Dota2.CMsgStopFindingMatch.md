# <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch"></a> Class CMsgStopFindingMatch

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgStopFindingMatch : IMessage<CMsgStopFindingMatch>, IEquatable<CMsgStopFindingMatch>, IDeepCloneable<CMsgStopFindingMatch>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgStopFindingMatch](Divine.Protobufs.Dota2.CMsgStopFindingMatch.md)

#### Implements

IMessage<CMsgStopFindingMatch\>, 
[IEquatable<CMsgStopFindingMatch\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgStopFindingMatch\>, 
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
[EnumerableExtensions.In<CMsgStopFindingMatch\>\(CMsgStopFindingMatch, params CMsgStopFindingMatch\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch__ctor"></a> CMsgStopFindingMatch\(\)

```csharp
public CMsgStopFindingMatch()
```

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch__ctor_Divine_Protobufs_Dota2_CMsgStopFindingMatch_"></a> CMsgStopFindingMatch\(CMsgStopFindingMatch\)

```csharp
public CMsgStopFindingMatch(CMsgStopFindingMatch other)
```

#### Parameters

`other` [CMsgStopFindingMatch](Divine.Protobufs.Dota2.CMsgStopFindingMatch.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_AcceptCooldownFieldNumber"></a> AcceptCooldownFieldNumber

```csharp
public const int AcceptCooldownFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_AcceptCooldown"></a> AcceptCooldown

```csharp
public bool AcceptCooldown { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_HasAcceptCooldown"></a> HasAcceptCooldown

```csharp
public bool HasAcceptCooldown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_Parser"></a> Parser

```csharp
public static MessageParser<CMsgStopFindingMatch> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgStopFindingMatch](Divine.Protobufs.Dota2.CMsgStopFindingMatch.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_ClearAcceptCooldown"></a> ClearAcceptCooldown\(\)

```csharp
public void ClearAcceptCooldown()
```

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_Clone"></a> Clone\(\)

```csharp
public CMsgStopFindingMatch Clone()
```

#### Returns

 [CMsgStopFindingMatch](Divine.Protobufs.Dota2.CMsgStopFindingMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_Equals_Divine_Protobufs_Dota2_CMsgStopFindingMatch_"></a> Equals\(CMsgStopFindingMatch\)

```csharp
public bool Equals(CMsgStopFindingMatch other)
```

#### Parameters

`other` [CMsgStopFindingMatch](Divine.Protobufs.Dota2.CMsgStopFindingMatch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_MergeFrom_Divine_Protobufs_Dota2_CMsgStopFindingMatch_"></a> MergeFrom\(CMsgStopFindingMatch\)

```csharp
public void MergeFrom(CMsgStopFindingMatch other)
```

#### Parameters

`other` [CMsgStopFindingMatch](Divine.Protobufs.Dota2.CMsgStopFindingMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgStopFindingMatch_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

