# <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge"></a> Class CMsgDOTAPassportPlayerCardChallenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPassportPlayerCardChallenge : IMessage<CMsgDOTAPassportPlayerCardChallenge>, IEquatable<CMsgDOTAPassportPlayerCardChallenge>, IDeepCloneable<CMsgDOTAPassportPlayerCardChallenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPassportPlayerCardChallenge](Divine.Protobufs.Dota2.CMsgDOTAPassportPlayerCardChallenge.md)

#### Implements

IMessage<CMsgDOTAPassportPlayerCardChallenge\>, 
[IEquatable<CMsgDOTAPassportPlayerCardChallenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPassportPlayerCardChallenge\>, 
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
[EnumerableExtensions.In<CMsgDOTAPassportPlayerCardChallenge\>\(CMsgDOTAPassportPlayerCardChallenge, params CMsgDOTAPassportPlayerCardChallenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge__ctor"></a> CMsgDOTAPassportPlayerCardChallenge\(\)

```csharp
public CMsgDOTAPassportPlayerCardChallenge()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge__ctor_Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_"></a> CMsgDOTAPassportPlayerCardChallenge\(CMsgDOTAPassportPlayerCardChallenge\)

```csharp
public CMsgDOTAPassportPlayerCardChallenge(CMsgDOTAPassportPlayerCardChallenge other)
```

#### Parameters

`other` [CMsgDOTAPassportPlayerCardChallenge](Divine.Protobufs.Dota2.CMsgDOTAPassportPlayerCardChallenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_ChallengeIdFieldNumber"></a> ChallengeIdFieldNumber

```csharp
public const int ChallengeIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_ChallengeId"></a> ChallengeId

```csharp
public uint ChallengeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_HasChallengeId"></a> HasChallengeId

```csharp
public bool HasChallengeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPassportPlayerCardChallenge> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPassportPlayerCardChallenge](Divine.Protobufs.Dota2.CMsgDOTAPassportPlayerCardChallenge.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_ClearChallengeId"></a> ClearChallengeId\(\)

```csharp
public void ClearChallengeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPassportPlayerCardChallenge Clone()
```

#### Returns

 [CMsgDOTAPassportPlayerCardChallenge](Divine.Protobufs.Dota2.CMsgDOTAPassportPlayerCardChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_Equals_Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_"></a> Equals\(CMsgDOTAPassportPlayerCardChallenge\)

```csharp
public bool Equals(CMsgDOTAPassportPlayerCardChallenge other)
```

#### Parameters

`other` [CMsgDOTAPassportPlayerCardChallenge](Divine.Protobufs.Dota2.CMsgDOTAPassportPlayerCardChallenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_"></a> MergeFrom\(CMsgDOTAPassportPlayerCardChallenge\)

```csharp
public void MergeFrom(CMsgDOTAPassportPlayerCardChallenge other)
```

#### Parameters

`other` [CMsgDOTAPassportPlayerCardChallenge](Divine.Protobufs.Dota2.CMsgDOTAPassportPlayerCardChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPassportPlayerCardChallenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

