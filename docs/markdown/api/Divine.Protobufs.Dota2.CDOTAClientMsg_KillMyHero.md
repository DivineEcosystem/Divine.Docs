# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero"></a> Class CDOTAClientMsg\_KillMyHero

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_KillMyHero : IMessage<CDOTAClientMsg_KillMyHero>, IEquatable<CDOTAClientMsg_KillMyHero>, IDeepCloneable<CDOTAClientMsg_KillMyHero>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_KillMyHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_KillMyHero.md)

#### Implements

IMessage<CDOTAClientMsg\_KillMyHero\>, 
[IEquatable<CDOTAClientMsg\_KillMyHero\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_KillMyHero\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_KillMyHero\>\(CDOTAClientMsg\_KillMyHero, params CDOTAClientMsg\_KillMyHero\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero__ctor"></a> CDOTAClientMsg\_KillMyHero\(\)

```csharp
public CDOTAClientMsg_KillMyHero()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_"></a> CDOTAClientMsg\_KillMyHero\(CDOTAClientMsg\_KillMyHero\)

```csharp
public CDOTAClientMsg_KillMyHero(CDOTAClientMsg_KillMyHero other)
```

#### Parameters

`other` [CDOTAClientMsg\_KillMyHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_KillMyHero.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_KillMyHero> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_KillMyHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_KillMyHero.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_KillMyHero Clone()
```

#### Returns

 [CDOTAClientMsg\_KillMyHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_KillMyHero.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_"></a> Equals\(CDOTAClientMsg\_KillMyHero\)

```csharp
public bool Equals(CDOTAClientMsg_KillMyHero other)
```

#### Parameters

`other` [CDOTAClientMsg\_KillMyHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_KillMyHero.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_"></a> MergeFrom\(CDOTAClientMsg\_KillMyHero\)

```csharp
public void MergeFrom(CDOTAClientMsg_KillMyHero other)
```

#### Parameters

`other` [CDOTAClientMsg\_KillMyHero](Divine.Protobufs.Dota2.CDOTAClientMsg\_KillMyHero.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_KillMyHero_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

