# <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments"></a> Class CMsgPlayerHeroRecentAccomplishments

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPlayerHeroRecentAccomplishments : IMessage<CMsgPlayerHeroRecentAccomplishments>, IEquatable<CMsgPlayerHeroRecentAccomplishments>, IDeepCloneable<CMsgPlayerHeroRecentAccomplishments>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPlayerHeroRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerHeroRecentAccomplishments.md)

#### Implements

IMessage<CMsgPlayerHeroRecentAccomplishments\>, 
[IEquatable<CMsgPlayerHeroRecentAccomplishments\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPlayerHeroRecentAccomplishments\>, 
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
[EnumerableExtensions.In<CMsgPlayerHeroRecentAccomplishments\>\(CMsgPlayerHeroRecentAccomplishments, params CMsgPlayerHeroRecentAccomplishments\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments__ctor"></a> CMsgPlayerHeroRecentAccomplishments\(\)

```csharp
public CMsgPlayerHeroRecentAccomplishments()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments__ctor_Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_"></a> CMsgPlayerHeroRecentAccomplishments\(CMsgPlayerHeroRecentAccomplishments\)

```csharp
public CMsgPlayerHeroRecentAccomplishments(CMsgPlayerHeroRecentAccomplishments other)
```

#### Parameters

`other` [CMsgPlayerHeroRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerHeroRecentAccomplishments.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_LastMatchFieldNumber"></a> LastMatchFieldNumber

```csharp
public const int LastMatchFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_RecentOutcomesFieldNumber"></a> RecentOutcomesFieldNumber

```csharp
public const int RecentOutcomesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_TotalRecordFieldNumber"></a> TotalRecordFieldNumber

```csharp
public const int TotalRecordFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_LastMatch"></a> LastMatch

```csharp
public CMsgPlayerRecentMatchInfo LastMatch { get; set; }
```

#### Property Value

 [CMsgPlayerRecentMatchInfo](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPlayerHeroRecentAccomplishments> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPlayerHeroRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerHeroRecentAccomplishments.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_RecentOutcomes"></a> RecentOutcomes

```csharp
public CMsgPlayerRecentMatchOutcomes RecentOutcomes { get; set; }
```

#### Property Value

 [CMsgPlayerRecentMatchOutcomes](Divine.Protobufs.Dota2.CMsgPlayerRecentMatchOutcomes.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_TotalRecord"></a> TotalRecord

```csharp
public CMsgPlayerMatchRecord TotalRecord { get; set; }
```

#### Property Value

 [CMsgPlayerMatchRecord](Divine.Protobufs.Dota2.CMsgPlayerMatchRecord.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_Clone"></a> Clone\(\)

```csharp
public CMsgPlayerHeroRecentAccomplishments Clone()
```

#### Returns

 [CMsgPlayerHeroRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerHeroRecentAccomplishments.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_Equals_Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_"></a> Equals\(CMsgPlayerHeroRecentAccomplishments\)

```csharp
public bool Equals(CMsgPlayerHeroRecentAccomplishments other)
```

#### Parameters

`other` [CMsgPlayerHeroRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerHeroRecentAccomplishments.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_MergeFrom_Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_"></a> MergeFrom\(CMsgPlayerHeroRecentAccomplishments\)

```csharp
public void MergeFrom(CMsgPlayerHeroRecentAccomplishments other)
```

#### Parameters

`other` [CMsgPlayerHeroRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerHeroRecentAccomplishments.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerHeroRecentAccomplishments_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

