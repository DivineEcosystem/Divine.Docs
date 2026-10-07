# <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated"></a> Class CMsgGCToClientItemBattlerUserDataUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientItemBattlerUserDataUpdated : IMessage<CMsgGCToClientItemBattlerUserDataUpdated>, IEquatable<CMsgGCToClientItemBattlerUserDataUpdated>, IDeepCloneable<CMsgGCToClientItemBattlerUserDataUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientItemBattlerUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientItemBattlerUserDataUpdated.md)

#### Implements

IMessage<CMsgGCToClientItemBattlerUserDataUpdated\>, 
[IEquatable<CMsgGCToClientItemBattlerUserDataUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientItemBattlerUserDataUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientItemBattlerUserDataUpdated\>\(CMsgGCToClientItemBattlerUserDataUpdated, params CMsgGCToClientItemBattlerUserDataUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated__ctor"></a> CMsgGCToClientItemBattlerUserDataUpdated\(\)

```csharp
public CMsgGCToClientItemBattlerUserDataUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_"></a> CMsgGCToClientItemBattlerUserDataUpdated\(CMsgGCToClientItemBattlerUserDataUpdated\)

```csharp
public CMsgGCToClientItemBattlerUserDataUpdated(CMsgGCToClientItemBattlerUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientItemBattlerUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientItemBattlerUserDataUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_WorldDataFieldNumber"></a> WorldDataFieldNumber

```csharp
public const int WorldDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientItemBattlerUserDataUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientItemBattlerUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientItemBattlerUserDataUpdated.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_WorldData"></a> WorldData

```csharp
public CMsgItemBattlerWorldData WorldData { get; set; }
```

#### Property Value

 [CMsgItemBattlerWorldData](Divine.Protobufs.Dota2.CMsgItemBattlerWorldData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientItemBattlerUserDataUpdated Clone()
```

#### Returns

 [CMsgGCToClientItemBattlerUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientItemBattlerUserDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_"></a> Equals\(CMsgGCToClientItemBattlerUserDataUpdated\)

```csharp
public bool Equals(CMsgGCToClientItemBattlerUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientItemBattlerUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientItemBattlerUserDataUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_"></a> MergeFrom\(CMsgGCToClientItemBattlerUserDataUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientItemBattlerUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientItemBattlerUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientItemBattlerUserDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientItemBattlerUserDataUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

