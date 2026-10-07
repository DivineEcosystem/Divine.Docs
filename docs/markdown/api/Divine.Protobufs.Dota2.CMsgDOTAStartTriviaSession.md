# <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession"></a> Class CMsgDOTAStartTriviaSession

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAStartTriviaSession : IMessage<CMsgDOTAStartTriviaSession>, IEquatable<CMsgDOTAStartTriviaSession>, IDeepCloneable<CMsgDOTAStartTriviaSession>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAStartTriviaSession](Divine.Protobufs.Dota2.CMsgDOTAStartTriviaSession.md)

#### Implements

IMessage<CMsgDOTAStartTriviaSession\>, 
[IEquatable<CMsgDOTAStartTriviaSession\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAStartTriviaSession\>, 
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
[EnumerableExtensions.In<CMsgDOTAStartTriviaSession\>\(CMsgDOTAStartTriviaSession, params CMsgDOTAStartTriviaSession\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession__ctor"></a> CMsgDOTAStartTriviaSession\(\)

```csharp
public CMsgDOTAStartTriviaSession()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession__ctor_Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_"></a> CMsgDOTAStartTriviaSession\(CMsgDOTAStartTriviaSession\)

```csharp
public CMsgDOTAStartTriviaSession(CMsgDOTAStartTriviaSession other)
```

#### Parameters

`other` [CMsgDOTAStartTriviaSession](Divine.Protobufs.Dota2.CMsgDOTAStartTriviaSession.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAStartTriviaSession> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAStartTriviaSession](Divine.Protobufs.Dota2.CMsgDOTAStartTriviaSession.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAStartTriviaSession Clone()
```

#### Returns

 [CMsgDOTAStartTriviaSession](Divine.Protobufs.Dota2.CMsgDOTAStartTriviaSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_Equals_Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_"></a> Equals\(CMsgDOTAStartTriviaSession\)

```csharp
public bool Equals(CMsgDOTAStartTriviaSession other)
```

#### Parameters

`other` [CMsgDOTAStartTriviaSession](Divine.Protobufs.Dota2.CMsgDOTAStartTriviaSession.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_"></a> MergeFrom\(CMsgDOTAStartTriviaSession\)

```csharp
public void MergeFrom(CMsgDOTAStartTriviaSession other)
```

#### Parameters

`other` [CMsgDOTAStartTriviaSession](Divine.Protobufs.Dota2.CMsgDOTAStartTriviaSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAStartTriviaSession_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

