# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement"></a> Class CDOTAClientMsg\_SetDesiredWardPlacement

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SetDesiredWardPlacement : IMessage<CDOTAClientMsg_SetDesiredWardPlacement>, IEquatable<CDOTAClientMsg_SetDesiredWardPlacement>, IDeepCloneable<CDOTAClientMsg_SetDesiredWardPlacement>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SetDesiredWardPlacement](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetDesiredWardPlacement.md)

#### Implements

IMessage<CDOTAClientMsg\_SetDesiredWardPlacement\>, 
[IEquatable<CDOTAClientMsg\_SetDesiredWardPlacement\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SetDesiredWardPlacement\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_SetDesiredWardPlacement\>\(CDOTAClientMsg\_SetDesiredWardPlacement, params CDOTAClientMsg\_SetDesiredWardPlacement\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement__ctor"></a> CDOTAClientMsg\_SetDesiredWardPlacement\(\)

```csharp
public CDOTAClientMsg_SetDesiredWardPlacement()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_"></a> CDOTAClientMsg\_SetDesiredWardPlacement\(CDOTAClientMsg\_SetDesiredWardPlacement\)

```csharp
public CDOTAClientMsg_SetDesiredWardPlacement(CDOTAClientMsg_SetDesiredWardPlacement other)
```

#### Parameters

`other` [CDOTAClientMsg\_SetDesiredWardPlacement](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetDesiredWardPlacement.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_WardIndexFieldNumber"></a> WardIndexFieldNumber

```csharp
public const int WardIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_WardXFieldNumber"></a> WardXFieldNumber

```csharp
public const int WardXFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_WardYFieldNumber"></a> WardYFieldNumber

```csharp
public const int WardYFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_HasWardIndex"></a> HasWardIndex

```csharp
public bool HasWardIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_HasWardX"></a> HasWardX

```csharp
public bool HasWardX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_HasWardY"></a> HasWardY

```csharp
public bool HasWardY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SetDesiredWardPlacement> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SetDesiredWardPlacement](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetDesiredWardPlacement.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_WardIndex"></a> WardIndex

```csharp
public uint WardIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_WardX"></a> WardX

```csharp
public float WardX { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_WardY"></a> WardY

```csharp
public float WardY { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_ClearWardIndex"></a> ClearWardIndex\(\)

```csharp
public void ClearWardIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_ClearWardX"></a> ClearWardX\(\)

```csharp
public void ClearWardX()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_ClearWardY"></a> ClearWardY\(\)

```csharp
public void ClearWardY()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SetDesiredWardPlacement Clone()
```

#### Returns

 [CDOTAClientMsg\_SetDesiredWardPlacement](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetDesiredWardPlacement.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_"></a> Equals\(CDOTAClientMsg\_SetDesiredWardPlacement\)

```csharp
public bool Equals(CDOTAClientMsg_SetDesiredWardPlacement other)
```

#### Parameters

`other` [CDOTAClientMsg\_SetDesiredWardPlacement](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetDesiredWardPlacement.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_"></a> MergeFrom\(CDOTAClientMsg\_SetDesiredWardPlacement\)

```csharp
public void MergeFrom(CDOTAClientMsg_SetDesiredWardPlacement other)
```

#### Parameters

`other` [CDOTAClientMsg\_SetDesiredWardPlacement](Divine.Protobufs.Dota2.CDOTAClientMsg\_SetDesiredWardPlacement.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SetDesiredWardPlacement_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

