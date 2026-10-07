# <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg"></a> Class CSODOTALobby.Types.CExtraMsg

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTALobby.Types.CExtraMsg : IMessage<CSODOTALobby.Types.CExtraMsg>, IEquatable<CSODOTALobby.Types.CExtraMsg>, IDeepCloneable<CSODOTALobby.Types.CExtraMsg>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTALobby.Types.CExtraMsg](Divine.Protobufs.Dota2.CSODOTALobby.Types.CExtraMsg.md)

#### Implements

IMessage<CSODOTALobby.Types.CExtraMsg\>, 
[IEquatable<CSODOTALobby.Types.CExtraMsg\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTALobby.Types.CExtraMsg\>, 
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
[EnumerableExtensions.In<CSODOTALobby.Types.CExtraMsg\>\(CSODOTALobby.Types.CExtraMsg, params CSODOTALobby.Types.CExtraMsg\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg__ctor"></a> CExtraMsg\(\)

```csharp
public CExtraMsg()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg__ctor_Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_"></a> CExtraMsg\(CExtraMsg\)

```csharp
public CExtraMsg(CSODOTALobby.Types.CExtraMsg other)
```

#### Parameters

`other` [CSODOTALobby](Divine.Protobufs.Dota2.CSODOTALobby.md).[Types](Divine.Protobufs.Dota2.CSODOTALobby.Types.md).[CExtraMsg](Divine.Protobufs.Dota2.CSODOTALobby.Types.CExtraMsg.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_ContentsFieldNumber"></a> ContentsFieldNumber

```csharp
public const int ContentsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_Contents"></a> Contents

```csharp
public ByteString Contents { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_HasContents"></a> HasContents

```csharp
public bool HasContents { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_Id"></a> Id

```csharp
public uint Id { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTALobby.Types.CExtraMsg> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTALobby](Divine.Protobufs.Dota2.CSODOTALobby.md).[Types](Divine.Protobufs.Dota2.CSODOTALobby.Types.md).[CExtraMsg](Divine.Protobufs.Dota2.CSODOTALobby.Types.CExtraMsg.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_ClearContents"></a> ClearContents\(\)

```csharp
public void ClearContents()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_Clone"></a> Clone\(\)

```csharp
public CSODOTALobby.Types.CExtraMsg Clone()
```

#### Returns

 [CSODOTALobby](Divine.Protobufs.Dota2.CSODOTALobby.md).[Types](Divine.Protobufs.Dota2.CSODOTALobby.Types.md).[CExtraMsg](Divine.Protobufs.Dota2.CSODOTALobby.Types.CExtraMsg.md)

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_Equals_Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_"></a> Equals\(CExtraMsg\)

```csharp
public bool Equals(CSODOTALobby.Types.CExtraMsg other)
```

#### Parameters

`other` [CSODOTALobby](Divine.Protobufs.Dota2.CSODOTALobby.md).[Types](Divine.Protobufs.Dota2.CSODOTALobby.Types.md).[CExtraMsg](Divine.Protobufs.Dota2.CSODOTALobby.Types.CExtraMsg.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_MergeFrom_Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_"></a> MergeFrom\(CExtraMsg\)

```csharp
public void MergeFrom(CSODOTALobby.Types.CExtraMsg other)
```

#### Parameters

`other` [CSODOTALobby](Divine.Protobufs.Dota2.CSODOTALobby.md).[Types](Divine.Protobufs.Dota2.CSODOTALobby.Types.md).[CExtraMsg](Divine.Protobufs.Dota2.CSODOTALobby.Types.CExtraMsg.md)

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTALobby_Types_CExtraMsg_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

