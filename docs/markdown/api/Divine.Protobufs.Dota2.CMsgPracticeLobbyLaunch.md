# <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch"></a> Class CMsgPracticeLobbyLaunch

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPracticeLobbyLaunch : IMessage<CMsgPracticeLobbyLaunch>, IEquatable<CMsgPracticeLobbyLaunch>, IDeepCloneable<CMsgPracticeLobbyLaunch>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPracticeLobbyLaunch](Divine.Protobufs.Dota2.CMsgPracticeLobbyLaunch.md)

#### Implements

IMessage<CMsgPracticeLobbyLaunch\>, 
[IEquatable<CMsgPracticeLobbyLaunch\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPracticeLobbyLaunch\>, 
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
[EnumerableExtensions.In<CMsgPracticeLobbyLaunch\>\(CMsgPracticeLobbyLaunch, params CMsgPracticeLobbyLaunch\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch__ctor"></a> CMsgPracticeLobbyLaunch\(\)

```csharp
public CMsgPracticeLobbyLaunch()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch__ctor_Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_"></a> CMsgPracticeLobbyLaunch\(CMsgPracticeLobbyLaunch\)

```csharp
public CMsgPracticeLobbyLaunch(CMsgPracticeLobbyLaunch other)
```

#### Parameters

`other` [CMsgPracticeLobbyLaunch](Divine.Protobufs.Dota2.CMsgPracticeLobbyLaunch.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_NonceFieldNumber"></a> NonceFieldNumber

```csharp
public const int NonceFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_HasNonce"></a> HasNonce

```csharp
public bool HasNonce { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_Nonce"></a> Nonce

```csharp
public ulong Nonce { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPracticeLobbyLaunch> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPracticeLobbyLaunch](Divine.Protobufs.Dota2.CMsgPracticeLobbyLaunch.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_ClearNonce"></a> ClearNonce\(\)

```csharp
public void ClearNonce()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_Clone"></a> Clone\(\)

```csharp
public CMsgPracticeLobbyLaunch Clone()
```

#### Returns

 [CMsgPracticeLobbyLaunch](Divine.Protobufs.Dota2.CMsgPracticeLobbyLaunch.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_Equals_Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_"></a> Equals\(CMsgPracticeLobbyLaunch\)

```csharp
public bool Equals(CMsgPracticeLobbyLaunch other)
```

#### Parameters

`other` [CMsgPracticeLobbyLaunch](Divine.Protobufs.Dota2.CMsgPracticeLobbyLaunch.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_MergeFrom_Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_"></a> MergeFrom\(CMsgPracticeLobbyLaunch\)

```csharp
public void MergeFrom(CMsgPracticeLobbyLaunch other)
```

#### Parameters

`other` [CMsgPracticeLobbyLaunch](Divine.Protobufs.Dota2.CMsgPracticeLobbyLaunch.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyLaunch_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

