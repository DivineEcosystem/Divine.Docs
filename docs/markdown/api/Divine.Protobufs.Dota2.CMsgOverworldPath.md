# <a id="Divine_Protobufs_Dota2_CMsgOverworldPath"></a> Class CMsgOverworldPath

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldPath : IMessage<CMsgOverworldPath>, IEquatable<CMsgOverworldPath>, IDeepCloneable<CMsgOverworldPath>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldPath](Divine.Protobufs.Dota2.CMsgOverworldPath.md)

#### Implements

IMessage<CMsgOverworldPath\>, 
[IEquatable<CMsgOverworldPath\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldPath\>, 
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
[EnumerableExtensions.In<CMsgOverworldPath\>\(CMsgOverworldPath, params CMsgOverworldPath\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath__ctor"></a> CMsgOverworldPath\(\)

```csharp
public CMsgOverworldPath()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath__ctor_Divine_Protobufs_Dota2_CMsgOverworldPath_"></a> CMsgOverworldPath\(CMsgOverworldPath\)

```csharp
public CMsgOverworldPath(CMsgOverworldPath other)
```

#### Parameters

`other` [CMsgOverworldPath](Divine.Protobufs.Dota2.CMsgOverworldPath.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_PathCostFieldNumber"></a> PathCostFieldNumber

```csharp
public const int PathCostFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_PathIdFieldNumber"></a> PathIdFieldNumber

```csharp
public const int PathIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_PathStateFieldNumber"></a> PathStateFieldNumber

```csharp
public const int PathStateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_HasPathId"></a> HasPathId

```csharp
public bool HasPathId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_HasPathState"></a> HasPathState

```csharp
public bool HasPathState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldPath> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldPath](Divine.Protobufs.Dota2.CMsgOverworldPath.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_PathCost"></a> PathCost

```csharp
public CMsgOverworldTokenQuantity PathCost { get; set; }
```

#### Property Value

 [CMsgOverworldTokenQuantity](Divine.Protobufs.Dota2.CMsgOverworldTokenQuantity.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_PathId"></a> PathId

```csharp
public uint PathId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_PathState"></a> PathState

```csharp
public EOverworldPathState PathState { get; set; }
```

#### Property Value

 [EOverworldPathState](Divine.Protobufs.Dota2.EOverworldPathState.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_ClearPathId"></a> ClearPathId\(\)

```csharp
public void ClearPathId()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_ClearPathState"></a> ClearPathState\(\)

```csharp
public void ClearPathState()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldPath Clone()
```

#### Returns

 [CMsgOverworldPath](Divine.Protobufs.Dota2.CMsgOverworldPath.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_Equals_Divine_Protobufs_Dota2_CMsgOverworldPath_"></a> Equals\(CMsgOverworldPath\)

```csharp
public bool Equals(CMsgOverworldPath other)
```

#### Parameters

`other` [CMsgOverworldPath](Divine.Protobufs.Dota2.CMsgOverworldPath.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldPath_"></a> MergeFrom\(CMsgOverworldPath\)

```csharp
public void MergeFrom(CMsgOverworldPath other)
```

#### Parameters

`other` [CMsgOverworldPath](Divine.Protobufs.Dota2.CMsgOverworldPath.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldPath_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

