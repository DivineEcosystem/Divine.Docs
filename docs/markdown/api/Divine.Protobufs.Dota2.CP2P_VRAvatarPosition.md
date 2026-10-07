# <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition"></a> Class CP2P\_VRAvatarPosition

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CP2P_VRAvatarPosition : IMessage<CP2P_VRAvatarPosition>, IEquatable<CP2P_VRAvatarPosition>, IDeepCloneable<CP2P_VRAvatarPosition>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CP2P\_VRAvatarPosition](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.md)

#### Implements

IMessage<CP2P\_VRAvatarPosition\>, 
[IEquatable<CP2P\_VRAvatarPosition\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CP2P\_VRAvatarPosition\>, 
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
[EnumerableExtensions.In<CP2P\_VRAvatarPosition\>\(CP2P\_VRAvatarPosition, params CP2P\_VRAvatarPosition\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition__ctor"></a> CP2P\_VRAvatarPosition\(\)

```csharp
public CP2P_VRAvatarPosition()
```

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition__ctor_Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_"></a> CP2P\_VRAvatarPosition\(CP2P\_VRAvatarPosition\)

```csharp
public CP2P_VRAvatarPosition(CP2P_VRAvatarPosition other)
```

#### Parameters

`other` [CP2P\_VRAvatarPosition](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_BodyPartsFieldNumber"></a> BodyPartsFieldNumber

```csharp
public const int BodyPartsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_HatIdFieldNumber"></a> HatIdFieldNumber

```csharp
public const int HatIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_SceneIdFieldNumber"></a> SceneIdFieldNumber

```csharp
public const int SceneIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_WorldScaleFieldNumber"></a> WorldScaleFieldNumber

```csharp
public const int WorldScaleFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_BodyParts"></a> BodyParts

```csharp
public RepeatedField<CP2P_VRAvatarPosition.Types.COrientation> BodyParts { get; }
```

#### Property Value

 RepeatedField<[CP2P\_VRAvatarPosition](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.md).[Types](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.Types.md).[COrientation](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.Types.COrientation.md)\>

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_HasHatId"></a> HasHatId

```csharp
public bool HasHatId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_HasSceneId"></a> HasSceneId

```csharp
public bool HasSceneId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_HasWorldScale"></a> HasWorldScale

```csharp
public bool HasWorldScale { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_HatId"></a> HatId

```csharp
public int HatId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Parser"></a> Parser

```csharp
public static MessageParser<CP2P_VRAvatarPosition> Parser { get; }
```

#### Property Value

 MessageParser<[CP2P\_VRAvatarPosition](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.md)\>

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_SceneId"></a> SceneId

```csharp
public int SceneId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_WorldScale"></a> WorldScale

```csharp
public int WorldScale { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_ClearHatId"></a> ClearHatId\(\)

```csharp
public void ClearHatId()
```

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_ClearSceneId"></a> ClearSceneId\(\)

```csharp
public void ClearSceneId()
```

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_ClearWorldScale"></a> ClearWorldScale\(\)

```csharp
public void ClearWorldScale()
```

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Clone"></a> Clone\(\)

```csharp
public CP2P_VRAvatarPosition Clone()
```

#### Returns

 [CP2P\_VRAvatarPosition](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.md)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Equals_Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_"></a> Equals\(CP2P\_VRAvatarPosition\)

```csharp
public bool Equals(CP2P_VRAvatarPosition other)
```

#### Parameters

`other` [CP2P\_VRAvatarPosition](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_MergeFrom_Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_"></a> MergeFrom\(CP2P\_VRAvatarPosition\)

```csharp
public void MergeFrom(CP2P_VRAvatarPosition other)
```

#### Parameters

`other` [CP2P\_VRAvatarPosition](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.md)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

