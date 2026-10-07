# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat"></a> Class CDOTAUserMsg\_BotChat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_BotChat : IMessage<CDOTAUserMsg_BotChat>, IEquatable<CDOTAUserMsg_BotChat>, IDeepCloneable<CDOTAUserMsg_BotChat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_BotChat](Divine.Protobufs.Dota2.CDOTAUserMsg\_BotChat.md)

#### Implements

IMessage<CDOTAUserMsg\_BotChat\>, 
[IEquatable<CDOTAUserMsg\_BotChat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_BotChat\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_BotChat\>\(CDOTAUserMsg\_BotChat, params CDOTAUserMsg\_BotChat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat__ctor"></a> CDOTAUserMsg\_BotChat\(\)

```csharp
public CDOTAUserMsg_BotChat()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_"></a> CDOTAUserMsg\_BotChat\(CDOTAUserMsg\_BotChat\)

```csharp
public CDOTAUserMsg_BotChat(CDOTAUserMsg_BotChat other)
```

#### Parameters

`other` [CDOTAUserMsg\_BotChat](Divine.Protobufs.Dota2.CDOTAUserMsg\_BotChat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_TargetFieldNumber"></a> TargetFieldNumber

```csharp
public const int TargetFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_TeamOnlyFieldNumber"></a> TeamOnlyFieldNumber

```csharp
public const int TeamOnlyFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_HasTarget"></a> HasTarget

```csharp
public bool HasTarget { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_HasTeamOnly"></a> HasTeamOnly

```csharp
public bool HasTeamOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_BotChat> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_BotChat](Divine.Protobufs.Dota2.CDOTAUserMsg\_BotChat.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_Target"></a> Target

```csharp
public string Target { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_TeamOnly"></a> TeamOnly

```csharp
public bool TeamOnly { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_ClearTarget"></a> ClearTarget\(\)

```csharp
public void ClearTarget()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_ClearTeamOnly"></a> ClearTeamOnly\(\)

```csharp
public void ClearTeamOnly()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_BotChat Clone()
```

#### Returns

 [CDOTAUserMsg\_BotChat](Divine.Protobufs.Dota2.CDOTAUserMsg\_BotChat.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_"></a> Equals\(CDOTAUserMsg\_BotChat\)

```csharp
public bool Equals(CDOTAUserMsg_BotChat other)
```

#### Parameters

`other` [CDOTAUserMsg\_BotChat](Divine.Protobufs.Dota2.CDOTAUserMsg\_BotChat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_"></a> MergeFrom\(CDOTAUserMsg\_BotChat\)

```csharp
public void MergeFrom(CDOTAUserMsg_BotChat other)
```

#### Parameters

`other` [CDOTAUserMsg\_BotChat](Divine.Protobufs.Dota2.CDOTAUserMsg\_BotChat.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BotChat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

