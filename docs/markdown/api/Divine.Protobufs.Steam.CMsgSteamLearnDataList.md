# <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList"></a> Class CMsgSteamLearnDataList

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnDataList : IMessage<CMsgSteamLearnDataList>, IEquatable<CMsgSteamLearnDataList>, IDeepCloneable<CMsgSteamLearnDataList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnDataList](Divine.Protobufs.Steam.CMsgSteamLearnDataList.md)

#### Implements

IMessage<CMsgSteamLearnDataList\>, 
[IEquatable<CMsgSteamLearnDataList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnDataList\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnDataList\>\(CMsgSteamLearnDataList, params CMsgSteamLearnDataList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList__ctor"></a> CMsgSteamLearnDataList\(\)

```csharp
public CMsgSteamLearnDataList()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList__ctor_Divine_Protobufs_Steam_CMsgSteamLearnDataList_"></a> CMsgSteamLearnDataList\(CMsgSteamLearnDataList\)

```csharp
public CMsgSteamLearnDataList(CMsgSteamLearnDataList other)
```

#### Parameters

`other` [CMsgSteamLearnDataList](Divine.Protobufs.Steam.CMsgSteamLearnDataList.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList_Data"></a> Data

```csharp
public RepeatedField<CMsgSteamLearnData> Data { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearnData](Divine.Protobufs.Steam.CMsgSteamLearnData.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnDataList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnDataList](Divine.Protobufs.Steam.CMsgSteamLearnDataList.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnDataList Clone()
```

#### Returns

 [CMsgSteamLearnDataList](Divine.Protobufs.Steam.CMsgSteamLearnDataList.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList_Equals_Divine_Protobufs_Steam_CMsgSteamLearnDataList_"></a> Equals\(CMsgSteamLearnDataList\)

```csharp
public bool Equals(CMsgSteamLearnDataList other)
```

#### Parameters

`other` [CMsgSteamLearnDataList](Divine.Protobufs.Steam.CMsgSteamLearnDataList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearnDataList_"></a> MergeFrom\(CMsgSteamLearnDataList\)

```csharp
public void MergeFrom(CMsgSteamLearnDataList other)
```

#### Parameters

`other` [CMsgSteamLearnDataList](Divine.Protobufs.Steam.CMsgSteamLearnDataList.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

