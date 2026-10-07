# <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData"></a> Class CMsgCraftworksUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCraftworksUserData : IMessage<CMsgCraftworksUserData>, IEquatable<CMsgCraftworksUserData>, IDeepCloneable<CMsgCraftworksUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCraftworksUserData](Divine.Protobufs.Dota2.CMsgCraftworksUserData.md)

#### Implements

IMessage<CMsgCraftworksUserData\>, 
[IEquatable<CMsgCraftworksUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCraftworksUserData\>, 
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
[EnumerableExtensions.In<CMsgCraftworksUserData\>\(CMsgCraftworksUserData, params CMsgCraftworksUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData__ctor"></a> CMsgCraftworksUserData\(\)

```csharp
public CMsgCraftworksUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData__ctor_Divine_Protobufs_Dota2_CMsgCraftworksUserData_"></a> CMsgCraftworksUserData\(CMsgCraftworksUserData\)

```csharp
public CMsgCraftworksUserData(CMsgCraftworksUserData other)
```

#### Parameters

`other` [CMsgCraftworksUserData](Divine.Protobufs.Dota2.CMsgCraftworksUserData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData_ComponentInventoryFieldNumber"></a> ComponentInventoryFieldNumber

```csharp
public const int ComponentInventoryFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData_ComponentInventory"></a> ComponentInventory

```csharp
public CMsgCraftworksComponents ComponentInventory { get; set; }
```

#### Property Value

 [CMsgCraftworksComponents](Divine.Protobufs.Dota2.CMsgCraftworksComponents.md)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCraftworksUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCraftworksUserData](Divine.Protobufs.Dota2.CMsgCraftworksUserData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData_Clone"></a> Clone\(\)

```csharp
public CMsgCraftworksUserData Clone()
```

#### Returns

 [CMsgCraftworksUserData](Divine.Protobufs.Dota2.CMsgCraftworksUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData_Equals_Divine_Protobufs_Dota2_CMsgCraftworksUserData_"></a> Equals\(CMsgCraftworksUserData\)

```csharp
public bool Equals(CMsgCraftworksUserData other)
```

#### Parameters

`other` [CMsgCraftworksUserData](Divine.Protobufs.Dota2.CMsgCraftworksUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgCraftworksUserData_"></a> MergeFrom\(CMsgCraftworksUserData\)

```csharp
public void MergeFrom(CMsgCraftworksUserData other)
```

#### Parameters

`other` [CMsgCraftworksUserData](Divine.Protobufs.Dota2.CMsgCraftworksUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCraftworksUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

