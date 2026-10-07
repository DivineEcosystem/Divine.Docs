# <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay"></a> Class CEntityMessageScreenOverlay

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CEntityMessageScreenOverlay : IMessage<CEntityMessageScreenOverlay>, IEquatable<CEntityMessageScreenOverlay>, IDeepCloneable<CEntityMessageScreenOverlay>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CEntityMessageScreenOverlay](Divine.Protobufs.Dota2.CEntityMessageScreenOverlay.md)

#### Implements

IMessage<CEntityMessageScreenOverlay\>, 
[IEquatable<CEntityMessageScreenOverlay\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CEntityMessageScreenOverlay\>, 
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
[EnumerableExtensions.In<CEntityMessageScreenOverlay\>\(CEntityMessageScreenOverlay, params CEntityMessageScreenOverlay\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay__ctor"></a> CEntityMessageScreenOverlay\(\)

```csharp
public CEntityMessageScreenOverlay()
```

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay__ctor_Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_"></a> CEntityMessageScreenOverlay\(CEntityMessageScreenOverlay\)

```csharp
public CEntityMessageScreenOverlay(CEntityMessageScreenOverlay other)
```

#### Parameters

`other` [CEntityMessageScreenOverlay](Divine.Protobufs.Dota2.CEntityMessageScreenOverlay.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_EntityMsgFieldNumber"></a> EntityMsgFieldNumber

```csharp
public const int EntityMsgFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_StartEffectFieldNumber"></a> StartEffectFieldNumber

```csharp
public const int StartEffectFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_EntityMsg"></a> EntityMsg

```csharp
public CEntityMsg EntityMsg { get; set; }
```

#### Property Value

 [CEntityMsg](Divine.Protobufs.Dota2.CEntityMsg.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_HasStartEffect"></a> HasStartEffect

```csharp
public bool HasStartEffect { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_Parser"></a> Parser

```csharp
public static MessageParser<CEntityMessageScreenOverlay> Parser { get; }
```

#### Property Value

 MessageParser<[CEntityMessageScreenOverlay](Divine.Protobufs.Dota2.CEntityMessageScreenOverlay.md)\>

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_StartEffect"></a> StartEffect

```csharp
public bool StartEffect { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_ClearStartEffect"></a> ClearStartEffect\(\)

```csharp
public void ClearStartEffect()
```

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_Clone"></a> Clone\(\)

```csharp
public CEntityMessageScreenOverlay Clone()
```

#### Returns

 [CEntityMessageScreenOverlay](Divine.Protobufs.Dota2.CEntityMessageScreenOverlay.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_Equals_Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_"></a> Equals\(CEntityMessageScreenOverlay\)

```csharp
public bool Equals(CEntityMessageScreenOverlay other)
```

#### Parameters

`other` [CEntityMessageScreenOverlay](Divine.Protobufs.Dota2.CEntityMessageScreenOverlay.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_MergeFrom_Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_"></a> MergeFrom\(CEntityMessageScreenOverlay\)

```csharp
public void MergeFrom(CEntityMessageScreenOverlay other)
```

#### Parameters

`other` [CEntityMessageScreenOverlay](Divine.Protobufs.Dota2.CEntityMessageScreenOverlay.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CEntityMessageScreenOverlay_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

