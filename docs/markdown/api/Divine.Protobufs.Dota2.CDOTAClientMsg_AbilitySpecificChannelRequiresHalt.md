# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt"></a> Class CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_AbilitySpecificChannelRequiresHalt : IMessage<CDOTAClientMsg_AbilitySpecificChannelRequiresHalt>, IEquatable<CDOTAClientMsg_AbilitySpecificChannelRequiresHalt>, IDeepCloneable<CDOTAClientMsg_AbilitySpecificChannelRequiresHalt>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt.md)

#### Implements

IMessage<CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt\>, 
[IEquatable<CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt\>\(CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt, params CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt__ctor"></a> CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt\(\)

```csharp
public CDOTAClientMsg_AbilitySpecificChannelRequiresHalt()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_"></a> CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt\(CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt\)

```csharp
public CDOTAClientMsg_AbilitySpecificChannelRequiresHalt(CDOTAClientMsg_AbilitySpecificChannelRequiresHalt other)
```

#### Parameters

`other` [CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_DefaultFieldNumber"></a> DefaultFieldNumber

```csharp
public const int DefaultFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_EnabledFieldNumber"></a> EnabledFieldNumber

```csharp
public const int EnabledFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_Default"></a> Default

```csharp
public bool Default { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_Enabled"></a> Enabled

```csharp
public bool Enabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_HasDefault"></a> HasDefault

```csharp
public bool HasDefault { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_HasEnabled"></a> HasEnabled

```csharp
public bool HasEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_AbilitySpecificChannelRequiresHalt> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_ClearDefault"></a> ClearDefault\(\)

```csharp
public void ClearDefault()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_ClearEnabled"></a> ClearEnabled\(\)

```csharp
public void ClearEnabled()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_AbilitySpecificChannelRequiresHalt Clone()
```

#### Returns

 [CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_"></a> Equals\(CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt\)

```csharp
public bool Equals(CDOTAClientMsg_AbilitySpecificChannelRequiresHalt other)
```

#### Parameters

`other` [CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_"></a> MergeFrom\(CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt\)

```csharp
public void MergeFrom(CDOTAClientMsg_AbilitySpecificChannelRequiresHalt other)
```

#### Parameters

`other` [CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_AbilitySpecificChannelRequiresHalt.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_AbilitySpecificChannelRequiresHalt_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

