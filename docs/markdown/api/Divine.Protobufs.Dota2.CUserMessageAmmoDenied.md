# <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied"></a> Class CUserMessageAmmoDenied

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageAmmoDenied : IMessage<CUserMessageAmmoDenied>, IEquatable<CUserMessageAmmoDenied>, IDeepCloneable<CUserMessageAmmoDenied>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageAmmoDenied](Divine.Protobufs.Dota2.CUserMessageAmmoDenied.md)

#### Implements

IMessage<CUserMessageAmmoDenied\>, 
[IEquatable<CUserMessageAmmoDenied\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageAmmoDenied\>, 
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
[EnumerableExtensions.In<CUserMessageAmmoDenied\>\(CUserMessageAmmoDenied, params CUserMessageAmmoDenied\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied__ctor"></a> CUserMessageAmmoDenied\(\)

```csharp
public CUserMessageAmmoDenied()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied__ctor_Divine_Protobufs_Dota2_CUserMessageAmmoDenied_"></a> CUserMessageAmmoDenied\(CUserMessageAmmoDenied\)

```csharp
public CUserMessageAmmoDenied(CUserMessageAmmoDenied other)
```

#### Parameters

`other` [CUserMessageAmmoDenied](Divine.Protobufs.Dota2.CUserMessageAmmoDenied.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_AmmoIdFieldNumber"></a> AmmoIdFieldNumber

```csharp
public const int AmmoIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_AmmoId"></a> AmmoId

```csharp
public uint AmmoId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_HasAmmoId"></a> HasAmmoId

```csharp
public bool HasAmmoId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageAmmoDenied> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageAmmoDenied](Divine.Protobufs.Dota2.CUserMessageAmmoDenied.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_ClearAmmoId"></a> ClearAmmoId\(\)

```csharp
public void ClearAmmoId()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_Clone"></a> Clone\(\)

```csharp
public CUserMessageAmmoDenied Clone()
```

#### Returns

 [CUserMessageAmmoDenied](Divine.Protobufs.Dota2.CUserMessageAmmoDenied.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_Equals_Divine_Protobufs_Dota2_CUserMessageAmmoDenied_"></a> Equals\(CUserMessageAmmoDenied\)

```csharp
public bool Equals(CUserMessageAmmoDenied other)
```

#### Parameters

`other` [CUserMessageAmmoDenied](Divine.Protobufs.Dota2.CUserMessageAmmoDenied.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_MergeFrom_Divine_Protobufs_Dota2_CUserMessageAmmoDenied_"></a> MergeFrom\(CUserMessageAmmoDenied\)

```csharp
public void MergeFrom(CUserMessageAmmoDenied other)
```

#### Parameters

`other` [CUserMessageAmmoDenied](Divine.Protobufs.Dota2.CUserMessageAmmoDenied.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageAmmoDenied_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

