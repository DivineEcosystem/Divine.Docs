# <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg"></a> Class CMsgGCToGCUpdateWelcomeMsg

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCUpdateWelcomeMsg : IMessage<CMsgGCToGCUpdateWelcomeMsg>, IEquatable<CMsgGCToGCUpdateWelcomeMsg>, IDeepCloneable<CMsgGCToGCUpdateWelcomeMsg>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCUpdateWelcomeMsg](Divine.Protobufs.Dota2.CMsgGCToGCUpdateWelcomeMsg.md)

#### Implements

IMessage<CMsgGCToGCUpdateWelcomeMsg\>, 
[IEquatable<CMsgGCToGCUpdateWelcomeMsg\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCUpdateWelcomeMsg\>, 
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
[EnumerableExtensions.In<CMsgGCToGCUpdateWelcomeMsg\>\(CMsgGCToGCUpdateWelcomeMsg, params CMsgGCToGCUpdateWelcomeMsg\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg__ctor"></a> CMsgGCToGCUpdateWelcomeMsg\(\)

```csharp
public CMsgGCToGCUpdateWelcomeMsg()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg__ctor_Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_"></a> CMsgGCToGCUpdateWelcomeMsg\(CMsgGCToGCUpdateWelcomeMsg\)

```csharp
public CMsgGCToGCUpdateWelcomeMsg(CMsgGCToGCUpdateWelcomeMsg other)
```

#### Parameters

`other` [CMsgGCToGCUpdateWelcomeMsg](Divine.Protobufs.Dota2.CMsgGCToGCUpdateWelcomeMsg.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_BroadcastFieldNumber"></a> BroadcastFieldNumber

```csharp
public const int BroadcastFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_NewMsgFieldNumber"></a> NewMsgFieldNumber

```csharp
public const int NewMsgFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_ServerFieldNumber"></a> ServerFieldNumber

```csharp
public const int ServerFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_Broadcast"></a> Broadcast

```csharp
public bool Broadcast { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_HasBroadcast"></a> HasBroadcast

```csharp
public bool HasBroadcast { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_HasServer"></a> HasServer

```csharp
public bool HasServer { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_NewMsg"></a> NewMsg

```csharp
public CExtraMsgBlock NewMsg { get; set; }
```

#### Property Value

 [CExtraMsgBlock](Divine.Protobufs.Dota2.CExtraMsgBlock.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCUpdateWelcomeMsg> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCUpdateWelcomeMsg](Divine.Protobufs.Dota2.CMsgGCToGCUpdateWelcomeMsg.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_Server"></a> Server

```csharp
public bool Server { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_ClearBroadcast"></a> ClearBroadcast\(\)

```csharp
public void ClearBroadcast()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_ClearServer"></a> ClearServer\(\)

```csharp
public void ClearServer()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCUpdateWelcomeMsg Clone()
```

#### Returns

 [CMsgGCToGCUpdateWelcomeMsg](Divine.Protobufs.Dota2.CMsgGCToGCUpdateWelcomeMsg.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_Equals_Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_"></a> Equals\(CMsgGCToGCUpdateWelcomeMsg\)

```csharp
public bool Equals(CMsgGCToGCUpdateWelcomeMsg other)
```

#### Parameters

`other` [CMsgGCToGCUpdateWelcomeMsg](Divine.Protobufs.Dota2.CMsgGCToGCUpdateWelcomeMsg.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_"></a> MergeFrom\(CMsgGCToGCUpdateWelcomeMsg\)

```csharp
public void MergeFrom(CMsgGCToGCUpdateWelcomeMsg other)
```

#### Parameters

`other` [CMsgGCToGCUpdateWelcomeMsg](Divine.Protobufs.Dota2.CMsgGCToGCUpdateWelcomeMsg.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCUpdateWelcomeMsg_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

