# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile"></a> Class CDOTAUserMsg\_DestroyLinearProjectile

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_DestroyLinearProjectile : IMessage<CDOTAUserMsg_DestroyLinearProjectile>, IEquatable<CDOTAUserMsg_DestroyLinearProjectile>, IDeepCloneable<CDOTAUserMsg_DestroyLinearProjectile>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_DestroyLinearProjectile](Divine.Protobufs.Dota2.CDOTAUserMsg\_DestroyLinearProjectile.md)

#### Implements

IMessage<CDOTAUserMsg\_DestroyLinearProjectile\>, 
[IEquatable<CDOTAUserMsg\_DestroyLinearProjectile\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_DestroyLinearProjectile\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_DestroyLinearProjectile\>\(CDOTAUserMsg\_DestroyLinearProjectile, params CDOTAUserMsg\_DestroyLinearProjectile\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile__ctor"></a> CDOTAUserMsg\_DestroyLinearProjectile\(\)

```csharp
public CDOTAUserMsg_DestroyLinearProjectile()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_"></a> CDOTAUserMsg\_DestroyLinearProjectile\(CDOTAUserMsg\_DestroyLinearProjectile\)

```csharp
public CDOTAUserMsg_DestroyLinearProjectile(CDOTAUserMsg_DestroyLinearProjectile other)
```

#### Parameters

`other` [CDOTAUserMsg\_DestroyLinearProjectile](Divine.Protobufs.Dota2.CDOTAUserMsg\_DestroyLinearProjectile.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_HandleFieldNumber"></a> HandleFieldNumber

```csharp
public const int HandleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_Handle"></a> Handle

```csharp
public int Handle { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_HasHandle"></a> HasHandle

```csharp
public bool HasHandle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_DestroyLinearProjectile> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_DestroyLinearProjectile](Divine.Protobufs.Dota2.CDOTAUserMsg\_DestroyLinearProjectile.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_ClearHandle"></a> ClearHandle\(\)

```csharp
public void ClearHandle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_DestroyLinearProjectile Clone()
```

#### Returns

 [CDOTAUserMsg\_DestroyLinearProjectile](Divine.Protobufs.Dota2.CDOTAUserMsg\_DestroyLinearProjectile.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_"></a> Equals\(CDOTAUserMsg\_DestroyLinearProjectile\)

```csharp
public bool Equals(CDOTAUserMsg_DestroyLinearProjectile other)
```

#### Parameters

`other` [CDOTAUserMsg\_DestroyLinearProjectile](Divine.Protobufs.Dota2.CDOTAUserMsg\_DestroyLinearProjectile.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_"></a> MergeFrom\(CDOTAUserMsg\_DestroyLinearProjectile\)

```csharp
public void MergeFrom(CDOTAUserMsg_DestroyLinearProjectile other)
```

#### Parameters

`other` [CDOTAUserMsg\_DestroyLinearProjectile](Divine.Protobufs.Dota2.CDOTAUserMsg\_DestroyLinearProjectile.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DestroyLinearProjectile_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

