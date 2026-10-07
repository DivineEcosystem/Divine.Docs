# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory"></a> Class CMsgClientToGCOverworldDevClearInventory

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldDevClearInventory : IMessage<CMsgClientToGCOverworldDevClearInventory>, IEquatable<CMsgClientToGCOverworldDevClearInventory>, IDeepCloneable<CMsgClientToGCOverworldDevClearInventory>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearInventory.md)

#### Implements

IMessage<CMsgClientToGCOverworldDevClearInventory\>, 
[IEquatable<CMsgClientToGCOverworldDevClearInventory\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldDevClearInventory\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldDevClearInventory\>\(CMsgClientToGCOverworldDevClearInventory, params CMsgClientToGCOverworldDevClearInventory\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory__ctor"></a> CMsgClientToGCOverworldDevClearInventory\(\)

```csharp
public CMsgClientToGCOverworldDevClearInventory()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_"></a> CMsgClientToGCOverworldDevClearInventory\(CMsgClientToGCOverworldDevClearInventory\)

```csharp
public CMsgClientToGCOverworldDevClearInventory(CMsgClientToGCOverworldDevClearInventory other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearInventory.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldDevClearInventory> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearInventory.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldDevClearInventory Clone()
```

#### Returns

 [CMsgClientToGCOverworldDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearInventory.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_"></a> Equals\(CMsgClientToGCOverworldDevClearInventory\)

```csharp
public bool Equals(CMsgClientToGCOverworldDevClearInventory other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearInventory.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_"></a> MergeFrom\(CMsgClientToGCOverworldDevClearInventory\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldDevClearInventory other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevClearInventory](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevClearInventory.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevClearInventory_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

