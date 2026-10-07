# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents"></a> Class CMsgClientToGCCraftworksDevModifyComponents

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCraftworksDevModifyComponents : IMessage<CMsgClientToGCCraftworksDevModifyComponents>, IEquatable<CMsgClientToGCCraftworksDevModifyComponents>, IDeepCloneable<CMsgClientToGCCraftworksDevModifyComponents>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCraftworksDevModifyComponents](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksDevModifyComponents.md)

#### Implements

IMessage<CMsgClientToGCCraftworksDevModifyComponents\>, 
[IEquatable<CMsgClientToGCCraftworksDevModifyComponents\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCraftworksDevModifyComponents\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCraftworksDevModifyComponents\>\(CMsgClientToGCCraftworksDevModifyComponents, params CMsgClientToGCCraftworksDevModifyComponents\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents__ctor"></a> CMsgClientToGCCraftworksDevModifyComponents\(\)

```csharp
public CMsgClientToGCCraftworksDevModifyComponents()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_"></a> CMsgClientToGCCraftworksDevModifyComponents\(CMsgClientToGCCraftworksDevModifyComponents\)

```csharp
public CMsgClientToGCCraftworksDevModifyComponents(CMsgClientToGCCraftworksDevModifyComponents other)
```

#### Parameters

`other` [CMsgClientToGCCraftworksDevModifyComponents](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksDevModifyComponents.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_ComponentsFieldNumber"></a> ComponentsFieldNumber

```csharp
public const int ComponentsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_CraftworksIdFieldNumber"></a> CraftworksIdFieldNumber

```csharp
public const int CraftworksIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_OperationFieldNumber"></a> OperationFieldNumber

```csharp
public const int OperationFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_Components"></a> Components

```csharp
public CMsgCraftworksComponents Components { get; set; }
```

#### Property Value

 [CMsgCraftworksComponents](Divine.Protobufs.Dota2.CMsgCraftworksComponents.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_CraftworksId"></a> CraftworksId

```csharp
public uint CraftworksId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_HasCraftworksId"></a> HasCraftworksId

```csharp
public bool HasCraftworksId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_HasOperation"></a> HasOperation

```csharp
public bool HasOperation { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_Operation"></a> Operation

```csharp
public CMsgClientToGCCraftworksDevModifyComponents.Types.EOperation Operation { get; set; }
```

#### Property Value

 [CMsgClientToGCCraftworksDevModifyComponents](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksDevModifyComponents.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksDevModifyComponents.Types.md).[EOperation](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksDevModifyComponents.Types.EOperation.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCraftworksDevModifyComponents> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCraftworksDevModifyComponents](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksDevModifyComponents.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_ClearCraftworksId"></a> ClearCraftworksId\(\)

```csharp
public void ClearCraftworksId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_ClearOperation"></a> ClearOperation\(\)

```csharp
public void ClearOperation()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCraftworksDevModifyComponents Clone()
```

#### Returns

 [CMsgClientToGCCraftworksDevModifyComponents](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksDevModifyComponents.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_"></a> Equals\(CMsgClientToGCCraftworksDevModifyComponents\)

```csharp
public bool Equals(CMsgClientToGCCraftworksDevModifyComponents other)
```

#### Parameters

`other` [CMsgClientToGCCraftworksDevModifyComponents](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksDevModifyComponents.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_"></a> MergeFrom\(CMsgClientToGCCraftworksDevModifyComponents\)

```csharp
public void MergeFrom(CMsgClientToGCCraftworksDevModifyComponents other)
```

#### Parameters

`other` [CMsgClientToGCCraftworksDevModifyComponents](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksDevModifyComponents.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksDevModifyComponents_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

