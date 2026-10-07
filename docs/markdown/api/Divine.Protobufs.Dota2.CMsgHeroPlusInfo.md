# <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo"></a> Class CMsgHeroPlusInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgHeroPlusInfo : IMessage<CMsgHeroPlusInfo>, IEquatable<CMsgHeroPlusInfo>, IDeepCloneable<CMsgHeroPlusInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgHeroPlusInfo](Divine.Protobufs.Dota2.CMsgHeroPlusInfo.md)

#### Implements

IMessage<CMsgHeroPlusInfo\>, 
[IEquatable<CMsgHeroPlusInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgHeroPlusInfo\>, 
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
[EnumerableExtensions.In<CMsgHeroPlusInfo\>\(CMsgHeroPlusInfo, params CMsgHeroPlusInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo__ctor"></a> CMsgHeroPlusInfo\(\)

```csharp
public CMsgHeroPlusInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo__ctor_Divine_Protobufs_Dota2_CMsgHeroPlusInfo_"></a> CMsgHeroPlusInfo\(CMsgHeroPlusInfo\)

```csharp
public CMsgHeroPlusInfo(CMsgHeroPlusInfo other)
```

#### Parameters

`other` [CMsgHeroPlusInfo](Divine.Protobufs.Dota2.CMsgHeroPlusInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgHeroPlusInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgHeroPlusInfo](Divine.Protobufs.Dota2.CMsgHeroPlusInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_Clone"></a> Clone\(\)

```csharp
public CMsgHeroPlusInfo Clone()
```

#### Returns

 [CMsgHeroPlusInfo](Divine.Protobufs.Dota2.CMsgHeroPlusInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_Equals_Divine_Protobufs_Dota2_CMsgHeroPlusInfo_"></a> Equals\(CMsgHeroPlusInfo\)

```csharp
public bool Equals(CMsgHeroPlusInfo other)
```

#### Parameters

`other` [CMsgHeroPlusInfo](Divine.Protobufs.Dota2.CMsgHeroPlusInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgHeroPlusInfo_"></a> MergeFrom\(CMsgHeroPlusInfo\)

```csharp
public void MergeFrom(CMsgHeroPlusInfo other)
```

#### Parameters

`other` [CMsgHeroPlusInfo](Divine.Protobufs.Dota2.CMsgHeroPlusInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgHeroPlusInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

