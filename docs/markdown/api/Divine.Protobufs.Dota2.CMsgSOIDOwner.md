# <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner"></a> Class CMsgSOIDOwner

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSOIDOwner : IMessage<CMsgSOIDOwner>, IEquatable<CMsgSOIDOwner>, IDeepCloneable<CMsgSOIDOwner>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSOIDOwner](Divine.Protobufs.Dota2.CMsgSOIDOwner.md)

#### Implements

IMessage<CMsgSOIDOwner\>, 
[IEquatable<CMsgSOIDOwner\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSOIDOwner\>, 
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
[EnumerableExtensions.In<CMsgSOIDOwner\>\(CMsgSOIDOwner, params CMsgSOIDOwner\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner__ctor"></a> CMsgSOIDOwner\(\)

```csharp
public CMsgSOIDOwner()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner__ctor_Divine_Protobufs_Dota2_CMsgSOIDOwner_"></a> CMsgSOIDOwner\(CMsgSOIDOwner\)

```csharp
public CMsgSOIDOwner(CMsgSOIDOwner other)
```

#### Parameters

`other` [CMsgSOIDOwner](Divine.Protobufs.Dota2.CMsgSOIDOwner.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_Id"></a> Id

```csharp
public ulong Id { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSOIDOwner> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSOIDOwner](Divine.Protobufs.Dota2.CMsgSOIDOwner.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_Type"></a> Type

```csharp
public uint Type { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_Clone"></a> Clone\(\)

```csharp
public CMsgSOIDOwner Clone()
```

#### Returns

 [CMsgSOIDOwner](Divine.Protobufs.Dota2.CMsgSOIDOwner.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_Equals_Divine_Protobufs_Dota2_CMsgSOIDOwner_"></a> Equals\(CMsgSOIDOwner\)

```csharp
public bool Equals(CMsgSOIDOwner other)
```

#### Parameters

`other` [CMsgSOIDOwner](Divine.Protobufs.Dota2.CMsgSOIDOwner.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_MergeFrom_Divine_Protobufs_Dota2_CMsgSOIDOwner_"></a> MergeFrom\(CMsgSOIDOwner\)

```csharp
public void MergeFrom(CMsgSOIDOwner other)
```

#### Parameters

`other` [CMsgSOIDOwner](Divine.Protobufs.Dota2.CMsgSOIDOwner.md)

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSOIDOwner_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

