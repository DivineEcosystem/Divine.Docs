# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged"></a> Class CDOTAUserMsg\_GamerulesStateChanged

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_GamerulesStateChanged : IMessage<CDOTAUserMsg_GamerulesStateChanged>, IEquatable<CDOTAUserMsg_GamerulesStateChanged>, IDeepCloneable<CDOTAUserMsg_GamerulesStateChanged>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_GamerulesStateChanged](Divine.Protobufs.Dota2.CDOTAUserMsg\_GamerulesStateChanged.md)

#### Implements

IMessage<CDOTAUserMsg\_GamerulesStateChanged\>, 
[IEquatable<CDOTAUserMsg\_GamerulesStateChanged\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_GamerulesStateChanged\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_GamerulesStateChanged\>\(CDOTAUserMsg\_GamerulesStateChanged, params CDOTAUserMsg\_GamerulesStateChanged\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged__ctor"></a> CDOTAUserMsg\_GamerulesStateChanged\(\)

```csharp
public CDOTAUserMsg_GamerulesStateChanged()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_"></a> CDOTAUserMsg\_GamerulesStateChanged\(CDOTAUserMsg\_GamerulesStateChanged\)

```csharp
public CDOTAUserMsg_GamerulesStateChanged(CDOTAUserMsg_GamerulesStateChanged other)
```

#### Parameters

`other` [CDOTAUserMsg\_GamerulesStateChanged](Divine.Protobufs.Dota2.CDOTAUserMsg\_GamerulesStateChanged.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_StateFieldNumber"></a> StateFieldNumber

```csharp
public const int StateFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_HasState"></a> HasState

```csharp
public bool HasState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_GamerulesStateChanged> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_GamerulesStateChanged](Divine.Protobufs.Dota2.CDOTAUserMsg\_GamerulesStateChanged.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_State"></a> State

```csharp
public uint State { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_ClearState"></a> ClearState\(\)

```csharp
public void ClearState()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_GamerulesStateChanged Clone()
```

#### Returns

 [CDOTAUserMsg\_GamerulesStateChanged](Divine.Protobufs.Dota2.CDOTAUserMsg\_GamerulesStateChanged.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_"></a> Equals\(CDOTAUserMsg\_GamerulesStateChanged\)

```csharp
public bool Equals(CDOTAUserMsg_GamerulesStateChanged other)
```

#### Parameters

`other` [CDOTAUserMsg\_GamerulesStateChanged](Divine.Protobufs.Dota2.CDOTAUserMsg\_GamerulesStateChanged.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_"></a> MergeFrom\(CDOTAUserMsg\_GamerulesStateChanged\)

```csharp
public void MergeFrom(CDOTAUserMsg_GamerulesStateChanged other)
```

#### Parameters

`other` [CDOTAUserMsg\_GamerulesStateChanged](Divine.Protobufs.Dota2.CDOTAUserMsg\_GamerulesStateChanged.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_GamerulesStateChanged_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

