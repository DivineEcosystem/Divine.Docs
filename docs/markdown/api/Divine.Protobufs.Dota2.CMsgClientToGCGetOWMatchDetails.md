# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails"></a> Class CMsgClientToGCGetOWMatchDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetOWMatchDetails : IMessage<CMsgClientToGCGetOWMatchDetails>, IEquatable<CMsgClientToGCGetOWMatchDetails>, IDeepCloneable<CMsgClientToGCGetOWMatchDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetOWMatchDetails](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetails.md)

#### Implements

IMessage<CMsgClientToGCGetOWMatchDetails\>, 
[IEquatable<CMsgClientToGCGetOWMatchDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetOWMatchDetails\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetOWMatchDetails\>\(CMsgClientToGCGetOWMatchDetails, params CMsgClientToGCGetOWMatchDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails__ctor"></a> CMsgClientToGCGetOWMatchDetails\(\)

```csharp
public CMsgClientToGCGetOWMatchDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_"></a> CMsgClientToGCGetOWMatchDetails\(CMsgClientToGCGetOWMatchDetails\)

```csharp
public CMsgClientToGCGetOWMatchDetails(CMsgClientToGCGetOWMatchDetails other)
```

#### Parameters

`other` [CMsgClientToGCGetOWMatchDetails](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetails.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetOWMatchDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetOWMatchDetails](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetails.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetOWMatchDetails Clone()
```

#### Returns

 [CMsgClientToGCGetOWMatchDetails](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_"></a> Equals\(CMsgClientToGCGetOWMatchDetails\)

```csharp
public bool Equals(CMsgClientToGCGetOWMatchDetails other)
```

#### Parameters

`other` [CMsgClientToGCGetOWMatchDetails](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_"></a> MergeFrom\(CMsgClientToGCGetOWMatchDetails\)

```csharp
public void MergeFrom(CMsgClientToGCGetOWMatchDetails other)
```

#### Parameters

`other` [CMsgClientToGCGetOWMatchDetails](Divine.Protobufs.Dota2.CMsgClientToGCGetOWMatchDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetOWMatchDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

