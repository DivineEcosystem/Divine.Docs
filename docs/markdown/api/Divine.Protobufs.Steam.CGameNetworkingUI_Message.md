# <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message"></a> Class CGameNetworkingUI\_Message

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGameNetworkingUI_Message : IMessage<CGameNetworkingUI_Message>, IEquatable<CGameNetworkingUI_Message>, IDeepCloneable<CGameNetworkingUI_Message>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGameNetworkingUI\_Message](Divine.Protobufs.Steam.CGameNetworkingUI\_Message.md)

#### Implements

IMessage<CGameNetworkingUI\_Message\>, 
[IEquatable<CGameNetworkingUI\_Message\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGameNetworkingUI\_Message\>, 
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
[EnumerableExtensions.In<CGameNetworkingUI\_Message\>\(CGameNetworkingUI\_Message, params CGameNetworkingUI\_Message\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message__ctor"></a> CGameNetworkingUI\_Message\(\)

```csharp
public CGameNetworkingUI_Message()
```

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message__ctor_Divine_Protobufs_Steam_CGameNetworkingUI_Message_"></a> CGameNetworkingUI\_Message\(CGameNetworkingUI\_Message\)

```csharp
public CGameNetworkingUI_Message(CGameNetworkingUI_Message other)
```

#### Parameters

`other` [CGameNetworkingUI\_Message](Divine.Protobufs.Steam.CGameNetworkingUI\_Message.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message_ConnectionStateFieldNumber"></a> ConnectionStateFieldNumber

```csharp
public const int ConnectionStateFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message_ConnectionState"></a> ConnectionState

```csharp
public RepeatedField<CGameNetworkingUI_ConnectionState> ConnectionState { get; }
```

#### Property Value

 RepeatedField<[CGameNetworkingUI\_ConnectionState](Divine.Protobufs.Steam.CGameNetworkingUI\_ConnectionState.md)\>

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message_Parser"></a> Parser

```csharp
public static MessageParser<CGameNetworkingUI_Message> Parser { get; }
```

#### Property Value

 MessageParser<[CGameNetworkingUI\_Message](Divine.Protobufs.Steam.CGameNetworkingUI\_Message.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message_Clone"></a> Clone\(\)

```csharp
public CGameNetworkingUI_Message Clone()
```

#### Returns

 [CGameNetworkingUI\_Message](Divine.Protobufs.Steam.CGameNetworkingUI\_Message.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message_Equals_Divine_Protobufs_Steam_CGameNetworkingUI_Message_"></a> Equals\(CGameNetworkingUI\_Message\)

```csharp
public bool Equals(CGameNetworkingUI_Message other)
```

#### Parameters

`other` [CGameNetworkingUI\_Message](Divine.Protobufs.Steam.CGameNetworkingUI\_Message.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message_MergeFrom_Divine_Protobufs_Steam_CGameNetworkingUI_Message_"></a> MergeFrom\(CGameNetworkingUI\_Message\)

```csharp
public void MergeFrom(CGameNetworkingUI_Message other)
```

#### Parameters

`other` [CGameNetworkingUI\_Message](Divine.Protobufs.Steam.CGameNetworkingUI\_Message.md)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGameNetworkingUI_Message_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

