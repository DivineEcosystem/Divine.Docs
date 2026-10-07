# <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce"></a> Class CClientMsg\_CustomGameEventBounce

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CClientMsg_CustomGameEventBounce : IMessage<CClientMsg_CustomGameEventBounce>, IEquatable<CClientMsg_CustomGameEventBounce>, IDeepCloneable<CClientMsg_CustomGameEventBounce>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CClientMsg\_CustomGameEventBounce](Divine.Protobufs.Dota2.CClientMsg\_CustomGameEventBounce.md)

#### Implements

IMessage<CClientMsg\_CustomGameEventBounce\>, 
[IEquatable<CClientMsg\_CustomGameEventBounce\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CClientMsg\_CustomGameEventBounce\>, 
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
[EnumerableExtensions.In<CClientMsg\_CustomGameEventBounce\>\(CClientMsg\_CustomGameEventBounce, params CClientMsg\_CustomGameEventBounce\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce__ctor"></a> CClientMsg\_CustomGameEventBounce\(\)

```csharp
public CClientMsg_CustomGameEventBounce()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce__ctor_Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_"></a> CClientMsg\_CustomGameEventBounce\(CClientMsg\_CustomGameEventBounce\)

```csharp
public CClientMsg_CustomGameEventBounce(CClientMsg_CustomGameEventBounce other)
```

#### Parameters

`other` [CClientMsg\_CustomGameEventBounce](Divine.Protobufs.Dota2.CClientMsg\_CustomGameEventBounce.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_EventNameFieldNumber"></a> EventNameFieldNumber

```csharp
public const int EventNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_PlayerSlotFieldNumber"></a> PlayerSlotFieldNumber

```csharp
public const int PlayerSlotFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_EventName"></a> EventName

```csharp
public string EventName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_HasEventName"></a> HasEventName

```csharp
public bool HasEventName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_HasPlayerSlot"></a> HasPlayerSlot

```csharp
public bool HasPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_Parser"></a> Parser

```csharp
public static MessageParser<CClientMsg_CustomGameEventBounce> Parser { get; }
```

#### Property Value

 MessageParser<[CClientMsg\_CustomGameEventBounce](Divine.Protobufs.Dota2.CClientMsg\_CustomGameEventBounce.md)\>

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_PlayerSlot"></a> PlayerSlot

```csharp
public int PlayerSlot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_ClearEventName"></a> ClearEventName\(\)

```csharp
public void ClearEventName()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_ClearPlayerSlot"></a> ClearPlayerSlot\(\)

```csharp
public void ClearPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_Clone"></a> Clone\(\)

```csharp
public CClientMsg_CustomGameEventBounce Clone()
```

#### Returns

 [CClientMsg\_CustomGameEventBounce](Divine.Protobufs.Dota2.CClientMsg\_CustomGameEventBounce.md)

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_Equals_Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_"></a> Equals\(CClientMsg\_CustomGameEventBounce\)

```csharp
public bool Equals(CClientMsg_CustomGameEventBounce other)
```

#### Parameters

`other` [CClientMsg\_CustomGameEventBounce](Divine.Protobufs.Dota2.CClientMsg\_CustomGameEventBounce.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_MergeFrom_Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_"></a> MergeFrom\(CClientMsg\_CustomGameEventBounce\)

```csharp
public void MergeFrom(CClientMsg_CustomGameEventBounce other)
```

#### Parameters

`other` [CClientMsg\_CustomGameEventBounce](Divine.Protobufs.Dota2.CClientMsg\_CustomGameEventBounce.md)

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CClientMsg_CustomGameEventBounce_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

