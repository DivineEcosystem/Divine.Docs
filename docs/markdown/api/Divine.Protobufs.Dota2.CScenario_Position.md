# <a id="Divine_Protobufs_Dota2_CScenario_Position"></a> Class CScenario\_Position

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CScenario_Position : IMessage<CScenario_Position>, IEquatable<CScenario_Position>, IDeepCloneable<CScenario_Position>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CScenario\_Position](Divine.Protobufs.Dota2.CScenario\_Position.md)

#### Implements

IMessage<CScenario\_Position\>, 
[IEquatable<CScenario\_Position\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CScenario\_Position\>, 
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
[EnumerableExtensions.In<CScenario\_Position\>\(CScenario\_Position, params CScenario\_Position\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CScenario_Position__ctor"></a> CScenario\_Position\(\)

```csharp
public CScenario_Position()
```

### <a id="Divine_Protobufs_Dota2_CScenario_Position__ctor_Divine_Protobufs_Dota2_CScenario_Position_"></a> CScenario\_Position\(CScenario\_Position\)

```csharp
public CScenario_Position(CScenario_Position other)
```

#### Parameters

`other` [CScenario\_Position](Divine.Protobufs.Dota2.CScenario\_Position.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CScenario_Position_XFieldNumber"></a> XFieldNumber

```csharp
public const int XFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenario_Position_YFieldNumber"></a> YFieldNumber

```csharp
public const int YFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CScenario_Position_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CScenario_Position_HasX"></a> HasX

```csharp
public bool HasX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenario_Position_HasY"></a> HasY

```csharp
public bool HasY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenario_Position_Parser"></a> Parser

```csharp
public static MessageParser<CScenario_Position> Parser { get; }
```

#### Property Value

 MessageParser<[CScenario\_Position](Divine.Protobufs.Dota2.CScenario\_Position.md)\>

### <a id="Divine_Protobufs_Dota2_CScenario_Position_X"></a> X

```csharp
public float X { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CScenario_Position_Y"></a> Y

```csharp
public float Y { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CScenario_Position_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenario_Position_ClearX"></a> ClearX\(\)

```csharp
public void ClearX()
```

### <a id="Divine_Protobufs_Dota2_CScenario_Position_ClearY"></a> ClearY\(\)

```csharp
public void ClearY()
```

### <a id="Divine_Protobufs_Dota2_CScenario_Position_Clone"></a> Clone\(\)

```csharp
public CScenario_Position Clone()
```

#### Returns

 [CScenario\_Position](Divine.Protobufs.Dota2.CScenario\_Position.md)

### <a id="Divine_Protobufs_Dota2_CScenario_Position_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenario_Position_Equals_Divine_Protobufs_Dota2_CScenario_Position_"></a> Equals\(CScenario\_Position\)

```csharp
public bool Equals(CScenario_Position other)
```

#### Parameters

`other` [CScenario\_Position](Divine.Protobufs.Dota2.CScenario\_Position.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CScenario_Position_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CScenario_Position_MergeFrom_Divine_Protobufs_Dota2_CScenario_Position_"></a> MergeFrom\(CScenario\_Position\)

```csharp
public void MergeFrom(CScenario_Position other)
```

#### Parameters

`other` [CScenario\_Position](Divine.Protobufs.Dota2.CScenario\_Position.md)

### <a id="Divine_Protobufs_Dota2_CScenario_Position_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CScenario_Position_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CScenario_Position_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

