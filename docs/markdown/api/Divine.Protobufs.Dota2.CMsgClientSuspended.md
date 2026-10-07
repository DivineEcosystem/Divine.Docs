# <a id="Divine_Protobufs_Dota2_CMsgClientSuspended"></a> Class CMsgClientSuspended

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientSuspended : IMessage<CMsgClientSuspended>, IEquatable<CMsgClientSuspended>, IDeepCloneable<CMsgClientSuspended>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientSuspended](Divine.Protobufs.Dota2.CMsgClientSuspended.md)

#### Implements

IMessage<CMsgClientSuspended\>, 
[IEquatable<CMsgClientSuspended\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientSuspended\>, 
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
[EnumerableExtensions.In<CMsgClientSuspended\>\(CMsgClientSuspended, params CMsgClientSuspended\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended__ctor"></a> CMsgClientSuspended\(\)

```csharp
public CMsgClientSuspended()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended__ctor_Divine_Protobufs_Dota2_CMsgClientSuspended_"></a> CMsgClientSuspended\(CMsgClientSuspended\)

```csharp
public CMsgClientSuspended(CMsgClientSuspended other)
```

#### Parameters

`other` [CMsgClientSuspended](Divine.Protobufs.Dota2.CMsgClientSuspended.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_TimeEndFieldNumber"></a> TimeEndFieldNumber

```csharp
public const int TimeEndFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_HasTimeEnd"></a> HasTimeEnd

```csharp
public bool HasTimeEnd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientSuspended> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientSuspended](Divine.Protobufs.Dota2.CMsgClientSuspended.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_TimeEnd"></a> TimeEnd

```csharp
public uint TimeEnd { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_ClearTimeEnd"></a> ClearTimeEnd\(\)

```csharp
public void ClearTimeEnd()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_Clone"></a> Clone\(\)

```csharp
public CMsgClientSuspended Clone()
```

#### Returns

 [CMsgClientSuspended](Divine.Protobufs.Dota2.CMsgClientSuspended.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_Equals_Divine_Protobufs_Dota2_CMsgClientSuspended_"></a> Equals\(CMsgClientSuspended\)

```csharp
public bool Equals(CMsgClientSuspended other)
```

#### Parameters

`other` [CMsgClientSuspended](Divine.Protobufs.Dota2.CMsgClientSuspended.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_MergeFrom_Divine_Protobufs_Dota2_CMsgClientSuspended_"></a> MergeFrom\(CMsgClientSuspended\)

```csharp
public void MergeFrom(CMsgClientSuspended other)
```

#### Parameters

`other` [CMsgClientSuspended](Divine.Protobufs.Dota2.CMsgClientSuspended.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientSuspended_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

