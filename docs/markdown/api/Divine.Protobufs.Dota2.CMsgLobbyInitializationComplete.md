# <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete"></a> Class CMsgLobbyInitializationComplete

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyInitializationComplete : IMessage<CMsgLobbyInitializationComplete>, IEquatable<CMsgLobbyInitializationComplete>, IDeepCloneable<CMsgLobbyInitializationComplete>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyInitializationComplete](Divine.Protobufs.Dota2.CMsgLobbyInitializationComplete.md)

#### Implements

IMessage<CMsgLobbyInitializationComplete\>, 
[IEquatable<CMsgLobbyInitializationComplete\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyInitializationComplete\>, 
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
[EnumerableExtensions.In<CMsgLobbyInitializationComplete\>\(CMsgLobbyInitializationComplete, params CMsgLobbyInitializationComplete\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete__ctor"></a> CMsgLobbyInitializationComplete\(\)

```csharp
public CMsgLobbyInitializationComplete()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete__ctor_Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_"></a> CMsgLobbyInitializationComplete\(CMsgLobbyInitializationComplete\)

```csharp
public CMsgLobbyInitializationComplete(CMsgLobbyInitializationComplete other)
```

#### Parameters

`other` [CMsgLobbyInitializationComplete](Divine.Protobufs.Dota2.CMsgLobbyInitializationComplete.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyInitializationComplete> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyInitializationComplete](Divine.Protobufs.Dota2.CMsgLobbyInitializationComplete.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyInitializationComplete Clone()
```

#### Returns

 [CMsgLobbyInitializationComplete](Divine.Protobufs.Dota2.CMsgLobbyInitializationComplete.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_Equals_Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_"></a> Equals\(CMsgLobbyInitializationComplete\)

```csharp
public bool Equals(CMsgLobbyInitializationComplete other)
```

#### Parameters

`other` [CMsgLobbyInitializationComplete](Divine.Protobufs.Dota2.CMsgLobbyInitializationComplete.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_"></a> MergeFrom\(CMsgLobbyInitializationComplete\)

```csharp
public void MergeFrom(CMsgLobbyInitializationComplete other)
```

#### Parameters

`other` [CMsgLobbyInitializationComplete](Divine.Protobufs.Dota2.CMsgLobbyInitializationComplete.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyInitializationComplete_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

