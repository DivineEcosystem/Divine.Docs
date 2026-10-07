# <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived"></a> Class CMsgGCHAppCheersReceived

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCHAppCheersReceived : IMessage<CMsgGCHAppCheersReceived>, IEquatable<CMsgGCHAppCheersReceived>, IDeepCloneable<CMsgGCHAppCheersReceived>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md)

#### Implements

IMessage<CMsgGCHAppCheersReceived\>, 
[IEquatable<CMsgGCHAppCheersReceived\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCHAppCheersReceived\>, 
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
[EnumerableExtensions.In<CMsgGCHAppCheersReceived\>\(CMsgGCHAppCheersReceived, params CMsgGCHAppCheersReceived\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived__ctor"></a> CMsgGCHAppCheersReceived\(\)

```csharp
public CMsgGCHAppCheersReceived()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived__ctor_Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_"></a> CMsgGCHAppCheersReceived\(CMsgGCHAppCheersReceived\)

```csharp
public CMsgGCHAppCheersReceived(CMsgGCHAppCheersReceived other)
```

#### Parameters

`other` [CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_CheerTargetsFieldNumber"></a> CheerTargetsFieldNumber

```csharp
public const int CheerTargetsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_CheerTargets"></a> CheerTargets

```csharp
public RepeatedField<CMsgGCHAppCheersReceived.Types.CheerTarget> CheerTargets { get; }
```

#### Property Value

 RepeatedField<[CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md).[Types](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.md).[CheerTarget](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.Types.CheerTarget.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCHAppCheersReceived> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Clone"></a> Clone\(\)

```csharp
public CMsgGCHAppCheersReceived Clone()
```

#### Returns

 [CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_Equals_Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_"></a> Equals\(CMsgGCHAppCheersReceived\)

```csharp
public bool Equals(CMsgGCHAppCheersReceived other)
```

#### Parameters

`other` [CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_MergeFrom_Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_"></a> MergeFrom\(CMsgGCHAppCheersReceived\)

```csharp
public void MergeFrom(CMsgGCHAppCheersReceived other)
```

#### Parameters

`other` [CMsgGCHAppCheersReceived](Divine.Protobufs.Steam.CMsgGCHAppCheersReceived.md)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCHAppCheersReceived_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

