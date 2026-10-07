# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile"></a> Class CDOTAUserMsg\_TE\_DestroyProjectile

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_TE_DestroyProjectile : IMessage<CDOTAUserMsg_TE_DestroyProjectile>, IEquatable<CDOTAUserMsg_TE_DestroyProjectile>, IDeepCloneable<CDOTAUserMsg_TE_DestroyProjectile>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_TE\_DestroyProjectile](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_DestroyProjectile.md)

#### Implements

IMessage<CDOTAUserMsg\_TE\_DestroyProjectile\>, 
[IEquatable<CDOTAUserMsg\_TE\_DestroyProjectile\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_TE\_DestroyProjectile\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_TE\_DestroyProjectile\>\(CDOTAUserMsg\_TE\_DestroyProjectile, params CDOTAUserMsg\_TE\_DestroyProjectile\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile__ctor"></a> CDOTAUserMsg\_TE\_DestroyProjectile\(\)

```csharp
public CDOTAUserMsg_TE_DestroyProjectile()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_"></a> CDOTAUserMsg\_TE\_DestroyProjectile\(CDOTAUserMsg\_TE\_DestroyProjectile\)

```csharp
public CDOTAUserMsg_TE_DestroyProjectile(CDOTAUserMsg_TE_DestroyProjectile other)
```

#### Parameters

`other` [CDOTAUserMsg\_TE\_DestroyProjectile](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_DestroyProjectile.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_HandleFieldNumber"></a> HandleFieldNumber

```csharp
public const int HandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_Handle"></a> Handle

```csharp
public int Handle { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_HasHandle"></a> HasHandle

```csharp
public bool HasHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_TE_DestroyProjectile> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_TE\_DestroyProjectile](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_DestroyProjectile.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_ClearHandle"></a> ClearHandle\(\)

```csharp
public void ClearHandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_TE_DestroyProjectile Clone()
```

#### Returns

 [CDOTAUserMsg\_TE\_DestroyProjectile](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_DestroyProjectile.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_"></a> Equals\(CDOTAUserMsg\_TE\_DestroyProjectile\)

```csharp
public bool Equals(CDOTAUserMsg_TE_DestroyProjectile other)
```

#### Parameters

`other` [CDOTAUserMsg\_TE\_DestroyProjectile](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_DestroyProjectile.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_"></a> MergeFrom\(CDOTAUserMsg\_TE\_DestroyProjectile\)

```csharp
public void MergeFrom(CDOTAUserMsg_TE_DestroyProjectile other)
```

#### Parameters

`other` [CDOTAUserMsg\_TE\_DestroyProjectile](Divine.Protobufs.Dota2.CDOTAUserMsg\_TE\_DestroyProjectile.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TE_DestroyProjectile_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

