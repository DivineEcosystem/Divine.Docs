# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages"></a> Class CMsgDOTALeagueMessages

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueMessages : IMessage<CMsgDOTALeagueMessages>, IEquatable<CMsgDOTALeagueMessages>, IDeepCloneable<CMsgDOTALeagueMessages>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueMessages](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.md)

#### Implements

IMessage<CMsgDOTALeagueMessages\>, 
[IEquatable<CMsgDOTALeagueMessages\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueMessages\>, 
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
[EnumerableExtensions.In<CMsgDOTALeagueMessages\>\(CMsgDOTALeagueMessages, params CMsgDOTALeagueMessages\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages__ctor"></a> CMsgDOTALeagueMessages\(\)

```csharp
public CMsgDOTALeagueMessages()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_"></a> CMsgDOTALeagueMessages\(CMsgDOTALeagueMessages\)

```csharp
public CMsgDOTALeagueMessages(CMsgDOTALeagueMessages other)
```

#### Parameters

`other` [CMsgDOTALeagueMessages](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_MessagesFieldNumber"></a> MessagesFieldNumber

```csharp
public const int MessagesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Messages"></a> Messages

```csharp
public RepeatedField<CMsgDOTALeagueMessages.Types.Message> Messages { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTALeagueMessages](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.Types.md).[Message](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.Types.Message.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueMessages> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueMessages](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueMessages Clone()
```

#### Returns

 [CMsgDOTALeagueMessages](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_"></a> Equals\(CMsgDOTALeagueMessages\)

```csharp
public bool Equals(CMsgDOTALeagueMessages other)
```

#### Parameters

`other` [CMsgDOTALeagueMessages](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_"></a> MergeFrom\(CMsgDOTALeagueMessages\)

```csharp
public void MergeFrom(CMsgDOTALeagueMessages other)
```

#### Parameters

`other` [CMsgDOTALeagueMessages](Divine.Protobufs.Dota2.CMsgDOTALeagueMessages.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueMessages_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

