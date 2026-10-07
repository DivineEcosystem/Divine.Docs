# <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest"></a> Class CMsgClientToGCJoinPlaytest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCJoinPlaytest : IMessage<CMsgClientToGCJoinPlaytest>, IEquatable<CMsgClientToGCJoinPlaytest>, IDeepCloneable<CMsgClientToGCJoinPlaytest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCJoinPlaytest](Divine.Protobufs.Dota2.CMsgClientToGCJoinPlaytest.md)

#### Implements

IMessage<CMsgClientToGCJoinPlaytest\>, 
[IEquatable<CMsgClientToGCJoinPlaytest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCJoinPlaytest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCJoinPlaytest\>\(CMsgClientToGCJoinPlaytest, params CMsgClientToGCJoinPlaytest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest__ctor"></a> CMsgClientToGCJoinPlaytest\(\)

```csharp
public CMsgClientToGCJoinPlaytest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_"></a> CMsgClientToGCJoinPlaytest\(CMsgClientToGCJoinPlaytest\)

```csharp
public CMsgClientToGCJoinPlaytest(CMsgClientToGCJoinPlaytest other)
```

#### Parameters

`other` [CMsgClientToGCJoinPlaytest](Divine.Protobufs.Dota2.CMsgClientToGCJoinPlaytest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCJoinPlaytest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCJoinPlaytest](Divine.Protobufs.Dota2.CMsgClientToGCJoinPlaytest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCJoinPlaytest Clone()
```

#### Returns

 [CMsgClientToGCJoinPlaytest](Divine.Protobufs.Dota2.CMsgClientToGCJoinPlaytest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_"></a> Equals\(CMsgClientToGCJoinPlaytest\)

```csharp
public bool Equals(CMsgClientToGCJoinPlaytest other)
```

#### Parameters

`other` [CMsgClientToGCJoinPlaytest](Divine.Protobufs.Dota2.CMsgClientToGCJoinPlaytest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_"></a> MergeFrom\(CMsgClientToGCJoinPlaytest\)

```csharp
public void MergeFrom(CMsgClientToGCJoinPlaytest other)
```

#### Parameters

`other` [CMsgClientToGCJoinPlaytest](Divine.Protobufs.Dota2.CMsgClientToGCJoinPlaytest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCJoinPlaytest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

