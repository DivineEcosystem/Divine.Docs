# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag"></a> Class CDOTAClientMsg\_SetUnitShareFlag

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SetUnitShareFlag : IMessage<CDOTAClientMsg_SetUnitShareFlag>, IEquatable<CDOTAClientMsg_SetUnitShareFlag>, IDeepCloneable<CDOTAClientMsg_SetUnitShareFlag>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SetUnitShareFlag](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetUnitShareFlag.md)

#### Implements

IMessage<CDOTAClientMsg\_SetUnitShareFlag\>, 
[IEquatable<CDOTAClientMsg\_SetUnitShareFlag\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SetUnitShareFlag\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_SetUnitShareFlag\>\(CDOTAClientMsg\_SetUnitShareFlag, params CDOTAClientMsg\_SetUnitShareFlag\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag__ctor"></a> CDOTAClientMsg\_SetUnitShareFlag\(\)

```csharp
public CDOTAClientMsg_SetUnitShareFlag()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_"></a> CDOTAClientMsg\_SetUnitShareFlag\(CDOTAClientMsg\_SetUnitShareFlag\)

```csharp
public CDOTAClientMsg_SetUnitShareFlag(CDOTAClientMsg_SetUnitShareFlag other)
```

#### Parameters

`other` [CDOTAClientMsg\_SetUnitShareFlag](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetUnitShareFlag.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_FlagFieldNumber"></a> FlagFieldNumber

```csharp
public const int FlagFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_StateFieldNumber"></a> StateFieldNumber

```csharp
public const int StateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_Flag"></a> Flag

```csharp
public uint Flag { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_HasFlag"></a> HasFlag

```csharp
public bool HasFlag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_HasState"></a> HasState

```csharp
public bool HasState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SetUnitShareFlag> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SetUnitShareFlag](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetUnitShareFlag.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_State"></a> State

```csharp
public bool State { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_ClearFlag"></a> ClearFlag\(\)

```csharp
public void ClearFlag()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_ClearState"></a> ClearState\(\)

```csharp
public void ClearState()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SetUnitShareFlag Clone()
```

#### Returns

 [CDOTAClientMsg\_SetUnitShareFlag](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetUnitShareFlag.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_"></a> Equals\(CDOTAClientMsg\_SetUnitShareFlag\)

```csharp
public bool Equals(CDOTAClientMsg_SetUnitShareFlag other)
```

#### Parameters

`other` [CDOTAClientMsg\_SetUnitShareFlag](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetUnitShareFlag.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_"></a> MergeFrom\(CDOTAClientMsg\_SetUnitShareFlag\)

```csharp
public void MergeFrom(CDOTAClientMsg_SetUnitShareFlag other)
```

#### Parameters

`other` [CDOTAClientMsg\_SetUnitShareFlag](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetUnitShareFlag.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetUnitShareFlag_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

