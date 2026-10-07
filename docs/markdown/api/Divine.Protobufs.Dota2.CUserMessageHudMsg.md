# <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg"></a> Class CUserMessageHudMsg

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageHudMsg : IMessage<CUserMessageHudMsg>, IEquatable<CUserMessageHudMsg>, IDeepCloneable<CUserMessageHudMsg>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageHudMsg](Divine.Protobufs.Dota2.CUserMessageHudMsg.md)

#### Implements

IMessage<CUserMessageHudMsg\>, 
[IEquatable<CUserMessageHudMsg\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageHudMsg\>, 
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
[EnumerableExtensions.In<CUserMessageHudMsg\>\(CUserMessageHudMsg, params CUserMessageHudMsg\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg__ctor"></a> CUserMessageHudMsg\(\)

```csharp
public CUserMessageHudMsg()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg__ctor_Divine_Protobufs_Dota2_CUserMessageHudMsg_"></a> CUserMessageHudMsg\(CUserMessageHudMsg\)

```csharp
public CUserMessageHudMsg(CUserMessageHudMsg other)
```

#### Parameters

`other` [CUserMessageHudMsg](Divine.Protobufs.Dota2.CUserMessageHudMsg.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_ChannelFieldNumber"></a> ChannelFieldNumber

```csharp
public const int ChannelFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_Color1FieldNumber"></a> Color1FieldNumber

```csharp
public const int Color1FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_Color2FieldNumber"></a> Color2FieldNumber

```csharp
public const int Color2FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_EffectFieldNumber"></a> EffectFieldNumber

```csharp
public const int EffectFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_XFieldNumber"></a> XFieldNumber

```csharp
public const int XFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_YFieldNumber"></a> YFieldNumber

```csharp
public const int YFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_Channel"></a> Channel

```csharp
public uint Channel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_Color1"></a> Color1

```csharp
public uint Color1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_Color2"></a> Color2

```csharp
public uint Color2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_Effect"></a> Effect

```csharp
public uint Effect { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_HasChannel"></a> HasChannel

```csharp
public bool HasChannel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_HasColor1"></a> HasColor1

```csharp
public bool HasColor1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_HasColor2"></a> HasColor2

```csharp
public bool HasColor2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_HasEffect"></a> HasEffect

```csharp
public bool HasEffect { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_HasX"></a> HasX

```csharp
public bool HasX { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_HasY"></a> HasY

```csharp
public bool HasY { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageHudMsg> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageHudMsg](Divine.Protobufs.Dota2.CUserMessageHudMsg.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_X"></a> X

```csharp
public float X { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_Y"></a> Y

```csharp
public float Y { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_ClearChannel"></a> ClearChannel\(\)

```csharp
public void ClearChannel()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_ClearColor1"></a> ClearColor1\(\)

```csharp
public void ClearColor1()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_ClearColor2"></a> ClearColor2\(\)

```csharp
public void ClearColor2()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_ClearEffect"></a> ClearEffect\(\)

```csharp
public void ClearEffect()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_ClearX"></a> ClearX\(\)

```csharp
public void ClearX()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_ClearY"></a> ClearY\(\)

```csharp
public void ClearY()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_Clone"></a> Clone\(\)

```csharp
public CUserMessageHudMsg Clone()
```

#### Returns

 [CUserMessageHudMsg](Divine.Protobufs.Dota2.CUserMessageHudMsg.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_Equals_Divine_Protobufs_Dota2_CUserMessageHudMsg_"></a> Equals\(CUserMessageHudMsg\)

```csharp
public bool Equals(CUserMessageHudMsg other)
```

#### Parameters

`other` [CUserMessageHudMsg](Divine.Protobufs.Dota2.CUserMessageHudMsg.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_MergeFrom_Divine_Protobufs_Dota2_CUserMessageHudMsg_"></a> MergeFrom\(CUserMessageHudMsg\)

```csharp
public void MergeFrom(CUserMessageHudMsg other)
```

#### Parameters

`other` [CUserMessageHudMsg](Divine.Protobufs.Dota2.CUserMessageHudMsg.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageHudMsg_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

