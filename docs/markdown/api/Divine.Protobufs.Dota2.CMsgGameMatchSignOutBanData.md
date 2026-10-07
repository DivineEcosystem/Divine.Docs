# <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData"></a> Class CMsgGameMatchSignOutBanData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameMatchSignOutBanData : IMessage<CMsgGameMatchSignOutBanData>, IEquatable<CMsgGameMatchSignOutBanData>, IDeepCloneable<CMsgGameMatchSignOutBanData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameMatchSignOutBanData](Divine.Protobufs.Dota2.CMsgGameMatchSignOutBanData.md)

#### Implements

IMessage<CMsgGameMatchSignOutBanData\>, 
[IEquatable<CMsgGameMatchSignOutBanData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameMatchSignOutBanData\>, 
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
[EnumerableExtensions.In<CMsgGameMatchSignOutBanData\>\(CMsgGameMatchSignOutBanData, params CMsgGameMatchSignOutBanData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData__ctor"></a> CMsgGameMatchSignOutBanData\(\)

```csharp
public CMsgGameMatchSignOutBanData()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData__ctor_Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_"></a> CMsgGameMatchSignOutBanData\(CMsgGameMatchSignOutBanData\)

```csharp
public CMsgGameMatchSignOutBanData(CMsgGameMatchSignOutBanData other)
```

#### Parameters

`other` [CMsgGameMatchSignOutBanData](Divine.Protobufs.Dota2.CMsgGameMatchSignOutBanData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_HeroBansFieldNumber"></a> HeroBansFieldNumber

```csharp
public const int HeroBansFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_HeroBanVotesFieldNumber"></a> HeroBanVotesFieldNumber

```csharp
public const int HeroBanVotesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_HeroBans"></a> HeroBans

```csharp
public RepeatedField<int> HeroBans { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_HeroBanVotes"></a> HeroBanVotes

```csharp
public RepeatedField<int> HeroBanVotes { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameMatchSignOutBanData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameMatchSignOutBanData](Divine.Protobufs.Dota2.CMsgGameMatchSignOutBanData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_Clone"></a> Clone\(\)

```csharp
public CMsgGameMatchSignOutBanData Clone()
```

#### Returns

 [CMsgGameMatchSignOutBanData](Divine.Protobufs.Dota2.CMsgGameMatchSignOutBanData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_Equals_Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_"></a> Equals\(CMsgGameMatchSignOutBanData\)

```csharp
public bool Equals(CMsgGameMatchSignOutBanData other)
```

#### Parameters

`other` [CMsgGameMatchSignOutBanData](Divine.Protobufs.Dota2.CMsgGameMatchSignOutBanData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_MergeFrom_Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_"></a> MergeFrom\(CMsgGameMatchSignOutBanData\)

```csharp
public void MergeFrom(CMsgGameMatchSignOutBanData other)
```

#### Parameters

`other` [CMsgGameMatchSignOutBanData](Divine.Protobufs.Dota2.CMsgGameMatchSignOutBanData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutBanData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

