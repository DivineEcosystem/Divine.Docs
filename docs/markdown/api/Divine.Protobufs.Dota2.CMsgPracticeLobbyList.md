# <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList"></a> Class CMsgPracticeLobbyList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPracticeLobbyList : IMessage<CMsgPracticeLobbyList>, IEquatable<CMsgPracticeLobbyList>, IDeepCloneable<CMsgPracticeLobbyList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPracticeLobbyList](Divine.Protobufs.Dota2.CMsgPracticeLobbyList.md)

#### Implements

IMessage<CMsgPracticeLobbyList\>, 
[IEquatable<CMsgPracticeLobbyList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPracticeLobbyList\>, 
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
[EnumerableExtensions.In<CMsgPracticeLobbyList\>\(CMsgPracticeLobbyList, params CMsgPracticeLobbyList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList__ctor"></a> CMsgPracticeLobbyList\(\)

```csharp
public CMsgPracticeLobbyList()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList__ctor_Divine_Protobufs_Dota2_CMsgPracticeLobbyList_"></a> CMsgPracticeLobbyList\(CMsgPracticeLobbyList\)

```csharp
public CMsgPracticeLobbyList(CMsgPracticeLobbyList other)
```

#### Parameters

`other` [CMsgPracticeLobbyList](Divine.Protobufs.Dota2.CMsgPracticeLobbyList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_GameModeFieldNumber"></a> GameModeFieldNumber

```csharp
public const int GameModeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_PassKeyFieldNumber"></a> PassKeyFieldNumber

```csharp
public const int PassKeyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_RegionFieldNumber"></a> RegionFieldNumber

```csharp
public const int RegionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_GameMode"></a> GameMode

```csharp
public DOTA_GameMode GameMode { get; set; }
```

#### Property Value

 [DOTA\_GameMode](Divine.Protobufs.Dota2.DOTA\_GameMode.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_HasGameMode"></a> HasGameMode

```csharp
public bool HasGameMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_HasPassKey"></a> HasPassKey

```csharp
public bool HasPassKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_HasRegion"></a> HasRegion

```csharp
public bool HasRegion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPracticeLobbyList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPracticeLobbyList](Divine.Protobufs.Dota2.CMsgPracticeLobbyList.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_PassKey"></a> PassKey

```csharp
public string PassKey { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_Region"></a> Region

```csharp
public uint Region { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_ClearGameMode"></a> ClearGameMode\(\)

```csharp
public void ClearGameMode()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_ClearPassKey"></a> ClearPassKey\(\)

```csharp
public void ClearPassKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_ClearRegion"></a> ClearRegion\(\)

```csharp
public void ClearRegion()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_Clone"></a> Clone\(\)

```csharp
public CMsgPracticeLobbyList Clone()
```

#### Returns

 [CMsgPracticeLobbyList](Divine.Protobufs.Dota2.CMsgPracticeLobbyList.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_Equals_Divine_Protobufs_Dota2_CMsgPracticeLobbyList_"></a> Equals\(CMsgPracticeLobbyList\)

```csharp
public bool Equals(CMsgPracticeLobbyList other)
```

#### Parameters

`other` [CMsgPracticeLobbyList](Divine.Protobufs.Dota2.CMsgPracticeLobbyList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_MergeFrom_Divine_Protobufs_Dota2_CMsgPracticeLobbyList_"></a> MergeFrom\(CMsgPracticeLobbyList\)

```csharp
public void MergeFrom(CMsgPracticeLobbyList other)
```

#### Parameters

`other` [CMsgPracticeLobbyList](Divine.Protobufs.Dota2.CMsgPracticeLobbyList.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbyList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

