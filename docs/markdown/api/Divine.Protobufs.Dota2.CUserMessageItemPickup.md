# <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup"></a> Class CUserMessageItemPickup

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageItemPickup : IMessage<CUserMessageItemPickup>, IEquatable<CUserMessageItemPickup>, IDeepCloneable<CUserMessageItemPickup>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageItemPickup](Divine.Protobufs.Dota2.CUserMessageItemPickup.md)

#### Implements

IMessage<CUserMessageItemPickup\>, 
[IEquatable<CUserMessageItemPickup\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageItemPickup\>, 
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
[EnumerableExtensions.In<CUserMessageItemPickup\>\(CUserMessageItemPickup, params CUserMessageItemPickup\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup__ctor"></a> CUserMessageItemPickup\(\)

```csharp
public CUserMessageItemPickup()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup__ctor_Divine_Protobufs_Dota2_CUserMessageItemPickup_"></a> CUserMessageItemPickup\(CUserMessageItemPickup\)

```csharp
public CUserMessageItemPickup(CUserMessageItemPickup other)
```

#### Parameters

`other` [CUserMessageItemPickup](Divine.Protobufs.Dota2.CUserMessageItemPickup.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_ItemnameFieldNumber"></a> ItemnameFieldNumber

```csharp
public const int ItemnameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_HasItemname"></a> HasItemname

```csharp
public bool HasItemname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_Itemname"></a> Itemname

```csharp
public string Itemname { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageItemPickup> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageItemPickup](Divine.Protobufs.Dota2.CUserMessageItemPickup.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_ClearItemname"></a> ClearItemname\(\)

```csharp
public void ClearItemname()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_Clone"></a> Clone\(\)

```csharp
public CUserMessageItemPickup Clone()
```

#### Returns

 [CUserMessageItemPickup](Divine.Protobufs.Dota2.CUserMessageItemPickup.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_Equals_Divine_Protobufs_Dota2_CUserMessageItemPickup_"></a> Equals\(CUserMessageItemPickup\)

```csharp
public bool Equals(CUserMessageItemPickup other)
```

#### Parameters

`other` [CUserMessageItemPickup](Divine.Protobufs.Dota2.CUserMessageItemPickup.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_MergeFrom_Divine_Protobufs_Dota2_CUserMessageItemPickup_"></a> MergeFrom\(CUserMessageItemPickup\)

```csharp
public void MergeFrom(CUserMessageItemPickup other)
```

#### Parameters

`other` [CUserMessageItemPickup](Divine.Protobufs.Dota2.CUserMessageItemPickup.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageItemPickup_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

