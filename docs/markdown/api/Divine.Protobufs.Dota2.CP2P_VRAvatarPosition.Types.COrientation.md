# <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation"></a> Class CP2P\_VRAvatarPosition.Types.COrientation

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CP2P_VRAvatarPosition.Types.COrientation : IMessage<CP2P_VRAvatarPosition.Types.COrientation>, IEquatable<CP2P_VRAvatarPosition.Types.COrientation>, IDeepCloneable<CP2P_VRAvatarPosition.Types.COrientation>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CP2P\_VRAvatarPosition.Types.COrientation](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.Types.COrientation.md)

#### Implements

IMessage<CP2P\_VRAvatarPosition.Types.COrientation\>, 
[IEquatable<CP2P\_VRAvatarPosition.Types.COrientation\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CP2P\_VRAvatarPosition.Types.COrientation\>, 
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
[EnumerableExtensions.In<CP2P\_VRAvatarPosition.Types.COrientation\>\(CP2P\_VRAvatarPosition.Types.COrientation, params CP2P\_VRAvatarPosition.Types.COrientation\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation__ctor"></a> COrientation\(\)

```csharp
public COrientation()
```

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation__ctor_Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_"></a> COrientation\(COrientation\)

```csharp
public COrientation(CP2P_VRAvatarPosition.Types.COrientation other)
```

#### Parameters

`other` [CP2P\_VRAvatarPosition](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.md).[Types](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.Types.md).[COrientation](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.Types.COrientation.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_AngFieldNumber"></a> AngFieldNumber

```csharp
public const int AngFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_PosFieldNumber"></a> PosFieldNumber

```csharp
public const int PosFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_Ang"></a> Ang

```csharp
public CMsgQAngle Ang { get; set; }
```

#### Property Value

 [CMsgQAngle](Divine.Protobufs.Dota2.CMsgQAngle.md)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_Parser"></a> Parser

```csharp
public static MessageParser<CP2P_VRAvatarPosition.Types.COrientation> Parser { get; }
```

#### Property Value

 MessageParser<[CP2P\_VRAvatarPosition](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.md).[Types](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.Types.md).[COrientation](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.Types.COrientation.md)\>

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_Pos"></a> Pos

```csharp
public CMsgVector Pos { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_Clone"></a> Clone\(\)

```csharp
public CP2P_VRAvatarPosition.Types.COrientation Clone()
```

#### Returns

 [CP2P\_VRAvatarPosition](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.md).[Types](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.Types.md).[COrientation](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.Types.COrientation.md)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_Equals_Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_"></a> Equals\(COrientation\)

```csharp
public bool Equals(CP2P_VRAvatarPosition.Types.COrientation other)
```

#### Parameters

`other` [CP2P\_VRAvatarPosition](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.md).[Types](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.Types.md).[COrientation](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.Types.COrientation.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_MergeFrom_Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_"></a> MergeFrom\(COrientation\)

```csharp
public void MergeFrom(CP2P_VRAvatarPosition.Types.COrientation other)
```

#### Parameters

`other` [CP2P\_VRAvatarPosition](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.md).[Types](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.Types.md).[COrientation](Divine.Protobufs.Dota2.CP2P\_VRAvatarPosition.Types.COrientation.md)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CP2P_VRAvatarPosition_Types_COrientation_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

