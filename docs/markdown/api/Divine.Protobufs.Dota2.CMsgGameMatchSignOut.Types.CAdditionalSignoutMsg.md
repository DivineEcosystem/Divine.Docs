# <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg"></a> Class CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg : IMessage<CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg>, IEquatable<CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg>, IDeepCloneable<CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg.md)

#### Implements

IMessage<CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg\>, 
[IEquatable<CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg\>, 
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
[EnumerableExtensions.In<CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg\>\(CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg, params CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg__ctor"></a> CAdditionalSignoutMsg\(\)

```csharp
public CAdditionalSignoutMsg()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg__ctor_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_"></a> CAdditionalSignoutMsg\(CAdditionalSignoutMsg\)

```csharp
public CAdditionalSignoutMsg(CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CAdditionalSignoutMsg](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_ContentsFieldNumber"></a> ContentsFieldNumber

```csharp
public const int ContentsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_Contents"></a> Contents

```csharp
public ByteString Contents { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_HasContents"></a> HasContents

```csharp
public bool HasContents { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_Id"></a> Id

```csharp
public uint Id { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CAdditionalSignoutMsg](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_ClearContents"></a> ClearContents\(\)

```csharp
public void ClearContents()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_Clone"></a> Clone\(\)

```csharp
public CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg Clone()
```

#### Returns

 [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CAdditionalSignoutMsg](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_Equals_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_"></a> Equals\(CAdditionalSignoutMsg\)

```csharp
public bool Equals(CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CAdditionalSignoutMsg](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_MergeFrom_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_"></a> MergeFrom\(CAdditionalSignoutMsg\)

```csharp
public void MergeFrom(CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[CAdditionalSignoutMsg](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.CAdditionalSignoutMsg.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_CAdditionalSignoutMsg_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

