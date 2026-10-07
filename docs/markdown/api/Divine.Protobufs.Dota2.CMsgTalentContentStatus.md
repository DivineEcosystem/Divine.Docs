# <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus"></a> Class CMsgTalentContentStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTalentContentStatus : IMessage<CMsgTalentContentStatus>, IEquatable<CMsgTalentContentStatus>, IDeepCloneable<CMsgTalentContentStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTalentContentStatus](Divine.Protobufs.Dota2.CMsgTalentContentStatus.md)

#### Implements

IMessage<CMsgTalentContentStatus\>, 
[IEquatable<CMsgTalentContentStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTalentContentStatus\>, 
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
[EnumerableExtensions.In<CMsgTalentContentStatus\>\(CMsgTalentContentStatus, params CMsgTalentContentStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus__ctor"></a> CMsgTalentContentStatus\(\)

```csharp
public CMsgTalentContentStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus__ctor_Divine_Protobufs_Dota2_CMsgTalentContentStatus_"></a> CMsgTalentContentStatus\(CMsgTalentContentStatus\)

```csharp
public CMsgTalentContentStatus(CMsgTalentContentStatus other)
```

#### Parameters

`other` [CMsgTalentContentStatus](Divine.Protobufs.Dota2.CMsgTalentContentStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_TalentStatusFieldNumber"></a> TalentStatusFieldNumber

```csharp
public const int TalentStatusFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTalentContentStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTalentContentStatus](Divine.Protobufs.Dota2.CMsgTalentContentStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_TalentStatus"></a> TalentStatus

```csharp
public RepeatedField<CMsgTalentContentStatus.Types.TalentDetails> TalentStatus { get; }
```

#### Property Value

 RepeatedField<[CMsgTalentContentStatus](Divine.Protobufs.Dota2.CMsgTalentContentStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTalentContentStatus.Types.md).[TalentDetails](Divine.Protobufs.Dota2.CMsgTalentContentStatus.Types.TalentDetails.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Clone"></a> Clone\(\)

```csharp
public CMsgTalentContentStatus Clone()
```

#### Returns

 [CMsgTalentContentStatus](Divine.Protobufs.Dota2.CMsgTalentContentStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_Equals_Divine_Protobufs_Dota2_CMsgTalentContentStatus_"></a> Equals\(CMsgTalentContentStatus\)

```csharp
public bool Equals(CMsgTalentContentStatus other)
```

#### Parameters

`other` [CMsgTalentContentStatus](Divine.Protobufs.Dota2.CMsgTalentContentStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgTalentContentStatus_"></a> MergeFrom\(CMsgTalentContentStatus\)

```csharp
public void MergeFrom(CMsgTalentContentStatus other)
```

#### Parameters

`other` [CMsgTalentContentStatus](Divine.Protobufs.Dota2.CMsgTalentContentStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTalentContentStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

