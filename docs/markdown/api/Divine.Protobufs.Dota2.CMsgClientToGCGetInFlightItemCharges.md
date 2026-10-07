# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges"></a> Class CMsgClientToGCGetInFlightItemCharges

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetInFlightItemCharges : IMessage<CMsgClientToGCGetInFlightItemCharges>, IEquatable<CMsgClientToGCGetInFlightItemCharges>, IDeepCloneable<CMsgClientToGCGetInFlightItemCharges>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetInFlightItemCharges](Divine.Protobufs.Dota2.CMsgClientToGCGetInFlightItemCharges.md)

#### Implements

IMessage<CMsgClientToGCGetInFlightItemCharges\>, 
[IEquatable<CMsgClientToGCGetInFlightItemCharges\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetInFlightItemCharges\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetInFlightItemCharges\>\(CMsgClientToGCGetInFlightItemCharges, params CMsgClientToGCGetInFlightItemCharges\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges__ctor"></a> CMsgClientToGCGetInFlightItemCharges\(\)

```csharp
public CMsgClientToGCGetInFlightItemCharges()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_"></a> CMsgClientToGCGetInFlightItemCharges\(CMsgClientToGCGetInFlightItemCharges\)

```csharp
public CMsgClientToGCGetInFlightItemCharges(CMsgClientToGCGetInFlightItemCharges other)
```

#### Parameters

`other` [CMsgClientToGCGetInFlightItemCharges](Divine.Protobufs.Dota2.CMsgClientToGCGetInFlightItemCharges.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetInFlightItemCharges> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetInFlightItemCharges](Divine.Protobufs.Dota2.CMsgClientToGCGetInFlightItemCharges.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetInFlightItemCharges Clone()
```

#### Returns

 [CMsgClientToGCGetInFlightItemCharges](Divine.Protobufs.Dota2.CMsgClientToGCGetInFlightItemCharges.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_"></a> Equals\(CMsgClientToGCGetInFlightItemCharges\)

```csharp
public bool Equals(CMsgClientToGCGetInFlightItemCharges other)
```

#### Parameters

`other` [CMsgClientToGCGetInFlightItemCharges](Divine.Protobufs.Dota2.CMsgClientToGCGetInFlightItemCharges.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_"></a> MergeFrom\(CMsgClientToGCGetInFlightItemCharges\)

```csharp
public void MergeFrom(CMsgClientToGCGetInFlightItemCharges other)
```

#### Parameters

`other` [CMsgClientToGCGetInFlightItemCharges](Divine.Protobufs.Dota2.CMsgClientToGCGetInFlightItemCharges.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetInFlightItemCharges_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

